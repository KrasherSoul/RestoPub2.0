Public Class a_familia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        query = ("INSERT INTO familia (nombre) VALUES ('" & TextBox1.Text & "')")
        SQLQuery(query, False)
        a_inicio.Visible = True
        Me.Hide()
    End Sub
End Class