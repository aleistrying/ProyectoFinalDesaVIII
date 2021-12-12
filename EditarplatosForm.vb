Public Class EditarplatosForm

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'PantallaPrincipal.AbrirFormenPanel(Of AñadirPlatoForm)()
        With AñadirPlatoForm
            .TopLevel = False
            PantallaPrincipal.PanelFormularios.Controls.Add(AñadirPlatoForm)
            .BringToFront()
            .Show()
        End With

    End Sub
End Class