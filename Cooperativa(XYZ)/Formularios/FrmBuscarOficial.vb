Imports System.Data.SqlClient

Public Class FrmBuscarOficial

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







    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Close()
    End Sub


    Private Sub BtnSeleccionar_Click(sender As Object, e As EventArgs) Handles BtnSeleccionar.Click
        FrmSolicitudPrestamo.TxtOficial.Text = LsvOficialCredito.FocusedItem.SubItems(0).Text
        Close()
    End Sub

    Private Sub FrmBuscarOficial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub


End Class