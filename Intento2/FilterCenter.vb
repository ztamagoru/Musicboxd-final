Imports System.IO

Public Class FilterCenter
    Dim extras As New extras
    Dim search As New search
    Dim filter As New filter

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Dispose()
        MenuPrincipal.Show()
    End Sub

    Private Sub FilterCenter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With extras
            .buttons(Button1)
            .buttons(filterBttn)
            .buttons(userBttn)
            .buttons(Button2)
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

    Public Sub refreshlist(Optional order As Integer = 1)
        Dim palabras As String() = File.ReadAllLines("C:\Musicboxd - imagenes\Insultos.txt")

        listapalabras.Items.Clear()

        If order = 1 Then
            Dim lista As New Queue

            For i = 0 To palabras.Length - 1
                lista.Enqueue(palabras(i))
            Next

            For Each z In lista
                listapalabras.Items.Add(z)
            Next

            orderby.Text = String.Empty
        Else
            Dim lista As New Stack

            For i = 0 To palabras.Length - 1
                lista.Push(palabras(i))
            Next

            For Each z In lista
                listapalabras.Items.Add(z)
            Next
        End If
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

    Private Sub addword(sender As Object, e As EventArgs) Handles Button2.Click
        If newword.Text.Trim = "Insert new word to filter" Or
                newword.Text.Trim = String.Empty Then
            MessageBox.Show($"New word empty.{vbNewLine}Complete the blank spaces and try again.")
        Else
            If filter.checkword(newword.Text.Trim) Then
                MessageBox.Show($"Word already saved.{vbNewLine}Please try uploading another word.")
            Else
                filter.addword(newword.Text.Trim)
                refreshlist()
            End If
        End If
    End Sub

    Private Sub orderby_SelectedIndexChanged(sender As Object, e As EventArgs) Handles orderby.SelectedIndexChanged
        If orderby.Text = "Recently added" Then
            refreshlist(2)
        Else
            refreshlist()
        End If
    End Sub

    Private Sub newword_Enter(sender As Object, e As EventArgs) Handles newword.Enter
        If newword.Text.Trim = "Insert new word to filter" Then
            With newword
                .Text = String.Empty
                .ForeColor = Color.FromArgb(91, 90, 86)
            End With
        End If
    End Sub

    Private Sub newword_Leave(sender As Object, e As EventArgs) Handles newword.Leave
        If newword.Text.Trim = String.Empty Then
            With newword
                .Text = "Insert new word to filter"
                .ForeColor = Color.FromArgb(160, 160, 160)
            End With
        End If
    End Sub
End Class