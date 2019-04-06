Imports System.Data.SqlClient

Public Class FrmTipoPrestamo

    Public Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FrmTipoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LsvTipoPrestamo.Visible = False
    End Sub

    'Private Sub PCentarl_MouseHover(sender As Object, e As EventArgs) Handles PCentarl.MouseHover
    '    Do While FrmPrincipal.PMenu.Width > 9
    '        FrmPrincipal.PMenu.Width -= 5
    '        System.Threading.Thread.Sleep(50)
    '        FrmPrincipal.PbxTipoPrestamo.Visible = False
    '    Loop
    'End Sub


    'Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs) Handles GroupBox1.MouseHover
    '    Do While FrmPrincipal.PMenu.Width > 9
    '        FrmPrincipal.PMenu.Width -= 5
    '        System.Threading.Thread.Sleep(50)
    '        FrmPrincipal.PbxTipoPrestamo.Visible = False
    '    Loop

    'End Sub

    'Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click
    '    Close()
    '    FrmPrincipal.LblTitulo.Text = ""
    '    FrmPrincipal.InsertarFormularioEnPanel(New FrmBlanco)

    'End Sub

    Private Sub ChkVer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged

        If ChkVer.CheckState = CheckState.Checked Then
            LsvTipoPrestamo.Visible = True
            MostrarTodo()
        Else
            LsvTipoPrestamo.Visible = False
        End If
    End Sub

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Salir As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        BtnCerrar.Enabled = Salir

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativo()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        HabilitarBotones(True, False, False, False, True)

        If ValidarTextBox() = True Then
            GuardarTipoPrestamo()
            Limpiar()
            HabilitarBotones(True, False, False, False, True)
            MostrarTodo()
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False, True)
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If

            Try
                Cn.Open()
                Using Cmd As New SqlCommand
                    With Cmd
                        .CommandText = "Sp_ActualizarTipoPrestamo"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Cn
                        .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 30).Value = TxtTipoPrestamo.Text
                        .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(TxtIdTipoPrestamo.Text)
                        .ExecuteNonQuery()

                        MessageBox.Show("Registro modificado satisfactoriamente", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End With
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al modificar el registro" + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
            MostrarTodo()
            Limpiar()
        End If

    End Sub

    Private Sub InvestigarCorrelativo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarTIpoPrestamo As New SqlCommand("Sp_InvestigarCorrelativo", Cn)

            ListarTIpoPrestamo.CommandType = CommandType.StoredProcedure
            ListarTIpoPrestamo.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "TipoPrestamo"

            Dim ListarTipoPrestamoR As SqlDataReader
            Cn.Open()
            ListarTipoPrestamoR = ListarTIpoPrestamo.ExecuteReader()

            If ListarTipoPrestamoR.Read = True Then
                If ListarTipoPrestamoR("CorrelativoTabla") Is DBNull.Value Then
                    TxtIdTipoPrestamo.Text = 1
                Else
                    TxtIdTipoPrestamo.Text = ListarTipoPrestamoR("CorrelativoTabla").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos." + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()

        End Try
    End Sub

    Private Sub GuardarTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@TipoPrestamo", SqlDbType.NVarChar, 30).Value = TxtTipoPrestamo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar el Tipo de Préstamo", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using Cmd As New SqlCommand
            Cn.Open()

            Try
                With Cmd
                    .CommandText = "Sp_MostrarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerTipoPrestamo As SqlDataReader
                VerTipoPrestamo = Cmd.ExecuteReader

                LsvTipoPrestamo.Items.Clear()

                While VerTipoPrestamo.Read = True
                    With LsvTipoPrestamo.Items.Add(VerTipoPrestamo("IdTipoPrestamo").ToString)
                        .SubItems.Add(VerTipoPrestamo("TipoPrestamo")).ToString()
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
            Cn.Close()
        End Using

    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtTipoPrestamo.Text = Nothing Then
            EpMensaje.SetError(TxtTipoPrestamo, "Tiene que ingresar el tipo de prestamo")
            TxtTipoPrestamo.Focus()
            TxtTipoPrestamo.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtTipoPrestamo, "")
        End If

        Return Estado

    End Function

    Private Sub Limpiar()
        TxtIdTipoPrestamo.Text = Nothing
        TxtTipoPrestamo.Text = Nothing

    End Sub

    Private Sub TxtTipoPrestamo_TextChanged(sender As Object, e As EventArgs) Handles TxtTipoPrestamo.TextChanged
        If TxtTipoPrestamo.Text <> Nothing Then
            EpMensaje.SetError(TxtTipoPrestamo, "")
            TxtTipoPrestamo.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        HabilitarBotones(False, False, True, True, True)
        TxtIdTipoPrestamo.Text = LsvTipoPrestamo.FocusedItem.SubItems(0).Text
        TxtTipoPrestamo.Text = LsvTipoPrestamo.FocusedItem.SubItems(1).Text
    End Sub

    Private Sub EliminarTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer

                    Id = CInt(LsvTipoPrestamo.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el registro", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click
        EliminarTipoPrestamo()
        MostrarTodo()
        HabilitarBotones(True, False, False, False, True)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True)
        Limpiar()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub Nacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, True)
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        HabilitarBotones(False, False, True, True, True)
        TxtIdTipoPrestamo.Text = LsvTipoPrestamo.FocusedItem.SubItems(0).Text
        TxtTipoPrestamo.Text = LsvTipoPrestamo.FocusedItem.SubItems(1).Text
    End Sub

End Class
