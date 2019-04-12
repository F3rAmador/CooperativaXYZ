Public Class FrmRegistroDePrestamo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BtnBuscarTipoPrestamo_Click(sender As Object, e As EventArgs) Handles BtnBuscarTipoPrestamo.Click
        FrmBuscarTipoPrestamo.ShowDialog()
    End Sub


End Class