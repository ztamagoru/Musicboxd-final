Imports System.Data.SqlClient

Public Class review
    Dim conexion As New conexion

    Public Sub getreviews(songname As String, artistname As String, Optional i As Integer = 1)
        SongInfo.FlowLayoutPanel1.Visible = True

        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_GET_SONG_REVIEWS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@name", songname)
            .Parameters.AddWithValue("@artist", artistname)
            .Parameters.AddWithValue("@order", i)

            Dim reader As SqlDataReader

            reader = .ExecuteReader()

            If reader.HasRows() Then
                While reader.Read()
                    Dim review As New ReviewItem

                    Dim username = reader.GetString(0)
                    Dim resena = reader.GetString(1)
                    Dim fecha = CType(reader(2), String)

                    review.SetearDatosDeReview(username, resena, fecha)

                    SongInfo.FlowLayoutPanel1.Controls.Add(review)
                End While
            Else
                SongInfo.FlowLayoutPanel1.Visible = False
            End If

            reader.Close()
        End With

        conexion.closeDatabase()
    End Sub

    Public Sub uploadreview(review As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Users].[SP_SAVE_REVIEW]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", SongInfo._username.Text)
            .Parameters.AddWithValue("@idsong", song.idsong)
            .Parameters.AddWithValue("@review", review)

            .ExecuteScalar()
        End With

        conexion.closeDatabase()

        With SongInfo
            getreviews(.lbl_songName.Text, .lbl_artistName.Text)
        End With
    End Sub
End Class
