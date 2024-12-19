Imports Microsoft.VisualBasic.Logging
Imports System.Diagnostics.Eventing
Imports System.Net.Mail
Imports MySql.Data.MySqlClient
Imports Mysqlx.Prepare

Public Class FormSaveChapter
    Private MainForm As FormMain
    Private BookId As Integer
    Private ChapterNumber As Integer
    Private UpdateMode As Boolean

    Public Sub New(form As FormMain, id As Integer, chapter As Integer, isUpdate As Boolean)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        MainForm = form
        BookId = id
        ChapterNumber = chapter
        UpdateMode = isUpdate
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

    Private Sub UpdateChapter()
        Try
            Using SqlConnection As New MySqlConnection(MainForm.ConnectionString)
                SqlConnection.Open()
                Dim Command As New MySqlCommand("UPDATE Chapters SET Title = @Title, Content = @Content WHERE ChapterNumber  = @ChapterNumber", SqlConnection)
                Command.Parameters.AddWithValue("@Title", TextBoxTitle.Text)
                Command.Parameters.AddWithValue("@Content", RichTextBoxContent.Text)
                Command.Parameters.AddWithValue("@ChapterNumber", ChapterNumber)
                Command.ExecuteReader()
                SqlConnection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MainForm.LoadChapters(BookId)
        Close()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If TextBoxTitle.Text = "" OrElse RichTextBoxContent.Text = "" Then
            MessageBox.Show("Please make sure to fill out all fields.")
            Return
        End If

        If UpdateMode Then
            UpdateChapter()
            Return
        End If
        SaveChapter()
        MainForm.LoadChapters(BookId)
        Close()
    End Sub

    Private Sub TextBoxTitle_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTitle.TextChanged

    End Sub

    Private Sub RichTextBoxContent_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxContent.TextChanged

    End Sub
End Class