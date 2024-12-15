<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteBookButton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeleteBookButton))
        PictureBoxDelete = New PictureBox()
        CType(PictureBoxDelete, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxDelete
        ' 
        PictureBoxDelete.Image = CType(resources.GetObject("PictureBoxDelete.Image"), Image)
        PictureBoxDelete.Location = New Point(0, 0)
        PictureBoxDelete.Name = "PictureBoxDelete"
        PictureBoxDelete.Size = New Size(12, 12)
        PictureBoxDelete.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxDelete.TabIndex = 0
        PictureBoxDelete.TabStop = False
        ' 
        ' DeleteBookButton
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBoxDelete)
        Name = "DeleteBookButton"
        Size = New Size(12, 12)
        CType(PictureBoxDelete, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxDelete As PictureBox

End Class
