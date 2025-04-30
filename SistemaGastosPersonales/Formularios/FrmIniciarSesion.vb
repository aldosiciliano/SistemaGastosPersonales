Imports System.Data.SQLite

Public Class FrmIniciarSesion
    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        Dim Usuario As String = TxtboxUserSesion.Text.Trim()
        Dim Contraseña As String = TxtBoxPassIniciar.Text.Trim()

        If String.IsNullOrEmpty(Usuario) Or String.IsNullOrEmpty(Contraseña) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Dim query = "SELECT Contraseña FROM Cuentas WHERE Usuario = @Usuario"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", Usuario)

                    Dim result = cmd.ExecuteScalar()
                    If result Is Nothing Then
                        MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                    Dim ContraseñaBD As String = result.ToString()
                    Dim ContraseñaIngresadaHash As String = Hash.HashearSHA256(Contraseña)

                    If ContraseñaBD <> ContraseñaIngresadaHash Then
                        MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim interfazPrincipal As New InterfazPrincipal()
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
End Class