Public Class l_pedidos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        pedidos.Text = Me.Text
        pedidos.Show()
        Me.Hide()
    End Sub



    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            pedidos.Text = Me.Text
            pedidos.Show()
            Me.Hide()
        End If
    End Sub
End Class