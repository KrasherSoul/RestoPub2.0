Public Class form1

    Private Sub btn_adm_Click(sender As Object, e As EventArgs) Handles btn_adm.Click
        Login.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btn_caja_Click(sender As Object, e As EventArgs) Handles btn_caja.Click
        Login.Visible = True
        Me.Visible = False
    End Sub

    Private Sub btn_mesero_Click(sender As Object, e As EventArgs) Handles btn_mesero.Click
        Login.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class