<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarplatosForm
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
        Me.Button9 = New System.Windows.Forms.Button()
        Me.DGEditarPlatos = New System.Windows.Forms.DataGridView()
        Me.Plato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCft = New System.Windows.Forms.Label()
        Me.CafeteriaComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.DGEditarPlatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(562, 192)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(194, 35)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Añadir platos"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'DGEditarPlatos
        '
        Me.DGEditarPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGEditarPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGEditarPlatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Plato, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5})
        Me.DGEditarPlatos.Location = New System.Drawing.Point(23, 286)
        Me.DGEditarPlatos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGEditarPlatos.Name = "DGEditarPlatos"
        Me.DGEditarPlatos.RowHeadersWidth = 62
        Me.DGEditarPlatos.Size = New System.Drawing.Size(1266, 231)
        Me.DGEditarPlatos.TabIndex = 15
        '
        'Plato
        '
        Me.Plato.HeaderText = "id plato"
        Me.Plato.MinimumWidth = 8
        Me.Plato.Name = "Plato"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre del plato"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column6
        '
        Me.Column6.HeaderText = "Imagen"
        Me.Column6.MinimumWidth = 8
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Editar"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column4.HeaderText = "Editar"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Eliminar"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column5.HeaderText = "Eliminar"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkViolet
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(555, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Editar Platos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 154)
        Me.Panel1.TabIndex = 23
        '
        'lblCft
        '
        Me.lblCft.AutoSize = True
        Me.lblCft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCft.Location = New System.Drawing.Point(113, 217)
        Me.lblCft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCft.Name = "lblCft"
        Me.lblCft.Size = New System.Drawing.Size(319, 25)
        Me.lblCft.TabIndex = 25
        Me.lblCft.Text = "Selecciona la cafeteria a editar aquí"
        Me.lblCft.Visible = False
        '
        'CafeteriaComboBox
        '
        Me.CafeteriaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CafeteriaComboBox.FormattingEnabled = True
        Me.CafeteriaComboBox.Location = New System.Drawing.Point(120, 245)
        Me.CafeteriaComboBox.Name = "CafeteriaComboBox"
        Me.CafeteriaComboBox.Size = New System.Drawing.Size(358, 37)
        Me.CafeteriaComboBox.TabIndex = 24
        '
        'EditarplatosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1312, 720)
        Me.Controls.Add(Me.lblCft)
        Me.Controls.Add(Me.CafeteriaComboBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGEditarPlatos)
        Me.Controls.Add(Me.Button9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditarplatosForm"
        Me.Text = "Editar platos"
        CType(Me.DGEditarPlatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button9 As Button
    Friend WithEvents DGEditarPlatos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Plato As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents lblCft As Label
    Friend WithEvents CafeteriaComboBox As ComboBox
End Class
