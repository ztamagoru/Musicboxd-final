﻿Public Class SongInfo
    Dim extras As New extras
    Dim songs As New cancion
    Dim rating As New rating
    Dim validador As New validador

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
        star2.Image = My.Resources.star
        star3.Image = My.Resources.star
        star4.Image = My.Resources.star
        star5.Image = My.Resources.star
        star6.Image = My.Resources.star
        star7.Image = My.Resources.star
        star8.Image = My.Resources.star
        star9.Image = My.Resources.star
        star10.Image = My.Resources.star
    End Sub

    Private Sub star1_MouseLeave(sender As Object, e As EventArgs) Handles star1.MouseLeave, star2.MouseLeave, star3.MouseLeave, star4.MouseLeave, star5.MouseLeave, star6.MouseLeave, star7.MouseLeave, star8.MouseLeave, star9.MouseLeave, star10.MouseLeave
        setstars(rating.rating)
    End Sub

    Private Sub star2_MouseEnter(sender As Object, e As EventArgs) Handles star2.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star
        star4.Image = My.Resources.star
        star5.Image = My.Resources.star
        star6.Image = My.Resources.star
        star7.Image = My.Resources.star
        star8.Image = My.Resources.star
        star9.Image = My.Resources.star
        star10.Image = My.Resources.star
    End Sub

    Private Sub star3_MouseEnter(sender As Object, e As EventArgs) Handles star3.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star__1_
        star4.Image = My.Resources.star
        star5.Image = My.Resources.star
        star6.Image = My.Resources.star
        star7.Image = My.Resources.star
        star8.Image = My.Resources.star
        star9.Image = My.Resources.star
        star10.Image = My.Resources.star
    End Sub

    Private Sub star4_MouseEnter(sender As Object, e As EventArgs) Handles star4.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star__1_
        star4.Image = My.Resources.star__1_
        star5.Image = My.Resources.star
        star6.Image = My.Resources.star
        star7.Image = My.Resources.star
        star8.Image = My.Resources.star
        star9.Image = My.Resources.star
        star10.Image = My.Resources.star
    End Sub

    Private Sub star5_MouseEnter(sender As Object, e As EventArgs) Handles star5.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star__1_
        star4.Image = My.Resources.star__1_
        star5.Image = My.Resources.star__1_
        star6.Image = My.Resources.star
        star7.Image = My.Resources.star
        star8.Image = My.Resources.star
        star9.Image = My.Resources.star
        star10.Image = My.Resources.star
    End Sub

    Private Sub star6_MouseEnter(sender As Object, e As EventArgs) Handles star6.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star__1_
        star4.Image = My.Resources.star__1_
        star5.Image = My.Resources.star__1_
        star6.Image = My.Resources.star__1_
        star7.Image = My.Resources.star
        star8.Image = My.Resources.star
        star9.Image = My.Resources.star
        star10.Image = My.Resources.star
    End Sub

    Private Sub star7_MouseEnter(sender As Object, e As EventArgs) Handles star7.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star__1_
        star4.Image = My.Resources.star__1_
        star5.Image = My.Resources.star__1_
        star6.Image = My.Resources.star__1_
        star7.Image = My.Resources.star__1_
        star8.Image = My.Resources.star
        star9.Image = My.Resources.star
        star10.Image = My.Resources.star

        star6_MouseEnter(sender, e)
    End Sub

    Private Sub star8_MouseEnter(sender As Object, e As EventArgs) Handles star8.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star__1_
        star4.Image = My.Resources.star__1_
        star5.Image = My.Resources.star__1_
        star6.Image = My.Resources.star__1_
        star7.Image = My.Resources.star__1_
        star8.Image = My.Resources.star__1_
        star9.Image = My.Resources.star
        star10.Image = My.Resources.star
    End Sub

    Private Sub star9_MouseEnter(sender As Object, e As EventArgs) Handles star9.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star__1_
        star4.Image = My.Resources.star__1_
        star5.Image = My.Resources.star__1_
        star6.Image = My.Resources.star__1_
        star7.Image = My.Resources.star__1_
        star8.Image = My.Resources.star__1_
        star9.Image = My.Resources.star__1_
        star10.Image = My.Resources.star
    End Sub

    Private Sub star10_MouseEnter(sender As Object, e As EventArgs) Handles star10.MouseEnter
        star1.Image = My.Resources.star__1_
        star2.Image = My.Resources.star__1_
        star3.Image = My.Resources.star__1_
        star4.Image = My.Resources.star__1_
        star5.Image = My.Resources.star__1_
        star6.Image = My.Resources.star__1_
        star7.Image = My.Resources.star__1_
        star8.Image = My.Resources.star__1_
        star9.Image = My.Resources.star__1_
        star10.Image = My.Resources.star__1_
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

    Public Sub setstars(rating As Integer)
        Select Case (rating)
            Case 1
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star
                star3.Image = My.Resources.star
                star4.Image = My.Resources.star
                star5.Image = My.Resources.star
                star6.Image = My.Resources.star
                star7.Image = My.Resources.star
                star8.Image = My.Resources.star
                star9.Image = My.Resources.star
                star10.Image = My.Resources.star
            Case 2
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star
                star4.Image = My.Resources.star
                star5.Image = My.Resources.star
                star6.Image = My.Resources.star
                star7.Image = My.Resources.star
                star8.Image = My.Resources.star
                star9.Image = My.Resources.star
                star10.Image = My.Resources.star
            Case 3
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star__1_
                star4.Image = My.Resources.star
                star5.Image = My.Resources.star
                star6.Image = My.Resources.star
                star7.Image = My.Resources.star
                star8.Image = My.Resources.star
                star9.Image = My.Resources.star
                star10.Image = My.Resources.star
            Case 4
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star__1_
                star4.Image = My.Resources.star__1_
                star5.Image = My.Resources.star
                star6.Image = My.Resources.star
                star7.Image = My.Resources.star
                star8.Image = My.Resources.star
                star9.Image = My.Resources.star
                star10.Image = My.Resources.star
            Case 5
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star__1_
                star4.Image = My.Resources.star__1_
                star5.Image = My.Resources.star__1_
                star6.Image = My.Resources.star
                star7.Image = My.Resources.star
                star8.Image = My.Resources.star
                star9.Image = My.Resources.star
                star10.Image = My.Resources.star
            Case 6
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star__1_
                star4.Image = My.Resources.star__1_
                star5.Image = My.Resources.star__1_
                star6.Image = My.Resources.star__1_
                star7.Image = My.Resources.star
                star8.Image = My.Resources.star
                star9.Image = My.Resources.star
                star10.Image = My.Resources.star
            Case 7
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star__1_
                star4.Image = My.Resources.star__1_
                star5.Image = My.Resources.star__1_
                star6.Image = My.Resources.star__1_
                star7.Image = My.Resources.star__1_
                star8.Image = My.Resources.star
                star9.Image = My.Resources.star
                star10.Image = My.Resources.star
            Case 8
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star__1_
                star4.Image = My.Resources.star__1_
                star5.Image = My.Resources.star__1_
                star6.Image = My.Resources.star__1_
                star7.Image = My.Resources.star__1_
                star8.Image = My.Resources.star__1_
                star9.Image = My.Resources.star
                star10.Image = My.Resources.star
            Case 9
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star__1_
                star4.Image = My.Resources.star__1_
                star5.Image = My.Resources.star__1_
                star6.Image = My.Resources.star__1_
                star7.Image = My.Resources.star__1_
                star8.Image = My.Resources.star__1_
                star9.Image = My.Resources.star__1_
                star10.Image = My.Resources.star
            Case 10
                star1.Image = My.Resources.star__1_
                star2.Image = My.Resources.star__1_
                star3.Image = My.Resources.star__1_
                star4.Image = My.Resources.star__1_
                star5.Image = My.Resources.star__1_
                star6.Image = My.Resources.star__1_
                star7.Image = My.Resources.star__1_
                star8.Image = My.Resources.star__1_
                star9.Image = My.Resources.star__1_
                star10.Image = My.Resources.star__1_
        End Select
    End Sub

