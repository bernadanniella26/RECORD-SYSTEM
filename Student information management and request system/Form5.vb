
Imports System.Net.Mail
Public Class Form5
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

            MsgBox("Mail has been succesfully sent!", MsgBoxStyle.Information)

        Catch ex As Exception

                MsgBox(ex.Message, vbCritical)

            End Try

        End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
    End Sub
End Class
