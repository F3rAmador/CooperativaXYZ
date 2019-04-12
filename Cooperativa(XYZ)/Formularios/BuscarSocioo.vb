Imports System.Data.SqlClient
Public Class BuscarSocioo



    ' Seleccionamos los botones a habilitar
    Private Sub FrmSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Close()
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
                        .SubItems.Add(VerSocio("Nacionalidad")).ToString()
                        .SubItems.Add(VerSocio("EstadoCivil")).ToString()
                        .SubItems.Add(VerSocio("LugarTrabajo")).ToString()
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

    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        FrmSolicitudPrestamo.TxtSocio.Text = LsvSocio.FocusedItem.SubItems(0).Text
        FrmRegistroDePrestamo.TxtIdentidadSociedad.Text = LsvSocio.FocusedItem.SubItems(0).Text
        FrmRegistroDePrestamo.TxtNombreSocio.Text = LsvSocio.FocusedItem.SubItems(1).Text
        FrmRegistroDePrestamo.TxtRtn.Text = LsvSocio.FocusedItem.SubItems(3).Text
        FrmRegistroDePrestamo.TxtNacionalidad.Text = LsvSocio.FocusedItem.SubItems(5).Text
        FrmRegistroDePrestamo.TxtEstadoCivil.Text = LsvSocio.FocusedItem.SubItems(6).Text


        Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub RdbBuscarCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles RdbBuscarCodigo.CheckedChanged

    End Sub

    Private Sub RdbBuscarNombre_CheckedChanged(sender As Object, e As EventArgs) Handles RdbBuscarNombre.CheckedChanged

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged

    End Sub

End Class