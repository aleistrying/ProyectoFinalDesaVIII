Public Class Inicio_de_sesion_usuario
    Private Sub Btn_ir_al_carrito_Click(sender As Object, e As EventArgs) Handles Btn_ir_al_carrito.Click
        Me.Hide()
        FormCarrito.Show()
    End Sub

    Private Sub Inicio_de_sesion_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim platos(,) As String = MySql.CargarPlatos(loginForm.usuario)
        'cargamos el primer plato

    End Sub
End Class