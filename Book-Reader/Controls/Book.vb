Public Class Book
    Public Sub New(Title As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelTitle.Text = Title

    End Sub

    Public Sub New(Title As String, ImageLocation As String)

        Me.New(Title)
        PictureBoxCover.ImageLocation = ImageLocation

    End Sub
End Class
