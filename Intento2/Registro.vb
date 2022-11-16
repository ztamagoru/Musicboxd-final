Public Class Registro
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
End Class