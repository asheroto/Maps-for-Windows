<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OpenInBrowser = New System.Windows.Forms.ToolStripButton()
        Me.SetAsDefaultMapsHandler = New System.Windows.Forms.ToolStripButton()
        Me.About = New System.Windows.Forms.ToolStripButton()
        Me.ReportABug = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.maps = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenInBrowser, Me.SetAsDefaultMapsHandler, Me.About, Me.ReportABug})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 23)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OpenInBrowser
        '
        Me.OpenInBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OpenInBrowser.Image = CType(resources.GetObject("OpenInBrowser.Image"), System.Drawing.Image)
        Me.OpenInBrowser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenInBrowser.Name = "OpenInBrowser"
        Me.OpenInBrowser.Size = New System.Drawing.Size(98, 20)
        Me.OpenInBrowser.Text = "Open in Browser"
        '
        'SetAsDefaultMapsHandler
        '
        Me.SetAsDefaultMapsHandler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SetAsDefaultMapsHandler.Image = CType(resources.GetObject("SetAsDefaultMapsHandler.Image"), System.Drawing.Image)
        Me.SetAsDefaultMapsHandler.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SetAsDefaultMapsHandler.Name = "SetAsDefaultMapsHandler"
        Me.SetAsDefaultMapsHandler.Size = New System.Drawing.Size(185, 20)
        Me.SetAsDefaultMapsHandler.Text = "Set as Default Maps/Geo Handler"
        '
        'About
        '
        Me.About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.About.Image = CType(resources.GetObject("About.Image"), System.Drawing.Image)
        Me.About.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(44, 20)
        Me.About.Text = "About"
        '
        'ReportABug
        '
        Me.ReportABug.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ReportABug.Image = CType(resources.GetObject("ReportABug.Image"), System.Drawing.Image)
        Me.ReportABug.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReportABug.Name = "ReportABug"
        Me.ReportABug.Size = New System.Drawing.Size(79, 20)
        Me.ReportABug.Text = "Report a Bug"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.maps, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ToolStrip1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.292181!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.70782!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 729)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'maps
        '
        Me.maps.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maps.Location = New System.Drawing.Point(4, 28)
        Me.maps.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.maps.MinimumSize = New System.Drawing.Size(30, 32)
        Me.maps.Name = "maps"
        Me.maps.ScriptErrorsSuppressed = True
        Me.maps.Size = New System.Drawing.Size(1000, 696)
        Me.maps.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maps for Windows"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents maps As WebBrowser
    Friend WithEvents About As ToolStripButton
    Friend WithEvents ReportABug As ToolStripButton
    Friend WithEvents SetAsDefaultMapsHandler As ToolStripButton
    Friend WithEvents OpenInBrowser As ToolStripButton
End Class
