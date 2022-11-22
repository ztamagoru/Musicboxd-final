Imports System.Data.SqlClient

Public Class review
    Dim conexion As New conexion

    Public Sub getreviews(songname As String, artistname As String, Optional i As Integer = 1)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_GET_SONG_REVIEWS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@name", songname)
            .Parameters.AddWithValue("@artist", artistname)
            .Parameters.AddWithValue("@order", i)

            Dim reader As SqlDataReader

            reader = .ExecuteReader()

            SongInfo.FlowLayoutPanel1.Controls.Clear()

            If reader.Read() Then
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
End Class
