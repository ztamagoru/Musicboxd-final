Public Class Registro
    Dim extras As New extras
    Dim validator As New validador
    Dim datos As New datos

    Private Sub Registro_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        With _username
            .Text = "Username"
            .ForeColor = signin.ForeColor
        End With

        With _password
            .Text = "Password"
            .PasswordChar = ""
            .ForeColor = signin.ForeColor
        End With

        With _email
            .Text = "Email"
            .ForeColor = signin.ForeColor
        End With

        With _name
            .Text = "Name"
            .ForeColor = signin.ForeColor
        End With

        With _surname
            .Text = "Surname"
            .ForeColor = signin.ForeColor
        End With
    End Sub

    Private Sub _username_Enter(sender As Object, e As EventArgs) Handles _username.Enter
        If _username.Text.Trim = "Username" Then

            _username.Text = String.Empty
            _username.ForeColor = label1.ForeColor
        End If
    End Sub

    Private Sub _username_Leave(sender As Object, e As EventArgs) Handles _username.Leave
        If _username.Text.Trim = String.Empty Then

            _username.Text = "Username"
            _username.ForeColor = signin.ForeColor
        End If
    End Sub

    Private Sub _password_Enter(sender As Object, e As EventArgs) Handles _password.Enter
        If _password.Text.Trim = "Password" Then

            _password.Text = String.Empty
            _password.ForeColor = label1.ForeColor
            _password.PasswordChar = "•"

        End If
    End Sub

    Private Sub _password_Leave(sender As Object, e As EventArgs) Handles _password.Leave
        If _password.Text = String.Empty Then

            _password.Text = "Password"
            _password.ForeColor = signin.ForeColor
            _password.PasswordChar = ""

        End If
    End Sub

    Private Sub _email_Enter(sender As Object, e As EventArgs) Handles _email.Enter
        If _email.Text.Trim = "Email" Then

            _email.Text = String.Empty
            _email.ForeColor = label1.ForeColor
        End If
    End Sub

    Private Sub _email_Leave(sender As Object, e As EventArgs) Handles _email.Leave
        If _email.Text.Trim = String.Empty Then

            _email.Text = "Email"
            _email.ForeColor = signin.ForeColor
        End If
    End Sub

    Private Sub _name_Enter(sender As Object, e As EventArgs) Handles _name.Enter
        If _name.Text.Trim = "Name" Then

            _name.Text = String.Empty
            _name.ForeColor = label1.ForeColor
        End If
    End Sub

    Private Sub _name_Leave(sender As Object, e As EventArgs) Handles _name.Leave
        If _name.Text.Trim = String.Empty Then

            _name.Text = "Name"
            _name.ForeColor = signin.ForeColor

        ElseIf _name.Text.Trim = "Name" Then
            _name.ForeColor = signin.ForeColor
        End If
    End Sub

    Private Sub _surname_Enter(sender As Object, e As EventArgs) Handles _surname.Enter
        If _surname.Text.Trim = "Surname" Then

            _surname.Text = String.Empty
            _surname.ForeColor = label1.ForeColor
        End If
    End Sub

    Private Sub _surname_Leave(sender As Object, e As EventArgs) Handles _surname.Leave
        If _surname.Text.Trim = String.Empty Then

            _surname.Text = "Surname"
            _surname.ForeColor = signin.ForeColor
        End If
    End Sub

    Private Sub signin_Click(sender As Object, e As EventArgs) Handles signin.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub Registro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extras.buttons(Button1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If _name.Text.Trim = "Name" Or
                _surname.Text.Trim = "Surname" Or
                _email.Text.Trim = "Email" Or
                _username.Text.Trim = "Username" Or
                _password.Text.Trim = "Password" Then

            MessageBox.Show($"Incomplete spaces.{vbCrLf}Please fill them and try again",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            Dim validation As Boolean

            validation = validator.validarDatos(_username.Text.Trim, _password.Text.Trim, _email.Text.Trim)

            If validation Then
                datos.compararDatos(_username.Text.Trim, _email.Text.Trim)
            End If
        End If
    End Sub
End Class