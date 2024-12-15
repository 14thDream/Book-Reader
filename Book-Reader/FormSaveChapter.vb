Imports MySql.Data.MySqlClient

Public Class FormSaveChapter
    Private MainForm As FormMain
    Private BookId As Integer
    Private ChapterNumber As Integer

    Public Sub New(form As FormMain, id As Integer, chapter As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MainForm = form
        BookId = id
        ChapterNumber = chapter
    End Sub

    Private Sub SaveChapter()
        Using SqlConnection As New MySqlConnection(MainForm.ConnectionString)
            SqlConnection.Open()

            Dim Query = "INSERT INTO Chapters (BookId, ChapterNumber, Title, Content) VALUES (@Id, @Chapter, @Title, @Content);"
            Dim Command As New MySqlCommand(Query, SqlConnection)

            Command.Parameters.AddWithValue("@Id", BookId)
            Command.Parameters.AddWithValue("@Chapter", ChapterNumber + 1)
            Command.Parameters.AddWithValue("@Title", TextBoxTitle.Text)
            Command.Parameters.AddWithValue("@Content", RichTextBoxContent.Text)

            Command.ExecuteReader()

            SqlConnection.Close()
        End Using
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If TextBoxTitle.Text = "" OrElse RichTextBoxContent.Text = "" Then
            MessageBox.Show("Please make sure to fill out all fields.")
            Return
        End If

        SaveChapter()
        Close()
    End Sub
End Class