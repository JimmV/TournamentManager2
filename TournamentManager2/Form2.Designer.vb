Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BracketForm
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
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(598, 212)
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
        ' BracketForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ComboBox15)
        Controls.Add(ComboBox14)
        Controls.Add(ComboBox13)
        Controls.Add(ComboBox12)
        Controls.Add(ComboBox11)
        Controls.Add(ComboBox10)
        Controls.Add(ComboBox9)
        Controls.Add(ComboBox8)
        Controls.Add(ComboBox7)
        Controls.Add(ComboBox6)
        Controls.Add(ComboBox5)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
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

    Dim cb As New List(Of ComboBox)

    Dim dt As New DataTable
    Dim availablePlayers As New List(Of String)
    Dim takenPlayersList As New List(Of String)
    Dim takenPlayers(7) As String
    Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=JamesDB;Trusted_Connection=True;"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        populateTable()
        For ind As Integer = 0 To 7
            takenPlayers(ind) = "(None Selected)"
        Next

        cb.Add(ComboBox8)
        cb.Add(ComboBox9)
        cb.Add(ComboBox10)
        cb.Add(ComboBox11)
        cb.Add(ComboBox12)
        cb.Add(ComboBox13)
        cb.Add(ComboBox14)
        cb.Add(ComboBox15)

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
End Class
