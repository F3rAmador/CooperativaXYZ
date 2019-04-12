Imports System.Data.SqlClient

Public Class FrmSolicitudPrestamo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub InvestigarCorrelativo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Dim Listar As New SqlCommand("Sp_InvestigarCorrelativo", Cn)

            Listar.CommandType = CommandType.StoredProcedure
            Listar.Parameters.Add("@NombreTabla", SqlDbType.NVarChar, 30).Value = "SolicitudPrestamo"

            Dim ListarR As SqlDataReader
            Cn.Open()
            ListarR = Listar.ExecuteReader()

            If ListarR.Read = True Then
                If ListarR("IdTabla") Is Nothing Then
                    TxtNumeroSolicitud.Text = 1
                Else
                    TxtNumeroSolicitud.Text = ListarR("IdTabla").ToString + 1
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los datos." + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()

        End Try
    End Sub


    Private Sub LLenarCboTipoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "TipoPrestamo")
                CboTipoPrestamo.DataSource = Ds.Tables(0)
                CboTipoPrestamo.DisplayMember = Ds.Tables(0).Columns("TipoPrestamo").ToString
                CboTipoPrestamo.ValueMember = Ds.Tables(0).Columns("IdTipoPrestamo").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub


    Private Sub LLenarCboFinalidadPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarFinalidadPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "FinalidadPrestamo")
                CboFinalidad.DataSource = Ds.Tables(0)
                CboFinalidad.DisplayMember = Ds.Tables(0).Columns("Finalidad").ToString
                CboFinalidad.ValueMember = Ds.Tables(0).Columns("IdFinalidadPrestamo").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub


    Private Sub LLenarCboEstadoPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If
        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarEstadoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim Da As New SqlDataAdapter(CMd)

                Dim Ds As New DataSet

                Da.Fill(Ds, "EstadoSolicitudPrestamo")
                CboEstadoPrestamo.DataSource = Ds.Tables(0)
                CboEstadoPrestamo.DisplayMember = Ds.Tables(0).Columns("EstadoPrestamo").ToString
                CboEstadoPrestamo.ValueMember = Ds.Tables(0).Columns("IdEstadoPrestamo").ToString
            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos." + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try
        End Using
    End Sub


    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_MostrarSolicitudPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerSolicitud As SqlDataReader
                VerSolicitud = CMd.ExecuteReader

                LsvSolicitudPrestamo.Items.Clear()
                While VerSolicitud.Read = True
                    With LsvSolicitudPrestamo.Items.Add(VerSolicitud("NumSolicitud").ToString)
                        .SubItems.Add(VerSolicitud("FechaSolicitud").ToString)
                        .SubItems.Add(VerSolicitud("TipoPrestamo").ToString)
                        .SubItems.Add(VerSolicitud("CodSocio").ToString)
                        .SubItems.Add(VerSolicitud("PlazoPago").ToString)
                        .SubItems.Add(VerSolicitud("Finalidad").ToString)
                        .SubItems.Add(VerSolicitud("TasaInteres").ToString)
                        .SubItems.Add(VerSolicitud("SumaOtorgada").ToString)
                        .SubItems.Add(VerSolicitud("CodOficial").ToString)
                        .SubItems.Add(VerSolicitud("EstadoPrestamo").ToString)



                    End With
                End While

            Catch ex As Exception

                MessageBox.Show("Error al mostrar la solicitud " + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()

            End Try
        End Using
    End Sub

    Private Sub GuardarSolicitudPrestamo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarSolicitudPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@FechaSolicitud", SqlDbType.Date).Value = DtpFechaSolicitud.Text
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(CboTipoPrestamo.SelectedValue)
                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtSocio.Text
                    .Parameters.Add("@PlazoPago", SqlDbType.Int).Value = CInt(TxtPlazoPago.Text)
                    .Parameters.Add("@IdFinalidadPrestamo", SqlDbType.Int).Value = CInt(CboFinalidad.SelectedValue)
                    .Parameters.Add("@TasaInteres", SqlDbType.Decimal, 8, 2).Value = CDec(TxtTasa.Text)
                    .Parameters.Add("@SumaOtorgada", SqlDbType.Decimal, 8, 2).Value = CDec(TxtSumaOtorgada.Text)
                    .Parameters.Add("@CodOficial", SqlDbType.VarChar, 15).Value = TxtOficial.Text
                    .Parameters.Add("@IdEstadoPrestamo", SqlDbType.Int).Value = CInt(CboEstadoPrestamo.SelectedValue)

                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al insertar los datos del cliente " + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub

    Private Sub ActualizarSolicitud()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_ActualizarSolicitudPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn


                    .Parameters.Add("@NumSolicitud", SqlDbType.Int).Value = TxtNumeroSolicitud.Text
                    .Parameters.Add("@FechaSolicitud", SqlDbType.Date).Value = DtpFechaSolicitud.Text
                    .Parameters.Add("@IdTipoPrestamo", SqlDbType.Int).Value = CInt(CboTipoPrestamo.SelectedValue)
                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtSocio.Text
                    .Parameters.Add("@PlazoPago", SqlDbType.Int).Value = CInt(TxtPlazoPago.Text)
                    .Parameters.Add("@IdFinalidadPrestamo", SqlDbType.Int).Value = CInt(CboFinalidad.SelectedValue)
                    .Parameters.Add("@TasaInteres", SqlDbType.Decimal, 8, 2).Value = CDec(TxtTasa.Text)
                    .Parameters.Add("@SumaOtorgada", SqlDbType.Decimal, 8, 2).Value = CDec(TxtSumaOtorgada.Text)
                    .Parameters.Add("@CodOficial", SqlDbType.VarChar, 15).Value = TxtOficial.Text
                    .Parameters.Add("@IdEstadoPrestamo", SqlDbType.Int).Value = CInt(CboEstadoPrestamo.SelectedValue)





                    .ExecuteNonQuery()

                    MessageBox.Show("Registro actualizado satisfactoriamente", "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el cliente " + ex.Message, "SIFO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    Private Sub FrmSolicitudPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        InvestigarCorrelativo()
        LLenarCboEstadoPrestamo()
        LLenarCboFinalidadPrestamo()
        LLenarCboTipoPrestamo()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        HabilitarBotones(True, False, False, False, True)
        GuardarSolicitudPrestamo()
        MostrarTodo()
    End Sub

    Private Sub BtnBuscarSocio_Click(sender As Object, e As EventArgs) Handles BtnBuscarSocio.Click
        FrmBuscarSocio.ShowDialog()
    End Sub

    Private Sub BtnBuscarOficial_Click(sender As Object, e As EventArgs) Handles BtnBuscarOficial.Click
        FrmBuscarOficial.ShowDialog()
    End Sub

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean, ByVal Guardar As Boolean, ByVal Modificar As Boolean, ByVal Cancelar As Boolean, ByVal Salir As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        BtnCerrar.Enabled = Salir

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        HabilitarBotones(True, False, False, False, True)
        ActualizarSolicitud()
        MostrarTodo()

        TcOpciones.SelectedIndex = 1
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True)
    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        HabilitarBotones(False, False, True, True, True)
        TxtNumeroSolicitud.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(0).Text
        DtpFechaSolicitud.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(1).Text
        CboTipoPrestamo.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(2).Text
        TxtSocio.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(3).Text
        TxtPlazoPago.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(4).Text
        CboFinalidad.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(5).Text
        TxtTasa.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(6).Text
        TxtSumaOtorgada.Text = FormatCurrency(LsvSolicitudPrestamo.FocusedItem.SubItems(7).Text, 2)
        TxtOficial.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(8).Text
        CboEstadoPrestamo.Text = LsvSolicitudPrestamo.FocusedItem.SubItems(9).Text

        LLenarCboEstadoPrestamo()
        LLenarCboFinalidadPrestamo()
        LLenarCboTipoPrestamo()

        TcOpciones.SelectedIndex = 0

    End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click

    End Sub
End Class