Imports System.Data
Imports System.Data.SqlClient

Public Class a_producto
    Private cn As SqlConnection
    Private da As SqlDataAdapter
    Dim conexion As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        query = ("INSERT INTO producto (id_categoria,nombre,precio,cantidad,descripcion) VALUES ('" & CmbCategoria.SelectedValue & "', '" & TxtNombre.Text & "','" & TxtPrecio.Text & "', '" & TxtCantidad.Text & "','" & RTxtDescripcion.Text & "')")
        SQLQuery(query, False)
        MsgBox(query)
        cargar_producto()
    End Sub

    Public Sub cargar_producto()
        dg_productos.Rows.Clear()
        SQLQuery("SELECT producto.id_producto, producto.nombre, producto.precio, producto.cantidad, producto.descripcion, categoria.nombre AS categoria FROM categoria INNER JOIN producto ON categoria.id_categoria = producto.id_categoria", True)
        If lector.HasRows Then
            While lector.Read
                dg_productos.Rows.Add(lector.Item("id_producto"), lector.Item("nombre"), lector.Item("categoria"), lector.Item("precio"), lector.Item("cantidad"), lector.Item("descripcion"), "Ver datos", "Modificar", "Eliminar")
            End While
        End If
    End Sub

    Private Sub a_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RestobarDataSet1.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.RestobarDataSet1.categoria)
        cargar_producto()


    End Sub

    Private Sub dg_productos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_productos.CellContentClick
        If e.ColumnIndex = 6 Then
            TxtNombre.Text = Me.dg_productos.Rows(e.RowIndex).Cells(1).Value
            CmbCategoria.Text = Me.dg_productos.Rows(e.RowIndex).Cells(2).Value
            TxtPrecio.Text = Me.dg_productos.Rows(e.RowIndex).Cells(3).Value
            TxtCantidad.Text = Me.dg_productos.Rows(e.RowIndex).Cells(4).Value
            RTxtDescripcion.Text = Me.dg_productos.Rows(e.RowIndex).Cells(5).Value
        End If

        If e.ColumnIndex = 7 Then
            Label3.Text = Me.dg_productos.Rows(e.RowIndex).Cells(0).Value
            TxtNombre.Text = Me.dg_productos.Rows(e.RowIndex).Cells(1).Value
            CmbCategoria.SelectedText = Me.dg_productos.Rows(e.RowIndex).Cells(2).Value
            TxtPrecio.Text = Me.dg_productos.Rows(e.RowIndex).Cells(3).Value
            TxtCantidad.Text = Me.dg_productos.Rows(e.RowIndex).Cells(4).Value
            RTxtDescripcion.Text = Me.dg_productos.Rows(e.RowIndex).Cells(5).Value
        End If

        Dim pregunta As String
        If e.ColumnIndex = 8 Then
            pregunta = MsgBox("¿Esta Seguro que quiere eliminar a " & dg_productos(1, e.RowIndex).Value.ToString & " ?", vbYesNo)
            If pregunta = vbYes Then
                SQLQuery("UPDATE trabajador SET estado = '0' WHERE rut = " & Me.dg_productos.Rows(e.RowIndex).Cells(0).Value, False)
                MsgBox("El cliente ha sido eliminado")
                cargar_producto()
            Else
                cargar_producto()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label6.Text = CmbCategoria.SelectedValue
        SQLQuery("UPDATE producto SET nombre = '" & TxtNombre.Text & "', id_categoria = '" & Label6.Text & "', precio = '" & TxtPrecio.Text & "', cantidad = '" & TxtCantidad.Text & "', descripcion = '" & RTxtDescripcion.Text & "' WHERE id_producto = '" & Label3.Text & "'", False)
        cargar_producto()
    End Sub

    Private Sub CmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCategoria.SelectedIndexChanged

    End Sub
End Class