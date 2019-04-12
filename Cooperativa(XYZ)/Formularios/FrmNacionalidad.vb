Imports System.Data.SqlClient

Public Class FrmNacionalidad

    ' Habilita los botones
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar

    End Sub

    ' Seleccionamos los botones a habilitar
    Private Sub FrmNacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False)
        MostrarTodo()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativo()
        TxtNacionalidad.ReadOnly = False

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarTextBox() = True Then
            GuardarNacionalidad()
            Limpiar()
            HabilitarBotones(True, False, False, False)
            MostrarTodo()
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarTextBox() = True Then
            ActualizarNacionalidad()
            Limpiar()
            HabilitarBotones(True, False, False, False)
            MostrarTodo()
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False)
        Limpiar()

    End Sub

    Private Sub Limpiar()
        TxtIdNacionalidad.Text = Nothing
        TxtNacionalidad.Text = Nothing

        EpMensaje.SetError(TxtNacionalidad, "")
        TxtNacionalidad.BackColor = Color.White

    End Sub


    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using Cmd As New SqlCommand
            Cn.Open()

            Try
                With Cmd
                    .CommandText = "Sp_MostrarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerCargo As SqlDataReader
                VerCargo = Cmd.ExecuteReader

                LsvLugarTrabajo.Items.Clear()

                While VerCargo.Read = True
                    With LsvLugarTrabajo.Items.Add(VerCargo("IdNacionalidad").ToString)
                        .SubItems.Add(VerCargo("Nacionalidad")).ToString()
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
            Cn.Close()
        End Using

    End Sub

    Private Sub InvestigarCorrelativo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim ListarCargo As New SqlCommand("Sp_InvestigarCorrelativo", Cn)

            ListarCargo.CommandType = CommandType.StoredProcedure
            ListarCargo.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "Nacionalidad"

            Dim ListarCargoR As SqlDataReader
            Cn.Open()
            ListarCargoR = ListarCargo.ExecuteReader()

            If ListarCargoR.Read = True Then
                If ListarCargoR("IdTabla") Is DBNull.Value Then
                    TxtIdNacionalidad.Text = 1
                Else
                    TxtIdNacionalidad.Text = ListarCargoR("IdTabla").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos." + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()

        End Try
    End Sub

    Private Sub GuardarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = TxtNacionalidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar la naciolnalidad", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub ActualizarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = TxtIdNacionalidad.Text
                    .Parameters.Add("@Nacionalidad", SqlDbType.NVarChar, 50).Value = TxtNacionalidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al modificar la nacionalidad", "Cooperativa XZY" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer

                    Id = CInt(LsvLugarTrabajo.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al eliminar el registro" + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtNacionalidad.Text = Nothing Then
            EpMensaje.SetError(TxtNacionalidad, "Tiene que ingresar la nacionalidad")
            TxtNacionalidad.Focus()
            TxtNacionalidad.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtNacionalidad, "")
            TxtNacionalidad.BackColor = Color.White
        End If

        Return Estado

    End Function

    Private Sub TxtNacionalidad_TextChanged(sender As Object, e As EventArgs) Handles TxtNacionalidad.TextChanged
        If TxtNacionalidad.Text <> Nothing Then
            EpMensaje.SetError(TxtNacionalidad, "")
            TxtNacionalidad.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click
        EliminarNacionalidad()
        MostrarTodo()
        HabilitarBotones(True, False, False, False)
    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        HabilitarBotones(False, False, True, True)
        TxtNacionalidad.ReadOnly = False
        TxtIdNacionalidad.Text = LsvLugarTrabajo.FocusedItem.SubItems(0).Text
        TxtNacionalidad.Text = LsvLugarTrabajo.FocusedItem.SubItems(1).Text
    End Sub




    Private Sub PCentarl_MouseHover(sender As Object, e As EventArgs) Handles PCentarl.MouseHover
        FrmPrincipalAdmin.PanelSub1.Visible = False
        FrmPrincipalAdmin.PanelSub2.Visible = False
        FrmPrincipalAdmin.PanelSub3.Visible = False
        FrmPrincipalAdmin.PanelSub4.Visible = False
        Do While FrmPrincipalAdmin.PMenu.Width > 9
            FrmPrincipalAdmin.PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
    End Sub

    Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs) Handles GroupBox1.MouseHover
        FrmPrincipalAdmin.PanelSub1.Visible = False
        FrmPrincipalAdmin.PanelSub2.Visible = False
        FrmPrincipalAdmin.PanelSub3.Visible = False
        FrmPrincipalAdmin.PanelSub4.Visible = False
        Do While FrmPrincipalAdmin.PMenu.Width > 9
            FrmPrincipalAdmin.PMenu.Width -= 5
            System.Threading.Thread.Sleep(10)
            ' PbxAlimento.Visible = False
        Loop
    End Sub
End Class