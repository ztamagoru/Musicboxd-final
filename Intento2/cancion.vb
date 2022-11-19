Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class cancion
    Dim conexion As New conexion

    Public Sub obtenerRecomendaciones()
        Dim comando, songName(3), artistName(3) As String

        Dim i As Integer = 0
        Dim reader As SqlDataReader

        comando = "EXEC [Songs].[SP_4_RECOMMENDATIONS]"

        reader = conexion.executeReader(comando)

        While reader.Read()
            songName(i) = reader.GetString(0)
            artistName(i) = reader.GetString(1)

            i += 1

            Dim bytes = CType(reader(2), Byte())

            MenuPrincipal.addCover(bytes, i)
        End While

        conexion.closeDatabase()

        With MenuPrincipal
            .songName1.Text = songName(0)
            .songName2.Text = songName(1)
            .songName3.Text = songName(2)
            .songName4.Text = songName(3)

            .artistName1.Text = artistName(0)
            .artistName2.Text = artistName(1)
            .artistName3.Text = artistName(2)
            .artistName4.Text = artistName(3)
        End With
    End Sub
End Class
