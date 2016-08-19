<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.Marco = New DevComponents.DotNetBar.PanelEx()
        Me.txtTel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtNombre = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCodigo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.txtCel = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtFb = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.Marco.SuspendLayout()
        Me.SuspendLayout()
        '
        'Marco
        '
        Me.Marco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Marco.CanvasColor = System.Drawing.SystemColors.Control
        Me.Marco.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Marco.Controls.Add(Me.txtFb)
        Me.Marco.Controls.Add(Me.LabelX5)
        Me.Marco.Controls.Add(Me.txtCel)
        Me.Marco.Controls.Add(Me.txtTel)
        Me.Marco.Controls.Add(Me.LabelX4)
        Me.Marco.Controls.Add(Me.LabelX3)
        Me.Marco.Controls.Add(Me.txtNombre)
        Me.Marco.Controls.Add(Me.LabelX2)
        Me.Marco.Controls.Add(Me.txtCodigo)
        Me.Marco.Controls.Add(Me.LabelX1)
        Me.Marco.Enabled = False
        Me.Marco.Location = New System.Drawing.Point(1, 0)
        Me.Marco.Name = "Marco"
        Me.Marco.Size = New System.Drawing.Size(486, 146)
        Me.Marco.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Marco.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Marco.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Marco.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Marco.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Marco.Style.GradientAngle = 90
        Me.Marco.TabIndex = 1
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtTel.Border.Class = "TextBoxBorder"
        Me.txtTel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtTel.ForeColor = System.Drawing.Color.Black
        Me.txtTel.Location = New System.Drawing.Point(72, 59)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(411, 22)
        Me.txtTel.TabIndex = 9
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.ForeColor = System.Drawing.Color.Black
        Me.LabelX4.Location = New System.Drawing.Point(9, 59)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(47, 17)
        Me.LabelX4.TabIndex = 8
        Me.LabelX4.Text = "Teléfono:"
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.ForeColor = System.Drawing.Color.Black
        Me.LabelX3.Location = New System.Drawing.Point(9, 87)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(38, 17)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Celular:"
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
        Me.txtNombre.Location = New System.Drawing.Point(72, 31)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(411, 22)
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
        Me.LabelX2.Location = New System.Drawing.Point(9, 31)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(45, 17)
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
        Me.txtCodigo.Size = New System.Drawing.Size(411, 22)
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
        Me.LabelX1.Size = New System.Drawing.Size(40, 17)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Código:"
        '
        'txtCel
        '
        Me.txtCel.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCel.Border.Class = "TextBoxBorder"
        Me.txtCel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCel.ForeColor = System.Drawing.Color.Black
        Me.txtCel.Location = New System.Drawing.Point(72, 87)
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(411, 22)
        Me.txtCel.TabIndex = 10
        '
        'txtFb
        '
        Me.txtFb.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtFb.Border.Class = "TextBoxBorder"
        Me.txtFb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtFb.ForeColor = System.Drawing.Color.Black
        Me.txtFb.Location = New System.Drawing.Point(72, 115)
        Me.txtFb.Name = "txtFb"
        Me.txtFb.Size = New System.Drawing.Size(411, 22)
        Me.txtFb.TabIndex = 12
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.ForeColor = System.Drawing.Color.Black
        Me.LabelX5.Location = New System.Drawing.Point(9, 115)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(52, 17)
        Me.LabelX5.TabIndex = 11
        Me.LabelX5.Text = "Facebook:"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 147)
        Me.Controls.Add(Me.Marco)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmClientes"
        Me.Text = "Clientes"
        Me.Marco.ResumeLayout(False)
        Me.Marco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Marco As DevComponents.DotNetBar.PanelEx
    Friend WithEvents txtFb As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtTel As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtNombre As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCodigo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
