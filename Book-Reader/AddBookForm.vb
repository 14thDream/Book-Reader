Imports MySql.Data.MySqlClient

Public Class AddBookForm

    Dim MySqlConn As MySqlConnection
    Dim Reader As MySqlDataReader
    Dim Command As MySqlCommand
    Dim Query As String

    Dim Current_DB As String = "insert-database-name-here"
    Dim Table_Name As String = "insert-table-name-here"

    Dim Title As String
    Dim ImagePath As String

    Private Sub AddBook_Button_Click(sender As Object, e As EventArgs) Handles AddBook_Button.Click

        MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
        'Add nalang Logic for connecting to Database and Performing The Query

        Try
            MySqlConn.Open()
            MessageBox.Show($"Connection To MySql Database ({Current_DB}) Successfully Established!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Query = $"insert into {Current_DB}.{Table_Name} (fields) values()...."
        Command = New MySqlCommand(Query, MySqlConn)

        Try
            MessageBox.Show($"Book Added Successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ClearAll_Button_Click(sender As Object, e As EventArgs) Handles ClearAll_Button.Click
        Title_TextBox.Text = ""
    End Sub












End Class


