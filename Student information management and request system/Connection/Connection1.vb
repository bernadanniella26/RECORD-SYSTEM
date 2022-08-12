Imports MySql.Data.MySqlClient
Public Class Connection1
    Dim CONNECT As New MySqlConnection("data source = localhost; user id = root; database = simars")
    Public Function open() As MySqlConnection
        Try
            CONNECT.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return CONNECT

    End Function

    Public Function close() As MySqlConnection
        Try
            CONNECT.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return CONNECT

    End Function
End Class