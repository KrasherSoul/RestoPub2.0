<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a_proveedor
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtTelefono2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTelefono1 = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.TxtVerificador = New System.Windows.Forms.TextBox()
        Me.TxtRut = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dg_proveedor = New System.Windows.Forms.DataGridView()
        Me.rut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.verificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rutc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ver_Datos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dg_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(491, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "rutA"
        '
        'TxtTelefono2
        '
        Me.TxtTelefono2.Location = New System.Drawing.Point(253, 174)
        Me.TxtTelefono2.Name = "TxtTelefono2"
        Me.TxtTelefono2.Size = New System.Drawing.Size(147, 20)
        Me.TxtTelefono2.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(250, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Telefono 2:"
        '
        'TxtTelefono1
        '
        Me.TxtTelefono1.Location = New System.Drawing.Point(26, 174)
        Me.TxtTelefono1.Name = "TxtTelefono1"
        Me.TxtTelefono1.Size = New System.Drawing.Size(147, 20)
        Me.TxtTelefono1.TabIndex = 18
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(491, 110)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(147, 20)
        Me.TxtCorreo.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(593, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(10, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "-"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(253, 110)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(147, 20)
        Me.TxtDireccion.TabIndex = 14
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(27, 110)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(147, 20)
        Me.TxtCiudad.TabIndex = 13
        '
        'TxtVerificador
        '
        Me.TxtVerificador.Location = New System.Drawing.Point(609, 44)
        Me.TxtVerificador.Name = "TxtVerificador"
        Me.TxtVerificador.Size = New System.Drawing.Size(33, 20)
        Me.TxtVerificador.TabIndex = 11
        '
        'TxtRut
        '
        Me.TxtRut.Location = New System.Drawing.Point(491, 44)
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.Size = New System.Drawing.Size(95, 20)
        Me.TxtRut.TabIndex = 10
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(253, 44)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(147, 20)
        Me.TxtApellido.TabIndex = 9
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(26, 44)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(147, 20)
        Me.TxtNombre.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(488, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Rut:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(488, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Correo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(250, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Direccion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(27, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ciudad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(24, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Telefono 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(250, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Button2
        '
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(477, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 29)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Guardar cambios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dg_proveedor
        '
        Me.dg_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_proveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.rut, Me.verificador, Me.nombre, Me.apellido, Me.rutc, Me.ciudad, Me.direccion, Me.correo, Me.telefono1, Me.telefono2, Me.ver_Datos, Me.Modificar, Me.Eliminar})
        Me.dg_proveedor.Location = New System.Drawing.Point(108, 293)
        Me.dg_proveedor.Name = "dg_proveedor"
        Me.dg_proveedor.Size = New System.Drawing.Size(844, 238)
        Me.dg_proveedor.TabIndex = 28
        '
        'rut
        '
        Me.rut.HeaderText = "rut"
        Me.rut.Name = "rut"
        Me.rut.Visible = False
        '
        'verificador
        '
        Me.verificador.HeaderText = "verificador"
        Me.verificador.Name = "verificador"
        Me.verificador.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        '
        'rutc
        '
        Me.rutc.HeaderText = "Rut"
        Me.rutc.Name = "rutc"
        '
        'ciudad
        '
        Me.ciudad.HeaderText = "Ciudad"
        Me.ciudad.Name = "ciudad"
        Me.ciudad.Visible = False
        '
        'direccion
        '
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.Visible = False
        '
        'correo
        '
        Me.correo.HeaderText = "Correo"
        Me.correo.Name = "correo"
        Me.correo.Visible = False
        '
        'telefono1
        '
        Me.telefono1.HeaderText = "Telefono 1"
        Me.telefono1.Name = "telefono1"
        '
        'telefono2
        '
        Me.telefono2.HeaderText = "Telefono 2"
        Me.telefono2.Name = "telefono2"
        '
        'ver_Datos
        '
        Me.ver_Datos.HeaderText = "Ver datos"
        Me.ver_Datos.Name = "ver_Datos"
        '
        'Modificar
        '
        Me.Modificar.HeaderText = "Modificar"
        Me.Modificar.Name = "Modificar"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtTelefono1)
        Me.GroupBox1.Controls.Add(Me.TxtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtCiudad)
        Me.GroupBox1.Controls.Add(Me.TxtVerificador)
        Me.GroupBox1.Controls.Add(Me.TxtRut)
        Me.GroupBox1.Controls.Add(Me.TxtApellido)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(988, 207)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Trabajador"
        '
        'Button1
        '
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(318, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 29)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'a_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 543)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dg_proveedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "a_proveedor"
        Me.Text = "a_proveedor"
        CType(Me.dg_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents TxtTelefono2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtTelefono1 As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents TxtVerificador As TextBox
    Friend WithEvents TxtRut As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dg_proveedor As DataGridView
    Friend WithEvents rut As DataGridViewTextBoxColumn
    Friend WithEvents verificador As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents rutc As DataGridViewTextBoxColumn
    Friend WithEvents ciudad As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents correo As DataGridViewTextBoxColumn
    Friend WithEvents telefono1 As DataGridViewTextBoxColumn
    Friend WithEvents telefono2 As DataGridViewTextBoxColumn
    Friend WithEvents ver_Datos As DataGridViewButtonColumn
    Friend WithEvents Modificar As DataGridViewButtonColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
End Class
