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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblBalance = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblMonto = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cbxTipo = New Guna.UI2.WinForms.Guna2ComboBox()
        cbxCategoria = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        btn2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Guna2RadioButton3 = New Guna.UI2.WinForms.Guna2RadioButton()
        rbtnSemana = New Guna.UI2.WinForms.Guna2RadioButton()
        rbtnDia = New Guna.UI2.WinForms.Guna2RadioButton()
        Guna2RadioButton1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Guna2RadioButton2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Guna2ShadowPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Location = New Point(109, 34)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(3, 2)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = Nothing
        ' 
        ' lblBalance
        ' 
        lblBalance.BackColor = Color.Transparent
        lblBalance.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBalance.Location = New Point(122, 62)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(65, 22)
        lblBalance.TabIndex = 1
        lblBalance.Text = "Balance:"
        ' 
        ' lblMonto
        ' 
        lblMonto.BackColor = Color.Transparent
        lblMonto.Location = New Point(201, 66)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(45, 17)
        lblMonto.TabIndex = 2
        lblMonto.Text = "$Monto"
        ' 
        ' cbxTipo
        ' 
        cbxTipo.BackColor = Color.LightBlue
        cbxTipo.BorderColor = Color.LightSkyBlue
        cbxTipo.BorderRadius = 10
        cbxTipo.BorderThickness = 0
        cbxTipo.CustomizableEdges = CustomizableEdges1
        cbxTipo.DrawMode = DrawMode.OwnerDrawFixed
        cbxTipo.DropDownStyle = ComboBoxStyle.DropDownList
        cbxTipo.FillColor = Color.Azure
        cbxTipo.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbxTipo.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbxTipo.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cbxTipo.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbxTipo.ItemHeight = 30
        cbxTipo.Items.AddRange(New Object() {"Ingreso", "Gastos", "Otros"})
        cbxTipo.Location = New Point(109, 108)
        cbxTipo.Name = "cbxTipo"
        cbxTipo.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        cbxTipo.Size = New Size(153, 36)
        cbxTipo.TabIndex = 3
        ' 
        ' cbxCategoria
        ' 
        cbxCategoria.BackColor = Color.LightSkyBlue
        cbxCategoria.BorderColor = Color.LightSkyBlue
        cbxCategoria.BorderRadius = 10
        cbxCategoria.CustomizableEdges = CustomizableEdges3
        cbxCategoria.DrawMode = DrawMode.OwnerDrawFixed
        cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cbxCategoria.FillColor = Color.Azure
        cbxCategoria.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbxCategoria.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbxCategoria.Font = New Font("Segoe UI", 10F)
        cbxCategoria.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbxCategoria.ItemHeight = 30
        cbxCategoria.Items.AddRange(New Object() {"Expensas", "Alquiler ", "Comida ", "Ropa ", "Entretenimiento ", "Transportesueldo ", "Ventas de Productos ", "Regalo", "Devolucion"})
        cbxCategoria.Location = New Point(307, 108)
        cbxCategoria.Name = "cbxCategoria"
        cbxCategoria.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        cbxCategoria.Size = New Size(153, 36)
        cbxCategoria.TabIndex = 4
        ' 
        ' Guna2DateTimePicker1
        ' 
        Guna2DateTimePicker1.BorderColor = Color.LightSkyBlue
        Guna2DateTimePicker1.BorderRadius = 10
        Guna2DateTimePicker1.Checked = True
        Guna2DateTimePicker1.CustomizableEdges = CustomizableEdges5
        Guna2DateTimePicker1.FillColor = Color.PaleTurquoise
        Guna2DateTimePicker1.Font = New Font("Segoe UI", 9F)
        Guna2DateTimePicker1.Format = DateTimePickerFormat.Long
        Guna2DateTimePicker1.Location = New Point(477, 108)
        Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Guna2DateTimePicker1.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2DateTimePicker1.Size = New Size(200, 36)
        Guna2DateTimePicker1.TabIndex = 5
        Guna2DateTimePicker1.Value = New Date(2025, 4, 26, 16, 12, 18, 375)
        ' 
        ' btnAdd
        ' 
        btnAdd.BorderRadius = 15
        btnAdd.CustomizableEdges = CustomizableEdges7
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.DodgerBlue
        btnAdd.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(601, 159)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAdd.Size = New Size(76, 45)
        btnAdd.TabIndex = 6
        btnAdd.Text = "Add"
        ' 
        ' btn2
        ' 
        btn2.DisabledState.BorderColor = Color.DarkGray
        btn2.DisabledState.CustomBorderColor = Color.DarkGray
        btn2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btn2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btn2.FillColor = Color.MediumSeaGreen
        btn2.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn2.ForeColor = Color.White
        btn2.Location = New Point(613, 210)
        btn2.Name = "btn2"
        btn2.ShadowDecoration.CustomizableEdges = CustomizableEdges9
        btn2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        btn2.Size = New Size(50, 50)
        btn2.TabIndex = 7
        btn2.Text = "+"
        ' 
        ' Guna2DataGridView1
        ' 
        Guna2DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = Color.White
        Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Guna2DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Guna2DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Guna2DataGridView1.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.Location = New Point(99, 266)
        Guna2DataGridView1.Name = "Guna2DataGridView1"
        Guna2DataGridView1.RowHeadersVisible = False
        Guna2DataGridView1.Size = New Size(578, 146)
        Guna2DataGridView1.TabIndex = 8
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        Guna2DataGridView1.ThemeStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White
        Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 17
        Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White
        Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Fecha"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Tipo"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Categoria"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Monto"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Guna2RadioButton3
        ' 
        Guna2RadioButton3.AutoSize = True
        Guna2RadioButton3.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton3.CheckedState.BorderThickness = 0
        Guna2RadioButton3.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton3.CheckedState.InnerColor = Color.White
        Guna2RadioButton3.CheckedState.InnerOffset = -4
        Guna2RadioButton3.Location = New Point(133, 14)
        Guna2RadioButton3.Name = "Guna2RadioButton3"
        Guna2RadioButton3.Size = New Size(47, 19)
        Guna2RadioButton3.TabIndex = 2
        Guna2RadioButton3.Text = "Mes"
        Guna2RadioButton3.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2RadioButton3.UncheckedState.BorderThickness = 2
        Guna2RadioButton3.UncheckedState.FillColor = Color.Transparent
        Guna2RadioButton3.UncheckedState.InnerColor = Color.Transparent
        ' 
        ' rbtnSemana
        ' 
        rbtnSemana.AutoSize = True
        rbtnSemana.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        rbtnSemana.CheckedState.BorderThickness = 0
        rbtnSemana.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        rbtnSemana.CheckedState.InnerColor = Color.White
        rbtnSemana.CheckedState.InnerOffset = -4
        rbtnSemana.Location = New Point(60, 14)
        rbtnSemana.Name = "rbtnSemana"
        rbtnSemana.Size = New Size(67, 19)
        rbtnSemana.TabIndex = 1
        rbtnSemana.Text = "Semana"
        rbtnSemana.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        rbtnSemana.UncheckedState.BorderThickness = 2
        rbtnSemana.UncheckedState.FillColor = Color.Transparent
        rbtnSemana.UncheckedState.InnerColor = Color.Transparent
        ' 
        ' rbtnDia
        ' 
        rbtnDia.AutoSize = True
        rbtnDia.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        rbtnDia.CheckedState.BorderThickness = 0
        rbtnDia.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        rbtnDia.CheckedState.InnerColor = Color.White
        rbtnDia.CheckedState.InnerOffset = -4
        rbtnDia.Location = New Point(12, 14)
        rbtnDia.Name = "rbtnDia"
        rbtnDia.Size = New Size(42, 19)
        rbtnDia.TabIndex = 0
        rbtnDia.Text = "Día"
        rbtnDia.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        rbtnDia.UncheckedState.BorderThickness = 2
        rbtnDia.UncheckedState.FillColor = Color.Transparent
        rbtnDia.UncheckedState.InnerColor = Color.Transparent
        ' 
        ' Guna2RadioButton1
        ' 
        Guna2RadioButton1.AutoSize = True
        Guna2RadioButton1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton1.CheckedState.BorderThickness = 0
        Guna2RadioButton1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton1.CheckedState.InnerColor = Color.White
        Guna2RadioButton1.CheckedState.InnerOffset = -4
        Guna2RadioButton1.Location = New Point(186, 14)
        Guna2RadioButton1.Name = "Guna2RadioButton1"
        Guna2RadioButton1.Size = New Size(47, 19)
        Guna2RadioButton1.TabIndex = 3
        Guna2RadioButton1.Text = "Año"
        Guna2RadioButton1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2RadioButton1.UncheckedState.BorderThickness = 2
        Guna2RadioButton1.UncheckedState.FillColor = Color.Transparent
        Guna2RadioButton1.UncheckedState.InnerColor = Color.Transparent
        ' 
        ' Guna2RadioButton2
        ' 
        Guna2RadioButton2.AutoSize = True
        Guna2RadioButton2.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton2.CheckedState.BorderThickness = 0
        Guna2RadioButton2.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2RadioButton2.CheckedState.InnerColor = Color.White
        Guna2RadioButton2.CheckedState.InnerOffset = -4
        Guna2RadioButton2.Location = New Point(239, 14)
        Guna2RadioButton2.Name = "Guna2RadioButton2"
        Guna2RadioButton2.Size = New Size(51, 19)
        Guna2RadioButton2.TabIndex = 4
        Guna2RadioButton2.Text = "Todo"
        Guna2RadioButton2.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2RadioButton2.UncheckedState.BorderThickness = 2
        Guna2RadioButton2.UncheckedState.FillColor = Color.Transparent
        Guna2RadioButton2.UncheckedState.InnerColor = Color.Transparent
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.Controls.Add(rbtnDia)
        Guna2ShadowPanel1.Controls.Add(Guna2RadioButton2)
        Guna2ShadowPanel1.Controls.Add(Guna2RadioButton1)
        Guna2ShadowPanel1.Controls.Add(Guna2RadioButton3)
        Guna2ShadowPanel1.Controls.Add(rbtnSemana)
        Guna2ShadowPanel1.FillColor = Color.Azure
        Guna2ShadowPanel1.Location = New Point(99, 195)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.Radius = 10
        Guna2ShadowPanel1.ShadowColor = Color.LightSkyBlue
        Guna2ShadowPanel1.Size = New Size(299, 45)
        Guna2ShadowPanel1.TabIndex = 9
        ' 
        ' InterfazPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(813, 550)
        Controls.Add(Guna2ShadowPanel1)
        Controls.Add(Guna2DataGridView1)
        Controls.Add(btn2)
        Controls.Add(btnAdd)
        Controls.Add(cbxTipo)
        Controls.Add(Guna2DateTimePicker1)
        Controls.Add(cbxCategoria)
        Controls.Add(lblMonto)
        Controls.Add(lblBalance)
        Controls.Add(Guna2HtmlLabel1)
        Name = "InterfazPrincipal"
        Text = "Gastos Personales "
        CType(Guna2DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Guna2ShadowPanel1.ResumeLayout(False)
        Guna2ShadowPanel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblBalance As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblMonto As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbxTipo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbxCategoria As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2RadioButton3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtnSemana As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rbtnDia As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2RadioButton2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
End Class
