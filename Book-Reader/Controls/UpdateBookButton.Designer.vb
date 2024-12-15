<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBookButton
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateBookButton))
        PictureBoxEdit = New PictureBox()
        CType(PictureBoxEdit, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxEdit
        ' 
        PictureBoxEdit.Image = CType(resources.GetObject("PictureBoxEdit.Image"), Image)
        PictureBoxEdit.Location = New Point(0, 0)
        PictureBoxEdit.Name = "PictureBoxEdit"
        PictureBoxEdit.Size = New Size(12, 12)
        PictureBoxEdit.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxEdit.TabIndex = 3
        PictureBoxEdit.TabStop = False
        ' 
        ' UpdateBookButton
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        Controls.Add(PictureBoxEdit)
        Name = "UpdateBookButton"
        Size = New Size(12, 12)
        CType(PictureBoxEdit, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBoxEdit As PictureBox

End Class
