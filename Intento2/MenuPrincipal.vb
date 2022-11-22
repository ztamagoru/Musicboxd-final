Imports System.IO
Imports System.Drawing.Imaging

Public Class MenuPrincipal
    Dim validador As New validador
    Dim datos As New datos
    Dim extras As New extras
    Dim song As New song
    Dim search As New search

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

        Select Case (datos.rol)
            Case 2
                parameterBttn.Visible = True
            Case 3
                parameterBttn.Visible = True
                userBttn.Visible = True
        End Select

        'pfp.Image = extras.roundpfp(pfp.Image)

        song.obtainrecommendations()
    End Sub

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

#End Region

#Region "    no sé cómo describir esto :p"
    Private Sub artistName1_Click(sender As Object, e As EventArgs) Handles songName1.Click, PictureBox3.Click, cover1.Click, artistName1.Click
        Dim artistname As String = artistName1.Text
        Dim songname As String = songName1.Text

        song.specificsong(songname, artistname)
        Me.Hide()
        SongInfo.Show()
    End Sub

    Private Sub artistName2_Click(sender As Object, e As EventArgs) Handles songName2.Click, PictureBox5.Click, cover2.Click, artistName2.Click
        Dim artistname As String = artistName2.Text
        Dim songname As String = songName2.Text

        song.specificsong(songname, artistname)
        Me.Hide()
        SongInfo.Show()
    End Sub

    Private Sub artistName3_Click(sender As Object, e As EventArgs) Handles songName3.Click, PictureBox4.Click, cover3.Click, artistName3.Click
        Dim artistname As String = artistName3.Text
        Dim songname As String = songName3.Text

        song.specificsong(songname, artistname)
        Me.Hide()
        SongInfo.Show()
    End Sub

    Private Sub artistName4_Click(sender As Object, e As EventArgs) Handles songName4.Click, PictureBox6.Click, cover4.Click, artistName4.Click
        Dim artistname As String = artistName4.Text
        Dim songname As String = songName4.Text

        song.specificsong(songname, artistname)
        Me.Hide()
        SongInfo.Show()
    End Sub

#End Region

#Region "    searchbar hovers"

    Private Sub searchbar_Enter(sender As Object, e As EventArgs) Handles searchbar.Enter
        If searchbar.Text.Trim = "Search song, album or artist" Then
            With searchbar
                .Text = String.Empty
                .ForeColor = Color.FromArgb(60, 60, 65)
            End With
        End If
    End Sub

    Private Sub searchbar_Leave(sender As Object, e As EventArgs) Handles searchbar.Leave
        If searchbar.Text.Trim = String.Empty Then
            With searchbar
                .Text = "Search song, album or artist"
                .ForeColor = Color.FromArgb(160, 160, 160)
            End With
        End If
    End Sub

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If searchbar.Text.Trim = "Search song, album or artist" Or
            searchbar.Text.Trim = String.Empty Then

            MessageBox.Show($"Search bar empty.{vbNewLine}Complete the blank space and try again",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            SearchMenu.lbl.Text = $"Search results for: {searchbar.Text.Trim}"

            search.makesearch(searchbar.Text.Trim)

            With SearchMenu.searchbar
                .Text = "Search song, album or artist"
                .ForeColor = Color.FromArgb(160, 160, 160)
            End With

            SearchMenu.Show()
            Me.Hide()
        End If
    End Sub
End Class