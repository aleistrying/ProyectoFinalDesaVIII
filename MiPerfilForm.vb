Public Class MiPerfilForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'detectar si algun campo es invalid
        If TxtNombre.Text = "" Then
            MessageBox.Show("El nombre no puede estar vacio.", "Error Nombre")
            Exit Sub
        ElseIf TxtApellido.Text = "" Then
            MessageBox.Show("El apellido no puede estar vacio.", "Error Apellido")
            Exit Sub
        ElseIf ComboBoxFotoPerfil.FindStringExact(ComboBoxFotoPerfil.Text) < 0 Then
            MessageBox.Show("La imagen seleccionada no es una opcion valida.", "Error de Imagen")
            Exit Sub
        End If
        'actualizar el objeto local de usuario para tener un cache
        loginForm.usuario.SetApellido(TxtApellido.Text)
        loginForm.usuario.SetNombre(TxtNombre.Text)
        loginForm.usuario.SetFoto(ComboBoxFotoPerfil.Text)

        'actualizar usario en la base de datos
        Dim actualizo As Integer = MySql.ActualizarUsuario(loginForm.usuario)
        If actualizo <> 1 Then
            MessageBox.Show("No se pudo actualizar correctamente los registros.", "Error Actualizacion")
            Exit Sub
        End If

        'recibir los datos de usuario nuevamente, por si hay algun cambio extra.
        Dim user As Usuario = MySql.CrearSesion(loginForm.usuario.GetEmail())
        ActualizarUsuario(user)

        MessageBox.Show("Se actualizo su perfil con exito.", "Success")
    End Sub
    Public Sub ActualizarUsuario(user As Usuario)
        'si algun dato fue cambiado, entonces actualizamos el objeto con los datos de la base de datos.
        loginForm.usuario = user
        TxtCorreo.Text = user.GetEmail()
        TxtApellido.Text = user.GetApellido()
        TxtNombre.Text = user.GetNombre()

        Try
            PictureBox1.Load("http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/perfil/" + user.GetFoto())
            PantallaPrincipal.ImgUsuario.Load("http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/perfil/" + user.GetFoto())
        Catch ex As Exception
            MessageBox.Show("No se pudo encontrar la imagen " + user.GetFoto(), "Error")
        End Try

        ComboBoxFotoPerfil.Text = user.GetFoto()

        'Actualizar los datos de la barra de navegacion
        PantallaPrincipal.LblNombreUsuario.Text = user.GetNombre() + " " + user.GetApellido().ToString().Substring(0, 1) + "."


    End Sub

    Private Sub ComboBoxFotoPerfil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFotoPerfil.SelectedIndexChanged
        If ComboBoxFotoPerfil.FindStringExact(ComboBoxFotoPerfil.Text) < 0 Then
            MessageBox.Show("La imagen seleccionada no es una opcion valida.", "Error de Imagen")
            Exit Sub
        End If

        Try
            PictureBox1.Load("http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/perfil/" + ComboBoxFotoPerfil.Text)
        Catch ex As Exception
            MessageBox.Show("No se pudo encontrar la imagen " + ComboBoxFotoPerfil.Text, "Error")
        End Try


    End Sub
End Class