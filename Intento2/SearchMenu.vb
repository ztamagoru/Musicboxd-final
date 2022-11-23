Public Class SearchMenu
    Dim extras As New extras
    Dim search As New search

    Private Sub SearchMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With extras
            .buttons(userBttn)
            .buttons(filterBttn)
            .buttons(Button1)
        End With

        Select Case (datos.rol)
            Case 2
                filterBttn.Visible = True
            Case 3
                filterBttn.Visible = True
                userBttn.Visible = True
        End Select

        _username.Text = MenuPrincipal._username.Text
    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        Me.Dispose()
        MenuPrincipal.Show()
    End Sub

    Private Sub SearchMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result = extras.show(
                    {"Close", "Sign out", "Cancel"},
                    "",
                    "Musicboxd")

        Select Case result
            Case "Close"
                Process.GetCurrentProcess().Kill()

            Case "Sign out"
                Me.Dispose()
                MenuPrincipal.Dispose()
                Inicio.Show()

            Case Else
                e.Cancel = True
        End Select
    End Sub

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

    Private Sub makesearch(sender As Object, e As EventArgs) Handles Button1.Click
        If searchbar.Text.Trim = "Search song, album or artist" Or
            searchbar.Text.Trim = String.Empty Then

            MessageBox.Show($"Search bar empty.{vbNewLine}Complete the blank space and try again",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            songspanel.Controls.Clear()
            albumpanel.Controls.Clear()
            artistpanel.Controls.Clear()

            songspanel.Visible = True
            albumpanel.Visible = True
            artistpanel.Visible = True

            lbl.Text = $"Search results for: {searchbar.Text.Trim}"

            search.makesearch(searchbar.Text.Trim)

            With searchbar
                .Text = "Search song, album or artist"
                .ForeColor = Color.FromArgb(160, 160, 160)
            End With
        End If
    End Sub

    Private Sub filterBttn_Click(sender As Object, e As EventArgs) Handles filterBttn.Click
        Me.Dispose()
        FilterCenter.Show()
    End Sub

    Private Sub userBttn_Click(sender As Object, e As EventArgs) Handles userBttn.Click
        Me.Dispose()
        FilterCenter.Show()
    End Sub
End Class