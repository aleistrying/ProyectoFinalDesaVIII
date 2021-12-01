<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pantallaRegistro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pantallaRegistro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnAcceptar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPasswordConfirmar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.eyeIconPass = New System.Windows.Forms.PictureBox()
        Me.eyeIconConPass = New System.Windows.Forms.PictureBox()
        CType(Me.eyeIconPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eyeIconConPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(82, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 40)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Crear Cuenta"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblPassword.Location = New System.Drawing.Point(43, 316)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 13
        Me.lblPassword.Text = "Password"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblUsuario.Location = New System.Drawing.Point(43, 246)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(48, 20)
        Me.lblUsuario.TabIndex = 12
        Me.lblUsuario.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(47, 273)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(323, 30)
        Me.txtEmail.TabIndex = 11
        '
        'btnAcceptar
        '
        Me.btnAcceptar.BackColor = System.Drawing.Color.Indigo
        Me.btnAcceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnAcceptar.ForeColor = System.Drawing.Color.White
        Me.btnAcceptar.Location = New System.Drawing.Point(89, 478)
        Me.btnAcceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAcceptar.Name = "btnAcceptar"
        Me.btnAcceptar.Size = New System.Drawing.Size(240, 82)
        Me.btnAcceptar.TabIndex = 9
        Me.btnAcceptar.Text = "Acceptar"
        Me.btnAcceptar.UseVisualStyleBackColor = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnVolver.Location = New System.Drawing.Point(89, 570)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(240, 82)
        Me.btnVolver.TabIndex = 16
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(47, 339)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(282, 30)
        Me.txtPassword.TabIndex = 10
        '
        'txtPasswordConfirmar
        '
        Me.txtPasswordConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPasswordConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPasswordConfirmar.Location = New System.Drawing.Point(47, 405)
        Me.txtPasswordConfirmar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPasswordConfirmar.Name = "txtPasswordConfirmar"
        Me.txtPasswordConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordConfirmar.Size = New System.Drawing.Size(282, 30)
        Me.txtPasswordConfirmar.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(43, 383)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Confirmar Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(43, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Tag = ""
        Me.Label3.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtNombre.Location = New System.Drawing.Point(47, 141)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(323, 30)
        Me.txtNombre.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(43, 179)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Tag = "Usuario"
        Me.Label4.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtApellido.Location = New System.Drawing.Point(47, 207)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(323, 30)
        Me.txtApellido.TabIndex = 21
        '
        'eyeIconPass
        '
        Me.eyeIconPass.InitialImage = CType(resources.GetObject("eyeIconPass.InitialImage"), System.Drawing.Image)
        Me.eyeIconPass.Location = New System.Drawing.Point(340, 339)
        Me.eyeIconPass.Name = "eyeIconPass"
        Me.eyeIconPass.Size = New System.Drawing.Size(30, 30)
        Me.eyeIconPass.TabIndex = 23
        Me.eyeIconPass.TabStop = False
        '
        'eyeIconConPass
        '
        Me.eyeIconConPass.Location = New System.Drawing.Point(340, 405)
        Me.eyeIconConPass.Name = "eyeIconConPass"
        Me.eyeIconConPass.Size = New System.Drawing.Size(30, 30)
        Me.eyeIconConPass.TabIndex = 24
        Me.eyeIconConPass.TabStop = False
        '
        'pantallaRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 672)
        Me.Controls.Add(Me.eyeIconConPass)
        Me.Controls.Add(Me.eyeIconPass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPasswordConfirmar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnAcceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pantallaRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Cuenta"
        CType(Me.eyeIconPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eyeIconConPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnAcceptar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPasswordConfirmar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents eyeIconPass As PictureBox
    Friend WithEvents eyeIconConPass As PictureBox
End Class
