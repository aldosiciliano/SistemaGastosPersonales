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
        BtnIniciarSesion = New Button()
        TxtUsuario = New Label()
        TxtboxUserSesion = New TextBox()
        TxtPass = New Label()
        TxtBoxPassIniciar = New TextBox()
        SuspendLayout()
        ' 
        ' BtnIniciarSesion
        ' 
        BtnIniciarSesion.Location = New Point(322, 253)
        BtnIniciarSesion.Name = "BtnIniciarSesion"
        BtnIniciarSesion.Size = New Size(97, 23)
        BtnIniciarSesion.TabIndex = 0
        BtnIniciarSesion.Text = "Iniciar Sesion"
        BtnIniciarSesion.UseVisualStyleBackColor = True
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.AutoSize = True
        TxtUsuario.Location = New Point(313, 142)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(47, 15)
        TxtUsuario.TabIndex = 1
        TxtUsuario.Text = "Usuario"
        ' 
        ' TxtboxUserSesion
        ' 
        TxtboxUserSesion.Location = New Point(313, 160)
        TxtboxUserSesion.Name = "TxtboxUserSesion"
        TxtboxUserSesion.Size = New Size(112, 23)
        TxtboxUserSesion.TabIndex = 2
        ' 
        ' TxtPass
        ' 
        TxtPass.AutoSize = True
        TxtPass.Location = New Point(313, 201)
        TxtPass.Name = "TxtPass"
        TxtPass.Size = New Size(67, 15)
        TxtPass.TabIndex = 1
        TxtPass.Text = "Contraseña"
        ' 
        ' TxtBoxPassIniciar
        ' 
        TxtBoxPassIniciar.Location = New Point(313, 219)
        TxtBoxPassIniciar.Name = "TxtBoxPassIniciar"
        TxtBoxPassIniciar.Size = New Size(112, 23)
        TxtBoxPassIniciar.TabIndex = 2
        ' 
        ' FrmIniciarSesion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(TxtBoxPassIniciar)
        Controls.Add(TxtboxUserSesion)
        Controls.Add(TxtPass)
        Controls.Add(TxtUsuario)
        Controls.Add(BtnIniciarSesion)
        Name = "FrmIniciarSesion"
        Text = "Iniciar Sesion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnIniciarSesion As Button
    Friend WithEvents TxtUsuario As Label
    Friend WithEvents TxtboxUserSesion As TextBox
    Friend WithEvents TxtPass As Label
    Friend WithEvents TxtBoxPassIniciar As TextBox
End Class
