Imports System.Data.SqlClient

Public Class a_compra

    Dim conexion As SqlConnection = New SqlConnection("server=localhost; user id=pruebasTesis; password=pruebastesis; database=restobar")

    Private Sub a_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RestobarDataSet1.categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.RestobarDataSet1.categoria)
        'TODO: esta línea de código carga datos en la tabla 'RestobarDataSet4.proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.RestobarDataSet4.proveedor)
        verificarIdCompra()
    End Sub

    Private Sub verificarIdCompra()
        SQLQuery("SELECT id_compra from compra where id_compra = (select max(id_compra) from compra)", True)
        If lector.HasRows Then
            While lector.Read
                Label1.Text = lector("id_compra")
            End While
        End If
        If Label1.Text = "id_de_la_compra" Then
            Label1.Text = "1"
        Else
            Label1.Text = Label1.Text + 1
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles textCodig.TextChanged
        SQLQuery("SELECT dbo.producto.nombre as nombreP, dbo.categoria.nombre AS nombre, producto.precio_neto, producto.descripcion, producto.cantidad FROM dbo.categoria INNER JOIN dbo.producto ON dbo.categoria.id_categoria = dbo.producto.id_categoria where codigo_barra = '" & textCodig.Text & "'", True)
        If lector.HasRows Then
            While lector.Read
                ComboBox2.Text = lector("nombre")
                textnombre.Text = lector("nombreP")
                textneto.Text = lector("precio_neto")
                Label5.Text = lector("cantidad")
                textdescrip.Text = lector("descripcion")
                lblPrincipal.Text = "ACTUALIZAR"
            End While
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles textcantidad.TextChanged
        Label6.Text = Val(Label5.Text) + Val(textcantidad.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lblPrincipal.Text = "PRINCIPAL" Then
            DataGridView1.Rows.Add(textCodig.Text, ComboBox2.SelectedValue, textnombre.Text, textneto.Text, textcantidad.Text, textdescrip.Text)
            DataGridView2.Rows.Add(Label1.Text, textCodig.Text, textunitario.Text, textcantidad.Text, textdescrip.Text)
        Else
            DataGridView3.Rows.Add(textCodig.Text, ComboBox2.SelectedValue, textnombre.Text, textneto.Text, Label6.Text, textdescrip.Text)
            DataGridView2.Rows.Add(Label1.Text, textCodig.Text, textunitario.Text, textcantidad.Text, textdescrip.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SQLQuery("INSERT INTO compra (id_compra,rut,fecha_hora,total) VALUES ('" & Label1.Text & "','" & ComboBox1.SelectedValue & "','" & DateTimePicker1.Value.ToString & "', '" & TextBox6.Text & "')", False)
        magia1()
        magia2()
        magia3()
    End Sub

    Private Sub magia1()
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO producto (codigo_barra,id_categoria,nombre,precio_neto,cantidad,descripcion)  VALUES (@codigo_barra,@id_categoria,@nombre,@precio_neto,@cantidad,@descripcion)", conexion)
        conexion.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila In DataGridView1.Rows
                agregar.Parameters.Clear()
                agregar.Parameters.AddWithValue("@codigo_barra", Convert.ToString(fila.Cells("codigo_barra").Value))
                agregar.Parameters.AddWithValue("@id_categoria", Convert.ToString(fila.Cells("id_categoria").Value))
                agregar.Parameters.AddWithValue("@nombre", Convert.ToString(fila.Cells("nombre").Value))
                agregar.Parameters.AddWithValue("@precio_neto", Convert.ToString(fila.Cells("precio_neto").Value))
                agregar.Parameters.AddWithValue("@cantidad", Convert.ToString(fila.Cells("cantidad").Value))
                agregar.Parameters.AddWithValue("@descripcion", Convert.ToString(fila.Cells("descripcion").Value))
                agregar.ExecuteNonQuery()
            Next
            'MsgBox("si")
        Catch ex As Exception
            ' MsgBox("no")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub magia2()
        Dim agregar2 As SqlCommand = New SqlCommand("INSERT INTO detalle_compra (id_compra,codigo_barra,precio_unitario,cantidad) VALUES (@id_compra, @codigo_barra1, @precio_unitario1, @cantidad1)", conexion)
        conexion.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila In DataGridView2.Rows
                agregar2.Parameters.Clear()
                agregar2.Parameters.AddWithValue("@id_compra", Convert.ToString(fila.Cells("id_compra").Value))
                agregar2.Parameters.AddWithValue("@codigo_barra1", Convert.ToString(fila.Cells("codigo_barra1").Value))
                agregar2.Parameters.AddWithValue("@precio_unitario1", Convert.ToString(fila.Cells("precio_unitario1").Value))
                agregar2.Parameters.AddWithValue("@cantidad1", Convert.ToString(fila.Cells("cantidad1").Value))
                agregar2.ExecuteNonQuery()
            Next
            'MsgBox("si")
        Catch ex As Exception
            'MsgBox("no")
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub magia3()
        Dim actualizar As SqlCommand = New SqlCommand("UPDATE producto set cantidad = @cantidad3 where codigo_barra = @codigo_barra3 ", conexion)
        conexion.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila In DataGridView3.Rows
                actualizar.Parameters.Clear()
                actualizar.Parameters.AddWithValue("@cantidad3", Convert.ToString(fila.Cells("cantidad3").Value))
                actualizar.Parameters.AddWithValue("@codigo_barra3", Convert.ToString(fila.Cells("codigo_barra3").Value))
                actualizar.ExecuteNonQuery()
            Next
            ' MsgBox("si")
        Catch ex As Exception
            'MsgBox("no")
        Finally
            conexion.Close()
        End Try
    End Sub


End Class