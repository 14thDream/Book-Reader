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

End Class
