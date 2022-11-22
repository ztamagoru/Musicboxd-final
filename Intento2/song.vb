Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class song
    Dim conexion As New conexion
    Dim rating As New rating
    Dim review As New review

    Private Shared _idsong As Integer

    Public Shared Property idsong As Integer
        Get
            Return _idsong
        End Get
        Set(value As Integer)
            _idsong = value
        End Set
    End Property

    Public Sub obtainrecommendations()
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

                idsong = reader.GetInt32(7)

                reader.Close()

                review.getreviews(.lbl_songName.Text, .lbl_artistName.Text)
                rating.getuserrating()
            End With
        End With

        conexion.closeDatabase()
    End Sub

    Public Sub searchsong(search As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_SONG_SEARCH]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@search", search)

            Dim reader As SqlDataReader

            reader = .ExecuteReader

            If reader.HasRows() Then
                While reader.Read()
                    Dim songbutton As New SongButton

                    Dim song = reader.GetString(0)

                    If Len(song) > 17 Then
                        song = $"{Left(song, 17)}..."
                    End If

                    Dim artist = reader.GetString(1)
                    Dim cover = CType(reader(2), Byte())

                    songbutton.seteartexto(song, artist, cover)

                    SearchMenu.songspanel.Controls.Add(songbutton)
                End While
            Else
                SearchMenu.songspanel.Visible = False
            End If

            reader.Close()
        End With

        conexion.closeDatabase()
    End Sub
End Class