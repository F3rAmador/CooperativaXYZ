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
        Me.TcDatos = New System.Windows.Forms.TabControl()
        Me.TpDatosSocio = New System.Windows.Forms.TabPage()
        Me.TxtTelTrabajo = New System.Windows.Forms.TextBox()
        Me.CboLugarTrabajo = New System.Windows.Forms.ComboBox()
        Me.CboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.TxtCodSocio = New System.Windows.Forms.TextBox()
        Me.TpListadoDeSolicitudDelSocio = New System.Windows.Forms.TabPage()
        Me.RdbBuscarNombre = New System.Windows.Forms.RadioButton()
        Me.DdbBuscarCodigo = New System.Windows.Forms.RadioButton()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LsvSocio = New System.Windows.Forms.ListView()
        Me.ChCodSocio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombres = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChRtn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoCivil = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChLugarTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefonoCasa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefonoTrabajo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CmsOpciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TcDatos.SuspendLayout()
        Me.TpDatosSocio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpListadoDeSolicitudDelSocio.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmsOpciones
        '
        Me.CmsOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
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
        Me.GroupBox1.Controls.Add(Me.TcDatos)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 456)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'TcDatos
        '
        Me.TcDatos.Controls.Add(Me.TpDatosSocio)
        Me.TcDatos.Controls.Add(Me.TpListadoDeSolicitudDelSocio)
        Me.TcDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TcDatos.Location = New System.Drawing.Point(0, 0)
        Me.TcDatos.Name = "TcDatos"
        Me.TcDatos.SelectedIndex = 0
        Me.TcDatos.Size = New System.Drawing.Size(968, 456)
        Me.TcDatos.TabIndex = 14
        '
        'TpDatosSocio
        '
        Me.TpDatosSocio.Controls.Add(Me.TxtTelTrabajo)
        Me.TpDatosSocio.Controls.Add(Me.CboLugarTrabajo)
        Me.TpDatosSocio.Controls.Add(Me.CboEstadoCivil)
        Me.TpDatosSocio.Controls.Add(Me.Label2)
        Me.TpDatosSocio.Controls.Add(Me.TxtApellidos)
        Me.TpDatosSocio.Controls.Add(Me.TxtNombres)
        Me.TpDatosSocio.Controls.Add(Me.BtnCerrar)
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
        Me.TpDatosSocio.Controls.Add(Me.TxtCodSocio)
        Me.TpDatosSocio.Location = New System.Drawing.Point(4, 27)
        Me.TpDatosSocio.Name = "TpDatosSocio"
        Me.TpDatosSocio.Padding = New System.Windows.Forms.Padding(3)
        Me.TpDatosSocio.Size = New System.Drawing.Size(960, 425)
        Me.TpDatosSocio.TabIndex = 0
        Me.TpDatosSocio.Text = "Datos del Socio"
        Me.TpDatosSocio.UseVisualStyleBackColor = True
        '
        'TxtTelTrabajo
        '
        Me.TxtTelTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelTrabajo.Location = New System.Drawing.Point(670, 280)
        Me.TxtTelTrabajo.Name = "TxtTelTrabajo"
        Me.TxtTelTrabajo.ReadOnly = True
        Me.TxtTelTrabajo.Size = New System.Drawing.Size(206, 29)
        Me.TxtTelTrabajo.TabIndex = 56
        '
        'CboLugarTrabajo
        '
        Me.CboLugarTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLugarTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLugarTrabajo.FormattingEnabled = True
        Me.CboLugarTrabajo.Location = New System.Drawing.Point(670, 158)
        Me.CboLugarTrabajo.Name = "CboLugarTrabajo"
        Me.CboLugarTrabajo.Size = New System.Drawing.Size(206, 28)
        Me.CboLugarTrabajo.TabIndex = 55
        '
        'CboEstadoCivil
        '
        Me.CboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEstadoCivil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstadoCivil.FormattingEnabled = True
        Me.CboEstadoCivil.Location = New System.Drawing.Point(670, 96)
        Me.CboEstadoCivil.Name = "CboEstadoCivil"
        Me.CboEstadoCivil.Size = New System.Drawing.Size(206, 28)
        Me.CboEstadoCivil.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Direccion"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidos.Location = New System.Drawing.Point(232, 168)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.ReadOnly = True
        Me.TxtApellidos.Size = New System.Drawing.Size(206, 29)
        Me.TxtApellidos.TabIndex = 52
        '
        'TxtNombres
        '
        Me.TxtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombres.Location = New System.Drawing.Point(232, 96)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.ReadOnly = True
        Me.TxtNombres.Size = New System.Drawing.Size(206, 29)
        Me.TxtNombres.TabIndex = 51
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
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(547, 280)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 24)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Tel Trabajo"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(568, 220)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 24)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Tel Casa"
        '
        'TxtTelCasa
        '
        Me.TxtTelCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelCasa.Location = New System.Drawing.Point(670, 220)
        Me.TxtTelCasa.Name = "TxtTelCasa"
        Me.TxtTelCasa.ReadOnly = True
        Me.TxtTelCasa.Size = New System.Drawing.Size(206, 29)
        Me.TxtTelCasa.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(524, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 24)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = " Lugar Trabajo"
        '
        'TxtRtn
        '
        Me.TxtRtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRtn.Location = New System.Drawing.Point(232, 239)
        Me.TxtRtn.Name = "TxtRtn"
        Me.TxtRtn.ReadOnly = True
        Me.TxtRtn.Size = New System.Drawing.Size(206, 29)
        Me.TxtRtn.TabIndex = 43
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(127, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 24)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Rtn"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(546, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 24)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Estado Civil"
        '
        'CboIdNacionalidad
        '
        Me.CboIdNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboIdNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIdNacionalidad.FormattingEnabled = True
        Me.CboIdNacionalidad.Location = New System.Drawing.Point(670, 37)
        Me.CboIdNacionalidad.Name = "CboIdNacionalidad"
        Me.CboIdNacionalidad.Size = New System.Drawing.Size(206, 28)
        Me.CboIdNacionalidad.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(535, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Nacionalidad"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(232, 304)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.ReadOnly = True
        Me.TxtDireccion.Size = New System.Drawing.Size(206, 29)
        Me.TxtDireccion.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Nombres"
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
        Me.Label4.Location = New System.Drawing.Point(38, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Código del Socio"
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
        Me.Label3.Location = New System.Drawing.Point(102, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 24)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Apellidos"
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
        'TxtCodSocio
        '
        Me.TxtCodSocio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCodSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCodSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSocio.Location = New System.Drawing.Point(232, 33)
        Me.TxtCodSocio.Name = "TxtCodSocio"
        Me.TxtCodSocio.ReadOnly = True
        Me.TxtCodSocio.Size = New System.Drawing.Size(206, 29)
        Me.TxtCodSocio.TabIndex = 23
        '
        'TpListadoDeSolicitudDelSocio
        '
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.RdbBuscarNombre)
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.DdbBuscarCodigo)
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.TextBox6)
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.Label11)
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.Button2)
        Me.TpListadoDeSolicitudDelSocio.Controls.Add(Me.LsvSocio)
        Me.TpListadoDeSolicitudDelSocio.Location = New System.Drawing.Point(4, 27)
        Me.TpListadoDeSolicitudDelSocio.Name = "TpListadoDeSolicitudDelSocio"
        Me.TpListadoDeSolicitudDelSocio.Padding = New System.Windows.Forms.Padding(3)
        Me.TpListadoDeSolicitudDelSocio.Size = New System.Drawing.Size(960, 425)
        Me.TpListadoDeSolicitudDelSocio.TabIndex = 1
        Me.TpListadoDeSolicitudDelSocio.Text = "Listado de solicitudes del Socio"
        Me.TpListadoDeSolicitudDelSocio.UseVisualStyleBackColor = True
        '
        'RdbBuscarNombre
        '
        Me.RdbBuscarNombre.AutoSize = True
        Me.RdbBuscarNombre.Location = New System.Drawing.Point(739, 34)
        Me.RdbBuscarNombre.Name = "RdbBuscarNombre"
        Me.RdbBuscarNombre.Size = New System.Drawing.Size(108, 22)
        Me.RdbBuscarNombre.TabIndex = 55
        Me.RdbBuscarNombre.TabStop = True
        Me.RdbBuscarNombre.Text = "Por Nombre"
        Me.RdbBuscarNombre.UseVisualStyleBackColor = True
        '
        'DdbBuscarCodigo
        '
        Me.DdbBuscarCodigo.AutoSize = True
        Me.DdbBuscarCodigo.Location = New System.Drawing.Point(601, 34)
        Me.DdbBuscarCodigo.Name = "DdbBuscarCodigo"
        Me.DdbBuscarCodigo.Size = New System.Drawing.Size(102, 22)
        Me.DdbBuscarCodigo.TabIndex = 54
        Me.DdbBuscarCodigo.TabStop = True
        Me.DdbBuscarCodigo.Text = "Por Código"
        Me.DdbBuscarCodigo.UseVisualStyleBackColor = True
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
        'LsvSocio
        '
        Me.LsvSocio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodSocio, Me.ChNombres, Me.ChApellidos, Me.ChRtn, Me.ChDireccion, Me.ChNacionalidad, Me.ChEstadoCivil, Me.ChLugarTrabajo, Me.ChTelefonoCasa, Me.ChTelefonoTrabajo})
        Me.LsvSocio.ContextMenuStrip = Me.CmsOpciones
        Me.LsvSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvSocio.FullRowSelect = True
        Me.LsvSocio.GridLines = True
        Me.LsvSocio.HideSelection = False
        Me.LsvSocio.Location = New System.Drawing.Point(3, 79)
        Me.LsvSocio.Name = "LsvSocio"
        Me.LsvSocio.Size = New System.Drawing.Size(954, 343)
        Me.LsvSocio.TabIndex = 14
        Me.LsvSocio.UseCompatibleStateImageBehavior = False
        Me.LsvSocio.View = System.Windows.Forms.View.Details
        '
        'ChCodSocio
        '
        Me.ChCodSocio.Text = "Codigo Socio"
        Me.ChCodSocio.Width = 89
        '
        'ChNombres
        '
        Me.ChNombres.Text = "Nombres"
        Me.ChNombres.Width = 67
        '
        'ChApellidos
        '
        Me.ChApellidos.Text = "Apellidos"
        Me.ChApellidos.Width = 72
        '
        'ChRtn
        '
        Me.ChRtn.Text = "Rtn"
        Me.ChRtn.Width = 104
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Dirección"
        Me.ChDireccion.Width = 93
        '
        'ChNacionalidad
        '
        Me.ChNacionalidad.Text = "Nacionalidad"
        Me.ChNacionalidad.Width = 103
        '
        'ChEstadoCivil
        '
        Me.ChEstadoCivil.Text = "Estado Civil"
        Me.ChEstadoCivil.Width = 106
        '
        'ChLugarTrabajo
        '
        Me.ChLugarTrabajo.Text = "Lugar de Trabajo"
        Me.ChLugarTrabajo.Width = 116
        '
        'ChTelefonoCasa
        '
        Me.ChTelefonoCasa.Text = "Teléfono Casa"
        Me.ChTelefonoCasa.Width = 92
        '
        'ChTelefonoTrabajo
        '
        Me.ChTelefonoTrabajo.Text = "Teléfono Trabajo"
        Me.ChTelefonoTrabajo.Width = 108
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'FrmSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSocio"
        Me.Text = "Form1"
        Me.CmsOpciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TcDatos.ResumeLayout(False)
        Me.TpDatosSocio.ResumeLayout(False)
        Me.TpDatosSocio.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpListadoDeSolicitudDelSocio.ResumeLayout(False)
        Me.TpListadoDeSolicitudDelSocio.PerformLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemEditar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemEliminar As ToolStripMenuItem
    Friend WithEvents TcDatos As TabControl
    Friend WithEvents TpDatosSocio As TabPage
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtCodSocio As TextBox
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
    Friend WithEvents LsvSocio As ListView
    Friend WithEvents ChCodSocio As ColumnHeader
    Friend WithEvents ChNombres As ColumnHeader
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChRtn As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents CboLugarTrabajo As ComboBox
    Friend WithEvents CboEstadoCivil As ComboBox
    Friend WithEvents TxtTelTrabajo As TextBox
    Friend WithEvents RdbBuscarNombre As RadioButton
    Friend WithEvents DdbBuscarCodigo As RadioButton
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChNacionalidad As ColumnHeader
    Friend WithEvents ChEstadoCivil As ColumnHeader
    Friend WithEvents ChLugarTrabajo As ColumnHeader
    Friend WithEvents ChTelefonoCasa As ColumnHeader
    Friend WithEvents ChTelefonoTrabajo As ColumnHeader
End Class
