<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ImagenPlato = New System.Windows.Forms.PictureBox()
        Me.BtnPlatoAnterior = New System.Windows.Forms.Button()
        Me.BtnSiguientePlato = New System.Windows.Forms.Button()
        Me.BtnPrecioPlato = New System.Windows.Forms.Button()
        Me.LblIdPlato = New System.Windows.Forms.Label()
        Me.LblNombrePlato = New System.Windows.Forms.Label()
        Me.CafeteriaComboBox = New System.Windows.Forms.ComboBox()
        Me.lblCft = New System.Windows.Forms.Label()
        CType(Me.ImagenPlato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenPlato
        '
        Me.ImagenPlato.Location = New System.Drawing.Point(297, 77)
        Me.ImagenPlato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImagenPlato.Name = "ImagenPlato"
        Me.ImagenPlato.Size = New System.Drawing.Size(715, 348)
        Me.ImagenPlato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenPlato.TabIndex = 0
        Me.ImagenPlato.TabStop = False
        '
        'BtnPlatoAnterior
        '
        Me.BtnPlatoAnterior.Location = New System.Drawing.Point(102, 346)
        Me.BtnPlatoAnterior.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPlatoAnterior.Name = "BtnPlatoAnterior"
        Me.BtnPlatoAnterior.Size = New System.Drawing.Size(172, 77)
        Me.BtnPlatoAnterior.TabIndex = 1
        Me.BtnPlatoAnterior.Text = "Anterior"
        Me.BtnPlatoAnterior.UseVisualStyleBackColor = True
        '
        'BtnSiguientePlato
        '
        Me.BtnSiguientePlato.Location = New System.Drawing.Point(1028, 346)
        Me.BtnSiguientePlato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSiguientePlato.Name = "BtnSiguientePlato"
        Me.BtnSiguientePlato.Size = New System.Drawing.Size(172, 77)
        Me.BtnSiguientePlato.TabIndex = 2
        Me.BtnSiguientePlato.Text = "Siguiente"
        Me.BtnSiguientePlato.UseVisualStyleBackColor = True
        '
        'BtnPrecioPlato
        '
        Me.BtnPrecioPlato.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BtnPrecioPlato.Location = New System.Drawing.Point(503, 544)
        Me.BtnPrecioPlato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPrecioPlato.Name = "BtnPrecioPlato"
        Me.BtnPrecioPlato.Size = New System.Drawing.Size(302, 60)
        Me.BtnPrecioPlato.TabIndex = 3
        Me.BtnPrecioPlato.Text = "PrecioPlato"
        Me.BtnPrecioPlato.UseVisualStyleBackColor = True
        '
        'LblIdPlato
        '
        Me.LblIdPlato.AutoSize = True
        Me.LblIdPlato.Location = New System.Drawing.Point(609, 449)
        Me.LblIdPlato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIdPlato.Name = "LblIdPlato"
        Me.LblIdPlato.Size = New System.Drawing.Size(90, 20)
        Me.LblIdPlato.TabIndex = 4
        Me.LblIdPlato.Text = "ID PLATO?"
        Me.LblIdPlato.Visible = False
        '
        'LblNombrePlato
        '
        Me.LblNombrePlato.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblNombrePlato.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LblNombrePlato.Location = New System.Drawing.Point(-1, 486)
        Me.LblNombrePlato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombrePlato.Name = "LblNombrePlato"
        Me.LblNombrePlato.Size = New System.Drawing.Size(1310, 45)
        Me.LblNombrePlato.TabIndex = 5
        Me.LblNombrePlato.Text = "Titulo"
        Me.LblNombrePlato.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CafeteriaComboBox
        '
        Me.CafeteriaComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CafeteriaComboBox.FormattingEnabled = True
        Me.CafeteriaComboBox.Location = New System.Drawing.Point(297, 19)
        Me.CafeteriaComboBox.Name = "CafeteriaComboBox"
        Me.CafeteriaComboBox.Size = New System.Drawing.Size(358, 37)
        Me.CafeteriaComboBox.TabIndex = 7
        '
        'lblCft
        '
        Me.lblCft.AutoSize = True
        Me.lblCft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblCft.Location = New System.Drawing.Point(38, 25)
        Me.lblCft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCft.Name = "lblCft"
        Me.lblCft.Size = New System.Drawing.Size(251, 25)
        Me.lblCft.TabIndex = 8
        Me.lblCft.Text = "Selecciona tu cafeteria aquí"
        Me.lblCft.Visible = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1312, 734)
        Me.Controls.Add(Me.lblCft)
        Me.Controls.Add(Me.CafeteriaComboBox)
        Me.Controls.Add(Me.LblNombrePlato)
        Me.Controls.Add(Me.LblIdPlato)
        Me.Controls.Add(Me.BtnPrecioPlato)
        Me.Controls.Add(Me.BtnSiguientePlato)
        Me.Controls.Add(Me.BtnPlatoAnterior)
        Me.Controls.Add(Me.ImagenPlato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ImagenPlato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagenPlato As PictureBox
    Friend WithEvents BtnPlatoAnterior As Button
    Friend WithEvents BtnSiguientePlato As Button
    Friend WithEvents BtnPrecioPlato As Button
    Friend WithEvents LblIdPlato As Label
    Friend WithEvents LblNombrePlato As Label
    Friend WithEvents CafeteriaComboBox As ComboBox
    Friend WithEvents lblCft As Label
End Class
