Public Class FormFactura
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MenuForm.LoadMenu()
        With MenuForm
            .TopLevel = False
            PantallaPrincipal.PanelFormularios.Controls.Add(MenuForm)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class