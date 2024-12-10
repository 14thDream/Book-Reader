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

                    AddHandler b.PanelBook.MouseClick, AddressOf Book_Click
                    For Each c As Control In b.PanelBook.Controls
                        AddHandler c.MouseClick, AddressOf Book_Click
                    Next

                    TableLayoutPanelDashboard.Controls.Add(b)
                End While
            End Using

            SqlConnection.Close()
        End Using
    End Sub

    Private Sub Book_Click(sender As Object, e As MouseEventArgs)
        PanelDetails.Visible = True
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadBooks()
    End Sub

    Private Sub ButtonBackDetails_Click(sender As Object, e As EventArgs) Handles ButtonBackDetails.Click
        PanelDetails.Visible = False
    End Sub
End Class
