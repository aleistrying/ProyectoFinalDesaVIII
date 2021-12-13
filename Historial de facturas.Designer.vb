<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_de_facturas
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
        Me.HistorialDeFacturasDG = New System.Windows.Forms.DataGridView()
        Me.Id_factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ver = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.HistorialDeFacturasDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HistorialDeFacturasDG
        '
        Me.HistorialDeFacturasDG.AllowUserToAddRows = False
        Me.HistorialDeFacturasDG.AllowUserToDeleteRows = False
        Me.HistorialDeFacturasDG.AllowUserToOrderColumns = True
        Me.HistorialDeFacturasDG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.HistorialDeFacturasDG.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HistorialDeFacturasDG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HistorialDeFacturasDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HistorialDeFacturasDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_factura, Me.Costo, Me.Fecha, Me.Ver})
        Me.HistorialDeFacturasDG.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HistorialDeFacturasDG.Location = New System.Drawing.Point(321, 206)
        Me.HistorialDeFacturasDG.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.HistorialDeFacturasDG.Name = "HistorialDeFacturasDG"
        Me.HistorialDeFacturasDG.ReadOnly = True
        Me.HistorialDeFacturasDG.RowHeadersWidth = 62
        Me.HistorialDeFacturasDG.ShowEditingIcon = False
        Me.HistorialDeFacturasDG.Size = New System.Drawing.Size(778, 257)
        Me.HistorialDeFacturasDG.TabIndex = 0
        '
        'Id_factura
        '
        Me.Id_factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Id_factura.HeaderText = "ID"
        Me.Id_factura.MinimumWidth = 8
        Me.Id_factura.Name = "Id_factura"
        Me.Id_factura.ReadOnly = True
        Me.Id_factura.Width = 62
        '
        'Costo
        '
        Me.Costo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Costo.HeaderText = "Costo"
        Me.Costo.MinimumWidth = 8
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = True
        Me.Costo.Width = 87
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 8
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 90
        '
        'Ver
        '
        Me.Ver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = "Ver"
        Me.Ver.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ver.HeaderText = "Ver Factura"
        Me.Ver.MinimumWidth = 8
        Me.Ver.Name = "Ver"
        Me.Ver.ReadOnly = True
        Me.Ver.Text = "Ver Factura"
        Me.Ver.UseColumnTextForButtonValue = True
        Me.Ver.Width = 99
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1350, 154)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(552, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Historial de Facturas"
        '
        'Historial_de_facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 692)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HistorialDeFacturasDG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Historial_de_facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial_de_facturas"
        CType(Me.HistorialDeFacturasDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HistorialDeFacturasDG As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Id_factura As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Ver As DataGridViewButtonColumn
End Class
