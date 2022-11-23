Imports System.Data.SqlClient

Public Class datos
    Dim conexion As New conexion
    Dim dataset As DataSet
    Dim dataadapter As SqlDataAdapter

    Private Shared _rol As Integer

    Public Shared Property rol As Integer
        Get
            Return _rol
        End Get
        Set(value As Integer)
            _rol = value
        End Set
    End Property

    Public Sub login(user As String, pass As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Users].[SP_LOG_IN]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", user)
            .Parameters.AddWithValue("@password", pass)
            .Parameters.Add("@rol", SqlDbType.Int).Direction = ParameterDirection.Output

            .ExecuteScalar()

            If .Parameters("@rol").Value <> 0 Then
                rol = .Parameters("@rol").Value
            Else
                rol = 0
            End If

            conexion.closeDatabase()
        End With
    End Sub

    Public Function comparedata() As Integer
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Users].[SP_VERIFY_EXISTING_ACCOUNT]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", validador.username)
            .Parameters.AddWithValue("@email", validador.useremail)
            .Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output

            .ExecuteScalar()

            conexion.closeDatabase()
            If .Parameters("@result").Value <> 0 Then
                Return .Parameters("@result").Value
            End If

        End With

        Return 0
    End Function

    Public Sub registeruser()
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Users].[SP_CREATE_ACCOUNT]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", validador.username)
            .Parameters.AddWithValue("@password", validador.password)
            .Parameters.AddWithValue("@mail", validador.useremail)
            .Parameters.AddWithValue("@name", validador.uname)
            .Parameters.AddWithValue("@surname", validador.usurname)

            .ExecuteScalar()

            conexion.closeDatabase()
        End With
    End Sub

    Public Sub getallusers(username As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Users].[SP_GET_ALL_USERS]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", username)

            .ExecuteScalar()

            dataset = New DataSet
            dataadapter = New SqlDataAdapter(conexion.cmd)

            dataadapter.Fill(dataset)

            UserCenter.dgUsers.DataSource = dataset.Tables(0).DefaultView
        End With

        conexion.closeDatabase()
    End Sub

    Public Sub getuserinfo(username As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Users].[SP_GET_USER_INFO]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", username)

            Dim reader As SqlDataReader

            reader = .ExecuteReader()

            reader.Read()

            With UserCenter
                .txtusername.Text = reader.GetString(0)
                .txtemail.Text = reader.GetString(1)
                .txtname.Text = reader.GetString(2)
                .txtsurname.Text = reader.GetString(3)

                .role.SelectedIndex = .role.FindStringExact(reader.GetString(4))
            End With

            reader.Close()
        End With

        conexion.closeDatabase()
    End Sub

    Public Sub changerole(username As String, newrole As String)
        conexion.openDatabase()
        conexion.cmd = New SqlCommand("[Users].[SP_CHANGE_ROLE]", conexion.conn)

        With conexion.cmd
            .CommandType = CommandType.StoredProcedure
            .Parameters.AddWithValue("@username", username)

            .ExecuteScalar()
        End With

        conexion.closeDatabase()
    End Sub
End Class
