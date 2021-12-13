Public Class FormCarrito
    Public facturaId = 0
    Public factura As Dictionary(Of String, String)
    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        ' Revisar si usuario tiene saldo.
        Dim saldo = MySql.GetSaldo(loginForm.usuario)
        If saldo = vbNullString Then
            'usuario no tiene sesion valida
            MessageBox.Show("No tienes una sesion valida. Vuelve a ingresar.", "Error de Sesion")
            PantallaPrincipal.Hide()
            loginForm.Show()
            Exit Sub
        End If
        'cambiar la interface grafica con la actualizacion del saldo nuevo 

        loginForm.usuario.SetSaldo(saldo)
        PantallaPrincipal.LblSaldo.Text = Math.Round(CDbl(saldo), 2).ToString("C2")

        ' Si usuario no tiene saldo entonces mandar mensaje
        If saldo < MenuForm.platos(4, MenuForm.plato) Then
            MessageBox.Show("No tienes suficiente saldo para realizar esta compra. Por favor agrega mas saldo.")
            Exit Sub
        End If

        ' si usuario tiene saldo, entonces realizar venta, 
        ' y llevar a la pantalla de factura con los datos
        facturaId = MySql.CrearFactura(MenuForm.platos(0, MenuForm.plato), loginForm.usuario)
        If facturaId = vbNullString Then
            'usuario no tiene sesion valida
            MessageBox.Show("No tienes una sesion valida. Vuelve a ingresar.", "Error de Sesion")
            PantallaPrincipal.Hide()
            loginForm.Show()
            Exit Sub
        ElseIf facturaId.ToString().StartsWith("ERROR:") Then
            MessageBox.Show(facturaId, "Error")
            Exit Sub
        End If

        factura = MySql.GetFactura(facturaId, loginForm.usuario)

        If factura.Count = 0 Then
            MessageBox.Show("Error Al buscar factura. Vuelva a ingresar al sistema.", "Error de Sesion")
            PantallaPrincipal.Hide()
            loginForm.Show()
            Exit Sub
        End If

        FormFactura.LblFecha.Text = "Fecha: " + factura.Item("fecha")
        FormFactura.LblCliente.Text = "Cliente: " + factura.Item("cliente")
        FormFactura.LblCafeteria.Text = "Cafeteria: " + factura.Item("cafeteria")
        FormFactura.LblItem.Text = factura.Item("descripcion")
        FormFactura.LblTotal.Text = factura.Item("monto")

        With FormFactura
            .TopLevel = False
            PantallaPrincipal.PanelFormularios.Controls.Add(FormFactura)
            .BringToFront()
            .Show()
        End With


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