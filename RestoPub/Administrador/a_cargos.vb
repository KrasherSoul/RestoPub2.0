Public Class a_cargos

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        query = ("INSERT INTO cargo (nombre,sueldo) VALUES ('" & TxtNombre.Text & "', '" & TxtSueldo.Text & "')")
        SQLQuery(query, False)
        MsgBox(query)
    End Sub

    Private Sub a_cargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class