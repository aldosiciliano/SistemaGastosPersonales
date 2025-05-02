Imports System.Data.SQLite

Public Class FrmIniciarSesion

    Private Function ValidarCampo(textbox As Guna.UI2.WinForms.Guna2TextBox, textoPorDefecto As String) As Boolean
        If textbox.Text = textoPorDefecto OrElse String.IsNullOrWhiteSpace(textbox.Text) Then
            MessageBox.Show($"Debe ingresar un valor válido para {textoPorDefecto}.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textbox.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        Dim Usuario As String = TxtboxUserSesion.Text.Trim()
        Dim Contraseña As String = TxtBoxPassIniciar.Text.Trim()

        If Not ValidarCampo(TxtboxUserSesion, "Usuario") OrElse Not ValidarCampo(TxtBoxPassIniciar, "Contraseña") Then
            Return
        End If

        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Dim query = "SELECT Contraseña FROM Usuarios WHERE Usuario = @Usuario"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", Usuario)

                    Dim result = cmd.ExecuteScalar()
                    If result Is Nothing Then
                        MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Dim ContraseñaBD As String = result.ToString()
                    Dim ContraseñaIngresadaHash As String = Hash.HashearSHA256(Contraseña)

                    If ContraseñaBD <> ContraseñaIngresadaHash Then
                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim interfazPrincipal As New InterfazPrincipal()
                        interfazPrincipal.UsuarioActual = Usuario
                        interfazPrincipal.Show()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message)
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

End Class