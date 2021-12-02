<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generacion_de_Factura
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.GeneracionFactura = New System.Windows.Forms.DataGridView()
        Me.nombrePlato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioPlato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.GeneracionFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneracionFactura
        '
        Me.GeneracionFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GeneracionFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombrePlato, Me.precioPlato})
        Me.GeneracionFactura.Location = New System.Drawing.Point(256, 12)
        Me.GeneracionFactura.Name = "GeneracionFactura"
        Me.GeneracionFactura.Size = New System.Drawing.Size(244, 311)
        Me.GeneracionFactura.TabIndex = 0
        '
        'nombrePlato
        '
        Me.nombrePlato.HeaderText = "nombre del plato"
        Me.nombrePlato.Name = "nombrePlato"
        Me.nombrePlato.ReadOnly = True
        '
        'precioPlato
        '
        Me.precioPlato.HeaderText = "Precio"
        Me.precioPlato.Name = "precioPlato"
        Me.precioPlato.ReadOnly = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(316, 375)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(111, 34)
        Me.btnRegresar.TabIndex = 1
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'Generacion_de_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.GeneracionFactura)
        Me.Name = "Generacion_de_Factura"
        Me.Text = "Generacion_de_Factura"
        CType(Me.GeneracionFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GeneracionFactura As DataGridView
    Friend WithEvents nombrePlato As DataGridViewTextBoxColumn
    Friend WithEvents precioPlato As DataGridViewTextBoxColumn
    Friend WithEvents btnRegresar As Button
End Class
