﻿Public Class Historial_de_facturas
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles HistorialDeFacturas.CellClick
        If Me.HistorialDeFacturas.CurrentCell.Value.ToString Like "*Button*" Then
            Me.Hide()
            Generacion_de_Factura.Show()

        End If
    End Sub
End Class