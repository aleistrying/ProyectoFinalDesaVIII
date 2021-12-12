<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegistro = New System.Windows.Forms.Button()
        Me.lblOlvide = New System.Windows.Forms.Label()
        Me.BtnInformacionForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Indigo
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(118, 373)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(240, 82)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.TabStop = False
        Me.BtnLogin.Text = "Ingresar"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtPassword.Location = New System.Drawing.Point(71, 242)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(323, 30)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.Text = "88362824283a80d2bf068c76d73da039"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtUsuario.Location = New System.Drawing.Point(71, 163)
        Me.TxtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(323, 30)
        Me.TxtUsuario.TabIndex = 0
        Me.TxtUsuario.Text = "alejandro.parparcen@utp.ac.pa"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblUsuario.Location = New System.Drawing.Point(67, 138)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblPassword.Location = New System.Drawing.Point(67, 217)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(61, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "App de Cafeteria"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Brown
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(118, 557)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(240, 82)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnRegistro
        '
        Me.btnRegistro.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRegistro.Location = New System.Drawing.Point(118, 467)
        Me.btnRegistro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegistro.Name = "btnRegistro"
        Me.btnRegistro.Size = New System.Drawing.Size(240, 82)
        Me.btnRegistro.TabIndex = 5
        Me.btnRegistro.TabStop = False
        Me.btnRegistro.Text = "Registro"
        Me.btnRegistro.UseVisualStyleBackColor = False
        '
        'lblOlvide
        '
        Me.lblOlvide.AutoSize = True
        Me.lblOlvide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlvide.Location = New System.Drawing.Point(163, 315)
        Me.lblOlvide.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOlvide.Name = "lblOlvide"
        Me.lblOlvide.Size = New System.Drawing.Size(144, 20)
        Me.lblOlvide.TabIndex = 3
        Me.lblOlvide.Text = "Olvide mi password"
        '
        'BtnInformacionForm
        '
        Me.BtnInformacionForm.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnInformacionForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInformacionForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnInformacionForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnInformacionForm.Location = New System.Drawing.Point(167, 664)
        Me.BtnInformacionForm.Name = "BtnInformacionForm"
        Me.BtnInformacionForm.Size = New System.Drawing.Size(140, 48)
        Me.BtnInformacionForm.TabIndex = 0
        Me.BtnInformacionForm.TabStop = False
        Me.BtnInformacionForm.Text = "Información "
        Me.BtnInformacionForm.UseVisualStyleBackColor = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 724)
        Me.Controls.Add(Me.BtnInformacionForm)
        Me.Controls.Add(Me.lblOlvide)
        Me.Controls.Add(Me.btnRegistro)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.BtnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegistro As Button
    Friend WithEvents lblOlvide As Label
    Friend WithEvents BtnInformacionForm As Button
End Class
