Imports System.Data.SqlClient

Public Class FrmLugarTrabajo

    ' Habilita los botones
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar

    End Sub

    ' Seleccionamos los botones a habilitar
    Private Sub FrmLugarTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False)
        MostrarTodo()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativo()
        TxtLugarTrabajo.ReadOnly = False

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarTextBox() = True Then
            GuardarLugarTrabajo()
            Limpiar()
            HabilitarBotones(True, False, False, False)
            MostrarTodo()
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarTextBox() = True Then
            ActualizarLugarTrabajo()
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
        TxtIdLugarTrabajo.Text = Nothing
        TxtLugarTrabajo.Text = Nothing

        EpMensaje.SetError(TxtLugarTrabajo, "")
        TxtLugarTrabajo.BackColor = Color.White

    End Sub


    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using Cmd As New SqlCommand
            Cn.Open()

            Try
                With Cmd
                    .CommandText = "Sp_MostrarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerLugarTrabajo As SqlDataReader
                VerLugarTrabajo = Cmd.ExecuteReader

                LsvLugarTrabajo.Items.Clear()

                While VerLugarTrabajo.Read = True
                    With LsvLugarTrabajo.Items.Add(VerLugarTrabajo("IdLugarTrabajo").ToString)
                        .SubItems.Add(VerLugarTrabajo("LugarTrabajo")).ToString()
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
            ListarCargo.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "LugarTrabajo"

            Dim ListarCargoR As SqlDataReader
            Cn.Open()
            ListarCargoR = ListarCargo.ExecuteReader()

            If ListarCargoR.Read = True Then
                If ListarCargoR("IdTabla") Is DBNull.Value Then
                    TxtIdLugarTrabajo.Text = 1
                Else
                    TxtIdLugarTrabajo.Text = ListarCargoR("IdTabla").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos." + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()

        End Try
    End Sub

    Private Sub GuardarLugarTrabajo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@LugarTrabajo", SqlDbType.NVarChar, 50).Value = TxtLugarTrabajo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar el lugar de trabajo", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub ActualizarLugarTrabajo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@IdLugarTrabajo", SqlDbType.Int).Value = TxtIdLugarTrabajo.Text
                    .Parameters.Add("@Trabajo", SqlDbType.NVarChar, 50).Value = TxtLugarTrabajo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al modificar el lugar de trabajo", "Cooperativa XZY" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarLugarTrabajo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer

                    Id = CInt(LsvLugarTrabajo.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdLugarTrabajo", SqlDbType.Int).Value = Id
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

        If TxtLugarTrabajo.Text = Nothing Then
            EpMensaje.SetError(TxtLugarTrabajo, "Tiene que ingresar el lugar de trabajo")
            TxtLugarTrabajo.Focus()
            TxtLugarTrabajo.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtLugarTrabajo, "")
            TxtLugarTrabajo.BackColor = Color.White
        End If

        Return Estado

    End Function

    Private Sub TxtLugarTrabajo_TextChanged(sender As Object, e As EventArgs) Handles TxtLugarTrabajo.TextChanged
        If TxtLugarTrabajo.Text <> Nothing Then
            EpMensaje.SetError(TxtLugarTrabajo, "")
            TxtLugarTrabajo.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click
        EliminarLugarTrabajo()
        MostrarTodo()
        HabilitarBotones(True, False, False, False)
    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        HabilitarBotones(False, False, True, True)
        TxtLugarTrabajo.ReadOnly = False
        TxtIdLugarTrabajo.Text = LsvLugarTrabajo.FocusedItem.SubItems(0).Text
        TxtLugarTrabajo.Text = LsvLugarTrabajo.FocusedItem.SubItems(1).Text
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
