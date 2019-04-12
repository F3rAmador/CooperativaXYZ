Imports System.Data.SqlClient

Public Class FrmLogin
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Close()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        WindowState = WindowState.Minimized
    End Sub
    Private Sub TxtUsuario_Enter(sender As Object, e As EventArgs) Handles TxtUsuario.Enter
        If TxtUsuario.Text = "USUARIO" Then
            TxtUsuario.Text = ""
            TxtUsuario.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TxtUsuario_Leave(sender As Object, e As EventArgs) Handles TxtUsuario.Leave
        If TxtUsuario.Text = "" Then
            TxtUsuario.Text = "USUARIO"
            TxtUsuario.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub TxtContraseña_Enter(sender As Object, e As EventArgs) Handles TxtContraseña.Enter
        If TxtContraseña.Text = "CONTRASEÑA" Then
            TxtContraseña.Text = ""
            TxtContraseña.ForeColor = Color.Black
            TxtContraseña.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TxtContraseña_Leave(sender As Object, e As EventArgs) Handles TxtContraseña.Leave
        If TxtContraseña.Text = "" Then
            TxtContraseña.Text = "CONTRASEÑA"
            TxtContraseña.ForeColor = Color.Gray
            TxtContraseña.UseSystemPasswordChar = False
        End If
    End Sub
    Private Function BuscarNombreUsuario()
        Dim Estado As Boolean = 0
        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_BuscarNombreUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text
                End With

                Dim VerUsuario As SqlDataReader
                VerUsuario = CMd.ExecuteReader()

                If VerUsuario.Read = True Then
                    If VerUsuario("Encontrado") < 1 Then
                        Estado = False
                    Else
                        Estado = True
                    End If
                End If

            Catch ex As Exception
                Estado = False
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using
        Return Estado
    End Function

    Private Function BuscarContraseñaUsuario()
        Dim Estado As Boolean = 0

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_BuscarContraseñaUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text
                End With

                Dim VerContraseña As SqlDataReader
                VerContraseña = CMd.ExecuteReader()

                If VerContraseña.Read = True Then
                    If VerContraseña("ContraseñaEncontrada") <> TxtContraseña.Text Then
                        Estado = False
                    Else
                        Estado = True
                    End If

                End If


            Catch ex As Exception
                Estado = False
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using

        Return Estado
    End Function

    Private Function BuscarUsuarioAdmin()
        Dim Estado As Boolean = 0

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_BuscarUsuarioAdmin"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text
                End With

                Dim VerAdmin As SqlDataReader
                VerAdmin = CMd.ExecuteReader()

                If VerAdmin.Read = True Then
                    If VerAdmin("AdminEncontrado") <> True Then
                        Estado = False
                    Else
                        Estado = True
                    End If

                End If


            Catch ex As Exception
                Estado = False
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using

        Return Estado
    End Function

    Private Function BuscarEstadoUsuario()
        Dim Estado As Boolean = 0

        If Cn.State = ConnectionState.Open Then
            Cn.Close()
        End If

        Using CMd As New SqlCommand
            Cn.Open()

            Try
                With CMd
                    .CommandText = "Sp_BuscarEstadoUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Cn
                    .Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = TxtUsuario.Text
                End With

                Dim VerEstado As SqlDataReader
                VerEstado = CMd.ExecuteReader()

                If VerEstado.Read = True Then
                    If VerEstado("EstadoUsuario") <> True Then
                        Estado = False
                    Else
                        Estado = True
                    End If

                End If


            Catch ex As Exception
                Estado = False
                MessageBox.Show("Error al consultar los datos." + ex.Message, "CoexmarSystem", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Finally
                Cn.Close()
            End Try
        End Using

        Return Estado
    End Function
    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        If BuscarNombreUsuario() = True Then
            If BuscarContraseñaUsuario() = True Then
                If BuscarEstadoUsuario() = True Then
                    If BuscarUsuarioAdmin() = True Then
                        FrmPrincipalAdmin.LblUsuario.Text = TxtUsuario.Text
                        TxtUsuario.Text = "USUARIO"
                        TxtUsuario.ForeColor = Color.Gray
                        TxtContraseña.Text = "CONTRASEÑA"
                        TxtContraseña.ForeColor = Color.Gray
                        TxtContraseña.UseSystemPasswordChar = False
                        FrmPrincipalAdmin.ShowDialog()
                    Else
                        ' FrmPrincipalUser.LblUsuario.Text = TxtUsuario.Text
                        TxtUsuario.Text = "USUARIO"
                        TxtUsuario.ForeColor = Color.Gray
                        TxtContraseña.Text = "CONTRASEÑA"
                        TxtContraseña.ForeColor = Color.Gray
                        TxtContraseña.UseSystemPasswordChar = False

                        ' FrmPrincipalUser.ShowDialog()
                    End If
                Else
                    LblMensaje.Text = "¡Usuario Inactivo!"
                End If
            Else
                LblMensaje.Text = "¡Constraseña Incorrecta!"
                TxtContraseña.Focus()
            End If
        Else
            LblMensaje.Text = "¡Este Usuario no existe!"
            TxtUsuario.Focus()
        End If
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged
        BuscarNombreUsuario()
        LblMensaje.Text = ""
    End Sub

    Private Sub TxtContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtContraseña.TextChanged
        BuscarContraseñaUsuario()
        LblMensaje.Text = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class