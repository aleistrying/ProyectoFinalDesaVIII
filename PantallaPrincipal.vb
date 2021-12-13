Public Class PantallaPrincipal

    'Public Sub AbrirFormenPanel(Of Miform As {Form, New})()
    '    Dim Formulario As Form
    '    Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault()
    '    If Formulario Is Nothing Then
    '        Formulario = New Miform()
    '        PanelFormularios.Controls.Add(Formulario)
    '        PanelFormularios.Tag = Formulario
    '        Formulario.Show()
    '    Else
    '        Formulario.BringToFront()

    '    End If


    'End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnEditarplatos.Click
        'AbrirFormenPanel(Of )EditarplatosForm()
        With EditarplatosForm
            .TopLevel = False
            PanelFormularios.Controls.Add(EditarplatosForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtneditaUsuarios.Click
        'AbrirFormenPanel(Of EditarUsuariosForm)()
        With EditarUsuariosForm
            .TopLevel = False
            PanelFormularios.Controls.Add(EditarplatosForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnCerrarsesion.Click
        Me.Close()
        loginForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'AbrirFormenPanel(Of MenuForm)()
        With MenuForm
            .TopLevel = False
            PanelFormularios.Controls.Add(MenuForm)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub btnHistorial_Click(sender As Object, e As EventArgs) Handles btnHistorial.Click
        'AbrirFormenPanel(Of Historial_de_facturas)()

        Historial_de_facturas.facturas = MySql.GetFacturas(loginForm.usuario)
        Historial_de_facturas.HistorialDeFacturasDG.Rows.Clear()

        For i As Integer = 0 To Historial_de_facturas.facturas.Length - 1
            Historial_de_facturas.HistorialDeFacturasDG.Rows.Add()

            Historial_de_facturas.HistorialDeFacturasDG.Rows(i).Cells(0).Value = Historial_de_facturas.facturas(i).Item("facturaId") 'id
            Historial_de_facturas.HistorialDeFacturasDG.Rows(i).Cells(1).Value = Math.Round(CDbl(Historial_de_facturas.facturas(i).Item("monto")), 2).ToString("C2") 'costo
            Historial_de_facturas.HistorialDeFacturasDG.Rows(i).Cells(2).Value = Historial_de_facturas.facturas(i).Item("fecha") 'fecha
        Next

        With Historial_de_facturas
            .TopLevel = False
            PanelFormularios.Controls.Add(Historial_de_facturas)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub BtnAnadirFondos_Click(sender As Object, e As EventArgs) Handles BtnAnadirFondos.Click
        'AbrirFormenPanel(Of Añadir_fondos)()
        Dim saldo As Double = MySql.GetSaldo(loginForm.usuario)

        AñadirFondosForm.saldo = Math.Round(CDbl(saldo), 2)
        LblSaldo.Text = Math.Round(CDbl(saldo), 2).ToString("C2")
        AñadirFondosForm.LblSaldoActual.Text = "Saldo Actual: " + Math.Round(CDbl(saldo), 2).ToString("C2")

        With AñadirFondosForm
            .TopLevel = False
            PanelFormularios.Controls.Add(AñadirFondosForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AbrirFormenPanel(Of MenuForm)()
    End Sub
End Class
