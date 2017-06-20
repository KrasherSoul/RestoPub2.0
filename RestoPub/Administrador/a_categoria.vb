Public Class a_categoria

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim query As String
        query = ("INSERT INTO categoria (nombre,id_familia) VALUES ('" & TxtNombre.Text & "', '" & CmbFamilia.SelectedIndex & "')")
        SQLQuery(query, False)
        a_inicio.Visible = True
        Me.Hide()

    End Sub

    Private Sub a_categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FamiliaTableAdapter.Fill(Me.RestobarDataSet2.familia)

    End Sub
End Class