Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class validador
    Dim conexion As New conexion
    Dim datos As New datos

    Private _code As String
    Private smtp_server As New SmtpClient
    Private e_mail As MailMessage
    Private _text As String

    Private MBmail As String = "noreply.musicboxd@gmail.com"
    Private MBpass As String = "ftknsjdorgznqaiv"

    Public Property code As String
        Get
            Return _code
        End Get
        Set(value As String)
            _code = value
        End Set
    End Property

    Private Property text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

    Public Function validarDatos(user As String, pass As String, mail As String) As Boolean
        Dim validU As Boolean = user.Length > 7
        Dim validP As Boolean = Regex.IsMatch(pass,
                                              "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,20}$")
        Dim validM As Boolean = Regex.IsMatch(mail,
                                              "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")

        If Not validU Then
            MessageBox.Show("Invalid username length.",
                            "Error",
                            MessageBoxButtons.OK)

        ElseIf Not validP Then
            MessageBox.Show("Invalid password format.",
                            "Error",
                            MessageBoxButtons.OK)

        ElseIf Not validP Then
            MessageBox.Show("Invalid mail format.",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            enviarCodigo(mail)
            Return True
        End If

        Return False
    End Function

    Private Sub enviarCodigo(mail As String)
        generarCodigo()

        text = $"Dear {Registro._name.Text.Trim},{vbCrLf}
                Please verify your email adress to complete your Musicboxd account.{vbCrLf}
                Code: {code}{vbCrLf}{vbCrLf}
                Thank you,{vbCrLf}The Musicboxd Team"

        With smtp_server
            .Credentials = New Net.NetworkCredential(MBmail, MBpass)
            .UseDefaultCredentials = False
            .Host = "smtp.gmail.com"
            .EnableSsl = True
            .Port = 587
        End With

        With e_mail
            .From = New MailAddress(MBmail)
            .To.Add(mail)
            .Subject = "Musicboxd - verify your account"
            .IsBodyHtml = False
            .Body = text
        End With

        smtp_server.SendMailAsync(e_mail)


    End Sub

    Private Sub generarCodigo()
        Dim num As New Random()
        Dim generatedCode As String = ""

        For i = 1 To 7
            If i = 4 Then
                generatedCode += "-"
            Else
                generatedCode += $"{num.Next(1, 9)}"
            End If
        Next

        code = generatedCode
    End Sub
End Class
