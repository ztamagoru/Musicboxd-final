Imports System.IO

Public Class SongButton
    Dim songs As New song

    Public Sub seteartexto(song As String, artist As String, coverimage As Byte())
        lbl_songname.Text = song
        lbl_artistname.Text = artist
        cover.Image = Image.FromStream(New MemoryStream(coverimage))
    End Sub

    Private Sub selectsong(sender As Object, e As EventArgs) Handles buttonbackground.Click, lbl_songname.Click, lbl_artistname.Click, cover.Click
        songs.specificsong(lbl_songname.Text, lbl_artistname.Text)
        SongInfo.Show()
        SearchMenu.Dispose()
    End Sub

    Private Sub hoverEnter(sender As Object, e As EventArgs) Handles buttonbackground.MouseEnter, lbl_songname.MouseEnter, lbl_artistname.MouseEnter, cover.MouseEnter
        buttonbackground.Image = My.Resources.fondo_boton_oscuro
        lbl_artistname.BackColor = Color.FromArgb(195, 206, 204)
        lbl_songname.BackColor = Color.FromArgb(195, 206, 204)
    End Sub

    Private Sub hoverLeave(sender As Object, e As EventArgs) Handles buttonbackground.MouseLeave, lbl_songname.MouseLeave, lbl_artistname.MouseLeave, cover.MouseLeave
        buttonbackground.Image = My.Resources.fondo_boton_claro
        lbl_artistname.BackColor = Color.FromArgb(216, 227, 225)
        lbl_songname.BackColor = Color.FromArgb(216, 227, 225)
    End Sub
End Class
