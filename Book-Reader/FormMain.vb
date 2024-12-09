Imports MySql.Data.MySqlClient

Public Class FormMain

    Private SqlConnection As MySqlConnection

    Private Sub LoadBooks()

        TableLayoutPanelDashboard.Controls.Clear()

        Dim command As New MySqlCommand("SELECT Title, ImagePath FROM books", SqlConnection)
        Using reader As MySqlDataReader = command.ExecuteReader

            While reader.Read

                Dim book As New Book(reader.GetString("Title"), reader.GetString("ImagePath")) With {
                    .Dock = DockStyle.Fill
                }

                TableLayoutPanelDashboard.Controls.Add(book)

            End While

        End Using

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        LoadBooks()

    End Sub

End Class
