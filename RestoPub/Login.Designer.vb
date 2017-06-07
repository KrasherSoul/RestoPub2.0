<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.ingresar_btn = New System.Windows.Forms.Button()
        Me.pass_usuario_text = New System.Windows.Forms.TextBox()
        Me.nombre_usuario_text = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ingresar_btn
        '
        Me.ingresar_btn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingresar_btn.Location = New System.Drawing.Point(82, 215)
        Me.ingresar_btn.Name = "ingresar_btn"
        Me.ingresar_btn.Size = New System.Drawing.Size(220, 38)
        Me.ingresar_btn.TabIndex = 20
        Me.ingresar_btn.Text = "Ingresar"
        Me.ingresar_btn.UseVisualStyleBackColor = True
        '
        'pass_usuario_text
        '
        Me.pass_usuario_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_usuario_text.Location = New System.Drawing.Point(82, 172)
        Me.pass_usuario_text.MaxLength = 25
        Me.pass_usuario_text.Name = "pass_usuario_text"
        Me.pass_usuario_text.Size = New System.Drawing.Size(220, 26)
        Me.pass_usuario_text.TabIndex = 19
        Me.pass_usuario_text.UseSystemPasswordChar = True
        '
        'nombre_usuario_text
        '
        Me.nombre_usuario_text.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_usuario_text.Location = New System.Drawing.Point(82, 132)
        Me.nombre_usuario_text.MaxLength = 25
        Me.nombre_usuario_text.Name = "nombre_usuario_text"
        Me.nombre_usuario_text.Size = New System.Drawing.Size(220, 26)
        Me.nombre_usuario_text.TabIndex = 18
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 385)
        Me.Controls.Add(Me.ingresar_btn)
        Me.Controls.Add(Me.pass_usuario_text)
        Me.Controls.Add(Me.nombre_usuario_text)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ingresar_btn As Button
    Friend WithEvents pass_usuario_text As TextBox
    Friend WithEvents nombre_usuario_text As TextBox
End Class
