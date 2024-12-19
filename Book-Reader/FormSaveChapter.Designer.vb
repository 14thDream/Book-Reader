<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSaveChapter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        TextBoxTitle = New TextBox()
        RichTextBoxContent = New RichTextBox()
        ButtonSave = New Button()
        SuspendLayout()
        ' 
        ' TextBoxTitle
        ' 
        TextBoxTitle.BorderStyle = BorderStyle.FixedSingle
        TextBoxTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBoxTitle.Location = New Point(213, 27)
        TextBoxTitle.Name = "TextBoxTitle"
        TextBoxTitle.PlaceholderText = "Title"
        TextBoxTitle.Size = New Size(373, 23)
        TextBoxTitle.TabIndex = 0
        TextBoxTitle.TextAlign = HorizontalAlignment.Center
        ' 
        ' RichTextBoxContent
        ' 
        RichTextBoxContent.BackColor = Color.White
        RichTextBoxContent.Location = New Point(27, 71)
        RichTextBoxContent.Name = "RichTextBoxContent"
        RichTextBoxContent.Size = New Size(746, 320)
        RichTextBoxContent.TabIndex = 2
        RichTextBoxContent.Text = ""
        ' 
        ' ButtonSave
        ' 
        ButtonSave.AutoSize = True
        ButtonSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSave.Location = New Point(682, 397)
        ButtonSave.Name = "ButtonSave"
        ButtonSave.Size = New Size(91, 25)
        ButtonSave.TabIndex = 3
        ButtonSave.Text = "Save Chapter"
        ButtonSave.UseVisualStyleBackColor = True
        ' 
        ' FormSaveChapter
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonSave)
        Controls.Add(RichTextBoxContent)
        Controls.Add(TextBoxTitle)
        Name = "FormSaveChapter"
        Text = "Save Chapter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxTitle As TextBox
    Friend WithEvents RichTextBoxContent As RichTextBox
    Friend WithEvents ButtonSave As Button
End Class
