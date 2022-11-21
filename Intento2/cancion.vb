Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class cancion
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

    Public Sub obtenerRecomendaciones()
        Dim songName(3), artistName(3) As String

        Dim i As Integer = 0

        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_4_RECOMMENDATIONS]", conexion.conn)

        conexion.cmd.CommandType = CommandType.StoredProcedure

        Dim reader As SqlDataReader

        reader = conexion.cmd.ExecuteReader()

        While reader.Read()
            songName(i) = reader.GetString(0)
            artistName(i) = reader.GetString(1)

            If songName(i).Length() > 17 Then
                songName(i) = $"{Left(songName(i), 17)}..."
            End If

            i += 1

            Dim bytes = CType(reader(2), Byte())

            MenuPrincipal.addCover(bytes, i)
        End While

        conexion.closeDatabase()

        With MenuPrincipal
            .songName1.Text = songName(0)
            .songName2.Text = songName(1)
            .songName3.Text = songName(2)
            .songName4.Text = songName(3)

            .artistName1.Text = artistName(0)
            .artistName2.Text = artistName(1)
            .artistName3.Text = artistName(2)
            .artistName4.Text = artistName(3)
        End With
    End Sub

    Public Sub specificsong(songs As String, artist As String)
        songs = Replace(songs, "...", "", 1)

        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_GET_SONG_DETAILS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@name", songs)
            .Parameters.AddWithValue("@artist", artist)

            Dim reader As SqlDataReader

            reader = .ExecuteReader()

            reader.Read()

            With SongInfo
                .lbl_songName.Text = reader.GetString(0)
                .lbl_artistName.Text = reader.GetString(1)

                .lbl_promedio.Text = CType(reader(2), String)

                Dim bytes = CType(reader(3), Byte())

                .cover.Image = Image.FromStream(New MemoryStream(bytes))

                .spotifyLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(4), String))
                .itunesLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(5), String))
                .deezerLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(6), String))

                reader.Close()

                conexion.closeDatabase()

                getreviews(.lbl_songName.Text, .lbl_artistName.Text)
            End With
        End With
    End Sub

    Private Sub getreviews(songname As String, artistname As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_GET_SONG_REVIEWS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@name", songname)
            .Parameters.AddWithValue("@artist", artistname)

            Dim reader As SqlDataReader

            reader = .ExecuteReader()
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
                'MsgBox("no hay reseñas disponibles al momento")
            End If

            reader.Close()
        End With

        conexion.closeDatabase()
    End Sub
End Class
