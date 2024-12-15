Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Book
    Private MainForm As FormMain
    Private Id As Integer

    Public Sub New(Form As FormMain, Id As Integer, Title As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Id = Id
        LabelTitle.Text = Title
        MainForm = Form

        For Each c As Control In PanelBook.Controls
            AddHandler c.Click, AddressOf LoadBookDetails

            AddHandler c.MouseHover, AddressOf AddBorder
            AddHandler c.MouseLeave, AddressOf RemoveBorder
        Next

    End Sub

    Public Sub New(Form As FormMain, Id As Integer, Title As String, ImageLocation As String)

        Me.New(Form, Id, Title)

        Try
            PictureBoxCover.Image = Image.FromFile(ImageLocation)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub AddBorder()

        PanelBook.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub RemoveBorder()

        PanelBook.BorderStyle = BorderStyle.None

    End Sub

    Private Sub LoadBookDetails(sender As Object, e As MouseEventArgs)
        Dim Chapters As New DataTable

        Using SqlConnection As New MySqlConnection(MainForm.ConnectionString)
            SqlConnection.Open()

            Dim Command As New MySqlCommand("SELECT * FROM Books WHERE Id = @Id", SqlConnection)
            Command.Parameters.AddWithValue("@Id", Id)

            Dim QueryChapters As New MySqlCommand("SELECT ChapterNumber AS Chapter, Title FROM Chapters WHERE BookId = @Id ORDER BY Chapter", SqlConnection)
            QueryChapters.Parameters.AddWithValue("@Id", Id)

            Dim DataAdapter As New MySqlDataAdapter With {
                .SelectCommand = QueryChapters
            }

            DataAdapter.Fill(Chapters)

            Using Reader = Command.ExecuteReader
                Reader.Read()

                MainForm.LabelTitle.Text = Reader.GetString("Title")
                MainForm.LabelAuthor.Text = Reader.GetString("Author")
                MainForm.LabelSummary.Text = Reader.GetString("Summary")

                Dim ImagePath = Reader.GetString("ImagePath")

                Try
                    MainForm.PictureBoxCover.Image = Image.FromFile(ImagePath)
                Catch ex As Exception
                    Dim Resources As New ComponentResourceManager(GetType(FormMain))
                    MainForm.PictureBoxCover.Image = CType(Resources.GetObject("PictureBoxCover.Image"), Image)
                End Try
            End Using

            SqlConnection.Close()
        End Using

        MainForm.DataGridViewChapters.DataSource = Chapters

        Dim ColumnChapter = MainForm.DataGridViewChapters.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
        Dim ColumnTitle = MainForm.DataGridViewChapters.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None)

        ColumnChapter.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        ColumnChapter.SortMode = DataGridViewColumnSortMode.NotSortable
        ColumnTitle.SortMode = DataGridViewColumnSortMode.NotSortable

        MainForm.PanelDetails.Visible = True
    End Sub
End Class
