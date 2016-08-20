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
        Me.Marco = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Accesos = New System.Windows.Forms.TabPage()
        Me.chkModulos = New System.Windows.Forms.CheckedListBox()
        Me.Sesiones = New System.Windows.Forms.TabPage()
        Me.General = New System.Windows.Forms.TabPage()
        Me.Marco.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Accesos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Marco
        '
        Me.Marco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Marco.BackColor = System.Drawing.SystemColors.Control
        Me.Marco.Controls.Add(Me.TabControl1)
        Me.Marco.Location = New System.Drawing.Point(12, 12)
        Me.Marco.Name = "Marco"
        Me.Marco.Size = New System.Drawing.Size(485, 315)
        Me.Marco.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Accesos)
        Me.TabControl1.Controls.Add(Me.Sesiones)
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(485, 313)
        Me.TabControl1.TabIndex = 0
        '
        'Accesos
        '
        Me.Accesos.Controls.Add(Me.chkModulos)
        Me.Accesos.Location = New System.Drawing.Point(4, 22)
        Me.Accesos.Name = "Accesos"
        Me.Accesos.Padding = New System.Windows.Forms.Padding(3)
        Me.Accesos.Size = New System.Drawing.Size(477, 287)
        Me.Accesos.TabIndex = 0
        Me.Accesos.Text = "Accesos Directos"
        Me.Accesos.UseVisualStyleBackColor = True
        '
        'chkModulos
        '
        Me.chkModulos.FormattingEnabled = True
        Me.chkModulos.Location = New System.Drawing.Point(8, 11)
        Me.chkModulos.Name = "chkModulos"
        Me.chkModulos.Size = New System.Drawing.Size(449, 259)
        Me.chkModulos.TabIndex = 0
        '
        'Sesiones
        '
        Me.Sesiones.Location = New System.Drawing.Point(4, 22)
        Me.Sesiones.Name = "Sesiones"
        Me.Sesiones.Padding = New System.Windows.Forms.Padding(3)
        Me.Sesiones.Size = New System.Drawing.Size(463, 280)
        Me.Sesiones.TabIndex = 1
        Me.Sesiones.Text = "Inicio de Sesión"
        Me.Sesiones.UseVisualStyleBackColor = True
        '
        'General
        '
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Size = New System.Drawing.Size(463, 280)
        Me.General.TabIndex = 2
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'frmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 346)
        Me.Controls.Add(Me.Marco)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmConfiguracion"
        Me.Text = "Configuración"
        Me.Marco.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Accesos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Marco As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Accesos As System.Windows.Forms.TabPage
    Friend WithEvents Sesiones As System.Windows.Forms.TabPage
    Friend WithEvents General As System.Windows.Forms.TabPage
    Friend WithEvents chkModulos As System.Windows.Forms.CheckedListBox
End Class
