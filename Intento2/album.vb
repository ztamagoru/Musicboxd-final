Imports System.Data.SqlClient
Imports System.IO

Public Class album
    Inherits song

    Dim conexion As New conexion

    Private _idalbum As Integer

    Public Property idalbum As Integer
        Get
            Return _idalbum
        End Get
        Set(value As Integer)
            _idalbum = value
        End Set
    End Property


    Public Sub specificalbum(album As String, artist As String)
        album = Replace(album, "...", "")

        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_GET_ALBUM_DETAILS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@album", album)
            .Parameters.AddWithValue("@artist", artist)

            Dim reader As SqlDataReader

            reader = .ExecuteReader

            reader.Read()

            With AlbumInfo
                .lbl_album.Text = reader.GetString(0)
                .lbl_artist.Text = reader.GetString(1)

                Dim bytes = CType(reader(2), Byte())

                .cover.Image = Image.FromStream(New MemoryStream(bytes))

                .lbl_description.Text = $"{reader.GetString(3)}{vbNewLine}Songs list:"

                .spotifyLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(4), String))
                .itunesLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(5), String))
                .deezerLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(6), String))
            End With

            idalbum = reader.GetInt32(7)

            reader.Close()
        End With

        conexion.cmd = New SqlCommand("[Songs].[SP_GET_ALBUM_SONGS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@idalbum", idalbum)

            Dim reader As SqlDataReader
            Dim i As Integer = 0

            reader = .ExecuteReader

            While reader.Read
                With AlbumInfo
                    If i Mod 2 = 0 Then
                        .lbl_songslist1.Text += $"{reader.GetString(0)}{vbNewLine}"
                    Else
                        .lbl_songslist2.Text += $"{reader.GetString(0)}{vbNewLine}"
                    End If
                End With

                i += 1
            End While

            With AlbumInfo
                With .lbl_songslist1
                    .Text = Replace(.Text, "songslist1", "")
                End With

                With .lbl_songslist2
                    .Text = Replace(.Text, "songslist2", "")
                End With
            End With

            reader.Close()
        End With

        conexion.closeDatabase()
    End Sub

    Public Sub searchalbum(search As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_ALBUM_SEARCH]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@search", search)

            Dim reader As SqlDataReader

            reader = .ExecuteReader

            If reader.HasRows Then
                While reader.Read
                    Dim albumbutton As New AlbumButton

                    Dim name = reader.GetString(0)

                    If Len(name) > 17 Then
                        name = $"{Left(name, 17)}..."
                    End If

                    Dim artist = reader.GetString(1)
                    Dim cover = CType(reader(2), Byte())

                    albumbutton.seteartexto(name, artist, cover)

                    SearchMenu.albumpanel.Controls.Add(albumbutton)
                End While
            Else
                SearchMenu.albumpanel.Visible = False
            End If

            reader.Close()
        End With

        conexion.closeDatabase()
    End Sub
End Class
