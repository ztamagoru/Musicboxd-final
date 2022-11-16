Imports System.Data.SqlClient

Public Class validador
    Private Shared _code As String
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

    Private Property code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
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
            MessageBox.Show("Error",
                            "Usuario o contraseña incorrectos.",
                            MessageBoxButtons.OK)
        End Try

        Return iniciarSesion
    End Function

    Public Sub validarDatos(user As String, pass As String, mail As String)


    End Sub
End Class
