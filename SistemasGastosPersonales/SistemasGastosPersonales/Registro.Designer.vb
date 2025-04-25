<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TxtPassword = New Label()
        TxtboxUser = New TextBox()
        TxtBoxPassword = New TextBox()
        BtnRegistrar = New Button()
        LinkIniciarSesion = New LinkLabel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(331, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 0
        Label1.Text = "Usuario"
        ' 
        ' TxtPassword
        ' 
        TxtPassword.AutoSize = True
        TxtPassword.Location = New Point(331, 207)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.Size = New Size(67, 15)
        TxtPassword.TabIndex = 1
        TxtPassword.Text = "Contraseña"
        ' 
        ' TxtboxUser
        ' 
        TxtboxUser.Location = New Point(331, 167)
        TxtboxUser.Name = "TxtboxUser"
        TxtboxUser.Size = New Size(164, 23)
        TxtboxUser.TabIndex = 2
        ' 
        ' TxtBoxPassword
        ' 
        TxtBoxPassword.Location = New Point(331, 225)
        TxtBoxPassword.Name = "TxtBoxPassword"
        TxtBoxPassword.Size = New Size(164, 23)
        TxtBoxPassword.TabIndex = 3
        ' 
        ' BtnRegistrar
        ' 
        BtnRegistrar.Cursor = Cursors.No
        BtnRegistrar.Location = New Point(364, 263)
        BtnRegistrar.Name = "BtnRegistrar"
        BtnRegistrar.Size = New Size(75, 23)
        BtnRegistrar.TabIndex = 4
        BtnRegistrar.Text = "Registrar"
        BtnRegistrar.UseVisualStyleBackColor = True
        ' 
        ' LinkIniciarSesion
        ' 
        LinkIniciarSesion.AutoSize = True
        LinkIniciarSesion.Location = New Point(765, 9)
        LinkIniciarSesion.Name = "LinkIniciarSesion"
        LinkIniciarSesion.Size = New Size(76, 15)
        LinkIniciarSesion.TabIndex = 5
        LinkIniciarSesion.TabStop = True
        LinkIniciarSesion.Text = "Iniciar Sesion"
        ' 
        ' Registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(853, 483)
        Controls.Add(LinkIniciarSesion)
        Controls.Add(BtnRegistrar)
        Controls.Add(TxtBoxPassword)
        Controls.Add(TxtboxUser)
        Controls.Add(TxtPassword)
        Controls.Add(Label1)
        Name = "Registro"
        Text = "Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPassword As Label
    Friend WithEvents TxtboxUser As TextBox
    Friend WithEvents TxtBoxPassword As TextBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents LinkIniciarSesion As LinkLabel

End Class
