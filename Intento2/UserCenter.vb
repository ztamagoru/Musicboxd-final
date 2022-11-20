Public Class UserCenter
    Dim extras As New extras

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
        pfp.Image = extras.roundpfp(pfp.Image)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MenuPrincipal.Show()
        Me.Dispose()
    End Sub
End Class