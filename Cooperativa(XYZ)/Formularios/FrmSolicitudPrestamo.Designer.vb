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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpSolicitudDePrestamo = New System.Windows.Forms.TabPage()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtIdTipoPrestamo = New System.Windows.Forms.TextBox()
        Me.TpListadoDeSolicitudDePrestamo = New System.Windows.Forms.TabPage()
        Me.LsvTipoPrestamo = New System.Windows.Forms.ListView()
        Me.ChNumSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFechaDeSolicitud = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ChTipoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChPlazoDePago = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChFinalidadDelPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChSumaOtorgada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChOficial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoPrestamo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.CmsOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TpSolicitudDePrestamo.SuspendLayout()
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
        Me.TabControl1.Controls.Add(Me.TpSolicitudDePrestamo)
        Me.TabControl1.Controls.Add(Me.TpListadoDeSolicitudDePrestamo)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(968, 456)
        Me.TabControl1.TabIndex = 14
        '
        'TpSolicitudDePrestamo
        '
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Button1)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.ComboBox3)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label10)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label9)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.TextBox5)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.TextBox2)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label6)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.TextBox4)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label8)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label7)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.TextBox3)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.ComboBox2)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label5)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.TextBox1)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label2)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.ComboBox1)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.DateTimePicker1)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label1)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.PictureBox1)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.BtnCancelar)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.BtnModificar)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label4)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.BtnGuardar)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.Label3)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.BtnNuevo)
        Me.TpSolicitudDePrestamo.Controls.Add(Me.TxtIdTipoPrestamo)
        Me.TpSolicitudDePrestamo.Location = New System.Drawing.Point(4, 27)
        Me.TpSolicitudDePrestamo.Name = "TpSolicitudDePrestamo"
        Me.TpSolicitudDePrestamo.Padding = New System.Windows.Forms.Padding(3)
        Me.TpSolicitudDePrestamo.Size = New System.Drawing.Size(960, 425)
        Me.TpSolicitudDePrestamo.TabIndex = 0
        Me.TpSolicitudDePrestamo.Text = "Datos de solicitud de préstamo"
        Me.TpSolicitudDePrestamo.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(683, 306)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(206, 28)
        Me.ComboBox3.TabIndex = 49
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
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(683, 234)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(206, 29)
        Me.TextBox5.TabIndex = 46
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(229, 306)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(206, 29)
        Me.TextBox2.TabIndex = 45
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
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(683, 163)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(206, 29)
        Me.TextBox4.TabIndex = 43
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
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(683, 89)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(206, 29)
        Me.TextBox3.TabIndex = 40
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(683, 26)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(206, 28)
        Me.ComboBox2.TabIndex = 39
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
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(232, 236)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 29)
        Me.TextBox1.TabIndex = 34
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
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(232, 164)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(206, 28)
        Me.ComboBox1.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(232, 100)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(206, 29)
        Me.DateTimePicker1.TabIndex = 31
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
        'TxtIdTipoPrestamo
        '
        Me.TxtIdTipoPrestamo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtIdTipoPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdTipoPrestamo.Location = New System.Drawing.Point(232, 33)
        Me.TxtIdTipoPrestamo.Name = "TxtIdTipoPrestamo"
        Me.TxtIdTipoPrestamo.ReadOnly = True
        Me.TxtIdTipoPrestamo.Size = New System.Drawing.Size(206, 29)
        Me.TxtIdTipoPrestamo.TabIndex = 23
        '
        'TpListadoDeSolicitudDePrestamo
        '
        Me.TpListadoDeSolicitudDePrestamo.Controls.Add(Me.TextBox6)
        Me.TpListadoDeSolicitudDePrestamo.Controls.Add(Me.Label11)
        Me.TpListadoDeSolicitudDePrestamo.Controls.Add(Me.Button2)
        Me.TpListadoDeSolicitudDePrestamo.Controls.Add(Me.LsvTipoPrestamo)
        Me.TpListadoDeSolicitudDePrestamo.Location = New System.Drawing.Point(4, 27)
        Me.TpListadoDeSolicitudDePrestamo.Name = "TpListadoDeSolicitudDePrestamo"
        Me.TpListadoDeSolicitudDePrestamo.Padding = New System.Windows.Forms.Padding(3)
        Me.TpListadoDeSolicitudDePrestamo.Size = New System.Drawing.Size(960, 425)
        Me.TpListadoDeSolicitudDePrestamo.TabIndex = 1
        Me.TpListadoDeSolicitudDePrestamo.Text = "Listado de solicitudes de préstamo"
        Me.TpListadoDeSolicitudDePrestamo.UseVisualStyleBackColor = True
        '
        'LsvTipoPrestamo
        '
        Me.LsvTipoPrestamo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChNumSolicitud, Me.ChFechaDeSolicitud, Me.ChTipoPrestamo, Me.ChSocio, Me.ChPlazoDePago, Me.ChFinalidadDelPrestamo, Me.ChTasa, Me.ChSumaOtorgada, Me.ChOficial, Me.ChEstadoPrestamo})
        Me.LsvTipoPrestamo.ContextMenuStrip = Me.CmsOpciones
        Me.LsvTipoPrestamo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LsvTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvTipoPrestamo.FullRowSelect = True
        Me.LsvTipoPrestamo.GridLines = True
        Me.LsvTipoPrestamo.HideSelection = False
        Me.LsvTipoPrestamo.Location = New System.Drawing.Point(3, 79)
        Me.LsvTipoPrestamo.Name = "LsvTipoPrestamo"
        Me.LsvTipoPrestamo.Size = New System.Drawing.Size(954, 343)
        Me.LsvTipoPrestamo.TabIndex = 14
        Me.LsvTipoPrestamo.UseCompatibleStateImageBehavior = False
        Me.LsvTipoPrestamo.View = System.Windows.Forms.View.Details
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
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconCerrar
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(923, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 33)
        Me.Button1.TabIndex = 50
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconCerrar
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(922, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 33)
        Me.Button2.TabIndex = 51
        Me.Button2.UseVisualStyleBackColor = False
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
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(362, 29)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(206, 29)
        Me.TextBox6.TabIndex = 53
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
        Me.TabControl1.ResumeLayout(False)
        Me.TpSolicitudDePrestamo.ResumeLayout(False)
        Me.TpSolicitudDePrestamo.PerformLayout()
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpSolicitudDePrestamo As TabPage
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtIdTipoPrestamo As TextBox
    Friend WithEvents TpListadoDeSolicitudDePrestamo As TabPage
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LsvTipoPrestamo As ListView
    Friend WithEvents ChNumSolicitud As ColumnHeader
    Friend WithEvents ChFechaDeSolicitud As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents ChTipoPrestamo As ColumnHeader
    Friend WithEvents ChSocio As ColumnHeader
    Friend WithEvents ChPlazoDePago As ColumnHeader
    Friend WithEvents ChFinalidadDelPrestamo As ColumnHeader
    Friend WithEvents ChTasa As ColumnHeader
    Friend WithEvents ChSumaOtorgada As ColumnHeader
    Friend WithEvents ChOficial As ColumnHeader
    Friend WithEvents ChEstadoPrestamo As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
End Class
