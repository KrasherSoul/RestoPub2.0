Public Class a_inicio
    Dim btn As Button
    Dim tlt As ToolTip
    Dim XY As Point
    Dim i As Integer
    Dim tp As Integer
    Dim lt As Integer
    Dim edicion As Boolean
    Dim eliminar As Boolean
    Dim id_mesa As Integer = 0
    Dim num_mesas As Integer = 1
    Dim cierre As Boolean = False
    Private Sub CrearBoton()
        Dim sql As String

        btn = New System.Windows.Forms.Button
        btn.Width = 60
        btn.Height = 60
        btn.Left = lt
        btn.Top = tp
        btn.Name = "Mesa " & i
        btn.Font = New Font(btn.Name, 20, btn.Font.Style, btn.Font.Unit)
        btn.Text = num_mesas
        btn.Tag = id_mesa
        btn.BackColor = Control.DefaultBackColor
        sql = "insert into mesa (id_mesa, num_mesa, fecha, estado, x, y) values ('" & btn.Tag & "','" & btn.Text & "','" & Date.Today & "','vacia','" & lt & "','" & tp & "')"
        SQLQuery(sql, False)
        num_mesas = num_mesas + 1
        i = i + 1
        id_mesa = id_mesa + 1
        sql = "update variables set id_mesa='" & id_mesa & "' where codigo=123"
        SQLQuery(sql, False)
        sql = "update variables set num_mesa='" & num_mesas & "' where codigo=123"
        SQLQuery(sql, False)
        AddHandler btn.MouseDown, AddressOf buttonMouseDown
        AddHandler btn.MouseMove, AddressOf buttonMouseMove
        AddHandler btn.MouseUp, AddressOf buttonMouseUp
        AddHandler btn.MouseClick, AddressOf Click_boton
        Me.Controls.Add(btn)

    End Sub

    Private Sub Click_boton(sender As Object, e As EventArgs)
        Dim sql As String
        If cierre Then
            Venta.Show()
            Venta.Label1.Text = sender.text

        End If
        If edicion Then
            If eliminar Then
                Me.Controls.Remove(sender)
                sql = "update mesa set estado='desuso' where id_mesa= '" & sender.tag & "'"

                SQLQuery(sql, False)
                num_mesas = num_mesas - 1
                sql = "update variables set numMesas='" & num_mesas & "' where codigo=123"

                i = i - 1
            End If
        Else
            l_pedidos.Text = sender.tag
            l_pedidos.Show()
            sender.forecolor = Color.Red

        End If

    End Sub

    Private Sub buttonMouseUp(sender As Object, e As MouseEventArgs)
        Dim b As Button = DirectCast(sender, Button)
        Dim sql As String

        btn.BackColor = Control.DefaultBackColor
        sql = "Update mesa SET x='" & sender.left & "', y= '" & sender.top & "' where id_mesa='" & sender.tag & "'"
        SQLQuery(sql,false)



    End Sub
    Private Sub buttonMouseDown(sender As Object, e As MouseEventArgs)
        XY.Y = MousePosition.Y - sender.top
        XY.X = MousePosition.X - sender.left

    End Sub
    Private Sub buttonMouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = Control.MouseButtons.Left Then

            If edicion = True Then
                sender.top = MousePosition.Y - XY.Y
                sender.left = MousePosition.X - XY.X
                Dim b As Button = DirectCast(sender, Button)
            End If

        End If
    End Sub
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
        Dim sql As String
        Dim sql2 As String
        sql = "select * from variables"
        SQLQuery(sql, True)
        If lector.HasRows Then
            While lector.Read
                id_mesa = lector.Item("id_mesa")
                num_mesas = lector.Item("num_mesa")
            End While
        End If
        'traer id_mesa ultima mesa agregada
        Top = 10
        Left = 10
        i = 1
        edicion = False
        eliminar = False
        BtnAgregar.Visible = False
        BtnEliminar.Visible = False
        BtnGuardar.Visible = False
        sql = "select id_mesa,x,y,num_mesa from mesa where estado='vacia'"
        SQLQuery(sql, True)
        If lector.HasRows Then
            While lector.Read
                btn = New System.Windows.Forms.Button
                btn.Width = 60
                btn.Height = 60
                btn.Left = lector.Item("x")
                btn.Top = lector.Item("y")
                btn.Name = "Mesa " & i
                btn.Font = New Font(btn.Name, 20, btn.Font.Style, btn.Font.Unit)
                btn.Text = lector.Item("num_mesa")
                btn.Tag = lector.Item("id_mesa")
                btn.BackColor = Control.DefaultBackColor

                AddHandler btn.MouseDown, AddressOf buttonMouseDown
                AddHandler btn.MouseMove, AddressOf buttonMouseMove
                AddHandler btn.MouseUp, AddressOf buttonMouseUp
                AddHandler btn.MouseClick, AddressOf Click_boton
                Me.Controls.Add(btn)

            End While
        End If

    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        a_categoria.Visible = True
        Me.Hide()
    End Sub

    Private Sub AgregarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductoToolStripMenuItem.Click
        a_producto.Visible = True
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        eliminar = False
        If edicion = True Then
            CrearBoton()

        Else
            MsgBox("Edicion deshabilitada", MsgBoxStyle.Exclamation, "Edicion deshabilitada")
        End If


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        eliminar = True
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        edicion = True
        eliminar = False
        BtnAgregar.Visible = True
        BtnEliminar.Visible = True
        BtnGuardar.Visible = True

    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        edicion = False
        eliminar = False
        BtnAgregar.Visible = False
        BtnEliminar.Visible = False
        BtnGuardar.Visible = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        edicion = False
        eliminar = False
    End Sub

    Private Sub FamiliaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FamiliaToolStripMenuItem.Click
        Me.Hide()
        a_familia.Show()
    End Sub

    Private Sub CerrarMesaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarMesaToolStripMenuItem.Click
        cierre = True
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Me.Hide()
        a_compra.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PruebaToolStripMenuItem.Click
        prueba.Show()
    End Sub

    Private Sub AsistenciaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsistenciaToolStripMenuItem.Click
        a_asistencia.Show()

        Me.Hide()

    End Sub
End Class