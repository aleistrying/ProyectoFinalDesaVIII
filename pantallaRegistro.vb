Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Text


Public Class pantallaRegistro
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlDr As MySqlDataReader
    Dim passwordRegex As New Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,30}")
    Dim emailRegex As New Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*)@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])")
    Private Sub pantallaRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eyeIconPass.BackgroundImage = My.Resources.eye_solid
        eyeIconPass.BackgroundImageLayout = ImageLayout.Stretch
        eyeIconConPass.BackgroundImage = My.Resources.eye_solid
        eyeIconConPass.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub btnAcceptar_Click(sender As Object, e As EventArgs) Handles btnAcceptar.Click

        If txtNombre.Text = "" Then
            MessageBox.Show("El nombre no puede estar vacio", "Error Nombre")
            Exit Sub
        ElseIf txtApellido.Text = "" Then
            MessageBox.Show("El apellido no puede estar vacio", "Error Email")
            Exit Sub
        ElseIf Not emailRegex.IsMatch(txtEmail.Text) Then
            MessageBox.Show("El email debe ser valido", "Error Email")
            Exit Sub
        ElseIf New Regex("@").Matches(txtEmail.Text).Count > 1 Then
            MessageBox.Show("El email debe ser valido", "Error Email")
            Exit Sub
        ElseIf Not txtEmail.Text.Contains("@utp.ac.pa") Then
            MessageBox.Show("El email debe ser de la institucion de la UTP", "Error Email")
            Exit Sub
        ElseIf Not passwordRegex.IsMatch(txtPassword.Text) Then
            MessageBox.Show("El Password debe tener una minuscula, mayuscula, caracter especial y debe ser minimo 8 caracteres.", "Error Password")
            Exit Sub
        ElseIf Not (txtPasswordConfirmar.Text = txtPassword.Text) Then
            MessageBox.Show("Los passwords deben coincidir", "Error confirmar password")
            Exit Sub
        End If

        Dim exists As Integer = MySql.UsuarioExiste(txtPassword.Text)
        If (exists) Then
            sqlConn.Close()
            MessageBox.Show("Usuario ya existe, Por favor elija otro correo", "Error usuario ya Existe")
            Exit Sub
        End If


        Dim passHash As String = LCase(MD5HashText.HashFromText(LCase(MD5HashText.HashFromText(txtPassword.Text))))
        If passHash = "" Then
            MessageBox.Show("Error al crear el hash", "Error")
        End If

        MySql.CrearUsuario(txtEmail.Text, txtNombre.Text, txtApellido.Text, passHash)

        'Reusamos la funcion de volver para borrar los campos y volver al menu principal
        MessageBox.Show("Su cuenta de estudiante fue creada exitosamente.", "Cuenta de Estudiante Creada")
        btnVolver_Click(vbNull, New EventArgs())

    End Sub

    Private Sub eyeIconPass_Click(sender As Object, e As EventArgs) Handles eyeIconPass.Click
        If txtPassword.PasswordChar = vbNullChar Then
            txtPassword.PasswordChar = "*"c
            eyeIconPass.BackgroundImage = My.Resources.eye_solid
        Else
            txtPassword.PasswordChar = ""
            eyeIconPass.BackgroundImage = My.Resources.eye_slash_solid
        End If
    End Sub

    Private Sub eyeIconConPass_Click(sender As Object, e As EventArgs) Handles eyeIconConPass.Click
        If txtPasswordConfirmar.PasswordChar = vbNullChar Then
            txtPasswordConfirmar.PasswordChar = "*"c
            eyeIconConPass.BackgroundImage = My.Resources.eye_solid
        Else
            txtPasswordConfirmar.PasswordChar = ""
            eyeIconConPass.BackgroundImage = My.Resources.eye_slash_solid
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        loginForm.Show()
        txtPasswordConfirmar.Text = ""
        txtPassword.Text = ""
        txtNombre.Text = ""
        txtEmail.Text = ""
        txtApellido.Text = ""
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class