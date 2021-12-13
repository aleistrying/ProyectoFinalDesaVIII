<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFactura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFactura))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.GeneracionFactura = New System.Windows.Forms.DataGridView()
        Me.nombrePlato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioPlato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblCafeteria = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblItem = New System.Windows.Forms.Label()
        CType(Me.GeneracionFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneracionFactura
        '
        Me.GeneracionFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GeneracionFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombrePlato, Me.precioPlato})
        Me.GeneracionFactura.Location = New System.Drawing.Point(1083, 560)
        Me.GeneracionFactura.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GeneracionFactura.Name = "GeneracionFactura"
        Me.GeneracionFactura.RowHeadersWidth = 62
        Me.GeneracionFactura.Size = New System.Drawing.Size(366, 478)
        Me.GeneracionFactura.TabIndex = 0
        Me.GeneracionFactura.Visible = False
        '
        'nombrePlato
        '
        Me.nombrePlato.HeaderText = "nombre del plato"
        Me.nombrePlato.MinimumWidth = 8
        Me.nombrePlato.Name = "nombrePlato"
        Me.nombrePlato.ReadOnly = True
        Me.nombrePlato.Width = 150
        '
        'precioPlato
        '
        Me.precioPlato.HeaderText = "Precio"
        Me.precioPlato.MinimumWidth = 8
        Me.precioPlato.Name = "precioPlato"
        Me.precioPlato.ReadOnly = True
        Me.precioPlato.Width = 150
        '
        'btnRegresar
        '
        Me.btnRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnRegresar.Location = New System.Drawing.Point(500, 542)
        Me.btnRegresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(243, 99)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(367, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(474, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LblCliente
        '
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LblCliente.Location = New System.Drawing.Point(360, 194)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(124, 37)
        Me.LblCliente.TabIndex = 3
        Me.LblCliente.Text = "Cliente:"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LblFecha.Location = New System.Drawing.Point(361, 143)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(92, 29)
        Me.LblFecha.TabIndex = 4
        Me.LblFecha.Text = "Fecha: "
        '
        'LblCafeteria
        '
        Me.LblCafeteria.AutoSize = True
        Me.LblCafeteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblCafeteria.Location = New System.Drawing.Point(360, 253)
        Me.LblCafeteria.Name = "LblCafeteria"
        Me.LblCafeteria.Size = New System.Drawing.Size(99, 32)
        Me.LblCafeteria.TabIndex = 5
        Me.LblCafeteria.Text = "Local: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(454, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 37)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Detalle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(683, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 37)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Monto"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblTotal.Location = New System.Drawing.Point(698, 417)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(79, 32)
        Me.LblTotal.TabIndex = 8
        Me.LblTotal.Text = "Total"
        '
        'LblItem
        '
        Me.LblItem.AutoSize = True
        Me.LblItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblItem.Location = New System.Drawing.Point(482, 417)
        Me.LblItem.Name = "LblItem"
        Me.LblItem.Size = New System.Drawing.Size(69, 32)
        Me.LblItem.TabIndex = 9
        Me.LblItem.Text = "Item"
        '
        'FormFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 680)
        Me.Controls.Add(Me.LblItem)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblCafeteria)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LblCliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.GeneracionFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.GeneracionFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GeneracionFactura As DataGridView
    Friend WithEvents nombrePlato As DataGridViewTextBoxColumn
    Friend WithEvents precioPlato As DataGridViewTextBoxColumn
    Friend WithEvents btnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblCliente As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblCafeteria As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblItem As Label
End Class
