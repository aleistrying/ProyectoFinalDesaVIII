Public Class Historial_de_facturas
    Public facturas() As Dictionary(Of String, String)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialDeFacturasDG.CellClick
        If sender.CurrentCell.Value.ToString Like "*Ver Factura*" Then

            FormFactura.LblFacturaId.Text = "ID: " + facturas(sender.CurrentCell.RowIndex).Item("facturaId")
            FormFactura.LblFecha.Text = "Fecha: " + facturas(sender.CurrentCell.RowIndex).Item("fecha")
            FormFactura.LblCliente.Text = "Cliente: " + facturas(sender.CurrentCell.RowIndex).Item("cliente")
            FormFactura.LblCafeteria.Text = "Cafeteria: " + facturas(sender.CurrentCell.RowIndex).Item("cafeteria")
            FormFactura.LblItem.Text = facturas(sender.CurrentCell.RowIndex).Item("descripcion")
            FormFactura.LblTotal.Text = Math.Round(CDbl(facturas(sender.CurrentCell.RowIndex).Item("monto")), 2).ToString("C2")


            With FormFactura
                .TopLevel = False
                PantallaPrincipal.PanelFormularios.Controls.Add(FormFactura)
                .BringToFront()
                .Show()
            End With
            Exit Sub
        End If
    End Sub

End Class