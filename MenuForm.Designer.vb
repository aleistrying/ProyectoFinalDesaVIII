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
        Me.BtnDetallePlato = New System.Windows.Forms.Button()
        Me.LblIdPlato = New System.Windows.Forms.Label()
        Me.LblNombrePlato = New System.Windows.Forms.Label()
        Me.Btn_ir_al_carrito = New System.Windows.Forms.Button()
        CType(Me.ImagenPlato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImagenPlato
        '
        Me.imagenPlato.Location = New System.Drawing.Point(206, 104)
        Me.imagenPlato.Name = "imagenPlato"
        Me.imagenPlato.Size = New System.Drawing.Size(189, 142)
        Me.imagenPlato.TabIndex = 0
        Me.imagenPlato.TabStop = False
        '
        'BtnPlatoAnterior
        '
        Me.Btn_platoAnterior.Location = New System.Drawing.Point(50, 143)
        Me.Btn_platoAnterior.Name = "Btn_platoAnterior"
        Me.Btn_platoAnterior.Size = New System.Drawing.Size(115, 50)
        Me.Btn_platoAnterior.TabIndex = 1
        Me.Btn_platoAnterior.Location = New System.Drawing.Point(50, 143)
        Me.Btn_platoAnterior.Name = "Btn_platoAnterior"
        Me.Btn_platoAnterior.Size = New System.Drawing.Size(115, 50)
        Me.Btn_platoAnterior.TabIndex = 1
        Me.Btn_platoAnterior.Text = "Anterior"
        Me.Btn_platoAnterior.UseVisualStyleBackColor = True
        Me.Btn_siguienteplato.Name = "Btn_siguienteplato"
        Me.Btn_siguienteplato.Size = New System.Drawing.Size(115, 50)
        Me.Btn_siguienteplato.TabIndex = 2
        Me.Btn_siguienteplato.Location = New System.Drawing.Point(435, 143)
        Me.Btn_siguienteplato.Name = "Btn_siguienteplato"
        Me.Btn_siguienteplato.Size = New System.Drawing.Size(115, 50)
        Me.Btn_siguienteplato.TabIndex = 2
        Me.Btn_siguienteplato.Text = "Siguiente"
        Me.Btn_siguienteplato.UseVisualStyleBackColor = True
        Me.BotonPrecio_Plato.Name = "BotonPrecio_Plato"
        Me.BotonPrecio_Plato.Size = New System.Drawing.Size(189, 30)
        Me.BotonPrecio_Plato.TabIndex = 3
        Me.BotonPrecio_Plato.Location = New System.Drawing.Point(206, 297)
        Me.BotonPrecio_Plato.Name = "BotonPrecio_Plato"
        Me.BotonPrecio_Plato.Size = New System.Drawing.Size(189, 30)
        Me.BotonPrecio_Plato.TabIndex = 3
        Me.BotonPrecio_Plato.Text = "Button3"
        Me.BotonPrecio_Plato.UseVisualStyleBackColor = True
        Me.labelnumPlato.Location = New System.Drawing.Point(278, 249)
        Me.labelnumPlato.Name = "labelnumPlato"
        Me.labelnumPlato.Size = New System.Drawing.Size(39, 13)
        Me.labelnumPlato.AutoSize = True
        Me.labelnumPlato.Location = New System.Drawing.Point(278, 249)
        Me.labelnumPlato.Name = "labelnumPlato"
        Me.labelnumPlato.Size = New System.Drawing.Size(39, 13)
        Me.labelnumPlato.TabIndex = 4
        Me.labelnumPlato.Text = "Label1"
        Me.labelNombrePlato.Location = New System.Drawing.Point(278, 281)
        Me.labelNombrePlato.Name = "labelNombrePlato"
        Me.labelNombrePlato.Size = New System.Drawing.Size(39, 13)
        Me.labelNombrePlato.AutoSize = True
        Me.labelNombrePlato.Location = New System.Drawing.Point(278, 281)
        Me.labelNombrePlato.Name = "labelNombrePlato"
        Me.labelNombrePlato.Size = New System.Drawing.Size(39, 13)
        Me.labelNombrePlato.TabIndex = 5
        Me.labelNombrePlato.Text = "Label1"
        Me.Btn_ir_al_carrito.Name = "Btn_ir_al_carrito"
        Me.Btn_ir_al_carrito.Size = New System.Drawing.Size(284, 103)
        Me.Btn_ir_al_carrito.TabIndex = 6
        Me.Btn_ir_al_carrito.Location = New System.Drawing.Point(206, 351)
        Me.Btn_ir_al_carrito.UseVisualStyleBackColor = True
        Me.Btn_ir_al_carrito.UseWaitCursor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 462)
        Me.Controls.Add(Me.Btn_ir_al_carrito)
        Me.Controls.Add(Me.labelNombrePlato)
        Me.Controls.Add(Me.labelnumPlato)
        Me.ClientSize = New System.Drawing.Size(595, 462)
        Me.Controls.Add(Me.Btn_siguienteplato)
        Me.Controls.Add(Me.labelNombrePlato)
        Me.Controls.Add(Me.labelnumPlato)
        Me.Controls.Add(Me.BotonPrecio_Plato)
        Me.Controls.Add(Me.Btn_siguienteplato)
        Me.Controls.Add(Me.Btn_platoAnterior)
        Me.Controls.Add(Me.imagenPlato)
        Me.Name = "Inicio_de_sesion_usuario"
        Me.Text = "Inicio_de_sesion_usuario"
        CType(Me.imagenPlato, System.ComponentModel.ISupportInitialize).EndInit()

        Friend WithEvents ImagenPlato As PictureBox
    Friend WithEvents BtnPlatoAnterior As Button
    Friend WithEvents BtnSiguientePlato As Button
    Friend WithEvents BtnDetallePlato As Button
    Friend WithEvents LblIdPlato As Label
    Friend WithEvents LblNombrePlato As Label
    Friend WithEvents Btn_ir_al_carrito As Button
End Class
