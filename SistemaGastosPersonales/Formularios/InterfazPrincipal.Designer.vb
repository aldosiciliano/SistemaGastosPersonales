<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InterfazPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbxTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxCategoria = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DataGridViewHistorial = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ColumnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxDinero = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAñadir = New Guna.UI2.WinForms.Guna2Button()
        Me.tbxFiltro = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DataGridViewHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cbxTipo.Location = New System.Drawing.Point(99, 110)
        Me.cbxTipo.Name = "cbxTipo"
        Me.cbxTipo.Size = New System.Drawing.Size(200, 36)
        Me.cbxTipo.TabIndex = 0
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
        Me.cbxCategoria.Items.AddRange(New Object() {"Alquiler", "Luz", "Agua", "Gas", "Internet", "Teléfono", "Supermercado", "Transporte", "Salud"})
        Me.cbxCategoria.Location = New System.Drawing.Point(346, 110)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(200, 36)
        Me.cbxCategoria.TabIndex = 0
        '
        'DateTimePicker
        '
        Me.DateTimePicker.BorderRadius = 10
        Me.DateTimePicker.Checked = True
        Me.DateTimePicker.FillColor = System.Drawing.Color.White
        Me.DateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker.Location = New System.Drawing.Point(99, 188)
        Me.DateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(212, 36)
        Me.DateTimePicker.TabIndex = 1
        Me.DateTimePicker.Value = New Date(2025, 4, 30, 11, 33, 30, 865)
        '
        'DataGridViewHistorial
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridViewHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewHistorial.ColumnHeadersHeight = 30
        Me.DataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnFecha, Me.ColumTipo, Me.ColumnCategoria, Me.ColumnMonto})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewHistorial.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.Location = New System.Drawing.Point(99, 291)
        Me.DataGridViewHistorial.Name = "DataGridViewHistorial"
        Me.DataGridViewHistorial.RowHeadersVisible = False
        Me.DataGridViewHistorial.Size = New System.Drawing.Size(706, 247)
        Me.DataGridViewHistorial.TabIndex = 2
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewHistorial.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewHistorial.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridViewHistorial.ThemeStyle.ReadOnly = False
        Me.DataGridViewHistorial.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewHistorial.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridViewHistorial.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewHistorial.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridViewHistorial.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridViewHistorial.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ColumnFecha
        '
        Me.ColumnFecha.HeaderText = "Fecha"
        Me.ColumnFecha.Name = "ColumnFecha"
        '
        'ColumTipo
        '
        Me.ColumTipo.HeaderText = "Tipo"
        Me.ColumTipo.Name = "ColumTipo"
        '
        'ColumnCategoria
        '
        Me.ColumnCategoria.HeaderText = "Categoria"
        Me.ColumnCategoria.Name = "ColumnCategoria"
        '
        'ColumnMonto
        '
        Me.ColumnMonto.HeaderText = "Monto"
        Me.ColumnMonto.Name = "ColumnMonto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(390, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "$Monto"
        '
        'tbxDinero
        '
        Me.tbxDinero.BorderRadius = 10
        Me.tbxDinero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxDinero.DefaultText = ""
        Me.tbxDinero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxDinero.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxDinero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxDinero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxDinero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxDinero.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxDinero.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxDinero.Location = New System.Drawing.Point(317, 188)
        Me.tbxDinero.Name = "tbxDinero"
        Me.tbxDinero.PlaceholderText = ""
        Me.tbxDinero.SelectedText = ""
        Me.tbxDinero.Size = New System.Drawing.Size(95, 36)
        Me.tbxDinero.TabIndex = 5
        '
        'btnAñadir
        '
        Me.btnAñadir.BorderRadius = 10
        Me.btnAñadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAñadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAñadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAñadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAñadir.FillColor = System.Drawing.Color.DodgerBlue
        Me.btnAñadir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadir.ForeColor = System.Drawing.Color.White
        Me.btnAñadir.Location = New System.Drawing.Point(655, 144)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(94, 47)
        Me.btnAñadir.TabIndex = 6
        Me.btnAñadir.Text = "Añadir"
        '
        'tbxFiltro
        '
        Me.tbxFiltro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbxFiltro.DefaultText = ""
        Me.tbxFiltro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbxFiltro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbxFiltro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxFiltro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbxFiltro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxFiltro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbxFiltro.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbxFiltro.Location = New System.Drawing.Point(605, 249)
        Me.tbxFiltro.Name = "tbxFiltro"
        Me.tbxFiltro.PlaceholderText = ""
        Me.tbxFiltro.SelectedText = ""
        Me.tbxFiltro.Size = New System.Drawing.Size(200, 36)
        Me.tbxFiltro.TabIndex = 7
        '
        'InterfazPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(876, 582)
        Me.Controls.Add(Me.tbxFiltro)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.tbxDinero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewHistorial)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.cbxCategoria)
        Me.Controls.Add(Me.cbxTipo)
        Me.Name = "InterfazPrincipal"
        Me.Text = "Gastos Personales "
        CType(Me.DataGridViewHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxCategoria As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DataGridViewHistorial As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ColumnFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCategoria As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMonto As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxDinero As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAñadir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents tbxFiltro As Guna.UI2.WinForms.Guna2TextBox
End Class
