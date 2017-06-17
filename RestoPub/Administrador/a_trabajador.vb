Imports System.Data
Imports System.Data.SqlClient

Public Class a_trabajador
    Private cn As SqlConnection
    Private da As SqlDataAdapter
    Dim conexion As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        query = ("INSERT INTO trabajador (nombre,apellido, rut, verificador, fecha_nacimiento,ciudad,direccion,correo,telefono1,telefono2,id_cargo ,estado) VALUES ('" & TxtNombre.Text & "', '" & TxtApellido.Text & "', '" & TxtRut.Text & "', '" & TxtVerificador.Text & "', '" & DtFechaNac.Value.ToString & "', '" & TxtCiudad.Text & "','" & TxtDireccion.Text & "' ,'" & TxtCorreo.Text & "', '" & TxtTelefono1.Text & "','" & TxtTelefono2.Text & "', '" & Label11.Text & "', '1' )")
        SQLQuery(query, False)
        If CheckBox1.Checked = True Then
            query = ("INSERT INTO usuario (rut,usuario,pass,estado) VALUES ('" & TxtRut.Text & "', '" & TxtUsuario.Text & "', '" & TxtPass.Text & "', '1' )")
            SQLQuery(query, False)
        End If
        MsgBox("El trabajador se ha agregado con exito!.")
        cargar_trabajador()
    End Sub

    Private Sub a_trabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsuario.Enabled = False
        TxtPass.Enabled = False
        cargar_trabajador()
        'TODO: esta línea de código carga datos en la tabla 'RestobarDataSet2.cargo' Puede moverla o quitarla según sea necesario.
        Me.CargoTableAdapter.Fill(Me.RestobarDataSet.cargo)
        ComboBox1.Text = "Seleccione un cargo"
    End Sub

    Public Sub cargar_trabajador()
        dg_trabajador.Rows.Clear()
        SQLQuery("SELECT trabajador.rut, trabajador.verificador, trabajador.nombre, trabajador.apellido, concat(trabajador.rut,'-',trabajador.verificador) as rutc, trabajador.fecha_nacimiento, trabajador.ciudad, trabajador.direccion, trabajador.correo, trabajador.telefono1, trabajador.telefono2, cargo.nombre AS cargo FROM cargo INNER JOIN trabajador ON cargo.id_cargo = trabajador.id_cargo where trabajador.estado = '1'", True)
        If lector.HasRows Then
            While lector.Read
                dg_trabajador.Rows.Add(lector.Item("rut"), lector.Item("verificador"), lector.Item("nombre"), lector.Item("apellido"), lector.Item("rutc"), lector.Item("fecha_nacimiento"), lector.Item("ciudad"), lector.Item("direccion"), lector.Item("correo"), lector.Item("telefono1"), lector.Item("telefono2"), lector.Item("cargo"), "Ver datos", "Modificar", "Eliminar")
            End While
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        llenar_combobox()
    End Sub

    Private Sub dg_trabajador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_trabajador.CellContentClick
        If e.ColumnIndex = 12 Then
            Label15.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(0).Value
            TxtNombre.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(2).Value
            TxtApellido.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(3).Value
            TxtRut.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(0).Value
            TxtVerificador.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(1).Value
            DtFechaNac.Value = Me.dg_trabajador.Rows(e.RowIndex).Cells(5).Value
            TxtCiudad.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(6).Value
            TxtDireccion.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(7).Value
            TxtCorreo.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(8).Value
            TxtTelefono1.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(9).Value
            TxtTelefono2.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(10).Value
            ComboBox1.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(11).Value
            llenar_combobox()
        End If

        If e.ColumnIndex = 13 Then
            Label15.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(0).Value
            TxtNombre.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(2).Value
            TxtApellido.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(3).Value
            TxtRut.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(0).Value
            TxtVerificador.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(1).Value
            DtFechaNac.Value = Me.dg_trabajador.Rows(e.RowIndex).Cells(5).Value
            TxtCiudad.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(6).Value
            TxtDireccion.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(7).Value
            TxtCorreo.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(8).Value
            TxtTelefono1.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(9).Value
            TxtTelefono2.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(10).Value
            ComboBox1.Text = Me.dg_trabajador.Rows(e.RowIndex).Cells(11).Value
            llenar_combobox()
        End If

        Dim pregunta As String
        If e.ColumnIndex = 14 Then
            pregunta = MsgBox("¿Esta Seguro que quiere eliminar a " & dg_trabajador(2, e.RowIndex).Value.ToString & " " & dg_trabajador(3, e.RowIndex).Value.ToString & " ?", vbYesNo)
            If pregunta = vbYes Then
                SQLQuery("UPDATE trabajador SET estado = '0' WHERE rut = " & Me.dg_trabajador.Rows(e.RowIndex).Cells(0).Value, False)
                MsgBox("El cliente ha sido eliminado")
                cargar_trabajador()
            Else
                cargar_trabajador()
            End If
        End If
    End Sub

    Private Sub llenar_combobox()
        Dim query As String
        Label11.Text = ComboBox1.SelectedValue.ToString
        query = ("select sueldo from cargo where id_cargo = " & Label11.Text)
        SQLQuery(query, True)
        If lector.Read() Then
            Label12.Text = lector("sueldo").ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SQLQuery("UPDATE trabajador SET rut = '" & TxtRut.Text & "', id_cargo = '" & Label11.Text & "', nombre = '" & TxtNombre.Text & "', apellido = '" & TxtApellido.Text & "', verificador = '" & TxtVerificador.Text & "', fecha_nacimiento = '" & DtFechaNac.Value & "', ciudad = '" & TxtCiudad.Text & "', direccion = '" & TxtDireccion.Text & "', correo = '" & TxtCorreo.Text & "', telefono1 = '" & TxtTelefono1.Text & "', telefono2 = '" & TxtTelefono2.Text & "' WHERE rut = '" & Label15.Text & "'", False)
        cargar_trabajador()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtUsuario.Enabled = True
            TxtPass.Enabled = True
        Else
            TxtUsuario.Enabled = False
            TxtPass.Enabled = False
        End If
    End Sub
End Class