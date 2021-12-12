Public Class FormCarrito
    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        Me.Hide()
        Generacion_de_Factura.Show()

    End Sub

    Private Sub Carritodecompras_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CarritodeCompras.CellClick
        If Me.CarritodeCompras.CurrentCell.GetType.ToString Like "*Button*" Then
            Me.CarritodeCompras.Rows.Remove(Me.CarritodeCompras.CurrentRow)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        With MenuForm
            .TopLevel = False
            PantallaPrincipal.PanelFormularios.Controls.Add(MenuForm)
            .BringToFront()
            .Show()
        End With

    End Sub
End Class