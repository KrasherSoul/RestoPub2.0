Public Class pedidos
    Dim cPedidos As Integer = 0

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

                AddHandler btn.MouseClick, AddressOf Click_botonFamilia
                Me.Controls.Add(btn)

            End While
        End If

    End Sub
    Public Sub cargar_productos()

    End Sub
    Private Sub Click_botonFamilia(sender As Object, e As MouseEventArgs)
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

    Private Sub Click_boton(sender As Object, e As MouseEventArgs)
        Dim query As String
        cPedidos = cPedidos + 1
        If cPedidos = 1 Then
            query = ("INSERT INTO pedido(id_mesa,rut,fecha_hora,estado) VALUES ('" & Label2.Text & "', '" & Label3.Text & "', '" & Now.ToShortDateString.ToString & "', 'Pendiente' )")
            SQLQuery(query, False)
            query = ("INSERT INTO detalle_pedido(id_producto,id_pedido,descripcion) VALUES ('" & sender.name & "', '" & Label4.Text & "', '' )")
            SQLQuery(query, False)
            llenarDetallePedidos()
        Else
            query = "select id_pedido from pedido where id_mesa='" & Label2.Text & "' and rut='" & Label3.Text & "'"
            SQLQuery(query, True)
            If lector.Read Then
                Label4.Text = lector.Item("id_pedido")
            End If
            query = ("INSERT INTO detalle_pedido(id_producto,id_pedido,descripcion) VALUES ('" & sender.name & "', '" & Label4.Text & "', '' )")
            SQLQuery(query, False)
            MsgBox(query)
            llenarDetallePedidos()

        End If
    End Sub

    Private Sub llenarDetallePedidos()
        DataGridView3.Rows.Clear()
        SQLQuery("SELECT dbo.detalle_pedido.id_producto, dbo.producto.nombre as nombreP, dbo.producto.precio FROM dbo.detalle_pedido INNER JOIN dbo.producto ON dbo.detalle_pedido.id_producto = dbo.producto.id_producto", True)
        If lector.HasRows Then
            While lector.Read
                DataGridView3.Rows.Add(lector.Item("id_producto"), lector.Item("nombreP"), lector.Item("precio"), "")
            End While
        End If
    End Sub
End Class