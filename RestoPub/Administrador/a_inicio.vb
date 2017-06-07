Public Class a_inicio

    Private Sub TrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrabajadorToolStripMenuItem.Click
        a_trabajador.Visible = True
        Me.Visible = False
    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem.Click
        a_cargos.Visible = True
        Me.Visible = False
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem.Click
        a_proveedor.Visible = True
        Me.Visible = False
    End Sub

    Private Sub a_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        a_categoria.Visible = True
        Me.Hide()
    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        a_producto.Visible = True
        Me.Hide()

    End Sub
End Class