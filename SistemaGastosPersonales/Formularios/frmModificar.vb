Imports System.Data.SQLite
Imports Guna.UI2.WinForms.Suite

Public Class frmModificar
    Public Property IdMovimiento As Integer
    'Construcctor
    Public Sub New(idMovimiento As Integer, fecha As String, tipo As String, categoria As String, monto As Decimal, metodo As String, descripcion As String)
        InitializeComponent()
        CargarEntidad()
        CargarMetodos()
        ' Asignar los valores a los controles del formulario
        Me.IdMovimiento = idMovimiento
        cbxTipo.Text = tipo
        cbxCategoria.Text = categoria
        cbxMetodo.Text = metodo
        dtpFecha.Value = DateTime.Parse(fecha)
        txtMonto.Text = monto.ToString("F2")
        txtDescripcion.Text = descripcion
    End Sub
    Private Sub cbxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipo.SelectedIndexChanged
        ' Limpiar las categorías actuales
        cbxCategoria.Items.Clear()

        ' Verificar el tipo seleccionado y cargar las categorías correspondientes
        If cbxTipo.SelectedItem IsNot Nothing Then
            If cbxTipo.SelectedItem.ToString() = "Ingreso" Then
                cbxCategoria.Items.Add("Salario")
                cbxCategoria.Items.Add("Alquileres cobrados")
                cbxCategoria.Items.Add("Intereses/Rendimiento")
            ElseIf cbxTipo.SelectedItem.ToString() = "Gasto" Then
                cbxCategoria.Items.Add("Alquiler")
                cbxCategoria.Items.Add("Comida")
                cbxCategoria.Items.Add("Transporte")
                cbxCategoria.Items.Add("Servicios")
                cbxCategoria.Items.Add("Salud")
            End If
        End If

        ' Seleccionar la primera opción por defecto
        If cbxCategoria.Items.Count > 0 Then
            cbxCategoria.SelectedIndex = 0
        End If
    End Sub

    Public Sub CargarMetodos()
        ' Limpiar los métodos actuales
        cbxMetodo.Items.Clear()
        ' Cargar los métodos de pago
        cbxMetodo.Items.Add("Efectivo")
        cbxMetodo.Items.Add("Tarjeta de credito")
        cbxMetodo.Items.Add("Tarjeta de debito")
        cbxMetodo.Items.Add("Transferencia")
        ' Seleccionar la primera opción por defecto
        If cbxMetodo.Items.Count > 0 Then
            cbxMetodo.SelectedIndex = 0
        End If
    End Sub

    Public Sub CargarEntidad()
        'Limpiar las entidades actales 
        cbxMetodo.Items.Clear()

        cbxEntidad.Items.Add("Banco BBVA")
        cbxEntidad.Items.Add("Banco Santander")
        cbxEntidad.Items.Add("Banco Nacion")
        cbxEntidad.Items.Add("Otros")
    End Sub

    Private Function ObtenerIdCategoria(conn As SQLiteConnection, nombreCategoria As String, tipoSeleccionado As String) As Integer
        Dim query As String = "SELECT IdCategoria FROM Categorias WHERE Nombre = @nombre AND Tipo = @tipo"
        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@nombre", nombreCategoria)
            cmd.Parameters.AddWithValue("@tipo", tipoSeleccionado)
            Dim resultado = cmd.ExecuteScalar()

            If resultado IsNot Nothing Then
                Return Convert.ToInt32(resultado)
            Else
                Throw New Exception($"No se encontró la categoría '{nombreCategoria}' para el tipo '{tipoSeleccionado}'.")
            End If
        End Using
    End Function
    Private Function ObtenerIdMetodo(conn As SQLiteConnection, nombreMetodo As String) As Integer
        Dim query As String = "SELECT IdMetodo FROM Metodo WHERE Origen = @nombre"
        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@nombre", nombreMetodo)
            Dim resultado = cmd.ExecuteScalar()

            If resultado IsNot Nothing Then
                Return Convert.ToInt32(resultado)
            Else
                Throw New Exception($"No se encontró el método '{nombreMetodo}'.")
            End If
        End Using
    End Function

    Public Event DatosActualizados()

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Obtener los valores de los controles
        Dim fecha As String = dtpFecha.Value.ToString("yyyy-MM-dd")
        Dim tipo As String = cbxTipo.SelectedItem.ToString()
        Dim categoria As String = cbxCategoria.SelectedItem.ToString()
        Dim monto As Decimal
        Dim metodo As String = cbxMetodo.SelectedItem.ToString()
        Dim descripcion As String = txtDescripcion.Text

        ' Validar el monto
        If Not Decimal.TryParse(txtMonto.Text, monto) Then
            MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Conexión a la base de datos
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                ' Obtener el IdCategoria correspondiente
                Dim idCategoria As Integer = ObtenerIdCategoria(conn, categoria, tipo)

                ' Obtener el IdMetodo correspondiente
                Dim idMetodo As Integer = ObtenerIdMetodo(conn, metodo)

                ' Consulta SQL para actualizar los datos
                Dim query As String = "UPDATE Movimientos SET Fecha = @fecha, Tipo = @tipo, CategoriaId = @categoriaId, Monto = @monto, IdMetodo = @IdMetodo, Descripcion = @descripcion WHERE IdMovimiento = @id"
                Using cmd As New SQLiteCommand(query, conn)
                    ' Asignar los parámetros de la consulta
                    cmd.Parameters.AddWithValue("@id", IdMovimiento) ' Asegúrate de que IdMovimiento tiene un valor válido
                    cmd.Parameters.AddWithValue("@fecha", fecha)
                    cmd.Parameters.AddWithValue("@tipo", tipo)
                    cmd.Parameters.AddWithValue("@categoriaId", idCategoria)
                    cmd.Parameters.AddWithValue("@monto", monto)
                    cmd.Parameters.AddWithValue("@IdMetodo", idMetodo)
                    cmd.Parameters.AddWithValue("@descripcion", descripcion)

                    ' Ejecutar la consulta
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    ' Verificar si se actualizó correctamente
                    If filasAfectadas > 0 Then
                        MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Actualizar la lista de movimientos en el formulario principal
                        RaiseEvent DatosActualizados()
                        Me.Close() ' Cerrar el formulario después de guardar
                    Else
                        MessageBox.Show("No se pudo actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class