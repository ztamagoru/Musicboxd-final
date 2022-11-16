Public Class Inicio
    Dim datos As New datos
    Dim extra As New extras
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extra.buttons(Button1)
    End Sub

    Private Sub _username_Enter(sender As Object, e As EventArgs) Handles _username.Enter
        If _username.Text = "Username" And _username.ForeColor = createAcc.ForeColor Then

            _username.Text = String.Empty
            _username.ForeColor = Color.FromArgb(1, 91, 90, 86)

        End If
    End Sub

    Private Sub _username_Leave(sender As Object, e As EventArgs) Handles _username.Leave
        If _username.Text = String.Empty Then

            _username.Text = "Username"
            _username.ForeColor = createAcc.ForeColor

        End If
    End Sub

    Private Sub _password_Enter(sender As Object, e As EventArgs) Handles _password.Enter
        If _password.Text = "Password" And _password.ForeColor = createAcc.ForeColor Then

            _password.Text = String.Empty
            _password.ForeColor = Color.FromArgb(1, 60, 60, 65)
            _password.PasswordChar = "•"

        End If
    End Sub

    Private Sub _password_Leave(sender As Object, e As EventArgs) Handles _password.Leave
        If _password.Text = String.Empty Then

            _password.Text = "Password"
            _password.ForeColor = createAcc.ForeColor
            _password.PasswordChar = ""

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user, pass As String

        user = _username.Text.Trim
        pass = _password.Text.Trim

        datos.inicioSesion(user, pass)

        If datos.rol = 0 Then
            MessageBox.Show("Incorrect username or password.",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            MsgBox($"u did it! here is ur role id: {datos.rol}")
        End If
    End Sub

    Private Sub createAcc_Click(sender As Object, e As EventArgs) Handles createAcc.Click
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub Inicio_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        With _username
            .Text = "Username"
            .ForeColor = Color.FromArgb(1, 91, 90, 86)
        End With

        With _password
            .Text = "Password"
            .PasswordChar = ""
            .ForeColor = Color.FromArgb(1, 91, 90, 86)
        End With
    End Sub
End Class
