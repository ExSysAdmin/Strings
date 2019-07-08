<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RemoveBlankLinesBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.ClipboardBtn = New System.Windows.Forms.Button()
        Me.LCaseBtn = New System.Windows.Forms.Button()
        Me.UCaseBtn = New System.Windows.Forms.Button()
        Me.TrimRightBtn = New System.Windows.Forms.Button()
        Me.TrimBtn = New System.Windows.Forms.Button()
        Me.TrimLeftBtn = New System.Windows.Forms.Button()
        Me.MainTabControl = New System.Windows.Forms.TabControl()
        Me.MainTabPage = New System.Windows.Forms.TabPage()
        Me.StringTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.MainLayoutPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MainTabControl.SuspendLayout()
        Me.MainTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator2, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Enabled = False
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Enabled = False
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Enabled = False
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Enabled = False
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.ColumnCount = 3
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainLayoutPanel.Controls.Add(Me.GroupBox1, 1, 0)
        Me.MainLayoutPanel.Controls.Add(Me.MainTabControl, 1, 1)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 24)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowCount = 3
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(800, 426)
        Me.MainLayoutPanel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RemoveBlankLinesBtn)
        Me.GroupBox1.Controls.Add(Me.ClearBtn)
        Me.GroupBox1.Controls.Add(Me.ClipboardBtn)
        Me.GroupBox1.Controls.Add(Me.LCaseBtn)
        Me.GroupBox1.Controls.Add(Me.UCaseBtn)
        Me.GroupBox1.Controls.Add(Me.TrimRightBtn)
        Me.GroupBox1.Controls.Add(Me.TrimBtn)
        Me.GroupBox1.Controls.Add(Me.TrimLeftBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 44)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Controls"
        '
        'RemoveBlankLinesBtn
        '
        Me.RemoveBlankLinesBtn.Location = New System.Drawing.Point(436, 15)
        Me.RemoveBlankLinesBtn.Name = "RemoveBlankLinesBtn"
        Me.RemoveBlankLinesBtn.Size = New System.Drawing.Size(122, 23)
        Me.RemoveBlankLinesBtn.TabIndex = 7
        Me.RemoveBlankLinesBtn.Text = "Remove Blank Lines"
        Me.RemoveBlankLinesBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(673, 15)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(75, 23)
        Me.ClearBtn.TabIndex = 6
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'ClipboardBtn
        '
        Me.ClipboardBtn.Location = New System.Drawing.Point(564, 15)
        Me.ClipboardBtn.Name = "ClipboardBtn"
        Me.ClipboardBtn.Size = New System.Drawing.Size(103, 23)
        Me.ClipboardBtn.TabIndex = 5
        Me.ClipboardBtn.Text = "Copy to Clipboard"
        Me.ClipboardBtn.UseVisualStyleBackColor = True
        '
        'LCaseBtn
        '
        Me.LCaseBtn.Location = New System.Drawing.Point(346, 15)
        Me.LCaseBtn.Name = "LCaseBtn"
        Me.LCaseBtn.Size = New System.Drawing.Size(75, 23)
        Me.LCaseBtn.TabIndex = 4
        Me.LCaseBtn.Text = "Lowercase"
        Me.LCaseBtn.UseVisualStyleBackColor = True
        '
        'UCaseBtn
        '
        Me.UCaseBtn.Location = New System.Drawing.Point(265, 15)
        Me.UCaseBtn.Name = "UCaseBtn"
        Me.UCaseBtn.Size = New System.Drawing.Size(75, 23)
        Me.UCaseBtn.TabIndex = 3
        Me.UCaseBtn.Text = "Uppercase"
        Me.UCaseBtn.UseVisualStyleBackColor = True
        '
        'TrimRightBtn
        '
        Me.TrimRightBtn.Location = New System.Drawing.Point(168, 15)
        Me.TrimRightBtn.Name = "TrimRightBtn"
        Me.TrimRightBtn.Size = New System.Drawing.Size(75, 23)
        Me.TrimRightBtn.TabIndex = 2
        Me.TrimRightBtn.Text = "Trim Right"
        Me.TrimRightBtn.UseVisualStyleBackColor = True
        '
        'TrimBtn
        '
        Me.TrimBtn.Location = New System.Drawing.Point(87, 15)
        Me.TrimBtn.Name = "TrimBtn"
        Me.TrimBtn.Size = New System.Drawing.Size(75, 23)
        Me.TrimBtn.TabIndex = 1
        Me.TrimBtn.Text = "Trim"
        Me.TrimBtn.UseVisualStyleBackColor = True
        '
        'TrimLeftBtn
        '
        Me.TrimLeftBtn.Location = New System.Drawing.Point(6, 15)
        Me.TrimLeftBtn.Name = "TrimLeftBtn"
        Me.TrimLeftBtn.Size = New System.Drawing.Size(75, 23)
        Me.TrimLeftBtn.TabIndex = 0
        Me.TrimLeftBtn.Text = "Trim Left"
        Me.TrimLeftBtn.UseVisualStyleBackColor = True
        '
        'MainTabControl
        '
        Me.MainTabControl.Controls.Add(Me.MainTabPage)
        Me.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainTabControl.Location = New System.Drawing.Point(23, 53)
        Me.MainTabControl.Name = "MainTabControl"
        Me.MainTabControl.SelectedIndex = 0
        Me.MainTabControl.Size = New System.Drawing.Size(754, 350)
        Me.MainTabControl.TabIndex = 2
        '
        'MainTabPage
        '
        Me.MainTabPage.Controls.Add(Me.StringTextBox)
        Me.MainTabPage.Location = New System.Drawing.Point(4, 22)
        Me.MainTabPage.Name = "MainTabPage"
        Me.MainTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.MainTabPage.Size = New System.Drawing.Size(746, 324)
        Me.MainTabPage.TabIndex = 0
        Me.MainTabPage.Text = "New"
        Me.MainTabPage.UseVisualStyleBackColor = True
        '
        'StringTextBox
        '
        Me.StringTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StringTextBox.Location = New System.Drawing.Point(3, 3)
        Me.StringTextBox.Multiline = True
        Me.StringTextBox.Name = "StringTextBox"
        Me.StringTextBox.Size = New System.Drawing.Size(740, 318)
        Me.StringTextBox.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Strings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MainLayoutPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.MainTabControl.ResumeLayout(False)
        Me.MainTabPage.ResumeLayout(False)
        Me.MainTabPage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainLayoutPanel As TableLayoutPanel
    Friend WithEvents StringTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ClipboardBtn As Button
    Friend WithEvents LCaseBtn As Button
    Friend WithEvents UCaseBtn As Button
    Friend WithEvents TrimRightBtn As Button
    Friend WithEvents TrimBtn As Button
    Friend WithEvents TrimLeftBtn As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveBlankLinesBtn As Button
    Friend WithEvents MainTabControl As TabControl
    Friend WithEvents MainTabPage As TabPage
End Class
