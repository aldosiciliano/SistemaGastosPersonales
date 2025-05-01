<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.BtnRegistrar = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtBoxPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtboxUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LinkSesion = New System.Windows.Forms.LinkLabel()
        Me.TxtboxNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtboxApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtboxDNI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtboxEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BorderRadius = 10
        Me.BtnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRegistrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(116, 410)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(180, 45)
        Me.BtnRegistrar.TabIndex = 0
        Me.BtnRegistrar.Text = "Registrar"
        '
        'TxtBoxPassword
        '
        Me.TxtBoxPassword.BorderRadius = 10
        Me.TxtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBoxPassword.DefaultText = "Contraseña"
        Me.TxtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBoxPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBoxPassword.Location = New System.Drawing.Point(107, 368)
        Me.TxtBoxPassword.Name = "TxtBoxPassword"
        Me.TxtBoxPassword.PlaceholderText = ""
        Me.TxtBoxPassword.SelectedText = ""
        Me.TxtBoxPassword.Size = New System.Drawing.Size(200, 36)
        Me.TxtBoxPassword.TabIndex = 1
        '
        'TxtboxUser
        '
        Me.TxtboxUser.BorderRadius = 10
        Me.TxtboxUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxUser.DefaultText = "Usuario"
        Me.TxtboxUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtboxUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtboxUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtboxUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxUser.Location = New System.Drawing.Point(107, 326)
        Me.TxtboxUser.Name = "TxtboxUser"
        Me.TxtboxUser.PlaceholderText = ""
        Me.TxtboxUser.SelectedText = ""
        Me.TxtboxUser.Size = New System.Drawing.Size(200, 36)
        Me.TxtboxUser.TabIndex = 1
        '
        'LinkSesion
        '
        Me.LinkSesion.AutoSize = True
        Me.LinkSesion.LinkColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.LinkSesion.Location = New System.Drawing.Point(153, 459)
        Me.LinkSesion.Name = "LinkSesion"
        Me.LinkSesion.Size = New System.Drawing.Size(107, 13)
        Me.LinkSesion.TabIndex = 2
        Me.LinkSesion.TabStop = True
        Me.LinkSesion.Text = "Ya tengo una cuenta"
        '
        'TxtboxNombre
        '
        Me.TxtboxNombre.BorderRadius = 10
        Me.TxtboxNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxNombre.DefaultText = "Nombre"
        Me.TxtboxNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtboxNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtboxNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtboxNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxNombre.Location = New System.Drawing.Point(107, 158)
        Me.TxtboxNombre.Name = "TxtboxNombre"
        Me.TxtboxNombre.PlaceholderText = ""
        Me.TxtboxNombre.SelectedText = ""
        Me.TxtboxNombre.Size = New System.Drawing.Size(200, 36)
        Me.TxtboxNombre.TabIndex = 4
        '
        'TxtboxApellido
        '
        Me.TxtboxApellido.BorderRadius = 10
        Me.TxtboxApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxApellido.DefaultText = "Apellido"
        Me.TxtboxApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtboxApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtboxApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxApellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtboxApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxApellido.Location = New System.Drawing.Point(107, 200)
        Me.TxtboxApellido.Name = "TxtboxApellido"
        Me.TxtboxApellido.PlaceholderText = ""
        Me.TxtboxApellido.SelectedText = ""
        Me.TxtboxApellido.Size = New System.Drawing.Size(200, 36)
        Me.TxtboxApellido.TabIndex = 5
        '
        'TxtboxDNI
        '
        Me.TxtboxDNI.BorderRadius = 10
        Me.TxtboxDNI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxDNI.DefaultText = "D.N.I"
        Me.TxtboxDNI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtboxDNI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtboxDNI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxDNI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxDNI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxDNI.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtboxDNI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxDNI.Location = New System.Drawing.Point(107, 242)
        Me.TxtboxDNI.Name = "TxtboxDNI"
        Me.TxtboxDNI.PlaceholderText = ""
        Me.TxtboxDNI.SelectedText = ""
        Me.TxtboxDNI.Size = New System.Drawing.Size(200, 36)
        Me.TxtboxDNI.TabIndex = 6
        '
        'TxtboxEmail
        '
        Me.TxtboxEmail.BorderRadius = 10
        Me.TxtboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxEmail.DefaultText = "Correo"
        Me.TxtboxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtboxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtboxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtboxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxEmail.Location = New System.Drawing.Point(107, 284)
        Me.TxtboxEmail.Name = "TxtboxEmail"
        Me.TxtboxEmail.PlaceholderText = ""
        Me.TxtboxEmail.SelectedText = ""
        Me.TxtboxEmail.Size = New System.Drawing.Size(200, 36)
        Me.TxtboxEmail.TabIndex = 7
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SistemaGastosPersonales.My.Resources.Resources.Logo1
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, -38)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(370, 274)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(418, 521)
        Me.Controls.Add(Me.TxtboxEmail)
        Me.Controls.Add(Me.TxtboxDNI)
        Me.Controls.Add(Me.TxtboxApellido)
        Me.Controls.Add(Me.TxtboxNombre)
        Me.Controls.Add(Me.LinkSesion)
        Me.Controls.Add(Me.TxtboxUser)
        Me.Controls.Add(Me.TxtBoxPassword)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegistrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBoxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtboxUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LinkIniciarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkSesion As LinkLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TxtboxNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtboxApellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtboxDNI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtboxEmail As Guna.UI2.WinForms.Guna2TextBox
End Class
