<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class a_asistencia
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
        Me.dg_asistencia = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asistencia = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dg_asistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_asistencia
        '
        Me.dg_asistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_asistencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rut, Me.nombre, Me.apellido, Me.rutc, Me.cargo, Me.fecha, Me.estado1, Me.Asistencia})
        Me.dg_asistencia.Location = New System.Drawing.Point(4, 84)
        Me.dg_asistencia.Name = "dg_asistencia"
        Me.dg_asistencia.Size = New System.Drawing.Size(744, 243)
        Me.dg_asistencia.TabIndex = 9
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(226, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(69, 17)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Modificar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(505, 348)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(226, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 15
        '
        'rut
        '
        Me.rut.HeaderText = "rut"
        Me.rut.Name = "rut"
        Me.rut.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.HeaderText = "apellido"
        Me.apellido.Name = "apellido"
        '
        'rutc
        '
        Me.rutc.HeaderText = "rut"
        Me.rutc.Name = "rutc"
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        '
        'fecha
        '
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        '
        'estado1
        '
        Me.estado1.HeaderText = "estado1"
        Me.estado1.Name = "estado1"
        '
        'Asistencia
        '
        Me.Asistencia.HeaderText = "Asistencia"
        Me.Asistencia.Name = "Asistencia"
        '
        'a_asistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 463)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dg_asistencia)
        Me.Controls.Add(Me.CheckBox1)
        Me.Name = "a_asistencia"
        Me.Text = "a_asistencia"
        CType(Me.dg_asistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_asistencia As DataGridView
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rut As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents rutc As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents estado1 As DataGridViewTextBoxColumn
    Friend WithEvents Asistencia As DataGridViewCheckBoxColumn
End Class
