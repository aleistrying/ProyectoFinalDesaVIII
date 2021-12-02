<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaPrincipal
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
        Me.btnCerrarsesion = New System.Windows.Forms.Button()
        Me.BtneditaUsuarios = New System.Windows.Forms.Button()
        Me.BtnEditarplatos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Navegacion = New System.Windows.Forms.Panel()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Saldo = New System.Windows.Forms.Label()
        Me.labelnombreUsuario = New System.Windows.Forms.Label()
        Me.imgUsuario = New System.Windows.Forms.PictureBox()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.Navegacion.SuspendLayout()
        CType(Me.imgUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFormularios.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrarsesion
        '
        Me.btnCerrarsesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarsesion.BackColor = System.Drawing.Color.Red
        Me.btnCerrarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarsesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCerrarsesion.Location = New System.Drawing.Point(765, 0)
        Me.btnCerrarsesion.Name = "btnCerrarsesion"
        Me.btnCerrarsesion.Size = New System.Drawing.Size(107, 59)
        Me.btnCerrarsesion.TabIndex = 24
        Me.btnCerrarsesion.Text = "Cerrar Sesion"
        Me.btnCerrarsesion.UseVisualStyleBackColor = False
        '
        'BtneditaUsuarios
        '
        Me.BtneditaUsuarios.BackColor = System.Drawing.Color.White
        Me.BtneditaUsuarios.FlatAppearance.BorderSize = 0
        Me.BtneditaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtneditaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtneditaUsuarios.Location = New System.Drawing.Point(526, 1)
        Me.BtneditaUsuarios.Name = "BtneditaUsuarios"
        Me.BtneditaUsuarios.Size = New System.Drawing.Size(85, 56)
        Me.BtneditaUsuarios.TabIndex = 12
        Me.BtneditaUsuarios.Text = "Editar usuarios"
        Me.BtneditaUsuarios.UseVisualStyleBackColor = False
        '
        'BtnEditarplatos
        '
        Me.BtnEditarplatos.BackColor = System.Drawing.Color.White
        Me.BtnEditarplatos.FlatAppearance.BorderSize = 0
        Me.BtnEditarplatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarplatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditarplatos.Location = New System.Drawing.Point(446, 1)
        Me.BtnEditarplatos.Name = "BtnEditarplatos"
        Me.BtnEditarplatos.Size = New System.Drawing.Size(74, 56)
        Me.BtnEditarplatos.TabIndex = 11
        Me.BtnEditarplatos.Text = "Editar platos"
        Me.BtnEditarplatos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(334, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Bienvenidos"
        '
        'Navegacion
        '
        Me.Navegacion.Controls.Add(Me.btnAdmin)
        Me.Navegacion.Controls.Add(Me.btnCerrarsesion)
        Me.Navegacion.Controls.Add(Me.BtneditaUsuarios)
        Me.Navegacion.Controls.Add(Me.Button2)
        Me.Navegacion.Controls.Add(Me.btnHistorial)
        Me.Navegacion.Controls.Add(Me.BtnEditarplatos)
        Me.Navegacion.Controls.Add(Me.btnPerfil)
        Me.Navegacion.Controls.Add(Me.Button1)
        Me.Navegacion.Controls.Add(Me.Saldo)
        Me.Navegacion.Controls.Add(Me.labelnombreUsuario)
        Me.Navegacion.Controls.Add(Me.imgUsuario)
        Me.Navegacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Navegacion.Location = New System.Drawing.Point(0, 0)
        Me.Navegacion.Name = "Navegacion"
        Me.Navegacion.Size = New System.Drawing.Size(875, 60)
        Me.Navegacion.TabIndex = 24
        '
        'btnAdmin
        '
        Me.btnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdmin.BackColor = System.Drawing.Color.White
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdmin.Location = New System.Drawing.Point(674, 1)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(85, 56)
        Me.btnAdmin.TabIndex = 32
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(349, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 56)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Añadir Fondos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.FlatAppearance.BorderSize = 0
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Location = New System.Drawing.Point(287, 1)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(56, 56)
        Me.btnHistorial.TabIndex = 30
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnPerfil
        '
        Me.btnPerfil.FlatAppearance.BorderSize = 0
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Location = New System.Drawing.Point(207, 1)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(74, 56)
        Me.btnPerfil.TabIndex = 29
        Me.btnPerfil.Text = "Mi perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(152, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 56)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Saldo
        '
        Me.Saldo.AutoSize = True
        Me.Saldo.Location = New System.Drawing.Point(66, 32)
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Size = New System.Drawing.Size(34, 13)
        Me.Saldo.TabIndex = 28
        Me.Saldo.Text = "Saldo"
        '
        'labelnombreUsuario
        '
        Me.labelnombreUsuario.AutoSize = True
        Me.labelnombreUsuario.Location = New System.Drawing.Point(66, 9)
        Me.labelnombreUsuario.Name = "labelnombreUsuario"
        Me.labelnombreUsuario.Size = New System.Drawing.Size(80, 13)
        Me.labelnombreUsuario.TabIndex = 27
        Me.labelnombreUsuario.Text = "NombreUsuario"
        '
        'imgUsuario
        '
        Me.imgUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgUsuario.Location = New System.Drawing.Point(0, 0)
        Me.imgUsuario.Name = "imgUsuario"
        Me.imgUsuario.Size = New System.Drawing.Size(60, 58)
        Me.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgUsuario.TabIndex = 26
        Me.imgUsuario.TabStop = False
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Controls.Add(Me.Label1)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(0, 60)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(875, 466)
        Me.PanelFormularios.TabIndex = 25
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(875, 526)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.Navegacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaPrincipal"
        Me.Text = "Form1"
        Me.Navegacion.ResumeLayout(False)
        Me.Navegacion.PerformLayout()
        CType(Me.imgUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtneditaUsuarios As Button
    Friend WithEvents BtnEditarplatos As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrarsesion As Button
    Friend WithEvents Navegacion As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Saldo As Label
    Friend WithEvents labelnombreUsuario As Label
    Friend WithEvents imgUsuario As PictureBox
    Friend WithEvents btnPerfil As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents PanelFormularios As Panel
End Class
