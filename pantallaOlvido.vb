Imports System.Net.Mail
Public Class pantallaOlvido

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEnviarCodigo.Click
        Dim email As New Mail
        If MySql.UsuarioExiste(txtUsuario.Text) = 0 Then
            MessageBox.Show("Usuario no exite", "Error Usuario")
            Exit Sub
        End If

        Dim pass As String = LCase(MD5HashText.HashFromText(Date.Now.ToString() + txtUsuario.Text))
        MySql.ActualizarClaveUsuario(txtUsuario.Text, LCase(MD5HashText.HashFromText(LCase(MD5HashText.HashFromText(pass)))))
        email.MailMessage = $"<p>Buen día, su nuevo password es:</p><p>{pass}</p><p> Que pase un excelente día :)</p>"
        email.MailSubject = "Recuperacion de cuenta"
        email.MailMessageTo = txtUsuario.Text
        Dim exito As Boolean = Mail.SendMail(email)
        If exito Then
            Me.Hide()
            loginForm.Show()
            MessageBox.Show("Correo Enviado Exitosamente", "Success")
        Else
            MessageBox.Show("Error enviando correos", "Error")
        End If

    End Sub
End Class
Public Class Mail
    Public Property MailMessageTo As String
    Public Property MailMessage As String
    Public Property MailSubject As String

    'This will send your mail...
    Public Shared Function SendMail(ByVal oMail As Mail) As Boolean
        Dim Smtp_Server As New SmtpClient("smtp.gmail.com")
        Dim e_mail As New MailMessage()

        Try
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("utp.cafeteria.online@gmail.com", "rfj80349q8fjq094wfkjaposdf")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            'Smtp_Server.Host =
            e_mail = New MailMessage()
            e_mail.From = New MailAddress("utp.cafeteria.online@gmail.com") 'Whatever you want here'
            e_mail.To.Add(oMail.MailMessageTo)
            e_mail.Subject = oMail.MailSubject
            e_mail.IsBodyHtml = True
            e_mail.Body = oMail.MailMessage
            Smtp_Server.Send(e_mail)

            Return True
        Catch error_t As Exception
            Return False
        Finally
            Smtp_Server = Nothing
            e_mail = Nothing
        End Try

    End Function

End Class