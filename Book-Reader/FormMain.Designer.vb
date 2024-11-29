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
        TableLayoutPanelDashboard = New TableLayoutPanel()
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
        ' FormMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1298, 999)
        Controls.Add(TableLayoutPanelDashboard)
        MinimumSize = New Size(1314, 755)
        Name = "FormMain"
        Text = "Book Reader"
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanelDashboard As TableLayoutPanel

End Class
