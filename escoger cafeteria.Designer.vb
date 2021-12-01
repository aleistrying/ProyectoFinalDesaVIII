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
        Me.checkboxrecordareleccion = New System.Windows.Forms.CheckBox()
        Me.btnenviarAinicioUsuario = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'checkboxrecordareleccion
        '
        Me.checkboxrecordareleccion.AutoSize = True
        Me.checkboxrecordareleccion.Location = New System.Drawing.Point(186, 236)
        Me.checkboxrecordareleccion.Name = "checkboxrecordareleccion"
        Me.checkboxrecordareleccion.Size = New System.Drawing.Size(126, 17)
        Me.checkboxrecordareleccion.TabIndex = 1
        Me.checkboxrecordareleccion.Text = "Recordar mi eleccion"
        Me.checkboxrecordareleccion.UseVisualStyleBackColor = True
        '
        'btnenviarAinicioUsuario
        '
        Me.btnenviarAinicioUsuario.Location = New System.Drawing.Point(186, 276)
        Me.btnenviarAinicioUsuario.Name = "btnenviarAinicioUsuario"
        Me.btnenviarAinicioUsuario.Size = New System.Drawing.Size(126, 61)
        Me.btnenviarAinicioUsuario.TabIndex = 4
        Me.btnenviarAinicioUsuario.Text = "Aceptar"
        Me.btnenviarAinicioUsuario.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(186, 91)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cafeteria A (350)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(186, 114)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cafeteria B (250)"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(186, 137)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(104, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Cafeteria C (100)"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(186, 160)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(105, 17)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Cafeteria D (100)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'escoger_cafeteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 496)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.btnenviarAinicioUsuario)
        Me.Controls.Add(Me.checkboxrecordareleccion)
        Me.Name = "escoger_cafeteria"
        Me.Text = "escoger_cafeteria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checkboxrecordareleccion As CheckBox
    Friend WithEvents btnenviarAinicioUsuario As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
End Class
