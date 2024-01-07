Imports System.Data.SqlClient
Imports System.Drawing.Imaging

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BracketForm
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
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        ComboBox5 = New ComboBox()
        ComboBox6 = New ComboBox()
        ComboBox7 = New ComboBox()
        ComboBox8 = New ComboBox()
        ComboBox9 = New ComboBox()
        ComboBox10 = New ComboBox()
        ComboBox11 = New ComboBox()
        ComboBox12 = New ComboBox()
        ComboBox13 = New ComboBox()
        ComboBox14 = New ComboBox()
        ComboBox15 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(585, 213)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(413, 114)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 1
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(413, 323)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(151, 28)
        ComboBox3.TabIndex = 2
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(221, 57)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(151, 28)
        ComboBox4.TabIndex = 3
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(221, 164)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(151, 28)
        ComboBox5.TabIndex = 4
        ' 
        ' ComboBox6
        ' 
        ComboBox6.FormattingEnabled = True
        ComboBox6.Location = New Point(221, 276)
        ComboBox6.Name = "ComboBox6"
        ComboBox6.Size = New Size(151, 28)
        ComboBox6.TabIndex = 5
        ' 
        ' ComboBox7
        ' 
        ComboBox7.FormattingEnabled = True
        ComboBox7.Location = New Point(221, 367)
        ComboBox7.Name = "ComboBox7"
        ComboBox7.Size = New Size(151, 28)
        ComboBox7.TabIndex = 6
        ' 
        ' ComboBox8
        ' 
        ComboBox8.FormattingEnabled = True
        ComboBox8.Location = New Point(49, 36)
        ComboBox8.Name = "ComboBox8"
        ComboBox8.Size = New Size(151, 28)
        ComboBox8.TabIndex = 7
        ' 
        ' ComboBox9
        ' 
        ComboBox9.FormattingEnabled = True
        ComboBox9.Location = New Point(49, 81)
        ComboBox9.Name = "ComboBox9"
        ComboBox9.Size = New Size(151, 28)
        ComboBox9.TabIndex = 8
        ' 
        ' ComboBox10
        ' 
        ComboBox10.FormattingEnabled = True
        ComboBox10.Location = New Point(49, 138)
        ComboBox10.Name = "ComboBox10"
        ComboBox10.Size = New Size(151, 28)
        ComboBox10.TabIndex = 9
        ' 
        ' ComboBox11
        ' 
        ComboBox11.FormattingEnabled = True
        ComboBox11.Location = New Point(49, 186)
        ComboBox11.Name = "ComboBox11"
        ComboBox11.Size = New Size(151, 28)
        ComboBox11.TabIndex = 10
        ' 
        ' ComboBox12
        ' 
        ComboBox12.FormattingEnabled = True
        ComboBox12.Location = New Point(49, 242)
        ComboBox12.Name = "ComboBox12"
        ComboBox12.Size = New Size(151, 28)
        ComboBox12.TabIndex = 11
        ' 
        ' ComboBox13
        ' 
        ComboBox13.FormattingEnabled = True
        ComboBox13.Location = New Point(49, 287)
        ComboBox13.Name = "ComboBox13"
        ComboBox13.Size = New Size(151, 28)
        ComboBox13.TabIndex = 12
        ' 
        ' ComboBox14
        ' 
        ComboBox14.FormattingEnabled = True
        ComboBox14.Location = New Point(49, 341)
        ComboBox14.Name = "ComboBox14"
        ComboBox14.Size = New Size(151, 28)
        ComboBox14.TabIndex = 13
        ' 
        ' ComboBox15
        ' 
        ComboBox15.FormattingEnabled = True
        ComboBox15.Location = New Point(49, 386)
        ComboBox15.Name = "ComboBox15"
        ComboBox15.Size = New Size(151, 28)
        ComboBox15.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(585, 463)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 29)
        Button1.TabIndex = 15
        Button1.Text = "Set Tier 1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(413, 463)
        Button2.Name = "Button2"
        Button2.Size = New Size(151, 29)
        Button2.TabIndex = 16
        Button2.Text = "Set Tier 2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(221, 463)
        Button3.Name = "Button3"
        Button3.Size = New Size(151, 29)
        Button3.TabIndex = 17
        Button3.Text = "Set Tier 3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(49, 463)
        Button4.Name = "Button4"
        Button4.Size = New Size(151, 29)
        Button4.TabIndex = 18
        Button4.Text = "Set Tier 4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(49, 538)
        Button5.Name = "Button5"
        Button5.Size = New Size(323, 29)
        Button5.TabIndex = 19
        Button5.Text = "Exit WIthout Saving"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(413, 538)
        Button6.Name = "Button6"
        Button6.Size = New Size(323, 29)
        Button6.TabIndex = 20
        Button6.Text = "Save Results and Exit"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' BracketForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(777, 599)
        Controls.Add(Button1)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button5)
        Controls.Add(Button6)

        Controls.Add(ComboBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox6)
        Controls.Add(ComboBox7)
        Controls.Add(ComboBox8)
        Controls.Add(ComboBox9)
        Controls.Add(ComboBox10)
        Controls.Add(ComboBox11)
        Controls.Add(ComboBox12)
        Controls.Add(ComboBox13)
        Controls.Add(ComboBox14)
        Controls.Add(ComboBox15)
        Name = "BracketForm"
        Text = "Bracket"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ComboBox8 As ComboBox
    Friend WithEvents ComboBox9 As ComboBox
    Friend WithEvents ComboBox10 As ComboBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents ComboBox12 As ComboBox
    Friend WithEvents ComboBox13 As ComboBox
    Friend WithEvents ComboBox14 As ComboBox
    Friend WithEvents ComboBox15 As ComboBox

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

    Dim numPlayers As Integer

    Dim cb As New List(Of ComboBox)
    Dim cbAll As New List(Of ComboBox)
    Dim buttonsAll As New List(Of Button)

    Dim dt As New DataTable
    Dim availablePlayers As New List(Of String)
    Dim takenPlayersList As New List(Of String)
    Dim takenPlayers(7) As String
    Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=JamesDB;Trusted_Connection=True;"

    Public Sub New(players As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        populateTable()

        numPlayers = players

        For ind As Integer = 0 To players - 1
            takenPlayers(ind) = "(None Selected)"
        Next

        For Each ComboBox As ComboBox In GetAll(Me, GetType(ComboBox))
            cbAll.Add(ComboBox)
        Next

        For Each Button As Button In GetAll(Me, GetType(Button))
            buttonsAll.Add(Button)
        Next

        'cbAll.Reverse()

        'Add player comboBoxes to first round combo boxes
        For ind As Integer = players - 1 To players * 2 - 2
            cb.Add(cbAll.ElementAt(ind))
        Next

        'Disable all comboBoxes not in first round
        For ind As Integer = 0 To 14
            If ind < players - 1 Or ind > players * 2 - 2 Then
                cbAll(ind).Enabled = False
            End If
        Next

        'Disable all buttons not in first round and add handlers
        For ind As Integer = 0 To 5
            If ind < 4 Then
                If ind <> Math.Log2(CDbl(players)) Then
                    buttonsAll(ind).Enabled = False
                End If
                AddHandler buttonsAll(ind).Click, AddressOf Button_Click
            End If
        Next
        AddHandler buttonsAll(4).Click, AddressOf Button_Click_WOS
        AddHandler buttonsAll(5).Click, AddressOf Button_Click_WS

        'cb.Add(ComboBox8)
        'cb.Add(ComboBox9)
        'cb.Add(ComboBox10)
        'cb.Add(ComboBox11)
        'cb.Add(ComboBox12)
        'cb.Add(ComboBox13)
        'cb.Add(ComboBox14)
        'cb.Add(ComboBox15)

        'Set combobox items and handlers
        Dim index As Integer
        index = 0
        For Each combo As ComboBox In cb
            'combo.DataSource = availablePlayers
            AddHandler combo.SelectionChangeCommitted, AddressOf ComboBox_SIC
            combo.Items.Add(takenPlayers(index))
            combo.Items.AddRange(availablePlayers.ToArray())
            combo.SelectedIndex = 0
            index += 1
        Next

    End Sub

    Private Sub populateTable()
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As New SqlCommand("SELECT GamerTag from PlayerDB ORDER BY GamerTag", connection)
        Dim reader As SqlDataReader = query.ExecuteReader()
        dt.Load(reader)
        connection.Close()
        'availablePlayers.Add("Select")
        For Each row As DataRow In dt.Rows
            availablePlayers.Add(row.Item("GamerTag"))
        Next
    End Sub

    Private Sub ComboBox_SIC(sender As Object, e As EventArgs)
        Dim index As Integer
        Dim se As Integer
        index = 0
        For Each combo As ComboBox In cb
            If combo Is sender Then
                takenPlayersList.Remove(takenPlayers(index))
                takenPlayersList.Add(sender.SelectedItem)
                takenPlayers(index) = sender.SelectedItem
            End If
            index += 1
        Next
        index = 0
        For Each combo As ComboBox In cb
            If combo IsNot sender Then
                combo.Items.Clear()
                If takenPlayers(index) <> "(None Selected)" Then
                    combo.Items.Add("(None Selected)")
                    se = 1
                Else
                    se = 0
                End If
                combo.Items.Add(takenPlayers(index))
                combo.Items.AddRange(availablePlayers.Except(takenPlayersList).ToArray())
                combo.SelectedIndex = se
            End If
            index += 1
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim tier As Integer = buttonsAll.IndexOf(sender)
        If tier = 0 Then
            buttonsAll(tier).Enabled = False
        Else
            buttonsAll(tier).Enabled = False
            buttonsAll(tier - 1).Enabled = True
        End If
        Update_Combos(tier)
    End Sub

    Private Sub Button_Click_WOS(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button_Click_WS(sender As Object, e As EventArgs)
        'Complie number of wins and losses for each player and update database
        Dim tier As Integer = Math.Log2(CDbl(numPlayers))
        While tier > 0
            Dim activePlayers As New List(Of String)
            Dim winners As New List(Of String)
            Dim losers As New List(Of String)
            For index As Integer = Math.Pow(2, CDbl(tier)) - 1 To Math.Pow(2, CDbl(tier)) - 1 + Math.Pow(2, CDbl(tier)) - 1
                activePlayers.Add(cbAll(index).SelectedItem)
            Next
            Dim tierM1 = tier - 1
            Dim indexPrev = 0
            For index As Integer = Math.Pow(2, CDbl(tierM1)) - 1 To Math.Pow(2, CDbl(tierM1)) - 1 + Math.Pow(2, CDbl(tierM1)) - 1
                If cbAll(index).SelectedItem <> "(None Selected)" Then
                    If Not activePlayers(indexPrev) = "(None Selected)" And Not activePlayers(indexPrev + 1) = "(None Selected)" Then
                        winners.Add(cbAll(index).SelectedItem)
                        If activePlayers(indexPrev) <> cbAll(index).SelectedItem Then
                            losers.Add(activePlayers(indexPrev))
                        Else
                            losers.Add(activePlayers(indexPrev + 1))
                        End If
                    End If
                End If
                indexPrev += 2
            Next
            Dim connection As New SqlConnection(connectionString)
            connection.Open()
            For Each winner As String In winners
                Dim query As String = "UPDATE PlayerDB SET Wins = Wins + 1 WHERE GamerTag = " & winner
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            Next
            For Each loser As String In losers
                Dim query As String = "UPDATE PlayerDB SET Losses = Losses + 1 WHERE GamerTag = " & loser
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            Next
            connection.Close()
            tier -= 1
        End While
        Me.Close()
    End Sub

    Private Sub Update_Combos(tier As Integer)
        'Enable / diasble comboBoxes and set items
        Dim playersFromLast As New List(Of String)
        If tier = 0 Then
            cbAll(0).Enabled = False
        Else
            For index As Integer = Math.Pow(2, CDbl(tier)) - 1 To Math.Pow(2, CDbl(tier)) - 1 + Math.Pow(2, CDbl(tier)) - 1
                cbAll(index).Enabled = False
                playersFromLast.Add(cbAll(index).SelectedItem)
            Next
            Dim tierM1 = tier - 1
            Dim indexPrev = 0
            For index As Integer = Math.Pow(2, CDbl(tierM1)) - 1 To Math.Pow(2, CDbl(tierM1)) - 1 + Math.Pow(2, CDbl(tierM1)) - 1
                cbAll(index).Enabled = True
                cbAll(index).Items.Add("(None Selected)")
                For i As Integer = 0 To 1
                    If Not cbAll(index).Items.Contains(playersFromLast(indexPrev + i)) Then
                        cbAll(index).Items.Add(playersFromLast(indexPrev + i))
                    End If
                Next
                cbAll(index).SelectedIndex = 0
                indexPrev += 2
            Next
        End If
    End Sub

    'from https://stackoverflow.com/questions/47911946/get-all-combobox-names-vb-net
    Private Function GetAll(Control As Control, Type As Type) As IEnumerable(Of Control)
        Dim Controls = Control.Controls.Cast(Of Control)()
        Return Controls.SelectMany(Function(x) GetAll(x, Type)).Concat(Controls).Where(Function(y) y.GetType = Type)
    End Function

End Class
