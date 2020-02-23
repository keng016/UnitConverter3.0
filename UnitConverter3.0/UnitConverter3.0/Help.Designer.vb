<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Help))
        Me.VersionTab = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SettingsTab = New System.Windows.Forms.TabPage()
        Me.FontCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DarkCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.VersionTab.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingsTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VersionTab
        '
        Me.VersionTab.Controls.Add(Me.Label4)
        Me.VersionTab.Controls.Add(Me.Label3)
        Me.VersionTab.Controls.Add(Me.Label2)
        Me.VersionTab.Controls.Add(Me.PictureBox2)
        Me.VersionTab.Location = New System.Drawing.Point(4, 24)
        Me.VersionTab.Name = "VersionTab"
        Me.VersionTab.Padding = New System.Windows.Forms.Padding(3)
        Me.VersionTab.Size = New System.Drawing.Size(596, 333)
        Me.VersionTab.TabIndex = 3
        Me.VersionTab.Text = "バージョン情報"
        Me.VersionTab.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(142, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "単位変換ツール v3.0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(144, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Version 3.0 2020"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(447, 68)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "単位変換ツールは、単位を変換するツールです。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "動作環境 : Microsoft .Net Freamwork 4.0 が動作し、かつ Windows 7また" &
    "は10が" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "インストールされたPC。"
        '
        'SettingsTab
        '
        Me.SettingsTab.Controls.Add(Me.Label5)
        Me.SettingsTab.Controls.Add(Me.PictureBox3)
        Me.SettingsTab.Controls.Add(Me.DarkCheckBox)
        Me.SettingsTab.Controls.Add(Me.Label1)
        Me.SettingsTab.Controls.Add(Me.PictureBox1)
        Me.SettingsTab.Controls.Add(Me.FontCheckBox)
        Me.SettingsTab.Location = New System.Drawing.Point(4, 24)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SettingsTab.Size = New System.Drawing.Size(596, 333)
        Me.SettingsTab.TabIndex = 2
        Me.SettingsTab.Text = "設定"
        Me.SettingsTab.UseVisualStyleBackColor = True
        '
        'FontCheckBox
        '
        Me.FontCheckBox.AutoSize = True
        Me.FontCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.FontCheckBox.Location = New System.Drawing.Point(49, 6)
        Me.FontCheckBox.Name = "FontCheckBox"
        Me.FontCheckBox.Size = New System.Drawing.Size(123, 22)
        Me.FontCheckBox.TabIndex = 0
        Me.FontCheckBox.Text = "フォント拡大モード"
        Me.FontCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "説明 : 文字を拡大します。"
        '
        'DarkCheckBox
        '
        Me.DarkCheckBox.AutoSize = True
        Me.DarkCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DarkCheckBox.Location = New System.Drawing.Point(49, 71)
        Me.DarkCheckBox.Name = "DarkCheckBox"
        Me.DarkCheckBox.Size = New System.Drawing.Size(88, 22)
        Me.DarkCheckBox.TabIndex = 3
        Me.DarkCheckBox.Text = "ダークモード"
        Me.DarkCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(8, 71)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "説明 : アプリのテーマを全体的に暗くします。"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.SettingsTab)
        Me.TabControl1.Controls.Add(Me.VersionTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Yu Gothic UI", 9.2!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(604, 361)
        Me.TabControl1.TabIndex = 0
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 361)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Help"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Help"
        Me.VersionTab.ResumeLayout(False)
        Me.VersionTab.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingsTab.ResumeLayout(False)
        Me.SettingsTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VersionTab As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SettingsTab As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DarkCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FontCheckBox As CheckBox
    Friend WithEvents TabControl1 As TabControl
End Class
