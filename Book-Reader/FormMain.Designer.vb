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
        TableLayoutPanelDashboard = New TableLayoutPanel()
        PanelDashboard = New Panel()
        PanelDetails = New Panel()
        Label1 = New Label()
        LabelSummary = New Label()
        LabelAuthor = New Label()
        LabelTitle = New Label()
        PictureBoxCover = New PictureBox()
        ButtonBackDetails = New PictureBox()
        PanelDashboard.SuspendLayout()
        PanelDetails.SuspendLayout()
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
        LabelSummary.Size = New Size(736, 192)
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

End Class
