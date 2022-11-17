Imports System.Data.SqlClient

Public Class conexion
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dataadapter As New SqlDataAdapter
    Public dataset As New DataSet

    Public Sub New()
        Try
            Dim server As String

            ' Si estoy trabajando con la pc:
            server = "DESKTOP-ULVBESH\SQLEXPRESS"

            ' Si estoy trabajando con la notebook:
            'server = "(Localdb)\servidormaria"

            With conn
                .ConnectionString = $"Server={server};Database=Musicboxd;Integrated Security=true;User Id=test;Password=wasd1234;"
                '.ConnectionTimeout = 60

                .Open()
            End With

            cmd.Connection = conn
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub execute(comando As SqlCommand)
        Try
            cmd = comando

            cmd.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message, vbOK)
        End Try
    End Sub
End Class
