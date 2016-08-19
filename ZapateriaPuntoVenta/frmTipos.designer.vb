<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipos))
        Me.Marco = New DevComponents.DotNetBar.PanelEx()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dgrPermisos = New DevComponents.DotNetBar.Controls.DataGridViewX()
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
        Me.Marco.CanvasColor = System.Drawing.SystemColors.Control
        Me.Marco.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Marco.Controls.Add(Me.txtNombre)
        Me.Marco.Controls.Add(Me.LabelX2)
        Me.Marco.Controls.Add(Me.txtCodigo)
        Me.Marco.Controls.Add(Me.LabelX1)
        Me.Marco.Controls.Add(Me.dgrPermisos)
        Me.Marco.Enabled = False
        Me.Marco.Location = New System.Drawing.Point(0, 0)
        Me.Marco.Name = "Marco"
        Me.Marco.Size = New System.Drawing.Size(506, 321)
        Me.Marco.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Marco.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Marco.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Marco.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Marco.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Marco.Style.GradientAngle = 90
        Me.Marco.TabIndex = 0
        Me.Marco.Text = "PanelEx1"
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
        Me.txtNombre.Location = New System.Drawing.Point(82, 39)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(411, 22)
        Me.txtNombre.TabIndex = 15
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.ForeColor = System.Drawing.Color.Black
        Me.LabelX2.Location = New System.Drawing.Point(19, 39)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(45, 17)
        Me.LabelX2.TabIndex = 14
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
        Me.txtCodigo.Location = New System.Drawing.Point(82, 6)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(411, 22)
        Me.txtCodigo.TabIndex = 13
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.Color.Black
        Me.LabelX1.Location = New System.Drawing.Point(19, 6)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(40, 17)
        Me.LabelX1.TabIndex = 12
        Me.LabelX1.Text = "Código:"
        '
        'dgrPermisos
        '
        Me.dgrPermisos.AllowUserToAddRows = False
        Me.dgrPermisos.AllowUserToDeleteRows = False
        Me.dgrPermisos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrPermisos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Módulo, Me.clConsulta, Me.clAgregar, Me.clEditar, Me.clEliminar})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrPermisos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgrPermisos.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgrPermisos.Location = New System.Drawing.Point(0, 81)
        Me.dgrPermisos.MultiSelect = False
        Me.dgrPermisos.Name = "dgrPermisos"
        Me.dgrPermisos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgrPermisos.RowTemplate.Height = 30
        Me.dgrPermisos.Size = New System.Drawing.Size(506, 238)
        Me.dgrPermisos.TabIndex = 11
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
        Me.clConsulta.Width = 59
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
        Me.clAgregar.Width = 54
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
        Me.clEditar.Width = 43
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
        Me.clEliminar.Width = 54
        '
        'frmTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 322)
        Me.Controls.Add(Me.Marco)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTipos"
        Me.Text = "Tipos de usuarios"
        Me.Marco.ResumeLayout(False)
        Me.Marco.PerformLayout()
        CType(Me.dgrPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Marco As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgrPermisos As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Módulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clConsulta As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents clAgregar As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents clEditar As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
    Friend WithEvents clEliminar As DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn
End Class
