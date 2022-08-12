Imports MySql.Data.MySqlClient
Public Class Form1
#Region "Declares"
    Dim myconnection As New Connection1
    Dim connect As MySqlConnection
    Dim DA As MySqlDataAdapter
    Dim DT As New DataTable
    Dim CMD As MySqlCommand
    Dim objdatareader As MySqlDataReader
    Dim X As String = "data source = localhost; user id = root; database = upload"

    Private Sub Username1_Enter(sender As Object, e As EventArgs) Handles Username1.Enter
        Dim username As String = Username1.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then

            Username1.Text = ""
            Username1.ForeColor = Color.Black

        End If
    End Sub

    Private Sub Username1_Leave(sender As Object, e As EventArgs) Handles Username1.Leave

        Dim username As String = Username1.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then

            Username1.Text = "username"
            Username1.ForeColor = Color.DarkGray

        End If
    End Sub

    Private Sub Password1_Enter(sender As Object, e As EventArgs) Handles Password1.Enter

        Dim password As String = Password1.Text
        If password.Trim().ToLower() = "password" Or password.Trim() = "" Then

            Password1.Text = ""
            Password1.ForeColor = Color.Black
            Password1.UseSystemPasswordChar = True


        End If

    End Sub

    Private Sub Password1_Leave(sender As Object, e As EventArgs) Handles Password1.Leave

        Dim password As String = Password1.Text
        If password.Trim().ToLower() = "password" Or password.Trim() = "" Then

            Password1.Text = "password"
            Password1.ForeColor = Color.DarkGray
            Password1.UseSystemPasswordChar = False


        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub BTNenter_Click(sender As Object, e As EventArgs) Handles BTNenter.Click
        Try
            connect = New MySqlConnection(X)
            connect.Open()
            Dim SQL As String = " select * from login_form where Username =  '" & Username1.Text & "' "
            CMD = New MySqlCommand(SQL, connect)
            Dim i As Integer = CMD.ExecuteNonQuery
            objdatareader = CMD.ExecuteReader
            objdatareader.Read()
            If (objdatareader(0)) = Username1.Text And (objdatareader(1)) = Password1.Text Then
                MsgBox("Successfully Logged in!!!", vbInformation, "Congratulations")
                Form3.Show()
            Else
                MsgBox("Name and Student Number didn't match")

            End If

        Catch ex As Exception
            MsgBox("Error, You're not registered yet or there's a problem in the database.", vbCritical, "Error")
        End Try
#End Region
    End Sub

    Private Sub Username1_TextChanged(sender As Object, e As EventArgs) Handles Username1.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
