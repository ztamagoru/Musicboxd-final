Public Class search
    Dim songs As New song
    Dim album As New album
    Dim artist As New artist

    Public Sub makesearch(search As String)
        songs.searchsong(search)
        artist.searchartist(search)
        album.searchalbum(search)
    End Sub
End Class
