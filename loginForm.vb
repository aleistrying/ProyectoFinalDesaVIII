Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class loginForm
    Public Shared usuario As Usuario

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtUsuario.Text = "" Then
            MessageBox.Show("El campo de usuario es requerido", "Error")
            Exit Sub
        ElseIf TxtPassword.Text = "" Then
            MessageBox.Show("El campo de password es requerido", "Error")
            Exit Sub
        End If
        'crear hash del password
        Dim passHash As String = LCase(MD5HashText.HashFromText(LCase(MD5HashText.HashFromText(TxtPassword.Text))))
        Dim datosCorrectos As Integer = MySql.UsuarioLogin(TxtUsuario.Text, passHash)

        If datosCorrectos = 0 Then
            MsgBox("El usuario o password estan incorrectos.", MsgBoxStyle.OkOnly, "Error Login")
            Exit Sub
        End If

        'creamos la sesion del usuario. el password no es necesario porque validamos que los datos estan correctos ya.
        usuario = MySql.CrearSesion(TxtUsuario.Text)
        If usuario.GetSesionToken() = vbNullString Then
            MessageBox.Show("Sucedio un error en la base de datos. No se pudo generar la sesion", "Error")
            Exit Sub
        End If


        'si el usuario ya tiene una cafeteria automatica, que vaya directo a la pantalla de inicio
        'If usuario.GetDefaultCafeteriaId() <> 0 Then
        'PantallaPrincipal.AbrirFormenPanel(Of MenuForm)()

        'Exit Sub
        'End If


        'escoger_cafeteria.DGVCafeterias.Rows().Clear()
        'For Each column As String In cafeterias
        'lo dividimos entre 3 porque tenemos 3 columnas por cada row. EG. 12 elementos de array = 4 rows de datos. esta funciona cambia dependiendo de las filas que hayan.
        'For I As Integer = 0 To cafeterias.GetLength(1) - 1
        '    escoger_cafeteria.DGVCafeterias.Rows.Add()
        '    'checkboxes
        '    escoger_cafeteria.DGVCafeterias.Rows(I).Cells(0).Value = False

        '    'Solo mostramos el nombre por ahora
        '    escoger_cafeteria.DGVCafeterias.Rows(I).Cells(1).Value = cafeterias(1, I)

        '    'id
        '    escoger_cafeteria.DGVCafeterias.Rows(I).Cells(2).Value = cafeterias(0, I)

        '    'location
        '    'DGVCafeterias.Rows(I).Cells(2).Value = cafeterias(2, I)
        'Next
        'rellenar la barra de navegacion
        PantallaPrincipal.LblNombreUsuario.Text = usuario.GetNombre()
        PantallaPrincipal.LblSaldo.Text = String.Format("{0:C2}", usuario.GetSaldo())
        Try
            PantallaPrincipal.ImgUsuario.Load($"http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/perfil/{usuario.GetFoto()}")
        Catch ex As Exception
            MessageBox.Show("La imagen de perfil tuvo un error.", "Imagen Error")
        End Try

        Me.Hide()
        PantallaPrincipal.Show()
        With MenuForm
            .TopLevel = False
            PantallaPrincipal.PanelFormularios.Controls.Add(MenuForm)
            .BringToFront()
            .Show()
        End With

        'Me.Hide()
        'escoger_cafeteria.Show()
        Exit Sub
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

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class