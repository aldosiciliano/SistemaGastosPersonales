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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InterfazPrincipal))
        Me.cbxTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbxCategoria = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DataGridViewHistorial = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ColumnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelMonto = New System.Windows.Forms.Label()
        Me.txtMonto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAñadir = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtDescripcion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Perfil = New System.Windows.Forms.TabPage()
        Me.PerfilUserLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnCorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnDNI = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnApellido = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnEditarPerfil = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGuardarPerfil = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.DataGridViewHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Perfil.SuspendLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.cbxTipo.Location = New System.Drawing.Point(75, 129)
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
        Me.cbxCategoria.Location = New System.Drawing.Point(322, 129)
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
        Me.DateTimePicker.Location = New System.Drawing.Point(75, 207)
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
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(127, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(159, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewHistorial.ColumnHeadersHeight = 30
        Me.DataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnFecha, Me.ColumnTipo, Me.ColumnCategoria, Me.ColumnMonto, Me.Descripcion})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewHistorial.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.Location = New System.Drawing.Point(75, 322)
        Me.DataGridViewHistorial.Name = "DataGridViewHistorial"
        Me.DataGridViewHistorial.RowHeadersVisible = False
        Me.DataGridViewHistorial.Size = New System.Drawing.Size(706, 304)
        Me.DataGridViewHistorial.TabIndex = 2
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridViewHistorial.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridViewHistorial.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridViewHistorial.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'ColumnTipo
        '
        Me.ColumnTipo.HeaderText = "Tipo"
        Me.ColumnTipo.Name = "ColumnTipo"
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
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'LabelMonto
        '
        Me.LabelMonto.AutoSize = True
        Me.LabelMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonto.Location = New System.Drawing.Point(368, 52)
        Me.LabelMonto.Name = "LabelMonto"
        Me.LabelMonto.Size = New System.Drawing.Size(29, 31)
        Me.LabelMonto.TabIndex = 4
        Me.LabelMonto.Text = "$"
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
        Me.txtMonto.Location = New System.Drawing.Point(293, 207)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PlaceholderText = ""
        Me.txtMonto.SelectedText = ""
        Me.txtMonto.Size = New System.Drawing.Size(95, 36)
        Me.txtMonto.TabIndex = 5
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.Color.White
        Me.btnAñadir.BorderRadius = 10
        Me.btnAñadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAñadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAñadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAñadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAñadir.FillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnAñadir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadir.ForeColor = System.Drawing.Color.White
        Me.btnAñadir.Location = New System.Drawing.Point(687, 196)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(94, 47)
        Me.btnAñadir.TabIndex = 6
        Me.btnAñadir.Text = "Añadir"
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderRadius = 10
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.DefaultText = ""
        Me.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(581, 280)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PlaceholderText = ""
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(200, 36)
        Me.txtBuscar.TabIndex = 7
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.Perfil)
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(-6, 2)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1056, 649)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 8
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Guna2PictureBox3)
        Me.TabPage1.Controls.Add(Me.LabelMonto)
        Me.TabPage1.Controls.Add(Me.txtBuscar)
        Me.TabPage1.Controls.Add(Me.cbxTipo)
        Me.TabPage1.Controls.Add(Me.btnAñadir)
        Me.TabPage1.Controls.Add(Me.cbxCategoria)
        Me.TabPage1.Controls.Add(Me.txtDescripcion)
        Me.TabPage1.Controls.Add(Me.txtMonto)
        Me.TabPage1.Controls.Add(Me.DateTimePicker)
        Me.TabPage1.Controls.Add(Me.DataGridViewHistorial)
        Me.TabPage1.Controls.Add(Me.Guna2PictureBox2)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(868, 641)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gastos Personales "
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
        Me.txtDescripcion.Location = New System.Drawing.Point(581, 129)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PlaceholderText = ""
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 36)
        Me.txtDescripcion.TabIndex = 5
        '
        'Perfil
        '
        Me.Perfil.Controls.Add(Me.btnEditarPerfil)
        Me.Perfil.Controls.Add(Me.btnGuardarPerfil)
        Me.Perfil.Controls.Add(Me.PerfilUserLabel)
        Me.Perfil.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Perfil.Controls.Add(Me.btnCorreo)
        Me.Perfil.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Perfil.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Perfil.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Perfil.Controls.Add(Me.btnDNI)
        Me.Perfil.Controls.Add(Me.btnApellido)
        Me.Perfil.Controls.Add(Me.btnNombre)
        Me.Perfil.Controls.Add(Me.Guna2PictureBox1)
        Me.Perfil.Location = New System.Drawing.Point(184, 4)
        Me.Perfil.Name = "Perfil"
        Me.Perfil.Padding = New System.Windows.Forms.Padding(3)
        Me.Perfil.Size = New System.Drawing.Size(868, 641)
        Me.Perfil.TabIndex = 1
        Me.Perfil.Text = "Perfil"
        Me.Perfil.UseVisualStyleBackColor = True
        '
        'PerfilUserLabel
        '
        Me.PerfilUserLabel.BackColor = System.Drawing.Color.Transparent
        Me.PerfilUserLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PerfilUserLabel.Location = New System.Drawing.Point(305, 68)
        Me.PerfilUserLabel.Name = "PerfilUserLabel"
        Me.PerfilUserLabel.Size = New System.Drawing.Size(233, 67)
        Me.PerfilUserLabel.TabIndex = 9
        Me.PerfilUserLabel.Text = "UserName"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(291, 414)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(51, 23)
        Me.Guna2HtmlLabel4.TabIndex = 7
        Me.Guna2HtmlLabel4.Text = "Correo"
        '
        'btnCorreo
        '
        Me.btnCorreo.BorderRadius = 10
        Me.btnCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnCorreo.DefaultText = ""
        Me.btnCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCorreo.Location = New System.Drawing.Point(375, 403)
        Me.btnCorreo.Name = "btnCorreo"
        Me.btnCorreo.PlaceholderText = ""
        Me.btnCorreo.SelectedText = ""
        Me.btnCorreo.Size = New System.Drawing.Size(259, 55)
        Me.btnCorreo.TabIndex = 6
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(291, 357)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(36, 23)
        Me.Guna2HtmlLabel3.TabIndex = 5
        Me.Guna2HtmlLabel3.Text = "D.N.I"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(292, 296)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(60, 23)
        Me.Guna2HtmlLabel2.TabIndex = 4
        Me.Guna2HtmlLabel2.Text = "Apellido"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(291, 237)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(61, 23)
        Me.Guna2HtmlLabel1.TabIndex = 3
        Me.Guna2HtmlLabel1.Text = "Nombre"
        '
        'btnDNI
        '
        Me.btnDNI.BorderRadius = 10
        Me.btnDNI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnDNI.DefaultText = ""
        Me.btnDNI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnDNI.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnDNI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDNI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnDNI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDNI.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnDNI.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDNI.Location = New System.Drawing.Point(375, 342)
        Me.btnDNI.Name = "btnDNI"
        Me.btnDNI.PlaceholderText = ""
        Me.btnDNI.SelectedText = ""
        Me.btnDNI.Size = New System.Drawing.Size(259, 55)
        Me.btnDNI.TabIndex = 2
        '
        'btnApellido
        '
        Me.btnApellido.BorderRadius = 10
        Me.btnApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnApellido.DefaultText = ""
        Me.btnApellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnApellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnApellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnApellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnApellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnApellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnApellido.Location = New System.Drawing.Point(375, 281)
        Me.btnApellido.Name = "btnApellido"
        Me.btnApellido.PlaceholderText = ""
        Me.btnApellido.SelectedText = ""
        Me.btnApellido.Size = New System.Drawing.Size(259, 55)
        Me.btnApellido.TabIndex = 1
        '
        'btnNombre
        '
        Me.btnNombre.BorderRadius = 10
        Me.btnNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnNombre.DefaultText = ""
        Me.btnNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.btnNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.btnNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNombre.Location = New System.Drawing.Point(375, 220)
        Me.btnNombre.Name = "btnNombre"
        Me.btnNombre.PlaceholderText = ""
        Me.btnNombre.SelectedText = ""
        Me.btnNombre.Size = New System.Drawing.Size(259, 55)
        Me.btnNombre.TabIndex = 0
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = Global.SistemaGastosPersonales.My.Resources.Resources.lupa__1_
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(541, 280)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(34, 36)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Guna2PictureBox3.TabIndex = 9
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = Global.SistemaGastosPersonales.My.Resources.Resources.Billetera1
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(0, -4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(200, 149)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 8
        Me.Guna2PictureBox2.TabStop = False
        '
        'btnEditarPerfil
        '
        Me.btnEditarPerfil.BorderRadius = 10
        Me.btnEditarPerfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarPerfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarPerfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarPerfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPerfil.ForeColor = System.Drawing.Color.White
        Me.btnEditarPerfil.Image = Global.SistemaGastosPersonales.My.Resources.Resources.lapiz__1_
        Me.btnEditarPerfil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEditarPerfil.Location = New System.Drawing.Point(548, 496)
        Me.btnEditarPerfil.Name = "btnEditarPerfil"
        Me.btnEditarPerfil.Size = New System.Drawing.Size(132, 45)
        Me.btnEditarPerfil.TabIndex = 11
        Me.btnEditarPerfil.Text = "Editar"
        '
        'btnGuardarPerfil
        '
        Me.btnGuardarPerfil.BorderRadius = 10
        Me.btnGuardarPerfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardarPerfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardarPerfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardarPerfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardarPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarPerfil.ForeColor = System.Drawing.Color.White
        Me.btnGuardarPerfil.Image = Global.SistemaGastosPersonales.My.Resources.Resources.ahorrar
        Me.btnGuardarPerfil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGuardarPerfil.Location = New System.Drawing.Point(339, 496)
        Me.btnGuardarPerfil.Name = "btnGuardarPerfil"
        Me.btnGuardarPerfil.Size = New System.Drawing.Size(132, 45)
        Me.btnGuardarPerfil.TabIndex = 10
        Me.btnGuardarPerfil.Text = "Guardar"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.SistemaGastosPersonales.My.Resources.Resources.usuario__1_
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(284, 206)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 8
        Me.Guna2PictureBox1.TabStop = False
        '
        'InterfazPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1046, 644)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InterfazPrincipal"
        Me.Text = "Gastos Personales "
        CType(Me.DataGridViewHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Perfil.ResumeLayout(False)
        Me.Perfil.PerformLayout()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxCategoria As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DataGridViewHistorial As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents LabelMonto As Label
    Friend WithEvents txtMonto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAñadir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Perfil As TabPage
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnDNI As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnApellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnEditarPerfil As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardarPerfil As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PerfilUserLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtDescripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ColumnFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCategoria As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMonto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
End Class
