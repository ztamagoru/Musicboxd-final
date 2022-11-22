Imports System.IO

Public Class AlbumButton
    Dim album As New album

    Public Sub seteartexto(albumname As String, artistname As String, photo As Byte())
        lbl_albumname.Text = albumname
        lbl_artistname.Text = artistname
        cover.Image = Image.FromStream(New MemoryStream(photo))
    End Sub

    Private Sub selectalbum(sender As Object, e As EventArgs) Handles lbl_artistname.Click, lbl_albumname.Click, cover.Click, buttonbackground.Click
        album.specificalbum(lbl_albumname.Text, lbl_artistname.Text)
        SearchMenu.Dispose()
        AlbumInfo.Show()
    End Sub

    Private Sub buttonbackground_MouseEnter(sender As Object, e As EventArgs) Handles lbl_artistname.MouseEnter, lbl_albumname.MouseEnter, cover.MouseEnter, buttonbackground.MouseEnter
        buttonbackground.Image = My.Resources.fondo_boton_oscuro
        lbl_albumname.BackColor = Color.FromArgb(195, 206, 204)
        lbl_artistname.BackColor = Color.FromArgb(195, 206, 204)
    End Sub

    Private Sub buttonbackground_MouseLeave(sender As Object, e As EventArgs) Handles lbl_artistname.MouseLeave, lbl_albumname.MouseLeave, cover.MouseLeave, buttonbackground.MouseLeave
        buttonbackground.Image = My.Resources.fondo_boton_claro
        lbl_albumname.BackColor = Color.FromArgb(216, 227, 225)
        lbl_artistname.BackColor = Color.FromArgb(216, 227, 225)
    End Sub
End Class
