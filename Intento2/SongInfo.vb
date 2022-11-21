Public Class SongInfo
    Dim extras As New extras
    Dim songs As New cancion

#Region "    links click"
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles deezerLink.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles itunesLink.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles spotifyLink.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub
#End Region

#Region "    stars hovers"

    Private Sub star1_MouseEnter(sender As Object, e As EventArgs) Handles star1.MouseEnter
        star1.Image = My.Resources.star__1_
    End Sub

    Private Sub star1_MouseLeave(sender As Object, e As EventArgs) Handles star1.MouseLeave
        If songs.rating < 1 Then
            star1.Image = My.Resources.star
        End If
    End Sub

    Private Sub star2_MouseEnter(sender As Object, e As EventArgs) Handles star2.MouseEnter
        star2.Image = My.Resources.star__1_

        star1_MouseEnter(sender, e)
    End Sub

    Private Sub star2_MouseLeave(sender As Object, e As EventArgs) Handles star2.MouseLeave
        If songs.rating < 2 Then
            star2.Image = My.Resources.star
        End If

        star1_MouseLeave(sender, e)
    End Sub

    Private Sub star3_MouseEnter(sender As Object, e As EventArgs) Handles star3.MouseEnter
        star3.Image = My.Resources.star__1_

        star2_MouseEnter(sender, e)
    End Sub

    Private Sub star3_MouseLeave(sender As Object, e As EventArgs) Handles star3.MouseLeave
        If songs.rating < 3 Then
            star3.Image = My.Resources.star
        End If
        star2_MouseLeave(sender, e)
    End Sub

    Private Sub star4_MouseEnter(sender As Object, e As EventArgs) Handles star4.MouseEnter
        star4.Image = My.Resources.star__1_

        star3_MouseEnter(sender, e)
    End Sub

    Private Sub star4_MouseLeave(sender As Object, e As EventArgs) Handles star4.MouseLeave
        If songs.rating < 4 Then
            star4.Image = My.Resources.star
        End If
        star3_MouseLeave(sender, e)
    End Sub

    Private Sub star5_MouseEnter(sender As Object, e As EventArgs) Handles star5.MouseEnter
        star5.Image = My.Resources.star__1_

        star4_MouseEnter(sender, e)
    End Sub

    Private Sub star5_MouseLeave(sender As Object, e As EventArgs) Handles star5.MouseLeave
        If songs.rating < 5 Then
            star5.Image = My.Resources.star
        End If
        star4_MouseLeave(sender, e)
    End Sub

    Private Sub star6_MouseEnter(sender As Object, e As EventArgs) Handles star6.MouseEnter
        star6.Image = My.Resources.star__1_

        star5_MouseEnter(sender, e)
    End Sub

    Private Sub star6_MouseLeave(sender As Object, e As EventArgs) Handles star6.MouseLeave
        If songs.rating < 6 Then
            star6.Image = My.Resources.star
        End If
        star5_MouseLeave(sender, e)
    End Sub

    Private Sub star7_MouseEnter(sender As Object, e As EventArgs) Handles star7.MouseEnter
        star7.Image = My.Resources.star__1_

        star6_MouseEnter(sender, e)
    End Sub

    Private Sub star7_MouseLeave(sender As Object, e As EventArgs) Handles star7.MouseLeave
        If songs.rating < 7 Then
            star7.Image = My.Resources.star
        End If
        star6_MouseLeave(sender, e)
    End Sub

    Private Sub star8_MouseEnter(sender As Object, e As EventArgs) Handles star8.MouseEnter
        star8.Image = My.Resources.star__1_

        star7_MouseEnter(sender, e)
    End Sub

    Private Sub star8_MouseLeave(sender As Object, e As EventArgs) Handles star8.MouseLeave
        If songs.rating < 8 Then
            star8.Image = My.Resources.star
        End If
        star7_MouseLeave(sender, e)
    End Sub

    Private Sub star9_MouseEnter(sender As Object, e As EventArgs) Handles star9.MouseEnter
        star9.Image = My.Resources.star__1_

        star8_MouseEnter(sender, e)
    End Sub

    Private Sub star9_MouseLeave(sender As Object, e As EventArgs) Handles star9.MouseLeave
        If songs.rating < 9 Then
            star9.Image = My.Resources.star
        End If
        star8_MouseLeave(sender, e)
    End Sub

    Private Sub star10_MouseEnter(sender As Object, e As EventArgs) Handles star10.MouseEnter
        star10.Image = My.Resources.star__1_

        star9_MouseEnter(sender, e)
    End Sub

    Private Sub star10_MouseLeave(sender As Object, e As EventArgs) Handles star10.MouseLeave
        If songs.rating < 10 Then
            star10.Image = My.Resources.star
        End If
        star9_MouseLeave(sender, e)
    End Sub

#End Region

    Private Sub SongInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case (datos.rol)
            Case 2
                parameterBttn.Visible = True
            Case 3
                parameterBttn.Visible = True
                userBttn.Visible = True
        End Select

        _username.Text = MenuPrincipal._username.Text
    End Sub

    Private Sub SongInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        Me.Dispose()
        MenuPrincipal.Show()
    End Sub
End Class