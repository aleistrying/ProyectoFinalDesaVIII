Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class loginForm
    Dim sqlCmd As New MySqlCommand
    Dim sqlConn As New MySqlConnection
    Dim sqlDr As MySqlDataReader
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsuario.Text = "" Then
            MessageBox.Show("El campo de usuario es requerido", "Error")
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("El campo de password es requerido", "Error")
            Exit Sub
        End If
        'crear hash del password

        Dim exists As Integer = MySql.UsuarioLogin(txtUsuario.Text, txtPassword.Text)

        If (exists) Then
            Me.Hide()
            Form1.Show()
            Exit Sub
        Else
            MsgBox("El usuario o password estan incorrectos.", MsgBoxStyle.OkOnly, "Error Login")
            Exit Sub
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub lblOlvide_Click(sender As Object, e As EventArgs) Handles lblOlvide.Click
        pantallaOlvido.Show()
        Me.Hide()
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        pantallaRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class