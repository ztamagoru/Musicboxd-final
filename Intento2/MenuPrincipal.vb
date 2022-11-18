﻿Imports System.IO

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
                e.Cancel = True
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

    Public Sub addCover(cover As Byte(), i As Integer)
        Select Case (i)
            Case 1
                cover1.Image = Image.FromStream(New MemoryStream(cover))
            Case 2
                cover2.Image = Image.FromStream(New MemoryStream(cover))
            Case 3
                cover3.Image = Image.FromStream(New MemoryStream(cover))
            Case 4
                cover4.Image = Image.FromStream(New MemoryStream(cover))
        End Select
    End Sub
End Class