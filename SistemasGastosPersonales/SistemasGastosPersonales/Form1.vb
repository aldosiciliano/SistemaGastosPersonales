
Imports System.Data.SQLite
Imports SistemasGastosPersonales.Conexion
Public Class Form1
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombreCuenta As String = TextBoxNombreCuenta.Text.Trim()
        Dim saldoInicial As Decimal

        'Validacion basica
        If String.IsNullOrEmpty(nombreCuenta) Then
            MessageBox.Show("Por favor, ingrese un nombre para la cuenta.")
            Return
        End If
        If Not Decimal.TryParse(TextBoxSaldoInicial.Text.Trim(), saldoInicial) Then
            MessageBox.Show("Por favor, ingrese un saldo inicial válido.")
            Return
        End If
        Try
            Using conn = Conexion.ObtenerConexion()
                Dim query As String = "INSERT INTO Cuentas (Nombre, SaldoInicial) VALUES (@Nombre, @SaldoInicial)"
                Using comando As New SQLiteCommand(query, conn)
                    ' Agregar parámetros para evitar inyección SQL
                    comando.Parameters.AddWithValue("@Nombre", nombreCuenta)
                    comando.Parameters.AddWithValue("@SaldoInicial", saldoInicial)

                    ' Ejecutar el comando
                    Dim filasAfectadas As Integer = comando.ExecuteNonQuery()
                    If filasAfectadas > 0 Then
                        MessageBox.Show("Cuenta guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo guardar la cuenta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show($"Ocurrió un error al guardar la cuenta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Conexion funcionando...

End Class