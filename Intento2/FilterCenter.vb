Imports System.IO

Public Class FilterCenter
    Dim extras As New extras
    Dim search As New search

    Dim lista As New Queue

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
        MenuPrincipal.Show()
    End Sub

    Private Sub FilterCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With extras
            .buttons(Button1)
            .buttons(filterBttn)
            .buttons(userBttn)
        End With

        _username.Text = MenuPrincipal._username.Text

        Select Case (datos.rol)
            Case 2
                filterBttn.Visible = True
            Case 3
                filterBttn.Visible = True
                userBttn.Visible = True
        End Select

        refreshlist()
    End Sub

    Public Sub refreshlist()
        Dim palabras As String() = File.ReadAllLines("C:\Musicboxd - imagenes\Insultos.txt")

        lista.Clear()

        listapalabras.Items.Clear()

        For i = 0 To palabras.Length - 1
            lista.Enqueue(palabras(i))
        Next

        For Each z In lista
            listapalabras.Items.Add(z)
        Next
    End Sub

    Private Sub FilterCenter_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result = extras.show(
                    {"Close", "Sign out", "Cancel"},
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

#Region "    searchbar hovers"

    Private Sub searchbar_Enter(sender As Object, e As EventArgs) Handles searchbar.Enter
        If searchbar.Text.Trim = "Search song, album or artist" Then
            With searchbar
                .Text = String.Empty
                .ForeColor = Color.FromArgb(60, 60, 65)
            End With
        End If
    End Sub

    Private Sub searchbar_Leave(sender As Object, e As EventArgs) Handles searchbar.Leave
        If searchbar.Text.Trim = String.Empty Then
            With searchbar
                .Text = "Search song, album or artist"
                .ForeColor = Color.FromArgb(160, 160, 160)
            End With
        End If
    End Sub
#End Region

    Private Sub userBttn_Click(sender As Object, e As EventArgs) Handles userBttn.Click
        Me.Dispose()
        UserCenter.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If searchbar.Text.Trim = "Search song, album or artist" Or
            searchbar.Text.Trim = String.Empty Then

            MessageBox.Show($"Search bar empty.{vbNewLine}Complete the blank space and try again",
                            "Error",
                            MessageBoxButtons.OK)
        Else
            SearchMenu.lbl.Text = $"Search results for: {searchbar.Text.Trim}"

            search.makesearch(searchbar.Text.Trim)

            With SearchMenu.searchbar
                .Text = "Search song, album or artist"
                .ForeColor = Color.FromArgb(160, 160, 160)
            End With

            SearchMenu.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class