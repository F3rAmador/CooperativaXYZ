<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarSocio
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.RdbBuscarNombre = New System.Windows.Forms.RadioButton()
        Me.RdbBuscarCodigo = New System.Windows.Forms.RadioButton()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.BtnSeleccionar)
        Me.GroupBox1.Controls.Add(Me.RdbBuscarNombre)
        Me.GroupBox1.Controls.Add(Me.RdbBuscarCodigo)
        Me.GroupBox1.Controls.Add(Me.TxtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.LsvSocio)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 456)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSeleccionar.FlatAppearance.BorderSize = 0
        Me.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSeleccionar.Location = New System.Drawing.Point(695, 34)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(113, 37)
        Me.BtnSeleccionar.TabIndex = 62
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = False
        '
        'RdbBuscarNombre
        '
        Me.RdbBuscarNombre.AutoSize = True
        Me.RdbBuscarNombre.Location = New System.Drawing.Point(526, 58)
        Me.RdbBuscarNombre.Name = "RdbBuscarNombre"
        Me.RdbBuscarNombre.Size = New System.Drawing.Size(81, 17)
        Me.RdbBuscarNombre.TabIndex = 61
        Me.RdbBuscarNombre.TabStop = True
        Me.RdbBuscarNombre.Text = "Por Nombre"
        Me.RdbBuscarNombre.UseVisualStyleBackColor = True
        '
        'RdbBuscarCodigo
        '
        Me.RdbBuscarCodigo.AutoSize = True
        Me.RdbBuscarCodigo.Location = New System.Drawing.Point(526, 26)
        Me.RdbBuscarCodigo.Name = "RdbBuscarCodigo"
        Me.RdbBuscarCodigo.Size = New System.Drawing.Size(77, 17)
        Me.RdbBuscarCodigo.TabIndex = 60
        Me.RdbBuscarCodigo.TabStop = True
        Me.RdbBuscarCodigo.Text = "Por Código"
        Me.RdbBuscarCodigo.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(291, 35)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(206, 29)
        Me.TxtBuscar.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(198, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 24)
        Me.Label11.TabIndex = 58
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
        Me.Button2.Location = New System.Drawing.Point(929, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 33)
        Me.Button2.TabIndex = 57
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LsvSocio
        '
        Me.LsvSocio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChCodSocio, Me.ChNombres, Me.ChApellidos, Me.ChRtn, Me.ChDireccion, Me.ChNacionalidad, Me.ChEstadoCivil, Me.ChLugarTrabajo, Me.ChTelefonoCasa, Me.ChTelefonoTrabajo})
        Me.LsvSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LsvSocio.FullRowSelect = True
        Me.LsvSocio.GridLines = True
        Me.LsvSocio.HideSelection = False
        Me.LsvSocio.Location = New System.Drawing.Point(6, 96)
        Me.LsvSocio.Name = "LsvSocio"
        Me.LsvSocio.Size = New System.Drawing.Size(954, 343)
        Me.LsvSocio.TabIndex = 56
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
        'FrmBuscarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 468)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBuscarSocio"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents RdbBuscarNombre As RadioButton
    Friend WithEvents RdbBuscarCodigo As RadioButton
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents LsvSocio As ListView
    Friend WithEvents ChCodSocio As ColumnHeader
    Friend WithEvents ChNombres As ColumnHeader
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChRtn As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChNacionalidad As ColumnHeader
    Friend WithEvents ChEstadoCivil As ColumnHeader
    Friend WithEvents ChLugarTrabajo As ColumnHeader
    Friend WithEvents ChTelefonoCasa As ColumnHeader
    Friend WithEvents ChTelefonoTrabajo As ColumnHeader
    Friend WithEvents BtnSeleccionar As Button
End Class
