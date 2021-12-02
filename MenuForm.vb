Public Class MenuForm
    Private Sub Btn_ir_al_carrito_Click(sender As Object, e As EventArgs) Handles Btn_ir_al_carrito.Click
        Me.Hide()
        FormCarrito.Show()
    End Sub
End Class