<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModificar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbxTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxCategoria = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxMetodo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxEntidad = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpFecha = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtMonto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'cbxTipo
        '
        Me.cbxTipo.BackColor = System.Drawing.Color.Transparent
        Me.cbxTipo.BorderRadius = 10
        Me.cbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxTipo.ItemHeight = 30
        Me.cbxTipo.Items.AddRange(New Object() {"Ingreso", "Gasto"})
        Me.cbxTipo.Location = New System.Drawing.Point(38, 40)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(200, 36)
        Me.cbxTipo.TabIndex = 1
        '
        'cbxCategoria
        '
        Me.cbxCategoria.BackColor = System.Drawing.Color.Transparent
        Me.cbxCategoria.BorderRadius = 10
        Me.cbxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCategoria.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxCategoria.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxCategoria.ItemHeight = 30
        Me.cbxCategoria.Location = New System.Drawing.Point(38, 106)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(200, 36)
        Me.cbxCategoria.TabIndex = 2
        '
        'cbxMetodo
        '
        Me.cbxMetodo.BackColor = System.Drawing.Color.Transparent
        Me.cbxMetodo.BorderRadius = 10
        Me.cbxMetodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxMetodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMetodo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxMetodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxMetodo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxMetodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxMetodo.ItemHeight = 30
        Me.cbxMetodo.Location = New System.Drawing.Point(38, 180)
        Me.cbxMetodo.Name = "cbxMetodo"
        Me.cbxMetodo.Size = New System.Drawing.Size(200, 36)
        Me.cbxMetodo.TabIndex = 3
        '
        'cbxEntidad
        '
        Me.cbxEntidad.BackColor = System.Drawing.Color.Transparent
        Me.cbxEntidad.BorderRadius = 10
        Me.cbxEntidad.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEntidad.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxEntidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxEntidad.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxEntidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxEntidad.ItemHeight = 30
        Me.cbxEntidad.Location = New System.Drawing.Point(38, 255)
        Me.cbxEntidad.Name = "cbxEntidad"
        Me.cbxEntidad.Size = New System.Drawing.Size(200, 36)
        Me.cbxEntidad.TabIndex = 4
        '
        'dtpFecha
        '
        Me.dtpFecha.BorderRadius = 10
        Me.dtpFecha.Checked = True
        Me.dtpFecha.FillColor = System.Drawing.Color.White
        Me.dtpFecha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFecha.Location = New System.Drawing.Point(38, 332)
        Me.dtpFecha.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(212, 36)
        Me.dtpFecha.TabIndex = 5
        Me.dtpFecha.Value = New Date(2025, 4, 30, 11, 33, 30, 865)
        '
        'txtMonto
        '
        Me.txtMonto.BorderRadius = 10
        Me.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMonto.DefaultText = ""
        Me.txtMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMonto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMonto.Location = New System.Drawing.Point(381, 40)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PlaceholderText = ""
        Me.txtMonto.SelectedText = ""
        Me.txtMonto.Size = New System.Drawing.Size(200, 36)
        Me.txtMonto.TabIndex = 6
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderRadius = 10
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.DefaultText = ""
        Me.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(381, 106)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PlaceholderText = ""
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 36)
        Me.txtDescripcion.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.BorderRadius = 10
        Me.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardar.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(381, 180)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(94, 47)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.BorderRadius = 10
        Me.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancelar.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(487, 180)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 47)
        Me.btnCancelar.TabIndex = 15
        Me.btnCancelar.Text = "Cancelar"
        '
        'frmModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(796, 475)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cbxEntidad)
        Me.Controls.Add(Me.cbxMetodo)
        Me.Controls.Add(Me.cbxCategoria)
        Me.Controls.Add(Me.cbxTipo)
        Me.Name = "frmModificar"
        Me.Text = "frmModificar"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxCategoria As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxMetodo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxEntidad As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpFecha As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtMonto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelar As Guna.UI2.WinForms.Guna2Button
End Class
