Public Class FormCarrito
    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        Me.Hide()
        Generacion_de_Factura.Show()

    End Sub

    Private Sub Carritodecompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Carritodecompras.CellClick
        If Me.Carritodecompras.CurrentCell.GetType.ToString Like "*Button*" Then
            Me.Carritodecompras.Rows.Remove(Me.Carritodecompras.CurrentRow)
        End If
    End Sub
End Class