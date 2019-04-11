<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSocio
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
        Me.TpDatosSocio = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTelCasa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtRtn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboIdNacionalidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdCodSocio = New System.Windows.Forms.TextBox()
        Me.TpListadoDeSolicitudDelSocio = New System.Windows.Forms.TabPage()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LsvTipoPrestamo = New System.Windows.Forms.ListView()
        Me.ChCodSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombres = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChRtn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdEstadoCivil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdLugarTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelCasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.CboLugarTrabajo = New System.Windows.Forms.ComboBox()
        Me.TxtTelTrabajo = New System.Windows.Forms.TextBox()
        Me.CmsOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TpDatosSocio.SuspendLayout()
        Me.TpListadoDeSolicitudDelSocio.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemEditar, Me.ToolStripMenuItemEliminar})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(133, 52)
        '
        'ToolStripMenuItemEditar
        '
        Me.ToolStripMenuItemEditar.Name = "ToolStripMenuItemEditar"
        Me.ToolStripMenuItemEditar.Size = New System.Drawing.Size(132, 24)
        Me.ToolStripMenuItemEditar.Text = "Editar"
        '
        'ToolStripMenuItemEliminar
        '
        Me.ToolStripMenuItemEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStripMenuItemEliminar.Name = "ToolStripMenuItemEliminar"
        Me.ToolStripMenuItemEliminar.Size = New System.Drawing.Size(132, 24)
        Me.ToolStripMenuItemEliminar.Text = "Eliminar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1291, 561)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpDatosSocio)
        Me.TabControl1.Controls.Add(Me.TpListadoDeSolicitudDelSocio)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1291, 561)
        Me.TabControl1.TabIndex = 14
        '
        'TpDatosSocio
        '
        Me.TpDatosSocio.Controls.Add(Me.TxtTelTrabajo)
        Me.TpDatosSocio.Controls.Add(Me.CboLugarTrabajo)
        Me.TpDatosSocio.Controls.Add(Me.CboEstadoCivil)
        Me.TpDatosSocio.Controls.Add(Me.Label2)
        Me.TpDatosSocio.Controls.Add(Me.TxtApellidos)
        Me.TpDatosSocio.Controls.Add(Me.TxtNombres)
        Me.TpDatosSocio.Controls.Add(Me.Button1)
        Me.TpDatosSocio.Controls.Add(Me.Label10)
        Me.TpDatosSocio.Controls.Add(Me.Label9)
        Me.TpDatosSocio.Controls.Add(Me.TxtTelCasa)
        Me.TpDatosSocio.Controls.Add(Me.Label6)
        Me.TpDatosSocio.Controls.Add(Me.TxtRtn)
        Me.TpDatosSocio.Controls.Add(Me.Label8)
        Me.TpDatosSocio.Controls.Add(Me.Label7)
        Me.TpDatosSocio.Controls.Add(Me.CboIdNacionalidad)
        Me.TpDatosSocio.Controls.Add(Me.Label5)
        Me.TpDatosSocio.Controls.Add(Me.TxtDireccion)
        Me.TpDatosSocio.Controls.Add(Me.Label1)
        Me.TpDatosSocio.Controls.Add(Me.PictureBox1)
        Me.TpDatosSocio.Controls.Add(Me.BtnCancelar)
        Me.TpDatosSocio.Controls.Add(Me.BtnModificar)
        Me.TpDatosSocio.Controls.Add(Me.Label4)
        Me.TpDatosSocio.Controls.Add(Me.BtnGuardar)
        Me.TpDatosSocio.Controls.Add(Me.Label3)
        Me.TpDatosSocio.Controls.Add(Me.BtnNuevo)
        Me.TpDatosSocio.Controls.Add(Me.TxtIdCodSocio)
        Me.TpDatosSocio.Location = New System.Drawing.Point(4, 33)
        Me.TpDatosSocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpDatosSocio.Name = "TpDatosSocio"
        Me.TpDatosSocio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpDatosSocio.Size = New System.Drawing.Size(1283, 524)
        Me.TpDatosSocio.TabIndex = 0
        Me.TpDatosSocio.Text = "Datos del Socio"
        Me.TpDatosSocio.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(729, 345)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 29)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Tel Trabajo"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(757, 271)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 29)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Tel Casa"
        '
        'TxtTelCasa
        '
        Me.TxtTelCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelCasa.Location = New System.Drawing.Point(894, 271)
        Me.TxtTelCasa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTelCasa.Name = "TxtTelCasa"
        Me.TxtTelCasa.Size = New System.Drawing.Size(273, 34)
        Me.TxtTelCasa.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(698, 195)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 29)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = " Lugar Trabajo"
        '
        'TxtRtn
        '
        Me.TxtRtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRtn.Location = New System.Drawing.Point(310, 294)
        Me.TxtRtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtRtn.Name = "TxtRtn"
        Me.TxtRtn.Size = New System.Drawing.Size(273, 34)
        Me.TxtRtn.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(169, 299)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 29)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Rtn"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(728, 123)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 29)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Estado Civil"
        '
        'CboIdNacionalidad
        '
        Me.CboIdNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIdNacionalidad.FormattingEnabled = True
        Me.CboIdNacionalidad.Location = New System.Drawing.Point(894, 46)
        Me.CboIdNacionalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CboIdNacionalidad.Name = "CboIdNacionalidad"
        Me.CboIdNacionalidad.Size = New System.Drawing.Size(273, 33)
        Me.CboIdNacionalidad.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(713, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 29)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Nacionalidad"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(310, 374)
        Me.TxtDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(273, 34)
        Me.TxtDireccion.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(137, 123)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 29)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombres"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 29)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Código del Socio"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 210)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 29)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellidos"
        '
        'TxtIdCodSocio
        '
        Me.TxtIdCodSocio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtIdCodSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdCodSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdCodSocio.Location = New System.Drawing.Point(309, 41)
        Me.TxtIdCodSocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtIdCodSocio.Name = "TxtIdCodSocio"
        Me.TxtIdCodSocio.ReadOnly = True
        Me.TxtIdCodSocio.Size = New System.Drawing.Size(274, 34)
        Me.TxtIdCodSocio.TabIndex = 23
        '
        'TpListadoDeSolicitudDelSocio
        '
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.TextBox6)
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.Label11)
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.Button2)
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.LsvTipoPrestamo)
        Me.TpListadoDeSolicitudDelSocio.Location = New System.Drawing.Point(4, 33)
        Me.TpListadoDeSolicitudDelSocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpListadoDeSolicitudDelSocio.Name = "TpListadoDeSolicitudDelSocio"
        Me.TpListadoDeSolicitudDelSocio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpListadoDeSolicitudDelSocio.Size = New System.Drawing.Size(1283, 524)
        Me.TpListadoDeSolicitudDelSocio.TabIndex = 1
        Me.TpListadoDeSolicitudDelSocio.Text = "Listado de solicitudes del Socio"
        Me.TpListadoDeSolicitudDelSocio.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(483, 36)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(273, 34)
        Me.TextBox6.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(364, 39)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 29)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Buscar"
        '
        'LsvTipoPrestamo
        '
        Me.LsvTipoPrestamo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodSocio, Me.ChNombres, Me.ChApellidos, Me.ChRtn, Me.ChIdNacionalidad, Me.ChIdEstadoCivil, Me.ChIdLugarTrabajo, Me.ChTelCasa, Me.ChTelTrabajo})
        Me.LsvTipoPrestamo.ContextMenuStrip = Me.CmsOpciones
        Me.LsvTipoPrestamo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LsvTipoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvTipoPrestamo.FullRowSelect = True
        Me.LsvTipoPrestamo.GridLines = True
        Me.LsvTipoPrestamo.HideSelection = False
        Me.LsvTipoPrestamo.Location = New System.Drawing.Point(4, 99)
        Me.LsvTipoPrestamo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LsvTipoPrestamo.Name = "LsvTipoPrestamo"
        Me.LsvTipoPrestamo.Size = New System.Drawing.Size(1275, 421)
        Me.LsvTipoPrestamo.TabIndex = 14
        Me.LsvTipoPrestamo.UseCompatibleStateImageBehavior = False
        Me.LsvTipoPrestamo.View = System.Windows.Forms.View.Details
        '
        'ChCodSocio
        '
        Me.ChCodSocio.Text = "Codigo Socio"
        Me.ChCodSocio.Width = 150
        '
        'ChNombres
        '
        Me.ChNombres.Text = "Nombres"
        Me.ChNombres.Width = 150
        '
        'ChApellidos
        '
        Me.ChApellidos.Text = "Apellidos"
        Me.ChApellidos.Width = 150
        '
        'ChRtn
        '
        Me.ChRtn.Text = "Rtn"
        Me.ChRtn.Width = 150
        '
        'ChIdNacionalidad
        '
        Me.ChIdNacionalidad.Text = "Nacionalidad"
        Me.ChIdNacionalidad.Width = 150
        '
        'ChIdEstadoCivil
        '
        Me.ChIdEstadoCivil.Text = "Estado Civil"
        Me.ChIdEstadoCivil.Width = 150
        '
        'ChIdLugarTrabajo
        '
        Me.ChIdLugarTrabajo.Text = "Lugar Trabajo"
        Me.ChIdLugarTrabajo.Width = 150
        '
        'ChTelCasa
        '
        Me.ChTelCasa.Text = "Tel Casa"
        Me.ChTelCasa.Width = 150
        '
        'ChTelTrabajo
        '
        Me.ChTelTrabajo.Text = "Tel Trabajo"
        Me.ChTelTrabajo.Width = 150
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
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
        Me.Button1.Location = New System.Drawing.Point(1231, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 41)
        Me.Button1.TabIndex = 50
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.LogoCooperativa
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(953, 432)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(327, 87)
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
        Me.BtnCancelar.Location = New System.Drawing.Point(763, 459)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(52, 53)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.editar
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Location = New System.Drawing.Point(644, 459)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(52, 53)
        Me.BtnModificar.TabIndex = 27
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.guardar_archivo_opcion
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(531, 459)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(52, 53)
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
        Me.BtnNuevo.Location = New System.Drawing.Point(411, 459)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(52, 53)
        Me.BtnNuevo.TabIndex = 25
        Me.BtnNuevo.UseVisualStyleBackColor = True
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
        Me.Button2.Location = New System.Drawing.Point(1229, 1)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(49, 41)
        Me.Button2.TabIndex = 51
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TxtNombres
        '
        Me.TxtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombres.Location = New System.Drawing.Point(310, 118)
        Me.TxtNombres.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(273, 34)
        Me.TxtNombres.TabIndex = 51
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidos.Location = New System.Drawing.Point(310, 207)
        Me.TxtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(273, 34)
        Me.TxtApellidos.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(135, 382)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Direccion"
        '
        'CboEstadoCivil
        '
        Me.CboEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstadoCivil.FormattingEnabled = True
        Me.CboEstadoCivil.Location = New System.Drawing.Point(894, 118)
        Me.CboEstadoCivil.Margin = New System.Windows.Forms.Padding(4)
        Me.CboEstadoCivil.Name = "CboEstadoCivil"
        Me.CboEstadoCivil.Size = New System.Drawing.Size(273, 33)
        Me.CboEstadoCivil.TabIndex = 54
        '
        'CboLugarTrabajo
        '
        Me.CboLugarTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLugarTrabajo.FormattingEnabled = True
        Me.CboLugarTrabajo.Location = New System.Drawing.Point(894, 195)
        Me.CboLugarTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.CboLugarTrabajo.Name = "CboLugarTrabajo"
        Me.CboLugarTrabajo.Size = New System.Drawing.Size(273, 33)
        Me.CboLugarTrabajo.TabIndex = 55
        '
        'TxtTelTrabajo
        '
        Me.TxtTelTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelTrabajo.Location = New System.Drawing.Point(894, 345)
        Me.TxtTelTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTelTrabajo.Name = "TxtTelTrabajo"
        Me.TxtTelTrabajo.Size = New System.Drawing.Size(273, 34)
        Me.TxtTelTrabajo.TabIndex = 56
        '
        'FrmSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1291, 576)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmSocio"
        Me.Text = "Form1"
        Me.CmsOpciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TpDatosSocio.ResumeLayout(False)
        Me.TpDatosSocio.PerformLayout()
        Me.TpListadoDeSolicitudDelSocio.ResumeLayout(False)
        Me.TpListadoDeSolicitudDelSocio.PerformLayout()
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
    Friend WithEvents TpDatosSocio As TabPage
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtIdCodSocio As TextBox
    Friend WithEvents TpListadoDeSolicitudDelSocio As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtTelCasa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtRtn As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CboIdNacionalidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LsvTipoPrestamo As ListView
    Friend WithEvents ChCodSocio As ColumnHeader
    Friend WithEvents ChNombres As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChRtn As ColumnHeader
    Friend WithEvents ChIdNacionalidad As ColumnHeader
    Friend WithEvents ChIdEstadoCivil As ColumnHeader
    Friend WithEvents ChIdLugarTrabajo As ColumnHeader
    Friend WithEvents ChTelCasa As ColumnHeader
    Friend WithEvents ChTelTrabajo As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents CboLugarTrabajo As ComboBox
    Friend WithEvents CboEstadoCivil As ComboBox
    Friend WithEvents TxtTelTrabajo As TextBox
End Class
