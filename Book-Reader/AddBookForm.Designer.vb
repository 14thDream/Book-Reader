<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBookForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        OpenFD = New OpenFileDialog()
        BookCover_PictureBox = New PictureBox()
        ClearAll_Button = New Button()
        AddBook_Button = New Button()
        Summary_TextBox = New TextBox()
        Summary_Label = New Label()
        Genre_ComboBox = New ComboBox()
        Author_TextBox = New TextBox()
        Title_TextBox = New TextBox()
        Genre_Label = New Label()
        Author_Label = New Label()
        Title_Label = New Label()
        BookDatePublished = New DateTimePicker()
        Label1 = New Label()
        CType(BookCover_PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' OpenFD
        ' 
        OpenFD.FileName = "OpenFD"
        ' 
        ' BookCover_PictureBox
        ' 
        BookCover_PictureBox.BackColor = Color.Transparent
        BookCover_PictureBox.BackgroundImageLayout = ImageLayout.Center
        BookCover_PictureBox.BorderStyle = BorderStyle.FixedSingle
        BookCover_PictureBox.Location = New Point(331, 12)
        BookCover_PictureBox.Name = "BookCover_PictureBox"
        BookCover_PictureBox.Size = New Size(192, 307)
        BookCover_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        BookCover_PictureBox.TabIndex = 41
        BookCover_PictureBox.TabStop = False
        ' 
        ' ClearAll_Button
        ' 
        ClearAll_Button.AutoSize = True
        ClearAll_Button.Location = New Point(14, 440)
        ClearAll_Button.Name = "ClearAll_Button"
        ClearAll_Button.Size = New Size(61, 25)
        ClearAll_Button.TabIndex = 40
        ClearAll_Button.Text = "Clear All"
        ClearAll_Button.UseVisualStyleBackColor = True
        ' 
        ' AddBook_Button
        ' 
        AddBook_Button.Location = New Point(274, 440)
        AddBook_Button.Name = "AddBook_Button"
        AddBook_Button.Size = New Size(41, 25)
        AddBook_Button.TabIndex = 39
        AddBook_Button.Text = "Save"
        AddBook_Button.UseVisualStyleBackColor = True
        ' 
        ' Summary_TextBox
        ' 
        Summary_TextBox.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Summary_TextBox.Location = New Point(14, 169)
        Summary_TextBox.Multiline = True
        Summary_TextBox.Name = "Summary_TextBox"
        Summary_TextBox.Size = New Size(301, 254)
        Summary_TextBox.TabIndex = 38
        ' 
        ' Summary_Label
        ' 
        Summary_Label.AutoSize = True
        Summary_Label.Font = New Font("Sylfaen", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Summary_Label.Location = New Point(14, 144)
        Summary_Label.Name = "Summary_Label"
        Summary_Label.Size = New Size(80, 22)
        Summary_Label.TabIndex = 37
        Summary_Label.Text = "Summary"
        ' 
        ' Genre_ComboBox
        ' 
        Genre_ComboBox.Font = New Font("Segoe UI", 9.0F)
        Genre_ComboBox.FormattingEnabled = True
        Genre_ComboBox.ItemHeight = 15
        Genre_ComboBox.Items.AddRange(New Object() {"Romance", "Fantasy", "Drama", "Horror", "Comedy", "Action", "History"})
        Genre_ComboBox.Location = New Point(76, 65)
        Genre_ComboBox.Name = "Genre_ComboBox"
        Genre_ComboBox.Size = New Size(239, 23)
        Genre_ComboBox.TabIndex = 36
        ' 
        ' Author_TextBox
        ' 
        Author_TextBox.Font = New Font("Segoe UI", 9.0F)
        Author_TextBox.Location = New Point(76, 37)
        Author_TextBox.Multiline = True
        Author_TextBox.Name = "Author_TextBox"
        Author_TextBox.Size = New Size(239, 22)
        Author_TextBox.TabIndex = 35
        ' 
        ' Title_TextBox
        ' 
        Title_TextBox.Font = New Font("Segoe UI", 9.0F)
        Title_TextBox.Location = New Point(76, 9)
        Title_TextBox.Multiline = True
        Title_TextBox.Name = "Title_TextBox"
        Title_TextBox.Size = New Size(239, 22)
        Title_TextBox.TabIndex = 34
        ' 
        ' Genre_Label
        ' 
        Genre_Label.AutoSize = True
        Genre_Label.Font = New Font("Sylfaen", 12.0F)
        Genre_Label.Location = New Point(14, 66)
        Genre_Label.Name = "Genre_Label"
        Genre_Label.Size = New Size(49, 22)
        Genre_Label.TabIndex = 33
        Genre_Label.Text = "Genre"
        ' 
        ' Author_Label
        ' 
        Author_Label.AutoSize = True
        Author_Label.Font = New Font("Sylfaen", 12.0F)
        Author_Label.Location = New Point(14, 37)
        Author_Label.Name = "Author_Label"
        Author_Label.Size = New Size(56, 22)
        Author_Label.TabIndex = 32
        Author_Label.Text = "Author"
        ' 
        ' Title_Label
        ' 
        Title_Label.AutoSize = True
        Title_Label.Font = New Font("Sylfaen", 12.0F)
        Title_Label.Location = New Point(14, 9)
        Title_Label.Name = "Title_Label"
        Title_Label.Size = New Size(42, 22)
        Title_Label.TabIndex = 31
        Title_Label.Text = "Title"
        ' 
        ' BookDatePublished
        ' 
        BookDatePublished.CalendarFont = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BookDatePublished.CustomFormat = "MMMM dd, yyyy"
        BookDatePublished.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BookDatePublished.Format = DateTimePickerFormat.Custom
        BookDatePublished.Location = New Point(129, 106)
        BookDatePublished.Name = "BookDatePublished"
        BookDatePublished.Size = New Size(186, 23)
        BookDatePublished.TabIndex = 44
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 12.0F)
        Label1.Location = New Point(12, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 22)
        Label1.TabIndex = 45
        Label1.Text = "Date Published"
        ' 
        ' AddBookForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(556, 494)
        Controls.Add(Label1)
        Controls.Add(BookDatePublished)
        Controls.Add(BookCover_PictureBox)
        Controls.Add(ClearAll_Button)
        Controls.Add(AddBook_Button)
        Controls.Add(Summary_TextBox)
        Controls.Add(Summary_Label)
        Controls.Add(Genre_ComboBox)
        Controls.Add(Author_TextBox)
        Controls.Add(Title_TextBox)
        Controls.Add(Genre_Label)
        Controls.Add(Author_Label)
        Controls.Add(Title_Label)
        Name = "AddBookForm"
        Text = "Form1"
        CType(BookCover_PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents OpenFD As OpenFileDialog
    Friend WithEvents BookCover_PictureBox As PictureBox
    Friend WithEvents ClearAll_Button As Button
    Friend WithEvents AddBook_Button As Button
    Friend WithEvents Summary_TextBox As TextBox
    Friend WithEvents Summary_Label As Label
    Friend WithEvents Genre_ComboBox As ComboBox
    Friend WithEvents Author_TextBox As TextBox
    Friend WithEvents Title_TextBox As TextBox
    Friend WithEvents Genre_Label As Label
    Friend WithEvents Author_Label As Label
    Friend WithEvents Title_Label As Label
    Friend WithEvents BookDatePublished As DateTimePicker
    Friend WithEvents Label1 As Label
End Class
