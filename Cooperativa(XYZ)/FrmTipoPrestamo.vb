Public Class FrmTipoPrestamo
    Private Sub ChkVer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.CheckState = CheckState.Checked Then
            LsvTipoPrestamo.Visible = True
        Else
            LsvTipoPrestamo.Visible = False
        End If
    End Sub


    Public Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FrmTipoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LsvTipoPrestamo.Visible = False
    End Sub

    Private Sub PCentarl_MouseHover(sender As Object, e As EventArgs) Handles PCentarl.MouseHover
        'Do While FrmPrincipal.PMenu.Width > 9
        ' FrmPrincipal.PMenu.Width -= 5
        ' System.Threading.Thread.Sleep(50)
        ' FrmPrincipal.PbxTipoPrestamo.Visible = False
        ' Loop
    End Sub


    Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs) Handles GroupBox1.MouseHover
        ' Do While FrmPrincipal.PMenu.Width > 9
        ' FrmPrincipal.PMenu.Width -= 5
        ' System.Threading.Thread.Sleep(50)
        ' FrmPrincipal.PbxTipoPrestamo.Visible = False
        ' Loop

    End Sub

    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
        ' FrmPrincipal.LblTitulo.Text = ""
        ' FrmPrincipal.InsertarFormularioEnPanel(New FrmBlanco)

    End Sub
End Class
