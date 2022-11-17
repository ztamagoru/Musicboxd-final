Public Class MenuPrincipal
    Dim validador As New validador
    Dim datos As New datos
    Dim extras As New extras
    Private Sub MenuPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Select Case (datos.rol)
            Case 1

            Case 2

            Case 3

        End Select
    End Sub

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result = extras.show(
                    {"Close", "Sign out"},
                    "",
                    "Musicboxd")

        Select Case result
            Case "Close"
                Process.GetCurrentProcess().Kill()
                e.Cancel = True
            Case "Sign out"
                Me.Dispose()
                Inicio.Show()
            Case Else
                e.Cancel = True
        End Select
    End Sub


End Class