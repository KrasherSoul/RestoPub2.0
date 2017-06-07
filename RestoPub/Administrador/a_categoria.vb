Public Class a_categoria
    Private Sub a_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        query = ("INSERT INTO categoria (nombre,familia) VALUES ('" & TxtNombre.Text & "', '" & CmbFamilia.SelectedItem & "')")
        SQLQuery(query, False)
        a_inicio.Visible = True
        Me.Hide()

    End Sub


End Class