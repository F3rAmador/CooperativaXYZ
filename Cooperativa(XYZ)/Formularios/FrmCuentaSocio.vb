Imports System.Data.SqlClient

Public Class FrmCuentaSocio
    Dim Dt As DataTable
    Dim Da As New SqlDataAdapter
    Dim cmd As New SqlCommand

    Private Sub HabilitarBotones(ByVal Nuevo As Boolean,
                                 ByVal Guardar As Boolean,
                                 ByVal Modificar As Boolean,
                                 ByVal Cancelar As Boolean,
                                 ByVal Salir As Boolean)
        BtnNuevo.Enabled = Nuevo
        BtnGuardar.Enabled = Guardar
        BtnModificar.Enabled = Modificar
        BtnCancelar.Enabled = Cancelar
        BtnCerrar.Enabled = Salir
    End Sub

    Private Sub HabilitarTextBox(ByVal NumCuenta As Boolean,
                                 ByVal CodSocio As Boolean,
                                 ByVal TipoCuenta As Boolean,
                                 ByVal Saldo As Boolean,
                                 ByVal FechaApertura As Boolean)
        TxtNumCuenta.Enabled = NumCuenta
        TxtCodSocio.Enabled = CodSocio
        CboTipoCuenta.Enabled = TipoCuenta
        TxtSaldo.Enabled = Saldo
        DtpFechaApertura.Enabled = FechaApertura

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        HabilitarBotones(False, True, False, True, True)
        HabilitarTextBox(True, True, True, True, True)

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        HabilitarBotones(True, False, False, False, True)

        If ValidarTextBox() = True Then
            GuardarCuentaSocio()
            Limpiar()
            HabilitarBotones(True, False, False, False, True)
            HabilitarTextBox(False, False, False, False, False)
            MostrarTodo()
        End If

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If ValidarTextBox() = True Then
            HabilitarBotones(True, False, False, False, True)
            If Cn.State = ConnectionState.Open Then
                Cn.Close()
            End If

            Dim Saldo As Double

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
                        .Parameters.Add("@SaldoActual", SqlDbType.Money).Value = Convert.ToDouble(Saldo)
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

    Private Sub GuardarCuentaSocio()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Dim Saldo As Double

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
                    .Parameters.Add("@SaldoActual", SqlDbType.Money).Value = Convert.ToDouble(Saldo)
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
                        .SubItems.Add(VerCuentaSocio("IdTipoCuenta")).ToString()
                        .SubItems.Add(VerCuentaSocio("Saldo")).ToString()
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

        If TxtNumCuenta.Text = Nothing And TxtCodSocio.Text = Nothing And CboTipoCuenta.Text = Nothing And TxtSaldo.Text = Nothing Then
            EpMensaje.SetError(TxtNumCuenta, "Tiene que ingresar el número de cuenta")
            EpMensaje.SetError(CboTipoCuenta, "Tiene que seleccionar un tipo de cuenta")
            EpMensaje.SetError(TxtSaldo, "Tiene que ingresar el saldo")
        ElseIf TxtNumCuenta.Text = Nothing Then
            EpMensaje.SetError(TxtNumCuenta, "Tiene que ingresar el número de cuenta")
            TxtNumCuenta.Focus()
            TxtNumCuenta.BackColor = Color.LightBlue
            Estado = False
        ElseIf CboTipoCuenta.Text = Nothing Then
            EpMensaje.SetError(CboTipoCuenta, "Tiene que ingresar un tipo de cuenta")
            CboTipoCuenta.BackColor = Color.LightBlue
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

    Private Sub TxtSaldo_TextChanged(sender As Object, e As EventArgs) Handles TxtSaldo.TextChanged
        If TxtSaldo.Text <> Nothing Then
            EpMensaje.SetError(TxtSaldo, "")
            TxtSaldo.BackColor = Color.White
        End If
    End Sub



    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        HabilitarBotones(False, False, True, True, True)
        TxtNumCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(0).Text
        CboTipoCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(2).Text
        TxtSaldo.Text = LsvCuentaSocio.FocusedItem.SubItems(3).Text
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
                    .Parameters.Add("@CodSocio", SqlDbType.NVarChar).Value = Id
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

    Private Sub TxtNumCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumCuenta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("No se permite ingresar letras o caracteres especiales", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TxtCodSocio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodSocio.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("No se permite ingresar letras o caracteres especiales", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TxtSaldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSaldo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("No se permite ingresar letras o caracteres especiales", "Cooperativa XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripMenuItemEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEliminar.Click
        EliminarCuentaSocio()
        MostrarTodo()
        HabilitarBotones(True, False, False, False, True)
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        HabilitarBotones(True, False, False, False, True)
        Limpiar()

    End Sub

    Private Sub CuentaSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HabilitarBotones(True, False, False, False, True)
        HabilitarTextBox(False, False, False, False, False)
        ComboBoxTipoCuenta()
        CboTipoCuenta.Text = Nothing

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        HabilitarBotones(False, False, True, True, True)
        TxtNumCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(0).Text
        CboTipoCuenta.Text = LsvCuentaSocio.FocusedItem.SubItems(2).Text
        TxtSaldo.Text = LsvCuentaSocio.FocusedItem.SubItems(3).Text
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
End Class