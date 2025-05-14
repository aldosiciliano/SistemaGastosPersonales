Imports SistemaGastosPersonales.Modelos
Imports SistemaGastosPersonales.Conexion
Imports System.Data.SQLite
Public Class UsuarioController
    Public Function Registrar(usuario As Usuario, perfil As Perfil) As Boolean
        Try
            Using conn = Conexion.ObtenerConexion()
                Using transaccion = conn.BeginTransaction()
                    Try
                        'Insertar usuarios
                        Dim queryUsuario As String = "INSERT INTO Usuarios (Usuario, Contraseña) VALUES (@Usuario, @Contraseña); SELECT last_insert_rowid();"
                        Dim idUsuario As Integer
                        Using comandoUsuario As New SQLiteCommand(queryUsuario, conn)
                            comandoUsuario.Parameters.AddWithValue("@Usuario", usuario.Usuario)
                            comandoUsuario.Parameters.AddWithValue("@Contraseña", usuario.Contraseña)
                            idUsuario = Convert.ToInt32(comandoUsuario.ExecuteScalar())
                        End Using
                        'Insertar perfil
                        Dim queryPerfil As String = "INSERT INTO Perfil (DNI, Nombre, Apellido, Email, UsuarioId) VALUES (@DNI, @Nombre, @Apellido, @Email, @UsuarioId)"
                        Using comandoPerfil As New SQLiteCommand(queryPerfil, conn)
                            comandoPerfil.Parameters.AddWithValue("@DNI", perfil.DNI)
                            comandoPerfil.Parameters.AddWithValue("@Nombre", perfil.Nombre)
                            comandoPerfil.Parameters.AddWithValue("@Apellido", perfil.Apellido)
                            comandoPerfil.Parameters.AddWithValue("@Email", perfil.Email)
                            comandoPerfil.Parameters.AddWithValue("@UsuarioId", idUsuario)
                            comandoPerfil.ExecuteNonQuery()
                        End Using
                        transaccion.Commit()
                        Return True
                    Catch ex As Exception
                        transaccion.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
        End Try
    End Function

    Public Function IniciarSesion(usuario As String, contraseña As String) As Boolean
        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Dim queryIniciarSesion As String = "SELECT Contraseña FROM Usuarios WHERE Usuario = @Usuario"
                Using cmd As New SQLiteCommand(queryIniciarSesion, conn)
                    cmd.Parameters.AddWithValue("@Usuario", usuario)
                    Dim result As Object = cmd.ExecuteScalar()

                    If result Is Nothing Then
                        Return False
                    End If

                    Dim contraseñaBD As String = result.ToString()
                    Dim contraseñaIngresadaHash As String = Hash.HashearSHA256(contraseña)

                    Console.WriteLine("Contraseña BD: " & contraseñaBD)
                    Console.WriteLine("Contraseña ingresada hash: " & contraseñaIngresadaHash)

                    Return contraseñaBD = contraseñaIngresadaHash
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception("Error al iniciar sesión: " & ex.Message)
        End Try
    End Function
End Class
