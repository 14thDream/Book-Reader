Imports System.IO
Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient
Public Class AddBookForm
    Dim ImagePath As String
    Private ConnectionString As String
    Private MainForm As FormMain

    Public Sub New(connection As String, form As FormMain)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ConnectionString = connection
        MainForm = form
    End Sub

    Private Sub BookCover_PictureBox_Click(sender As Object, e As EventArgs) Handles BookCover_PictureBox.Click
        Dim RootDirectory As String = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)))) + "\Images\default-cover.jpg"
        MessageBox.Show($"Root Direct{RootDirectory}")
        OpenFD.FileName = RootDirectory '"C:\Users\USer\Source\Repos\Book-Readers\Book-Reader\Images\default-cover.jpg"
        OpenFD.InitialDirectory = "C:\"
        OpenFD.Title = "Select a Book Cover"
        OpenFD.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFD.ShowDialog()
        ImagePath = OpenFD.FileName

        Try
            BookCover_PictureBox.ImageLocation = ImagePath
        Catch ex As Exception
            BookCover_PictureBox.ImageLocation = ""
        Finally
            BookCover_PictureBox.Refresh()
        End Try

        'If ImagePath is empty: Set to the directory of the default image: 
        If ImagePath = "OpenFD" OrElse ImagePath = "" Then
            OpenFD.FileName = RootDirectory '"C:\Users\USer\Source\Repos\Book-Readers\Book-Reader\Images\default-cover.jpg"
        End If
    End Sub

    Private Sub ClearAll_Button_Click_1(sender As Object, e As EventArgs) Handles ClearAll_Button.Click
        Dim RootDirectory As String = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)))) + "\Images\default-cover.jpg"
        Title_TextBox.Text = ""
        Author_TextBox.Text = ""
        Genre_ComboBox.ResetText()
        BookDatePublished.Value = DateTime.Now.Date()
        Summary_TextBox.Text = ""

        'If Clear Then Button Was Pressed, Set the directory To the Default image.
        OpenFD.InitialDirectory = "C:\"  'This is to avoid returning the previous selected image even after pressing clear.
        OpenFD.FileName = RootDirectory '"C:\Users\USer\Source\Repos\Book-Readers\Book-Reader\Images\default-cover.jpg" 'This is to avoid returning the previous selected image even after pressing clear.
        BookCover_PictureBox.ImageLocation = RootDirectory '"C:\Users\USer\Source\Repos\Book-Readers\Book-Reader\Images\default-cover.jpg"
    End Sub
    Private Sub AddBook_Button_Click_1(sender As Object, e As EventArgs) Handles AddBook_Button.Click

        Dim RootDirectory As String = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)))) + "\Images\default-cover.jpg"
        Dim SqlConnection = New MySqlConnection(ConnectionString)
        Dim Title = Title_TextBox.Text
        Dim Author = If(Author_TextBox.Text <> "", Author_TextBox.Text, "Unnamed")
        Dim Summary = Summary_TextBox.Text
        Dim Genre = Genre_ComboBox.Text
        Dim ImagePath = BookCover_PictureBox.ImageLocation
        Dim DatePublished = BookDatePublished.Value 'Check if it requires a default value

        If ImagePath = "OpenFD" OrElse ImagePath = "" Then
            ImagePath = RootDirectory '"C:\Users\USer\Source\Repos\Book-Readers\Book-Reader\Images\default-cover.jpg"
        End If

        MessageBox.Show($"ImagePath: {ImagePath}")

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
            Command.Parameters.AddWithValue("@ImagePath", ImagePath)
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
        MainForm.LoadBooks()
    End Sub
End Class