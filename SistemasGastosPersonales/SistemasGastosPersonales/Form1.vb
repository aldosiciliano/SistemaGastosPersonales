
Imports System.Data.SQLite
Imports SistemasGastosPersonales.Conexion
Public Class Form1
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim Usuario As String = TxtboxUser.Text.Trim()
        Dim Contraseña As String = TxtBoxPassword.Text.Trim()

        'Validacion basica
        If String.IsNullOrEmpty(Usuario) Then
            MessageBox.Show("Por favor, ingrese un nombre para la cuenta.")
            Return
        End If
        If String.IsNullOrEmpty(Contraseña) Then
            MessageBox.Show("Por favor, ingrese una contraseña.")
            Return
        End If
        Try
            Using conn = Conexion.ObtenerConexion()
                Dim query As String = "INSERT INTO Cuentas (Usuario, Contraseña) VALUES (@Usuario, @Contraseña)"
                Using comando As New SQLiteCommand(query, conn)
                    ' Agregar parámetros para evitar inyección SQL
                    comando.Parameters.AddWithValue("@Usuario", Usuario)
                    comando.Parameters.AddWithValue("@Contraseña", Contraseña)
                    ' Ejecutar el comando
                    Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
                    If filasAfectadas > 0 Then
                        MessageBox.Show("Cuenta registrar exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo registrar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show($"Ocurrió un error al registrar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class