#Region "    rating value changed"

    Private Sub star1_Click(sender As Object, e As EventArgs) Handles star1.Click
        rating.changerating(1)
    End Sub

    Private Sub star2_Click(sender As Object, e As EventArgs) Handles star2.Click
        rating.changerating(2)
    End Sub

    Private Sub star3_Click(sender As Object, e As EventArgs) Handles star3.Click
        rating.changerating(3)
    End Sub

    Private Sub star4_Click(sender As Object, e As EventArgs) Handles star4.Click
        rating.changerating(4)
    End Sub

    Private Sub star5_Click(sender As Object, e As EventArgs) Handles star5.Click
        rating.changerating(5)
    End Sub

    Private Sub star6_Click(sender As Object, e As EventArgs) Handles star6.Click
        rating.changerating(6)
    End Sub

    Private Sub star7_Click(sender As Object, e As EventArgs) Handles star7.Click
        rating.changerating(7)
    End Sub

    Private Sub star8_Click(sender As Object, e As EventArgs) Handles star8.Click
        rating.changerating(8)
    End Sub

    Private Sub star9_Click(sender As Object, e As EventArgs) Handles star9.Click
        rating.changerating(9)
    End Sub

    Private Sub star10_Click(sender As Object, e As EventArgs) Handles star10.Click
        rating.changerating(10)
    End Sub

#End Region

#Region "    review textbox hovers"
    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text.Trim = "Write your review about the song here!" Then

        End If
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave

    End Sub

#End Region

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        validador.censorreview(TextBox1.Text.Trim())
    End Sub
End Class