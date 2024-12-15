Imports System.Resources
Imports MySql.Data.MySqlClient

Public Class FormSaveBook
    Private MainForm As FormMain

    Private ConnectionString As String
    Public ImageLocation As String

    Property BookId As Integer

    Public Sub New(connection As String, form As FormMain)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MainForm = form

        ConnectionString = connection
        ImageLocation = ""

        BookId = -1

        Dim SqlConnection As New MySqlConnection(ConnectionString)

        Try
            SqlConnection.Open()

            Dim Command As New MySqlCommand("SELECT Name FROM Genres", SqlConnection)
            Dim Reader = Command.ExecuteReader

            Genre_ComboBox.Items.Clear()

            While Reader.Read
                Dim genre = Reader.GetString("Name")
                Genre_ComboBox.Items.Add(genre)
            End While

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show("Connection not found. Make sure that MySQL is open and running.")
        End Try
    End Sub

    Private Sub BookCover_PictureBox_Click(sender As Object, e As EventArgs) Handles BookCover_PictureBox.Click
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Title = "Select a Book Cover"
        OpenFD.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFD.ShowDialog()

        Dim ImagePath = OpenFD.FileName

        Try
            BookCover_PictureBox.Image = Image.FromFile(ImagePath)
            ImageLocation = ImagePath
        Catch ex As Exception
        Finally
            BookCover_PictureBox.Refresh()
        End Try
    End Sub

    Private Sub ClearAll_Button_Click_1(sender As Object, e As EventArgs) Handles ClearAll_Button.Click
        Title_TextBox.Text = ""
        Author_TextBox.Text = ""
        Genre_ComboBox.ResetText()
        BookDatePublished.Value = DateTime.Now()
        Summary_TextBox.Text = ""
        BookCover_PictureBox.Image = Nothing
    End Sub

    Private Sub SaveBook_Button_Click(sender As Object, e As EventArgs) Handles AddBook_Button.Click
        If BookId >= 0 Then
            UpdateBook()
        Else
            AddBook()
        End If

        MainForm.LoadBooks()
    End Sub

    Private Sub AddBook()
        Dim SqlConnection = New MySqlConnection(ConnectionString)

        Dim Title = Title_TextBox.Text
        Dim Author = If(Author_TextBox.Text <> "", Author_TextBox.Text, "Unnamed")
        Dim Summary = Summary_TextBox.Text
        Dim Genre = Genre_ComboBox.Text
        Dim DatePublished = BookDatePublished.Value 'Check if it requires a default value

        If Title = "" Then
            MessageBox.Show("Title field required")
            Return
        ElseIf Genre_ComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Genre field required")
            Return
        End If

        Try
            SqlConnection.Open()

            Dim Query = $"INSERT INTO Books(Title, ImagePath, Author, Genre, DatePublished, Summary) Values (@Title, @ImagePath, @Author, @Genre, @DatePublished, @Summary)"
            Dim Command = New MySqlCommand(Query, SqlConnection)

            Command.Parameters.AddWithValue("@Title", Title)
            Command.Parameters.AddWithValue("@ImagePath", ImageLocation)
            Command.Parameters.AddWithValue("@Author", Author)
            Command.Parameters.AddWithValue("@Genre", Genre)
            Command.Parameters.AddWithValue("@DatePublished", DatePublished)
            Command.Parameters.AddWithValue("@Summary", Summary)

            Command.ExecuteReader()

            SqlConnection.Close()
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UpdateBook()
        Dim SqlConnection = New MySqlConnection(ConnectionString)

        Dim Title = Title_TextBox.Text
        Dim Author = If(Author_TextBox.Text <> "", Author_TextBox.Text, "Unnamed")
        Dim Summary = Summary_TextBox.Text
        Dim Genre = Genre_ComboBox.Text
        Dim DatePublished = BookDatePublished.Value 'Check if it requires a default value

        If Title = "" Then
            MessageBox.Show("Title field required")
            Return
        ElseIf Genre_ComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Genre field required")
            Return
        End If

        Try
            SqlConnection.Open()

            Dim Query = $"UPDATE Books SET Title = @Title, ImagePath = @ImagePath, Author = @Author, Genre = @Genre, DatePublished = @DatePublished, Summary = @Summary WHERE Id = @Id"
            Dim Command = New MySqlCommand(Query, SqlConnection)

            Command.Parameters.AddWithValue("@Id", BookId)
            Command.Parameters.AddWithValue("@Title", Title)
            Command.Parameters.AddWithValue("@ImagePath", ImageLocation)
            Command.Parameters.AddWithValue("@Author", Author)
            Command.Parameters.AddWithValue("@Genre", Genre)
            Command.Parameters.AddWithValue("@DatePublished", DatePublished)
            Command.Parameters.AddWithValue("@Summary", Summary)

            Command.ExecuteReader()

            SqlConnection.Close()
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class


