
Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.IO
Public Class Form4
    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "DATA SOURCE = localhost; USER id= root; DATABASE = upload"
    Dim CMD As MySqlCommand
    Dim itemcoll(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet
    Dim sql As String
    Dim dt As DataTable
    Dim Attachment As Dictionary(Of Integer, Byte())

    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click

        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub btnupload_Click_1(sender As Object, e As EventArgs) Handles btnupload.Click
        Dim FilenameName As String()
        FilenameName = OpenFileDialog1.FileName.Split("\")
        File.Copy(OpenFileDialog1.FileName, "upload\" + FilenameName(FilenameName.Length - 1))
        MessageBox.Show("File uploaded")
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "INSERT INTO tables (filename) values ('" & TextBox1.Text & "')"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("Record Saved", vbInformation, "Admin")
            Else
                MsgBox("Record Not Saved", vbCritical, "Admin")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Call Form1_Load(sender, e)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            sql = "SELECT * FROM tables"
            CMD = New MySqlCommand
            With CMD
                .Connection = CONNECT
                .CommandText = sql


            End With
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = CMD
            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
        Finally
            da.Dispose()



        End Try

    End Sub


    Private Sub btndownload_Click(sender As Object, e As EventArgs) Handles btndownload.Click

        MsgBox("DOWNLOAD SUCCESS ", MsgBoxStyle.Information)


    End Sub


    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Form3.Show()
    End Sub


End Class