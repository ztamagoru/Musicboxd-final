Imports System.IO
Imports System.Drawing.Imaging

Public Class MenuPrincipal
    Dim validador As New validador
    Dim datos As New datos
    Dim extras As New extras
    Dim song As New cancion
    Dim search As New buscador

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result = extras.show(
                    {"Close", "Sign out", "Cancel"},
                    "",
                    "Musicboxd")

        Select Case result
            Case "Close"
                Process.GetCurrentProcess().Kill()

            Case "Sign out"
                Me.Dispose()
                Inicio.Show()

            Case Else
                e.Cancel = True
        End Select
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With extras
            .buttons(Button1)
            .buttons(parameterBttn)
            .buttons(userBttn)
        End With

        Dim x As Integer = datos.rol

        Debug.WriteLine(x.ToString)

        Select Case (x)
            Case 2
                parameterBttn.Visible = True
            Case 3
                parameterBttn.Visible = True
                userBttn.Visible = True
        End Select

        pfp.Image = extras.roundpfp(pfp.Image)

        pfp.BackColor = Color.FromArgb(195, 206, 204)
        _username.BackColor = Color.FromArgb(195, 206, 204)
        logo.BackColor = Color.FromArgb(195, 206, 204)

        song.obtenerRecomendaciones()
    End Sub

    'sujeto a cambios:
    Public Sub addCover(cover As Byte(), i As Integer)
        Select Case (i)
            Case 1
                cover1.Image = Image.FromStream(New MemoryStream(cover))
            Case 2
                cover2.Image = Image.FromStream(New MemoryStream(cover))
            Case 3
                cover3.Image = Image.FromStream(New MemoryStream(cover))
            Case 4
                cover4.Image = Image.FromStream(New MemoryStream(cover))
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If searchbar.Text.Trim = "Search song, album or artist" Then

        End If
    End Sub

    Private Sub userBttn_Click(sender As Object, e As EventArgs) Handles userBttn.Click
        Me.Hide()
        With UserCenter
            .Show()
            ._username.Text = _username.Text
        End With

    End Sub

#Region "    hovers"

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter, cover4.MouseEnter, songName4.MouseEnter, artistName4.MouseEnter
        PictureBox6.Image = My.Resources.banner_inicio

        songName4.BackColor = Color.FromArgb(195, 206, 204)
        cover4.BackColor = Color.FromArgb(195, 206, 204)
        artistName4.BackColor = Color.FromArgb(195, 206, 204)
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave, cover4.MouseLeave, songName4.MouseLeave, artistName4.MouseLeave
        PictureBox6.Image = Nothing

        songName4.BackColor = Color.FromArgb(231, 233, 228)
        cover4.BackColor = Color.FromArgb(231, 233, 228)
        artistName4.BackColor = Color.FromArgb(231, 233, 228)
    End Sub

    Private Sub artistName3_MouseEnter(sender As Object, e As EventArgs) Handles songName3.MouseEnter, PictureBox4.MouseEnter, cover3.MouseEnter, artistName3.MouseEnter
        PictureBox4.Image = My.Resources.banner_inicio

        songName3.BackColor = Color.FromArgb(195, 206, 204)
        cover3.BackColor = Color.FromArgb(195, 206, 204)
        artistName3.BackColor = Color.FromArgb(195, 206, 204)
    End Sub

    Private Sub artistName3_MouseLeave(sender As Object, e As EventArgs) Handles songName3.MouseLeave, PictureBox4.MouseLeave, cover3.MouseLeave, artistName3.MouseLeave
        PictureBox4.Image = Nothing

        songName3.BackColor = Color.FromArgb(231, 233, 228)
        cover3.BackColor = Color.FromArgb(231, 233, 228)
        artistName3.BackColor = Color.FromArgb(231, 233, 228)
    End Sub

    Private Sub artistName1_MouseEnter(sender As Object, e As EventArgs) Handles songName1.MouseEnter, PictureBox3.MouseEnter, cover1.MouseEnter, artistName1.MouseEnter
        PictureBox3.Image = My.Resources.banner_inicio

        songName1.BackColor = Color.FromArgb(195, 206, 204)
        cover1.BackColor = Color.FromArgb(195, 206, 204)
        artistName1.BackColor = Color.FromArgb(195, 206, 204)
    End Sub

    Private Sub artistName1_MouseLeave(sender As Object, e As EventArgs) Handles songName1.MouseLeave, PictureBox3.MouseLeave, cover1.MouseLeave, artistName1.MouseLeave
        PictureBox3.Image = Nothing

        songName1.BackColor = Color.FromArgb(231, 233, 228)
        cover1.BackColor = Color.FromArgb(231, 233, 228)
        artistName1.BackColor = Color.FromArgb(231, 233, 228)
    End Sub

    Private Sub artistName2_MouseEnter(sender As Object, e As EventArgs) Handles songName2.MouseEnter, PictureBox5.MouseEnter, cover2.MouseEnter, artistName2.MouseEnter
        PictureBox5.Image = My.Resources.banner_inicio

        songName2.BackColor = Color.FromArgb(195, 206, 204)
        cover2.BackColor = Color.FromArgb(195, 206, 204)
        artistName2.BackColor = Color.FromArgb(195, 206, 204)
    End Sub

    Private Sub artistName2_MouseLeave(sender As Object, e As EventArgs) Handles songName2.MouseLeave, PictureBox5.MouseLeave, cover2.MouseLeave, artistName2.MouseLeave
        PictureBox5.Image = Nothing

        songName2.BackColor = Color.FromArgb(231, 233, 228)
        cover2.BackColor = Color.FromArgb(231, 233, 228)
        artistName2.BackColor = Color.FromArgb(231, 233, 228)
    End Sub

    Private Sub artistName1_Click(sender As Object, e As EventArgs) Handles songName1.Click, PictureBox3.Click, cover1.Click, artistName1.Click

    End Sub

#End Region
End Class