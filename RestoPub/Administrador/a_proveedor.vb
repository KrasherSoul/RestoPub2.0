Public Class a_proveedor

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        query = ("INSERT INTO proveedor (nombre,apellido, rut, verificador,ciudad,direccion,correo,telefono1,telefono2,estado) VALUES ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "', '" & TxtRut.Text & "', '" & TxtVerificador.Text & "', '" & TxtCiudad.Text & "','" & TxtDireccion.Text & "' ,'" & TxtCorreo.Text & "', '" & TxtTelefono1.Text & "','" & TxtTelefono2.Text & "', '1' )")
        SQLQuery(query, False)
        MsgBox(query)
        cargar_proveedor()
    End Sub

    Private Sub cargar_proveedor()
        dg_proveedor.Rows.Clear()
        SQLQuery("SELECT rut, verificador, nombre, apellido, concat(rut,'-',verificador) as rutc, ciudad, direccion, correo, telefono1, telefono2 FROM proveedor where estado = '1'", True)
        If lector.HasRows Then
            While lector.Read
                dg_proveedor.Rows.Add(lector.Item("rut"), lector.Item("verificador"), lector.Item("nombre"), lector.Item("apellido"), lector.Item("rutc"), lector.Item("ciudad"), lector.Item("direccion"), lector.Item("correo"), lector.Item("telefono1"), lector.Item("telefono2"), "Ver datos", "Modificar", "Eliminar")
            End While
        End If
    End Sub

    Private Sub a_proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_proveedor()

    End Sub

    Private Sub dg_proveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_proveedor.CellContentClick
        If e.ColumnIndex = 10 Then
            Label15.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(0).Value
            TxtNombre.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(2).Value
            TxtApellido.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(3).Value
            TxtRut.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(0).Value
            TxtVerificador.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(1).Value
            TxtCiudad.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(5).Value
            TxtDireccion.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(6).Value
            TxtCorreo.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(7).Value
            TxtTelefono1.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(8).Value
            TxtTelefono2.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(9).Value
        End If

        If e.ColumnIndex = 11 Then
            Label15.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(0).Value
            TxtNombre.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(2).Value
            TxtApellido.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(3).Value
            TxtRut.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(0).Value
            TxtVerificador.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(1).Value
            TxtCiudad.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(5).Value
            TxtDireccion.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(6).Value
            TxtCorreo.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(7).Value
            TxtTelefono1.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(8).Value
            TxtTelefono2.Text = Me.dg_proveedor.Rows(e.RowIndex).Cells(9).Value
        End If

        Dim pregunta As String
        If e.ColumnIndex = 12 Then
            pregunta = MsgBox("¿Esta Seguro que quiere eliminar a " & dg_proveedor(2, e.RowIndex).Value.ToString & " " & dg_proveedor(3, e.RowIndex).Value.ToString & " ?", vbYesNo)
            If pregunta = vbYes Then
                SQLQuery("UPDATE proveedor SET estado = '0' WHERE rut = " & Me.dg_proveedor.Rows(e.RowIndex).Cells(0).Value, False)
                MsgBox("El cliente ha sido eliminado")
                cargar_proveedor()
            Else
                cargar_proveedor()
            End If
        End If




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SQLQuery("UPDATE proveedor SET rut = '" & TxtRut.Text & "', nombre = '" & TxtNombre.Text & "', apellido = '" & TxtApellido.Text & "', verificador = '" & TxtVerificador.Text & "', ciudad = '" & TxtCiudad.Text & "', direccion = '" & TxtDireccion.Text & "', correo = '" & TxtCorreo.Text & "', telefono1 = '" & TxtTelefono1.Text & "', telefono2 = '" & TxtTelefono2.Text & "' WHERE rut = '" & Label15.Text & "'", False)
        cargar_proveedor()

    End Sub
End Class