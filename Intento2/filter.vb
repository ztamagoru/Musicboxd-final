Public Class filter

    Private _description As String

    Public Property description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Sub New(z As String)
        description = z
    End Sub
End Class
