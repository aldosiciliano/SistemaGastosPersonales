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
        Me.SuspendLayout()
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnRegistrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(117, 297)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(180, 45)
        Me.BtnRegistrar.TabIndex = 0
        Me.BtnRegistrar.Text = "Registrar"
        '
        'TxtBoxPassword
        '
        Me.TxtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBoxPassword.DefaultText = "Contraseña"
        Me.TxtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBoxPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBoxPassword.Location = New System.Drawing.Point(107, 242)
        Me.TxtBoxPassword.Name = "TxtBoxPassword"
        Me.TxtBoxPassword.PlaceholderText = ""
        Me.TxtBoxPassword.SelectedText = ""
        Me.TxtBoxPassword.Size = New System.Drawing.Size(200, 36)
        Me.TxtBoxPassword.TabIndex = 1
        '
        'TxtboxUser
        '
        Me.TxtboxUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxUser.DefaultText = "Usuario"
        Me.TxtboxUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtboxUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtboxUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxUser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtboxUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxUser.Location = New System.Drawing.Point(107, 169)
        Me.TxtboxUser.Name = "TxtboxUser"
        Me.TxtboxUser.PlaceholderText = ""
        Me.TxtboxUser.SelectedText = ""
        Me.TxtboxUser.Size = New System.Drawing.Size(200, 36)
        Me.TxtboxUser.TabIndex = 1
        '
        'LinkSesion
        '
        Me.LinkSesion.AutoSize = True
        Me.LinkSesion.Location = New System.Drawing.Point(344, 9)
        Me.LinkSesion.Name = "LinkSesion"
        Me.LinkSesion.Size = New System.Drawing.Size(70, 13)
        Me.LinkSesion.TabIndex = 2
        Me.LinkSesion.TabStop = True
        Me.LinkSesion.Text = "Iniciar Sesion"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(426, 495)
        Me.Controls.Add(Me.LinkSesion)
        Me.Controls.Add(Me.TxtboxUser)
        Me.Controls.Add(Me.TxtBoxPassword)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegistrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBoxPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtboxUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LinkIniciarSesion As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkSesion As LinkLabel
End Class
