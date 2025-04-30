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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CbxTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CbxCategoria = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.DateTimePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DataGridViewHistorial = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ColumnFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtboxMonto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DataGridViewHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CbxTipo
        '
        Me.CbxTipo.BackColor = System.Drawing.Color.Transparent
        Me.CbxTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxTipo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbxTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbxTipo.ItemHeight = 30
        Me.CbxTipo.Items.AddRange(New Object() {"Ingreso", "Gasto"})
        Me.CbxTipo.Location = New System.Drawing.Point(99, 110)
        Me.CbxTipo.Name = "CbxTipo"
        Me.CbxTipo.Size = New System.Drawing.Size(200, 36)
        Me.CbxTipo.TabIndex = 0
        '
        'CbxCategoria
        '
        Me.CbxCategoria.BackColor = System.Drawing.Color.Transparent
        Me.CbxCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCategoria.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbxCategoria.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbxCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbxCategoria.ItemHeight = 30
        Me.CbxCategoria.Items.AddRange(New Object() {"Alquiler", "Luz", "Agua", "Gas", "Internet", "Teléfono", "Supermercado", "Transporte", "Salud"})
        Me.CbxCategoria.Location = New System.Drawing.Point(348, 110)
        Me.CbxCategoria.Name = "CbxCategoria"
        Me.CbxCategoria.Size = New System.Drawing.Size(200, 36)
        Me.CbxCategoria.TabIndex = 0
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Checked = True
        Me.DateTimePicker.FillColor = System.Drawing.Color.White
        Me.DateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.DateTimePicker.Location = New System.Drawing.Point(589, 110)
        Me.DateTimePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(216, 36)
        Me.DateTimePicker.TabIndex = 1
        Me.DateTimePicker.Value = New Date(2025, 4, 30, 11, 33, 30, 865)
        '
        'DataGridViewHistorial
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DataGridViewHistorial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewHistorial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewHistorial.ColumnHeadersHeight = 15
        Me.DataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridViewHistorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnFecha, Me.ColumTipo, Me.ColumnCategoria, Me.ColumnMonto})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewHistorial.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewHistorial.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridViewHistorial.Location = New System.Drawing.Point(99, 290)
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
        Me.DataGridViewHistorial.ThemeStyle.HeaderStyle.Height = 15
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(95, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Balance:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(172, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "$Monto"
        '
        'TxtboxMonto
        '
        Me.TxtboxMonto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtboxMonto.DefaultText = ""
        Me.TxtboxMonto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtboxMonto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtboxMonto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxMonto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtboxMonto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxMonto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtboxMonto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtboxMonto.Location = New System.Drawing.Point(99, 180)
        Me.TxtboxMonto.Name = "TxtboxMonto"
        Me.TxtboxMonto.PlaceholderText = ""
        Me.TxtboxMonto.SelectedText = ""
        Me.TxtboxMonto.Size = New System.Drawing.Size(200, 36)
        Me.TxtboxMonto.TabIndex = 5
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(363, 180)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(76, 45)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "Añadir"
        '
        'InterfazPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(876, 582)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.TxtboxMonto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewHistorial)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.CbxCategoria)
        Me.Controls.Add(Me.CbxTipo)
        Me.Name = "InterfazPrincipal"
        Me.Text = "InterfazPrincipal"
        CType(Me.DataGridViewHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbxTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CbxCategoria As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents DateTimePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DataGridViewHistorial As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents ColumnFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColumTipo As DataGridViewTextBoxColumn
    Friend WithEvents ColumnCategoria As DataGridViewTextBoxColumn
    Friend WithEvents ColumnMonto As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtboxMonto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
