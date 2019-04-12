Imports System.Data.SqlClient
Public Class FrmBuscarTipoPrestamo

    Public Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub FrmTipoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LsvTipoPrestamo.Visible = True

    End Sub




    Private Sub MostrarTodo()
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using Cmd As New SqlCommand
            Cn.Open()

            Try
                With Cmd
                    .CommandText = "Sp_MostrarTipoPrestamo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn

                End With

                Dim VerTipoPrestamo As SqlDataReader
                VerTipoPrestamo = Cmd.ExecuteReader

                LsvTipoPrestamo.Items.Clear()

                While VerTipoPrestamo.Read = True
                    With LsvTipoPrestamo.Items.Add(VerTipoPrestamo("IdTipoPrestamo").ToString)
                        .SubItems.Add(VerTipoPrestamo("TipoPrestamo")).ToString()
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al consultar los datos", "Cooperativa XYZ" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
            Cn.Close()
        End Using

    End Sub

    Private Sub ToolStripMenuItemEditar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditar.Click
        FrmRegistroDePrestamo.TxtNumeroPrestamo.Text = LsvTipoPrestamo.FocusedItem.SubItems(0).Text
        FrmRegistroDePrestamo.TxtTipoPréstamo.Text = LsvTipoPrestamo.FocusedItem.SubItems(1).Text
        Close()
    End Sub
End Class