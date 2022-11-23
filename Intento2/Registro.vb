Public Class Registro
    Dim extras As New extras
    Dim validator As New validador
    Dim datos As New datos

#Region "    hovers"
    Private Sub Registro_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ResetBoxes()
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

#End Region

    Private Sub signin_Click(sender As Object, e As EventArgs) Handles signin.Click
        Inicio.Show()
        Me.Dispose()
    End Sub

    Private Sub Registro_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        extras.buttons(Button1)

        usernameTip.SetToolTip(_username,
                               $"The username needs to have between{vbNewLine}8 and 50 characters.")
        passwordTip.SetToolTip(_password,
                               $"The password needs to contain at least:{vbNewLine}• Between 8 and 20 characters{vbNewLine}• One upcase character{vbNewLine}• One number")
    End Sub

    Private Sub register(sender As Object, e As EventArgs) Handles Button1.Click
        If _name.Text.Trim = "Name" Or
                _surname.Text.Trim = "Surname" Or
                _email.Text.Trim = "Email" Or
                _username.Text.Trim = "Username" Or
                _password.Text.Trim = "Password" Then

            MessageBox.Show($"Incomplete spaces.{vbCrLf}Please fill them and try again",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            Dim user, pass, mail, name, surname As String

            user = _username.Text.Trim
            pass = _password.Text.Trim
            mail = _email.Text.Trim
            name = _name.Text.Trim
            surname = _surname.Text.Trim

            If validator.validateuser(user, pass, mail, name, surname) Then
                Select Case (datos.comparedata())
                    Case 0
                        Me.Enabled() = False
                        IngresarCodigo.Show()

                        validator.sendcode()
                    Case 1
                        MessageBox.Show("An account with that username already exists.",
                                        "Error",
                                        MessageBoxButtons.OK)
                    Case 2
                        MessageBox.Show("An account with that email already exists.",
                                        "Error",
                                        MessageBoxButtons.OK)
                End Select
            End If
        End If
    End Sub

#Region "    resets"
    Public Sub ResetBoxes()
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