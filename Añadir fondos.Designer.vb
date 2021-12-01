<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Añadir_fondos
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
        Me.SuspendLayout()
        '
        'labelSaldodisponible
        '
        Me.labelSaldodisponible.AutoSize = True
        Me.labelSaldodisponible.Location = New System.Drawing.Point(381, 111)
        Me.labelSaldodisponible.Name = "labelSaldodisponible"
        Me.labelSaldodisponible.Size = New System.Drawing.Size(32, 13)
        Me.labelSaldodisponible.TabIndex = 0
        Me.labelSaldodisponible.Text = "saldo"
        '
        'btnBancoGeneral
        '
        Me.btnBancoGeneral.Location = New System.Drawing.Point(331, 151)
        Me.btnBancoGeneral.Name = "btnBancoGeneral"
        Me.btnBancoGeneral.Size = New System.Drawing.Size(138, 27)
        Me.btnBancoGeneral.TabIndex = 1
        Me.btnBancoGeneral.Text = "Banco General"
        Me.btnBancoGeneral.UseVisualStyleBackColor = True
        '
        'BtnNequi
        '
        Me.BtnNequi.Location = New System.Drawing.Point(331, 195)
        Me.BtnNequi.Name = "BtnNequi"
        Me.BtnNequi.Size = New System.Drawing.Size(138, 27)
        Me.BtnNequi.TabIndex = 2
        Me.BtnNequi.Text = "Nequi"
        Me.BtnNequi.UseVisualStyleBackColor = True
        '
        'BtnBitcoin
        '
        Me.BtnBitcoin.Location = New System.Drawing.Point(331, 240)
        Me.BtnBitcoin.Name = "BtnBitcoin"
        Me.BtnBitcoin.Size = New System.Drawing.Size(138, 27)
        Me.BtnBitcoin.TabIndex = 3
        Me.BtnBitcoin.Text = "Bitcoin"
        Me.BtnBitcoin.UseVisualStyleBackColor = True
        '
        'Añadir_fondos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnBitcoin)
        Me.Controls.Add(Me.BtnNequi)
        Me.Controls.Add(Me.btnBancoGeneral)
        Me.Controls.Add(Me.labelSaldodisponible)
        Me.Name = "Añadir_fondos"
        Me.Text = "Añadir_fondos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelSaldodisponible As Label
    Friend WithEvents btnBancoGeneral As Button
    Friend WithEvents BtnNequi As Button
    Friend WithEvents BtnBitcoin As Button
End Class
