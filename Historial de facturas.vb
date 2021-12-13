Public Class Historial_de_facturas
    Public facturas() As Dictionary(Of String, String)
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialDeFacturasDG.CellClick
        If Me.HistorialDeFacturasDG.CurrentCell.Value.ToString Like "*Button*" Then
            Me.Hide()
            FormFactura.Show()

        End If
    End Sub

    Private Sub Historial_de_facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class