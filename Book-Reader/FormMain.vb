Imports System.Drawing.Text
Imports MySql.Data.MySqlClient

Public Class FormMain
    Private ConnectionString As String = "server=localhost;database=BookReader;userid=root"

    Private Sub LoadBooks()
        TableLayoutPanelDashboard.Controls.Clear()

        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()
            Dim Command As New MySqlCommand("SELECT Id, Title, ImagePath FROM books", SqlConnection)

            Using Reader = Command.ExecuteReader()
                While Reader.Read
                    Dim Id = Reader.GetInt32("Id")
                    Dim Title = Reader.GetString("Title")
                    Dim ImagePath = Reader.GetString("ImagePath")

                    Dim b As New Book(Id, Title, ImagePath) With {
                        .Dock = DockStyle.Fill
                    }

                    Dim Book_Click = Book_Click_By_Id(Id)


                    AddHandler b.PanelBook.MouseClick, Book_Click
                    For Each c As Control In b.PanelBook.Controls
                        AddHandler c.MouseClick, Book_Click
                    Next

                    TableLayoutPanelDashboard.Controls.Add(b)
                End While
            End Using
            TableLayoutPanelDashboard.Controls.Add(New AddBookButton() With {
                    .Dock = DockStyle.Fill
                    })
            SqlConnection.Close()
        End Using
    End Sub




    Private Function Book_Click_By_Id(Id As Integer) As MouseEventHandler
        Dim Title As String
        Dim ImagePath As String
        Dim Author As String
        Dim Summary As String

        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()

            Dim Command As New MySqlCommand("SELECT * FROM books WHERE id = @Id", SqlConnection)
            Command.Parameters.AddWithValue("@Id", Id)

            Using Reader = Command.ExecuteReader
                Reader.Read()

                Title = Reader.GetString("Title")
                ImagePath = Reader.GetString("ImagePath")
                Author = Reader.GetString("Author")
                Summary = Reader.GetString("Summary")
            End Using

            SqlConnection.Close()
        End Using

        Return Sub(sender As Object, e As MouseEventArgs)
                   LabelTitle.Text = Title
                   PictureBoxCover.ImageLocation = ImagePath
                   LabelAuthor.Text = Author
                   LabelSummary.Text = Summary

                   PanelDetails.Visible = True
               End Sub
    End Function

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBooks()
    End Sub


    Private Sub ButtonBackDetails_Click(sender As Object, e As EventArgs) Handles ButtonBackDetails.Click
        PanelDetails.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelDetails_Paint(sender As Object, e As PaintEventArgs) Handles PanelDetails.Paint

    End Sub
End Class
