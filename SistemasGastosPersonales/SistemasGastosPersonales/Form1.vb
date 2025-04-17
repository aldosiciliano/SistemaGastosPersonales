
Imports System.Data.SQLite

Public Class Form1
    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click
        Try
            ' Establecer la conexión
            Using conexionBD = Conexion.ObtenerConexion()
                ' Crear el comando SQL
                Dim query As String = "SELECT * FROM Categorias"
                Dim comando As New SQLiteCommand(query, conexionBD)

                ' Ejecutar el comando y leer los datos
                Using lector As SQLiteDataReader = comando.ExecuteReader()
                    If lector.HasRows Then
                        While lector.Read()
                            ' Leer los datos de cada columna
                            Dim id As Integer = lector.GetInt32(0) ' Primera columna (IdCategoria)
                            Dim nombre As String = lector.GetString(1) ' Segunda columna (Nombre)
                            Dim tipo As String = lector.GetString(2) ' Tercera columna (Tipo)

                            ' Mostrar los datos en un MessageBox (puedes adaptarlo para mostrar en un DataGridView u otro control)
                            MessageBox.Show($"ID: {id}, Nombre: {nombre}, Tipo: {tipo}", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End While
                    Else
                        MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show($"Error al realizar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class