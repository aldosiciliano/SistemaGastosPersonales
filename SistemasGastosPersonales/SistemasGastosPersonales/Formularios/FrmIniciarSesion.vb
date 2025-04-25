Imports System.Data.SQLite
Imports SistemasGastosPersonales.Conexion

Public Class FrmIniciarSesion
    Private Sub BtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles BtnIniciarSesion.Click
        Dim Usuario As String = TxtboxUserSesion.Text.Trim()
        Dim Contraseña As String = TxtBoxPassIniciar.Text.Trim()
        If String.IsNullOrEmpty(Usuario) Then
            MessageBox.Show("Por favor, ingrese el usuario")
            Return
        End If
        If String.IsNullOrEmpty(Contraseña) Then
            MessageBox.Show("Por favor, ingrese una contraseña.")
            Return
        End If
        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Dim query = "SELECT Contraseña FROM Cuentas WHERE Usuario = @Usuario"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", Usuario)
                    Dim result = cmd.ExecuteScalar()
                    If result Is Nothing Then
                        MessageBox.Show("Usuario no encontrado")
                        Return
                    End If
                    Dim ContraseñaBD As String = result.ToString()
                    Dim ContraseñaIngresadaHash As String = Hash.HashearSHA256(Contraseña)
                    If ContraseñaBD = ContraseñaIngresadaHash Then
                        MessageBox.Show("Inicio de sesión exitoso")
                        ' Aquí puedes abrir el formulario principal o realizar otras acciones
                    Else
                        MessageBox.Show("Contraseña incorrecta")
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
End Class