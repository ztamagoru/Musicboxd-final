Imports System.Data.SqlClient

Public Class artist
    Inherits album

    Dim conexion As New conexion

    Public Sub searchartist(search As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Songs].[SP_ARTIST_SEARCH]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@search", search)

            Dim reader As SqlDataReader

            reader = .ExecuteReader

            If reader.HasRows Then
                While reader.Read()
                    Dim artistbutton As New ArtistButton

                    Dim name = reader.GetString(0)
                    Dim photo = CType(reader(1), Byte())

                    artistbutton.seteartexto(name, photo)

                    SearchMenu.artistpanel.Controls.Add(artistbutton)
                End While
            Else
                SearchMenu.artistpanel.Visible = False
            End If

            reader.Close()
        End With

        conexion.closeDatabase()
    End Sub

    Public Sub specificartist(name As String)

    End Sub
End Class
