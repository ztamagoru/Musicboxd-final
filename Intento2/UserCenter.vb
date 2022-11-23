Public Class UserCenter
    Dim extras As New extras
    Dim datos As New datos

    Private Sub UserCenter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

    Private Sub UserCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pfp.Image = extras.roundpfp(pfp.Image)

        With extras
            .buttons(Button1)
            .buttons(filterBttn)
            .buttons(userBttn)
            .buttons(change)
        End With

        _username.Text = MenuPrincipal._username.Text

        Select Case (datos.rol)
            Case 2
                filterBttn.Visible = True
            Case 3
                filterBttn.Visible = True
                userBttn.Visible = True
        End Select

        datos.getallusers(_username.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MenuPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub dgUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsers.CellClick
        With dgUsers.CurrentRow
            txtusername.Text = .Cells(0).Value
            txtname.Text = .Cells(1).Value
            txtsurname.Text = .Cells(2).Value
            txtemail.Text = .Cells(3).Value

            role.SelectedIndex = role.FindStringExact(.Cells(4).Value)
        End With
    End Sub

    Private Sub role_SelectedIndexChanged(sender As Object, e As EventArgs) Handles role.SelectedIndexChanged
        If role.Text <> dgUsers.CurrentRow.Cells(4).Value Then
            change.Enabled = True
        Else
            change.Enabled = False
        End If
    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click
        datos.changerole(txtusername.Text, role.Text)

        datos.getallusers(_username.Text)
    End Sub
End Class