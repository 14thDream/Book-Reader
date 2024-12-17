Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Public Class FormMain
    Public ConnectionString As String = "server=localhost;database=BookReader;userid=root"
    Public BookId As Integer
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
        Dim SaveChapterForm As New FormSaveChapter(Me, BookId, ChapterNumber, False)
        SaveChapterForm.Show()
    End Sub
    Private Sub EditChapter_Button_Click(sender As Object, e As EventArgs) Handles EditChapter_Button.Click
        Dim SelectedRow = DataGridViewChapters.CurrentRow

        If SelectedRow IsNot Nothing Then
            Try
                Dim Title = SelectedRow.Cells("Title").Value.ToString
                Using SqlConnection As New MySqlConnection(ConnectionString)
                    SqlConnection.Open()
                    Dim Command As New MySqlCommand("SELECT * FROM CHAPTERS WHERE Title = @Title", SqlConnection)
                    Command.Parameters.AddWithValue("@Title", Title)
                    Using Reader = Command.ExecuteReader
                        While Reader.Read
                            Dim ChapterNumber = Reader.GetInt32("ChapterNumber")
                            Dim SaveChapterForm As New FormSaveChapter(Me, BookId, ChapterNumber, True)
                            SaveChapterForm.Show()
                        End While
                    End Using
                    SqlConnection.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Invalid Operation! Chapter Does Not Exist!")
        End If

    End Sub

    Private Sub DeleteChapter_Button_Click(sender As Object, e As EventArgs) Handles DeleteChapter_Button.Click
        Dim SelectedRow = DataGridViewChapters.CurrentRow
        'Try'
        If SelectedRow IsNot Nothing Then
            Dim Id = SelectedRow.Cells("Id").Value
            Using SqlConnection As New MySqlConnection(ConnectionString)
                    SqlConnection.Open()
                    Dim Command As New MySqlCommand("DELETE FROM CHAPTERS WHERE Id = @ChapterId", SqlConnection)
                    Command.Parameters.AddWithValue("@ChapterId", Id)
                    Using Reader = Command.ExecuteReader
                        LoadChapters(BookId)
                    End Using
                    SqlConnection.Close()
                End Using

            Else
                MessageBox.Show("Invalid Operation! Chapter Does Not Exist!")
            End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
        RefreshChapterCount()

        ' DELETE FROM Chapters WHERE Id = @ChapterId

    End Sub

    Private Sub RefreshChapterCount()
        'For Each column As DataGridViewColumn In DataGridViewChapters.Columns
        '    MessageBox.Show(column.Name)
        'Next
        'Dim chapterColumnIndex As Integer = DataGridViewChapters.Columns("ChapterNumber").Index

        'MessageBox.Show(DataGridViewChapters.Rows(0).Cells("Chapter").Size)
        Try
            If DataGridViewChapters.CurrentRow IsNot Nothing Then
                For i As Integer = 0 To DataGridViewChapters.RowCount - 1
                    Dim CurrentChapterNumber = DataGridViewChapters.Rows(i).Cells("Chapter").Value
                    Using SqlConnection As New MySqlConnection(ConnectionString)

                        SqlConnection.Open()
                        Dim Command As New MySqlCommand("UPDATE CHAPTERS SET ChapterNumber = @NewChapterNumber WHERE BookId = @BookId AND ChapterNumber = @ChapterNumber", SqlConnection)
                        Command.Parameters.AddWithValue("@ChapterNumber", CurrentChapterNumber)
                        Command.Parameters.AddWithValue("@NewChapterNumber", i + 1)
                        Command.Parameters.AddWithValue("@BookId", BookId)
                        Command.ExecuteNonQuery()
                        SqlConnection.Close()
                    End Using
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        LoadChapters(BookId)
    End Sub
End Class
