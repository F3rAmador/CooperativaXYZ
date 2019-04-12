Imports System.Data.SqlClient

Public Class FrmFinalidadPrestamo

    ' Habilita los botones
    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar

    End Sub

    ' Seleccionamos los botones a habilitar
    Private Sub FrmFinalidadPrestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False)
        MostrarTodo()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True)
        InvestigarCorrelativo()
        TxtFinalidad.ReadOnly = False

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarTextBox() = True Then
            GuardarFinalidad()
            Limpiar()
            HabilitarBotones(True, False, False, False)
            MostrarTodo()
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarTextBox() = True Then
            ActualizarFinalidad()
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
        TxtIdFinalidad.Text = Nothing
        TxtFinalidad.Text = Nothing

        EpMensaje.SetError(TxtFinalidad, "")
        TxtFinalidad.BackColor = Color.White

    End Sub


    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using Cmd As New SqlCommand
            Cn.Open()

            Try
                With Cmd
                    .CommandText = "Sp_MostrarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerFinalidad As SqlDataReader
                VerFinalidad = Cmd.ExecuteReader

                LsvFinalidad.Items.Clear()

                While VerFinalidad.Read = True
                    With LsvFinalidad.Items.Add(VerFinalidad("IdFinalidadPrestamo").ToString)
                        .SubItems.Add(VerFinalidad("Finalidad")).ToString()
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
            ListarCargo.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "FinalidadPrestamo"

            Dim ListarCargoR As SqlDataReader
            Cn.Open()
            ListarCargoR = ListarCargo.ExecuteReader()

            If ListarCargoR.Read = True Then
                If ListarCargoR("IdTabla") Is DBNull.Value Then
                    TxtIdFinalidad.Text = 1
                Else
                    TxtIdFinalidad.Text = ListarCargoR("IdTabla").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos." + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()

        End Try
    End Sub

    Private Sub GuardarFinalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@Finalidad", SqlDbType.NVarChar, 50).Value = TxtFinalidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar la finalidad", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub ActualizarFinalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@IdFinalidadPrestamo", SqlDbType.Int).Value = TxtIdFinalidad.Text
                    .Parameters.Add("@Finalidad", SqlDbType.NVarChar, 50).Value = TxtFinalidad.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al modificar la finalidad", "Cooperativa XZY" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarFinalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer

                    Id = CInt(LsvFinalidad.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@IdFinalidadPrestamo", SqlDbType.Int).Value = Id
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

        If TxtFinalidad.Text = Nothing Then
            EpMensaje.SetError(TxtFinalidad, "Tiene que ingresar la finalidad")
            TxtFinalidad.Focus()
            TxtFinalidad.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.SetError(TxtFinalidad, "")
            TxtFinalidad.BackColor = Color.White
        End If

        Return Estado

    End Function

    Private Sub TxtNacionalidad_TextChanged(sender As Object, e As EventArgs) Handles TxtFinalidad.TextChanged
        If TxtFinalidad.Text <> Nothing Then
            EpMensaje.SetError(TxtFinalidad, "")
            TxtFinalidad.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click
        EliminarFinalidad()
        MostrarTodo()
        HabilitarBotones(True, False, False, False)
    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        HabilitarBotones(False, False, True, True)
        TxtFinalidad.ReadOnly = False
        TxtIdFinalidad.Text = LsvFinalidad.FocusedItem.SubItems(0).Text
        TxtFinalidad.Text = LsvFinalidad.FocusedItem.SubItems(1).Text
    End Sub

End Class
