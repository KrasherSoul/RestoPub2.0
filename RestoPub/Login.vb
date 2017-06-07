Public Class Login

    Private Sub ingresar_button_Click(sender As Object, e As EventArgs) Handles ingresar_btn.Click
        If nombre_usuario_text.Text = "" Or pass_usuario_text.Text = "" Then
            MsgBox("Debe completar todos los datos solicitados.")
        Else
            SQLQuery("SELECT * FROM trabajador WHERE usuario = '" & nombre_usuario_text.Text & "' AND pass = '" & pass_usuario_text.Text & "' AND estado_usuario = '1'", True)
            If lector.HasRows Then
                a_inicio.Visible = True
                Me.Visible = False
            Else
                MsgBox("Los datos ingresados son incorrectos.")
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
