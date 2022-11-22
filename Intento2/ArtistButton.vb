Imports System.IO

Public Class ArtistButton
    Dim artist As New artist

    Public Sub seteartexto(name As String, photo As Byte())
        lbl_artistname.Text = name
        artistphoto.Image = Image.FromStream(New MemoryStream(photo))
    End Sub

    Private Sub buttonbackground_Click(sender As Object, e As EventArgs) Handles buttonbackground.Click, artistphoto.Click, lbl_artistname.Click
        artist.specificartist(Name)
        'SearchMenu.Dispose()

    End Sub

    Private Sub hoverEnter(sender As Object, e As EventArgs) Handles lbl_artistname.MouseEnter, artistphoto.MouseEnter, buttonbackground.MouseEnter
        buttonbackground.Image = My.Resources.fondo_boton_oscuro
        lbl_artistname.BackColor = Color.FromArgb(195, 206, 204)
    End Sub

    Private Sub hoverLeave(sender As Object, e As EventArgs) Handles lbl_artistname.MouseLeave, artistphoto.MouseLeave, buttonbackground.MouseLeave
        buttonbackground.Image = My.Resources.fondo_boton_claro
        lbl_artistname.BackColor = Color.FromArgb(216, 227, 225)
    End Sub
End Class
