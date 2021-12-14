<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarUsuariosForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGEditarUsuarios = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nivel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Habilitado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGEditarUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGEditarUsuarios
        '
        Me.DGEditarUsuarios.AllowUserToAddRows = False
        Me.DGEditarUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGEditarUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.DGEditarUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGEditarUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGEditarUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEditarUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Apellido, Me.Correo, Me.Nivel, Me.Habilitado, Me.Editar, Me.Eliminar})
        Me.DGEditarUsuarios.GridColor = System.Drawing.SystemColors.Control
        Me.DGEditarUsuarios.Location = New System.Drawing.Point(27, 260)
        Me.DGEditarUsuarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGEditarUsuarios.Name = "DGEditarUsuarios"
        Me.DGEditarUsuarios.RowHeadersWidth = 62
        Me.DGEditarUsuarios.Size = New System.Drawing.Size(1252, 231)
        Me.DGEditarUsuarios.TabIndex = 19
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 104
        '
        'Apellido
        '
        Me.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.MinimumWidth = 8
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Width = 104
        '
        'Correo
        '
        Me.Correo.HeaderText = "correo"
        Me.Correo.MinimumWidth = 8
        Me.Correo.Name = "Correo"
        '
        'Nivel
        '
        Me.Nivel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Nivel.HeaderText = "Nivel"
        Me.Nivel.MinimumWidth = 8
        Me.Nivel.Name = "Nivel"
        Me.Nivel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Nivel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Nivel.Width = 82
        '
        'Habilitado
        '
        Me.Habilitado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Habilitado.HeaderText = "Habilitado"
        Me.Habilitado.MinimumWidth = 8
        Me.Habilitado.Name = "Habilitado"
        Me.Habilitado.Width = 90
        '
        'Editar
        '
        Me.Editar.DataPropertyName = "Editar"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = "Editar"
        Me.Editar.DefaultCellStyle = DataGridViewCellStyle2
        Me.Editar.HeaderText = "Editar"
        Me.Editar.MinimumWidth = 8
        Me.Editar.Name = "Editar"
        Me.Editar.Text = "Editar"
        Me.Editar.ToolTipText = "Editar"
        Me.Editar.UseColumnTextForButtonValue = True
        '
        'Eliminar
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = "Eliminar"
        Me.Eliminar.DefaultCellStyle = DataGridViewCellStyle3
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.MinimumWidth = 8
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkViolet
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(550, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Editar Usuarios"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 172)
        Me.Panel1.TabIndex = 22
        '
        'EditarUsuariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1312, 720)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGEditarUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditarUsuariosForm"
        Me.Text = "Form3"
        CType(Me.DGEditarUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGEditarUsuarios As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Correo As DataGridViewTextBoxColumn
    Friend WithEvents Nivel As DataGridViewComboBoxColumn
    Friend WithEvents Habilitado As DataGridViewCheckBoxColumn
    Friend WithEvents Editar As DataGridViewButtonColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
End Class
