<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_mesero = New System.Windows.Forms.Button()
        Me.btn_adm = New System.Windows.Forms.Button()
        Me.btn_caja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_mesero
        '
        Me.btn_mesero.Location = New System.Drawing.Point(162, 258)
        Me.btn_mesero.Name = "btn_mesero"
        Me.btn_mesero.Size = New System.Drawing.Size(204, 53)
        Me.btn_mesero.TabIndex = 4
        Me.btn_mesero.Text = "MESERO"
        Me.btn_mesero.UseVisualStyleBackColor = True
        '
        'btn_adm
        '
        Me.btn_adm.Location = New System.Drawing.Point(162, 75)
        Me.btn_adm.Name = "btn_adm"
        Me.btn_adm.Size = New System.Drawing.Size(204, 53)
        Me.btn_adm.TabIndex = 2
        Me.btn_adm.Text = "ADMINISTRADOR"
        Me.btn_adm.UseVisualStyleBackColor = True
        '
        'btn_caja
        '
        Me.btn_caja.Location = New System.Drawing.Point(162, 165)
        Me.btn_caja.Name = "btn_caja"
        Me.btn_caja.Size = New System.Drawing.Size(204, 53)
        Me.btn_caja.TabIndex = 3
        Me.btn_caja.Text = "CAJA"
        Me.btn_caja.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 387)
        Me.Controls.Add(Me.btn_mesero)
        Me.Controls.Add(Me.btn_adm)
        Me.Controls.Add(Me.btn_caja)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_mesero As Button
    Friend WithEvents btn_adm As Button
    Friend WithEvents btn_caja As Button
End Class
