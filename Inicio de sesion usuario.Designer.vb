<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_de_sesion_usuario
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
        Me.ImagenPlato = New System.Windows.Forms.PictureBox()
        Me.BtnPlatoAnterior = New System.Windows.Forms.Button()
        Me.BtnSiguientePlato = New System.Windows.Forms.Button()
        Me.BtnDetallePlato = New System.Windows.Forms.Button()
        Me.LblIdPlato = New System.Windows.Forms.Label()
        Me.LblNombrePlato = New System.Windows.Forms.Label()
        Me.Btn_ir_al_carrito = New System.Windows.Forms.Button()
        CType(Me.ImagenPlato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenPlato
        '
        Me.ImagenPlato.Location = New System.Drawing.Point(309, 160)
        Me.ImagenPlato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImagenPlato.Name = "ImagenPlato"
        Me.ImagenPlato.Size = New System.Drawing.Size(284, 218)
        Me.ImagenPlato.TabIndex = 0
        Me.ImagenPlato.TabStop = False
        '
        'BtnPlatoAnterior
        '
        Me.BtnPlatoAnterior.Location = New System.Drawing.Point(75, 220)
        Me.BtnPlatoAnterior.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnPlatoAnterior.Name = "BtnPlatoAnterior"
        Me.BtnPlatoAnterior.Size = New System.Drawing.Size(172, 77)
        Me.BtnPlatoAnterior.TabIndex = 1
        Me.BtnPlatoAnterior.Text = "Anterior"
        Me.BtnPlatoAnterior.UseVisualStyleBackColor = True
        '
        'BtnSiguientePlato
        '
        Me.BtnSiguientePlato.Location = New System.Drawing.Point(652, 220)
        Me.BtnSiguientePlato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSiguientePlato.Name = "BtnSiguientePlato"
        Me.BtnSiguientePlato.Size = New System.Drawing.Size(172, 77)
        Me.BtnSiguientePlato.TabIndex = 2
        Me.BtnSiguientePlato.Text = "Siguiente"
        Me.BtnSiguientePlato.UseVisualStyleBackColor = True
        '
        'BtnDetallePlato
        '
        Me.BtnDetallePlato.Location = New System.Drawing.Point(309, 457)
        Me.BtnDetallePlato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDetallePlato.Name = "BtnDetallePlato"
        Me.BtnDetallePlato.Size = New System.Drawing.Size(284, 46)
        Me.BtnDetallePlato.TabIndex = 3
        Me.BtnDetallePlato.Text = "LblBtnPrecioPlato"
        Me.BtnDetallePlato.UseVisualStyleBackColor = True
        '
        'LblIdPlato
        '
        Me.LblIdPlato.AutoSize = True
        Me.LblIdPlato.Location = New System.Drawing.Point(353, 383)
        Me.LblIdPlato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblIdPlato.Name = "LblIdPlato"
        Me.LblIdPlato.Size = New System.Drawing.Size(187, 20)
        Me.LblIdPlato.TabIndex = 4
        Me.LblIdPlato.Text = "ID? no se si agregar esto"
        Me.LblIdPlato.Visible = False
        '
        'LblNombrePlato
        '
        Me.LblNombrePlato.AutoSize = True
        Me.LblNombrePlato.Location = New System.Drawing.Point(417, 432)
        Me.LblNombrePlato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombrePlato.Name = "LblNombrePlato"
        Me.LblNombrePlato.Size = New System.Drawing.Size(57, 20)
        Me.LblNombrePlato.TabIndex = 5
        Me.LblNombrePlato.Text = "Label1"
        '
        'Btn_ir_al_carrito
        '
        Me.Btn_ir_al_carrito.Location = New System.Drawing.Point(309, 540)
        Me.Btn_ir_al_carrito.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_ir_al_carrito.Name = "Btn_ir_al_carrito"
        Me.Btn_ir_al_carrito.Size = New System.Drawing.Size(284, 103)
        Me.Btn_ir_al_carrito.TabIndex = 6
        Me.Btn_ir_al_carrito.Text = "Ir al carrito #"
        Me.Btn_ir_al_carrito.UseVisualStyleBackColor = True
        '
        'Inicio_de_sesion_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 711)
        Me.Controls.Add(Me.Btn_ir_al_carrito)
        Me.Controls.Add(Me.LblNombrePlato)
        Me.Controls.Add(Me.LblIdPlato)
        Me.Controls.Add(Me.BtnDetallePlato)
        Me.Controls.Add(Me.BtnSiguientePlato)
        Me.Controls.Add(Me.BtnPlatoAnterior)
        Me.Controls.Add(Me.ImagenPlato)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Inicio_de_sesion_usuario"
        Me.Text = "Inicio_de_sesion_usuario"
        CType(Me.ImagenPlato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImagenPlato As PictureBox
    Friend WithEvents BtnPlatoAnterior As Button
    Friend WithEvents BtnSiguientePlato As Button
    Friend WithEvents BtnDetallePlato As Button
    Friend WithEvents LblIdPlato As Label
    Friend WithEvents LblNombrePlato As Label
    Friend WithEvents Btn_ir_al_carrito As Button
End Class
