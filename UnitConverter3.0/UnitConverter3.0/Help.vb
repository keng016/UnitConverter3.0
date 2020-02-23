Public Class Help
    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximumSize = Size
        MinimumSize = Size
        If TabControl1.SelectedIndex = 0 Then
            Text = "設定"
        ElseIf TabControl1.SelectedIndex = 1 Then
            Text = "バージョン情報"
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Text = "設定"
        ElseIf TabControl1.SelectedIndex = 1 Then
            Text = "バージョン情報"
        End If
    End Sub

    Private Sub FontCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles FontCheckBox.CheckedChanged
        If FontCheckBox.Checked = True Then
            Main.Label1.Font = New Font("Yu Gothic UI", 12)
            Main.Label2.Font = New Font("Yu Gothic UI", 12)
            Main.UnitListBox.Font = New Font("Yu Gothic UI", 20)
        Else
            Main.Label1.Font = New Font("Yu Gothic UI", 9.4)
            Main.Label2.Font = New Font("Yu Gothic UI", 9.4)
            Main.UnitListBox.Font = New Font("Yu Gothic UI", 16)
        End If
    End Sub

    Private Sub DarkCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles DarkCheckBox.CheckedChanged
        If DarkCheckBox.Checked = True Then
            Main.UnitListBox.BackColor = Color.Black
            Main.UnitListBox.ForeColor = Color.White
            Main.Panel1.BackColor = Color.Black
            Main.Panel1.ForeColor = Color.White
            Main.Panel2.BackColor = Color.Black
            Main.Panel2.ForeColor = Color.White
            Main.ConvertButton.FlatStyle = FlatStyle.Flat
            Main.ClearButton.FlatStyle = FlatStyle.Flat
        Else
            Main.UnitListBox.BackColor = Color.White
            Main.UnitListBox.ForeColor = Color.Black
            Main.Panel1.BackColor = Color.White
            Main.Panel1.ForeColor = Color.Black
            Main.Panel2.BackColor = Color.White
            Main.Panel2.ForeColor = Color.Black
            Main.ConvertButton.FlatStyle = FlatStyle.Standard
            Main.ClearButton.FlatStyle = FlatStyle.Standard
        End If
    End Sub
End Class