Public Class AddBookButton
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("You Pressed Me!")
        Dim AddBookForm As New AddBookForm
        AddBookForm.Show()
    End Sub
End Class
