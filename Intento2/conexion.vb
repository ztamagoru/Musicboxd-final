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
                .ConnectionString = $"Data Source={server};Initial Catalog=Musicboxd;Integrated Security=True;"
            End With

            cmd.Connection = conn
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub openDatabase()
        conn.Open()
    End Sub

    Public Sub closeDatabase()
        conn.Close()
    End Sub

    Public Sub execute(comando As SqlCommand)
        Try
            cmd = comando

            conn.Open()

            cmd.ExecuteScalar()

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOK)
        End Try
    End Sub

    Public Function executeReader(comando As String) As SqlDataReader
        Try
            cmd.CommandText = comando

            conn.Open()

            executeReader = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return executeReader
    End Function
End Class
