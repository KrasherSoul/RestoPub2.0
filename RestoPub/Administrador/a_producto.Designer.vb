<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class a_producto
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dg_productos = New System.Windows.Forms.DataGridView()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ver_Datos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Modificar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CargoTableAdapter = New RestoPub.restobarDataSetTableAdapters.cargoTableAdapter()
        Me.CargoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestobarDataSet = New RestoPub.restobarDataSet()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RTxtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestobarDataSet1 = New RestoPub.restobarDataSet1()
        Me.CategoriaTableAdapter = New RestoPub.restobarDataSet1TableAdapters.categoriaTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestobarDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestobarDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(491, 44)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(95, 20)
        Me.TxtPrecio.TabIndex = 10
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
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Precio:"
        '
        'Button1
        '
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(286, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 29)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(445, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 29)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Guardar cambios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dg_productos
        '
        Me.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.nombre, Me.categoria, Me.precio, Me.stock, Me.descripcion, Me.ver_Datos, Me.Modificar, Me.Eliminar})
        Me.dg_productos.Location = New System.Drawing.Point(9, 283)
        Me.dg_productos.Name = "dg_productos"
        Me.dg_productos.Size = New System.Drawing.Size(844, 205)
        Me.dg_productos.TabIndex = 28
        '
        'id_producto
        '
        Me.id_producto.HeaderText = "Id"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'categoria
        '
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(250, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripcion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(27, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(250, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Categoria:"
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
        'CargoTableAdapter
        '
        Me.CargoTableAdapter.ClearBeforeFill = True
        '
        'CargoBindingSource
        '
        Me.CargoBindingSource.DataMember = "cargo"
        Me.CargoBindingSource.DataSource = Me.RestobarDataSet
        '
        'RestobarDataSet
        '
        Me.RestobarDataSet.DataSetName = "restobarDataSet"
        Me.RestobarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(27, 110)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(147, 20)
        Me.TxtCantidad.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RTxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.CmbCategoria)
        Me.GroupBox1.Controls.Add(Me.TxtCantidad)
        Me.GroupBox1.Controls.Add(Me.TxtPrecio)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 207)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'RTxtDescripcion
        '
        Me.RTxtDescripcion.Location = New System.Drawing.Point(253, 111)
        Me.RTxtDescripcion.Name = "RTxtDescripcion"
        Me.RTxtDescripcion.Size = New System.Drawing.Size(237, 70)
        Me.RTxtDescripcion.TabIndex = 17
        Me.RTxtDescripcion.Text = ""
        '
        'CmbCategoria
        '
        Me.CmbCategoria.DataSource = Me.CategoriaBindingSource
        Me.CmbCategoria.DisplayMember = "nombre"
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(253, 44)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.CmbCategoria.TabIndex = 14
        Me.CmbCategoria.ValueMember = "id_categoria"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "categoria"
        Me.CategoriaBindingSource.DataSource = Me.RestobarDataSet1
        '
        'RestobarDataSet1
        '
        Me.RestobarDataSet1.DataSetName = "restobarDataSet1"
        Me.RestobarDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(286, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Label3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Label6"
        '
        'a_producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1095, 536)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dg_productos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "a_producto"
        Me.Text = "a_producto"
        CType(Me.dg_productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CargoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestobarDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestobarDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents dg_productos As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CargoTableAdapter As restobarDataSetTableAdapters.cargoTableAdapter
    Friend WithEvents CargoBindingSource As BindingSource
    Friend WithEvents RestobarDataSet As restobarDataSet
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbCategoria As ComboBox
    Friend WithEvents RTxtDescripcion As RichTextBox
    Friend WithEvents RestobarDataSet1 As restobarDataSet1
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As restobarDataSet1TableAdapters.categoriaTableAdapter
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents ver_Datos As DataGridViewButtonColumn
    Friend WithEvents Modificar As DataGridViewButtonColumn
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
