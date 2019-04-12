<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCuentaSocio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpCuentaSocio = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescripcionTipoCuenta = New System.Windows.Forms.TextBox()
        Me.TxtCodSocio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.DtpFechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNumCuenta = New System.Windows.Forms.TextBox()
        Me.TpListadoCuentasSocio = New System.Windows.Forms.TabPage()
        Me.LsvCuentaSocio = New System.Windows.Forms.ListView()
        Me.ChNumCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChCodSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDescripcionTipoCuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSaldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaApertura = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnBuscarSocio = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCerrar2 = New System.Windows.Forms.Button()
        Me.CmsOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TpCuentaSocio.SuspendLayout()
        Me.TpListadoCuentasSocio.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmsOpciones
        '
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemEditar, Me.ToolStripMenuItemEliminar})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(118, 48)
        '
        'ToolStripMenuItemEditar
        '
        Me.ToolStripMenuItemEditar.Name = "ToolStripMenuItemEditar"
        Me.ToolStripMenuItemEditar.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuItemEditar.Text = "Editar"
        '
        'ToolStripMenuItemEliminar
        '
        Me.ToolStripMenuItemEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripMenuItemEliminar.Name = "ToolStripMenuItemEliminar"
        Me.ToolStripMenuItemEliminar.Size = New System.Drawing.Size(117, 22)
        Me.ToolStripMenuItemEliminar.Text = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 456)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpCuentaSocio)
        Me.TabControl1.Controls.Add(Me.TpListadoCuentasSocio)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(968, 456)
        Me.TabControl1.TabIndex = 14
        '
        'TpCuentaSocio
        '
        Me.TpCuentaSocio.Controls.Add(Me.BtnBuscarSocio)
        Me.TpCuentaSocio.Controls.Add(Me.Label5)
        Me.TpCuentaSocio.Controls.Add(Me.TxtDescripcionTipoCuenta)
        Me.TpCuentaSocio.Controls.Add(Me.TxtCodSocio)
        Me.TpCuentaSocio.Controls.Add(Me.BtnCerrar)
        Me.TpCuentaSocio.Controls.Add(Me.Label6)
        Me.TpCuentaSocio.Controls.Add(Me.TxtSaldo)
        Me.TpCuentaSocio.Controls.Add(Me.Label2)
        Me.TpCuentaSocio.Controls.Add(Me.CboTipoCuenta)
        Me.TpCuentaSocio.Controls.Add(Me.DtpFechaApertura)
        Me.TpCuentaSocio.Controls.Add(Me.Label1)
        Me.TpCuentaSocio.Controls.Add(Me.PictureBox1)
        Me.TpCuentaSocio.Controls.Add(Me.BtnCancelar)
        Me.TpCuentaSocio.Controls.Add(Me.BtnModificar)
        Me.TpCuentaSocio.Controls.Add(Me.Label4)
        Me.TpCuentaSocio.Controls.Add(Me.BtnGuardar)
        Me.TpCuentaSocio.Controls.Add(Me.Label3)
        Me.TpCuentaSocio.Controls.Add(Me.BtnNuevo)
        Me.TpCuentaSocio.Controls.Add(Me.TxtNumCuenta)
        Me.TpCuentaSocio.Location = New System.Drawing.Point(4, 27)
        Me.TpCuentaSocio.Name = "TpCuentaSocio"
        Me.TpCuentaSocio.Padding = New System.Windows.Forms.Padding(3)
        Me.TpCuentaSocio.Size = New System.Drawing.Size(960, 425)
        Me.TpCuentaSocio.TabIndex = 0
        Me.TpCuentaSocio.Text = "Datos de cuenta de socio"
        Me.TpCuentaSocio.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(527, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(272, 24)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Descripción de Tipo de Cuenta"
        '
        'TxtDescripcionTipoCuenta
        '
        Me.TxtDescripcionTipoCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDescripcionTipoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcionTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionTipoCuenta.Location = New System.Drawing.Point(531, 72)
        Me.TxtDescripcionTipoCuenta.Multiline = True
        Me.TxtDescripcionTipoCuenta.Name = "TxtDescripcionTipoCuenta"
        Me.TxtDescripcionTipoCuenta.Size = New System.Drawing.Size(364, 120)
        Me.TxtDescripcionTipoCuenta.TabIndex = 53
        '
        'TxtCodSocio
        '
        Me.TxtCodSocio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCodSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSocio.Location = New System.Drawing.Point(232, 102)
        Me.TxtCodSocio.Name = "TxtCodSocio"
        Me.TxtCodSocio.Size = New System.Drawing.Size(206, 29)
        Me.TxtCodSocio.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 24)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Fecha de apertura"
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldo.Location = New System.Drawing.Point(232, 236)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(206, 29)
        Me.TxtSaldo.TabIndex = 34
        Me.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Saldo"
        '
        'CboTipoCuenta
        '
        Me.CboTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoCuenta.FormattingEnabled = True
        Me.CboTipoCuenta.Location = New System.Drawing.Point(232, 164)
        Me.CboTipoCuenta.Name = "CboTipoCuenta"
        Me.CboTipoCuenta.Size = New System.Drawing.Size(206, 28)
        Me.CboTipoCuenta.TabIndex = 32
        '
        'DtpFechaApertura
        '
        Me.DtpFechaApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaApertura.Location = New System.Drawing.Point(232, 305)
        Me.DtpFechaApertura.Name = "DtpFechaApertura"
        Me.DtpFechaApertura.Size = New System.Drawing.Size(206, 29)
        Me.DtpFechaApertura.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Código Socio"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = " Número de cuenta"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tipo Cuenta"
        '
        'TxtNumCuenta
        '
        Me.TxtNumCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNumCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumCuenta.Location = New System.Drawing.Point(232, 33)
        Me.TxtNumCuenta.Name = "TxtNumCuenta"
        Me.TxtNumCuenta.Size = New System.Drawing.Size(206, 29)
        Me.TxtNumCuenta.TabIndex = 23
        '
        'TpListadoCuentasSocio
        '
        Me.TpListadoCuentasSocio.Controls.Add(Me.BtnCerrar2)
        Me.TpListadoCuentasSocio.Controls.Add(Me.LsvCuentaSocio)
        Me.TpListadoCuentasSocio.Location = New System.Drawing.Point(4, 27)
        Me.TpListadoCuentasSocio.Name = "TpListadoCuentasSocio"
        Me.TpListadoCuentasSocio.Padding = New System.Windows.Forms.Padding(3)
        Me.TpListadoCuentasSocio.Size = New System.Drawing.Size(960, 425)
        Me.TpListadoCuentasSocio.TabIndex = 1
        Me.TpListadoCuentasSocio.Text = "Listado de cuentas de socio"
        Me.TpListadoCuentasSocio.UseVisualStyleBackColor = True
        '
        'LsvCuentaSocio
        '
        Me.LsvCuentaSocio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumCuenta, Me.ChCodSocio, Me.ChIdTipoCuenta, Me.ChDescripcionTipoCuenta, Me.ChSaldo, Me.ChFechaApertura})
        Me.LsvCuentaSocio.ContextMenuStrip = Me.CmsOpciones
        Me.LsvCuentaSocio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LsvCuentaSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvCuentaSocio.FullRowSelect = True
        Me.LsvCuentaSocio.GridLines = True
        Me.LsvCuentaSocio.HideSelection = False
        Me.LsvCuentaSocio.Location = New System.Drawing.Point(3, 79)
        Me.LsvCuentaSocio.Name = "LsvCuentaSocio"
        Me.LsvCuentaSocio.Size = New System.Drawing.Size(954, 343)
        Me.LsvCuentaSocio.TabIndex = 14
        Me.LsvCuentaSocio.UseCompatibleStateImageBehavior = False
        Me.LsvCuentaSocio.View = System.Windows.Forms.View.Details
        '
        'ChNumCuenta
        '
        Me.ChNumCuenta.Text = "Número de Cuenta"
        Me.ChNumCuenta.Width = 150
        '
        'ChCodSocio
        '
        Me.ChCodSocio.Text = "Código de Socio"
        Me.ChCodSocio.Width = 150
        '
        'ChIdTipoCuenta
        '
        Me.ChIdTipoCuenta.Text = "Tipo de Cuenta"
        Me.ChIdTipoCuenta.Width = 150
        '
        'ChDescripcionTipoCuenta
        '
        Me.ChDescripcionTipoCuenta.Text = "Descripción de Tipo de Cuenta"
        Me.ChDescripcionTipoCuenta.Width = 300
        '
        'ChSaldo
        '
        Me.ChSaldo.Text = "Saldo"
        Me.ChSaldo.Width = 150
        '
        'ChFechaApertura
        '
        Me.ChFechaApertura.Text = "Fecha de Apertura"
        Me.ChFechaApertura.Width = 150
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'BtnBuscarSocio
        '
        Me.BtnBuscarSocio.BackColor = System.Drawing.Color.Black
        Me.BtnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarSocio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBuscarSocio.Location = New System.Drawing.Point(438, 101)
        Me.BtnBuscarSocio.Name = "BtnBuscarSocio"
        Me.BtnBuscarSocio.Size = New System.Drawing.Size(42, 29)
        Me.BtnBuscarSocio.TabIndex = 54
        Me.BtnBuscarSocio.Text = "..."
        Me.BtnBuscarSocio.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCerrar.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconCerrar
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Location = New System.Drawing.Point(923, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(37, 33)
        Me.BtnCerrar.TabIndex = 50
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.LogoCooperativa
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(715, 351)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 71)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.cancelar
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Location = New System.Drawing.Point(572, 373)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(39, 43)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.editar
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Location = New System.Drawing.Point(483, 373)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(39, 43)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.guardar_archivo_opcion
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(398, 373)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(39, 43)
        Me.BtnGuardar.TabIndex = 26
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.AccessibleDescription = ""
        Me.BtnNuevo.AccessibleName = ""
        Me.BtnNuevo.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.boton_nuevo_documento
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Location = New System.Drawing.Point(308, 373)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(39, 43)
        Me.BtnNuevo.TabIndex = 25
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnCerrar2
        '
        Me.BtnCerrar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCerrar2.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconCerrar
        Me.BtnCerrar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar2.FlatAppearance.BorderSize = 0
        Me.BtnCerrar2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar2.Location = New System.Drawing.Point(922, 1)
        Me.BtnCerrar2.Name = "BtnCerrar2"
        Me.BtnCerrar2.Size = New System.Drawing.Size(37, 33)
        Me.BtnCerrar2.TabIndex = 51
        Me.BtnCerrar2.UseVisualStyleBackColor = False
        '
        'FrmCuentaSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCuentaSocio"
        Me.Text = "Form1"
        Me.CmsOpciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TpCuentaSocio.ResumeLayout(False)
        Me.TpCuentaSocio.PerformLayout()
        Me.TpListadoCuentasSocio.ResumeLayout(False)
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemEditar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemEliminar As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpCuentaSocio As TabPage
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtNumCuenta As TextBox
    Friend WithEvents TpListadoCuentasSocio As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CboTipoCuenta As ComboBox
    Friend WithEvents DtpFechaApertura As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LsvCuentaSocio As ListView
    Friend WithEvents ChNumCuenta As ColumnHeader
    Friend WithEvents ChCodSocio As ColumnHeader
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents ChIdTipoCuenta As ColumnHeader
    Friend WithEvents ChSaldo As ColumnHeader
    Friend WithEvents ChFechaApertura As ColumnHeader
    Friend WithEvents BtnCerrar2 As Button
    Friend WithEvents TxtCodSocio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDescripcionTipoCuenta As TextBox
    Friend WithEvents ChDescripcionTipoCuenta As ColumnHeader
    Friend WithEvents BtnBuscarSocio As Button
End Class

