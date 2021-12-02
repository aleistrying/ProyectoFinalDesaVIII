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
        Me.imagenPlato = New System.Windows.Forms.PictureBox()
        Me.Btn_platoAnterior = New System.Windows.Forms.Button()
        Me.Btn_siguienteplato = New System.Windows.Forms.Button()
        Me.BotonPrecio_Plato = New System.Windows.Forms.Button()
        Me.labelnumPlato = New System.Windows.Forms.Label()
        Me.labelNombrePlato = New System.Windows.Forms.Label()
        Me.Btn_ir_al_carrito = New System.Windows.Forms.Button()
        CType(Me.imagenPlato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imagenPlato
        '
        Me.imagenPlato.Location = New System.Drawing.Point(309, 160)
        Me.imagenPlato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.imagenPlato.Name = "imagenPlato"
        Me.imagenPlato.Size = New System.Drawing.Size(284, 218)
        Me.imagenPlato.TabIndex = 0
        Me.imagenPlato.TabStop = False
        '
        'Btn_platoAnterior
        '
        Me.Btn_platoAnterior.Location = New System.Drawing.Point(75, 220)
        Me.Btn_platoAnterior.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_platoAnterior.Name = "Btn_platoAnterior"
        Me.Btn_platoAnterior.Size = New System.Drawing.Size(172, 77)
        Me.Btn_platoAnterior.TabIndex = 1
        Me.Btn_platoAnterior.Text = "Anterior"
        Me.Btn_platoAnterior.UseVisualStyleBackColor = True
        '
        'Btn_siguienteplato
        '
        Me.Btn_siguienteplato.Location = New System.Drawing.Point(652, 220)
        Me.Btn_siguienteplato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_siguienteplato.Name = "Btn_siguienteplato"
        Me.Btn_siguienteplato.Size = New System.Drawing.Size(172, 77)
        Me.Btn_siguienteplato.TabIndex = 2
        Me.Btn_siguienteplato.Text = "Siguiente"
        Me.Btn_siguienteplato.UseVisualStyleBackColor = True
        '
        'BotonPrecio_Plato
        '
        Me.BotonPrecio_Plato.Location = New System.Drawing.Point(309, 457)
        Me.BotonPrecio_Plato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BotonPrecio_Plato.Name = "BotonPrecio_Plato"
        Me.BotonPrecio_Plato.Size = New System.Drawing.Size(284, 46)
        Me.BotonPrecio_Plato.TabIndex = 3
        Me.BotonPrecio_Plato.Text = "Button3"
        Me.BotonPrecio_Plato.UseVisualStyleBackColor = True
        '
        'labelnumPlato
        '
        Me.labelnumPlato.AutoSize = True
        Me.labelnumPlato.Location = New System.Drawing.Point(417, 383)
        Me.labelnumPlato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelnumPlato.Name = "labelnumPlato"
        Me.labelnumPlato.Size = New System.Drawing.Size(57, 20)
        Me.labelnumPlato.TabIndex = 4
        Me.labelnumPlato.Text = "Label1"
        '
        'labelNombrePlato
        '
        Me.labelNombrePlato.AutoSize = True
        Me.labelNombrePlato.Location = New System.Drawing.Point(417, 432)
        Me.labelNombrePlato.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelNombrePlato.Name = "labelNombrePlato"
        Me.labelNombrePlato.Size = New System.Drawing.Size(57, 20)
        Me.labelNombrePlato.TabIndex = 5
        Me.labelNombrePlato.Text = "Label1"
        '
        'Btn_ir_al_carrito
        '
        Me.Btn_ir_al_carrito.Location = New System.Drawing.Point(309, 540)
        Me.Btn_ir_al_carrito.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_ir_al_carrito.Name = "Btn_ir_al_carrito"
        Me.Btn_ir_al_carrito.Size = New System.Drawing.Size(284, 103)
        Me.Btn_ir_al_carrito.TabIndex = 6
        Me.Btn_ir_al_carrito.Text = "Ir al carrito"
        Me.Btn_ir_al_carrito.UseVisualStyleBackColor = True
        '
        'Inicio_de_sesion_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 711)
        Me.Controls.Add(Me.Btn_ir_al_carrito)
        Me.Controls.Add(Me.labelNombrePlato)
        Me.Controls.Add(Me.labelnumPlato)
        Me.Controls.Add(Me.BotonPrecio_Plato)
        Me.Controls.Add(Me.Btn_siguienteplato)
        Me.Controls.Add(Me.Btn_platoAnterior)
        Me.Controls.Add(Me.imagenPlato)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Inicio_de_sesion_usuario"
        Me.Text = "Inicio_de_sesion_usuario"
        CType(Me.imagenPlato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imagenPlato As PictureBox
    Friend WithEvents Btn_platoAnterior As Button
    Friend WithEvents Btn_siguienteplato As Button
    Friend WithEvents BotonPrecio_Plato As Button
    Friend WithEvents labelnumPlato As Label
    Friend WithEvents labelNombrePlato As Label
    Friend WithEvents Btn_ir_al_carrito As Button
End Class
