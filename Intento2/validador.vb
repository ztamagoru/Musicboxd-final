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

        conexion.cmd = New SqlCommand("[Users].[SP_LOG_IN]", conexion.conn)

        Try
            With conexion.cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@username", user)
                .Parameters.AddWithValue("@password", pass)
                .Parameters.Add("@rol", SqlDbType.Int).Direction = ParameterDirection.Output

                .ExecuteScalar()

                If .Parameters("@rol").Value <> 0 Then
                    iniciarSesion = .Parameters("@rol").Value
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return iniciarSesion
    End Function
End Class
