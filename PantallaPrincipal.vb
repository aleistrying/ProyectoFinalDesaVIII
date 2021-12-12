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
        With Historial_de_facturas
            .TopLevel = False
            PanelFormularios.Controls.Add(Historial_de_facturas)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'AbrirFormenPanel(Of Añadir_fondos)()
        With AñadirPlatoForm
            .TopLevel = False
            PanelFormularios.Controls.Add(AñadirPlatoForm)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub PantallaPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AbrirFormenPanel(Of MenuForm)()
    End Sub
End Class
