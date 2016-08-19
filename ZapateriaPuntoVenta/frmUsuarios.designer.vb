<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.Marco = New DevComponents.DotNetBar.PanelEx()
        Me.txtNombreC = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cboTipos = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.ComboItem1 = New DevComponents.Editors.ComboItem()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.dgrPermisos = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cmdCambiar = New DevComponents.DotNetBar.ButtonX()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.DataGridViewCheckBoxXColumn1 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.DataGridViewCheckBoxXColumn2 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.DataGridViewCheckBoxXColumn3 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.DataGridViewCheckBoxXColumn4 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.DataGridViewCheckBoxXColumn5 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.DataGridViewCheckBoxXColumn6 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.DataGridViewCheckBoxXColumn7 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.DataGridViewCheckBoxXColumn8 = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.Módulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clConsulta = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.clAgregar = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.clEditar = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.clEliminar = New DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn()
        Me.Marco.SuspendLayout()
        CType(Me.dgrPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Marco
        '
        Me.Marco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Marco.CanvasColor = System.Drawing.SystemColors.Control
        Me.Marco.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Marco.Controls.Add(Me.txtNombreC)
        Me.Marco.Controls.Add(Me.LabelX4)
        Me.Marco.Controls.Add(Me.cboTipos)
        Me.Marco.Controls.Add(Me.LabelX3)
        Me.Marco.Controls.Add(Me.dgrPermisos)
        Me.Marco.Controls.Add(Me.cmdCambiar)
        Me.Marco.Controls.Add(Me.txtNombre)
        Me.Marco.Controls.Add(Me.LabelX2)
        Me.Marco.Controls.Add(Me.txtCodigo)
        Me.Marco.Controls.Add(Me.LabelX1)
        Me.Marco.Enabled = False
        Me.Marco.Location = New System.Drawing.Point(0, 1)
        Me.Marco.Name = "Marco"
        Me.Marco.Size = New System.Drawing.Size(493, 416)
        Me.Marco.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Marco.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Marco.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Marco.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Marco.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Marco.Style.GradientAngle = 90
        Me.Marco.TabIndex = 0
        '
        'txtNombreC
        '
        Me.txtNombreC.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombreC.Border.Class = "TextBoxBorder"
        Me.txtNombreC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombreC.ForeColor = System.Drawing.Color.Black
        Me.txtNombreC.Location = New System.Drawing.Point(72, 67)
        Me.txtNombreC.Name = "txtNombreC"
        Me.txtNombreC.Size = New System.Drawing.Size(411, 25)
        Me.txtNombreC.TabIndex = 9
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(9, 67)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(63, 20)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Completo:"
        '
        'cboTipos
        '
        Me.cboTipos.DisplayMember = "Text"
        Me.cboTipos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipos.ForeColor = System.Drawing.Color.Black
        Me.cboTipos.FormattingEnabled = True
        Me.cboTipos.ItemHeight = 19
        Me.cboTipos.Items.AddRange(New Object() {Me.ComboItem1})
        Me.cboTipos.Location = New System.Drawing.Point(72, 98)
        Me.cboTipos.Name = "cboTipos"
        Me.cboTipos.Size = New System.Drawing.Size(411, 25)
        Me.cboTipos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cboTipos.TabIndex = 7
        '
        'ComboItem1
        '
        Me.ComboItem1.Text = "Nuevo..."
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(9, 98)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(31, 20)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Tipo:"
        '
        'dgrPermisos
        '
        Me.dgrPermisos.AllowUserToAddRows = False
        Me.dgrPermisos.AllowUserToDeleteRows = False
        Me.dgrPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrPermisos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Módulo, Me.clConsulta, Me.clAgregar, Me.clEditar, Me.clEliminar})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrPermisos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgrPermisos.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgrPermisos.Location = New System.Drawing.Point(12, 168)
        Me.dgrPermisos.MultiSelect = False
        Me.dgrPermisos.Name = "dgrPermisos"
        Me.dgrPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgrPermisos.RowTemplate.Height = 30
        Me.dgrPermisos.Size = New System.Drawing.Size(471, 237)
        Me.dgrPermisos.TabIndex = 5
        '
        'cmdCambiar
        '
        Me.cmdCambiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdCambiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdCambiar.Location = New System.Drawing.Point(12, 129)
        Me.cmdCambiar.Name = "cmdCambiar"
        Me.cmdCambiar.Size = New System.Drawing.Size(471, 33)
        Me.cmdCambiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdCambiar.TabIndex = 4
        Me.cmdCambiar.Text = "Cambiar/Agregar contraseña"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombre.Border.Class = "TextBoxBorder"
        Me.txtNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(72, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(411, 25)
        Me.txtNombre.TabIndex = 3
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(9, 36)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(54, 20)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "Nombre:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCodigo.Border.Class = "TextBoxBorder"
        Me.txtCodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(72, 3)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(411, 25)
        Me.txtCodigo.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(9, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(48, 20)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Código:"
        '
        'DataGridViewCheckBoxXColumn1
        '
        Me.DataGridViewCheckBoxXColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewCheckBoxXColumn1.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Top
        Me.DataGridViewCheckBoxXColumn1.Checked = True
        Me.DataGridViewCheckBoxXColumn1.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxXColumn1.CheckValue = "N"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewCheckBoxXColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewCheckBoxXColumn1.FillWeight = 96.15385!
        Me.DataGridViewCheckBoxXColumn1.HeaderText = "Consulta"
        Me.DataGridViewCheckBoxXColumn1.Name = "DataGridViewCheckBoxXColumn1"
        '
        'DataGridViewCheckBoxXColumn2
        '
        Me.DataGridViewCheckBoxXColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewCheckBoxXColumn2.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Top
        Me.DataGridViewCheckBoxXColumn2.Checked = True
        Me.DataGridViewCheckBoxXColumn2.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxXColumn2.CheckValue = "N"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewCheckBoxXColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewCheckBoxXColumn2.FillWeight = 105.4029!
        Me.DataGridViewCheckBoxXColumn2.HeaderText = "Agregar"
        Me.DataGridViewCheckBoxXColumn2.Name = "DataGridViewCheckBoxXColumn2"
        '
        'DataGridViewCheckBoxXColumn3
        '
        Me.DataGridViewCheckBoxXColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewCheckBoxXColumn3.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Top
        Me.DataGridViewCheckBoxXColumn3.Checked = True
        Me.DataGridViewCheckBoxXColumn3.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxXColumn3.CheckValue = "N"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewCheckBoxXColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewCheckBoxXColumn3.FillWeight = 98.37717!
        Me.DataGridViewCheckBoxXColumn3.HeaderText = "Editar"
        Me.DataGridViewCheckBoxXColumn3.Name = "DataGridViewCheckBoxXColumn3"
        '
        'DataGridViewCheckBoxXColumn4
        '
        Me.DataGridViewCheckBoxXColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewCheckBoxXColumn4.CheckBoxPosition = DevComponents.DotNetBar.eCheckBoxPosition.Top
        Me.DataGridViewCheckBoxXColumn4.Checked = True
        Me.DataGridViewCheckBoxXColumn4.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxXColumn4.CheckValue = "N"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewCheckBoxXColumn4.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewCheckBoxXColumn4.FillWeight = 100.066!
        Me.DataGridViewCheckBoxXColumn4.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxXColumn4.Name = "DataGridViewCheckBoxXColumn4"
        '
        'DataGridViewCheckBoxXColumn5
        '
        Me.DataGridViewCheckBoxXColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewCheckBoxXColumn5.CheckBoxImageChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_outline_blank_black_24dp
        Me.DataGridViewCheckBoxXColumn5.CheckBoxImageUnChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_black_24dp
        Me.DataGridViewCheckBoxXColumn5.Checked = True
        Me.DataGridViewCheckBoxXColumn5.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxXColumn5.CheckValue = "N"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewCheckBoxXColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewCheckBoxXColumn5.FillWeight = 96.15385!
        Me.DataGridViewCheckBoxXColumn5.HeaderText = "Consulta"
        Me.DataGridViewCheckBoxXColumn5.Name = "DataGridViewCheckBoxXColumn5"
        Me.DataGridViewCheckBoxXColumn5.Width = 54
        '
        'DataGridViewCheckBoxXColumn6
        '
        Me.DataGridViewCheckBoxXColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewCheckBoxXColumn6.CheckBoxImageChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_outline_blank_black_24dp
        Me.DataGridViewCheckBoxXColumn6.CheckBoxImageUnChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_black_24dp
        Me.DataGridViewCheckBoxXColumn6.Checked = True
        Me.DataGridViewCheckBoxXColumn6.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxXColumn6.CheckValue = "N"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewCheckBoxXColumn6.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewCheckBoxXColumn6.FillWeight = 105.4029!
        Me.DataGridViewCheckBoxXColumn6.HeaderText = "Agregar"
        Me.DataGridViewCheckBoxXColumn6.Name = "DataGridViewCheckBoxXColumn6"
        Me.DataGridViewCheckBoxXColumn6.Width = 50
        '
        'DataGridViewCheckBoxXColumn7
        '
        Me.DataGridViewCheckBoxXColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewCheckBoxXColumn7.CheckBoxImageChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_outline_blank_black_24dp
        Me.DataGridViewCheckBoxXColumn7.CheckBoxImageUnChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_black_24dp
        Me.DataGridViewCheckBoxXColumn7.Checked = True
        Me.DataGridViewCheckBoxXColumn7.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxXColumn7.CheckValue = "N"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewCheckBoxXColumn7.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewCheckBoxXColumn7.FillWeight = 98.37717!
        Me.DataGridViewCheckBoxXColumn7.HeaderText = "Editar"
        Me.DataGridViewCheckBoxXColumn7.Name = "DataGridViewCheckBoxXColumn7"
        Me.DataGridViewCheckBoxXColumn7.Width = 40
        '
        'DataGridViewCheckBoxXColumn8
        '
        Me.DataGridViewCheckBoxXColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewCheckBoxXColumn8.CheckBoxImageChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_outline_blank_black_24dp
        Me.DataGridViewCheckBoxXColumn8.CheckBoxImageUnChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_black_24dp
        Me.DataGridViewCheckBoxXColumn8.Checked = True
        Me.DataGridViewCheckBoxXColumn8.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.DataGridViewCheckBoxXColumn8.CheckValue = "N"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewCheckBoxXColumn8.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewCheckBoxXColumn8.FillWeight = 100.066!
        Me.DataGridViewCheckBoxXColumn8.HeaderText = "Eliminar"
        Me.DataGridViewCheckBoxXColumn8.Name = "DataGridViewCheckBoxXColumn8"
        Me.DataGridViewCheckBoxXColumn8.Width = 49
        '
        'Módulo
        '
        Me.Módulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Módulo.HeaderText = "Módulo"
        Me.Módulo.Name = "Módulo"
        Me.Módulo.ReadOnly = True
        '
        'clConsulta
        '
        Me.clConsulta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clConsulta.CheckBoxImageChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_black_24dp
        Me.clConsulta.CheckBoxImageUnChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_outline_blank_black_24dp
        Me.clConsulta.Checked = True
        Me.clConsulta.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.clConsulta.CheckValue = "N"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.clConsulta.DefaultCellStyle = DataGridViewCellStyle1
        Me.clConsulta.FillWeight = 96.15385!
        Me.clConsulta.HeaderText = "Consulta"
        Me.clConsulta.Name = "clConsulta"
        Me.clConsulta.Width = 69
        '
        'clAgregar
        '
        Me.clAgregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clAgregar.CheckBoxImageChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_black_24dp
        Me.clAgregar.CheckBoxImageUnChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_outline_blank_black_24dp
        Me.clAgregar.Checked = True
        Me.clAgregar.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.clAgregar.CheckValue = "N"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.clAgregar.DefaultCellStyle = DataGridViewCellStyle2
        Me.clAgregar.FillWeight = 105.4029!
        Me.clAgregar.HeaderText = "Agregar"
        Me.clAgregar.Name = "clAgregar"
        Me.clAgregar.Width = 64
        '
        'clEditar
        '
        Me.clEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clEditar.CheckBoxImageChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_black_24dp
        Me.clEditar.CheckBoxImageUnChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_outline_blank_black_24dp
        Me.clEditar.Checked = True
        Me.clEditar.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.clEditar.CheckValue = "N"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.clEditar.DefaultCellStyle = DataGridViewCellStyle3
        Me.clEditar.FillWeight = 98.37717!
        Me.clEditar.HeaderText = "Editar"
        Me.clEditar.Name = "clEditar"
        Me.clEditar.Width = 50
        '
        'clEliminar
        '
        Me.clEliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.clEliminar.CheckBoxImageChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_black_24dp
        Me.clEliminar.CheckBoxImageUnChecked = Global.ZapateriaPuntoVenta.My.Resources.Resources.ic_check_box_outline_blank_black_24dp
        Me.clEliminar.Checked = True
        Me.clEliminar.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.clEliminar.CheckValue = "N"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.clEliminar.DefaultCellStyle = DataGridViewCellStyle4
        Me.clEliminar.FillWeight = 100.066!
        Me.clEliminar.HeaderText = "Eliminar"
        Me.clEliminar.Name = "clEliminar"
        Me.clEliminar.Width = 63
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 418)
        Me.Controls.Add(Me.Marco)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.ShowInTaskbar = False
        Me.Text = "Usuarios"
        Me.Marco.ResumeLayout(False)
        Me.Marco.PerformLayout()
        CType(Me.dgrPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Marco As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cboTipos As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgrPermisos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cmdCambiar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ComboItem1 As DevComponents.Editors.ComboItem
    Friend WithEvents DataGridViewCheckBoxXColumn1 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents DataGridViewCheckBoxXColumn2 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents DataGridViewCheckBoxXColumn3 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents DataGridViewCheckBoxXColumn4 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents txtNombreC As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Módulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clConsulta As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents clAgregar As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents clEditar As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents clEliminar As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents DataGridViewCheckBoxXColumn5 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents DataGridViewCheckBoxXColumn6 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents DataGridViewCheckBoxXColumn7 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents DataGridViewCheckBoxXColumn8 As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
End Class
