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
        TableLayoutPanelDashboard = New TableLayoutPanel()
        PanelDashboard = New Panel()
        PanelDetails = New Panel()
        PanelReadChapter = New Panel()
        RichTextBoxChapterContent = New RichTextBox()
        LabelChapterNumber = New Label()
        LabelChapterTitle = New Label()
        ButtonBackChapter = New PictureBox()
        PictureBoxNext = New PictureBox()
        PictureBoxBack = New PictureBox()
        ButtonAddChapter = New Button()
        DataGridViewChapters = New DataGridView()
        Label1 = New Label()
        LabelSummary = New Label()
        LabelAuthor = New Label()
        LabelTitle = New Label()
        PictureBoxCover = New PictureBox()
        ButtonBackDetails = New PictureBox()
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
        TableLayoutPanelDashboard.RowCount = 5
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20.0F))
        TableLayoutPanelDashboard.Size = New Size(1298, 881)
        TableLayoutPanelDashboard.TabIndex = 0
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.Controls.Add(PanelDetails)
        PanelDashboard.Controls.Add(TableLayoutPanelDashboard)
        PanelDashboard.Dock = DockStyle.Fill
        PanelDashboard.Location = New Point(0, 0)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(1298, 881)
        PanelDashboard.TabIndex = 1
        ' 
        ' PanelDetails
        ' 
        PanelDetails.Controls.Add(PanelReadChapter)
        PanelDetails.Controls.Add(ButtonAddChapter)
        PanelDetails.Controls.Add(DataGridViewChapters)
        PanelDetails.Controls.Add(Label1)
        PanelDetails.Controls.Add(LabelSummary)
        PanelDetails.Controls.Add(LabelAuthor)
        PanelDetails.Controls.Add(LabelTitle)
        PanelDetails.Controls.Add(PictureBoxCover)
        PanelDetails.Controls.Add(ButtonBackDetails)
        PanelDetails.Dock = DockStyle.Fill
        PanelDetails.Location = New Point(0, 0)
        PanelDetails.Name = "PanelDetails"
        PanelDetails.Size = New Size(1298, 881)
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
        PanelReadChapter.Size = New Size(1298, 881)
        PanelReadChapter.TabIndex = 7
        PanelReadChapter.Visible = False
        ' 
        ' RichTextBoxChapterContent
        ' 
        RichTextBoxChapterContent.BackColor = Color.White
        RichTextBoxChapterContent.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBoxChapterContent.Location = New Point(72, 72)
        RichTextBoxChapterContent.Name = "RichTextBoxChapterContent"
        RichTextBoxChapterContent.ReadOnly = True
        RichTextBoxChapterContent.Size = New Size(1154, 779)
        RichTextBoxChapterContent.TabIndex = 11
        RichTextBoxChapterContent.Text = ""
        ' 
        ' LabelChapterNumber
        ' 
        LabelChapterNumber.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelChapterNumber.Location = New Point(72, 34)
        LabelChapterNumber.Name = "LabelChapterNumber"
        LabelChapterNumber.Size = New Size(58, 20)
        LabelChapterNumber.TabIndex = 9
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
        PictureBoxNext.Location = New Point(1237, 434)
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
        ' ButtonAddChapter
        ' 
        ButtonAddChapter.AutoSize = True
        ButtonAddChapter.Location = New Point(1151, 776)
        ButtonAddChapter.Name = "ButtonAddChapter"
        ButtonAddChapter.Size = New Size(84, 25)
        ButtonAddChapter.TabIndex = 6
        ButtonAddChapter.Text = "Add Chapter"
        ButtonAddChapter.UseVisualStyleBackColor = True
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
        DataGridViewChapters.Size = New Size(736, 385)
        DataGridViewChapters.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(499, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 21)
        Label1.TabIndex = 0
        Label1.Text = "Summary"
        ' 
        ' LabelSummary
        ' 
        LabelSummary.BackColor = SystemColors.ControlLightLight
        LabelSummary.BorderStyle = BorderStyle.FixedSingle
        LabelSummary.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelSummary.Location = New Point(499, 84)
        LabelSummary.Name = "LabelSummary"
        LabelSummary.Size = New Size(736, 256)
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
        ButtonBackDetails.Location = New Point(12, 12)
        ButtonBackDetails.Name = "ButtonBackDetails"
        ButtonBackDetails.Size = New Size(30, 30)
        ButtonBackDetails.SizeMode = PictureBoxSizeMode.StretchImage
        ButtonBackDetails.TabIndex = 0
        ButtonBackDetails.TabStop = False
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1298, 881)
        Controls.Add(PanelDashboard)
        MinimumSize = New Size(1314, 755)
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

End Class
