Imports System.Data.SqlClient

Public Class a_asistencia

    Dim conexion As SqlConnection = New SqlConnection("server=localhost; user id=pruebasTesis; password=pruebastesis; database=restobar")

    Private Sub a_asistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_grid()
    End Sub

    Private Sub llenar_grid()

        dg_asistencia.Rows.Clear()
        SQLQuery("SELECT trabajador.rut, trabajador.nombre, trabajador.apellido, concat(trabajador.rut,'-',trabajador.verificador) as rutc , cargo.nombre AS Cargo FROM cargo INNER JOIN trabajador ON cargo.id_cargo = trabajador.id_cargo", True)
        If lector.HasRows Then
            While lector.Read
                dg_asistencia.Rows.Add(lector.Item("rut"), lector.Item("nombre"), lector.Item("apellido"), lector.Item("rutc"), lector.Item("cargo"), DateTime.Now.ToString("dd/MM/yyyy"))
            End While
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        magia()

    End Sub


    Private Sub magia()
        Dim agregar As SqlCommand = New SqlCommand("INSERT INTO asistencia (rut,fecha,estado)  VALUES (@rut,@fecha,@estado)", conexion)
        conexion.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            For Each fila In dg_asistencia.Rows
                agregar.Parameters.Clear()
                agregar.Parameters.AddWithValue("@rut", Convert.ToString(fila.Cells("rut").Value))
                agregar.Parameters.AddWithValue("@id_categoria", Convert.ToString(fila.Cells("fecha").Value))
                agregar.Parameters.AddWithValue("@estado", Convert.ToString(fila.Cells("estado").Value))
                agregar.ExecuteNonQuery()
            Next
            MsgBox("si")
        Catch ex As Exception
            MsgBox("no")
        Finally
            conexion.Close()
        End Try
    End Sub




    Private Sub dg_asistencia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_asistencia.CellContentClick
        If e.ColumnIndex = 7 Then
            'Dim value As Boolean = CType(Me.dg_asistencia.CurrentCell.EditedFormattedValue, Boolean)
            'If value = True Then
            '    Me.dg_asistencia.Rows(e.RowIndex).Cells(6).Value = "1"

            'Else
            '    Me.dg_asistencia.Rows(e.RowIndex).Cells(6).Value = "0"
            'End If

            Dim row As DataGridViewRow = dg_asistencia.Rows(e.RowIndex)
            Dim value As DataGridViewCheckBoxCell = TryCast(Row.Cells(7), DataGridViewCheckBoxCell)
            If Convert.ToBoolean(value.Value) Then
                row.DefaultCellStyle.BackColor = Color.Green
            Else
                row.DefaultCellStyle.BackColor = Color.Red

            End If

        End If
    End Sub
End Class