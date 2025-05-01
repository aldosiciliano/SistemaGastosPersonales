<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIniciarSesion
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
        Me.BtnIniciarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.TxtBoxPassIniciar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtboxUserSesion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnIniciarSesion
        '
        Me.BtnIniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnIniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnIniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnIniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnIniciarSesion.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BtnIniciarSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.BtnIniciarSesion.Location = New System.Drawing.Point(117, 302)
        Me.BtnIniciarSesion.Name = "BtnIniciarSesion"
        Me.BtnIniciarSesion.Size = New System.Drawing.Size(180, 45)
        Me.BtnIniciarSesion.TabIndex = 0
        Me.BtnIniciarSesion.Text = "Iniciar Sesion"
        '
        'TxtBoxPassIniciar
        '
        Me.TxtBoxPassIniciar.AcceptsTab = True
        Me.TxtBoxPassIniciar.BorderRadius = 10
        Me.TxtBoxPassIniciar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBoxPassIniciar.DefaultText = "Contraseña" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TxtBoxPassIniciar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtBoxPassIniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtBoxPassIniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBoxPassIniciar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtBoxPassIniciar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBoxPassIniciar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtBoxPassIniciar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtBoxPassIniciar.Location = New System.Drawing.Point(106, 243)
        Me.TxtBoxPassIniciar.Name = "TxtBoxPassIniciar"
        Me.TxtBoxPassIniciar.PlaceholderText = ""
        Me.TxtBoxPassIniciar.SelectedText = ""
        Me.TxtBoxPassIniciar.Size = New System.Drawing.Size(200, 36)
        Me.TxtBoxPassIniciar.TabIndex = 1
        Me.TxtBoxPassIniciar.Tag = ""
        '
        'TxtboxUserSesion
        '
        Me.TxtboxUserSesion.BorderRadius = 10
        Me.TxtboxUserSesion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxUserSesion.DefaultText = "Usuario"
        Me.TxtboxUserSesion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtboxUserSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtboxUserSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxUserSesion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxUserSesion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxUserSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtboxUserSesion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxUserSesion.Location = New System.Drawing.Point(106, 185)
        Me.TxtboxUserSesion.Name = "TxtboxUserSesion"
        Me.TxtboxUserSesion.PlaceholderText = ""
        Me.TxtboxUserSesion.SelectedText = ""
        Me.TxtboxUserSesion.Size = New System.Drawing.Size(200, 36)
        Me.TxtboxUserSesion.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SistemaGastosPersonales.My.Resources.Resources.Logo1
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(3, -25)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(370, 274)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 4
        Me.Guna2PictureBox1.TabStop = False
        '
        'FrmIniciarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(413, 465)
        Me.Controls.Add(Me.TxtboxUserSesion)
        Me.Controls.Add(Me.TxtBoxPassIniciar)
        Me.Controls.Add(Me.BtnIniciarSesion)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Name = "FrmIniciarSesion"
        Me.Text = "Iniciar sesion"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnIniciarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtBoxPassIniciar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtboxUserSesion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
