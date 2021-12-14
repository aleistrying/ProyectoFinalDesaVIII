<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MiPerfilForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.ComboBoxFotoPerfil = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkViolet
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1312, 154)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(582, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mi Perfil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(227, 198)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Correo Electronico"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtCorreo.Location = New System.Drawing.Point(232, 232)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.ReadOnly = True
        Me.TxtCorreo.Size = New System.Drawing.Size(202, 35)
        Me.TxtCorreo.TabIndex = 2
        Me.TxtCorreo.Text = "Correo electonico"
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNombre.Location = New System.Drawing.Point(232, 349)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(202, 35)
        Me.TxtNombre.TabIndex = 4
        Me.TxtNombre.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(226, 313)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtApellido.Location = New System.Drawing.Point(232, 463)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(202, 35)
        Me.TxtApellido.TabIndex = 6
        Me.TxtApellido.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(225, 419)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(102, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Apellido"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(861, 198)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnSalvar.Location = New System.Drawing.Point(507, 609)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(268, 64)
        Me.BtnSalvar.TabIndex = 9
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'ComboBoxFotoPerfil
        '
        Me.ComboBoxFotoPerfil.AutoCompleteCustomSource.AddRange(New String() {"default.png" & Global.Microsoft.VisualBasic.ChrW(9), "man-1.png", "man-2.png", "man-3.png", "man-4.png", "man-5.png", "man-6.png", "man-7.png", "man-8.png", "otro-1.png", "otro-2.png", "otro-3.png", "otro-4.png", "otro-5.png", "otro-6.png", "otro-7.png", "otro-8.png", "woman-1.png ", "woman-2.png ", "woman-3.png ", "woman-4.png ", "woman-5.png ", "woman-6.png ", "woman-7.png ", "woman-8.png"})
        Me.ComboBoxFotoPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ComboBoxFotoPerfil.FormattingEnabled = True
        Me.ComboBoxFotoPerfil.Items.AddRange(New Object() {"default.png" & Global.Microsoft.VisualBasic.ChrW(9), "man-1.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "man-2.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "man-3.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "man-4.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "man-5.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "man-6.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "man-7.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "man-8.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "otro-1.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "otro-2.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "otro-3.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "otro-4.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "otro-5.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "otro-6.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "otro-7.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "otro-8.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "woman-1.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "woman-2.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "woman-3.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "woman-4.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "woman-5.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "woman-6.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "woman-7.png" & Global.Microsoft.VisualBasic.ChrW(9) & " ", "woman-8.png"})
        Me.ComboBoxFotoPerfil.Location = New System.Drawing.Point(507, 230)
        Me.ComboBoxFotoPerfil.Name = "ComboBoxFotoPerfil"
        Me.ComboBoxFotoPerfil.Size = New System.Drawing.Size(300, 37)
        Me.ComboBoxFotoPerfil.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(502, 198)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Foto de Perfil"
        '
        'MiPerfilForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1312, 717)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxFotoPerfil)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MiPerfilForm"
        Me.Text = "MiPerfilForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents ComboBoxFotoPerfil As ComboBox
    Friend WithEvents Label5 As Label
End Class
