Imports System.Data.SqlClient

Public Class FrmSocio

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar

    End Sub

    ' Seleccionamos los botones a habilitar
    Private Sub FrmSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False)
        MostrarTodo()

    End Sub

    Private Sub LLenarNacionalidad()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "Nacionalidad")
                CboIdNacionalidad.DataSource = Ds.Tables(0)
                CboIdNacionalidad.DisplayMember = Ds.Tables(0).Columns("Nacionalidad").ToString
                CboIdNacionalidad.ValueMember = Ds.Tables(0).Columns("IdNacionalidad").ToString
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos" + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LLenarEstadoCivil()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarEstadoCivil"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "EstadoCivil")
                CboEstadoCivil.DataSource = Ds.Tables(0)
                CboEstadoCivil.DisplayMember = Ds.Tables(0).Columns("EstadoCivil").ToString
                CboEstadoCivil.ValueMember = Ds.Tables(0).Columns("IdEstadoCivil").ToString
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos" + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LLenarLugarTrabajo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarLugarTrabajo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "LugarTrabajo")
                CboLugarTrabajo.DataSource = Ds.Tables(0)
                CboLugarTrabajo.DisplayMember = Ds.Tables(0).Columns("LugarTrabajo").ToString
                CboLugarTrabajo.ValueMember = Ds.Tables(0).Columns("IdLugarTrabajo").ToString
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos" + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        LLenarNacionalidad()
        LLenarEstadoCivil()
        LLenarLugarTrabajo()

        HabilitarBotones(False, True, False, True)

        TxtCodSocio.ReadOnly = False
        TxtNombres.ReadOnly = False
        TxtApellidos.ReadOnly = False
        TxtRtn.ReadOnly = False
        TxtDireccion.ReadOnly = False
        TxtTelCasa.ReadOnly = False
        TxtTelTrabajo.ReadOnly = False

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If ValidarTextBox() = True Then
            GuardarSocio()
            Limpiar()
            HabilitarBotones(True, False, False, False)
            MostrarTodo()
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click

        If ValidarTextBox() = True Then
            ActualizarSocio()
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
        TxtCodSocio.Text = Nothing
        TxtNombres.Text = Nothing
        TxtApellidos.Text = Nothing
        TxtRtn.Text = Nothing
        TxtDireccion.Text = Nothing
        TxtTelCasa.Text = Nothing
        TxtTelTrabajo.Text = Nothing
        TxtTelCasa.Text = Nothing
        CboIdNacionalidad.Text = Nothing
        CboLugarTrabajo.Text = Nothing
        CboEstadoCivil.Text = Nothing


    End Sub

    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using Cmd As New SqlCommand
            Cn.Open()

            Try
                With Cmd
                    .CommandText = "Sp_MostrarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerSocio As SqlDataReader
                VerSocio = Cmd.ExecuteReader

                LsvSocio.Items.Clear()

                While VerSocio.Read = True
                    With LsvSocio.Items.Add(VerSocio("CodSocio").ToString)
                        .SubItems.Add(VerSocio("Nombres")).ToString()
                        .SubItems.Add(VerSocio("Apellidos")).ToString()
                        .SubItems.Add(VerSocio("Rtn")).ToString()
                        .SubItems.Add(VerSocio("Direccion")).ToString()
                        .SubItems.Add(VerSocio("IdNacionalidad")).ToString()
                        .SubItems.Add(VerSocio("IdEstadoCivil")).ToString()
                        .SubItems.Add(VerSocio("IdLugarTrabajo")).ToString()
                        .SubItems.Add(VerSocio("TelCasa")).ToString()
                        .SubItems.Add(VerSocio("TelTrabajo")).ToString()

                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
            Cn.Close()
        End Using

    End Sub

    Private Sub GuardarSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtCodSocio.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombres.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Rtn", SqlDbType.Decimal, 14).Value = CDec(TxtRtn.Text)
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtCodSocio.Text
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CInt(CboIdNacionalidad.SelectedValue)
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CInt(CboEstadoCivil.SelectedValue)
                    .Parameters.Add("@IdLugarTrabajo", SqlDbType.Int).Value = CInt(CboLugarTrabajo.SelectedValue)
                    .Parameters.Add("@TelCasa", SqlDbType.Char, 9).Value = TxtTelCasa.Text
                    .Parameters.Add("@TelTrabajo", SqlDbType.Char, 9).Value = TxtTelTrabajo.Text

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub ActualizarSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtCodSocio.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 50).Value = TxtNombres.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 50).Value = TxtApellidos.Text
                    .Parameters.Add("@Rtn", SqlDbType.Decimal, 14).Value = CDec(TxtRtn.Text)
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtCodSocio.Text
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CInt(CboIdNacionalidad.SelectedValue)
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CInt(CboEstadoCivil.SelectedValue)
                    .Parameters.Add("@IdLugarTrabajo", SqlDbType.Int).Value = CInt(CboLugarTrabajo.SelectedValue)
                    .Parameters.Add("@TelCasa", SqlDbType.Char, 9).Value = TxtTelCasa.Text
                    .Parameters.Add("@TelTrabajo", SqlDbType.Char, 9).Value = TxtTelTrabajo.Text
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al modificar los datos", "Cooperativa XZY" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub EliminarSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As Integer

                    Id = CInt(LsvSocio.FocusedItem.SubItems(0).Text)
                    .Parameters.Add("@CodSocio", SqlDbType.Int).Value = Id
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

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click
        EliminarSocio()
        MostrarTodo()
        HabilitarBotones(True, False, False, False)
    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        TcDatos.SelectedIndex = 0

        HabilitarBotones(False, False, True, True)
        TxtCodSocio.ReadOnly = True

        TxtCodSocio.Text = LsvSocio.FocusedItem.SubItems(0).Text
        TxtNombres.Text = LsvSocio.FocusedItem.SubItems(1).Text
        TxtApellidos.Text = LsvSocio.FocusedItem.SubItems(2).Text
        TxtRtn.Text = LsvSocio.FocusedItem.SubItems(3).Text
        TxtDireccion.Text = LsvSocio.FocusedItem.SubItems(4).Text
        CboIdNacionalidad.Text = LsvSocio.FocusedItem.SubItems(5).Text
        CboEstadoCivil.Text = LsvSocio.FocusedItem.SubItems(6).Text
        CboLugarTrabajo.Text = LsvSocio.FocusedItem.SubItems(7).Text
        TxtTelCasa.Text = LsvSocio.FocusedItem.SubItems(8).Text
        TxtTelTrabajo.Text = LsvSocio.FocusedItem.SubItems(9).Text

        LLenarNacionalidad()
        LLenarEstadoCivil()
        LLenarLugarTrabajo()

        TxtCodSocio.ReadOnly = True
        TxtNombres.ReadOnly = False
        TxtApellidos.ReadOnly = False
        TxtRtn.ReadOnly = False
        TxtDireccion.ReadOnly = False
        TxtTelCasa.ReadOnly = False
        TxtTelTrabajo.ReadOnly = False
    End Sub

    Private Function ValidarTextBox() As Boolean
        Dim Estado As Boolean

        If TxtCodSocio.Text = Nothing And TxtNombres.Text = Nothing And TxtApellidos.Text = Nothing And
        TxtRtn.Text = Nothing And TxtDireccion.Text = Nothing Then
            EpMensaje.SetError(TxtCodSocio, "Debe ingresar los datos")
            Estado = False

            TxtCodSocio.BackColor = Color.LightBlue
            TxtNombres.BackColor = Color.LightBlue
            TxtApellidos.BackColor = Color.LightBlue
            TxtRtn.BackColor = Color.LightBlue
            TxtDireccion.BackColor = Color.LightBlue
            TxtTelCasa.BackColor = Color.LightBlue
            TxtTelTrabajo.BackColor = Color.LightBlue

        ElseIf TxtCodSocio.Text = Nothing Then
            EpMensaje.SetError(TxtCodSocio, "Debe ingresar identidad")
            Estado = False

            EpMensaje.SetError(TxtNombres, "")
            EpMensaje.SetError(TxtApellidos, "")
            EpMensaje.SetError(TxtRtn, "")
            EpMensaje.SetError(TxtDireccion, "")
            EpMensaje.SetError(TxtTelCasa, "")
            EpMensaje.SetError(TxtTelTrabajo, "")

            TxtCodSocio.BackColor = Color.LightBlue
            TxtNombres.BackColor = Color.White
            TxtApellidos.BackColor = Color.White
            TxtRtn.BackColor = Color.White
            TxtDireccion.BackColor = Color.White
            TxtTelCasa.BackColor = Color.White
            TxtTelTrabajo.BackColor = Color.White

        ElseIf TxtNombres.Text = Nothing Then
            EpMensaje.SetError(TxtNombres, "Debe ingresar el nombre")

            EpMensaje.SetError(TxtCodSocio, "")
            EpMensaje.SetError(TxtApellidos, "")
            EpMensaje.SetError(TxtRtn, "")
            EpMensaje.SetError(TxtDireccion, "")
            EpMensaje.SetError(TxtTelCasa, "")
            EpMensaje.SetError(TxtTelTrabajo, "")

            TxtCodSocio.BackColor = Color.White
            TxtNombres.BackColor = Color.LightBlue
            TxtApellidos.BackColor = Color.White
            TxtRtn.BackColor = Color.White
            TxtDireccion.BackColor = Color.White
            TxtTelCasa.BackColor = Color.White
            TxtTelTrabajo.BackColor = Color.White

            Estado = False
        ElseIf TxtApellidos.Text = Nothing Then
            EpMensaje.SetError(TxtApellidos, "Debe ingresar apellidos")

            EpMensaje.SetError(TxtNombres, "")
            EpMensaje.SetError(TxtCodSocio, "")
            EpMensaje.SetError(TxtRtn, "")
            EpMensaje.SetError(TxtDireccion, "")
            EpMensaje.SetError(TxtTelCasa, "")
            EpMensaje.SetError(TxtTelTrabajo, "")

            TxtCodSocio.BackColor = Color.White
            TxtNombres.BackColor = Color.White
            TxtApellidos.BackColor = Color.LightBlue
            TxtRtn.BackColor = Color.White
            TxtDireccion.BackColor = Color.White
            TxtTelCasa.BackColor = Color.White
            TxtTelTrabajo.BackColor = Color.White

            Estado = False
        ElseIf TxtRtn.Text = Nothing Then
            EpMensaje.SetError(TxtRtn, "Debe ingresar el RTN")

            EpMensaje.SetError(TxtNombres, "")
            EpMensaje.SetError(TxtApellidos, "")
            EpMensaje.SetError(TxtCodSocio, "")
            EpMensaje.SetError(TxtDireccion, "")
            EpMensaje.SetError(TxtTelCasa, "")
            EpMensaje.SetError(TxtTelTrabajo, "")

            TxtCodSocio.BackColor = Color.Wheat
            TxtNombres.BackColor = Color.White
            TxtApellidos.BackColor = Color.White
            TxtRtn.BackColor = Color.LightBlue
            TxtDireccion.BackColor = Color.White
            TxtTelCasa.BackColor = Color.White
            TxtTelTrabajo.BackColor = Color.White

            Estado = False
        ElseIf TxtDireccion.Text = Nothing Then
            EpMensaje.SetError(TxtDireccion, "Debe ingresar la dirección")

            EpMensaje.SetError(TxtNombres, "")
            EpMensaje.SetError(TxtApellidos, "")
            EpMensaje.SetError(TxtRtn, "")
            EpMensaje.SetError(TxtCodSocio, "")
            EpMensaje.SetError(TxtTelCasa, "")
            EpMensaje.SetError(TxtTelTrabajo, "")

            TxtCodSocio.BackColor = Color.White
            TxtNombres.BackColor = Color.White
            TxtApellidos.BackColor = Color.White
            TxtRtn.BackColor = Color.White
            TxtDireccion.BackColor = Color.LightBlue
            TxtTelCasa.BackColor = Color.White
            TxtTelTrabajo.BackColor = Color.White

            Estado = False
        Else
            TxtCodSocio.BackColor = Color.White
            TxtNombres.BackColor = Color.White
            TxtApellidos.BackColor = Color.White
            TxtRtn.BackColor = Color.White
            TxtDireccion.BackColor = Color.White
            TxtTelCasa.BackColor = Color.White
            TxtTelTrabajo.BackColor = Color.White

            EpMensaje.SetError(TxtDireccion, "")
            EpMensaje.SetError(TxtNombres, "")
            EpMensaje.SetError(TxtApellidos, "")
            EpMensaje.SetError(TxtRtn, "")
            EpMensaje.SetError(TxtCodSocio, "")
            EpMensaje.SetError(TxtTelCasa, "")
            EpMensaje.SetError(TxtTelTrabajo, "")

            Estado = True


        End If
        Return Estado
    End Function
End Class