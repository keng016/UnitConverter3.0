Public Class Main
    Private Sub GetWeight()
        Dim mg As New Unit(UnitType.Weight, 0.001, "mg")
        Dim g As New Unit(UnitType.Weight, 1.0, "g")
        Dim kg As New Unit(UnitType.Weight, 1000.0, "kg")

        SetListItems(mg, g, kg)
    End Sub

    Private Sub GetLength()
        Dim mm As New Unit(UnitType.Length, 0.001, "mm")
        Dim cm As New Unit(UnitType.Length, 0.01, "cm")
        Dim m As New Unit(UnitType.Length, 1.0, "m")
        Dim km As New Unit(UnitType.Length, 1000.0, "km")

        SetListItems(mm, cm, m, km)
    End Sub

    Private Sub GetVolume()
        Dim mL As New Unit(UnitType.Volume, 0.001, "mL")
        Dim dL As New Unit(UnitType.Volume, 0.1, "dL")
        Dim L As New Unit(UnitType.Volume, 1.0, "L")
        Dim KL As New Unit(UnitType.Volume, 1000.0, "kL")

        SetListItems(mL, dL, L, KL)
    End Sub

    Private Sub Clear()
        SourceTextBox.Text = "0"
        AfterTextBox.Text = "0"
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        Clear()
    End Sub

    Private Sub SetListItems(ParamArray units() As Unit)
        Dim list As New List(Of ConverterItem)

        For f = 0 To units.Length - 1
            For t = 0 To units.Length - 1
                If f <> t Then
                    Dim item As New ConverterItem(units(f), units(t))
                    list.Add(item)
                End If
            Next
        Next

        Me.isSuppressListEvent = True
        Me.UnitListBox.BeginUpdate()

        Me.UnitListBox.DisplayMember = NameOf(ConverterItem.Text)
        Me.UnitListBox.DataSource = list
        UpdateResult()

        Me.UnitListBox.EndUpdate()
        Me.isSuppressListEvent = False
    End Sub
    Private isSuppressListEvent As Boolean = False

    Public Sub UpdateResult()
        Dim item As ConverterItem
        If UnitListBox.SelectedIndex < 0 Then
            AfterTextBox.Text = "選択されていません”
            Return
        End If

        item = CType(UnitListBox.SelectedItem, ConverterItem)

        Dim fromValue As Double
        If Not Double.TryParse(SourceTextBox.Text, fromValue) Then
            MessageBox.Show("元の値が数値ではありません。",
                "警告",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            Return
        End If


        AfterTextBox.Text = item.GetToValue(fromValue).ToString()

    End Sub

    Private Sub SourceTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SourceTextBox.KeyPress
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) _
         And e.KeyChar <> vbBack And e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub WeightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeightToolStripMenuItem.Click
        GetWeight()
    End Sub

    Private Sub LengthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LengthToolStripMenuItem.Click
        GetLength()
    End Sub

    Private Sub VolumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolumeToolStripMenuItem.Click
        GetVolume()
    End Sub

    Private Sub ConvertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertToolStripMenuItem.Click
        UpdateResult()
    End Sub

    Private Sub UnitListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UnitListBox.SelectedIndexChanged
        If isSuppressListEvent Then
            Exit Sub
        End If
        UpdateResult()
    End Sub

    Private Sub WeightRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles WeightRadioButton.CheckedChanged
        GetWeight()
    End Sub

    Private Sub LengthRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LengthRadioButton.CheckedChanged
        GetLength()
    End Sub

    Private Sub VolumeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles VolumeRadioButton.CheckedChanged
        GetVolume()
    End Sub

    Private Sub ConvertButton_Click(sender As Object, e As EventArgs) Handles ConvertButton.Click
        UpdateResult()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Clear()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Help.TabControl1.SelectedIndex = 0
        Help.ShowDialog()
    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        Help.TabControl1.SelectedIndex = 1
        Help.ShowDialog()
    End Sub
End Class

''' <summary>
''' 単位を読み取り、変換結果を算出します。
''' </summary>

Class Unit
    Sub New(ByVal type As UnitType, ByVal scale As Double, ByVal text As String)
        Me.UnitType = type
        Me.Scale = scale
        Me.Text = text
        If scale = 0 Then
            Throw New ArgumentOutOfRangeException("係数を0にしないでください")
        End If
    End Sub

    ''' <summary>変換係数</summary>
    Public ReadOnly Property Scale As Double
    ''' <summary>単位種類</summary>
    Public ReadOnly Property UnitType As UnitType
    ''' <summary>表示用文字列</summary>
    Public ReadOnly Property Text As String
End Class

Class ConverterItem
    Public Sub New(ByVal type As UnitType, ByVal fscale As Double, ByVal ftext As String, ByVal tscale As Double, ByVal ttext As String)
        MyClass.New(New Unit(type, fscale, ftext), New Unit(type, tscale, ttext))
    End Sub
    Public Sub New(ByVal fromUnit As [Unit], ByVal toUnit As Unit)
        If fromUnit.UnitType <> toUnit.UnitType Then
            Throw New ArgumentException("UnitTypeが異なります")
        End If
        Me.FromUnit = fromUnit
        Me.ToUnit = toUnit
    End Sub

    ''' <summary>変換元の単位と係数</summary>
    Public ReadOnly Property FromUnit As Unit
    ''' <summary>変換先の単位と係数</summary>
    Public ReadOnly Property ToUnit As Unit

    ''' <summary>表示用文字列</summary>
    Public ReadOnly Property Text As String
        Get
            Return ToUnit.Text + " => " + FromUnit.Text
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Text
    End Function


    ''' <summary>変換値を計算する</summary>
    ''' <param name="fromValue">変換元の数値</param>
    ''' <returns>変換後の数値</returns>
    Public Function GetToValue(ByVal fromValue As Double) As Double
        Return fromValue * ToUnit.Scale / FromUnit.Scale
    End Function
End Class

Enum UnitType
    Length
    Volume
    Weight
End Enum