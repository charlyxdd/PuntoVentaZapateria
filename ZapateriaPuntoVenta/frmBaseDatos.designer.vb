<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseDatos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBaseDatos))
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.txtIP = New DevComponents.Editors.IpAddressInput()
        Me.lvEquipos = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.imgs = New System.Windows.Forms.ImageList(Me.components)
        Me.tmrAnimacion = New System.Windows.Forms.Timer(Me.components)
        CType(Me.txtIP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(411, 27)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(62, 25)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 4
        Me.ButtonX1.Text = "ButtonX1"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(13, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(176, 20)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Localización de la base datos:"
        '
        'Highlighter1
        '
        Me.Highlighter1.CustomHighlightColors = New System.Drawing.Color(-1) {}
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(378, 58)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(85, 28)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 6
        Me.ButtonX2.Text = "ButtonX2"
        '
        'txtIP
        '
        Me.txtIP.AutoOverwrite = True
        '
        '
        '
        Me.txtIP.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtIP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtIP.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.txtIP.ButtonFreeText.Visible = True
        Me.txtIP.Location = New System.Drawing.Point(13, 27)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(392, 25)
        Me.txtIP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtIP.TabIndex = 7
        '
        'lvEquipos
        '
        Me.lvEquipos.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lvEquipos.Border.Class = "ListViewBorder"
        Me.lvEquipos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvEquipos.ForeColor = System.Drawing.Color.Black
        Me.lvEquipos.GridLines = True
        Me.lvEquipos.LargeImageList = Me.imgs
        Me.lvEquipos.Location = New System.Drawing.Point(13, 58)
        Me.lvEquipos.Name = "lvEquipos"
        Me.lvEquipos.Size = New System.Drawing.Size(460, 228)
        Me.lvEquipos.TabIndex = 8
        Me.lvEquipos.UseCompatibleStateImageBehavior = False
        Me.lvEquipos.Visible = False
        '
        'imgs
        '
        Me.imgs.ImageStream = CType(resources.GetObject("imgs.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgs.TransparentColor = System.Drawing.Color.Transparent
        Me.imgs.Images.SetKeyName(0, "1.ico")
        '
        'tmrAnimacion
        '
        Me.tmrAnimacion.Interval = 10
        '
        'frmBaseDatos
        '
        Me.AcceptButton = Me.ButtonX2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 86)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.lvEquipos)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmBaseDatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cambiar configuración de base datos"
        CType(Me.txtIP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtIP As DevComponents.Editors.IpAddressInput
    Friend WithEvents lvEquipos As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents imgs As System.Windows.Forms.ImageList
    Friend WithEvents tmrAnimacion As System.Windows.Forms.Timer
End Class
