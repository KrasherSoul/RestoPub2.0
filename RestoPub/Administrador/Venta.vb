Public Class Venta
    Dim id_mesa As Integer
    Dim vuelto As Integer
    Dim efectivo As Integer
    Dim propina As Integer
    Dim total As Integer


    Private Sub Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDetallePedidos()
        TextBox1.Text = total
        propina = total * 0.1

        TextBox8.Text = propina.ToString


    End Sub
    Private Sub llenarDetallePedidos()
        SQLQuery("SELECT pedido.id_pedido as pedido From pedido INNER Join mesa ON pedido.id_mesa = mesa.id_mesa Where (mesa.num_mesa = '3') AND (pedido.estado = 'pendiente')", True)
        If lector.HasRows Then
            While lector.Read

                SQLQuery2("Select dbo.producto.nombre As nombreP, dbo.producto.precio, detalle_pedido.fecha_hora FROM dbo.detalle_pedido INNER JOIN dbo.producto ON dbo.detalle_pedido.id_producto = dbo.producto.id_producto where id_pedido='" & lector.Item(0) & "'", True)
                If lector2.HasRows Then
                    While lector2.Read
                        DataGridView1.Rows.Add(lector2.Item("nombreP"), lector2.Item("precio"), lector2.Item("fecha_hora"))
                        total = total + lector2.Item("precio")
                    End While

                End If
            End While
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox2.Checked Then
            TextBox3.Text = (efectivo - CInt(TextBox7.Text.ToString)).ToString
        Else
            vuelto = efectivo - total
            TextBox3.Text = vuelto
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        efectivo = CInt(TextBox2.Text.ToString)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        TextBox7.Text = (propina + total).ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton3.Checked Then
            total = 0
            TextBox1.Text = total
        Else
            total = total - CInt(TextBox4.Text.ToString)
            TextBox1.Text = total
        End If


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        propina = total * 0.1
        TextBox8.Text = propina.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then

        End If
    End Sub
End Class