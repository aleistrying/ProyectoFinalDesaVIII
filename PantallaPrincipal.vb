Public Class PantallaPrincipal

    Private Sub AbrirFormenPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform()
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            Formulario.Show()
        Else
            Formulario.BringToFront()

        End If


    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnEditarplatos.Click
        AbrirFormenPanel(Of EditarplatosForm)()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtneditaUsuarios.Click
        AbrirFormenPanel(Of EditarUsuariosForm)()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCerrarsesion.Click
        Me.Close()
        loginForm.Show()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormenPanel(Of MenuForm)()
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click

    End Sub

    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        AbrirFormenPanel(Of Historial_de_facturas)()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormenPanel(Of Añadir_fondos)()
    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFormenPanel(Of MenuForm)()
    End Sub
End Class
