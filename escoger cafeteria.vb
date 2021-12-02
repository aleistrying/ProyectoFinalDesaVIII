Public Class escoger_cafeteria
    Private Sub BtnAcceptarCafeteria_Click(sender As Object, e As EventArgs) Handles BtnAcceptarCafeteria.Click
        'revisamos si el usuario eligio algun dato
        Dim seleccionoDato As Boolean = False
        ' y guardamos en memoria lla eleccion del usuario
        For Each row As DataGridViewRow In DGVCafeterias.Rows
            If row.Cells(0).Value = True Then
                loginForm.usuario.SetCafeteriaIdSeleccionada(row.Cells(2).Value)
                seleccionoDato = True
                Exit For
            End If
        Next

        If seleccionoDato = False Then
            MessageBox.Show("Debe seleccionar una cafeteria para poder continuar.", "Error")
            Exit Sub
        End If

        'si el usuario elije guardar su eleccion entonces haacemos update en la base de datos. 
        If ChkRecordarSeleccion.Checked Then
            MySql.ActualizarUsuarioCafeteria(loginForm.usuario)
        End If
        Me.Hide()
        MenuForm.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        'vaciar los datos de la cuenta
        loginForm.usuario = New Usuario(0, "", "", "", 0, "", "", 0)
        DGVCafeterias.Rows.Clear()
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub Escoger_cafeteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim cafeterias(,) As String = MySql.ListaCafeterias()
        'DGVCafeterias.Rows().Clear()
        ''For Each column As String In cafeterias
        ''lo dividimos entre 3 porque tenemos 3 columnas por cada row. EG. 12 elementos de array = 4 rows de datos. esta funciona cambia dependiendo de las filas que hayan.
        'For I As Integer = 0 To cafeterias.GetLength(1) - 1
        '    DGVCafeterias.Rows.Add()
        '    'id
        '    'DGVCafeterias.Rows(I).Cells(0).Value = cafeterias(0, I)

        '    'checkboxes
        '    DGVCafeterias.Rows(I).Cells(0).Value = False

        '    'Solo mostramos el nombre por ahora
        '    DGVCafeterias.Rows(I).Cells(1).Value = cafeterias(1, I)

        '    'location
        '    'DGVCafeterias.Rows(I).Cells(2).Value = cafeterias(2, I)
        'Next
    End Sub

    Private Sub DGVCafeterias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCafeterias.CellContentClick
        'Para asegurarnos que funcione como radio button:

        If DGVCafeterias.Rows.Count() <= 0 Then
            Exit Sub
        End If

        If e.ColumnIndex = 0 Then
            For Each row As DataGridViewRow In DGVCafeterias.Rows
                row.Cells(0).Value = False
            Next
            DGVCafeterias.CurrentRow.Cells(0).Value = True
        End If
    End Sub
End Class