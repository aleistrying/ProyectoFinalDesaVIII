Public Class EditarUsuariosForm
    Public usuarios() As Usuario
    Dim tipoUsuarios() As Dictionary(Of String, String)
    'Dim cell As New DataGridViewComboBoxCell()
    Dim tiposIds() As Integer
    Dim tiposDesc() As String


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EditarplatosForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        loginForm.Show()
    End Sub
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
            DGEditarUsuarios.Rows(i).Cells(4).Selected = usuarios(i).GetEnabled()
        Next

    End Sub

    Private Sub DGEditarUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEditarUsuarios.CellContentClick
        If sender.CurrentCell.Value.ToString Like "*Editar*" Then

        ElseIf sender.CurrentCell.Value.ToString Like "*Borrar*" Then

        End If
    End Sub
End Class