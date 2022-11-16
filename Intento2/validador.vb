Imports System.Data.SqlClient

Public Class validador
    Private Shared code As String
    Private _rol As Integer

    Private comando As New SqlCommand

    Dim conexion As New conexion

    Public Property rol As Integer
        Get
            Return _rol
        End Get
        Set(value As Integer)
            _rol = value
        End Set
    End Property

    Public Function iniciarSesion(user As String, pass As String) As Integer
        iniciarSesion = 0

        Try
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@username", user)
                .Parameters.AddWithValue("@password", pass)
                .Parameters.Add("@rol", SqlDbType.Int).Direction = ParameterDirection.Output
            End With

            conexion.execute(comando)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return iniciarSesion
    End Function
End Class
