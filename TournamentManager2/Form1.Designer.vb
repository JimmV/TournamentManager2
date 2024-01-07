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
        NameTitle = New TextBox()
        NameBox = New TextBox()
        GamerTitle = New TextBox()
        WinsTitle = New TextBox()
        LossesTitle = New TextBox()
        GamerBox = New TextBox()
        WinsBox = New TextBox()
        LossesBox = New TextBox()
        UpdateButton = New Button()
        DeleteButton = New Button()
        AddButton = New Button()
        MessageBox = New TextBox()
        BracketButton = New Button()
        Label1 = New System.Windows.Forms.Label()
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
        ' NameTitle
        ' 
        NameTitle.Location = New Point(386, 31)
        NameTitle.Name = "NameTitle"
        NameTitle.ReadOnly = True
        NameTitle.Size = New Size(125, 27)
        NameTitle.TabIndex = 1
        NameTitle.Text = "Name"
        ' 
        ' NameBox
        ' 
        NameBox.Location = New Point(540, 35)
        NameBox.Name = "NameBox"
        NameBox.Size = New Size(228, 27)
        NameBox.TabIndex = 2
        ' 
        ' GamerTitle
        ' 
        GamerTitle.Location = New Point(386, 84)
        GamerTitle.Name = "GamerTitle"
        GamerTitle.ReadOnly = True
        GamerTitle.Size = New Size(125, 27)
        GamerTitle.TabIndex = 4
        GamerTitle.Text = "Gammer Tag"
        ' 
        ' WinsTitle
        ' 
        WinsTitle.Location = New Point(386, 139)
        WinsTitle.Name = "WinsTitle"
        WinsTitle.ReadOnly = True
        WinsTitle.Size = New Size(125, 27)
        WinsTitle.TabIndex = 5
        WinsTitle.Text = "Wins"
        ' 
        ' LossesTitle
        ' 
        LossesTitle.Location = New Point(386, 195)
        LossesTitle.Name = "LossesTitle"
        LossesTitle.ReadOnly = True
        LossesTitle.Size = New Size(125, 27)
        LossesTitle.TabIndex = 6
        LossesTitle.Text = "Losses"
        ' 
        ' GamerBox
        ' 
        GamerBox.Location = New Point(540, 84)
        GamerBox.Name = "GamerBox"
        GamerBox.Size = New Size(228, 27)
        GamerBox.TabIndex = 7
        ' 
        ' WinsBox
        ' 
        WinsBox.Location = New Point(540, 139)
        WinsBox.Name = "WinsBox"
        WinsBox.Size = New Size(228, 27)
        WinsBox.TabIndex = 8
        ' 
        ' LossesBox
        ' 
        LossesBox.Location = New Point(540, 195)
        LossesBox.Name = "LossesBox"
        LossesBox.Size = New Size(228, 27)
        LossesBox.TabIndex = 9
        ' 
        ' UpdateButton
        ' 
        UpdateButton.Location = New Point(386, 320)
        UpdateButton.Name = "UpdateButton"
        UpdateButton.Size = New Size(94, 29)
        UpdateButton.TabIndex = 10
        UpdateButton.Text = "Update"
        UpdateButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Location = New Point(504, 320)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(94, 29)
        DeleteButton.TabIndex = 11
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(634, 320)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(94, 29)
        AddButton.TabIndex = 12
        AddButton.Text = "Add"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' MessageBox
        ' 
        MessageBox.Location = New Point(386, 260)
        MessageBox.Name = "MessageBox"
        MessageBox.ReadOnly = True
        MessageBox.Size = New Size(382, 27)
        MessageBox.TabIndex = 13
        ' 
        ' BracketButton
        ' 
        BracketButton.Location = New Point(504, 368)
        BracketButton.Name = "BracketButton"
        BracketButton.Size = New Size(94, 29)
        BracketButton.TabIndex = 14
        BracketButton.Text = "Bracket"
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(BracketButton)
        Controls.Add(MessageBox)
        Controls.Add(AddButton)
        Controls.Add(DeleteButton)
        Controls.Add(UpdateButton)
        Controls.Add(LossesBox)
        Controls.Add(WinsBox)
        Controls.Add(GamerBox)
        Controls.Add(LossesTitle)
        Controls.Add(WinsTitle)
        Controls.Add(GamerTitle)
        Controls.Add(NameBox)
        Controls.Add(NameTitle)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Tournament Manager"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents NameTitle As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents GamerTitle As TextBox
    Friend WithEvents WinsTitle As TextBox
    Friend WithEvents LossesTitle As TextBox
    Friend WithEvents GamerBox As TextBox
    Friend WithEvents WinsBox As TextBox
    Friend WithEvents LossesBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents MessageBox As TextBox
    Friend WithEvents BracketButton As Button

    Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=JamesDB;Trusted_Connection=True;"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        populateLB()
    End Sub

    Private Sub populateLB()
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

    Private Sub selectLB()
        ' something here to select without the button would be nice
    End Sub

    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.MouseClick
        Dim selectedItem = ListBox1.SelectedItem
        NameBox.Text = selectedItem
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "SELECT * from PlayerDB WHERE GamerTag = " + selectedItem
        Dim command As New SqlCommand(query, connection)
        Dim reader = command.ExecuteReader
        Dim dt As New DataTable
        dt.Load(reader)
        connection.Close()

        For Each row As DataRow In dt.Rows
            NameBox.Text = row.Item("Playername")
            GamerBox.Text = row.Item("GamerTag")
            WinsBox.Text = row.Item("Wins")
            LossesBox.Text = row.Item("Losses")
        Next
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim selectedItem = ListBox1.SelectedItem

        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "UPDATE PlayerDB SET "
        query &= "Playername = '" & NameBox.Text
        query &= "', GamerTag = '" & GamerBox.Text
        query &= "', Wins = " & CInt(WinsBox.Text)
        query &= ", Losses = " & CInt(LossesBox.Text)
        query &= " WHERE GamerTag = " & selectedItem
        Dim command As New SqlCommand(query, connection)
        command.ExecuteNonQuery()
        connection.Close()
        populateLB()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim selectedItem = ListBox1.SelectedItem

        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Dim query As String = "DELETE from PlayerDB WHERE GamerTag = " & selectedItem
        Dim command As New SqlCommand(query, connection)
        command.ExecuteNonQuery()
        connection.Close()
        populateLB()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Try
            Dim query As String = "INSERT INTO PlayerDB VALUES ('" & NameBox.Text & "', '" & GamerBox.Text & "', " & CInt(WinsBox.Text) & ", " & CInt(LossesBox.Text) & ")"
            Dim command As New SqlCommand(query, connection)
            command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Text = ex.Message
        End Try
        connection.Close()
        populateLB()
    End Sub

    Private Sub BracketButton_Click(sender As Object, e As EventArgs) Handles BracketButton.Click
        Dim bf As New BracketForm(8)
        bf.Show()
    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
