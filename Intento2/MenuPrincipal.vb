﻿Imports System.IO
Imports System.Drawing.Imaging

Public Class MenuPrincipal
    Dim validador As New validador
    Dim datos As New datos
    Dim extras As New extras
    Dim song As New cancion
    Dim search As New buscador

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result = extras.show(
                    {"Close", "Sign out"},
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

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With extras
            .buttons(Button1)
            .buttons(parameterBttn)
            .buttons(userBttn)
        End With

        Dim x As Integer = datos.rol

        Debug.WriteLine(x.ToString)

        Select Case (x)
            Case 2
                parameterBttn.Visible = True
            Case 3
                parameterBttn.Visible = True
                userBttn.Visible = True
        End Select

        pfp.Image = extras.roundpfp(pfp.Image)

        song.obtenerRecomendaciones()
    End Sub

    'sujeto a cambios:
    Public Sub addCover(cover As Byte(), i As Integer)
        'Dim ms As New MemoryStream
        'ms = New MemoryStream(cover)

        '

        'Using bitmap As New 

        'Dim pic As Image = Nothing

        'Using ms As New MemoryStream(cover)
        '    ms.Seek(0, SeekOrigin.Begin)
        '    pic = New System.Drawing.Bitmap(ms)
        'End Using
        ''pic = New Bitmap(ms)

        Select Case (i)
            Case 1
                'cover1.Image = pic
            Case 2
               ' cover2.Image.Save(ms, ImageFormat.Png)' = pic'Bitmap.FromStream(New MemoryStream(cover), True, True)
            Case 3
                'cover3.Image.Save(ms, ImageFormat.Png)' = pic'Bitmap.FromStream(New MemoryStream(cover), True, True)
            Case 4
                'cover4.Image.Save(ms, ImageFormat.Png) ' = pic 'Bitmap.FromStream(New MemoryStream(cover), True, True)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If searchbar.Text.Trim = "Search song, album or artist" Then

        End If
    End Sub

    Private Sub userBttn_Click(sender As Object, e As EventArgs) Handles userBttn.Click
        Me.Hide()
        With UserCenter
            .Show()
            ._username.Text = _username.Text
        End With

    End Sub

    Private Sub parameterBttn_Click(sender As Object, e As EventArgs) Handles parameterBttn.Click

    End Sub
End Class