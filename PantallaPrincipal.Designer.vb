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
        Me.Navegacion = New System.Windows.Forms.Panel()
        Me.BtnAdmin = New System.Windows.Forms.Button()
        Me.BtnAnadirFondos = New System.Windows.Forms.Button()
        Me.btnHistorial = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblSaldo = New System.Windows.Forms.Label()
        Me.LblNombreUsuario = New System.Windows.Forms.Label()
        Me.ImgUsuario = New System.Windows.Forms.PictureBox()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.Navegacion.SuspendLayout()
        CType(Me.ImgUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrarsesion
        '
        Me.btnCerrarsesion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarsesion.BackColor = System.Drawing.Color.Red
        Me.btnCerrarsesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrarsesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarsesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCerrarsesion.Location = New System.Drawing.Point(1152, 0)
        Me.btnCerrarsesion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCerrarsesion.Name = "btnCerrarsesion"
        Me.btnCerrarsesion.Size = New System.Drawing.Size(160, 92)
        Me.btnCerrarsesion.TabIndex = 24
        Me.btnCerrarsesion.Text = "Cerrar Sesion"
        Me.btnCerrarsesion.UseVisualStyleBackColor = False
        '
        'BtneditaUsuarios
        '
        Me.BtneditaUsuarios.BackColor = System.Drawing.Color.LightGray
        Me.BtneditaUsuarios.FlatAppearance.BorderSize = 0
        Me.BtneditaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtneditaUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtneditaUsuarios.Location = New System.Drawing.Point(677, 3)
        Me.BtneditaUsuarios.Name = "BtneditaUsuarios"
        Me.BtneditaUsuarios.Size = New System.Drawing.Size(112, 86)
        Me.BtneditaUsuarios.TabIndex = 12
        Me.BtneditaUsuarios.Text = "Editar usuarios"
        Me.BtneditaUsuarios.UseVisualStyleBackColor = False
        '
        'BtnEditarplatos
        '
        Me.BtnEditarplatos.BackColor = System.Drawing.Color.LightGray
        Me.BtnEditarplatos.FlatAppearance.BorderSize = 0
        Me.BtnEditarplatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditarplatos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditarplatos.Location = New System.Drawing.Point(795, 3)
        Me.BtnEditarplatos.Name = "BtnEditarplatos"
        Me.BtnEditarplatos.Size = New System.Drawing.Size(146, 86)
        Me.BtnEditarplatos.TabIndex = 11
        Me.BtnEditarplatos.Text = "Editar platos"
        Me.BtnEditarplatos.UseVisualStyleBackColor = False
        '
        'Navegacion
        '
        Me.Navegacion.BackColor = System.Drawing.Color.LightGray
        Me.Navegacion.Controls.Add(Me.BtnAdmin)
        Me.Navegacion.Controls.Add(Me.btnCerrarsesion)
        Me.Navegacion.Controls.Add(Me.BtneditaUsuarios)
        Me.Navegacion.Controls.Add(Me.BtnAnadirFondos)
        Me.Navegacion.Controls.Add(Me.btnHistorial)
        Me.Navegacion.Controls.Add(Me.BtnEditarplatos)
        Me.Navegacion.Controls.Add(Me.btnPerfil)
        Me.Navegacion.Controls.Add(Me.Button1)
        Me.Navegacion.Controls.Add(Me.LblSaldo)
        Me.Navegacion.Controls.Add(Me.LblNombreUsuario)
        Me.Navegacion.Controls.Add(Me.ImgUsuario)
        Me.Navegacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.Navegacion.Location = New System.Drawing.Point(0, 0)
        Me.Navegacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Navegacion.Name = "Navegacion"
        Me.Navegacion.Size = New System.Drawing.Size(1312, 92)
        Me.Navegacion.TabIndex = 24
        '
        'BtnAdmin
        '
        Me.BtnAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAdmin.BackColor = System.Drawing.Color.LightGray
        Me.BtnAdmin.FlatAppearance.BorderSize = 0
        Me.BtnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnAdmin.Location = New System.Drawing.Point(959, 3)
        Me.BtnAdmin.Name = "BtnAdmin"
        Me.BtnAdmin.Size = New System.Drawing.Size(186, 86)
        Me.BtnAdmin.TabIndex = 32
        Me.BtnAdmin.Text = "Admin"
        Me.BtnAdmin.UseVisualStyleBackColor = False
        '
        'BtnAnadirFondos
        '
        Me.BtnAnadirFondos.FlatAppearance.BorderSize = 0
        Me.BtnAnadirFondos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnadirFondos.Location = New System.Drawing.Point(433, 5)
        Me.BtnAnadirFondos.Name = "BtnAnadirFondos"
        Me.BtnAnadirFondos.Size = New System.Drawing.Size(128, 84)
        Me.BtnAnadirFondos.TabIndex = 31
        Me.BtnAnadirFondos.Text = "Añadir Fondos"
        Me.BtnAnadirFondos.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.FlatAppearance.BorderSize = 0
        Me.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistorial.Location = New System.Drawing.Point(558, 5)
        Me.btnHistorial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(112, 84)
        Me.btnHistorial.TabIndex = 30
        Me.btnHistorial.Text = "Historial"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'btnPerfil
        '
        Me.btnPerfil.FlatAppearance.BorderSize = 0
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Location = New System.Drawing.Point(326, 5)
        Me.btnPerfil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(100, 84)
        Me.btnPerfil.TabIndex = 29
        Me.btnPerfil.Text = "Mi perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(228, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 82)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblSaldo
        '
        Me.LblSaldo.AutoSize = True
        Me.LblSaldo.Location = New System.Drawing.Point(99, 49)
        Me.LblSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaldo.Name = "LblSaldo"
        Me.LblSaldo.Size = New System.Drawing.Size(50, 20)
        Me.LblSaldo.TabIndex = 28
        Me.LblSaldo.Text = "Saldo"
        '
        'LblNombreUsuario
        '
        Me.LblNombreUsuario.AutoSize = True
        Me.LblNombreUsuario.Location = New System.Drawing.Point(99, 14)
        Me.LblNombreUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombreUsuario.Name = "LblNombreUsuario"
        Me.LblNombreUsuario.Size = New System.Drawing.Size(120, 20)
        Me.LblNombreUsuario.TabIndex = 27
        Me.LblNombreUsuario.Text = "NombreUsuario"
        '
        'ImgUsuario
        '
        Me.ImgUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImgUsuario.Location = New System.Drawing.Point(0, 0)
        Me.ImgUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ImgUsuario.Name = "ImgUsuario"
        Me.ImgUsuario.Size = New System.Drawing.Size(90, 89)
        Me.ImgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgUsuario.TabIndex = 26
        Me.ImgUsuario.TabStop = False
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(0, 92)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1312, 717)
        Me.PanelFormularios.TabIndex = 25
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1312, 809)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.Navegacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "PantallaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Navegacion.ResumeLayout(False)
        Me.Navegacion.PerformLayout()
        CType(Me.ImgUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtneditaUsuarios As Button
    Friend WithEvents BtnEditarplatos As Button
    Friend WithEvents btnCerrarsesion As Button
    Friend WithEvents Navegacion As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents LblSaldo As Label
    Friend WithEvents LblNombreUsuario As Label
    Friend WithEvents ImgUsuario As PictureBox
    Friend WithEvents btnPerfil As Button
    Friend WithEvents BtnAnadirFondos As Button
    Friend WithEvents btnHistorial As Button
    Friend WithEvents BtnAdmin As Button
    Friend WithEvents PanelFormularios As Panel
End Class
