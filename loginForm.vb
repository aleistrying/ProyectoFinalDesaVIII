Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class loginForm
    Dim sqlCmd As New MySqlCommand
    Dim sqlConn As New MySqlConnection
    Dim sqlDr As MySqlDataReader
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtUsuario.Text = "" Then
            MessageBox.Show("El campo de usuario es requerido", "Error")
            Exit Sub
        ElseIf TxtPassword.Text = "" Then
            MessageBox.Show("El campo de password es requerido", "Error")
            Exit Sub
        End If
        'crear hash del password
        Dim passHash As String = MD5HashText.HashFromText(TxtPassword.Text)
        Dim exists As Integer = MySql.UsuarioLogin(TxtUsuario.Text, passHash)

        If (exists) Then
            Me.Hide()
            escoger_cafeteria.Show()
            Exit Sub
        Else
            MsgBox("El usuario o password estan incorrectos.", MsgBoxStyle.OkOnly, "Error Login")
            Exit Sub
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub LblOlvide_Click(sender As Object, e As EventArgs) Handles LblOlvide.Click
        pantallaOlvido.Show()
        Me.Hide()
    End Sub

    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
        pantallaRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class