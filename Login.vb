Imports MySql.Data.MySqlClient

Public Class Login
    Public Conexion As New MySqlConnection

    Public Sub ConectarMySQL()
        Try
            With Conexion
                .ConnectionString = "server=localhost;User Id=root;database=tienda;Password=root;SslMode=none"
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class