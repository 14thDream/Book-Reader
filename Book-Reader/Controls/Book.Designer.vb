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
        PictureBoxCover = New PictureBox()
        LabelTitle = New Label()
        CType(PictureBoxCover, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxCover
        ' 
        PictureBoxCover.Location = New Point(0, 0)
        PictureBoxCover.Name = "PictureBoxCover"
        PictureBoxCover.Size = New Size(80, 128)
        PictureBoxCover.TabIndex = 0
        PictureBoxCover.TabStop = False
        ' 
        ' LabelTitle
        ' 
        LabelTitle.Location = New Point(0, 127)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(80, 23)
        LabelTitle.TabIndex = 1
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Book
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(LabelTitle)
        Controls.Add(PictureBoxCover)
        Name = "Book"
        Size = New Size(79, 150)
        CType(PictureBoxCover, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxCover As PictureBox
    Friend WithEvents LabelTitle As Label

End Class
