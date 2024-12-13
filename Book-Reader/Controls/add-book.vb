Public Class AddBookButton
    Private Sub PictureBoxIcon_Click(sender As Object, e As EventArgs) Handles PictureBoxIcon.Click
        Dim AddBookForm As New AddBookForm
        AddBookForm.Show()
    End Sub
End Class
