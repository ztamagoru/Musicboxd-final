Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class validador
    Dim conexion As New conexion
    Dim datos As datos

    Private Shared _user, _pass, _mail, _name, _code, _surname As String
    Private _text As String

    Private Shared MBmail As String = "noreply.musicboxd@gmail.com"
    Private Shared MBpass As String = "adphsllcidaznukb"

    Public Shared Property username As String
        Get
            Return _user
        End Get
        Set(value As String)
            _user = value
        End Set
    End Property

    Public Shared Property password As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public Shared Property useremail As String
        Get
            Return _mail
        End Get
        Set(value As String)
            _mail = value
        End Set
    End Property

    Public Shared Property uname As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Shared Property usurname As String
        Get
            Return _surname
        End Get
        Set(value As String)
            _surname = value
        End Set
    End Property

    Public Shared Property code As String
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

    Public Function validarDatos(user As String, pass As String, mail As String, name As String, surname As String) As Boolean
        username = user
        password = pass
        useremail = mail
        uname = name
        usurname = surname


        Dim validU As Boolean = username.Length > 7

        Dim validP As Boolean = Regex.IsMatch(password,
                                              "^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,20}$")

        Dim validM As Boolean = Regex.IsMatch(useremail,
                                              "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?")

        If Not validU Then
            MessageBox.Show("Invalid username length.",
                            "Error",
                            MessageBoxButtons.OK)

        ElseIf Not validP Then
            MessageBox.Show("Invalid password format.",
                            "Error",
                            MessageBoxButtons.OK)

        ElseIf Not validM Then
            MessageBox.Show("Invalid mail format.",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            Return True
        End If

        Return False
    End Function

    Public Sub enviarCodigo()
        generarCodigo()

        text = $"Dear {username},{vbCrLf}
                Please verify your email adress to complete your Musicboxd account.{vbCrLf}
                Code: {code}{vbCrLf}{vbCrLf}
                Thank you,{vbCrLf}The Musicboxd Team"

        Dim smtp_server As New SmtpClient("smtp.gmail.com", 587)
        Dim e_mail As New MailMessage

        With smtp_server
            .UseDefaultCredentials = False
            .Credentials = New Net.NetworkCredential(MBmail, MBpass)
            .EnableSsl = True
            .Port = 587
            .Host = "smtp.gmail.com"
        End With

        e_mail = New MailMessage
        With e_mail
            .From = New MailAddress(MBmail)
            .To.Add(useremail)
            .Subject = "Musicboxd - verify your account"
            .IsBodyHtml = False
            .Body = text
        End With
        Try
            smtp_server.SendMailAsync(e_mail)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

    Public Function validarCodigo(ucode As String) As Boolean
        Debug.WriteLine($"{ucode}{vbCrLf}{code}")

        If ucode = code Then
            Return True
        End If

        Return False
    End Function
End Class
