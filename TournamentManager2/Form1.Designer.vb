Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows.Input
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        ListBox1 = New ListBox()
        NameBox = New TextBox()
        GamerBox = New TextBox()
        UpdateButton = New Button()
        DeleteButton = New Button()
        AddButton = New Button()
        BracketButton = New Button()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        NumPlayersBox = New ComboBox()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        WinsNumBox = New NumericUpDown()
        LossesNumBox = New NumericUpDown()
        MessageLabel = New System.Windows.Forms.Label()
        CType(WinsNumBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(LossesNumBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(23, 43)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(323, 384)
        ListBox1.TabIndex = 0
        ' 
        ' NameBox
        ' 
        NameBox.Location = New Point(540, 35)
        NameBox.Name = "NameBox"
        NameBox.Size = New Size(228, 27)
        NameBox.TabIndex = 2
        ' 
        ' GamerBox
        ' 
        GamerBox.Location = New Point(540, 84)
        GamerBox.Name = "GamerBox"
        GamerBox.Size = New Size(228, 27)
        GamerBox.TabIndex = 7
        ' 
        ' UpdateButton
        ' 
        UpdateButton.Location = New Point(402, 245)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(94, 29)
        UpdateButton.TabIndex = 10
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(540, 245)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(94, 29)
        DeleteButton.TabIndex = 11
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(674, 245)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(94, 29)
        AddButton.TabIndex = 12
        AddButton.Text = "Add"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' BracketButton
        ' 
        BracketButton.Location = New Point(663, 302)
        BracketButton.Name = "BracketButton"
        BracketButton.Size = New Size(105, 27)
        BracketButton.TabIndex = 14
        BracketButton.Text = "New Bracket"
        BracketButton.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 15
        Label1.Text = "Gamer Tags"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(402, 302)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 17
        Label2.Text = "Bracket Size:"
        ' 
        ' NumPlayersBox
        ' 
        NumPlayersBox.FormattingEnabled = True
        NumPlayersBox.Location = New Point(559, 299)
        NumPlayersBox.Name = "NumPlayersBox"
        NumPlayersBox.Size = New Size(58, 28)
        NumPlayersBox.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(442, 35)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 20)
        Label3.TabIndex = 19
        Label3.Text = "Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(411, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 20
        Label4.Text = "Gamer Tag:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(450, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 21
        Label5.Text = "Wins:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(442, 195)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 20)
        Label6.TabIndex = 22
        Label6.Text = "Losses:"
        ' 
        ' WinsNumBox
        ' 
        WinsNumBox.Location = New Point(540, 139)
        WinsNumBox.Name = "WinsNumBox"
        WinsNumBox.Size = New Size(150, 27)
        WinsNumBox.TabIndex = 23
        ' 
        ' LossesNumBox
        ' 
        LossesNumBox.Location = New Point(540, 195)
        LossesNumBox.Name = "LossesNumBox"
        LossesNumBox.Size = New Size(150, 27)
        LossesNumBox.TabIndex = 24
        ' 
        ' MessageLabel
        ' 
        MessageLabel.Location = New Point(368, 347)
        MessageLabel.MaximumSize = New Size(400, 100)
        MessageLabel.Name = "MessageLabel"
        MessageLabel.Size = New Size(400, 80)
        MessageLabel.TabIndex = 25
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MessageLabel)
        Controls.Add(LossesNumBox)
        Controls.Add(WinsNumBox)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(NumPlayersBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BracketButton)
        Controls.Add(AddButton)
        Controls.Add(DeleteButton)
        Controls.Add(UpdateButton)
        Controls.Add(GamerBox)
        Controls.Add(NameBox)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Tournament Manager"
        CType(WinsNumBox, ComponentModel.ISupportInitialize).EndInit()
        CType(LossesNumBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents GamerBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents BracketButton As Button

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumPlayersBox As ComboBox

    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents WinsNumBox As NumericUpDown
    Friend WithEvents LossesNumBox As NumericUpDown

    Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=JamesDB;Trusted_Connection=True;"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        populateLB()
        NumPlayersBox.Items.AddRange({2, 4, 8})
        NumPlayersBox.SelectedIndex = 0
    End Sub

    Private Sub populateLB()
        AddHandler ListBox1.Click, AddressOf ListBox1_Click
        ListBox1.Items.Clear()
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As New SqlCommand("SELECT GamerTag from PlayerDB ORDER BY GamerTag", connection)
        Dim reader As SqlDataReader = query.ExecuteReader()
        Dim dt As New DataTable()
        dt.Load(reader)
        connection.Close()
        For Each row As DataRow In dt.Rows
            ListBox1.Items.Add(row.Item("GamerTag"))
        Next
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs)
        Dim selectedItem = ListBox1.SelectedItem
        NameBox.Text = selectedItem
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "SELECT * from PlayerDB WHERE GamerTag = '" & selectedItem & "'"
        Dim command As New SqlCommand(query, connection)
        Dim reader = command.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        connection.Close()

        For Each row As DataRow In dt.Rows
            NameBox.Text = row.Item("Playername")
            GamerBox.Text = row.Item("GamerTag")
            WinsNumBox.Value = row.Item("Wins")
            LossesNumBox.Value = row.Item("Losses")
        Next
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If GamerBox.Text <> "" And NameBox.Text <> "" Then
            Dim connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "UPDATE PlayerDB SET "
            query &= "Playername = '" & NameBox.Text
            query &= "', GamerTag = '" & GamerBox.Text
            query &= "', Wins = " & WinsNumBox.Value
            query &= ", Losses = " & LossesNumBox.Value
            query &= " WHERE GamerTag = '" & GamerBox.Text & "'"
            Dim command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
            connection.Close()
            populateLB()
        Else
            MessageLabel.Text = "The Name and Gamer Tag must both be non-empty"
        End If

    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If GamerBox.Text <> "" Then
            Dim connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "DELETE from PlayerDB WHERE GamerTag = '" & ListBox1.SelectedItem & "'"
            Dim command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
            connection.Close()
            populateLB()
        Else
            MessageLabel.Text = "The Gamer Tag must be non-empty"
        End If

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If NameBox.Text <> "" And GamerBox.Text <> "" Then
            Dim connection As New SqlConnection(connectionString)
            connection.Open()
            Try
                Dim query As String = "INSERT INTO PlayerDB VALUES ('" & NameBox.Text & "', '" & GamerBox.Text & "', " & WinsNumBox.Value & ", " & LossesNumBox.Value & ")"
                Dim command As New SqlCommand(query, connection)
                command.ExecuteNonQuery()
            Catch ex As Exception
                Dim message As String = ""
                message &= "Cannot insert duplicate: "
                message &= ex.Message.Substring(ex.Message.IndexOf("("))
                MessageLabel.Text = message
            End Try
            connection.Close()
            populateLB()
        Else
            MessageLabel.Text = "The Name and Gamer Tag must both be non-empty"
        End If

    End Sub

    Private Sub BracketButton_Click(sender As Object, e As EventArgs) Handles BracketButton.Click
        Dim bf As New BracketForm(NumPlayersBox.SelectedItem)
        bf.Show()
    End Sub

    Friend WithEvents MessageLabel As System.Windows.Forms.Label

End Class
