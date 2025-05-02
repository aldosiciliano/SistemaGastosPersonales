Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates

Public Class InterfazPrincipal
    Public Property UsuarioActual As String
    Private Sub InterfazPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTipo.Items.Add("Ingreso")
        cbxTipo.Items.Add("Gasto")

        'Cargar el nombre de la persona de la bd
        Dim nombrePersona As String = ""
        Dim query As String = "SELECT Nombre FROM Perfil WHERE UsuarioId = (SELECT IdUsuario FROM Usuarios WHERE Usuario = @Usuario)
"
        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", UsuarioActual)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        nombrePersona = result.ToString()
                    End If
                End Using
            End Using
            PerfilUserLabel.Text = $"Bienvenido, {nombrePersona}"
        Catch ex As Exception
            MessageBox.Show($"Error al cargar el nombre: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipo.SelectedIndexChanged
        cbxCategoria.Items.Clear()
        If cbxTipo.SelectedItem.ToString = "Ingreso" Then
            cbxCategoria.Items.Add("Sueldo")
            cbxCategoria.Items.Add("Alquileres cobrados")
            cbxCategoria.Items.Add("Intereses / Rendimientos")
        ElseIf cbxTipo.SelectedItem.ToString = "Gasto" Then
            cbxCategoria.Items.Add("Alquiler")
            cbxCategoria.Items.Add("Comida")
            cbxCategoria.Items.Add("Transporte")
            cbxCategoria.Items.Add("Servicios")
            cbxCategoria.Items.Add("Salud")

        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim query As String = "SELECT Nombre, Apellido, Email, DNI, Correo FROM Perfil WHERE UsuarioId = (SELECT IdUsuario FROM Usuarios WHERE Usuario = @Usuario)"
        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", UsuarioActual)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            btnNombre.Text = reader("Nombre").ToString()
                            btnApellido.Text = reader("Apellido").ToString()
                            btnDNI.Text = reader("DNI").ToString()
                            btnCorreo.Text = reader("Email").ToString()
                        Else
                            MessageBox.Show("No se encontró el perfil del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al cargar el perfil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class