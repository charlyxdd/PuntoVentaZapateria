<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracion))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Accesos = New System.Windows.Forms.TabPage()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkModulos = New System.Windows.Forms.CheckedListBox()
        Me.Sesiones = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.General = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.Accesos.SuspendLayout()
        Me.Sesiones.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Accesos)
        Me.TabControl1.Controls.Add(Me.Sesiones)
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(592, 385)
        Me.TabControl1.TabIndex = 1
        '
        'Accesos
        '
        Me.Accesos.Controls.Add(Me.cmdGuardar)
        Me.Accesos.Controls.Add(Me.Label1)
        Me.Accesos.Controls.Add(Me.chkModulos)
        Me.Accesos.Location = New System.Drawing.Point(4, 22)
        Me.Accesos.Name = "Accesos"
        Me.Accesos.Padding = New System.Windows.Forms.Padding(3)
        Me.Accesos.Size = New System.Drawing.Size(584, 359)
        Me.Accesos.TabIndex = 0
        Me.Accesos.Text = "Accesos Directos"
        Me.Accesos.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGuardar.Location = New System.Drawing.Point(466, 304)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(81, 28)
        Me.cmdGuardar.TabIndex = 2
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Módulos"
        '
        'chkModulos
        '
        Me.chkModulos.FormattingEnabled = True
        Me.chkModulos.Location = New System.Drawing.Point(8, 39)
        Me.chkModulos.Name = "chkModulos"
        Me.chkModulos.Size = New System.Drawing.Size(539, 259)
        Me.chkModulos.TabIndex = 0
        '
        'Sesiones
        '
        Me.Sesiones.Controls.Add(Me.Button1)
        Me.Sesiones.Location = New System.Drawing.Point(4, 22)
        Me.Sesiones.Name = "Sesiones"
        Me.Sesiones.Padding = New System.Windows.Forms.Padding(3)
        Me.Sesiones.Size = New System.Drawing.Size(570, 352)
        Me.Sesiones.TabIndex = 1
        Me.Sesiones.Text = "Inicio de Sesión"
        Me.Sesiones.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(119, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'General
        '
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Size = New System.Drawing.Size(570, 352)
        Me.General.TabIndex = 2
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 409)
        Me.Controls.Add(Me.TabControl1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracion"
        Me.Text = "Configuración"
        Me.TabControl1.ResumeLayout(False)
        Me.Accesos.ResumeLayout(False)
        Me.Accesos.PerformLayout()
        Me.Sesiones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Accesos As System.Windows.Forms.TabPage
    Friend WithEvents chkModulos As System.Windows.Forms.CheckedListBox
    Friend WithEvents Sesiones As System.Windows.Forms.TabPage
    Friend WithEvents General As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdGuardar As System.Windows.Forms.Button
End Class
