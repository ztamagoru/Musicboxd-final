Imports System.Data.SqlClient

Public Class rating
    Dim conexion As New conexion

    Private Shared _rating As Integer = 0

    Public Shared Property rating As Integer
        Get
            Return _rating
        End Get
        Set(value As Integer)
            _rating = value
        End Set
    End Property

    Public Sub getuserrating()
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Users].[SP_GET_USER_RATE]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", MenuPrincipal._username.Text)
            .Parameters.AddWithValue("@songid", song.idsong)
            .Parameters.Add("@rate", sqlDbType:=SqlDbType.Int).Direction = ParameterDirection.Output

            .ExecuteScalar()

            If Not .Parameters("@rate").Value Is DBNull.Value Then
                rating = .Parameters("@rate").Value
            Else
                rating = 0
            End If
        End With

        conexion.closeDatabase()

        SongInfo.setstars(rating)
    End Sub

    Public Sub changerating(rate As Integer)
        If rate <> rating Then
            rating = rate

            conexion.openDatabase()
            conexion.cmd = New SqlCommand("[Users].[SP_SAVE_RATING]", conexion.conn)

            With conexion.cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@username", SongInfo._username.Text)
                .Parameters.AddWithValue("@rate", rate)
                .Parameters.AddWithValue("@idsong", song.idsong)

                .ExecuteScalar()
            End With

            SongInfo.setstars(rating)

            conexion.closeDatabase()

            refreshratings()

        End If
    End Sub

    Private Sub refreshratings()
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_REFRESH_RATING]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@idsong", song.idsong)
            .Parameters.Add("@rating", sqlDbType:=SqlDbType.Float).Direction = ParameterDirection.Output

            .ExecuteScalar()

            SongInfo.lbl_promedio.Text = CType(.Parameters("@rating").Value, String)
            SongInfo.lbl_promedio.Text = $"{Left(SongInfo.lbl_promedio.Text, 3)}"
        End With

        conexion.closeDatabase()
    End Sub
End Class
