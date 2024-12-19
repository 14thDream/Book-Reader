<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DeleteChapter_Button = New Button()
        TableLayoutPanelDashboard = New TableLayoutPanel()
        PanelDashboard = New Panel()
        PanelDetails = New Panel()
        PanelReadChapter = New Panel()
        LabelChapterNumber = New Label()
        RichTextBoxChapterContent = New RichTextBox()
        LabelChapterTitle = New Label()
        ButtonBackChapter = New PictureBox()
        PictureBoxNext = New PictureBox()
        PictureBoxBack = New PictureBox()
        DataGridViewChapters = New DataGridView()
        EditChapter_Button = New Button()
        ButtonAddChapter = New Button()
        Label1 = New Label()
        LabelSummary = New Label()
        LabelAuthor = New Label()
        LabelTitle = New Label()
        PictureBoxCover = New PictureBox()
        ButtonBackDetails = New PictureBox()
        LabelGenreNoContent = New Label()
        LabelDatePublishedNoContent = New Label()
        LabelGenre = New Label()
        LabelDatePublished = New Label()
        PanelDashboard.SuspendLayout()
        PanelDetails.SuspendLayout()
        PanelReadChapter.SuspendLayout()
        CType(ButtonBackChapter, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxNext, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridViewChapters, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxCover, ComponentModel.ISupportInitialize).BeginInit()
        CType(ButtonBackDetails, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DeleteChapter_Button
        ' 
        DeleteChapter_Button.AutoSize = True
        DeleteChapter_Button.Location = New Point(960, 700)
        DeleteChapter_Button.Name = "DeleteChapter_Button"
        DeleteChapter_Button.Size = New Size(95, 25)
        DeleteChapter_Button.TabIndex = 8
        DeleteChapter_Button.Text = "Delete Chapter"
        DeleteChapter_Button.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanelDashboard
        ' 
        TableLayoutPanelDashboard.AutoScroll = True
        TableLayoutPanelDashboard.ColumnCount = 4
        TableLayoutPanelDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanelDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanelDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanelDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0F))
        TableLayoutPanelDashboard.Dock = DockStyle.Fill
        TableLayoutPanelDashboard.Location = New Point(0, 0)
        TableLayoutPanelDashboard.Name = "TableLayoutPanelDashboard"
        TableLayoutPanelDashboard.RowCount = 4
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 25.0F))
        TableLayoutPanelDashboard.Size = New Size(1298, 749)
        TableLayoutPanelDashboard.TabIndex = 0
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.AutoScroll = True
        PanelDashboard.BackColor = Color.Transparent
        PanelDashboard.Controls.Add(PanelDetails)
        PanelDashboard.Controls.Add(TableLayoutPanelDashboard)
        PanelDashboard.Dock = DockStyle.Fill
        PanelDashboard.Location = New Point(0, 0)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(1298, 749)
        PanelDashboard.TabIndex = 1
        ' 
        ' PanelDetails
        ' 
        PanelDetails.AutoScroll = True
        PanelDetails.Controls.Add(PanelReadChapter)
        PanelDetails.Controls.Add(DataGridViewChapters)
        PanelDetails.Controls.Add(EditChapter_Button)
        PanelDetails.Controls.Add(ButtonAddChapter)
        PanelDetails.Controls.Add(DeleteChapter_Button)
        PanelDetails.Controls.Add(Label1)
        PanelDetails.Controls.Add(LabelSummary)
        PanelDetails.Controls.Add(LabelAuthor)
        PanelDetails.Controls.Add(LabelTitle)
        PanelDetails.Controls.Add(PictureBoxCover)
        PanelDetails.Controls.Add(ButtonBackDetails)
        PanelDetails.Controls.Add(LabelGenreNoContent)
        PanelDetails.Controls.Add(LabelDatePublishedNoContent)
        PanelDetails.Controls.Add(LabelGenre)
        PanelDetails.Controls.Add(LabelDatePublished)
        PanelDetails.Dock = DockStyle.Fill
        PanelDetails.Location = New Point(0, 0)
        PanelDetails.Name = "PanelDetails"
        PanelDetails.Size = New Size(1298, 749)
        PanelDetails.TabIndex = 1
        PanelDetails.Visible = False
        ' 
        ' PanelReadChapter
        ' 
        PanelReadChapter.Controls.Add(LabelChapterNumber)
        PanelReadChapter.Controls.Add(RichTextBoxChapterContent)
        PanelReadChapter.Controls.Add(LabelChapterTitle)
        PanelReadChapter.Controls.Add(ButtonBackChapter)
        PanelReadChapter.Controls.Add(PictureBoxNext)
        PanelReadChapter.Controls.Add(PictureBoxBack)
        PanelReadChapter.Dock = DockStyle.Fill
        PanelReadChapter.Location = New Point(0, 0)
        PanelReadChapter.Name = "PanelReadChapter"
        PanelReadChapter.Size = New Size(1298, 749)
        PanelReadChapter.TabIndex = 7
        PanelReadChapter.Visible = False
        ' 
        ' LabelChapterNumber
        ' 
        LabelChapterNumber.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelChapterNumber.Location = New Point(72, 34)
        LabelChapterNumber.Name = "LabelChapterNumber"
        LabelChapterNumber.Size = New Size(58, 20)
        LabelChapterNumber.TabIndex = 9
        ' 
        ' RichTextBoxChapterContent
        ' 
        RichTextBoxChapterContent.BackColor = SystemColors.Control
        RichTextBoxChapterContent.BorderStyle = BorderStyle.None
        RichTextBoxChapterContent.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBoxChapterContent.Location = New Point(67, 72)
        RichTextBoxChapterContent.Name = "RichTextBoxChapterContent"
        RichTextBoxChapterContent.ReadOnly = True
        RichTextBoxChapterContent.Size = New Size(1154, 651)
        RichTextBoxChapterContent.TabIndex = 11
        RichTextBoxChapterContent.Text = ""
        ' 
        ' LabelChapterTitle
        ' 
        LabelChapterTitle.BackColor = SystemColors.Control
        LabelChapterTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelChapterTitle.Location = New Point(72, 28)
        LabelChapterTitle.Name = "LabelChapterTitle"
        LabelChapterTitle.Size = New Size(1154, 32)
        LabelChapterTitle.TabIndex = 10
        LabelChapterTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ButtonBackChapter
        ' 
        ButtonBackChapter.Image = CType(resources.GetObject("ButtonBackChapter.Image"), Image)
        ButtonBackChapter.Location = New Point(12, 72)
        ButtonBackChapter.Name = "ButtonBackChapter"
        ButtonBackChapter.Size = New Size(30, 30)
        ButtonBackChapter.SizeMode = PictureBoxSizeMode.StretchImage
        ButtonBackChapter.TabIndex = 8
        ButtonBackChapter.TabStop = False
        ' 
        ' PictureBoxNext
        ' 
        PictureBoxNext.Image = CType(resources.GetObject("PictureBoxNext.Image"), Image)
        PictureBoxNext.Location = New Point(1227, 434)
        PictureBoxNext.Name = "PictureBoxNext"
        PictureBoxNext.Size = New Size(50, 50)
        PictureBoxNext.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxNext.TabIndex = 2
        PictureBoxNext.TabStop = False
        ' 
        ' PictureBoxBack
        ' 
        PictureBoxBack.Image = CType(resources.GetObject("PictureBoxBack.Image"), Image)
        PictureBoxBack.Location = New Point(11, 434)
        PictureBoxBack.Name = "PictureBoxBack"
        PictureBoxBack.Size = New Size(50, 50)
        PictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxBack.TabIndex = 1
        PictureBoxBack.TabStop = False
        ' 
        ' DataGridViewChapters
        ' 
        DataGridViewChapters.AllowUserToAddRows = False
        DataGridViewChapters.AllowUserToDeleteRows = False
        DataGridViewChapters.AllowUserToResizeColumns = False
        DataGridViewChapters.AllowUserToResizeRows = False
        DataGridViewChapters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewChapters.BackgroundColor = Color.White
        DataGridViewChapters.BorderStyle = BorderStyle.None
        DataGridViewChapters.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        DataGridViewChapters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewChapters.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewChapters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridViewChapters.DefaultCellStyle = DataGridViewCellStyle2
        DataGridViewChapters.EnableHeadersVisualStyles = False
        DataGridViewChapters.Location = New Point(499, 373)
        DataGridViewChapters.MultiSelect = False
        DataGridViewChapters.Name = "DataGridViewChapters"
        DataGridViewChapters.ReadOnly = True
        DataGridViewChapters.RowHeadersVisible = False
        DataGridViewChapters.Size = New Size(736, 310)
        DataGridViewChapters.TabIndex = 5
        ' 
        ' EditChapter_Button
        ' 
        EditChapter_Button.AutoSize = True
        EditChapter_Button.Location = New Point(1061, 700)
        EditChapter_Button.Name = "EditChapter_Button"
        EditChapter_Button.Size = New Size(84, 25)
        EditChapter_Button.TabIndex = 7
        EditChapter_Button.Text = "Edit Chapter"
        EditChapter_Button.UseVisualStyleBackColor = True
        ' 
        ' ButtonAddChapter
        ' 
        ButtonAddChapter.AutoSize = True
        ButtonAddChapter.Location = New Point(1151, 700)
        ButtonAddChapter.Name = "ButtonAddChapter"
        ButtonAddChapter.Size = New Size(84, 25)
        ButtonAddChapter.TabIndex = 6
        ButtonAddChapter.Text = "Add Chapter"
        ButtonAddChapter.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(499, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 37)
        Label1.TabIndex = 0
        Label1.Text = "Summary"
        ' 
        ' LabelSummary
        ' 
        LabelSummary.BackColor = Color.Transparent
        LabelSummary.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSummary.Location = New Point(499, 108)
        LabelSummary.Name = "LabelSummary"
        LabelSummary.Size = New Size(736, 232)
        LabelSummary.TabIndex = 4
        ' 
        ' LabelAuthor
        ' 
        LabelAuthor.Font = New Font("Segoe UI", 12.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LabelAuthor.Location = New Point(113, 607)
        LabelAuthor.Name = "LabelAuthor"
        LabelAuthor.Size = New Size(320, 23)
        LabelAuthor.TabIndex = 3
        LabelAuthor.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoEllipsis = True
        LabelTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTitle.Location = New Point(113, 575)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(320, 32)
        LabelTitle.TabIndex = 2
        LabelTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBoxCover
        ' 
        PictureBoxCover.Image = CType(resources.GetObject("PictureBoxCover.Image"), Image)
        PictureBoxCover.Location = New Point(113, 54)
        PictureBoxCover.Name = "PictureBoxCover"
        PictureBoxCover.Size = New Size(320, 512)
        PictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxCover.TabIndex = 1
        PictureBoxCover.TabStop = False
        ' 
        ' ButtonBackDetails
        ' 
        ButtonBackDetails.Image = CType(resources.GetObject("ButtonBackDetails.Image"), Image)
        ButtonBackDetails.Location = New Point(12, 72)
        ButtonBackDetails.Name = "ButtonBackDetails"
        ButtonBackDetails.Size = New Size(30, 30)
        ButtonBackDetails.SizeMode = PictureBoxSizeMode.StretchImage
        ButtonBackDetails.TabIndex = 0
        ButtonBackDetails.TabStop = False
        ' 
        ' LabelGenreNoContent
        ' 
        LabelGenreNoContent.AutoSize = True
        LabelGenreNoContent.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelGenreNoContent.Location = New Point(113, 660)
        LabelGenreNoContent.Name = "LabelGenreNoContent"
        LabelGenreNoContent.Size = New Size(59, 21)
        LabelGenreNoContent.TabIndex = 8
        LabelGenreNoContent.Text = "Genre:"
        ' 
        ' LabelDatePublishedNoContent
        ' 
        LabelDatePublishedNoContent.AutoSize = True
        LabelDatePublishedNoContent.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelDatePublishedNoContent.Location = New Point(113, 700)
        LabelDatePublishedNoContent.Name = "LabelDatePublishedNoContent"
        LabelDatePublishedNoContent.Size = New Size(134, 21)
        LabelDatePublishedNoContent.TabIndex = 9
        LabelDatePublishedNoContent.Text = "Date Published: "
        ' 
        ' LabelGenre
        ' 
        LabelGenre.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelGenre.Location = New Point(253, 660)
        LabelGenre.Name = "LabelGenre"
        LabelGenre.Size = New Size(180, 23)
        LabelGenre.TabIndex = 10
        LabelGenre.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelDatePublished
        ' 
        LabelDatePublished.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelDatePublished.Location = New Point(253, 700)
        LabelDatePublished.Name = "LabelDatePublished"
        LabelDatePublished.Size = New Size(180, 23)
        LabelDatePublished.TabIndex = 11
        LabelDatePublished.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1298, 749)
        Controls.Add(PanelDashboard)
        MinimumSize = New Size(1314, 718)
        Name = "FormMain"
        Text = "Book Reader"
        PanelDashboard.ResumeLayout(False)
        PanelDetails.ResumeLayout(False)
        PanelDetails.PerformLayout()
        PanelReadChapter.ResumeLayout(False)
        CType(ButtonBackChapter, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxNext, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxBack, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridViewChapters, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxCover, ComponentModel.ISupportInitialize).EndInit()
        CType(ButtonBackDetails, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanelDashboard As TableLayoutPanel
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents PanelDetails As Panel
    Friend WithEvents ButtonBackDetails As PictureBox
    Friend WithEvents PictureBoxCover As PictureBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelAuthor As Label
    Friend WithEvents LabelSummary As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewChapters As DataGridView
    Friend WithEvents ButtonAddChapter As Button
    Friend WithEvents PanelReadChapter As Panel
    Friend WithEvents PictureBoxNext As PictureBox
    Friend WithEvents PictureBoxBack As PictureBox
    Friend WithEvents ButtonBackChapter As PictureBox
    Friend WithEvents LabelChapterTitle As Label
    Friend WithEvents LabelChapterNumber As Label
    Friend WithEvents RichTextBoxChapterContent As RichTextBox
    Friend WithEvents LabelGenre As Label
    Friend WithEvents LabelDatePublishedNoContent As Label
    Friend WithEvents LabelGenreNoContent As Label
    Friend WithEvents LabelDatePublished As Label
    Friend WithEvents EditChapter_Button As Button
    Friend WithEvents DeleteChapter_Button As Button

End Class
