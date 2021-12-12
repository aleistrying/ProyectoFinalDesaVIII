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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CarritodeCompras = New System.Windows.Forms.DataGridView()
        Me.nombre_plato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioPlato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPlato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImagenPlato = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btneliminardelista = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.lblresm = New System.Windows.Forms.Label()
        Me.ImagenCompra = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        CType(Me.CarritodeCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CarritodeCompras
        '
        Me.CarritodeCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarritodeCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre_plato, Me.PrecioPlato, Me.DescripcionPlato, Me.ImagenPlato, Me.btneliminardelista})
        Me.CarritodeCompras.Location = New System.Drawing.Point(1154, 650)
        Me.CarritodeCompras.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CarritodeCompras.Name = "CarritodeCompras"
        Me.CarritodeCompras.RowHeadersWidth = 62
        Me.CarritodeCompras.Size = New System.Drawing.Size(820, 326)
        Me.CarritodeCompras.TabIndex = 0
        Me.CarritodeCompras.Visible = False
        '
        'nombre_plato
        '
        Me.nombre_plato.HeaderText = "Nombre del Plato"
        Me.nombre_plato.MinimumWidth = 8
        Me.nombre_plato.Name = "nombre_plato"
        Me.nombre_plato.ReadOnly = True
        Me.nombre_plato.Width = 150
        '
        'PrecioPlato
        '
        Me.PrecioPlato.HeaderText = "Precio"
        Me.PrecioPlato.MinimumWidth = 8
        Me.PrecioPlato.Name = "PrecioPlato"
        Me.PrecioPlato.ReadOnly = True
        Me.PrecioPlato.Width = 150
        '
        'DescripcionPlato
        '
        Me.DescripcionPlato.HeaderText = "Descripcion del plato"
        Me.DescripcionPlato.MinimumWidth = 8
        Me.DescripcionPlato.Name = "DescripcionPlato"
        Me.DescripcionPlato.ReadOnly = True
        Me.DescripcionPlato.Width = 150
        '
        'ImagenPlato
        '
        Me.ImagenPlato.HeaderText = "Imagen del plato"
        Me.ImagenPlato.MinimumWidth = 8
        Me.ImagenPlato.Name = "ImagenPlato"
        Me.ImagenPlato.Width = 150
        '
        'btneliminardelista
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = "eliminar"
        Me.btneliminardelista.DefaultCellStyle = DataGridViewCellStyle1
        Me.btneliminardelista.HeaderText = "Eliminar"
        Me.btneliminardelista.MinimumWidth = 8
        Me.btneliminardelista.Name = "btneliminardelista"
        Me.btneliminardelista.Text = "Eliminar"
        Me.btneliminardelista.Width = 150
        '
        'BtnPagar
        '
        Me.BtnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnPagar.Location = New System.Drawing.Point(477, 457)
        Me.BtnPagar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(208, 75)
        Me.BtnPagar.TabIndex = 1
        Me.BtnPagar.Text = "Pagar"
        Me.BtnPagar.UseVisualStyleBackColor = True
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LblNombre.Location = New System.Drawing.Point(735, 147)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(150, 37)
        Me.LblNombre.TabIndex = 2
        Me.LblNombre.Text = "Nombre: "
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblPrecio.Location = New System.Drawing.Point(735, 367)
        Me.LblPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(95, 29)
        Me.LblPrecio.TabIndex = 3
        Me.LblPrecio.Text = "Precio: "
        '
        'lblresm
        '
        Me.lblresm.AutoSize = True
        Me.lblresm.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lblresm.Location = New System.Drawing.Point(420, 38)
        Me.lblresm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblresm.Name = "lblresm"
        Me.lblresm.Size = New System.Drawing.Size(359, 40)
        Me.lblresm.TabIndex = 4
        Me.lblresm.Text = "Resumen de Compra"
        '
        'ImagenCompra
        '
        Me.ImagenCompra.Location = New System.Drawing.Point(144, 147)
        Me.ImagenCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImagenCompra.Name = "ImagenCompra"
        Me.ImagenCompra.Size = New System.Drawing.Size(416, 249)
        Me.ImagenCompra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenCompra.TabIndex = 5
        Me.ImagenCompra.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblDescripcion.Location = New System.Drawing.Point(735, 233)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(452, 120)
        Me.LblDescripcion.TabIndex = 6
        Me.LblDescripcion.Text = "Descripción:"
        '
        'BtnVolver
        '
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnVolver.Location = New System.Drawing.Point(477, 571)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(208, 75)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FormCarrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.ImagenCompra)
        Me.Controls.Add(Me.lblresm)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.BtnPagar)
        Me.Controls.Add(Me.CarritodeCompras)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormCarrito"
        Me.Text = "Resumen de Compra"
        CType(Me.CarritodeCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CarritodeCompras As DataGridView
    Friend WithEvents nombre_plato As DataGridViewTextBoxColumn
    Friend WithEvents PrecioPlato As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPlato As DataGridViewTextBoxColumn
    Friend WithEvents ImagenPlato As DataGridViewImageColumn
    Friend WithEvents btneliminardelista As DataGridViewButtonColumn
    Friend WithEvents BtnPagar As Button
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents lblresm As Label
    Friend WithEvents ImagenCompra As PictureBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents BtnVolver As Button
End Class
