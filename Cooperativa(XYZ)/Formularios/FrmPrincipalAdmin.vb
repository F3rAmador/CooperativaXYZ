Public Class FrmPrincipalAdmin
    Dim EstadoMaximizar As Boolean
    Dim EstadoIngresar As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Public Sub InsertarFormularioEnPanel(ByVal FormularioHijo As Object)
        If PCentral.Controls.Count > 0 Then
            PCentral.Controls.RemoveAt(0)
        End If
        Dim Formulario As Form = TryCast(FormularioHijo, Form)
        FormularioHijo.TopLevel = False
        FormularioHijo.Dock = DockStyle.Fill
        PCentral.Controls.Add(FormularioHijo)
        PCentral.Tag = FormularioHijo
        FormularioHijo.show()
    End Sub
    Private Sub PMenu_MouseHover(sender As Object, e As EventArgs) Handles PMenu.MouseHover
        PbxIngresar.Visible = False
        PbxUsuario.Visible = False
        PbxSolicitudPrestamo.Visible = False
        PbxCuentaSocio.Visible = False
        PbxRegistroPrestamo.Visible = False
        Do While PMenu.Width < 81
            PMenu.Width += 5
            System.Threading.Thread.Sleep(10)
        Loop
        PbxIngresar.Visible = True
        PbxUsuario.Visible = True
        PbxSolicitudPrestamo.Visible = True
        PbxCuentaSocio.Visible = True
        PbxRegistroPrestamo.Visible = True
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoMaximizar = True
        EstadoIngresar = True
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        WindowState = WindowState.Minimized
    End Sub

    Private Sub PbxTipoPrestamo_Click_1(sender As Object, e As EventArgs) Handles PbxTipoPrestamo.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        LblTitulo.Text = "TIPO PRÉSTAMO"
        InsertarFormularioEnPanel(New FrmTipoPrestamo)
    End Sub

    Private Sub PbxIngresar_Click(sender As Object, e As EventArgs) Handles PbxIngresar.Click
        If EstadoIngresar = True Then
            PanelSub2.Visible = True
            PanelSub3.Visible = True
            PanelSub4.Visible = True
            EstadoIngresar = False
        Else
            PanelSub2.Visible = False
            PanelSub3.Visible = False
            PanelSub4.Visible = False
            EstadoIngresar = True
        End If

    End Sub

    Private Sub PCentral_MouseHover(sender As Object, e As EventArgs) Handles PCentral.MouseHover
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
    End Sub

    Private Sub PbxNacionalidad_Click(sender As Object, e As EventArgs) Handles PbxNacionalidad.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        LblTitulo.Text = "NACIONALIDAD"
        InsertarFormularioEnPanel(New FrmNacionalidad)
    End Sub

    Private Sub PbxLugarTrabajo_Click(sender As Object, e As EventArgs) Handles PbxLugarTrabajo.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        LblTitulo.Text = "LUGAR DE TRABAJO"
        InsertarFormularioEnPanel(New FrmLugarTrabajo)
    End Sub

    Private Sub Pb_Click(sender As Object, e As EventArgs) Handles PbxSocio.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        LblTitulo.Text = "SOCIO"
        InsertarFormularioEnPanel(New FrmSocio)
    End Sub

    Private Sub PbxOficial_Click(sender As Object, e As EventArgs) Handles PbxOficial.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        LblTitulo.Text = "OFICIAL"
        InsertarFormularioEnPanel(New FrmOficial)
    End Sub



    Private Sub PbxFinalidadPrestamo_Click(sender As Object, e As EventArgs) Handles PbxFinalidadPrestamo.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        LblTitulo.Text = "FINALIDAD DE PRESTAMO"
        InsertarFormularioEnPanel(New FrmFinalidadPrestamo)
    End Sub

    Private Sub PbxUsuario_Click(sender As Object, e As EventArgs) Handles PbxUsuario.Click
        PUsuario.Visible = True
    End Sub



    Private Sub PUsuario_MouseLeave(sender As Object, e As EventArgs) Handles PUsuario.MouseLeave
        PUsuario.Visible = False
    End Sub

    Private Sub PbxSolicitudPrestamo_Click(sender As Object, e As EventArgs) Handles PbxSolicitudPrestamo.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        LblTitulo.Text = "SOLICITUD DE PRÉSTAMO"
        InsertarFormularioEnPanel(New FrmSolicitudPrestamo)
    End Sub

    Private Sub PbxCuentaSocio_Click(sender As Object, e As EventArgs) Handles PbxCuentaSocio.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        ' LblTitulo.Text = "CUENTA SOCIO"
        ' InsertarFormularioEnPanel(New FrmCuentaSocio)
    End Sub

    Private Sub PbxRegistroPrestamo_Click(sender As Object, e As EventArgs) Handles PbxRegistroPrestamo.Click
        PUsuario.Visible = False
        PanelSub2.Visible = False
        PanelSub3.Visible = False
        PanelSub4.Visible = False
        Do While PMenu.Width > 9
            PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
        EstadoIngresar = True
        ' LblTitulo.Text = "SOLICITUD DE PRÉSTAMO"
        ' InsertarFormularioEnPanel(New FrmSolicitudPrestamo)
    End Sub
End Class