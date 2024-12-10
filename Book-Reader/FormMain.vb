Imports MySql.Data.MySqlClient

Public Class FormMain
    Private ConnectionString As String

    Private Sub LoadBooks()
        TableLayoutPanelDashboard.Controls.Clear()

        Using SqlConnection As New MySqlConnection(ConnectionString)
            SqlConnection.Open()
            Dim Command As New MySqlCommand("SELECT Title, ImagePath FROM books", SqlConnection)

            Using Reader = Command.ExecuteReader()
                While Reader.Read
                    Dim Title = Reader.GetString("Title")
                    Dim ImagePath = Reader.GetString("ImagePath")

                    Dim Book As New Book(Title, ImagePath) With {
                        .Dock = DockStyle.Fill
                    }

                    TableLayoutPanelDashboard.Controls.Add(Book)
                End While
            End Using

            SqlConnection.Close()
        End Using
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBooks()
    End Sub
End Class
