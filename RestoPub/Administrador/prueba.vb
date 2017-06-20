Public Class prueba

    Private Sub prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mifecha As Date
        MsgBox(PrimerDiaDelMes(mifecha.Now) + " " + UltimoDiaDelMes(mifecha.Now))
    End Sub

    'para saber el primer dia del mes 
    Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    'para saber el ultimo dia del mes
    Function UltimoDiaDelMes(ByVal dtmFecha As Date) As Date
        UltimoDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha) + 1, 0)
    End Function

End Class

