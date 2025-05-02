Imports System.Data.SQLite


Public Class InterfazPrincipal
    Public Property UsuarioActual As String
    Private Sub InterfazPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxTipo.Items.Add("Ingreso")
        cbxTipo.Items.Add("Gasto")
        CargarMovimientos()
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
        Dim categorias As New List(Of String)

        If cbxTipo.SelectedItem.ToString = "Ingreso" Then
            categorias.AddRange(New String() {"Sueldo", "Alquileres cobrados", "Intereses / Rendimientos"})
        ElseIf cbxTipo.SelectedItem.ToString = "Gasto" Then
            categorias.AddRange(New String() {"Alquiler", "Comida", "Transporte", "Servicios", "Salud"})
        End If

        For Each categoria In categorias
            cbxCategoria.Items.Add(categoria)

            ' Verificar si la categoría ya existe en la base de datos
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Dim query As String = "SELECT COUNT(*) FROM Categorias WHERE Nombre = @nombre AND Tipo = @tipo"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", categoria)
                    cmd.Parameters.AddWithValue("@tipo", cbxTipo.SelectedItem.ToString())

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count = 0 Then
                        ' Insertar la categoría si no existe
                        Dim insertQuery As String = "INSERT INTO Categorias (Nombre, Tipo) VALUES (@nombre, @tipo)"
                        Using insertCmd As New SQLiteCommand(insertQuery, conn)
                            insertCmd.Parameters.AddWithValue("@nombre", categoria)
                            insertCmd.Parameters.AddWithValue("@tipo", cbxTipo.SelectedItem.ToString())
                            insertCmd.ExecuteNonQuery()
                        End Using
                    End If
                End Using
            End Using
        Next
    End Sub

    'Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditarPerfil.Click
    '    Dim query As String = "SELECT Nombre, Apellido, Email, DNI, Correo FROM Perfil WHERE UsuarioId = (SELECT IdUsuario FROM Usuarios WHERE Usuario = @Usuario)"
    '    Try
    '        Using conn As SQLiteConnection = Conexion.ObtenerConexion()
    '            Using cmd As New SQLiteCommand(query, conn)
    '                cmd.Parameters.AddWithValue("@Usuario", UsuarioActual)

    '                Using reader As SQLiteDataReader = cmd.ExecuteReader()
    '                    If reader.Read() Then
    '                        btnNombre.Text = reader("Nombre").ToString()
    '                        btnApellido.Text = reader("Apellido").ToString()
    '                        btnDNI.Text = reader("DNI").ToString()
    '                        btnCorreo.Text = reader("Email").ToString()
    '                    Else
    '                        MessageBox.Show("No se encontró el perfil del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    End If
    '                End Using
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show($"Error al cargar el perfil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim tipoSeleccionado As String = cbxTipo.SelectedItem.ToString()
        Dim nombreCategoria As String = cbxCategoria.SelectedItem.ToString()
        Dim monto As Decimal = Convert.ToDecimal(txtMonto.Text)
        Dim fechaMovimiento As Date = DateTimePicker.Value
        Dim descripcion As String = txtDescripcion.Text().ToString()

        Using conn As SQLiteConnection = Conexion.ObtenerConexion()
            Try
                ' Obtener el IdUsuario del usuario actual
                Dim idUsuario As Integer
                Dim buscarUsuarioQuery As String = "SELECT IdUsuario FROM Usuarios WHERE Usuario = @usuario"
                Using buscarUsuarioCmd As New SQLiteCommand(buscarUsuarioQuery, conn)
                    buscarUsuarioCmd.Parameters.AddWithValue("@usuario", UsuarioActual)
                    Dim resultadoUsuario = buscarUsuarioCmd.ExecuteScalar()

                    If resultadoUsuario Is Nothing Then
                        MessageBox.Show("No se encontró el usuario en la base de datos.")
                        Exit Sub
                    End If

                    idUsuario = Convert.ToInt32(resultadoUsuario)
                End Using

                ' Buscar IdCategoria
                Dim idCategoria As Integer
                Dim buscarCategoriaQuery As String = "SELECT IdCategoria FROM Categorias WHERE Nombre = @nombre AND Tipo = @tipo"
                Using buscarCategoriaCmd As New SQLiteCommand(buscarCategoriaQuery, conn)
                    buscarCategoriaCmd.Parameters.AddWithValue("@nombre", nombreCategoria)
                    buscarCategoriaCmd.Parameters.AddWithValue("@tipo", tipoSeleccionado)

                    Dim resultadoCategoria = buscarCategoriaCmd.ExecuteScalar()

                    If resultadoCategoria Is Nothing Then
                        MessageBox.Show("La categoría seleccionada no existe en la base de datos.")
                        Exit Sub
                    End If

                    idCategoria = Convert.ToInt32(resultadoCategoria)
                End Using

                ' Insertar movimiento
                Dim insertarQuery As String = "INSERT INTO Movimientos (Fecha, Monto, Tipo, CategoriaId, IdUsuario, Descripcion) VALUES (@fecha, @monto, @tipo, @categoriaId, @idUsuario, @descripcion)"
                Using insertarCmd As New SQLiteCommand(insertarQuery, conn)
                    insertarCmd.Parameters.AddWithValue("@fecha", fechaMovimiento)
                    insertarCmd.Parameters.AddWithValue("@monto", monto)
                    insertarCmd.Parameters.AddWithValue("@tipo", tipoSeleccionado)
                    insertarCmd.Parameters.AddWithValue("@categoriaId", idCategoria)
                    insertarCmd.Parameters.AddWithValue("@idUsuario", idUsuario)
                    insertarCmd.Parameters.AddWithValue("@descripcion", descripcion)
                    insertarCmd.ExecuteNonQuery()
                    MessageBox.Show("Movimiento guardado correctamente.")
                    CargarMovimientos()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error al guardar: " & ex.Message)
            End Try
        End Using
    End Sub

    '´Función para cargar los movimientos en el DataGridView
    Private Sub CargarMovimientos()
        ' Limpiar las filas actuales del DataGridView
        DataGridViewHistorial.Rows.Clear()

        Dim query As String = "
        SELECT M.Fecha, M.Tipo, C.Nombre AS Categoria, M.Monto, M.Descripcion
        FROM Movimientos M
        JOIN Categorias C ON M.CategoriaId = C.IdCategoria
        WHERE M.IdUsuario = (SELECT IdUsuario FROM Usuarios WHERE Usuario = @usuario)
        ORDER BY M.Fecha DESC
    "

        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", UsuarioActual)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DataGridViewHistorial.Rows.Add(
                            reader("Fecha"),
                            reader("Tipo"),
                            reader("Categoria"),
                            reader("Monto"),
                            reader("Descripcion")
                        )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar movimientos: " & ex.Message)
        End Try
    End Sub

End Class