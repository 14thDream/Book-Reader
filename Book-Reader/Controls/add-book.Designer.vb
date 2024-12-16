<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBookButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBookButton))
        PictureBoxIcon = New PictureBox()
        CType(PictureBoxIcon, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxIcon
        ' 
        PictureBoxIcon.Anchor = AnchorStyles.None
        PictureBoxIcon.Image = CType(resources.GetObject("PictureBoxIcon.Image"), Image)
        PictureBoxIcon.Location = New Point(0, 0)
        PictureBoxIcon.Name = "PictureBoxIcon"
        PictureBoxIcon.Size = New Size(84, 85)
        PictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxIcon.TabIndex = 0
        PictureBoxIcon.TabStop = False
        ' 
        ' AddBookButton
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBoxIcon)
        Name = "AddBookButton"
        Size = New Size(84, 85)
        CType(PictureBoxIcon, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxIcon As PictureBox

End Class
