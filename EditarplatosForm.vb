Public Class EditarplatosForm
    Public platos(,) As String
    Public cafeterias(,) As String
    Public cafeteria As Integer = 0


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'PantallaPrincipal.AbrirFormenPanel(Of AñadirPlatoForm)()
        With AñadirPlatoForm
            .TopLevel = False
            PantallaPrincipal.PanelFormularios.Controls.Add(AñadirPlatoForm)
            .BringToFront()
            .Show()
        End With

    End Sub
    Public Sub RefreshCafeterias()
        cafeterias = MySql.ListaCafeterias()
        platos = MySql.GetPlatos(cafeterias(0, cafeteria))

        CafeteriaComboBox.Items.Clear()
        For i As Integer = 0 To cafeterias.GetLength(1) - 1
            CafeteriaComboBox.Items.Add(cafeterias(1, i))
        Next

        CafeteriaComboBox.Text = cafeterias(1, cafeteria)
    End Sub
    Public Sub RefreshDataGrid()

        DGEditarPlatos.Rows.Clear()
        If platos.Length = 0 Then
            Exit Sub
        End If
        'llenar data grid
        For i As Integer = 0 To platos.GetLength(1) - 1
            DGEditarPlatos.Rows.Add()
            DGEditarPlatos.Rows(i).Cells(0).Value = platos(0, i) 'id
            DGEditarPlatos.Rows(i).Cells(1).Value = platos(1, i) 'nombre
            DGEditarPlatos.Rows(i).Cells(2).Value = platos(2, i) 'desc
            DGEditarPlatos.Rows(i).Cells(3).Value = Math.Round(CDbl(platos(3, i)), 2) 'precio
            DGEditarPlatos.Rows(i).Cells(4).Value = platos(4, i) 'foto
            DGEditarPlatos.Rows(i).Cells(5).Value = platos(5, i) 'stock
            DGEditarPlatos.Rows(i).Cells(6).Value = platos(6, i) 'enable
        Next
    End Sub
    Private Sub CafeteriaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CafeteriaComboBox.SelectedIndexChanged
        If CafeteriaComboBox.SelectedIndex > -1 Then
            Dim sindex As Integer = CafeteriaComboBox.SelectedIndex

            platos = MySql.GetPlatos(cafeterias(0, sindex))
            RefreshDataGrid()
        End If

    End Sub
    Private Sub DGEditarPlatos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEditarPlatos.CellContentClick
        Dim index As Integer = sender.CurrentCell.RowIndex
        If e.ColumnIndex = 7 Then 'sender.CurrentCell.Value.ToString() Like "*Editar*" Then
            Dim plato() As String = {
                DGEditarPlatos.Rows(index).Cells(0).Value,
                DGEditarPlatos.Rows(index).Cells(1).Value,
                DGEditarPlatos.Rows(index).Cells(2).Value,
                DGEditarPlatos.Rows(index).Cells(3).Value,
                DGEditarPlatos.Rows(index).Cells(4).Value,
                DGEditarPlatos.Rows(index).Cells(5).Value,
                DGEditarPlatos.Rows(index).Cells(6).Value}
            Dim success As Integer = MySql.EditarPlato(plato, cafeterias(0, cafeteria))
            If success <> 0 Then
                MessageBox.Show("Se actualizo el plato con exito", "Success")
            Else
                MessageBox.Show("No se pudo actualizar al plato", "error")
            End If
            RefreshCafeterias()
            RefreshDataGrid()

        ElseIf e.ColumnIndex = 8 Then  ' sender.CurrentCell.Value.ToString() Like "*Borrar*" Then
            Dim success As Integer = MySql.BorrarPlato(platos(0, index), cafeterias(0, cafeteria))
            If success <> 0 Then
                MessageBox.Show("Se borro el plato con exito", "Success")
            Else
                MessageBox.Show("No se pudo borrar el plato", "error")
            End If
            RefreshCafeterias()
            RefreshDataGrid()
        End If
    End Sub
End Class