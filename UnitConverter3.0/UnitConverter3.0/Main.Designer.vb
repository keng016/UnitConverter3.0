<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LengthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConvertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AfterTextBox = New System.Windows.Forms.TextBox()
        Me.SourceTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VolumeRadioButton = New System.Windows.Forms.RadioButton()
        Me.LengthRadioButton = New System.Windows.Forms.RadioButton()
        Me.WeightRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.UnitListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.UnitToolStripMenuItem, Me.OptionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(524, 24)
        Me.MenuStrip1.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.FileToolStripMenuItem.Text = "ファイル(&F)"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ClearToolStripMenuItem.Text = "数字をクリア(&L)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExitToolStripMenuItem.Text = "終了(&X)"
        '
        'UnitToolStripMenuItem
        '
        Me.UnitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WeightToolStripMenuItem, Me.LengthToolStripMenuItem, Me.VolumeToolStripMenuItem, Me.ToolStripSeparator1, Me.ConvertToolStripMenuItem})
        Me.UnitToolStripMenuItem.Name = "UnitToolStripMenuItem"
        Me.UnitToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.UnitToolStripMenuItem.Text = "単位(&U)"
        '
        'WeightToolStripMenuItem
        '
        Me.WeightToolStripMenuItem.Name = "WeightToolStripMenuItem"
        Me.WeightToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.WeightToolStripMenuItem.Text = "重さ"
        '
        'LengthToolStripMenuItem
        '
        Me.LengthToolStripMenuItem.Name = "LengthToolStripMenuItem"
        Me.LengthToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.LengthToolStripMenuItem.Text = "長さ"
        '
        'VolumeToolStripMenuItem
        '
        Me.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem"
        Me.VolumeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.VolumeToolStripMenuItem.Text = "容積"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'ConvertToolStripMenuItem
        '
        Me.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem"
        Me.ConvertToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ConvertToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ConvertToolStripMenuItem.Text = "変換(&C)"
        '
        'OptionToolStripMenuItem
        '
        Me.OptionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem"
        Me.OptionToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.OptionToolStripMenuItem.Text = "オプション(&O)"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SettingsToolStripMenuItem.Text = "設定(&S)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VersionToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.HelpToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'VersionToolStripMenuItem
        '
        Me.VersionToolStripMenuItem.Name = "VersionToolStripMenuItem"
        Me.VersionToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.VersionToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.VersionToolStripMenuItem.Text = "バージョン情報(&V)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.AfterTextBox)
        Me.Panel1.Controls.Add(Me.SourceTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 83)
        Me.Panel1.TabIndex = 1
        '
        'AfterTextBox
        '
        Me.AfterTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AfterTextBox.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.AfterTextBox.Location = New System.Drawing.Point(72, 47)
        Me.AfterTextBox.Name = "AfterTextBox"
        Me.AfterTextBox.ReadOnly = True
        Me.AfterTextBox.Size = New System.Drawing.Size(440, 29)
        Me.AfterTextBox.TabIndex = 5
        '
        'SourceTextBox
        '
        Me.SourceTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SourceTextBox.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!)
        Me.SourceTextBox.Location = New System.Drawing.Point(72, 7)
        Me.SourceTextBox.Name = "SourceTextBox"
        Me.SourceTextBox.Size = New System.Drawing.Size(440, 29)
        Me.SourceTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 9.4!)
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "変換後 :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 9.4!)
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "変換前 :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.VolumeRadioButton)
        Me.Panel2.Controls.Add(Me.LengthRadioButton)
        Me.Panel2.Controls.Add(Me.WeightRadioButton)
        Me.Panel2.Controls.Add(Me.ClearButton)
        Me.Panel2.Controls.Add(Me.ConvertButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(524, 48)
        Me.Panel2.TabIndex = 2
        '
        'VolumeRadioButton
        '
        Me.VolumeRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.VolumeRadioButton.AutoSize = True
        Me.VolumeRadioButton.Font = New System.Drawing.Font("Yu Gothic UI", 9.4!)
        Me.VolumeRadioButton.Location = New System.Drawing.Point(290, 14)
        Me.VolumeRadioButton.Name = "VolumeRadioButton"
        Me.VolumeRadioButton.Size = New System.Drawing.Size(52, 21)
        Me.VolumeRadioButton.TabIndex = 7
        Me.VolumeRadioButton.TabStop = True
        Me.VolumeRadioButton.Text = "容積"
        Me.VolumeRadioButton.UseVisualStyleBackColor = True
        '
        'LengthRadioButton
        '
        Me.LengthRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LengthRadioButton.AutoSize = True
        Me.LengthRadioButton.Font = New System.Drawing.Font("Yu Gothic UI", 9.4!)
        Me.LengthRadioButton.Location = New System.Drawing.Point(236, 14)
        Me.LengthRadioButton.Name = "LengthRadioButton"
        Me.LengthRadioButton.Size = New System.Drawing.Size(48, 21)
        Me.LengthRadioButton.TabIndex = 6
        Me.LengthRadioButton.TabStop = True
        Me.LengthRadioButton.Text = "長さ"
        Me.LengthRadioButton.UseVisualStyleBackColor = True
        '
        'WeightRadioButton
        '
        Me.WeightRadioButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.WeightRadioButton.AutoSize = True
        Me.WeightRadioButton.Checked = True
        Me.WeightRadioButton.Font = New System.Drawing.Font("Yu Gothic UI", 9.4!)
        Me.WeightRadioButton.Location = New System.Drawing.Point(182, 14)
        Me.WeightRadioButton.Name = "WeightRadioButton"
        Me.WeightRadioButton.Size = New System.Drawing.Size(48, 21)
        Me.WeightRadioButton.TabIndex = 5
        Me.WeightRadioButton.TabStop = True
        Me.WeightRadioButton.Text = "重さ"
        Me.WeightRadioButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Font = New System.Drawing.Font("Yu Gothic UI", 9.8!)
        Me.ClearButton.Location = New System.Drawing.Point(435, 8)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(80, 33)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "クリア(&L)"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ConvertButton
        '
        Me.ConvertButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ConvertButton.Font = New System.Drawing.Font("Yu Gothic UI", 9.8!)
        Me.ConvertButton.Location = New System.Drawing.Point(9, 8)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(80, 33)
        Me.ConvertButton.TabIndex = 3
        Me.ConvertButton.Text = "変換(&C)"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'UnitListBox
        '
        Me.UnitListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UnitListBox.Font = New System.Drawing.Font("Yu Gothic UI", 16.0!)
        Me.UnitListBox.FormattingEnabled = True
        Me.UnitListBox.ItemHeight = 30
        Me.UnitListBox.Location = New System.Drawing.Point(0, 107)
        Me.UnitListBox.Name = "UnitListBox"
        Me.UnitListBox.Size = New System.Drawing.Size(524, 426)
        Me.UnitListBox.TabIndex = 8
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 581)
        Me.Controls.Add(Me.UnitListBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "単位変換ツール v3.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LengthToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ConvertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AfterTextBox As TextBox
    Friend WithEvents SourceTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VolumeRadioButton As RadioButton
    Friend WithEvents LengthRadioButton As RadioButton
    Friend WithEvents WeightRadioButton As RadioButton
    Friend WithEvents ClearButton As Button
    Friend WithEvents ConvertButton As Button
    Friend WithEvents UnitListBox As ListBox
End Class
