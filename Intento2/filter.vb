Imports System.IO

Public Class filter

    Public Function checkword(word As String)
        Dim palabras As String() = File.ReadAllLines("C:\Musicboxd - imagenes\Insultos.txt")

        Dim i As Integer

        For i = 0 To palabras.Length - 1
            If word = palabras(i) Then
                Exit For
            End If
        Next

        If i < palabras.Length - 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub addword(newword As String)
        Using writer As New StreamWriter("C:\Musicboxd - imagenes\Insultos.txt", True)
            writer.WriteLine($"{newword}")
        End Using
    End Sub
End Class
