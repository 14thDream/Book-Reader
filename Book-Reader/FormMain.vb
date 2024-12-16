Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Public Class FormMain
    Public ConnectionString As String = "server=localhost;database=BookReader;userid=root"
    Public BookId As Integer
    Public SelectedChapterIndex As Integer

    Public Sub LoadBooks()
        TableLayoutPanelDashboard.Controls.Clear()

        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()
            Dim Command As New MySqlCommand("SELECT Id, Title, ImagePath FROM books", SqlConnection)

            Using Reader = Command.ExecuteReader()
                While Reader.Read
                    Dim Id = Reader.GetInt32("Id")
                    Dim Title = Reader.GetString("Title")
                    Dim ImagePath = Reader.GetString("ImagePath")

                    Dim b As New Book(Me, Id, Title, ImagePath) With {
                        .Dock = DockStyle.Fill
                    }

                    TableLayoutPanelDashboard.Controls.Add(b)
                End While
            End Using

            Dim AddButton = New AddBookButton With {
                .Dock = DockStyle.Fill
            }

            AddHandler AddButton.PictureBoxIcon.Click, AddressOf AddBook
            TableLayoutPanelDashboard.Controls.Add(AddButton)

            SqlConnection.Close()
        End Using
    End Sub

    Public Sub LoadChapters(id As Integer)
        Dim Chapters As New DataTable

        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()

            Dim QueryChapters As New MySqlCommand("SELECT ChapterNumber AS Chapter, Title FROM Chapters WHERE BookId = @Id ORDER BY Chapter", SqlConnection)
            QueryChapters.Parameters.AddWithValue("@Id", id)

            Dim DataAdapter As New MySqlDataAdapter With {
                .SelectCommand = QueryChapters
            }

            DataAdapter.Fill(Chapters)

            SqlConnection.Close()
        End Using

        DataGridViewChapters.DataSource = Chapters

        Dim ColumnChapter = DataGridViewChapters.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        Dim ColumnTitle = DataGridViewChapters.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None)

        ColumnChapter.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        ColumnChapter.SortMode = DataGridViewColumnSortMode.NotSortable
        ColumnTitle.SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBooks()
    End Sub


    Private Sub ButtonBackDetails_Click(sender As Object, e As EventArgs) Handles ButtonBackDetails.Click
        PanelDetails.Visible = False
    End Sub

    Private Sub AddBook(sender As Object, e As EventArgs)
        Dim AddBookForm As New FormSaveBook(ConnectionString, Me)
        AddBookForm.Show()
    End Sub

    Private Sub ButtonAddChapter_Click(sender As Object, e As EventArgs) Handles ButtonAddChapter.Click
        Dim LastIndex = DataGridViewChapters.Rows.GetLastRow(DataGridViewElementStates.Visible)
        Dim ChapterNumber = 0

        If DataGridViewChapters.RowCount > 0 Then
            Dim Row = DataGridViewChapters.Rows(LastIndex)
            ChapterNumber = Row.Cells("Chapter").Value
        End If

        Dim SaveChapterForm As New FormSaveChapter(Me, BookId, ChapterNumber)
        SaveChapterForm.Show()
    End Sub

    Private Sub DataGridViewChapters_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewChapters.CellContentClick
        SelectedChapterIndex = e.RowIndex
    End Sub

    Private Sub EditChapter_Button_Click(sender As Object, e As EventArgs) Handles EditChapter_Button.Click
        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()
            Dim Command As New MySqlCommand("SELECT Title FROM CHAPTERS WHERE Id = @Id", SqlConnection)
            Command.Parameters.AddWithValue("@Id", SelectedChapterIndex + 1)
            Using Reader = Command.ExecuteReader()
                While Reader.Read
                    Dim Title = Reader.GetString("Title")
                    MessageBox.Show($"Selected Chapter Right Now: {Title}")
                End While
            End Using
            SqlConnection.Close()
        End Using
    End Sub
End Class
