Public Class l_pedidos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "SELECT nombre FROM trabajador INNER JOIN usuario ON trabajador.rut = usuario.rut where pass= " & TextBox1.Text
        SQLQuery(sql, True)
        If lector.HasRows Then
            While lector.Read
                pedidos.Label2.Text = Me.Text
                pedidos.Show()
                Me.Hide()
            End While
        End If


    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Dim sql As String
        If e.KeyCode = Keys.KeyCode.Enter Then
            sql = "SELECT trabajador.rut FROM trabajador INNER JOIN usuario ON trabajador.rut = usuario.rut where pass= " & TextBox1.Text
            SQLQuery(sql, True)
            If lector.HasRows Then
                While lector.Read
                    pedidos.Label2.Text = Me.Text
                    pedidos.Label3.Text = lector.Item("rut")
                    pedidos.Show()
                    Me.Hide()
                End While
            End If
        End If
    End Sub
End Class