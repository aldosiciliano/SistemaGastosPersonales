Imports System.Data.SQLite
Imports SistemaGastosPersonales.Conexion
Public Class Registro

    ' Función de validación general
    Private Function ValidarCampo(textbox As Guna.UI2.WinForms.Guna2TextBox, textoPorDefecto As String) As Boolean
        If textbox.Text = textoPorDefecto OrElse String.IsNullOrWhiteSpace(textbox.Text) Then
            MessageBox.Show($"Debe ingresar un valor válido para {textoPorDefecto}.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            textbox.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click

        If Not ValidarCampo(TxtboxDNI, "DNI") Then Exit Sub
        If Not ValidarCampo(TxtboxNombre, "Nombre") Then Exit Sub
        If Not ValidarCampo(TxtboxApellido, "Apellido") Then Exit Sub
        If Not ValidarCampo(TxtboxEmail, "Correo") Then Exit Sub
        If Not ValidarCampo(TxtboxUser, "Usuario") Then Exit Sub
        If Not ValidarCampo(TxtBoxPassword, "Contraseña") Then Exit Sub

        Dim Usuario As String = TxtboxUser.Text.Trim()
        Dim Contraseña As String = TxtBoxPassword.Text.Trim()
        Dim DNI As String = TxtboxDNI.Text.Trim()
        Dim Nombre As String = TxtboxNombre.Text.Trim()
        Dim Apellido As String = TxtboxApellido.Text.Trim()
        Dim Email As String = TxtboxEmail.Text.Trim()

        'Hashear contraseña
        Dim ContraseñaHasheada As String = Hash.HashearSHA256(Contraseña)

        Try
            Using conn = Conexion.ObtenerConexion()
                Using transaccion = conn.BeginTransaction()
                    Try
                        ' 1. Insertar en la tabla Usuarios
                        Dim queryUsuario As String = "INSERT INTO Usuarios (Usuario, Contraseña) VALUES (@Usuario, @Contraseña); SELECT last_insert_rowid();"
                        Dim idUsuario As Integer
                        Using comandoUsuario As New SQLiteCommand(queryUsuario, conn)
                            comandoUsuario.Parameters.AddWithValue("@Usuario", Usuario)
                            comandoUsuario.Parameters.AddWithValue("@Contraseña", ContraseñaHasheada)
                            idUsuario = Convert.ToInt32(comandoUsuario.ExecuteScalar())
                        End Using

                        ' 2. Insertar en la tabla Perfil
                        Dim queryPerfil As String = "INSERT INTO Perfil (DNI, Nombre, Apellido, Email, UsuarioID) VALUES (@DNI, @Nombre, @Apellido, @Email, @UsuarioID)"
                        Using comandoPerfil As New SQLiteCommand(queryPerfil, conn)
                            comandoPerfil.Parameters.AddWithValue("@DNI", DNI)
                            comandoPerfil.Parameters.AddWithValue("@Nombre", Nombre)
                            comandoPerfil.Parameters.AddWithValue("@Apellido", Apellido)
                            comandoPerfil.Parameters.AddWithValue("@Email", Email)
                            comandoPerfil.Parameters.AddWithValue("@UsuarioID", idUsuario)
                            comandoPerfil.ExecuteNonQuery()
                        End Using

                        transaccion.Commit()
                        MessageBox.Show("Cuenta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Catch ex As Exception
                        transaccion.Rollback()
                        MessageBox.Show("Error al registrar el perfil: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Ocurrió un error general: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub LinkIniciarSesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkIniciarSesion.LinkClicked
    '    Dim frmIniciarSesion As New FrmIniciarSesion()
    '     Suscribir el evento FormClosed
    '    AddHandler frmIniciarSesion.FormClosed, AddressOf FrmIniciarSesion_FormClosed
    '    frmIniciarSesion.Show()
    '    Me.Hide()
    'End Sub
    ' Manejador del evento FormClosed
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
    Private Sub TxtboxApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtboxApellido.TextChanged

    End Sub
    Private Sub TxtboxApellido_Enter(sender As Object, e As EventArgs) Handles TxtboxApellido.Enter
        TxtboxApellido.Clear()
    End Sub

    Private Sub TxtboxApellido_Leave(sender As Object, e As EventArgs) Handles TxtboxApellido.Leave
        ' Si el campo está vacío, restablecer el texto predeterminado
        If String.IsNullOrWhiteSpace(TxtboxApellido.Text) Then
            TxtboxApellido.Text = "Apellido"
        End If
    End Sub

    Private Sub TxtboxNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtboxNombre.TextChanged

    End Sub

    Private Sub TxtboxNombre_Enter(sender As Object, e As EventArgs) Handles TxtboxNombre.Enter
        TxtboxNombre.Clear()
    End Sub

    Private Sub TxtboxNombre_Leave(sender As Object, e As EventArgs) Handles TxtboxNombre.Leave

        If String.IsNullOrWhiteSpace(TxtboxNombre.Text) Then
            TxtboxNombre.Text = "Nombre"
        End If
    End Sub
    Private Sub TxtboxEmail_TextChanged(sender As Object, e As EventArgs) Handles TxtboxEmail.TextChanged

    End Sub

    Private Sub TxtboxEmail_Enter(sender As Object, e As EventArgs) Handles TxtboxEmail.Enter
        TxtboxEmail.Clear()
    End Sub

    Private Sub TxtboxEmail_Leave(sender As Object, e As EventArgs) Handles TxtboxEmail.Leave
        If String.IsNullOrWhiteSpace(TxtboxEmail.Text) Then
            TxtboxEmail.Text = "Correo"
        End If
    End Sub
    Private Sub TxtboxDNI_TextChanged(sender As Object, e As EventArgs) Handles TxtboxDNI.TextChanged

    End Sub

    Private Sub TxtboxDNI_Enter(sender As Object, e As EventArgs) Handles TxtboxDNI.Enter
        TxtboxDNI.Clear()
    End Sub

    Private Sub TxtboxDNI_Leave(sender As Object, e As EventArgs) Handles TxtboxDNI.Leave

        If String.IsNullOrWhiteSpace(TxtboxDNI.Text) Then
            TxtboxDNI.Text = "DNI"
        End If
    End Sub

    Private Sub TxtboxUser_TextChanged(sender As Object, e As EventArgs) Handles TxtboxUser.TextChanged

    End Sub
    Private Sub TxtboxUser_Enter(sender As Object, e As EventArgs) Handles TxtboxUser.Enter
        TxtboxUser.Clear()
    End Sub

    Private Sub TxtboxUser_Leave(sender As Object, e As EventArgs) Handles TxtboxUser.Leave
        If String.IsNullOrWhiteSpace(TxtboxUser.Text) Then
            TxtboxUser.Text = "Usuario"
        End If
    End Sub
    Private Sub TxtboxContraseña_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxPassword.TextChanged

    End Sub
    Private Sub TxtboxPassword_Enter(sender As Object, e As EventArgs) Handles TxtBoxPassword.Enter
        TxtBoxPassword.Clear()
    End Sub

    Private Sub TxtboxPassword_Leave(sender As Object, e As EventArgs) Handles TxtBoxPassword.Leave
        If String.IsNullOrWhiteSpace(TxtBoxPassword.Text) Then
            TxtBoxPassword.Text = "Contraseña"
        End If
    End Sub

End Class