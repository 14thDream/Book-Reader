Public Class Book
    Public Id As Integer

    Public Sub New(Id As Integer, Title As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Id = Id
        LabelTitle.Text = Title

        For Each c As Control In PanelBook.Controls
            AddHandler c.MouseHover, AddressOf AddBorder
            AddHandler c.MouseLeave, AddressOf RemoveBorder
        Next

    End Sub

    Public Sub New(Id As Integer, Title As String, ImageLocation As String)

        Me.New(Id, Title)
        PictureBoxCover.ImageLocation = ImageLocation

    End Sub

    Private Sub AddBorder()

        PanelBook.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub RemoveBorder()

        PanelBook.BorderStyle = BorderStyle.None

    End Sub
End Class
