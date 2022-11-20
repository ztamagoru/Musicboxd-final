Imports System.Text.RegularExpressions

Public Class IngresarCodigo
    Dim extras As New extras
    Dim validador As New validador
    Dim datos As New datos

    Private Sub IngresarCodigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extras.buttons(Button1)
    End Sub

    Private Sub IngresarCodigo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim ocult, pattern As String

        pattern = "(?<=[\w]{3})[\w-\._\+ %]*(?=[\w]{1}@)"

        ocult = Regex.Replace(validador.useremail, pattern, "***")

        insertmail.Text = ocult

        MaskedTextBox1.Clear()
    End Sub

    Private Sub IngresarCodigo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resp As MsgBoxResult

        resp = MessageBox.Show("Do you want to cancel this operation?",
                                "League of Champs",
                                MessageBoxButtons.YesNo)
        If resp = vbYes Then
            Registro.Enabled = True
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        If MaskedTextBox1.MaskCompleted Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub ingresarcodigo(sender As Object, e As EventArgs) Handles Button1.Click
        If validador.validarCodigo(MaskedTextBox1.Text) Then

            datos.registrarUsuario()

            MessageBox.Show($"Account created succesfully.{vbNewLine}Please sign in.",
                            "Musicboxd",
                            MessageBoxButtons.OK)

            Registro.Enabled() = True
            Registro.Hide()

            Inicio.Show()

            Me.Dispose()
        Else
            MessageBox.Show($"Incorrect code.{vbNewLine}Please try again.",
                            "Musicboxd",
                            MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub enviarcodigodevuelta(sender As Object, e As EventArgs) Handles Label2.Click
        validador.enviarCodigo()
        MessageBox.Show($"New code sent to {insertmail.Text}.",
                        "Musicboxd",
                        MessageBoxButtons.OK)
    End Sub
End Class