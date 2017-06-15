<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class a_inicio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarMesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.FamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrabajadorToolStripMenuItem, Me.CargosToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.EditarMesasToolStripMenuItem, Me.FamiliaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(869, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TrabajadorToolStripMenuItem
        '
        Me.TrabajadorToolStripMenuItem.Name = "TrabajadorToolStripMenuItem"
        Me.TrabajadorToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.TrabajadorToolStripMenuItem.Text = "Trabajador"
        '
        'CargosToolStripMenuItem
        '
        Me.CargosToolStripMenuItem.Name = "CargosToolStripMenuItem"
        Me.CargosToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.CargosToolStripMenuItem.Text = "Cargos"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.AgregarProductoToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'AgregarProductoToolStripMenuItem
        '
        Me.AgregarProductoToolStripMenuItem.Name = "AgregarProductoToolStripMenuItem"
        Me.AgregarProductoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AgregarProductoToolStripMenuItem.Text = "Agregar Producto"
        '
        'EditarMesasToolStripMenuItem
        '
        Me.EditarMesasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.EditarMesasToolStripMenuItem.Name = "EditarMesasToolStripMenuItem"
        Me.EditarMesasToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.EditarMesasToolStripMenuItem.Text = "Mesas"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.GuardarToolStripMenuItem.Text = "Terminar"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(500, 141)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(115, 32)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar Mesa"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(500, 105)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(115, 30)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "Eliminar Mesa"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(500, 69)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(115, 30)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar Mesas"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FamiliaToolStripMenuItem
        '
        Me.FamiliaToolStripMenuItem.Name = "FamiliaToolStripMenuItem"
        Me.FamiliaToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FamiliaToolStripMenuItem.Text = "Familia"
        '
        'a_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 503)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "a_inicio"
        Me.Text = "a_inicio"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents EditarMesasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents FamiliaToolStripMenuItem As ToolStripMenuItem
End Class
