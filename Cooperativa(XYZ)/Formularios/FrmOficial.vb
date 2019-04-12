Imports System.Data.SqlClient

Public Class FrmOficial


    Public Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FrmTipoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNumIdentidad.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        TxtNumIdentidad.ReadOnly = True
        TxtNombre.ReadOnly = True
        TxtApellidos.ReadOnly = True
        TxtTelefono.ReadOnly = True
        TxtDirección.ReadOnly = True
        LsvOficialCredito.Visible = True
        MostrarTodo()
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
        TxtNumIdentidad.ReadOnly = False
        TxtNombre.ReadOnly = False
        TxtApellidos.ReadOnly = False
        TxtTelefono.ReadOnly = False
        TxtDirección.ReadOnly = False
        TxtNumIdentidad.Focus()


    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        HabilitarBotones(True, False, False, False, True)

        If ValidarTextBox() = True Then
            GuardarOficialCredito()
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
                        .CommandText = "Sp_ActualizarOficialCredito"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Cn
                        .Parameters.Add("@CodOficial", SqlDbType.VarChar, 15).Value = TxtNumIdentidad.Text
                        .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombre.Text
                        .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                        .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = TxtTelefono.Text
                        .Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = TxtDirección.Text

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



    Private Sub GuardarOficialCredito()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarOficialCredito"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@CodOficial", SqlDbType.VarChar, 15).Value = TxtNumIdentidad.Text
                    .Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = TxtNombre.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = TxtTelefono.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value = TxtDirección.Text
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
                    .CommandText = "Sp_MostrarOficialCredito"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerTipoPrestamo As SqlDataReader
                VerTipoPrestamo = Cmd.ExecuteReader

                LsvOficialCredito.Items.Clear()

                While VerTipoPrestamo.Read = True
                    With LsvOficialCredito.Items.Add(VerTipoPrestamo("CodOficial").ToString)
                        .SubItems.Add(VerTipoPrestamo("Nombres")).ToString()
                        .SubItems.Add(VerTipoPrestamo("Apellidos")).ToString()
                        .SubItems.Add(VerTipoPrestamo("Teléfono")).ToString()
                        .SubItems.Add(VerTipoPrestamo("Dirección")).ToString()
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos " + ex.Message, "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
            Cn.Close()
        End Using

    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtNombre.Text = Nothing And TxtNumIdentidad.Text = Nothing And TxtApellidos.Text = Nothing And TxtDirección.Text = Nothing Then
            EpMensaje.SetError(TxtNumIdentidad, "Tiene que comenzar como el número de identidad")
            TxtNumIdentidad.Focus()
            TxtNumIdentidad.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtNombre.Text = Nothing Then
            EpMensaje.SetError(TxtNombre, "Tiene que ingresar el nombre")
            TxtNombre.Focus()
            TxtNombre.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtApellidos.Text = Nothing Then
            EpMensaje.SetError(TxtApellidos, "Tiene que ingresar el apellido")
            TxtApellidos.Focus()
            TxtApellidos.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtDirección.Text = Nothing Then
            EpMensaje.SetError(TxtDirección, "Tiene que ingresar la dirección")
            TxtDirección.Focus()
            TxtDirección.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtNumIdentidad.Text = Nothing Then
            EpMensaje.SetError(TxtNumIdentidad, "Tiene que ingresar el número de identidad")
            TxtNumIdentidad.Focus()
            TxtNumIdentidad.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtNombre, "")
        End If

        Return Estado

    End Function

    Private Sub Limpiar()
        TxtNumIdentidad.Text = Nothing
        TxtNombre.Text = Nothing
        TxtApellidos.Text = Nothing
        TxtTelefono.Text = Nothing
        TxtDirección.Text = Nothing
    End Sub



    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If TxtNombre.Text <> Nothing Then
            EpMensaje.SetError(TxtNombre, "")
            TxtNombre.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtApellidos_TextChanged(sender As Object, e As EventArgs) Handles TxtApellidos.TextChanged
        If TxtApellidos.Text <> Nothing Then
            EpMensaje.SetError(TxtApellidos, "")
            TxtApellidos.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtDireccion_TextChanged(sender As Object, e As EventArgs) Handles TxtDirección.TextChanged
        If TxtDirección.Text <> Nothing Then
            EpMensaje.SetError(TxtDirección, "")
            TxtDirección.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        HabilitarBotones(False, False, True, True, True)
        TxtNumIdentidad.ReadOnly = False
        TxtNombre.ReadOnly = False
        TxtApellidos.ReadOnly = False
        TxtTelefono.ReadOnly = False
        TxtDirección.ReadOnly = False
        TxtNumIdentidad.Text = LsvOficialCredito.FocusedItem.SubItems(0).Text
        TxtNombre.Text = LsvOficialCredito.FocusedItem.SubItems(1).Text
        TxtApellidos.Text = LsvOficialCredito.FocusedItem.SubItems(2).Text
        TxtTelefono.Text = LsvOficialCredito.FocusedItem.SubItems(3).Text
        TxtDirección.Text = LsvOficialCredito.FocusedItem.SubItems(4).Text
    End Sub

    Private Sub EliminarOficialCredito()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarOficialCredito"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    Dim Id As String

                    Id = LsvOficialCredito.FocusedItem.SubItems(0).Text
                    .Parameters.Add("@CodOficial", SqlDbType.VarChar, 15).Value = Id
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

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        EliminarOficialCredito()
        MostrarTodo()
        HabilitarBotones(True, False, False, False, True)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True)
        TxtNumIdentidad.ReadOnly = True
        TxtNombre.ReadOnly = True
        TxtApellidos.ReadOnly = True
        TxtTelefono.ReadOnly = True
        TxtDirección.ReadOnly = True
        TxtNumIdentidad.Focus()
        Limpiar()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub TipoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, True)
    End Sub



    Private Sub TxtNumIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtNumIdentidad.TextChanged
        If TxtNumIdentidad.Text <> Nothing Then
            EpMensaje.SetError(TxtNumIdentidad, "")
            TxtNumIdentidad.BackColor = Color.White
        End If
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