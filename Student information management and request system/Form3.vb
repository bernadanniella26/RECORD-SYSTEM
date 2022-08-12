Public Class Form3


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()


    End Sub

    Private Sub REQUEST_Click(sender As Object, e As EventArgs) Handles Botton2.Click
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim responce As Integer
        responce = MessageBox.Show("are you sure yoou want to exit ", "exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If responce = vbYes Then
            Application.Exit()

        End If

    End Sub
End Class