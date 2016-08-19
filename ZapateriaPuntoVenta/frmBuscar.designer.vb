<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscar))
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtFiltro = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dgrBuscar = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cmdQuitar = New DevComponents.DotNetBar.ButtonX()
        CType(Me.dgrBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(12, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(63, 20)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Filtrar por:"
        '
        'txtFiltro
        '
        Me.txtFiltro.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFiltro.Border.Class = "TextBoxBorder"
        Me.txtFiltro.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFiltro.ForeColor = System.Drawing.Color.Black
        Me.txtFiltro.Location = New System.Drawing.Point(12, 38)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(498, 25)
        Me.txtFiltro.TabIndex = 2
        Me.txtFiltro.WatermarkText = "Palabras claves"
        '
        'dgrBuscar
        '
        Me.dgrBuscar.AllowUserToAddRows = False
        Me.dgrBuscar.AllowUserToDeleteRows = False
        Me.dgrBuscar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgrBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgrBuscar.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgrBuscar.GridColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.dgrBuscar.Location = New System.Drawing.Point(-2, 106)
        Me.dgrBuscar.Name = "dgrBuscar"
        Me.dgrBuscar.ReadOnly = True
        Me.dgrBuscar.Size = New System.Drawing.Size(524, 365)
        Me.dgrBuscar.TabIndex = 4
        '
        'cmdQuitar
        '
        Me.cmdQuitar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdQuitar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdQuitar.Location = New System.Drawing.Point(441, 69)
        Me.cmdQuitar.Name = "cmdQuitar"
        Me.cmdQuitar.Size = New System.Drawing.Size(69, 31)
        Me.cmdQuitar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdQuitar.TabIndex = 5
        Me.cmdQuitar.Text = "Quitar filtro"
        '
        'frmBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 468)
        Me.Controls.Add(Me.cmdQuitar)
        Me.Controls.Add(Me.dgrBuscar)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.LabelX1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar"
        CType(Me.dgrBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtFiltro As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dgrBuscar As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cmdQuitar As DevComponents.DotNetBar.ButtonX
End Class
