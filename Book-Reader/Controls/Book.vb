﻿Imports System.ComponentModel
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
            AddHandler c.MouseHover, AddressOf AddBorder
            AddHandler c.MouseLeave, AddressOf RemoveBorder

            If c.GetType() = GetType(UpdateBookButton) Then
                AddHandler CType(c, UpdateBookButton).PictureBoxEdit.Click, AddressOf ShowUpdateBookForm
            ElseIf c.GetType() = GetType(DeleteBookButton) Then
                AddHandler CType(c, DeleteBookButton).PictureBoxDelete.Click, AddressOf DeleteBook
            Else
                AddHandler c.Click, AddressOf LoadBookDetails
            End If
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
        Using SqlConnection As New MySqlConnection(MainForm.ConnectionString)
            SqlConnection.Open()

            Dim Command As New MySqlCommand("SELECT * FROM Books WHERE Id = @Id", SqlConnection)
            Command.Parameters.AddWithValue("@Id", Id)

            Using Reader = Command.ExecuteReader
                Reader.Read()

                MainForm.LabelTitle.Text = Reader.GetString("Title")
                MainForm.LabelAuthor.Text = Reader.GetString("Author")
                MainForm.LabelSummary.Text = Reader.GetString("Summary")
                MainForm.LabelGenre.Text = Reader.GetString("Genre")
                MainForm.LabelDatePublished.Text = Reader.GetMySqlDateTime("DatePublished").GetDateTime().ToString("MMMM dd, yyyy")

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

        MainForm.LoadChapters(Id)

        MainForm.BookId = Id
        MainForm.PanelDetails.Visible = True
    End Sub

    Private Sub ShowUpdateBookForm(sender As Object, e As EventArgs)
        Dim FormEditBook As New FormSaveBook(MainForm.ConnectionString, MainForm) With {
            .BookId = Id
        }

        Using SqlConnection As New MySqlConnection(MainForm.ConnectionString)
            SqlConnection.Open()

            Dim Command As New MySqlCommand("SELECT * FROM Books WHERE Id = @Id", SqlConnection)
            Command.Parameters.AddWithValue("@Id", Id)

            Dim Reader = Command.ExecuteReader()
            Reader.Read()

            FormEditBook.Title_TextBox.Text = Reader.GetString("Title")
            FormEditBook.Author_TextBox.Text = Reader.GetString("Author")
            FormEditBook.Summary_TextBox.Text = Reader.GetString("Summary")
            FormEditBook.BookDatePublished.Value = Reader.GetMySqlDateTime("DatePublished")

            Dim Genre = Reader.GetString("Genre")
            FormEditBook.Genre_ComboBox.Text = Genre
            FormEditBook.Genre_ComboBox.SelectedIndex = FormEditBook.Genre_ComboBox.Items.IndexOf(Genre)

            Dim ImageLocation = Reader.GetString("ImagePath")

            Try
                FormEditBook.BookCover_PictureBox.Image = Image.FromFile(ImageLocation)
                FormEditBook.ImageLocation = ImageLocation
            Catch ex As Exception
                Dim Resources As New ComponentResourceManager(GetType(FormMain))
                FormEditBook.BookCover_PictureBox.Image = CType(Resources.GetObject("PictureBoxCover.Image"), Image)
            End Try

            SqlConnection.Close()
        End Using

        FormEditBook.Show()
    End Sub

    Private Sub DeleteBook()
        Using SqlConnection As New MySqlConnection(MainForm.ConnectionString)
            SqlConnection.Open()

            Dim Command As New MySqlCommand("DELETE FROM Books WHERE Id = @Id", SqlConnection)
            Command.Parameters.AddWithValue("@Id", Id)

            Command.ExecuteReader()

            SqlConnection.Close()
        End Using

        MainForm.LoadBooks()
    End Sub
End Class
