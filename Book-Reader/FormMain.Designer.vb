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
        ButtonBackDetails = New PictureBox()
        PictureBoxCover = New PictureBox()
        PanelDashboard.SuspendLayout()
        PanelDetails.SuspendLayout()
        CType(ButtonBackDetails, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBoxCover, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanelDashboard
        ' 
        TableLayoutPanelDashboard.AutoScroll = True
        TableLayoutPanelDashboard.ColumnCount = 4
        TableLayoutPanelDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanelDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanelDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanelDashboard.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanelDashboard.Dock = DockStyle.Fill
        TableLayoutPanelDashboard.Location = New Point(0, 0)
        TableLayoutPanelDashboard.Name = "TableLayoutPanelDashboard"
        TableLayoutPanelDashboard.RowCount = 5
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelDashboard.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanelDashboard.Size = New Size(1298, 999)
        TableLayoutPanelDashboard.TabIndex = 0
        ' 
        ' PanelDashboard
        ' 
        PanelDashboard.Controls.Add(PanelDetails)
        PanelDashboard.Controls.Add(TableLayoutPanelDashboard)
        PanelDashboard.Dock = DockStyle.Fill
        PanelDashboard.Location = New Point(0, 0)
        PanelDashboard.Name = "PanelDashboard"
        PanelDashboard.Size = New Size(1298, 999)
        PanelDashboard.TabIndex = 1
        ' 
        ' PanelDetails
        ' 
        PanelDetails.Controls.Add(PictureBoxCover)
        PanelDetails.Controls.Add(ButtonBackDetails)
        PanelDetails.Dock = DockStyle.Fill
        PanelDetails.Location = New Point(0, 0)
        PanelDetails.Name = "PanelDetails"
        PanelDetails.Size = New Size(1298, 999)
        PanelDetails.TabIndex = 1
        PanelDetails.Visible = False
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
        ' PictureBoxCover
        ' 
        PictureBoxCover.Location = New Point(113, 54)
        PictureBoxCover.Name = "PictureBoxCover"
        PictureBoxCover.Size = New Size(240, 384)
        PictureBoxCover.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxCover.TabIndex = 1
        PictureBoxCover.TabStop = False
        ' 
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1298, 999)
        Controls.Add(PanelDashboard)
        MinimumSize = New Size(1314, 755)
        Name = "FormMain"
        Text = "Book Reader"
        PanelDashboard.ResumeLayout(False)
        PanelDetails.ResumeLayout(False)
        CType(ButtonBackDetails, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBoxCover, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanelDashboard As TableLayoutPanel
    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents PanelDetails As Panel
    Friend WithEvents ButtonBackDetails As PictureBox
    Friend WithEvents PictureBoxCover As PictureBox

End Class
