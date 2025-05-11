Imports System.Data.SQLite


Public Class InterfazPrincipal
    Public Property UsuarioActual As String

    Private Sub InterfazPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtDescripcion.ForeColor = Color.Gray
        txtDescripcion.Text = "Descripcion"

        txtMonto.ForeColor = Color.Gray
        txtMonto.Text = "Ingrese monto"

        txtBuscar.Text = "Filtro"
        txtBuscar.ForeColor = Color.Gray

        cbxMetodo.ForeColor = Color.Gray
        cbxMetodo.Text = "Metodo de pago"


        cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList

        cbxTipo.Items.Add("Seleccione movimiento")
        cbxTipo.Items.Add("Gasto")
        cbxTipo.Items.Add("Ingreso")


        cbxTipo.SelectedIndex = 0
        cbxTipo.ForeColor = Color.Gray

        ' Cambiar color al seleccionar una opción real
        AddHandler cbxTipo.SelectedIndexChanged, Sub()
                                                     If cbxTipo.SelectedIndex = 0 Then
                                                         cbxTipo.ForeColor = Color.Gray
                                                     Else
                                                         cbxTipo.ForeColor = Color.Black
                                                     End If
                                                 End Sub
        CargarMovimientos()
        CalcularMontoDisponible()
        CalcularMonto()
        ConfigurarComboBoxMetodo()
        CargarMetodos()
        CargarComboBoxEntidad()
        ConfigurarComboBoxEntidad()

        'Cargar el nombre de la persona de la bd
        Dim nombrePersona As String = ""
        Dim query As String = "SELECT Nombre FROM Perfil WHERE UsuarioId = (SELECT IdUsuario FROM Usuarios WHERE Usuario = @Usuario)"
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

        ' Cargar el perfil del usuario
        Dim query1 As String = "SELECT Nombre, Apellido, DNI, Email FROM Perfil WHERE UsuarioId = (SELECT IdUsuario FROM Usuarios WHERE Usuario = @Usuario)"
        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Using cmd As New SQLiteCommand(query1, conn)
                    cmd.Parameters.AddWithValue("@Usuario", UsuarioActual)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtNombrePerfil.Text = reader("Nombre").ToString()
                            txtApellidoPerfil.Text = reader("Apellido").ToString()
                            txtDNIPerfil.Text = reader("DNI").ToString()
                            txtCorreoPerfil.Text = reader("Email").ToString()
                        Else
                            MessageBox.Show("no se encontró el perfil del usuario.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"error al cargar el perfil: {ex.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtNombrePerfil.SelectionStart = txtNombrePerfil.Text.Length
        txtApellidoPerfil.SelectionStart = txtApellidoPerfil.Text.Length
        txtDNIPerfil.SelectionStart = txtDNIPerfil.Text.Length
        txtCorreoPerfil.SelectionStart = txtCorreoPerfil.Text.Length
    End Sub

    'Cargar Metodos a bd
    Private Sub CargarMetodos()
        Dim metodos As New List(Of String) From {"Seleccione un metodo", "Efectivo", "Tarjeta de credito", "Tarjeta de debito", "Transferencia"}
        cbxMetodo.Items.Clear()
        cbxMetodo.Items.AddRange(metodos.ToArray())
        cbxMetodo.SelectedIndex = 0
        cbxMetodo.ForeColor = Color.Gray
        ' Cambiar color al seleccionar una opción real
        AddHandler cbxMetodo.SelectedIndexChanged, Sub()
                                                       If cbxMetodo.SelectedIndex = 0 Then
                                                           cbxMetodo.ForeColor = Color.Gray
                                                       Else
                                                           cbxMetodo.ForeColor = Color.Black
                                                       End If
                                                   End Sub
        Dim query As String = "SELECT Entidad FROM Metodo WHERE IdUsuario = (SELECT IdUsuario From Usuarios WHERE Usuario = @Usuario)"
        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", UsuarioActual)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim entidad As String = reader("Entidad").ToString()
                            If Not cbxEntidad.Items.Contains(entidad) Then
                                cbxEntidad.Items.Add(entidad)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al cargar entidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConfigurarComboBoxMetodo()
        AddHandler cbxMetodo.SelectedIndexChanged, Sub()
                                                       If cbxMetodo.SelectedItem IsNot Nothing AndAlso cbxMetodo.SelectedItem.ToString() = "Efectivo" Then
                                                           ' Limpiar y deshabilitar la entidad bancaria
                                                           cbxEntidad.SelectedIndex = 0
                                                           cbxEntidad.Enabled = False
                                                       Else
                                                           ' Habilitar la entidad bancaria si no es "Efectivo"
                                                           cbxEntidad.Enabled = True
                                                       End If
                                                   End Sub

        AddHandler cbxMetodo.GotFocus, Sub()
                                           If cbxMetodo.Text = "Seleccione un método" Then
                                               cbxMetodo.Text = ""
                                               cbxMetodo.ForeColor = Color.Black
                                           End If
                                       End Sub

        AddHandler cbxMetodo.LostFocus, Sub()
                                            If String.IsNullOrWhiteSpace(cbxMetodo.Text) Then
                                                cbxMetodo.Text = "Seleccione un método"
                                                cbxMetodo.ForeColor = Color.Gray
                                            End If
                                        End Sub
    End Sub

    Private Sub CargarComboBoxEntidad()
        cbxEntidad.Items.Clear()
        Dim entidades As New List(Of String) From {"Seleccione una entidad", "Banco BBVA", "Banco Santander", "Banco Nación", "Otros"}
        cbxEntidad.Items.AddRange(entidades.ToArray())
        cbxEntidad.SelectedIndex = 0
        cbxEntidad.ForeColor = Color.Gray

        AddHandler cbxEntidad.SelectedIndexChanged, Sub()
                                                        If cbxEntidad.SelectedIndex = 0 Then
                                                            cbxEntidad.ForeColor = Color.Gray
                                                        Else
                                                            cbxEntidad.ForeColor = Color.Black
                                                        End If
                                                    End Sub

        Dim query As String = "SELECT Entidad FROM Metodo WHERE IdUsuario = (SELECT IdUsuario From Usuarios WHERE Usuario = @Usuario)"
        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", UsuarioActual)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim entidad As String = reader("Entidad").ToString()
                            If Not cbxEntidad.Items.Contains(entidad) Then
                                cbxEntidad.Items.Add(entidad)
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al cargar entidades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ConfigurarComboBoxEntidad()
        AddHandler cbxEntidad.GotFocus, Sub()
                                            If cbxEntidad.Text = "Seleccione una entidad" Then
                                                cbxEntidad.Text = ""
                                                cbxEntidad.ForeColor = Color.Black
                                            End If
                                        End Sub
        AddHandler cbxEntidad.LostFocus, Sub()
                                             If String.IsNullOrWhiteSpace(cbxEntidad.Text) Then
                                                 cbxEntidad.Text = "Seleccione una entidad"
                                                 cbxEntidad.ForeColor = Color.Gray
                                             End If
                                         End Sub
    End Sub

    Private Sub cbxTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipo.SelectedIndexChanged
        cbxCategoria.Items.Clear()
        Dim categorias As New List(Of String)

        If cbxTipo.SelectedItem.ToString = "Ingreso" Then
            categorias.AddRange(New String() {"Sueldo", "Alquileres cobrados", "Intereses / Rendimientos"})
        ElseIf cbxTipo.SelectedItem.ToString = "Gasto" Then
            categorias.AddRange(New String() {"Alquiler", "Comida", "Transporte", "Servicios", "Salud"})
        End If

        cbxCategoria.Items.Add("Seleccione una categoría")

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

        cbxCategoria.SelectedIndex = 0
        cbxCategoria.ForeColor = Color.Gray

        AddHandler cbxCategoria.SelectedIndexChanged, Sub()
                                                          If cbxCategoria.SelectedIndex = 0 Then
                                                              cbxCategoria.ForeColor = Color.Gray
                                                          Else
                                                              cbxCategoria.ForeColor = Color.Black
                                                          End If
                                                      End Sub
    End Sub



    Private Sub btnEditar_click(sender As Object, e As EventArgs) Handles btnEditarPerfil.Click
        txtNombrePerfil.Enabled = True
        txtApellidoPerfil.Enabled = True
        txtDNIPerfil.Enabled = True
        txtCorreoPerfil.Enabled = True
        btnGuardarPerfil.Enabled = True
        btnCancelar.Enabled = True
        btnEditarPerfil.Enabled = False
    End Sub

    Private Sub btnGuardarPerfil_Click(sender As Object, e As EventArgs) Handles btnGuardarPerfil.Click
        Dim query As String = "UPDATE perfil 
                               SET nombre = @nombre, 
                               apellido = @apellido, 
                               dni = @dni, 
                               email = @correo 
                               WHERE usuarioid = (SELECT idusuario FROM usuarios WHERE usuario = @usuario)"

        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombrePerfil.Text)
                    cmd.Parameters.AddWithValue("@apellido", txtApellidoPerfil.Text)
                    cmd.Parameters.AddWithValue("@dni", txtDNIPerfil.Text)
                    cmd.Parameters.AddWithValue("@correo", txtCorreoPerfil.Text)
                    cmd.Parameters.AddWithValue("@usuario", UsuarioActual)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Perfil actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se encontró el perfil del usuario para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    PerfilUserLabel.Text = $"Bienvenido, {txtNombrePerfil.Text}"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error al actualizar el perfil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        ' Deshabilitar los campos de texto y botones después de guardar
        btnEditarPerfil.Enabled = True
        btnGuardarPerfil.Enabled = False
        btnCancelar.Enabled = False
        txtNombrePerfil.Enabled = False
        txtApellidoPerfil.Enabled = False
        txtDNIPerfil.Enabled = False
        txtCorreoPerfil.Enabled = False

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        If Not ValidarCampos() Then Return

        Dim tipoSeleccionado As String = cbxTipo.SelectedItem.ToString()
        Dim nombreCategoria As String = cbxCategoria.SelectedItem.ToString()
        Dim monto As Decimal = Convert.ToDecimal(txtMonto.Text)
        Dim fechaMovimiento As Date = DateTimePicker.Value
        Dim descripcion As String = If(txtDescripcion.Text = "Descripcion", "", txtDescripcion.Text) ' Descripción opcional
        Dim entidad As String = If(cbxMetodo.SelectedItem.ToString() = "Efectivo", "-", cbxEntidad.Text)

        Using conn As SQLiteConnection = Conexion.ObtenerConexion()
            Try
                Dim idUsuario As Integer = ObtenerIdUsuario(conn)
                If idUsuario = -1 Then Exit Sub

                Dim idCategoria As Integer = ObtenerIdCategoria(conn, nombreCategoria, tipoSeleccionado)
                Dim idMetodo As Integer = ObtenerIdMetodo(conn, idUsuario)

                ' Si el método es "Efectivo", no se guarda entidad bancaria
                InsertarMovimiento(conn, fechaMovimiento, monto, tipoSeleccionado, idCategoria, idUsuario, idMetodo, descripcion)
                MessageBox.Show("Movimiento guardado correctamente.")
                CargarMovimientos()
                CalcularMontoDisponible()
                CalcularMonto()
            Catch ex As Exception
                MessageBox.Show("Error al guardar: " & ex.Message)
            End Try
        End Using
    End Sub

    'Eliminar un movimiento
    'Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
    '    If DataGridViewHistorial.SelectedRows.Count = 0 Then
    '        MessageBox.Show("Seleccione un movimiento para eliminar.")
    '        Return
    '        End
    '        Dim filaSeleccionada As DataGridViewRow = DataGridViewHistorial.SelectedRows(0)
    '        Dim idMovimiento As Integer = Convert.ToInt32(filaSeleccionada.Cells("IdMovimiento").Value)
    '        Dim confirmacion As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este movimiento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    '        If confirmacion = DialogResult.No Then Return

    '        Dim query As String = "DELETE FROM Movimientos WHERE IdMovimiento = @idMovimiento"
    '        Try
    '            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
    '                Using cmd As New SQLiteCommand(query, conn)
    '                    cmd.Parameters.AddWithValue("@IdMovimiento", idMovimiento)
    '                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

    '                    If filasAfectadas > 0 Then
    '                        MessageBox.Show("Movimiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        CargarMovimientos() ' Actualizar el DataGridView
    '                    Else
    '                        MessageBox.Show("No se pudo eliminar el movimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '                    End If
    '                End Using
    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show($"Error al eliminar el movimiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    End If
    'End Sub

    ' Método para validar los campos de entrada
    Private Function ValidarCampos() As Boolean
        If txtMonto.Text = "Ingrese monto" Then
            MessageBox.Show("Ingrese un monto.", "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' Método para obtener el IdUsuario
    Private Function ObtenerIdUsuario(conn As SQLiteConnection) As Integer
        Dim query As String = "SELECT IdUsuario FROM Usuarios WHERE Usuario = @usuario"
        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@usuario", UsuarioActual)
            Dim resultado = cmd.ExecuteScalar()
            If resultado Is Nothing Then
                MessageBox.Show("No se encontró el usuario en la base de datos.")
                Return -1
            End If
            Return Convert.ToInt32(resultado)
        End Using
    End Function

    ' Método para obtener o insertar una categoría
    Private Function ObtenerIdCategoria(conn As SQLiteConnection, nombreCategoria As String, tipoSeleccionado As String) As Integer
        Dim query As String = "SELECT IdCategoria FROM Categorias WHERE Nombre = @nombre AND Tipo = @tipo"
        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@nombre", nombreCategoria)
            cmd.Parameters.AddWithValue("@tipo", tipoSeleccionado)
            Dim resultado = cmd.ExecuteScalar()

            If resultado Is Nothing Then
                Dim insertarQuery As String = "INSERT INTO Categorias (Nombre, Tipo) VALUES (@nombre, @tipo)"
                Using insertarCmd As New SQLiteCommand(insertarQuery, conn)
                    insertarCmd.Parameters.AddWithValue("@nombre", nombreCategoria)
                    insertarCmd.Parameters.AddWithValue("@tipo", tipoSeleccionado)
                    insertarCmd.ExecuteNonQuery()
                End Using
                Return Convert.ToInt32(conn.LastInsertRowId)
            End If

            Return Convert.ToInt32(resultado)
        End Using
    End Function

    ' Método para obtener o insertar un método
    Private Function ObtenerIdMetodo(conn As SQLiteConnection, idUsuario As Integer) As Integer
        Dim query As String = "SELECT IdMetodo FROM Metodo WHERE Origen = @Origen AND Entidad = @Entidad AND IdUsuario = @IdUsuario"
        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@Origen", cbxMetodo.Text)
            cmd.Parameters.AddWithValue("@Entidad", cbxEntidad.Text)
            cmd.Parameters.AddWithValue("@IdUsuario", idUsuario)
            Dim resultado = cmd.ExecuteScalar()

            If resultado Is Nothing Then
                Dim insertarQuery As String = "INSERT INTO Metodo (Origen, Entidad, IdUsuario) VALUES (@Origen, @Entidad, @IdUsuario)"
                Using insertarCmd As New SQLiteCommand(insertarQuery, conn)
                    insertarCmd.Parameters.AddWithValue("@Origen", cbxMetodo.Text)
                    insertarCmd.Parameters.AddWithValue("@Entidad", cbxEntidad.Text)
                    insertarCmd.Parameters.AddWithValue("@IdUsuario", idUsuario)
                    insertarCmd.ExecuteNonQuery()
                End Using
                Return Convert.ToInt32(conn.LastInsertRowId)
            End If

            Return Convert.ToInt32(resultado)
        End Using
    End Function

    ' Método para insertar un movimiento
    Private Sub InsertarMovimiento(conn As SQLiteConnection, fecha As Date, monto As Decimal, tipo As String, idCategoria As Integer, idUsuario As Integer, idMetodo As Integer, descripcion As String)
        Dim query As String = "INSERT INTO Movimientos (Fecha, Monto, Tipo, CategoriaId, IdUsuario, IdMetodo, Descripcion) VALUES (@fecha, @monto, @tipo, @categoriaId, @idUsuario, @idMetodo, @descripcion)"
        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@monto", monto)
            cmd.Parameters.AddWithValue("@tipo", tipo)
            cmd.Parameters.AddWithValue("@categoriaId", idCategoria)
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario)
            cmd.Parameters.AddWithValue("@idMetodo", idMetodo)
            cmd.Parameters.AddWithValue("@descripcion", If(String.IsNullOrWhiteSpace(descripcion), "", descripcion)) ' Descripción opcional
            cmd.ExecuteNonQuery()
        End Using
    End Sub



    'Función para cargar los movimientos en el DataGridView
    Private Sub CargarMovimientos()
        ' Limpiar las filas actuales del DataGridView
        DataGridViewHistorial.Rows.Clear()

        Dim query As String = "
        SELECT M.IdMovimiento, M.Fecha, M.Tipo, C.Nombre AS Categoria, M.Monto, 
               COALESCE(Me.Origen, 'Sin método') AS Metodo, 
               COALESCE(Me.Entidad, '') AS Entidad, 
               M.Descripcion
        FROM Movimientos M
        JOIN Categorias C ON M.CategoriaId = C.IdCategoria
        LEFT JOIN Metodo Me ON M.IdMetodo = Me.IdMetodo
        WHERE M.IdUsuario = (SELECT IdUsuario FROM Usuarios WHERE Usuario = @usuario)
        ORDER BY M.Fecha DESC"
        Try
            Using conn As SQLiteConnection = Conexion.ObtenerConexion()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", UsuarioActual)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Asegúrate de que los datos se asignan a las columnas correctas
                            Dim entidad As String = reader("Entidad").ToString()
                            If entidad = "Seleccione una entidad" Then
                                entidad = "" ' Reemplazar con cadena vacía
                            End If

                            DataGridViewHistorial.Rows.Add(
                            reader("IdMovimiento"), ' IdMovimiento")
                            Convert.ToDateTime(reader("Fecha")).ToString("dd/MM/yyyy"), ' Fecha
                            reader("Tipo"), ' Tipo
                            reader("Categoria"), ' Categoría
                            reader("Monto"), ' Monto
                            reader("Metodo"), ' Método
                            entidad, ' Entidad
                            reader("Descripcion") ' Descripción
                        )
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar movimientos: " & ex.Message)
        End Try
        CalcularMontoDisponible()
    End Sub

    Private Sub txtBuscar_Enter(sender As Object, e As EventArgs) Handles txtBuscar.Enter
        If txtBuscar.Text = "Filtro" Then
            txtBuscar.Text = ""
            txtBuscar.ForeColor = Color.Black
        End If
    End Sub


    ' Funcion para filtar o buscar en el DataGridView
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Dim filtro As String = txtBuscar.Text.Trim().ToLower()

        If filtro = "filtro" Then Exit Sub ' Evitar filtrar si está el texto guía

        For Each fila As DataGridViewRow In DataGridViewHistorial.Rows
            If fila.IsNewRow Then Continue For

            Dim visible As Boolean = False

            For Each celda As DataGridViewCell In fila.Cells
                If celda.Value IsNot Nothing Then
                    ' Convertimos todo a string en minúsculas para comparar
                    Dim valorCelda As String = celda.Value.ToString().ToLower()

                    ' Si coincide el texto (ya sea fecha, descripción, etc.)
                    If valorCelda.Contains(filtro) Then
                        visible = True
                        Exit For
                    End If
                End If
            Next

            fila.Visible = visible
        Next
    End Sub

    Private Sub txtBuscar_Leave(sender As Object, e As EventArgs) Handles txtBuscar.Leave
        If txtBuscar.Text = "" Then
            txtBuscar.Text = "Filtro"
            txtBuscar.ForeColor = Color.Gray
        End If
    End Sub


    ' Funcion que calcula el monto disponible
    Private Sub CalcularMontoDisponible()
        Dim montoDisponible As Decimal = 0

        For Each fila As DataGridViewRow In DataGridViewHistorial.Rows
            If Not fila.IsNewRow Then
                Try
                    Dim tipo As String = fila.Cells("ColumnTipo").Value.ToString()
                    Dim monto As Decimal = Convert.ToDecimal(fila.Cells("ColumnMonto").Value)

                    If tipo = "Ingreso" Then
                        montoDisponible += monto
                    ElseIf tipo = "Gasto" Then
                        montoDisponible -= monto
                    End If
                Catch ex As Exception
                End Try
            End If
        Next
        LabelMonto.Text = "$" & montoDisponible.ToString("N2")
    End Sub
    ' Función que calcula el monto de gastos e ingresos
    Private Sub CalcularMonto()
        Dim montoGastos As Decimal = 0
        Dim montoIngresos As Decimal = 0

        For Each fila As DataGridViewRow In DataGridViewHistorial.Rows
            If Not fila.IsNewRow Then
                Try
                    Dim tipo As String = fila.Cells("ColumnTipo").Value.ToString()
                    Dim monto As Decimal = Convert.ToDecimal(fila.Cells("ColumnMonto").Value)

                    If tipo = "Ingreso" Then
                        montoIngresos += monto
                    ElseIf tipo = "Gasto" Then
                        montoGastos += monto ' Cambiado para sumar gastos como positivo
                    End If
                Catch ex As Exception
                    ' Ignorar errores en celdas vacías o mal formateadas
                End Try
            End If
        Next
        LabelGastos.Text = "$" & montoGastos.ToString("N2")
        LabelIngresos.Text = "$" & montoIngresos.ToString("N2")
    End Sub



    Private Sub txtMonto_Enter(sender As Object, e As EventArgs) Handles txtMonto.Enter
        If txtMonto.Text = "Ingrese monto" Then
            txtMonto.Text = ""
            txtMonto.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtMonto_Leave(sender As Object, e As EventArgs) Handles txtMonto.Leave
        If String.IsNullOrWhiteSpace(txtMonto.Text) Then
            txtMonto.Text = "Ingrese monto"
            txtMonto.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtDescripcion_Enter(sender As Object, e As EventArgs) Handles txtDescripcion.Enter
        If txtDescripcion.Text = "Descripcion" Then
            txtDescripcion.Text = ""
            txtDescripcion.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDescripcion_Leave(sender As Object, e As EventArgs) Handles txtDescripcion.Leave
        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Then
            txtDescripcion.Text = "Descripcion"
            txtDescripcion.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        btnEditarPerfil.Enabled = True
        btnGuardarPerfil.Enabled = False
        btnCancelar.Enabled = False
        txtNombrePerfil.Enabled = False
        txtApellidoPerfil.Enabled = False
        txtDNIPerfil.Enabled = False
        txtCorreoPerfil.Enabled = False
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Verificar si hay una fila seleccionada
        If DataGridViewHistorial.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un movimiento para modificar.")
            Return
        End If

        ' Obtener los datos de la fila seleccionada
        Dim filaSeleccionada As DataGridViewRow = DataGridViewHistorial.SelectedRows(0)
        Dim idMovimiento As Integer = Convert.ToInt32(filaSeleccionada.Cells("ColumnId").Value)
        Dim fecha As String = filaSeleccionada.Cells("ColumnFecha").Value.ToString()
        Dim tipo As String = filaSeleccionada.Cells("ColumnTipo").Value.ToString()
        Dim categoria As String = filaSeleccionada.Cells("ColumnCategoria").Value.ToString()
        Dim monto As Decimal = Convert.ToDecimal(filaSeleccionada.Cells("ColumnMonto").Value)
        Dim metodo As String = filaSeleccionada.Cells("ColumnMetodo").Value.ToString()
        Dim descripcion As String = filaSeleccionada.Cells("ColumnDescripcion").Value.ToString()

        ' Instanciar el formulario frmModificar
        Dim frm As New frmModificar(idMovimiento, fecha, tipo, categoria, monto, metodo, descripcion)

        ' Suscribirse al evento DatosActualizados
        AddHandler frm.DatosActualizados, AddressOf ActualizarDataGridView

        ' Mostrar el formulario
        frm.ShowDialog()


    End Sub

    ' Método para actualizar el DataGridView
    Private Sub ActualizarDataGridView()
        CargarMovimientos() ' Llama al método que recarga los datos en el DataGridView
    End Sub
End Class