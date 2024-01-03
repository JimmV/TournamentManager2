Public Class Gamer
    Private playername As String
    Private gamerTag As String
    Private wins As Integer
    Private losses As Integer

    Public Property PropPlayername() As String
        Get
            ' Gets the property value.
            Return playername
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            playername = Value
        End Set
    End Property

    Public Property PropGamerTag() As String
        Get
            ' Gets the property value.
            Return gamerTag
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            gamerTag = Value
        End Set
    End Property

    Public Property PropWins() As Integer
        Get
            ' Gets the property value.
            Return wins
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            wins = Value
        End Set
    End Property

    Public Property PropLosses() As Integer
        Get
            ' Gets the property value.
            Return losses
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            losses = Value
        End Set
    End Property
End Class
