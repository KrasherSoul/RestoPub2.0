Public Class pedidos
    Dim cPedidos As Integer = 0
    Dim nPedido As Integer = 0
    Dim nCuenta As Integer = 0

    Private Sub pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btn As Button
        Dim sql As String
        Dim lft As Integer
        Button2.Enabled = False

        LblIdPedido.Text = nPedido
        cPedidos = 0

        SQLQuery("select * from familia", True)
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
        sql = "select * from variables"
        SQLQuery(sql, True)
        If lector.HasRows Then
            While lector.Read
                nPedido = lector.Item("num_pedido")
                nCuenta = lector.Item("num_cuenta")
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
            Dim lft As Integer = 10
            Dim tp As Integer = 10
            sql = "select * from producto where id_categoria=" & Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value
            SQLQuery(sql, True)
            Me.GroupBox1.Controls.Clear()

            If lector.HasRows Then
                While lector.Read
                    If lft > 500 Then
                        lft = 10
                        tp = tp + 75
                    End If
                    btn = New System.Windows.Forms.Button
                    btn.Width = 150
                    btn.Height = 75
                    btn.Left = lft
                    lft = lft + 150


                    btn.Top = tp
                    btn.Name = lector.Item("id_producto")
                    btn.Font = New Font(btn.Name, 15, btn.Font.Style, btn.Font.Unit)
                    btn.Text = lector.Item("nombre")
                    btn.BackColor = Control.DefaultBackColor

                    AddHandler btn.MouseClick, AddressOf Click_boton
                    Me.GroupBox1.Controls.Add(btn)
                End While
            End If

        End If

    End Sub

    Private Sub Click_boton(sender As Object, e As MouseEventArgs)
        Dim query As String
        cPedidos = cPedidos + 1
        If cPedidos = 1 Then
            Label4.Text = nPedido
            nPedido = nPedido + 1
            SQLQuery("update variables set num_pedido='" & nPedido.ToString & "' where codigo=123", False)
            query = ("INSERT INTO pedido(id_pedido,id_mesa,rut,fecha_hora,estado) VALUES ('" & nPedido.ToString & "','" & Label2.Text & "', '" & Label3.Text & "', '" & Now.ToShortDateString.ToString & "', 'Pendiente' )")
            SQLQuery(query, False)


            query = ("INSERT INTO detalle_pedido(id_producto,id_pedido,descripcion,fecha_hora) VALUES ('" & sender.name & "', '" & nPedido.ToString & "', '','" & Now.ToShortDateString.ToString & "' )")
            SQLQuery(query, False)
            llenarDetallePedidos()
        Else
            query = ("INSERT INTO detalle_pedido(id_producto,id_pedido,descripcion,fecha_hora) VALUES ('" & sender.name & "', '" & nPedido.ToString & "', '','" & Now.ToShortDateString.ToString & "' )")
            SQLQuery(query, False)
            llenarDetallePedidos()

        End If
    End Sub

    Private Sub llenarDetallePedidos()
        DataGridView3.Rows.Clear()
        SQLQuery("SELECT dbo.detalle_pedido.id_detalle_pedido,dbo.detalle_pedido.id_producto, dbo.producto.nombre as nombreP, dbo.producto.precio FROM dbo.detalle_pedido INNER JOIN dbo.producto ON dbo.detalle_pedido.id_producto = dbo.producto.id_producto where id_pedido='" & nPedido.ToString & "'", True)
        If lector.HasRows Then
            While lector.Read
                DataGridView3.Rows.Add(lector.Item("id_detalle_pedido"), lector.Item("id_producto"), lector.Item("nombreP"), lector.Item("precio"), "")
            End While
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SQLQuery("DELETE FROM detalle_pedido WHERE id_detalle_pedido='" & LblIdPedido.Text & "' ", False)

        Button2.Enabled = False


        llenarDetallePedidos()


    End Sub

    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick
        If e.RowIndex = -1 Then

        Else
            Button2.Enabled = True
            LblIdPedido.Text = Me.DataGridView3.Rows(e.RowIndex).Cells(0).Value
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub DataGridView3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentDoubleClick
        If e.RowIndex = -1 Then

        Else
            SQLQuery("select * from detalle_pedido where id_detalle_pedido='" & Me.DataGridView3.Rows(e.RowIndex).Cells(0).Value & "'", True)
            If lector.HasRows Then
                While lector.Read
                    descripcion_pedido.TextBox1.Text = lector.Item("descripcion")
                End While
            End If
            descripcion_pedido.Label1.Text = Me.DataGridView3.Rows(e.RowIndex).Cells(0).Value
            descripcion_pedido.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        PrintDocument1.Print()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim titulo As Font = New Drawing.Font("Arial", 14)
        Dim sector As Font = New Drawing.Font("Arial", 16)
        Dim texto As Font = New Drawing.Font("Arial", 11)
        Dim margenizq As Integer
        Dim margensup As Integer
        e.Graphics.DrawString("Pedido n° " & nPedido.ToString, titulo, Brushes.Black, margenizq, margensup)
        SQLQuery("SELECT dbo.detalle_pedido.id_detalle_pedido,dbo.detalle_pedido.id_producto, dbo.producto.nombre as nombreP, dbo.producto.precio FROM dbo.detalle_pedido INNER JOIN dbo.producto ON dbo.detalle_pedido.id_producto = dbo.producto.id_producto where id_pedido='" & nPedido.ToString & "'", True)
        If lector.HasRows Then
            margensup = margensup + 25
            e.Graphics.DrawString("Producto", texto, Brushes.Black, margenizq, (margensup))
            e.Graphics.DrawString("Precio", texto, Brushes.Black, (margenizq + 100), (margensup))
            While lector.Read
                margensup = margensup + 25
                e.Graphics.DrawString(lector.Item("nombreP").ToString, texto, Brushes.Black, (margenizq), margensup)
                e.Graphics.DrawString(lector.Item("precio").ToString, texto, Brushes.Black, (margenizq + 100), margensup)
            End While
        End If

    End Sub
End Class