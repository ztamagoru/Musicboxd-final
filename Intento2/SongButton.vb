Imports System.IO

Public Class SongButton
    Dim songs As New cancion

    Public Sub seteartexto(song As String, artist As String, coverimage As Byte())
        lbl_songname.Text = song
        lbl_artistname.Text = artist
        cover.Image = Image.FromStream(New MemoryStream(coverimage))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, lbl_songname.Click, lbl_artistname.Click, cover.Click
        songs.specificsong(lbl_songname.Text, lbl_artistname.Text)
        Me.Dispose()
    End Sub
End Class
