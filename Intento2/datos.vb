﻿Imports System.Data.SqlClient

Public Class datos
    Dim conexion As New conexion
    'Dim validador As validador

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

            conexion.closeDatabase()
        End With
    End Sub

    Public Function compararDatos() As Integer
        conexion.cmd = New SqlCommand("[Users].[SP_VERIFY_EXISTING_ACCOUNT]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", validador.username)
            .Parameters.AddWithValue("@email", validador.useremail)
            .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output

            .ExecuteScalar()

            If .Parameters("@result").Value <> 0 Then
                Return .Parameters("@result").Value
            End If

            conexion.closeDatabase()
        End With

        Return 0
    End Function

    Public Sub registrarUsuario()
        conexion.cmd = New SqlCommand("[Users].[SP_CREATE_ACCOUNT]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", validador.username)
            .Parameters.AddWithValue("@password", validador.password)
            .Parameters.AddWithValue("@mail", validador.useremail)
            .Parameters.AddWithValue("@name", validador.uname)
            .Parameters.AddWithValue("@surname", validador.usurname)

            .ExecuteScalar()

            conexion.closeDatabase()
        End With
    End Sub
End Class
