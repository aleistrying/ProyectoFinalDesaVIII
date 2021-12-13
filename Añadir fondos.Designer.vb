<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirFondosForm
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
        Me.labelSaldodisponible = New System.Windows.Forms.Label()
        Me.btnBancoGeneral = New System.Windows.Forms.Button()
        Me.BtnNequi = New System.Windows.Forms.Button()
        Me.BtnBitcoin = New System.Windows.Forms.Button()
        Me.LblSaldoActual = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtAgregarSaldo = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'labelSaldodisponible
        '
        Me.labelSaldodisponible.AutoSize = True
        Me.labelSaldodisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.labelSaldodisponible.Location = New System.Drawing.Point(458, 27)
        Me.labelSaldodisponible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelSaldodisponible.Name = "labelSaldodisponible"
        Me.labelSaldodisponible.Size = New System.Drawing.Size(275, 40)
        Me.labelSaldodisponible.TabIndex = 0
        Me.labelSaldodisponible.Text = "Agregar Fondos"
        '
        'btnBancoGeneral
        '
        Me.btnBancoGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnBancoGeneral.Location = New System.Drawing.Point(494, 329)
        Me.btnBancoGeneral.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBancoGeneral.Name = "btnBancoGeneral"
        Me.btnBancoGeneral.Size = New System.Drawing.Size(228, 79)
        Me.btnBancoGeneral.TabIndex = 1
        Me.btnBancoGeneral.Text = "Banco General"
        Me.btnBancoGeneral.UseVisualStyleBackColor = True
        '
        'BtnNequi
        '
        Me.BtnNequi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnNequi.Location = New System.Drawing.Point(494, 418)
        Me.BtnNequi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnNequi.Name = "BtnNequi"
        Me.BtnNequi.Size = New System.Drawing.Size(228, 79)
        Me.BtnNequi.TabIndex = 2
        Me.BtnNequi.Text = "Nequi"
        Me.BtnNequi.UseVisualStyleBackColor = True
        '
        'BtnBitcoin
        '
        Me.BtnBitcoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BtnBitcoin.Location = New System.Drawing.Point(494, 507)
        Me.BtnBitcoin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBitcoin.Name = "BtnBitcoin"
        Me.BtnBitcoin.Size = New System.Drawing.Size(228, 79)
        Me.BtnBitcoin.TabIndex = 3
        Me.BtnBitcoin.Text = "Bitcoin"
        Me.BtnBitcoin.UseVisualStyleBackColor = True
        '
        'LblSaldoActual
        '
        Me.LblSaldoActual.AutoSize = True
        Me.LblSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LblSaldoActual.Location = New System.Drawing.Point(470, 139)
        Me.LblSaldoActual.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaldoActual.Name = "LblSaldoActual"
        Me.LblSaldoActual.Size = New System.Drawing.Size(263, 32)
        Me.LblSaldoActual.TabIndex = 4
        Me.LblSaldoActual.Text = "Saldo Actual: $0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(488, 237)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 32)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Saldo a agregar $"
        '
        'TxtAgregarSaldo
        '
        Me.TxtAgregarSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TxtAgregarSaldo.Location = New System.Drawing.Point(494, 272)
        Me.TxtAgregarSaldo.Mask = "9999.00"
        Me.TxtAgregarSaldo.Name = "TxtAgregarSaldo"
        Me.TxtAgregarSaldo.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtAgregarSaldo.Size = New System.Drawing.Size(228, 44)
        Me.TxtAgregarSaldo.TabIndex = 7
        '
        'AñadirFondosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 692)
        Me.Controls.Add(Me.TxtAgregarSaldo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblSaldoActual)
        Me.Controls.Add(Me.BtnBitcoin)
        Me.Controls.Add(Me.BtnNequi)
        Me.Controls.Add(Me.btnBancoGeneral)
        Me.Controls.Add(Me.labelSaldodisponible)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AñadirFondosForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir_fondos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelSaldodisponible As Label
    Friend WithEvents btnBancoGeneral As Button
    Friend WithEvents BtnNequi As Button
    Friend WithEvents BtnBitcoin As Button
    Friend WithEvents LblSaldoActual As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtAgregarSaldo As MaskedTextBox
End Class
