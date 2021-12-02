<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCarrito
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Carritodecompras = New System.Windows.Forms.DataGridView()
        Me.nombre_plato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioPlato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPlato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenPlato = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btneliminardelista = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label_total_a_pagar = New System.Windows.Forms.Label()
        CType(Me.Carritodecompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Carritodecompras
        '
        Me.Carritodecompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Carritodecompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre_plato, Me.PrecioPlato, Me.DescripcionPlato, Me.ImagenPlato, Me.btneliminardelista})
        Me.Carritodecompras.Location = New System.Drawing.Point(132, 95)
        Me.Carritodecompras.Name = "Carritodecompras"
        Me.Carritodecompras.Size = New System.Drawing.Size(547, 212)
        Me.Carritodecompras.TabIndex = 0
        '
        'nombre_plato
        '
        Me.nombre_plato.HeaderText = "Nombre del Plato"
        Me.nombre_plato.Name = "nombre_plato"
        Me.nombre_plato.ReadOnly = True
        '
        'PrecioPlato
        '
        Me.PrecioPlato.HeaderText = "Precio"
        Me.PrecioPlato.Name = "PrecioPlato"
        Me.PrecioPlato.ReadOnly = True
        '
        'DescripcionPlato
        '
        Me.DescripcionPlato.HeaderText = "Descripcion del plato"
        Me.DescripcionPlato.Name = "DescripcionPlato"
        Me.DescripcionPlato.ReadOnly = True
        '
        'ImagenPlato
        '
        Me.ImagenPlato.HeaderText = "Imagen del plato"
        Me.ImagenPlato.Name = "ImagenPlato"
        '
        'btneliminardelista
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.NullValue = "eliminar"
        Me.btneliminardelista.DefaultCellStyle = DataGridViewCellStyle3
        Me.btneliminardelista.HeaderText = "Eliminar"
        Me.btneliminardelista.Name = "btneliminardelista"
        Me.btneliminardelista.Text = "Eliminar"
        '
        'BtnPagar
        '
        Me.BtnPagar.Location = New System.Drawing.Point(322, 352)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(139, 49)
        Me.BtnPagar.TabIndex = 1
        Me.BtnPagar.Text = "Pagar"
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total a Pagar"
        '
        'label_total_a_pagar
        '
        Me.label_total_a_pagar.AutoSize = True
        Me.label_total_a_pagar.Location = New System.Drawing.Point(458, 310)
        Me.label_total_a_pagar.Name = "label_total_a_pagar"
        Me.label_total_a_pagar.Size = New System.Drawing.Size(31, 13)
        Me.label_total_a_pagar.TabIndex = 3
        Me.label_total_a_pagar.Text = "Total"
        '
        'FormCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.label_total_a_pagar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPagar)
        Me.Controls.Add(Me.Carritodecompras)
        Me.Name = "FormCarrito"
        Me.Text = "FormCarrito"
        CType(Me.Carritodecompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Carritodecompras As DataGridView
    Friend WithEvents nombre_plato As DataGridViewTextBoxColumn
    Friend WithEvents PrecioPlato As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPlato As DataGridViewTextBoxColumn
    Friend WithEvents ImagenPlato As DataGridViewImageColumn
    Friend WithEvents btneliminardelista As DataGridViewButtonColumn
    Friend WithEvents BtnPagar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents label_total_a_pagar As Label
End Class
