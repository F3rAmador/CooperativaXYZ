<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarOficiall
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
        Me.PCentarl = New System.Windows.Forms.Panel()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.RdbBuscarNombre = New System.Windows.Forms.RadioButton()
        Me.RdbBuscarCodigo = New System.Windows.Forms.RadioButton()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LsvOficialCredito = New System.Windows.Forms.ListView()
        Me.ChINumIdentidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChApellidos = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PCentarl.SuspendLayout()
        Me.CmsOpciones.SuspendLayout()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PCentarl
        '
        Me.PCentarl.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PCentarl.Controls.Add(Me.Button1)
        Me.PCentarl.Controls.Add(Me.LsvOficialCredito)
        Me.PCentarl.Controls.Add(Me.BtnSeleccionar)
        Me.PCentarl.Controls.Add(Me.RdbBuscarNombre)
        Me.PCentarl.Controls.Add(Me.RdbBuscarCodigo)
        Me.PCentarl.Controls.Add(Me.TxtBuscar)
        Me.PCentarl.Controls.Add(Me.Label11)
        Me.PCentarl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PCentarl.Location = New System.Drawing.Point(0, 0)
        Me.PCentarl.Name = "PCentarl"
        Me.PCentarl.Size = New System.Drawing.Size(968, 468)
        Me.PCentarl.TabIndex = 17
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSeleccionar.FlatAppearance.BorderSize = 0
        Me.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeleccionar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnSeleccionar.Location = New System.Drawing.Point(702, 33)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(113, 37)
        Me.BtnSeleccionar.TabIndex = 67
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = False
        '
        'RdbBuscarNombre
        '
        Me.RdbBuscarNombre.AutoSize = True
        Me.RdbBuscarNombre.Location = New System.Drawing.Point(518, 57)
        Me.RdbBuscarNombre.Name = "RdbBuscarNombre"
        Me.RdbBuscarNombre.Size = New System.Drawing.Size(81, 17)
        Me.RdbBuscarNombre.TabIndex = 66
        Me.RdbBuscarNombre.TabStop = True
        Me.RdbBuscarNombre.Text = "Por Nombre"
        Me.RdbBuscarNombre.UseVisualStyleBackColor = True
        '
        'RdbBuscarCodigo
        '
        Me.RdbBuscarCodigo.AutoSize = True
        Me.RdbBuscarCodigo.Location = New System.Drawing.Point(518, 25)
        Me.RdbBuscarCodigo.Name = "RdbBuscarCodigo"
        Me.RdbBuscarCodigo.Size = New System.Drawing.Size(77, 17)
        Me.RdbBuscarCodigo.TabIndex = 65
        Me.RdbBuscarCodigo.TabStop = True
        Me.RdbBuscarCodigo.Text = "Por Código"
        Me.RdbBuscarCodigo.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(283, 34)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(206, 29)
        Me.TxtBuscar.TabIndex = 64
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(190, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 24)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Buscar"
        '
        'LsvOficialCredito
        '
        Me.LsvOficialCredito.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChINumIdentidad, Me.ChNombre, Me.ChApellidos, Me.ChTelefono, Me.ChDireccion})
        Me.LsvOficialCredito.ContextMenuStrip = Me.CmsOpciones
        Me.LsvOficialCredito.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LsvOficialCredito.FullRowSelect = True
        Me.LsvOficialCredito.GridLines = True
        Me.LsvOficialCredito.Location = New System.Drawing.Point(0, 90)
        Me.LsvOficialCredito.Name = "LsvOficialCredito"
        Me.LsvOficialCredito.Size = New System.Drawing.Size(968, 378)
        Me.LsvOficialCredito.TabIndex = 11
        Me.LsvOficialCredito.UseCompatibleStateImageBehavior = False
        Me.LsvOficialCredito.View = System.Windows.Forms.View.Details
        '
        'ChINumIdentidad
        '
        Me.ChINumIdentidad.Text = "Número de Identidad"
        Me.ChINumIdentidad.Width = 115
        '
        'ChNombre
        '
        Me.ChNombre.Text = "Nombre"
        Me.ChNombre.Width = 150
        '
        'ChApellidos
        '
        Me.ChApellidos.Text = "Apellidos"
        Me.ChApellidos.Width = 150
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Télefono"
        Me.ChTelefono.Width = 120
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Dirección"
        Me.ChDireccion.Width = 150
        '
        'CmsOpciones
        '
        Me.CmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.CmsOpciones.Name = "CmsOpciones"
        Me.CmsOpciones.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.BackColor = System.Drawing.Color.Coral
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 458)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(968, 10)
        Me.Panel1.TabIndex = 18
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
        Me.Button1.Location = New System.Drawing.Point(931, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 33)
        Me.Button1.TabIndex = 51
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmBuscarOficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PCentarl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBuscarOficial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmOficial"
        Me.PCentarl.ResumeLayout(False)
        Me.PCentarl.PerformLayout()
        Me.CmsOpciones.ResumeLayout(False)
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PCentarl As Panel
    Friend WithEvents LsvOficialCredito As ListView
    Friend WithEvents ChINumIdentidad As ColumnHeader
    Friend WithEvents ChNombre As ColumnHeader
    Friend WithEvents ChApellidos As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnSeleccionar As Button
    Friend WithEvents RdbBuscarNombre As RadioButton
    Friend WithEvents RdbBuscarCodigo As RadioButton
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
End Class
