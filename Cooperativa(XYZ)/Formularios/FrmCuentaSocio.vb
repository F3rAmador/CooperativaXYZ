Imports System.Data.SqlClient

Public Class FrmCuentaSocio
    Dim Dt As DataTable
    Dim Da As New SqlDataAdapter
    Dim cmd As New SqlCommand

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                                 ByVal Guardar As Boolean,
                                 ByVal Modificar As Boolean,
                                 ByVal Cancelar As Boolean,
                                 ByVal Salir As Boolean,
                                 ByVal Salir2 As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        BtnCerrar.Enabled = Salir
        BtnCerrar2.Enabled = Salir2
    End Sub

    Private Sub HabilitarTextBox(ByVal NumCuenta As Boolean,
                                 ByVal CodSocio As Boolean,
                                 ByVal TipoCuenta As Boolean,
                                 ByVal DescripcionTipoCuenta As Boolean,
                                 ByVal Saldo As Boolean,
                                 ByVal FechaApertura As Boolean)
        TxtNumCuenta.Enabled = NumCuenta
        TxtCodSocio.Enabled = CodSocio
        CboTipoCuenta.Enabled = TipoCuenta
        TxtDescripcionTipoCuenta.Enabled = DescripcionTipoCuenta
        TxtSaldo.Enabled = Saldo
        DtpFechaApertura.Enabled = FechaApertura

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True, True)
        HabilitarTextBox(True, True, True, True, True, True)

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        HabilitarBotones(True, False, False, False, True, True)

        If ValidarTextBox() = True Then
            GuardarCuentaSocio()
            'Limpiar()
            HabilitarBotones(True, False, False, False, True, True)
            HabilitarTextBox(False, False, False, False, False, False)
            MostrarTodo()
        Else
            'Limpiar()
            HabilitarBotones(False, True, False, True, True, True)
            MostrarTodo()
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False, True, True)
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If

            Try
                Cn.Open()
                Using Cmd As New SqlCommand
                    With Cmd
                        .CommandText = "Sp_ActualizarCuentaSocio"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Cn
                        .Parameters.Add("@NumCuenta", SqlDbType.VarChar, 19).Value = TxtNumCuenta.Text
                        .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtCodSocio.Text
                        .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CboTipoCuenta.SelectedValue
                        .Parameters.Add("@DescripcionTipoCuenta", SqlDbType.NVarChar, 100).Value = TxtDescripcionTipoCuenta.Text
                        .Parameters.Add("@SaldoActual", SqlDbType.Decimal, 8, 2).Value = CDec(TxtSaldo.Text)
                        .Parameters.Add("@FechaApertura", SqlDbType.Date).Value = Convert.ToDateTime(DtpFechaApertura.Text)
                        .ExecuteNonQuery()

                        MessageBox.Show("Registro modificado satisfactoriamente", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End With
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Cn.Close()
            End Try

            MostrarTodo()
            Limpiar()
        End If

    End Sub

    Private Sub BtnCerrar_Click_1(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub

    Private Sub BtnCerrar2_Click(sender As Object, e As EventArgs) Handles BtnCerrar2.Click
        Close()
    End Sub

    Private Sub GuardarCuentaSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_InsertarCuentaSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    .Parameters.Add("@NumCuenta", SqlDbType.VarChar, 19).Value = TxtNumCuenta.Text
                    .Parameters.Add("@CodSocio", SqlDbType.VarChar, 15).Value = TxtCodSocio.Text
                    .Parameters.Add("@IdTipoCuenta", SqlDbType.Int).Value = CboTipoCuenta.SelectedValue
                    .Parameters.Add("@DescripcionTipoCuenta", SqlDbType.NVarChar, 100).Value = TxtDescripcionTipoCuenta.Text
                    .Parameters.Add("@SaldoActual", SqlDbType.Decimal, 8, 2).Value = CDec(TxtSaldo.Text)
                    .Parameters.Add("@FechaApertura", SqlDbType.Date).Value = Convert.ToDateTime(DtpFechaApertura.Text)
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro almacenado satisfactoriamente.", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
                MostrarTodo()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    .CommandText = "Sp_MostrarCuentaSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerCuentaSocio As SqlDataReader
                VerCuentaSocio = Cmd.ExecuteReader

                LsvCuentaSocio.Items.Clear()

                While VerCuentaSocio.Read = True
                    With LsvCuentaSocio.Items.Add(VerCuentaSocio("NumCuenta").ToString)
                        .SubItems.Add(VerCuentaSocio("CodSocio")).ToString()
                        .SubItems.Add(VerCuentaSocio("TipoCuenta")).ToString()
                        .SubItems.Add(VerCuentaSocio("DescripcionTipoCuenta")).ToString()
                        .SubItems.Add(VerCuentaSocio("SaldoActual")).ToString()
                        .SubItems.Add(VerCuentaSocio("FechaApertura")).ToString()
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error: " + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
            Cn.Close()
        End Using

    End Sub

    Private Function ValidarTextBox()
        Dim Estado As Boolean

        If TxtNumCuenta.Text = Nothing And TxtCodSocio.Text = Nothing And CboTipoCuenta.Text = Nothing And TxtDescripcionTipoCuenta.Text = Nothing And TxtSaldo.Text = Nothing Then
            EpMensaje.SetError(TxtNumCuenta, "Tiene que ingresar el número de cuenta")
            EpMensaje.SetError(TxtCodSocio, "Tiene que agregar el número de socio")
            EpMensaje.SetError(CboTipoCuenta, "Tiene que seleccionar un tipo de cuenta")
            EpMensaje.SetError(TxtDescripcionTipoCuenta, "Tiene que agregar una descripción a tipo de cuenta")
            EpMensaje.SetError(TxtSaldo, "Tiene que ingresar el saldo")
            Estado = False
        ElseIf TxtCodSocio.Text = Nothing Then
            EpMensaje.SetError(TxtCodSocio, "Tiene que ingresar el número de socio")
            TxtNumCuenta.Focus()
            TxtNumCuenta.BackColor = Color.LightBlue
            Estado = False
        ElseIf CboTipoCuenta.Text = Nothing Then
            EpMensaje.SetError(CboTipoCuenta, "Tiene que ingresar un tipo de cuenta")
            CboTipoCuenta.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtDescripcionTipoCuenta.Text = Nothing Then
            EpMensaje.SetError(TxtDescripcionTipoCuenta, "Tiene que agregar una descripción a tipo de cuenta")
            TxtDescripcionTipoCuenta.Focus()
            TxtDescripcionTipoCuenta.BackColor = Color.LightBlue
            Estado = False
        ElseIf TxtSaldo.Text = Nothing Then
            EpMensaje.SetError(TxtSaldo, "Tiene que ingresar el saldo")
            TxtSaldo.Focus()
            TxtSaldo.BackColor = Color.LightBlue
            Estado = False
        Else
            Estado = True
            EpMensaje.Dispose()
        End If

        Return Estado

    End Function

    Private Sub Limpiar()
        TxtNumCuenta.Text = Nothing
        TxtCodSocio.Text = Nothing
        CboTipoCuenta.Text = ""
        TxtDescripcionTipoCuenta.Text = Nothing
        TxtSaldo.Text = Nothing

    End Sub

    Private Sub TxtNumCuenta_TextChanged(sender As Object, e As EventArgs) Handles TxtNumCuenta.TextChanged
        If TxtNumCuenta.Text <> Nothing Then
            EpMensaje.SetError(TxtNumCuenta, "")
            TxtNumCuenta.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtCodSocio_TextChanged(sender As Object, e As EventArgs) Handles TxtCodSocio.TextChanged
        If TxtCodSocio.Text <> Nothing Then
            EpMensaje.SetError(TxtCodSocio, "")
            TxtSaldo.BackColor = Color.White
        End If
    End Sub

    Private Sub CboTipoCuenta_TextChanged(sender As Object, e As EventArgs) Handles CboTipoCuenta.TextChanged
        EpMensaje.Clear()

    End Sub

    Private Sub TxtDescripcionTipoCuenta_Changed(sender As Object, e As EventArgs) Handles TxtDescripcionTipoCuenta.TextChanged
        If TxtDescripcionTipoCuenta.Text <> Nothing Then
            EpMensaje.SetError(TxtDescripcionTipoCuenta, "")
            TxtDescripcionTipoCuenta.BackColor = Color.White
        End If
    End Sub

    Private Sub TxtSaldo_TextChanged(sender As Object, e As EventArgs) Handles TxtSaldo.TextChanged
        If TxtSaldo.Text <> Nothing Then
            EpMensaje.SetError(TxtSaldo, "")
            TxtSaldo.BackColor = Color.White
        End If
    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        HabilitarBotones(False, False, True, True, True, True)
        HabilitarTextBox(True, True, True, True, True, False)
        TxtNumCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(0).Text
        TxtCodSocio.Text = LsvCuentaSocio.FocusedItem.SubItems(1).Text
        CboTipoCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(2).Text
        TxtDescripcionTipoCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(3).Text
        TxtSaldo.Text = LsvCuentaSocio.FocusedItem.SubItems(4).Text
        TabControl1.SelectedIndex = 0
    End Sub

    Private Sub EliminarCuentaSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Try
            Cn.Open()
            Using Cmd As New SqlCommand
                With Cmd
                    .CommandText = "Sp_EliminarCuentaSocio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                    Dim Id As String

                    Id = LsvCuentaSocio.FocusedItem.SubItems(0).Text
                    .Parameters.Add("@NumCuenta", SqlDbType.VarChar).Value = Id
                    .ExecuteNonQuery()

                    MessageBox.Show("Registro eliminado satisfactoriamente", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End With
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message, "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cn.Close()
        End Try
    End Sub


    'Private Sub TxtNumCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumCuenta.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '        MessageBox.Show("No se permite ingresar letras o caracteres especiales", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub TxtCodSocio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodSocio.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '        MessageBox.Show("No se permite ingresar letras o caracteres especiales", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub TxtDescripcionTipoCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescripcionTipoCuenta.KeyPress
    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '        MessageBox.Show("No se permite ingresar números o caracteres especiales", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub TxtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSaldo.KeyPress
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '        MessageBox.Show("No se permite ingresar letras o caracteres especiales", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click
        EliminarCuentaSocio()
        MostrarTodo()
        HabilitarBotones(True, False, False, False, True, True)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True, True)
        Limpiar()

    End Sub

    Private Sub CuentaSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, True, True)
        HabilitarTextBox(False, False, False, False, False, False)
        ComboBoxTipoCuenta()
        CboTipoCuenta.Text = Nothing
        MostrarTodo()

    End Sub

    Private Sub ComboBoxTipoCuenta()
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "Select * From TipoCuenta"
            .Connection = Cn
        End With

        Da.SelectCommand = cmd
        Dt = New DataTable
        Da.Fill(Dt)

        With CboTipoCuenta
            .DataSource = Dt
            .DisplayMember = "TipoCuenta"
            .ValueMember = "IdTipoCuenta"
        End With

    End Sub

    Private Sub BtnBuscarSocio_Click(sender As Object, e As EventArgs) Handles BtnBuscarSocio.Click
        BuscarSocioo.ShowDialog()
    End Sub
End Class