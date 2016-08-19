<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.RadialMenu1 = New DevComponents.DotNetBar.RadialMenu()
        Me.cmdBaseDatos = New DevComponents.DotNetBar.RadialMenuItem()
        Me.cmdOlvido = New DevComponents.DotNetBar.RadialMenuItem()
        Me.Highlighter1 = New DevComponents.DotNetBar.Validator.Highlighter()
        Me.txtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPass = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.SwitchButton1 = New DevComponents.DotNetBar.Controls.SwitchButton()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'RadialMenu1
        '
        Me.RadialMenu1.BackColor = System.Drawing.Color.Transparent
        Me.RadialMenu1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.cmdBaseDatos, Me.cmdOlvido})
        Me.RadialMenu1.Location = New System.Drawing.Point(12, 140)
        Me.RadialMenu1.MenuType = DevComponents.DotNetBar.eRadialMenuType.Circular
        Me.RadialMenu1.Name = "RadialMenu1"
        Me.RadialMenu1.Size = New System.Drawing.Size(28, 28)
        Me.RadialMenu1.Symbol = ""
        Me.RadialMenu1.TabIndex = 0
        Me.RadialMenu1.Text = "Opciones"
        '
        'cmdBaseDatos
        '
        Me.cmdBaseDatos.CircularBackColor = System.Drawing.SystemColors.HotTrack
        Me.cmdBaseDatos.Name = "cmdBaseDatos"
        Me.cmdBaseDatos.Symbol = ""
        Me.cmdBaseDatos.Tag = "Hola"
        Me.cmdBaseDatos.Text = "Configuración de base de datos"
        Me.cmdBaseDatos.Tooltip = "Configuración de la base de datos"
        '
        'cmdOlvido
        '
        Me.cmdOlvido.CircularBackColor = System.Drawing.SystemColors.HotTrack
        Me.cmdOlvido.Name = "cmdOlvido"
        Me.cmdOlvido.Symbol = ""
        Me.cmdOlvido.Text = "¿Olvidó su contraseña?"
        Me.cmdOlvido.Tooltip = "Recuperar contraseña"
        '
        'Highlighter1
        '
        Me.Highlighter1.ContainerControl = Me
        Me.Highlighter1.CustomHighlightColors = New System.Drawing.Color(-1) {}
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUsuario.Border.Class = "TextBoxBorder"
        Me.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsuario.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtUsuario, True)
        Me.txtUsuario.Location = New System.Drawing.Point(12, 32)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(393, 25)
        Me.txtUsuario.TabIndex = 2
        Me.txtUsuario.WatermarkText = "Usuario"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPass.Border.Class = "TextBoxBorder"
        Me.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.Highlighter1.SetHighlightOnFocus(Me.txtPass, True)
        Me.txtPass.Location = New System.Drawing.Point(12, 98)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(347, 25)
        Me.txtPass.TabIndex = 4
        Me.txtPass.WatermarkText = "Contraseña"
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
        Me.LabelX1.Size = New System.Drawing.Size(119, 20)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Nombre de usuario:"
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(12, 72)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(72, 20)
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Contraseña:"
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(272, 139)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(133, 29)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 5
        Me.ButtonX1.Text = "ButtonX1"
        '
        'SwitchButton1
        '
        '
        '
        '
        Me.SwitchButton1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SwitchButton1.Location = New System.Drawing.Point(365, 98)
        Me.SwitchButton1.Name = "SwitchButton1"
        Me.SwitchButton1.OffBackColor = System.Drawing.Color.Red
        Me.SwitchButton1.OffText = "No"
        Me.SwitchButton1.OffTextColor = System.Drawing.Color.White
        Me.SwitchButton1.OnBackColor = System.Drawing.Color.Blue
        Me.SwitchButton1.OnText = "Sí"
        Me.SwitchButton1.OnTextColor = System.Drawing.Color.White
        Me.SwitchButton1.Size = New System.Drawing.Size(55, 25)
        Me.SwitchButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SwitchButton1.SwitchWidth = 10
        Me.SwitchButton1.TabIndex = 6
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(365, 72)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(44, 20)
        Me.LabelX3.TabIndex = 7
        Me.LabelX3.Text = "Visible:"
        '
        'frmLogin
        '
        Me.AcceptButton = Me.ButtonX1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(417, 173)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.SwitchButton1)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.RadialMenu1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadialMenu1 As DevComponents.DotNetBar.RadialMenu
    Friend WithEvents cmdBaseDatos As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents cmdOlvido As DevComponents.DotNetBar.RadialMenuItem
    Friend WithEvents Highlighter1 As DevComponents.DotNetBar.Validator.Highlighter
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPass As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents SwitchButton1 As DevComponents.DotNetBar.Controls.SwitchButton
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
End Class
