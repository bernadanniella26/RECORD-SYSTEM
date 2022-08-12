
Imports System.Net.Mail
Public Class Form6
    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click

        Try

            Dim mail As New MailMessage

            Dim smtpServer As New SmtpClient("smtp.gmail.com")

            mail.From = New MailAddress(txtFrom.Text)

            mail.To.Add(txtTo.Text)

            mail.Subject = txtSubject.Text
            mail.Body = txtBody.Text

            smtpServer.Port = 587
            smtpServer.Credentials = New System.Net.NetworkCredential(txtFrom.Text, "qnqkbxnbgdggrvus")

            smtpServer.EnableSsl = True

            smtpServer.Send(mail)

            MsgBox("Mail has been succesfully sent!, wait 2 to 4 days  starting from request day before you pickup. ", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox(ex.Message, vbCritical)

        End Try

    End Sub

    Private Sub send_Click_1(sender As Object, e As EventArgs) Handles send.Click

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Form7.Show()
    End Sub
End Class

