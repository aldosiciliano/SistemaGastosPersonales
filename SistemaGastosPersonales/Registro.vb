Imports SistemaGastosPersonales.Modelos
Imports SistemaGastosPersonales.Conexion
Public Class Registro

    Private usuarioController As New UsuarioController()
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If Not ValidarCampo(TxtboxDNI, "DNI") Then Exit Sub
        If Not ValidarCampo(TxtboxNombre, "Nombre") Then Exit Sub
        If Not ValidarCampo(TxtboxApellido, "Apellido") Then Exit Sub
        If Not ValidarCampo(TxtboxEmail, "Correo") Then Exit Sub
        If Not ValidarCampo(TxtboxUser, "Usuario") Then Exit Sub
        If Not ValidarCampo(TxtBoxPassword, "Contraseña") Then Exit Sub

        Dim usuario As New Usuario With {
        .Usuario = TxtboxUser.Text.Trim(),
        .Contraseña = Hash.HashearSHA256(TxtBoxPassword.Text.Trim())
        }

        Dim perfil As New Perfil With {
        .Nombre = TxtboxNombre.Text.Trim(),
        .Apellido = TxtboxApellido.Text.Trim(),
        .DNI = TxtboxDNI.Text.Trim(),
        .Email = TxtboxEmail.Text.Trim()
        }

        If usuarioController.Registrar(usuario, perfil) Then
            MessageBox.Show("Registro exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FrmIniciarSesion.Show()
            Me.Hide()
        Else
            MessageBox.Show("Error al registrar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ' Función de validación general
    Private Function ValidarCampo(textbox As Guna.UI2.WinForms.Guna2TextBox, textoPorDefecto As String) As Boolean
        If textbox.Text = textoPorDefecto OrElse String.IsNullOrWhiteSpace(textbox.Text) Then
            MessageBox.Show($"Debe ingresar un valor válido para {textoPorDefecto}.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textbox.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub FrmIniciarSesion_FormClosed(sender As Object, e As FormClosedEventArgs)
        ' Cerrar el formulario Registro cuando FrmIniciarSesion se cierre
        Me.Close()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxPassword.PasswordChar = "*"
    End Sub

    Private Sub TxtboxUser_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtboxUser.KeyDown, TxtBoxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkSesion.LinkClicked
        Dim frmIniciarSesion As New FrmIniciarSesion()
        ' Suscribir el evento FormClosed
        AddHandler frmIniciarSesion.FormClosed, AddressOf FrmIniciarSesion_FormClosed
        frmIniciarSesion.Show()
        Me.Hide()
    End Sub

    'VACIAR Y REESTABLECER CAMPOS (estetico) 
    Private Sub TxtboxApellido_Enter(sender As Object, e As EventArgs) Handles TxtboxApellido.Enter
        TxtboxApellido.Clear()
    End Sub

    Private Sub TxtboxApellido_Leave(sender As Object, e As EventArgs) Handles TxtboxApellido.Leave
        ' Si el campo está vacío, restablecer el texto predeterminado
        If String.IsNullOrWhiteSpace(TxtboxApellido.Text) Then
            TxtboxApellido.Text = "Apellido"
        End If
    End Sub


    Private Sub TxtboxNombre_Enter(sender As Object, e As EventArgs) Handles TxtboxNombre.Enter
        TxtboxNombre.Clear()
    End Sub

    Private Sub TxtboxNombre_Leave(sender As Object, e As EventArgs) Handles TxtboxNombre.Leave

        If String.IsNullOrWhiteSpace(TxtboxNombre.Text) Then
            TxtboxNombre.Text = "Nombre"
        End If
    End Sub

    Private Sub TxtboxEmail_Enter(sender As Object, e As EventArgs) Handles TxtboxEmail.Enter
        TxtboxEmail.Clear()
    End Sub

    Private Sub TxtboxEmail_Leave(sender As Object, e As EventArgs) Handles TxtboxEmail.Leave
        If String.IsNullOrWhiteSpace(TxtboxEmail.Text) Then
            TxtboxEmail.Text = "Correo"
        End If
    End Sub

    Private Sub TxtboxDNI_Enter(sender As Object, e As EventArgs) Handles TxtboxDNI.Enter
        TxtboxDNI.Clear()
    End Sub

    Private Sub TxtboxDNI_Leave(sender As Object, e As EventArgs) Handles TxtboxDNI.Leave

        If String.IsNullOrWhiteSpace(TxtboxDNI.Text) Then
            TxtboxDNI.Text = "DNI"
        End If
    End Sub


    Private Sub TxtboxUser_Enter(sender As Object, e As EventArgs) Handles TxtboxUser.Enter
        TxtboxUser.Clear()
    End Sub

    Private Sub TxtboxUser_Leave(sender As Object, e As EventArgs) Handles TxtboxUser.Leave
        If String.IsNullOrWhiteSpace(TxtboxUser.Text) Then
            TxtboxUser.Text = "Usuario"
        End If
    End Sub

    Private Sub TxtboxPassword_Enter(sender As Object, e As EventArgs) Handles TxtBoxPassword.Enter
        TxtBoxPassword.Clear()
    End Sub

    Private Sub TxtboxPassword_Leave(sender As Object, e As EventArgs) Handles TxtBoxPassword.Leave
        If String.IsNullOrWhiteSpace(TxtBoxPassword.Text) Then
            TxtBoxPassword.Text = "Contraseña"
        End If
    End Sub


    Private Sub btnMostrarContra_Click(sender As Object, e As EventArgs) Handles btnMostrarContra.Click
        If TxtBoxPassword.PasswordChar = "*" Then
            TxtBoxPassword.PasswordChar = ""
            btnMostrarContra.Image = My.Resources.cerrar_ojo
        Else
            TxtBoxPassword.PasswordChar = "*"
            btnMostrarContra.Image = My.Resources.ver
        End If
    End Sub
End Class