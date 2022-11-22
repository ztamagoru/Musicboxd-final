Imports System.Data.SqlClient
Imports System.IO

Public Class artist
    Inherits album

    Dim conexion As New conexion

    Private _idartist As Integer

    Public Property idartist As Integer
        Get
            Return _idartist
        End Get
        Set(value As Integer)
            _idartist = value
        End Set
    End Property

    Public Sub searchartist(search As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_ARTIST_SEARCH]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@search", search)

            Dim reader As SqlDataReader

            reader = .ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    Dim artistbutton As New ArtistButton

                    Dim name = reader.GetString(0)
                    Dim photo = CType(reader(1), Byte())

                    artistbutton.seteartexto(name, photo)

                    SearchMenu.artistpanel.Controls.Add(artistbutton)
                End While
            Else
                SearchMenu.artistpanel.Visible = False
            End If

            reader.Close()
        End With

        conexion.closeDatabase()
    End Sub

    Public Sub specificartist(name As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_GET_ARTIST_DETAILS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@name", name)

            Dim reader As SqlDataReader

            reader = .ExecuteReader

            reader.Read()

            With ArtistInfo
                .lbl_artistname.Text = reader.GetString(0)

                idartist = reader.GetInt32(1)

                .lbl_description.Text = $"{reader.GetString(2)}{vbNewLine}Albums:"

                Dim bytes = CType(reader(3), Byte())

                .photo.Image = Image.FromStream(New MemoryStream(bytes))

                .spotifyLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(4), String))
                .itunesLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(5), String))
                .deezerLink.Links.Add(0, Len(.spotifyLink.Text), CType(reader(6), String))
            End With

            reader.Close()
        End With

        conexion.cmd = New SqlCommand("[Songs].[SP_GET_ARTIST_ALBUMS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@idartist", idartist)

            Dim reader As SqlDataReader
            Dim i As Integer = 0

            reader = .ExecuteReader

            While reader.Read
                With ArtistInfo
                    If i Mod 2 = 0 Then
                        .lbl_albumlist1.Text += $"{reader.GetString(0)}{vbNewLine}"
                    Else
                        .lbl_albumlist2.Text += $"{reader.GetString(0)}{vbNewLine}"
                    End If
                End With
            End While

            With ArtistInfo
                .lbl_albumlist1.Text = Replace(.lbl_albumlist1.Text, "albumlist1", "")
                .lbl_albumlist2.Text = Replace(.lbl_albumlist2.Text, "albumlist2", "")
            End With

            reader.Close()
        End With


        conexion.closeDatabase()
    End Sub
End Class
