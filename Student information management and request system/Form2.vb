Imports MySql.Data.MySqlClient
Public Class Form2
    Dim D As MySqlConnection
    Dim X As String = "data source = localhost; user id = root; database = upload"
    Dim T As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            D = New MySqlConnection(X)
            D.Open()
            Dim SQL As String = "INSERT INTO login_form (Username, Password, Student_Num, Email, Course, Year ) values ('" & Username.Text & "','" & Password.Text & "','" & Student_num.Text & "','" & Email.Text & "','" & Course.Text & "','" & Year.Text & "')"
            T = New MySqlCommand(SQL, D)
            Dim r As Integer = T.ExecuteNonQuery
            If r <> 0 Then
                MsgBox("Record saved", vbInformation, "Admin")
                Me.Hide()
                Form1.Show()
            Else
                MsgBox("Record not save", vbCritical, "Admin")
            End If
            D.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub
End Class