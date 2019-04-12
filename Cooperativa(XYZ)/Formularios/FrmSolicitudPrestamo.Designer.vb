<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitudPrestamo
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TcOpciones = New System.Windows.Forms.TabControl()
        Me.BtnSalir = New System.Windows.Forms.TabPage()
        Me.BtnBuscarOficial = New System.Windows.Forms.Button()
        Me.BtnBuscarSocio = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.CboEstadoPrestamo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtOficial = New System.Windows.Forms.TextBox()
        Me.TxtPlazoPago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtSumaOtorgada = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.CboFinalidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboTipoPrestamo = New System.Windows.Forms.ComboBox()
        Me.DtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtNumeroSolicitud = New System.Windows.Forms.TextBox()
        Me.TpListadoDeSolicitudDePrestamo = New System.Windows.Forms.TabPage()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnSalir1 = New System.Windows.Forms.Button()
        Me.LsvSolicitudPrestamo = New System.Windows.Forms.ListView()
        Me.ChNumSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaDeSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTipoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChPlazoDePago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFinalidadDelPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSumaOtorgada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChOficial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CmsOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TcOpciones.SuspendLayout()
        Me.BtnSalir.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpListadoDeSolicitudDePrestamo.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Controls.Add(Me.TcOpciones)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 469)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'TcOpciones
        '
        Me.TcOpciones.Controls.Add(Me.BtnSalir)
        Me.TcOpciones.Controls.Add(Me.TpListadoDeSolicitudDePrestamo)
        Me.TcOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TcOpciones.Location = New System.Drawing.Point(0, 0)
        Me.TcOpciones.Name = "TcOpciones"
        Me.TcOpciones.SelectedIndex = 0
        Me.TcOpciones.Size = New System.Drawing.Size(968, 463)
        Me.TcOpciones.TabIndex = 0
        '
        'BtnSalir
        '
        Me.BtnSalir.Controls.Add(Me.BtnBuscarOficial)
        Me.BtnSalir.Controls.Add(Me.BtnBuscarSocio)
        Me.BtnSalir.Controls.Add(Me.BtnCerrar)
        Me.BtnSalir.Controls.Add(Me.CboEstadoPrestamo)
        Me.BtnSalir.Controls.Add(Me.Label10)
        Me.BtnSalir.Controls.Add(Me.Label9)
        Me.BtnSalir.Controls.Add(Me.TxtOficial)
        Me.BtnSalir.Controls.Add(Me.TxtPlazoPago)
        Me.BtnSalir.Controls.Add(Me.Label6)
        Me.BtnSalir.Controls.Add(Me.TxtSumaOtorgada)
        Me.BtnSalir.Controls.Add(Me.Label8)
        Me.BtnSalir.Controls.Add(Me.Label7)
        Me.BtnSalir.Controls.Add(Me.TxtTasa)
        Me.BtnSalir.Controls.Add(Me.CboFinalidad)
        Me.BtnSalir.Controls.Add(Me.Label5)
        Me.BtnSalir.Controls.Add(Me.TxtSocio)
        Me.BtnSalir.Controls.Add(Me.Label2)
        Me.BtnSalir.Controls.Add(Me.CboTipoPrestamo)
        Me.BtnSalir.Controls.Add(Me.DtpFechaSolicitud)
        Me.BtnSalir.Controls.Add(Me.Label1)
        Me.BtnSalir.Controls.Add(Me.PictureBox1)
        Me.BtnSalir.Controls.Add(Me.BtnCancelar)
        Me.BtnSalir.Controls.Add(Me.BtnModificar)
        Me.BtnSalir.Controls.Add(Me.Label4)
        Me.BtnSalir.Controls.Add(Me.BtnGuardar)
        Me.BtnSalir.Controls.Add(Me.Label3)
        Me.BtnSalir.Controls.Add(Me.BtnNuevo)
        Me.BtnSalir.Controls.Add(Me.TxtNumeroSolicitud)
        Me.BtnSalir.Location = New System.Drawing.Point(4, 27)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Padding = New System.Windows.Forms.Padding(3)
        Me.BtnSalir.Size = New System.Drawing.Size(960, 432)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Datos de solicitud de préstamo"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnBuscarOficial
        '
        Me.BtnBuscarOficial.BackColor = System.Drawing.Color.Black
        Me.BtnBuscarOficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarOficial.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBuscarOficial.Location = New System.Drawing.Point(885, 234)
        Me.BtnBuscarOficial.Name = "BtnBuscarOficial"
        Me.BtnBuscarOficial.Size = New System.Drawing.Size(42, 29)
        Me.BtnBuscarOficial.TabIndex = 52
        Me.BtnBuscarOficial.Text = "..."
        Me.BtnBuscarOficial.UseVisualStyleBackColor = False
        '
        'BtnBuscarSocio
        '
        Me.BtnBuscarSocio.BackColor = System.Drawing.Color.Black
        Me.BtnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarSocio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnBuscarSocio.Location = New System.Drawing.Point(435, 236)
        Me.BtnBuscarSocio.Name = "BtnBuscarSocio"
        Me.BtnBuscarSocio.Size = New System.Drawing.Size(42, 29)
        Me.BtnBuscarSocio.TabIndex = 51
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
        Me.BtnCerrar.Location = New System.Drawing.Point(923, 7)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(37, 33)
        Me.BtnCerrar.TabIndex = 50
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'CboEstadoPrestamo
        '
        Me.CboEstadoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstadoPrestamo.FormattingEnabled = True
        Me.CboEstadoPrestamo.Location = New System.Drawing.Point(683, 306)
        Me.CboEstadoPrestamo.Name = "CboEstadoPrestamo"
        Me.CboEstadoPrestamo.Size = New System.Drawing.Size(206, 28)
        Me.CboEstadoPrestamo.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(478, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(179, 24)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Estado de Préstamo"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(596, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 24)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Oficial"
        '
        'TxtOficial
        '
        Me.TxtOficial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOficial.Location = New System.Drawing.Point(683, 234)
        Me.TxtOficial.Name = "TxtOficial"
        Me.TxtOficial.Size = New System.Drawing.Size(206, 29)
        Me.TxtOficial.TabIndex = 46
        '
        'TxtPlazoPago
        '
        Me.TxtPlazoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlazoPago.Location = New System.Drawing.Point(229, 306)
        Me.TxtPlazoPago.Name = "TxtPlazoPago"
        Me.TxtPlazoPago.Size = New System.Drawing.Size(206, 29)
        Me.TxtPlazoPago.TabIndex = 45
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 24)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Plazo de pago"
        '
        'TxtSumaOtorgada
        '
        Me.TxtSumaOtorgada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSumaOtorgada.Location = New System.Drawing.Point(683, 163)
        Me.TxtSumaOtorgada.Name = "TxtSumaOtorgada"
        Me.TxtSumaOtorgada.Size = New System.Drawing.Size(206, 29)
        Me.TxtSumaOtorgada.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(515, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 24)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Suma Otorgada"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(518, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Tasa de interés"
        '
        'TxtTasa
        '
        Me.TxtTasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTasa.Location = New System.Drawing.Point(683, 89)
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(206, 29)
        Me.TxtTasa.TabIndex = 40
        '
        'CboFinalidad
        '
        Me.CboFinalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFinalidad.FormattingEnabled = True
        Me.CboFinalidad.Location = New System.Drawing.Point(683, 26)
        Me.CboFinalidad.Name = "CboFinalidad"
        Me.CboFinalidad.Size = New System.Drawing.Size(206, 28)
        Me.CboFinalidad.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(456, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Finalidad del préstamo"
        '
        'TxtSocio
        '
        Me.TxtSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSocio.Location = New System.Drawing.Point(232, 236)
        Me.TxtSocio.Name = "TxtSocio"
        Me.TxtSocio.Size = New System.Drawing.Size(206, 29)
        Me.TxtSocio.TabIndex = 34
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
        Me.Label2.Text = "Socio"
        '
        'CboTipoPrestamo
        '
        Me.CboTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoPrestamo.FormattingEnabled = True
        Me.CboTipoPrestamo.Location = New System.Drawing.Point(232, 164)
        Me.CboTipoPrestamo.Name = "CboTipoPrestamo"
        Me.CboTipoPrestamo.Size = New System.Drawing.Size(206, 28)
        Me.CboTipoPrestamo.TabIndex = 32
        '
        'DtpFechaSolicitud
        '
        Me.DtpFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaSolicitud.Location = New System.Drawing.Point(232, 100)
        Me.DtpFechaSolicitud.Name = "DtpFechaSolicitud"
        Me.DtpFechaSolicitud.Size = New System.Drawing.Size(206, 29)
        Me.DtpFechaSolicitud.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Fecha de solicitud"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.LogoCooperativa
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(715, 358)
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
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = " Número de solicitud"
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
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tipo Préstamo"
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
        'TxtNumeroSolicitud
        '
        Me.TxtNumeroSolicitud.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNumeroSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumeroSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroSolicitud.Location = New System.Drawing.Point(232, 33)
        Me.TxtNumeroSolicitud.Name = "TxtNumeroSolicitud"
        Me.TxtNumeroSolicitud.ReadOnly = True
        Me.TxtNumeroSolicitud.Size = New System.Drawing.Size(206, 29)
        Me.TxtNumeroSolicitud.TabIndex = 23
        '
        'TpListadoDeSolicitudDePrestamo
        '
        Me.TpListadoDeSolicitudDePrestamo.Controls.Add(Me.TextBox6)
        Me.TpListadoDeSolicitudDePrestamo.Controls.Add(Me.Label11)
        Me.TpListadoDeSolicitudDePrestamo.Controls.Add(Me.BtnSalir1)
        Me.TpListadoDeSolicitudDePrestamo.Controls.Add(Me.LsvSolicitudPrestamo)
        Me.TpListadoDeSolicitudDePrestamo.Location = New System.Drawing.Point(4, 27)
        Me.TpListadoDeSolicitudDePrestamo.Name = "TpListadoDeSolicitudDePrestamo"
        Me.TpListadoDeSolicitudDePrestamo.Padding = New System.Windows.Forms.Padding(3)
        Me.TpListadoDeSolicitudDePrestamo.Size = New System.Drawing.Size(960, 432)
        Me.TpListadoDeSolicitudDePrestamo.TabIndex = 1
        Me.TpListadoDeSolicitudDePrestamo.Text = "Listado de solicitudes de préstamo"
        Me.TpListadoDeSolicitudDePrestamo.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(362, 29)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(206, 29)
        Me.TextBox6.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(273, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 24)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Buscar"
        '
        'BtnSalir1
        '
        Me.BtnSalir1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSalir1.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconCerrar
        Me.BtnSalir1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalir1.FlatAppearance.BorderSize = 0
        Me.BtnSalir1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSalir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir1.Location = New System.Drawing.Point(922, 8)
        Me.BtnSalir1.Name = "BtnSalir1"
        Me.BtnSalir1.Size = New System.Drawing.Size(37, 33)
        Me.BtnSalir1.TabIndex = 51
        Me.BtnSalir1.UseVisualStyleBackColor = False
        '
        'LsvSolicitudPrestamo
        '
        Me.LsvSolicitudPrestamo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumSolicitud, Me.ChFechaDeSolicitud, Me.ChTipoPrestamo, Me.ChSocio, Me.ChPlazoDePago, Me.ChFinalidadDelPrestamo, Me.ChTasa, Me.ChSumaOtorgada, Me.ChOficial, Me.ChEstadoPrestamo})
        Me.LsvSolicitudPrestamo.ContextMenuStrip = Me.CmsOpciones
        Me.LsvSolicitudPrestamo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LsvSolicitudPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvSolicitudPrestamo.FullRowSelect = True
        Me.LsvSolicitudPrestamo.GridLines = True
        Me.LsvSolicitudPrestamo.HideSelection = False
        Me.LsvSolicitudPrestamo.Location = New System.Drawing.Point(3, 86)
        Me.LsvSolicitudPrestamo.Name = "LsvSolicitudPrestamo"
        Me.LsvSolicitudPrestamo.Size = New System.Drawing.Size(954, 343)
        Me.LsvSolicitudPrestamo.TabIndex = 14
        Me.LsvSolicitudPrestamo.UseCompatibleStateImageBehavior = False
        Me.LsvSolicitudPrestamo.View = System.Windows.Forms.View.Details
        '
        'ChNumSolicitud
        '
        Me.ChNumSolicitud.Text = "Número de solicitud"
        Me.ChNumSolicitud.Width = 150
        '
        'ChFechaDeSolicitud
        '
        Me.ChFechaDeSolicitud.Text = "Fecha de solicitud"
        Me.ChFechaDeSolicitud.Width = 150
        '
        'ChTipoPrestamo
        '
        Me.ChTipoPrestamo.Text = "Tipo de Préstamo"
        Me.ChTipoPrestamo.Width = 150
        '
        'ChSocio
        '
        Me.ChSocio.Text = "Socio"
        Me.ChSocio.Width = 150
        '
        'ChPlazoDePago
        '
        Me.ChPlazoDePago.Text = "Plazo de pago"
        Me.ChPlazoDePago.Width = 150
        '
        'ChFinalidadDelPrestamo
        '
        Me.ChFinalidadDelPrestamo.Text = "Finalidad del préstamo"
        Me.ChFinalidadDelPrestamo.Width = 150
        '
        'ChTasa
        '
        Me.ChTasa.Text = "Tasa de interés"
        Me.ChTasa.Width = 150
        '
        'ChSumaOtorgada
        '
        Me.ChSumaOtorgada.Text = "SumaOtorgada"
        Me.ChSumaOtorgada.Width = 150
        '
        'ChOficial
        '
        Me.ChOficial.Text = "Oficial "
        Me.ChOficial.Width = 150
        '
        'ChEstadoPrestamo
        '
        Me.ChEstadoPrestamo.Text = "Estadó de Préstamo"
        Me.ChEstadoPrestamo.Width = 150
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'FrmSolicitudPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSolicitudPrestamo"
        Me.Text = "Form1"
        Me.CmsOpciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TcOpciones.ResumeLayout(False)
        Me.BtnSalir.ResumeLayout(False)
        Me.BtnSalir.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpListadoDeSolicitudDePrestamo.ResumeLayout(False)
        Me.TpListadoDeSolicitudDePrestamo.PerformLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemEditar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemEliminar As ToolStripMenuItem
    Friend WithEvents TcOpciones As TabControl
    Friend WithEvents BtnSalir As TabPage
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtNumeroSolicitud As TextBox
    Friend WithEvents TpListadoDeSolicitudDePrestamo As TabPage
    Friend WithEvents CboEstadoPrestamo As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtOficial As TextBox
    Friend WithEvents TxtPlazoPago As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtSumaOtorgada As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTasa As TextBox
    Friend WithEvents CboFinalidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSocio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CboTipoPrestamo As ComboBox
    Friend WithEvents DtpFechaSolicitud As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LsvSolicitudPrestamo As ListView
    Friend WithEvents ChNumSolicitud As ColumnHeader
    Friend WithEvents ChFechaDeSolicitud As ColumnHeader
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents ChTipoPrestamo As ColumnHeader
    Friend WithEvents ChSocio As ColumnHeader
    Friend WithEvents ChPlazoDePago As ColumnHeader
    Friend WithEvents ChFinalidadDelPrestamo As ColumnHeader
    Friend WithEvents ChTasa As ColumnHeader
    Friend WithEvents ChSumaOtorgada As ColumnHeader
    Friend WithEvents ChOficial As ColumnHeader
    Friend WithEvents ChEstadoPrestamo As ColumnHeader
    Friend WithEvents BtnSalir1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnBuscarOficial As Button
    Friend WithEvents BtnBuscarSocio As Button
End Class
