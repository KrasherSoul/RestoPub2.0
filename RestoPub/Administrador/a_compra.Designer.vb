<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class a_compra
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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ProveedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestobarDataSet4 = New RestoPub.restobarDataSet4()
        Me.RestobarDataSet = New RestoPub.restobarDataSet()
        Me.RestobarDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProveedorTableAdapter = New RestoPub.restobarDataSet4TableAdapters.proveedorTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.textneto = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestobarDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestobarDataSet1 = New RestoPub.restobarDataSet1()
        Me.textdescrip = New System.Windows.Forms.TextBox()
        Me.textCodig = New System.Windows.Forms.TextBox()
        Me.textcantidad = New System.Windows.Forms.TextBox()
        Me.textnombre = New System.Windows.Forms.TextBox()
        Me.textunitario = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo_barra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_neto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CategoriaTableAdapter = New RestoPub.restobarDataSet1TableAdapters.categoriaTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.id_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_barra1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_unitario1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.codigo_barra3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestobarDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestobarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestobarDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestobarDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestobarDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ProveedorBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(19, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(138, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "rut"
        '
        'ProveedorBindingSource
        '
        Me.ProveedorBindingSource.DataMember = "proveedor"
        Me.ProveedorBindingSource.DataSource = Me.RestobarDataSet4
        '
        'RestobarDataSet4
        '
        Me.RestobarDataSet4.DataSetName = "restobarDataSet4"
        Me.RestobarDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RestobarDataSet
        '
        Me.RestobarDataSet.DataSetName = "restobarDataSet"
        Me.RestobarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RestobarDataSetBindingSource
        '
        Me.RestobarDataSetBindingSource.DataSource = Me.RestobarDataSet
        Me.RestobarDataSetBindingSource.Position = 0
        '
        'ProveedorTableAdapter
        '
        Me.ProveedorTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la compra"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(492, 40)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 6
        Me.TextBox6.Text = "total"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(191, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(259, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.textneto)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.textdescrip)
        Me.GroupBox2.Controls.Add(Me.textCodig)
        Me.GroupBox2.Controls.Add(Me.textcantidad)
        Me.GroupBox2.Controls.Add(Me.textnombre)
        Me.GroupBox2.Controls.Add(Me.textunitario)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(917, 112)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(329, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Label3"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(170, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 38)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Agregar producto"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'textneto
        '
        Me.textneto.Location = New System.Drawing.Point(638, 28)
        Me.textneto.Name = "textneto"
        Me.textneto.Size = New System.Drawing.Size(100, 20)
        Me.textneto.TabIndex = 7
        Me.textneto.Text = "precio venta"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.CategoriaBindingSource
        Me.ComboBox2.DisplayMember = "nombre"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(329, 28)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 5
        Me.ComboBox2.ValueMember = "id_categoria"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.RestobarDataSet1BindingSource
        '
        'RestobarDataSet1BindingSource
        '
        Me.RestobarDataSet1BindingSource.DataSource = Me.RestobarDataSet1
        Me.RestobarDataSet1BindingSource.Position = 0
        '
        'RestobarDataSet1
        '
        Me.RestobarDataSet1.DataSetName = "restobarDataSet1"
        Me.RestobarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'textdescrip
        '
        Me.textdescrip.Location = New System.Drawing.Point(40, 72)
        Me.textdescrip.Name = "textdescrip"
        Me.textdescrip.Size = New System.Drawing.Size(100, 20)
        Me.textdescrip.TabIndex = 4
        Me.textdescrip.Text = "descripcion"
        '
        'textCodig
        '
        Me.textCodig.AccessibleName = ""
        Me.textCodig.Location = New System.Drawing.Point(40, 29)
        Me.textCodig.Name = "textCodig"
        Me.textCodig.Size = New System.Drawing.Size(100, 20)
        Me.textCodig.TabIndex = 3
        Me.textCodig.Text = "codigo barra"
        '
        'textcantidad
        '
        Me.textcantidad.Location = New System.Drawing.Point(699, 68)
        Me.textcantidad.Name = "textcantidad"
        Me.textcantidad.Size = New System.Drawing.Size(100, 20)
        Me.textcantidad.TabIndex = 2
        Me.textcantidad.Text = "cantidad"
        '
        'textnombre
        '
        Me.textnombre.Location = New System.Drawing.Point(170, 29)
        Me.textnombre.Name = "textnombre"
        Me.textnombre.Size = New System.Drawing.Size(100, 20)
        Me.textnombre.TabIndex = 0
        Me.textnombre.Text = "nombre"
        '
        'textunitario
        '
        Me.textunitario.Location = New System.Drawing.Point(504, 29)
        Me.textunitario.Name = "textunitario"
        Me.textunitario.Size = New System.Drawing.Size(100, 20)
        Me.textunitario.TabIndex = 1
        Me.textunitario.Text = "precio uni"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo_barra, Me.id_categoria, Me.nombre, Me.precio_neto, Me.cantidad, Me.descripcion})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 315)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'codigo_barra
        '
        Me.codigo_barra.HeaderText = "codigo_barra"
        Me.codigo_barra.Name = "codigo_barra"
        '
        'id_categoria
        '
        Me.id_categoria.HeaderText = "id_categoria"
        Me.id_categoria.Name = "id_categoria"
        '
        'nombre
        '
        Me.nombre.HeaderText = "nombre"
        Me.nombre.Name = "nombre"
        '
        'precio_neto
        '
        Me.precio_neto.HeaderText = "precio_neto"
        Me.precio_neto.Name = "precio_neto"
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "descripcion"
        Me.descripcion.Name = "descripcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(798, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "id_de_la_compra"
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(798, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "id_detalle_compra"
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Location = New System.Drawing.Point(91, 258)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(63, 13)
        Me.lblPrincipal.TabIndex = 9
        Me.lblPrincipal.Text = "PRINCIPAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "cantidad ant"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(283, 281)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "cantidad new"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(726, 612)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(197, 38)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "aceptar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_compra, Me.codigo_barra1, Me.precio_unitario1, Me.cantidad1})
        Me.DataGridView2.Location = New System.Drawing.Point(662, 315)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(444, 277)
        Me.DataGridView2.TabIndex = 12
        '
        'id_compra
        '
        Me.id_compra.HeaderText = "id_compra"
        Me.id_compra.Name = "id_compra"
        '
        'codigo_barra1
        '
        Me.codigo_barra1.HeaderText = "Cod. Barra"
        Me.codigo_barra1.Name = "codigo_barra1"
        '
        'precio_unitario1
        '
        Me.precio_unitario1.HeaderText = "precio unit."
        Me.precio_unitario1.Name = "precio_unitario1"
        '
        'cantidad1
        '
        Me.cantidad1.HeaderText = "cantidad"
        Me.cantidad1.Name = "cantidad1"
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo_barra3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.cantidad3, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView3.Location = New System.Drawing.Point(12, 471)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(644, 121)
        Me.DataGridView3.TabIndex = 13
        '
        'codigo_barra3
        '
        Me.codigo_barra3.HeaderText = "codigo_barra"
        Me.codigo_barra3.Name = "codigo_barra3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "id_categoria"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "precio_neto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'cantidad3
        '
        Me.cantidad3.HeaderText = "cantidad"
        Me.cantidad3.Name = "cantidad3"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'a_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 662)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "a_compra"
        Me.Text = "a_compra"
        CType(Me.ProveedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestobarDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestobarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestobarDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestobarDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestobarDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RestobarDataSetBindingSource As BindingSource
    Friend WithEvents RestobarDataSet As restobarDataSet
    Friend WithEvents RestobarDataSet4 As restobarDataSet4
    Friend WithEvents ProveedorBindingSource As BindingSource
    Friend WithEvents ProveedorTableAdapter As restobarDataSet4TableAdapters.proveedorTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textcantidad As TextBox
    Friend WithEvents textunitario As TextBox
    Friend WithEvents textnombre As TextBox
    Friend WithEvents textdescrip As TextBox
    Friend WithEvents textCodig As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents RestobarDataSet1BindingSource As BindingSource
    Friend WithEvents RestobarDataSet1 As restobarDataSet1
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As restobarDataSet1TableAdapters.categoriaTableAdapter
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textneto As TextBox
    Friend WithEvents lblPrincipal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents codigo_barra As DataGridViewTextBoxColumn
    Friend WithEvents id_categoria As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents precio_neto As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents id_compra As DataGridViewTextBoxColumn
    Friend WithEvents codigo_barra1 As DataGridViewTextBoxColumn
    Friend WithEvents precio_unitario1 As DataGridViewTextBoxColumn
    Friend WithEvents cantidad1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents codigo_barra3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents cantidad3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
