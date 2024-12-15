<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Book))
        PictureBoxCover = New PictureBox()
        LabelTitle = New Label()
        PanelBook = New Panel()
        UpdateBookButton1 = New UpdateBookButton()
        CType(PictureBoxCover, ComponentModel.ISupportInitialize).BeginInit()
        PanelBook.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBoxCover
        ' 
        PictureBoxCover.Image = CType(resources.GetObject("PictureBoxCover.Image"), Image)
        PictureBoxCover.Location = New Point(13, 10)
        PictureBoxCover.Name = "PictureBoxCover"
        PictureBoxCover.Size = New Size(80, 128)
        PictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxCover.TabIndex = 0
        PictureBoxCover.TabStop = False
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoEllipsis = True
        LabelTitle.Location = New Point(13, 145)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(80, 23)
        LabelTitle.TabIndex = 1
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelBook
        ' 
        PanelBook.Anchor = AnchorStyles.None
        PanelBook.BackColor = SystemColors.Control
        PanelBook.Controls.Add(UpdateBookButton1)
        PanelBook.Controls.Add(LabelTitle)
        PanelBook.Controls.Add(PictureBoxCover)
        PanelBook.Location = New Point(76, 67)
        PanelBook.Name = "PanelBook"
        PanelBook.Padding = New Padding(16)
        PanelBook.Size = New Size(106, 173)
        PanelBook.TabIndex = 2
        ' 
        ' UpdateBookButton1
        ' 
        UpdateBookButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        UpdateBookButton1.Location = New Point(0, 10)
        UpdateBookButton1.Name = "UpdateBookButton1"
        UpdateBookButton1.Size = New Size(12, 12)
        UpdateBookButton1.TabIndex = 3
        ' 
        ' Book
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PanelBook)
        Name = "Book"
        Size = New Size(271, 318)
        CType(PictureBoxCover, ComponentModel.ISupportInitialize).EndInit()
        PanelBook.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxCover As PictureBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PanelBook As Panel
    Friend WithEvents UpdateBookButton1 As UpdateBookButton

End Class
