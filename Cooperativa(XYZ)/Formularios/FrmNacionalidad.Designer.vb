﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNacionalidad
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
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TxtIdNacionalidad = New System.Windows.Forms.TextBox()
        Me.LsvLugarTrabajo = New System.Windows.Forms.ListView()
        Me.ChIdNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNacionalidad = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItemEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNacionalidad = New System.Windows.Forms.TextBox()
        Me.PCentarl = New System.Windows.Forms.Panel()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsOpciones.SuspendLayout()
        Me.PCentarl.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'TxtIdNacionalidad
        '
        Me.TxtIdNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtIdNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdNacionalidad.Location = New System.Drawing.Point(407, 53)
        Me.TxtIdNacionalidad.Name = "TxtIdNacionalidad"
        Me.TxtIdNacionalidad.ReadOnly = True
        Me.TxtIdNacionalidad.Size = New System.Drawing.Size(167, 29)
        Me.TxtIdNacionalidad.TabIndex = 10
        '
        'LsvLugarTrabajo
        '
        Me.LsvLugarTrabajo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LsvLugarTrabajo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdNacionalidad, Me.ChNacionalidad})
        Me.LsvLugarTrabajo.ContextMenuStrip = Me.CmsOpciones
        Me.LsvLugarTrabajo.FullRowSelect = True
        Me.LsvLugarTrabajo.GridLines = True
        Me.LsvLugarTrabajo.Location = New System.Drawing.Point(393, 6)
        Me.LsvLugarTrabajo.Name = "LsvLugarTrabajo"
        Me.LsvLugarTrabajo.Size = New System.Drawing.Size(306, 282)
        Me.LsvLugarTrabajo.TabIndex = 11
        Me.LsvLugarTrabajo.UseCompatibleStateImageBehavior = False
        Me.LsvLugarTrabajo.View = System.Windows.Forms.View.Details
        '
        'ChIdNacionalidad
        '
        Me.ChIdNacionalidad.Text = "Código Nacionalidad"
        Me.ChIdNacionalidad.Width = 100
        '
        'ChNacionalidad
        '
        Me.ChNacionalidad.Text = "Nacionalidad"
        Me.ChNacionalidad.Width = 200
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
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 24)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Código Nacionalidad:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nacionalidad:"
        '
        'TxtNacionalidad
        '
        Me.TxtNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtNacionalidad.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNacionalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNacionalidad.Location = New System.Drawing.Point(407, 101)
        Me.TxtNacionalidad.Name = "TxtNacionalidad"
        Me.TxtNacionalidad.ReadOnly = True
        Me.TxtNacionalidad.Size = New System.Drawing.Size(223, 29)
        Me.TxtNacionalidad.TabIndex = 11
        '
        'PCentarl
        '
        Me.PCentarl.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PCentarl.Controls.Add(Me.PbxLogo)
        Me.PCentarl.Controls.Add(Me.LsvLugarTrabajo)
        Me.PCentarl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PCentarl.Location = New System.Drawing.Point(0, 208)
        Me.PCentarl.Name = "PCentarl"
        Me.PCentarl.Size = New System.Drawing.Size(968, 300)
        Me.PCentarl.TabIndex = 18
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbxLogo.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.LogoCooperativa
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Location = New System.Drawing.Point(733, 245)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(245, 71)
        Me.PbxLogo.TabIndex = 13
        Me.PbxLogo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.BtnCerrar)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnModificar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BtnNuevo)
        Me.GroupBox1.Controls.Add(Me.TxtIdNacionalidad)
        Me.GroupBox1.Controls.Add(Me.TxtNacionalidad)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 208)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
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
        Me.BtnCerrar.Location = New System.Drawing.Point(931, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(37, 33)
        Me.BtnCerrar.TabIndex = 13
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Image = Global.Cooperativa_XYZ_.My.Resources.Resources.cancelar
        Me.BtnCancelar.Location = New System.Drawing.Point(658, 150)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(39, 43)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnModificar.Enabled = False
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Image = Global.Cooperativa_XYZ_.My.Resources.Resources.editar
        Me.BtnModificar.Location = New System.Drawing.Point(569, 150)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(39, 43)
        Me.BtnModificar.TabIndex = 19
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Image = Global.Cooperativa_XYZ_.My.Resources.Resources.guardar_archivo_opcion
        Me.BtnGuardar.Location = New System.Drawing.Point(484, 150)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(39, 43)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.AccessibleDescription = ""
        Me.BtnNuevo.AccessibleName = ""
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Image = Global.Cooperativa_XYZ_.My.Resources.Resources.boton_nuevo_documento
        Me.BtnNuevo.Location = New System.Drawing.Point(394, 150)
        Me.BtnNuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(39, 43)
        Me.BtnNuevo.TabIndex = 17
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'FrmNacionalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 508)
        Me.Controls.Add(Me.PCentarl)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNacionalidad"
        Me.Text = "FrmNacionalidad"
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsOpciones.ResumeLayout(False)
        Me.PCentarl.ResumeLayout(False)
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents PCentarl As Panel
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents LsvLugarTrabajo As ListView
    Friend WithEvents ChIdNacionalidad As ColumnHeader
    Friend WithEvents ChNacionalidad As ColumnHeader
    Friend WithEvents CmsOpciones As ContextMenuStrip
    Friend WithEvents ToolStripMenuItemEditar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemEliminar As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents TxtIdNacionalidad As TextBox
    Friend WithEvents TxtNacionalidad As TextBox
End Class
