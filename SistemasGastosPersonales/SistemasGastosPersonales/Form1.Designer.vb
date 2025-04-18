<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label2 = New Label()
        TextBoxUserName = New TextBox()
        TextBoxSaldoInicial = New TextBox()
        btnGuardar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(331, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre de Cuenta"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(331, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 1
        Label2.Text = "Saldo Inicial"
        ' 
        ' TextBoxUserName
        ' 
        TextBoxUserName.Location = New Point(331, 167)
        TextBoxUserName.Name = "TextBoxUserName"
        TextBoxUserName.Size = New Size(164, 23)
        TextBoxUserName.TabIndex = 2
        ' 
        ' TextBoxSaldoInicial
        ' 
        TextBoxSaldoInicial.Location = New Point(331, 225)
        TextBoxSaldoInicial.Name = "TextBoxSaldoInicial"
        TextBoxSaldoInicial.Size = New Size(164, 23)
        TextBoxSaldoInicial.TabIndex = 3
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Cursor = Cursors.No
        btnGuardar.Location = New Point(364, 263)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(75, 23)
        btnGuardar.TabIndex = 4
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(853, 483)
        Controls.Add(btnGuardar)
        Controls.Add(TextBoxSaldoInicial)
        Controls.Add(TextBoxUserName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents TextBoxSaldoInicial As TextBox
    Friend WithEvents btnGuardar As Button

End Class
