Imports SistemaGastosPersonales.Modelos
Imports SistemaGastosPersonales.Conexion
Public Class FrmIniciarSesion
    Private usuarioController As New UsuarioController()
    Private Function ValidarCampo(textbox As Guna.UI2.WinForms.Guna2TextBox, textoPorDefecto As String) As Boolean
        If textbox.Text = textoPorDefecto OrElse String.IsNullOrWhiteSpace(textbox.Text) Then
            MessageBox.Show($"Debe ingresar un valor válido para {textoPorDefecto}.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textbox.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        If Not ValidarCampo(TxtboxUserSesion, "Usuario") Then Exit Sub
        If Not ValidarCampo(TxtBoxPassIniciar, "Contraseña") Then Exit Sub

        Dim usuario As New Usuario With {
            .Usuario = TxtboxUserSesion.Text.Trim(),
            .Contraseña = TxtBoxPassIniciar.Text.Trim()
        }

        Try
            If usuarioController.IniciarSesion(usuario.Usuario, usuario.Contraseña) Then
                Dim interfazPrincipal As New InterfazPrincipal()
                interfazPrincipal.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmIniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxPassIniciar.PasswordChar = "*"
    End Sub

    Private Sub TxtboxUser_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBoxPassIniciar.KeyDown, TxtboxUserSesion.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnIniciarSesion.PerformClick()
        End If
    End Sub

    Private Sub TxtboxUserSesion_Enter(sender As Object, e As EventArgs) Handles TxtboxUserSesion.Enter
        TxtboxUserSesion.Clear()
    End Sub

    Private Sub TxtboxUserSesion_Leave(sender As Object, e As EventArgs) Handles TxtboxUserSesion.Leave
        If String.IsNullOrWhiteSpace(TxtboxUserSesion.Text) Then
            TxtboxUserSesion.Text = "Usuario"
        End If
    End Sub
    Private Sub TxtBoxPassIniciar_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxPassIniciar.TextChanged

    End Sub
    Private Sub TxtBoxPassIniciar_Enter(sender As Object, e As EventArgs) Handles TxtBoxPassIniciar.Enter
        TxtBoxPassIniciar.Clear()
    End Sub

    Private Sub TxtBoxPassIniciar_Leave(sender As Object, e As EventArgs) Handles TxtBoxPassIniciar.Leave
        If String.IsNullOrWhiteSpace(TxtBoxPassIniciar.Text) Then
            TxtBoxPassIniciar.Text = "Contraseña"
        End If
    End Sub

    Private Sub TxtboxUserSesion_TextChanged(sender As Object, e As EventArgs) Handles TxtboxUserSesion.TextChanged

    End Sub

    Private Sub btnMostrarContra_Click(sender As Object, e As EventArgs) Handles btnMostrarContra.Click
        If TxtBoxPassIniciar.PasswordChar = "*" Then
            TxtBoxPassIniciar.PasswordChar = ""
            btnMostrarContra.Image = My.Resources.cerrar_ojo
        Else
            TxtBoxPassIniciar.PasswordChar = "*"
            btnMostrarContra.Image = My.Resources.ver
        End If
    End Sub

    Private Sub lbVolverReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbVolverReg.LinkClicked
        Registro.Show()
        Me.Hide()
    End Sub
End Class