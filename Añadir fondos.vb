Public Class AñadirFondosForm
    Public saldo As Double

    Private Sub btnBancoGeneral_Click(sender As Object, e As EventArgs) Handles btnBancoGeneral.Click
        AgregarFondos()
    End Sub

    Private Sub BtnNequi_Click(sender As Object, e As EventArgs) Handles BtnNequi.Click
        AgregarFondos()
    End Sub

    Private Sub BtnBitcoin_Click(sender As Object, e As EventArgs) Handles BtnBitcoin.Click
        AgregarFondos()
    End Sub
    Private Sub AgregarFondos()
        Dim saldoText As Double = TxtAgregarSaldo.Text.Replace(" ", "")
        MySql.AgregarFondos(loginForm.usuario, saldoText)

        Dim nuevoSaldo As Double = Math.Round(MySql.GetSaldo(loginForm.usuario), 2)

        LblSaldoActual.Text = "Saldo Actual: " + nuevoSaldo.ToString("C2")
        PantallaPrincipal.LblSaldo.Text = nuevoSaldo.ToString("C2")
        saldo = nuevoSaldo
        TxtAgregarSaldo.Text = ""
        MessageBox.Show("Fondos agregados exitosamente", "Fondo Success")
    End Sub
End Class