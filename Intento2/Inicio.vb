Public Class Inicio
    Dim datos As New datos
    Dim extra As New extras
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extra.buttons(Button1)
    End Sub

#Region "    hovers"
    Private Sub _username_Enter(sender As Object, e As EventArgs) Handles _username.GotFocus
        If _username.Text = "Username" Then

            _username.Text = String.Empty
            _username.ForeColor = Color.FromArgb(60, 60, 65)
        End If
    End Sub

    Private Sub _username_Leave(sender As Object, e As EventArgs) Handles _username.LostFocus
        If _username.Text = String.Empty Then

            _username.Text = "Username"
            _username.ForeColor = createAcc.ForeColor

        End If
    End Sub

    Private Sub _password_Enter(sender As Object, e As EventArgs) Handles _password.GotFocus
        If _password.Text = "Password" Then

            _password.Text = String.Empty
            _password.ForeColor = Color.FromArgb(60, 60, 65)
            _password.PasswordChar = "•"
        End If
    End Sub

    Private Sub _password_Leave(sender As Object, e As EventArgs) Handles _password.LostFocus
        If _password.Text = String.Empty Then

            _password.Text = "Password"
            _password.ForeColor = createAcc.ForeColor
            _password.PasswordChar = ""

        End If
    End Sub
#End Region

    Private Sub login(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user, pass As String

        user = _username.Text.Trim
        pass = _password.Text.Trim

        datos.login(user, pass)

        If datos.rol = 0 Then
            MessageBox.Show("Incorrect username or password.",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            MenuPrincipal._username.Text = user
            Me.Hide()
            ResetBoxes()
            MenuPrincipal.Show()
        End If
    End Sub

    Private Sub createAcc_Click(sender As Object, e As EventArgs) Handles createAcc.Click
        Me.Hide()
        ResetBoxes()
        Registro.ResetBoxes()
        Registro.Show()
    End Sub

#Region "    reset"
    Public Sub ResetBoxes()
        With _username
            .Text = "Username"
            .ForeColor = createAcc.ForeColor
        End With

        With _password
            .Text = "Password"
            .PasswordChar = ""
            .ForeColor = createAcc.ForeColor
        End With
    End Sub

#End Region

    Private Sub showPassword(sender As Object, e As MouseEventArgs) Handles eye.MouseDown
        _password.PasswordChar = ""

        eye.Image = My.Resources.view
    End Sub

    Private Sub hidePassword(sender As Object, e As MouseEventArgs) Handles eye.MouseUp
        If Not _password.Text.Trim = "Password" Then
            _password.PasswordChar = "•"
        End If

        eye.Image = My.Resources.view__1_
    End Sub
End Class
