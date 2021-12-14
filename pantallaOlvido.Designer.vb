<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pantallaOlvido
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnAcceptar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BtnEnviarCodigo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(54, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 40)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Recuperar Cuenta"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblPassword.Location = New System.Drawing.Point(44, 282)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(78, 20)
        Me.lblPassword.TabIndex = 13
        Me.lblPassword.Text = "Password"
        Me.lblPassword.Visible = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lblUsuario.Location = New System.Drawing.Point(44, 150)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblUsuario.TabIndex = 12
        Me.lblUsuario.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtUsuario.Location = New System.Drawing.Point(48, 173)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(323, 30)
        Me.txtUsuario.TabIndex = 1
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
        Me.btnAcceptar.TabStop = False
        Me.btnAcceptar.Text = "Acceptar"
        Me.btnAcceptar.UseVisualStyleBackColor = False
        Me.btnAcceptar.Visible = False
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
        Me.btnVolver.TabStop = False
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPassword.Location = New System.Drawing.Point(48, 305)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(323, 30)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(48, 372)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(323, 30)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TabStop = False
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(44, 349)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Confirmar Password"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label3.Location = New System.Drawing.Point(44, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Tag = "Usuario"
        Me.Label3.Text = "Codigo"
        Me.Label3.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox2.Location = New System.Drawing.Point(48, 240)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(323, 30)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Visible = False
        '
        'BtnEnviarCodigo
        '
        Me.BtnEnviarCodigo.BackColor = System.Drawing.Color.Indigo
        Me.BtnEnviarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnviarCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BtnEnviarCodigo.ForeColor = System.Drawing.Color.White
        Me.BtnEnviarCodigo.Location = New System.Drawing.Point(135, 315)
        Me.BtnEnviarCodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEnviarCodigo.Name = "BtnEnviarCodigo"
        Me.BtnEnviarCodigo.Size = New System.Drawing.Size(145, 47)
        Me.BtnEnviarCodigo.TabIndex = 21
        Me.BtnEnviarCodigo.TabStop = False
        Me.BtnEnviarCodigo.Text = "Enviar Codigo"
        Me.BtnEnviarCodigo.UseVisualStyleBackColor = False
        '
        'pantallaOlvido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 672)
        Me.Controls.Add(Me.BtnEnviarCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnAcceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pantallaOlvido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pantallaOlvido"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnAcceptar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnEnviarCodigo As Button
End Class
