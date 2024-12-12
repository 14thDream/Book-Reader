<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBookForm
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
        OpenFD = New OpenFileDialog()
        Panel2 = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        BookCover_PictureBox = New PictureBox()
        ClearAll_Button = New Button()
        AddBook_Button = New Button()
        Author_TextBox = New TextBox()
        Title_TextBox = New TextBox()
        Author_Label = New Label()
        Title_Label = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        CType(BookCover_PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' OpenFD
        ' 
        OpenFD.FileName = "OpenFD"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(BookCover_PictureBox)
        Panel2.Controls.Add(ClearAll_Button)
        Panel2.Controls.Add(AddBook_Button)
        Panel2.Controls.Add(Author_TextBox)
        Panel2.Controls.Add(Title_TextBox)
        Panel2.Controls.Add(Author_Label)
        Panel2.Controls.Add(Title_Label)
        Panel2.Font = New Font("Segoe UI", 15F)
        Panel2.Location = New Point(16, 19)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(926, 665)
        Panel2.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(14, 13)
        Button2.Name = "Button2"
        Button2.Size = New Size(167, 31)
        Button2.TabIndex = 30
        Button2.Text = "Return to Dashboard"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(84, 177)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 53)
        Button1.TabIndex = 29
        Button1.Text = "Add Book Cover"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BookCover_PictureBox
        ' 
        BookCover_PictureBox.BackColor = Color.Transparent
        BookCover_PictureBox.BackgroundImageLayout = ImageLayout.Center
        BookCover_PictureBox.BorderStyle = BorderStyle.FixedSingle
        BookCover_PictureBox.Location = New Point(275, 177)
        BookCover_PictureBox.Name = "BookCover_PictureBox"
        BookCover_PictureBox.Size = New Size(405, 304)
        BookCover_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        BookCover_PictureBox.TabIndex = 28
        BookCover_PictureBox.TabStop = False
        ' 
        ' ClearAll_Button
        ' 
        ClearAll_Button.Location = New Point(495, 487)
        ClearAll_Button.Name = "ClearAll_Button"
        ClearAll_Button.Size = New Size(185, 65)
        ClearAll_Button.TabIndex = 27
        ClearAll_Button.Text = "Clear All"
        ClearAll_Button.UseVisualStyleBackColor = True
        ' 
        ' AddBook_Button
        ' 
        AddBook_Button.Location = New Point(275, 487)
        AddBook_Button.Name = "AddBook_Button"
        AddBook_Button.Size = New Size(185, 65)
        AddBook_Button.TabIndex = 26
        AddBook_Button.Text = "Add Book"
        AddBook_Button.UseVisualStyleBackColor = True
        ' 
        ' Author_TextBox
        ' 
        Author_TextBox.Location = New Point(275, 128)
        Author_TextBox.Multiline = True
        Author_TextBox.Name = "Author_TextBox"
        Author_TextBox.Size = New Size(405, 35)
        Author_TextBox.TabIndex = 21
        ' 
        ' Title_TextBox
        ' 
        Title_TextBox.Location = New Point(275, 81)
        Title_TextBox.Multiline = True
        Title_TextBox.Name = "Title_TextBox"
        Title_TextBox.Size = New Size(405, 35)
        Title_TextBox.TabIndex = 20
        ' 
        ' Author_Label
        ' 
        Author_Label.AutoSize = True
        Author_Label.Font = New Font("Sylfaen", 20.25F)
        Author_Label.Location = New Point(84, 128)
        Author_Label.Name = "Author_Label"
        Author_Label.Size = New Size(140, 35)
        Author_Label.TabIndex = 16
        Author_Label.Text = "Book Title:"
        ' 
        ' Title_Label
        ' 
        Title_Label.AutoSize = True
        Title_Label.Font = New Font("Sylfaen", 20.25F)
        Title_Label.Location = New Point(84, 81)
        Title_Label.Name = "Title_Label"
        Title_Label.Size = New Size(124, 35)
        Title_Label.TabIndex = 15
        Title_Label.Text = "Book ID: "
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(-26, -73)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(903, 725)
        Panel1.TabIndex = 11
        ' 
        ' AddBookForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(870, 591)
        Controls.Add(Panel1)
        Name = "AddBookForm"
        Text = "Form1"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(BookCover_PictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents OpenFD As OpenFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BookCover_PictureBox As PictureBox
    Friend WithEvents ClearAll_Button As Button
    Friend WithEvents AddBook_Button As Button
    Friend WithEvents Author_TextBox As TextBox
    Friend WithEvents Title_TextBox As TextBox
    Friend WithEvents Author_Label As Label
    Friend WithEvents Title_Label As Label
    Friend WithEvents Panel1 As Panel
End Class
