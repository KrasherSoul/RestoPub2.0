Public Class pedidos
    Private Sub pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn As Button
        Dim sql As String
        Dim lft As Integer
        sql = "select * from familia"
        SQLQuery(sql, True)
        If lector.HasRows Then
            While lector.Read
                btn = New System.Windows.Forms.Button
                btn.Width = 100
                btn.Height = 30
                btn.Left = lft
                lft = lft + 105
                btn.Top = 0
                btn.Name = lector.Item("id_familia")
                btn.Font = New Font(btn.Name, 15, btn.Font.Style, btn.Font.Unit)
                btn.Text = lector.Item("nombre")
                btn.BackColor = Control.DefaultBackColor

                AddHandler btn.MouseClick, AddressOf Click_boton
                Me.Controls.Add(btn)

            End While
        End If

    End Sub
    Public Sub cargar_productos()

    End Sub
    Private Sub Click_boton(sender As Object, e As MouseEventArgs)
        DataGridView1.Rows.Clear()
        SQLQuery("SELECT categoria.id_categoria,categoria.nombre FROM categoria where id_familia=" & sender.name, True)
        If lector.HasRows Then
            While lector.Read
                DataGridView1.Rows.Add(lector.Item("id_categoria"), lector.Item("nombre"))
            End While
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = 1 Then
            Dim btn As Button
            Dim sql As String
            Dim lft As Integer = 140
            Dim tp As Integer = 40
            sql = "select * from producto where id_categoria=" & Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value
            SQLQuery(sql, True)
            If lector.HasRows Then
                While lector.Read
                    btn = New System.Windows.Forms.Button
                    btn.Width = 100
                    btn.Height = 30
                    btn.Left = lft
                    lft = lft + 105

                    If lft > 244 Then
                        lft = 135
                        tp = tp + 30
                    End If
                    btn.Top = tp
                    btn.Name = lector.Item("id_producto")
                    btn.Font = New Font(btn.Name, 15, btn.Font.Style, btn.Font.Unit)
                    btn.Text = lector.Item("nombre")
                    btn.BackColor = Control.DefaultBackColor

                    AddHandler btn.MouseClick, AddressOf Click_boton
                    Me.Controls.Add(btn)

                End While
            End If

        End If

    End Sub
End Class