<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblInicio = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.LblInicio)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.LblMensaje)
        Me.Panel1.Controls.Add(Me.BtnEntrar)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.TxtContraseña)
        Me.Panel1.Controls.Add(Me.TxtUsuario)
        Me.Panel1.Controls.Add(Me.BtnMinimizar)
        Me.Panel1.Controls.Add(Me.BtnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(261, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 309)
        Me.Panel1.TabIndex = 8
        '
        'LblInicio
        '
        Me.LblInicio.AutoSize = True
        Me.LblInicio.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblInicio.Location = New System.Drawing.Point(86, 61)
        Me.LblInicio.Name = "LblInicio"
        Me.LblInicio.Size = New System.Drawing.Size(146, 21)
        Me.LblInicio.TabIndex = 23
        Me.LblInicio.Text = "INICIO DE SESIÓN"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(12, 185)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(297, 1)
        Me.Panel2.TabIndex = 21
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Font = New System.Drawing.Font("Microsoft PhagsPa", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMensaje.ForeColor = System.Drawing.Color.Red
        Me.LblMensaje.Location = New System.Drawing.Point(95, 206)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(0, 17)
        Me.LblMensaje.TabIndex = 22
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.DimGray
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.Font = New System.Drawing.Font("Microsoft PhagsPa", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnEntrar.Location = New System.Drawing.Point(23, 241)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(258, 36)
        Me.BtnEntrar.TabIndex = 21
        Me.BtnEntrar.Tag = "0"
        Me.BtnEntrar.Text = "ENTRAR"
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(12, 136)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 1)
        Me.Panel3.TabIndex = 20
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BackColor = System.Drawing.Color.Black
        Me.TxtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.ForeColor = System.Drawing.Color.Gray
        Me.TxtContraseña.Location = New System.Drawing.Point(12, 166)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(293, 20)
        Me.TxtContraseña.TabIndex = 18
        Me.TxtContraseña.Tag = "2"
        Me.TxtContraseña.Text = "CONTRASEÑA"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BackColor = System.Drawing.Color.Black
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft PhagsPa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.ForeColor = System.Drawing.Color.Gray
        Me.TxtUsuario.Location = New System.Drawing.Point(12, 117)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(293, 20)
        Me.TxtUsuario.TabIndex = 17
        Me.TxtUsuario.Tag = "1"
        Me.TxtUsuario.Text = "USUARIO"
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconMinimizar
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Location = New System.Drawing.Point(247, 2)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(34, 30)
        Me.BtnMinimizar.TabIndex = 7
        Me.BtnMinimizar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.IconCerrar
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Location = New System.Drawing.Point(285, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(34, 30)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbxLogo.BackgroundImage = Global.Cooperativa_XYZ_.My.Resources.Resources.LogoCooperativa
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Location = New System.Drawing.Point(-5, 95)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(270, 113)
        Me.PbxLogo.TabIndex = 7
        Me.PbxLogo.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 309)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PbxLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblInicio As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblMensaje As Label
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PbxLogo As PictureBox
End Class
