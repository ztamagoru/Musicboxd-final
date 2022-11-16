Imports System.Data.SqlClient

Public Class datos
    Dim conexion As New conexion

    Private _rol As Integer

    Public Property rol As Integer
        Get
            Return _rol
        End Get
        Set(value As Integer)
            _rol = value
        End Set
    End Property

    Public Sub inicioSesion(user As String, pass As String)
        conexion.cmd = New SqlCommand("[Users].[SP_LOG_IN]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", user)
            .Parameters.AddWithValue("@password", pass)
            .Parameters.Add("@rol", SqlDbType.Int).Direction = ParameterDirection.Output

            .ExecuteScalar()

            If .Parameters("@rol").Value <> 0 Then
                rol = .Parameters("@rol").Value
            Else
                rol = 0
            End If
        End With
    End Sub

    Public Function compararDatos(user As String, email As String) As Boolean
        Try
            conexion.cmd = New SqlCommand("[Users].[SP_VERIFY_EXISTING_ACCOUNT]", conexion.conn)

            With conexion.cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@username", user)
                .Parameters.AddWithValue("@email", email)
                .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output

                .ExecuteScalar()

                If .Parameters("@result").Value <> 0 Then
                    Return .Parameters("@result").Value
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return 0
    End Function
End Class
