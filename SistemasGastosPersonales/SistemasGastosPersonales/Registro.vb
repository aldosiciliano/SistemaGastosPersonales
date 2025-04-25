
Imports System.Data.SQLite
Imports SistemasGastosPersonales.Conexion
Public Class Registro
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
        'Hashear contraseña
        Dim ContraseñaHasheada As String = Hash.HashearSHA256(Contraseña)

        Try
            Using conn = Conexion.ObtenerConexion()
                Dim query As String = "INSERT INTO Cuentas (Usuario, Contraseña) VALUES (@Usuario, @Contraseña)"
                Using comando As New SQLiteCommand(query, conn)
                    ' Agregar parámetros para evitar inyección SQL
                    comando.Parameters.AddWithValue("@Usuario", Usuario)
                    comando.Parameters.AddWithValue("@Contraseña", ContraseñaHasheada)
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

    Private Sub LinkIniciarSesion_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkIniciarSesion.LinkClicked
        Dim frmIniciarSesion As New FrmIniciarSesion()
        ' Suscribir el evento FormClosed
        AddHandler frmIniciarSesion.FormClosed, AddressOf FrmIniciarSesion_FormClosed

        frmIniciarSesion.Show()
        Me.Hide()
    End Sub

    ' Manejador del evento FormClosed
    Private Sub FrmIniciarSesion_FormClosed(sender As Object, e As FormClosedEventArgs)
        ' Cerrar el formulario Registro cuando FrmIniciarSesion se cierre
        Me.Close()
    End Sub

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TxtBoxPassword.PasswordChar = "*"
    End Sub

End Class