Public Class EditarUsuariosForm
    Public usuarios() As Usuario
    Dim tipoUsuarios() As Dictionary(Of String, String)
    'Dim cell As New DataGridViewComboBoxCell()
    Dim tiposIds() As Integer
    Dim tiposDesc() As String

    Public Sub RefreshDataGrid()
        'recibir datos de la base de datos
        usuarios = MySql.GetUsuarios()
        tipoUsuarios = MySql.GetTipoUsuarios()
        'Dim cell As New DataGridViewComboBoxCell()
        ReDim tiposIds(tipoUsuarios.Length - 1)
        ReDim tiposDesc(tipoUsuarios.Length - 1)
        'cell.Items.Clear()
        For i As Integer = 0 To tipoUsuarios.Length - 1
            'cell.Items.Add(tipoUsuarios(i).Item("descripcion"))
            tiposDesc(i) = tipoUsuarios(i).Item("descripcion")
            tiposIds(i) = tipoUsuarios(i).Item("id")
        Next
        'cell.DataSource = 
        'llenar data grid
        DGEditarUsuarios.Rows.Clear()
        For i As Integer = 0 To usuarios.Length - 1
            DGEditarUsuarios.Rows.Add()
            DGEditarUsuarios.Rows(i).Cells(0).Value = usuarios(i).GetNombre()
            DGEditarUsuarios.Rows(i).Cells(1).Value = usuarios(i).GetApellido()
            DGEditarUsuarios.Rows(i).Cells(2).Value = usuarios(i).GetEmail()
            'manejar un poco distinto por ser lista.
            Dim DGVComboBoxCell As DataGridViewComboBoxCell = DGEditarUsuarios.Rows(i).Cells(3)
            DGVComboBoxCell.DataSource = tiposDesc
            DGVComboBoxCell.Value = tiposDesc(Array.FindIndex(tiposIds, Function(s) s = usuarios(i).GetTipoUsuario()))
            'DGEditarUsuarios.Rows(i).Cells(3).Value = usuarios(i).GetTipoUsuario()
            DGEditarUsuarios.Rows(i).Cells(4).Value = usuarios(i).GetEnabled()

            'Dim DGVCheckBox As DataGridViewCheckBoxCell = DGEditarUsuarios.Rows(i).Cells(4)
            'DGVCheckBox.Value = usuarios(i).GetEnabled()
        Next

    End Sub

    Private Sub DGEditarUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEditarUsuarios.CellContentClick

        Dim index As Integer = sender.CurrentCell.RowIndex
        If e.ColumnIndex = 5 Then 'sender.CurrentCell.Value.ToString() Like "*Editar*" Then
            Dim usuarioEditado As New Usuario(usuarios(index).GetId(),'no se editara
                                              DGEditarUsuarios.Rows(index).Cells(0).Value,
DGEditarUsuarios.Rows(index).Cells(1).Value,
DGEditarUsuarios.Rows(index).Cells(2).Value,
tiposIds(Array.FindIndex(tiposDesc, Function(x) x = DGEditarUsuarios.Rows(index).Cells(3).Value)),
"",' no se editara la foto
            "m",' no se editara el sexo
0) ' default cafeteria no imporat
            usuarioEditado.SetEnabled(DGEditarUsuarios.Rows(index).Cells(4).Value)
            Dim success As Integer = MySql.EditarUsuario(usuarioEditado)
            If success <> 0 Then
                MessageBox.Show("Se actualizo el usuario con exito", "Success")
            Else
                MessageBox.Show("No se pudo actualizar al usuario", "error")
            End If
            RefreshDataGrid()

        ElseIf e.ColumnIndex = 6 Then  ' sender.CurrentCell.Value.ToString() Like "*Borrar*" Then
            Dim success As Integer = MySql.BorrarUsuario(usuarios(index).GetId())
            If success <> 0 Then
                MessageBox.Show("Se borro el usuario con exito", "Success")
            Else
                MessageBox.Show("No se pudo borrar al usuario", "error")
            End If
            RefreshDataGrid()
        End If
    End Sub
End Class