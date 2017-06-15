Public Class descripcion_pedido
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SQLQuery("update detalle_pedido set descripcion='" & TextBox1.Text.ToString & "' where id_detalle_pedido='" & Label1.Text.ToString & "'", False)
        Me.Hide()
    End Sub
End Class