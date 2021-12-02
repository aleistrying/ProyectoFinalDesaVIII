<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class escoger_cafeteria
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ChkRecordarSeleccion = New System.Windows.Forms.CheckBox()
        Me.BtnAcceptarCafeteria = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DGVCafeterias = New System.Windows.Forms.DataGridView()
        Me.PcafeteriaDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.P_cafeteriaDataSet1 = New prototipo.p_cafeteriaDataSet1()
        Me.cafeteriaCheckbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.textCafeterias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVCafeterias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PcafeteriaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_cafeteriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkRecordarSeleccion
        '
        Me.ChkRecordarSeleccion.AutoSize = True
        Me.ChkRecordarSeleccion.Location = New System.Drawing.Point(282, 363)
        Me.ChkRecordarSeleccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkRecordarSeleccion.Name = "ChkRecordarSeleccion"
        Me.ChkRecordarSeleccion.Size = New System.Drawing.Size(183, 24)
        Me.ChkRecordarSeleccion.TabIndex = 5
        Me.ChkRecordarSeleccion.TabStop = False
        Me.ChkRecordarSeleccion.Text = "Recordar mi eleccion"
        Me.ChkRecordarSeleccion.UseVisualStyleBackColor = True
        '
        'BtnAcceptarCafeteria
        '
        Me.BtnAcceptarCafeteria.Location = New System.Drawing.Point(279, 425)
        Me.BtnAcceptarCafeteria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAcceptarCafeteria.Name = "BtnAcceptarCafeteria"
        Me.BtnAcceptarCafeteria.Size = New System.Drawing.Size(189, 94)
        Me.BtnAcceptarCafeteria.TabIndex = 6
        Me.BtnAcceptarCafeteria.TabStop = False
        Me.BtnAcceptarCafeteria.Text = "Aceptar"
        Me.BtnAcceptarCafeteria.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Selecciona la cafeteria a utilizar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(279, 545)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(189, 94)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.TabStop = False
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DGVCafeterias
        '
        Me.DGVCafeterias.AllowUserToAddRows = False
        Me.DGVCafeterias.AllowUserToDeleteRows = False
        Me.DGVCafeterias.AllowUserToResizeColumns = False
        Me.DGVCafeterias.AllowUserToResizeRows = False
        Me.DGVCafeterias.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGVCafeterias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVCafeterias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DGVCafeterias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVCafeterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCafeterias.ColumnHeadersVisible = False
        Me.DGVCafeterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cafeteriaCheckbox, Me.textCafeterias, Me.id})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCafeterias.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCafeterias.GridColor = System.Drawing.SystemColors.Control
        Me.DGVCafeterias.Location = New System.Drawing.Point(230, 129)
        Me.DGVCafeterias.MultiSelect = False
        Me.DGVCafeterias.Name = "DGVCafeterias"
        Me.DGVCafeterias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCafeterias.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVCafeterias.RowHeadersVisible = False
        Me.DGVCafeterias.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVCafeterias.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVCafeterias.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVCafeterias.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVCafeterias.ShowEditingIcon = False
        Me.DGVCafeterias.Size = New System.Drawing.Size(286, 199)
        Me.DGVCafeterias.TabIndex = 11
        '
        'PcafeteriaDataSet1BindingSource
        '
        Me.PcafeteriaDataSet1BindingSource.DataSource = Me.P_cafeteriaDataSet1
        Me.PcafeteriaDataSet1BindingSource.Position = 0
        '
        'P_cafeteriaDataSet1
        '
        Me.P_cafeteriaDataSet1.DataSetName = "p_cafeteriaDataSet1"
        Me.P_cafeteriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cafeteriaCheckbox
        '
        Me.cafeteriaCheckbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cafeteriaCheckbox.HeaderText = ""
        Me.cafeteriaCheckbox.MinimumWidth = 8
        Me.cafeteriaCheckbox.Name = "cafeteriaCheckbox"
        Me.cafeteriaCheckbox.Width = 8
        '
        'textCafeterias
        '
        Me.textCafeterias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.textCafeterias.HeaderText = "Cafeterias"
        Me.textCafeterias.MinimumWidth = 8
        Me.textCafeterias.Name = "textCafeterias"
        Me.textCafeterias.ReadOnly = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 150
        '
        'escoger_cafeteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 763)
        Me.Controls.Add(Me.DGVCafeterias)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnAcceptarCafeteria)
        Me.Controls.Add(Me.ChkRecordarSeleccion)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "escoger_cafeteria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "escoger_cafeteria"
        CType(Me.DGVCafeterias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PcafeteriaDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_cafeteriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkRecordarSeleccion As CheckBox
    Friend WithEvents BtnAcceptarCafeteria As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DGVCafeterias As DataGridView
    Friend WithEvents P_cafeteriaDataSet1 As p_cafeteriaDataSet1
    Friend WithEvents PcafeteriaDataSet1BindingSource As BindingSource
    Friend WithEvents cafeteriaCheckbox As DataGridViewCheckBoxColumn
    Friend WithEvents textCafeterias As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
End Class
