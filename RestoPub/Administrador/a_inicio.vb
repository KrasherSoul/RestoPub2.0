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
End Class