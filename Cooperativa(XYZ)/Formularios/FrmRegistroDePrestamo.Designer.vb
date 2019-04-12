<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroDePrestamo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GbxTipoPrestamo = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarTipoPrestamo = New System.Windows.Forms.Button()
        Me.TxtFechaSolicitud = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtTipoPréstamo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtNumeroPrestamo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbxSocio = New System.Windows.Forms.GroupBox()
        Me.BtnBuscarSocio = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtNacionalidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtRtn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtNombreSocio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIdentidadSociedad = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LsvCuentaSocio = New System.Windows.Forms.ListView()
        Me.ChNumeroDeCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDescripcionTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSaldoActual = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GbxDatosPrestamo = New System.Windows.Forms.GroupBox()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TxtFinalidadPrestamo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.FinalidadPrestamo2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TxtTasaInteres = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.TxtSumaOtorgada = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.TxtPlazoPago = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LscSocio = New System.Windows.Forms.ListView()
        Me.ChCodigoSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChLugarTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefonoCasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefonoTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.TxtIdentidadOficial = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.TxtNombreOficial = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.TxtEstadoCivil = New System.Windows.Forms.TextBox()
        Me.GbxTipoPrestamo.SuspendLayout()
        Me.GbxSocio.SuspendLayout()
        Me.GbxDatosPrestamo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbxTipoPrestamo
        '
        Me.GbxTipoPrestamo.Controls.Add(Me.BtnBuscarTipoPrestamo)
        Me.GbxTipoPrestamo.Controls.Add(Me.TxtFechaSolicitud)
        Me.GbxTipoPrestamo.Controls.Add(Me.Label3)
        Me.GbxTipoPrestamo.Controls.Add(Me.Panel2)
        Me.GbxTipoPrestamo.Controls.Add(Me.TxtTipoPréstamo)
        Me.GbxTipoPrestamo.Controls.Add(Me.Label2)
        Me.GbxTipoPrestamo.Controls.Add(Me.Panel1)
        Me.GbxTipoPrestamo.Controls.Add(Me.TxtNumeroPrestamo)
        Me.GbxTipoPrestamo.Controls.Add(Me.Label1)
        Me.GbxTipoPrestamo.Location = New System.Drawing.Point(12, 62)
        Me.GbxTipoPrestamo.Name = "GbxTipoPrestamo"
        Me.GbxTipoPrestamo.Size = New System.Drawing.Size(755, 72)
        Me.GbxTipoPrestamo.TabIndex = 1
        Me.GbxTipoPrestamo.TabStop = False
        '
        'BtnBuscarTipoPrestamo
        '
        Me.BtnBuscarTipoPrestamo.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconBuscar
        Me.BtnBuscarTipoPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarTipoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarTipoPrestamo.Location = New System.Drawing.Point(255, 6)
        Me.BtnBuscarTipoPrestamo.Name = "BtnBuscarTipoPrestamo"
        Me.BtnBuscarTipoPrestamo.Size = New System.Drawing.Size(32, 25)
        Me.BtnBuscarTipoPrestamo.TabIndex = 8
        Me.BtnBuscarTipoPrestamo.UseVisualStyleBackColor = True
        '
        'TxtFechaSolicitud
        '
        Me.TxtFechaSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaSolicitud.Location = New System.Drawing.Point(144, 46)
        Me.TxtFechaSolicitud.Mask = "00/00/0000"
        Me.TxtFechaSolicitud.Name = "TxtFechaSolicitud"
        Me.TxtFechaSolicitud.ReadOnly = True
        Me.TxtFechaSolicitud.Size = New System.Drawing.Size(113, 15)
        Me.TxtFechaSolicitud.TabIndex = 7
        Me.TxtFechaSolicitud.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de Solicitud:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(420, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 1)
        Me.Panel2.TabIndex = 5
        '
        'TxtTipoPréstamo
        '
        Me.TxtTipoPréstamo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTipoPréstamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTipoPréstamo.Location = New System.Drawing.Point(420, 12)
        Me.TxtTipoPréstamo.Name = "TxtTipoPréstamo"
        Me.TxtTipoPréstamo.ReadOnly = True
        Me.TxtTipoPréstamo.Size = New System.Drawing.Size(182, 15)
        Me.TxtTipoPréstamo.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tipo de Préstamo:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(138, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(111, 1)
        Me.Panel1.TabIndex = 2
        '
        'TxtNumeroPrestamo
        '
        Me.TxtNumeroPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNumeroPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroPrestamo.Location = New System.Drawing.Point(138, 13)
        Me.TxtNumeroPrestamo.Name = "TxtNumeroPrestamo"
        Me.TxtNumeroPrestamo.ReadOnly = True
        Me.TxtNumeroPrestamo.Size = New System.Drawing.Size(111, 15)
        Me.TxtNumeroPrestamo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número de Préstamo:"
        '
        'GbxSocio
        '
        Me.GbxSocio.Controls.Add(Me.Panel14)
        Me.GbxSocio.Controls.Add(Me.TxtEstadoCivil)
        Me.GbxSocio.Controls.Add(Me.BtnBuscarSocio)
        Me.GbxSocio.Controls.Add(Me.Panel6)
        Me.GbxSocio.Controls.Add(Me.TxtDireccion)
        Me.GbxSocio.Controls.Add(Me.Label11)
        Me.GbxSocio.Controls.Add(Me.Label10)
        Me.GbxSocio.Controls.Add(Me.Panel5)
        Me.GbxSocio.Controls.Add(Me.TxtNacionalidad)
        Me.GbxSocio.Controls.Add(Me.Label9)
        Me.GbxSocio.Controls.Add(Me.Panel4)
        Me.GbxSocio.Controls.Add(Me.TxtRtn)
        Me.GbxSocio.Controls.Add(Me.Label8)
        Me.GbxSocio.Controls.Add(Me.Panel3)
        Me.GbxSocio.Controls.Add(Me.TxtNombreSocio)
        Me.GbxSocio.Controls.Add(Me.Label7)
        Me.GbxSocio.Controls.Add(Me.TxtIdentidadSociedad)
        Me.GbxSocio.Controls.Add(Me.Label6)
        Me.GbxSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxSocio.Location = New System.Drawing.Point(12, 136)
        Me.GbxSocio.Name = "GbxSocio"
        Me.GbxSocio.Size = New System.Drawing.Size(755, 110)
        Me.GbxSocio.TabIndex = 2
        Me.GbxSocio.TabStop = False
        Me.GbxSocio.Text = "Datos Generales del Socio"
        '
        'BtnBuscarSocio
        '
        Me.BtnBuscarSocio.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconBuscar
        Me.BtnBuscarSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarSocio.Location = New System.Drawing.Point(277, 12)
        Me.BtnBuscarSocio.Name = "BtnBuscarSocio"
        Me.BtnBuscarSocio.Size = New System.Drawing.Size(32, 25)
        Me.BtnBuscarSocio.TabIndex = 23
        Me.BtnBuscarSocio.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(68, 98)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(373, 1)
        Me.Panel6.TabIndex = 22
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(67, 83)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(373, 15)
        Me.TxtDireccion.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 16)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(452, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Estado Civil:"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(302, 66)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(139, 1)
        Me.Panel5.TabIndex = 17
        '
        'TxtNacionalidad
        '
        Me.TxtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNacionalidad.Location = New System.Drawing.Point(301, 51)
        Me.TxtNacionalidad.Name = "TxtNacionalidad"
        Me.TxtNacionalidad.ReadOnly = True
        Me.TxtNacionalidad.Size = New System.Drawing.Size(139, 15)
        Me.TxtNacionalidad.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(213, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Nacionalidad:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(36, 65)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(168, 1)
        Me.Panel4.TabIndex = 14
        '
        'TxtRtn
        '
        Me.TxtRtn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtRtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRtn.Location = New System.Drawing.Point(35, 50)
        Me.TxtRtn.Name = "TxtRtn"
        Me.TxtRtn.ReadOnly = True
        Me.TxtRtn.Size = New System.Drawing.Size(168, 15)
        Me.TxtRtn.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-1, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "RTN:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(462, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(187, 1)
        Me.Panel3.TabIndex = 11
        '
        'TxtNombreSocio
        '
        Me.TxtNombreSocio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreSocio.Location = New System.Drawing.Point(461, 20)
        Me.TxtNombreSocio.Name = "TxtNombreSocio"
        Me.TxtNombreSocio.ReadOnly = True
        Me.TxtNombreSocio.Size = New System.Drawing.Size(187, 15)
        Me.TxtNombreSocio.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(344, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Nombre del Socio:"
        '
        'TxtIdentidadSociedad
        '
        Me.TxtIdentidadSociedad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdentidadSociedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentidadSociedad.Location = New System.Drawing.Point(120, 21)
        Me.TxtIdentidadSociedad.Mask = "0000-0000-0000"
        Me.TxtIdentidadSociedad.Name = "TxtIdentidadSociedad"
        Me.TxtIdentidadSociedad.ReadOnly = True
        Me.TxtIdentidadSociedad.Size = New System.Drawing.Size(151, 15)
        Me.TxtIdentidadSociedad.TabIndex = 8
        Me.TxtIdentidadSociedad.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-1, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Identidad de Socio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Registro de Préstamos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 259)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Cuentas de socios  en la cooperativa:"
        '
        'LsvCuentaSocio
        '
        Me.LsvCuentaSocio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumeroDeCuenta, Me.ChTipoCuenta, Me.ChDescripcionTipoCuenta, Me.ChSaldoActual})
        Me.LsvCuentaSocio.FullRowSelect = True
        Me.LsvCuentaSocio.GridLines = True
        Me.LsvCuentaSocio.Location = New System.Drawing.Point(12, 277)
        Me.LsvCuentaSocio.Name = "LsvCuentaSocio"
        Me.LsvCuentaSocio.Size = New System.Drawing.Size(660, 97)
        Me.LsvCuentaSocio.TabIndex = 11
        Me.LsvCuentaSocio.UseCompatibleStateImageBehavior = False
        Me.LsvCuentaSocio.View = System.Windows.Forms.View.Details
        '
        'ChNumeroDeCuenta
        '
        Me.ChNumeroDeCuenta.Text = "Número de Cuenta"
        Me.ChNumeroDeCuenta.Width = 140
        '
        'ChTipoCuenta
        '
        Me.ChTipoCuenta.Text = "Tipo de Cuenta"
        Me.ChTipoCuenta.Width = 150
        '
        'ChDescripcionTipoCuenta
        '
        Me.ChDescripcionTipoCuenta.Text = "Descripción de Tipo Cuenta"
        Me.ChDescripcionTipoCuenta.Width = 250
        '
        'ChSaldoActual
        '
        Me.ChSaldoActual.Text = "Saldo Actual"
        Me.ChSaldoActual.Width = 120
        '
        'GbxDatosPrestamo
        '
        Me.GbxDatosPrestamo.Controls.Add(Me.Panel11)
        Me.GbxDatosPrestamo.Controls.Add(Me.TxtFinalidadPrestamo)
        Me.GbxDatosPrestamo.Controls.Add(Me.Label18)
        Me.GbxDatosPrestamo.Controls.Add(Me.Panel7)
        Me.GbxDatosPrestamo.Controls.Add(Me.FinalidadPrestamo2)
        Me.GbxDatosPrestamo.Controls.Add(Me.Label14)
        Me.GbxDatosPrestamo.Controls.Add(Me.Panel8)
        Me.GbxDatosPrestamo.Controls.Add(Me.TxtTasaInteres)
        Me.GbxDatosPrestamo.Controls.Add(Me.Label15)
        Me.GbxDatosPrestamo.Controls.Add(Me.Panel9)
        Me.GbxDatosPrestamo.Controls.Add(Me.TxtSumaOtorgada)
        Me.GbxDatosPrestamo.Controls.Add(Me.Label16)
        Me.GbxDatosPrestamo.Controls.Add(Me.Panel10)
        Me.GbxDatosPrestamo.Controls.Add(Me.TxtPlazoPago)
        Me.GbxDatosPrestamo.Controls.Add(Me.Label17)
        Me.GbxDatosPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbxDatosPrestamo.Location = New System.Drawing.Point(12, 379)
        Me.GbxDatosPrestamo.Name = "GbxDatosPrestamo"
        Me.GbxDatosPrestamo.Size = New System.Drawing.Size(755, 110)
        Me.GbxDatosPrestamo.TabIndex = 12
        Me.GbxDatosPrestamo.TabStop = False
        Me.GbxDatosPrestamo.Text = "Datos del Préstamo:"
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel11.Location = New System.Drawing.Point(400, 64)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(234, 1)
        Me.Panel11.TabIndex = 13
        '
        'TxtFinalidadPrestamo
        '
        Me.TxtFinalidadPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFinalidadPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFinalidadPrestamo.Location = New System.Drawing.Point(399, 49)
        Me.TxtFinalidadPrestamo.Name = "TxtFinalidadPrestamo"
        Me.TxtFinalidadPrestamo.ReadOnly = True
        Me.TxtFinalidadPrestamo.Size = New System.Drawing.Size(234, 15)
        Me.TxtFinalidadPrestamo.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(220, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 16)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "%"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(7, 95)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(373, 1)
        Me.Panel7.TabIndex = 22
        '
        'FinalidadPrestamo2
        '
        Me.FinalidadPrestamo2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FinalidadPrestamo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalidadPrestamo2.Location = New System.Drawing.Point(8, 80)
        Me.FinalidadPrestamo2.Name = "FinalidadPrestamo2"
        Me.FinalidadPrestamo2.ReadOnly = True
        Me.FinalidadPrestamo2.Size = New System.Drawing.Size(373, 15)
        Me.FinalidadPrestamo2.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(247, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(147, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Finalidad de Préstamo:"
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel8.Location = New System.Drawing.Point(162, 67)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(53, 1)
        Me.Panel8.TabIndex = 17
        '
        'TxtTasaInteres
        '
        Me.TxtTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTasaInteres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTasaInteres.Location = New System.Drawing.Point(161, 52)
        Me.TxtTasaInteres.Name = "TxtTasaInteres"
        Me.TxtTasaInteres.ReadOnly = True
        Me.TxtTasaInteres.Size = New System.Drawing.Size(53, 15)
        Me.TxtTasaInteres.TabIndex = 16
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Tasa de interés a aplicar:"
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel9.Location = New System.Drawing.Point(104, 35)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(168, 1)
        Me.Panel9.TabIndex = 14
        '
        'TxtSumaOtorgada
        '
        Me.TxtSumaOtorgada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSumaOtorgada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSumaOtorgada.Location = New System.Drawing.Point(103, 20)
        Me.TxtSumaOtorgada.Name = "TxtSumaOtorgada"
        Me.TxtSumaOtorgada.ReadOnly = True
        Me.TxtSumaOtorgada.Size = New System.Drawing.Size(168, 15)
        Me.TxtSumaOtorgada.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(-1, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 16)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Suma Otorgada:"
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(436, 34)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(199, 1)
        Me.Panel10.TabIndex = 11
        '
        'TxtPlazoPago
        '
        Me.TxtPlazoPago.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPlazoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlazoPago.Location = New System.Drawing.Point(435, 19)
        Me.TxtPlazoPago.Name = "TxtPlazoPago"
        Me.TxtPlazoPago.ReadOnly = True
        Me.TxtPlazoPago.Size = New System.Drawing.Size(199, 15)
        Me.TxtPlazoPago.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(330, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 16)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Plazo de Pago:"
        '
        'LscSocio
        '
        Me.LscSocio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodigoSocio, Me.ChNombre, Me.ChDireccion, Me.ChLugarTrabajo, Me.ChTelefonoCasa, Me.ChTelefonoTrabajo})
        Me.LscSocio.FullRowSelect = True
        Me.LscSocio.GridLines = True
        Me.LscSocio.Location = New System.Drawing.Point(12, 511)
        Me.LscSocio.Name = "LscSocio"
        Me.LscSocio.Size = New System.Drawing.Size(755, 97)
        Me.LscSocio.TabIndex = 14
        Me.LscSocio.UseCompatibleStateImageBehavior = False
        Me.LscSocio.View = System.Windows.Forms.View.Details
        '
        'ChCodigoSocio
        '
        Me.ChCodigoSocio.Text = "Identidad Socio"
        Me.ChCodigoSocio.Width = 130
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre"
        Me.ChNombre.Width = 150
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Dirección"
        Me.ChDireccion.Width = 150
        '
        'ChLugarTrabajo
        '
        Me.ChLugarTrabajo.Text = "Lugar Trabajo"
        Me.ChLugarTrabajo.Width = 120
        '
        'ChTelefonoCasa
        '
        Me.ChTelefonoCasa.Text = "Tel. Casa"
        Me.ChTelefonoCasa.Width = 100
        '
        'ChTelefonoTrabajo
        '
        Me.ChTelefonoTrabajo.Text = "Tel. Trabajo"
        Me.ChTelefonoTrabajo.Width = 100
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 492)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Información sobre Avales:"
        '
        'Panel12
        '
        Me.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel12.Location = New System.Drawing.Point(184, 634)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(168, 1)
        Me.Panel12.TabIndex = 17
        '
        'TxtIdentidadOficial
        '
        Me.TxtIdentidadOficial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdentidadOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentidadOficial.Location = New System.Drawing.Point(184, 619)
        Me.TxtIdentidadOficial.Name = "TxtIdentidadOficial"
        Me.TxtIdentidadOficial.ReadOnly = True
        Me.TxtIdentidadOficial.Size = New System.Drawing.Size(168, 15)
        Me.TxtIdentidadOficial.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(13, 621)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(170, 16)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "Identidad Oficial de crédito:"
        '
        'Panel13
        '
        Me.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel13.Location = New System.Drawing.Point(584, 633)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(168, 1)
        Me.Panel13.TabIndex = 20
        '
        'TxtNombreOficial
        '
        Me.TxtNombreOficial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreOficial.Location = New System.Drawing.Point(584, 618)
        Me.TxtNombreOficial.Name = "TxtNombreOficial"
        Me.TxtNombreOficial.ReadOnly = True
        Me.TxtNombreOficial.Size = New System.Drawing.Size(168, 15)
        Me.TxtNombreOficial.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(414, 620)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(166, 16)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Nombre oficial de Crédito: "
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconCerrar1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(756, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.LogoCooperativa
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(11, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 84)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Image = Global.Cooperativa_XYZ_.My.Resources.Resources.cancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(508, 649)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(39, 43)
        Me.BtnCancelar.TabIndex = 26
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Image = Global.Cooperativa_XYZ_.My.Resources.Resources.editar
        Me.BtnModificar.Location = New System.Drawing.Point(419, 649)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(39, 43)
        Me.BtnModificar.TabIndex = 25
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Image = Global.Cooperativa_XYZ_.My.Resources.Resources.guardar_archivo_opcion
        Me.BtnGuardar.Location = New System.Drawing.Point(334, 649)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(39, 43)
        Me.BtnGuardar.TabIndex = 24
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.AccessibleDescription = ""
        Me.BtnNuevo.AccessibleName = ""
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Image = Global.Cooperativa_XYZ_.My.Resources.Resources.boton_nuevo_documento
        Me.BtnNuevo.Location = New System.Drawing.Point(244, 649)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(39, 43)
        Me.BtnNuevo.TabIndex = 23
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel14.Location = New System.Drawing.Point(540, 65)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(139, 1)
        Me.Panel14.TabIndex = 25
        '
        'TxtEstadoCivil
        '
        Me.TxtEstadoCivil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstadoCivil.Location = New System.Drawing.Point(539, 50)
        Me.TxtEstadoCivil.Name = "TxtEstadoCivil"
        Me.TxtEstadoCivil.ReadOnly = True
        Me.TxtEstadoCivil.Size = New System.Drawing.Size(139, 15)
        Me.TxtEstadoCivil.TabIndex = 24
        '
        'FrmRegistroDePrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(786, 694)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.TxtNombreOficial)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.TxtIdentidadOficial)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LscSocio)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GbxDatosPrestamo)
        Me.Controls.Add(Me.LsvCuentaSocio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GbxSocio)
        Me.Controls.Add(Me.GbxTipoPrestamo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegistroDePrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistroDePrestamo"
        Me.GbxTipoPrestamo.ResumeLayout(False)
        Me.GbxTipoPrestamo.PerformLayout()
        Me.GbxSocio.ResumeLayout(False)
        Me.GbxSocio.PerformLayout()
        Me.GbxDatosPrestamo.ResumeLayout(False)
        Me.GbxDatosPrestamo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GbxTipoPrestamo As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtNumeroPrestamo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFechaSolicitud As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtTipoPréstamo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GbxSocio As GroupBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TxtNacionalidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtRtn As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtNombreSocio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtIdentidadSociedad As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents LsvCuentaSocio As ListView
    Friend WithEvents ChNumeroDeCuenta As ColumnHeader
    Friend WithEvents ChTipoCuenta As ColumnHeader
    Friend WithEvents ChDescripcionTipoCuenta As ColumnHeader
    Friend WithEvents ChSaldoActual As ColumnHeader
    Friend WithEvents GbxDatosPrestamo As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents FinalidadPrestamo2 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TxtTasaInteres As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents TxtSumaOtorgada As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TxtPlazoPago As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TxtFinalidadPrestamo As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents LscSocio As ListView
    Friend WithEvents ChCodigoSocio As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChLugarTrabajo As ColumnHeader
    Friend WithEvents ChTelefonoCasa As ColumnHeader
    Friend WithEvents ChTelefonoTrabajo As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TxtIdentidadOficial As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents TxtNombreOficial As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnBuscarTipoPrestamo As Button
    Friend WithEvents BtnBuscarSocio As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents TxtEstadoCivil As TextBox
End Class
