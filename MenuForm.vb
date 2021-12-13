Public Class MenuForm

    Public plato = 0
    Public platos(,) As String
    Public cafeterias(,) As String
    'Private Sub Btn_ir_al_carrito_Click(sender As Object, e As EventArgs)
    '    Me.Hide()
    '    FormCarrito.Show()
    'End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cafeterias = MySql.ListaCafeterias()
        CafeteriaComboBox.Items.Clear()
        'cargamos el combo box con las opciones
        For Index As Integer = 0 To cafeterias.GetLength(1) - 1
            CafeteriaComboBox.Items.Add(cafeterias(1, Index))
        Next
        'cargamos la primera cafeteria en el combobox
        If cafeterias.GetLength(1) Then
            CafeteriaComboBox.SelectedIndex = 0
            loginForm.usuario.SetCafeteriaIdSeleccionada(cafeterias(0, 0))
            loginForm.usuario.SetDefaultCafeteriaId(cafeterias(0, 0))
        End If

        platos = MySql.CargarPlatos(loginForm.usuario)
        'cargamos el primer plato
        If platos.Length <> 0 Then
            plato = 0
            LblNombrePlato.Text = platos(1, 0)
            BtnPrecioPlato.Text = Math.Round(CDbl(platos(4, 0)), 2).ToString("C2")
            Try
                ImagenPlato.Load("http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/platos/" + platos(3, 0))
            Catch ex As Exception
                MessageBox.Show("No se pudo encontrar la imagen " + platos(3, 0), "Error")
            End Try
        End If


        If platos.GetLength(1) - 1 = plato And plato <> -1 And platos.GetLength(0) <> 1 Then
            BtnSiguientePlato.Visible = False
            BtnPlatoAnterior.Visible = True
        ElseIf 0 = plato Then
            BtnPlatoAnterior.Visible = False
            BtnSiguientePlato.Visible = True
        Else
            BtnPlatoAnterior.Visible = False
            BtnSiguientePlato.Visible = False
        End If
    End Sub
    Private Sub BtnSiguientePlato_Click(sender As Object, e As EventArgs) Handles BtnSiguientePlato.Click
        If platos.GetLength(1) - 1 > plato Then
            plato += 1
            LblNombrePlato.Text = platos(1, plato)
            BtnPrecioPlato.Text = Math.Round(CDbl(platos(4, plato)), 2).ToString("C2")
            Try
                ImagenPlato.Load("http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/platos/" + platos(3, plato))
            Catch ex As Exception
                MessageBox.Show("No se pudo encontrar la imagen " + platos(3, plato), "Error")
            End Try

        End If

        If platos.GetLength(1) - 1 = plato And plato <> -1 And platos.GetLength(0) <> 1 Then
            BtnSiguientePlato.Visible = False
            BtnPlatoAnterior.Visible = True
        ElseIf 0 = plato Then
            BtnPlatoAnterior.Visible = False
            BtnSiguientePlato.Visible = True
        Else
            BtnPlatoAnterior.Visible = False
            BtnSiguientePlato.Visible = False
        End If
    End Sub

    Private Sub BtnPlatoAnterior_Click(sender As Object, e As EventArgs) Handles BtnPlatoAnterior.Click
        If 0 < plato Then
            plato -= 1
            LblNombrePlato.Text = platos(1, plato)
            BtnPrecioPlato.Text = Math.Round(CDbl(platos(4, plato)), 2).ToString("C2")

            Try
                ImagenPlato.Load("http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/platos/" + platos(3, plato))
            Catch ex As Exception
                MessageBox.Show("No se pudo encontrar la imagen " + platos(3, plato), "Error")
            End Try
        Else
            plato = -1
        End If


        If platos.GetLength(1) - 1 = plato And plato <> -1 And platos.GetLength(0) <> 1 Then
            BtnSiguientePlato.Visible = False
            BtnPlatoAnterior.Visible = True
        ElseIf 0 = plato Then
            BtnPlatoAnterior.Visible = False
            BtnSiguientePlato.Visible = True
        Else
            BtnPlatoAnterior.Visible = False
            BtnSiguientePlato.Visible = False
        End If

    End Sub

    Private Sub CafeteriaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CafeteriaComboBox.SelectedIndexChanged
        If CafeteriaComboBox.SelectedIndex > -1 Then
            Dim sindex As Integer
            sindex = CafeteriaComboBox.SelectedIndex

            loginForm.usuario.SetCafeteriaIdSeleccionada(cafeterias(0, sindex))
            'probablemente ya no es necesario.
            loginForm.usuario.SetDefaultCafeteriaId(cafeterias(0, sindex))

            platos = MySql.CargarPlatos(loginForm.usuario)
            'cargamos el primer plato
            If platos.Length <> 0 Then
                plato = 0
                LblNombrePlato.Text = platos(1, 0)
                BtnPrecioPlato.Show()
                BtnPrecioPlato.Text = Math.Round(CDbl(platos(4, 0)), 2).ToString("C2")
                Try
                    ImagenPlato.Show()
                    ImagenPlato.Load("http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/platos/" + platos(3, 0))
                Catch ex As Exception
                    MessageBox.Show("No se pudo encontrar la imagen " + platos(3, 0), "Error")
                End Try
            Else
                plato = -1
                LblNombrePlato.Text = "No hay platos en esta cafeteria"
                BtnPrecioPlato.Text = ""
                BtnPrecioPlato.Hide()
                ImagenPlato.Hide()
            End If

            If platos.GetLength(1) - 1 = plato And plato <> -1 And platos.GetLength(0) <> 1 Then
                BtnSiguientePlato.Visible = False
                BtnPlatoAnterior.Visible = True
            ElseIf 0 = plato Then
                BtnPlatoAnterior.Visible = False
                BtnSiguientePlato.Visible = True
            Else
                BtnPlatoAnterior.Visible = False
                BtnSiguientePlato.Visible = False
            End If
        End If
    End Sub

    Private Sub BtnPrecioPlato_Click(sender As Object, e As EventArgs) Handles BtnPrecioPlato.Click
        'Me.Hide()
        'PantallaPrincipal.Show()
        FormCarrito.LblNombre.Text = platos(1, plato)
        FormCarrito.LblDescripcion.Text = platos(2, plato)
        FormCarrito.ImagenCompra.Load("http://cafeteria.eastus2.cloudapp.azure.com/cdn/photo/platos/" + platos(3, plato))
        FormCarrito.LblPrecio.Text = Math.Round(CDbl(platos(4, plato)), 2).ToString("C2")

        With FormCarrito
            .TopLevel = False
            PantallaPrincipal.PanelFormularios.Controls.Add(FormCarrito)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class