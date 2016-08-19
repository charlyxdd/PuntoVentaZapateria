<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaja))
        Me.Marco = New DevComponents.DotNetBar.PanelEx()
        Me.chkEntregado = New System.Windows.Forms.CheckBox()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdCanjear = New System.Windows.Forms.Button()
        Me.cmdMenos = New System.Windows.Forms.Button()
        Me.cmdMas = New System.Windows.Forms.Button()
        Me.cmdPagar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPagado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.dgrDetalle = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talla = New DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn()
        Me.Estilo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recibido = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Entregado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.cmdBuscarCliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lvNotas = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.Marco.SuspendLayout()
        CType(Me.dgrDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Marco
        '
        Me.Marco.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Marco.CanvasColor = System.Drawing.SystemColors.Control
        Me.Marco.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Marco.Controls.Add(Me.chkEntregado)
        Me.Marco.Controls.Add(Me.cmdCerrar)
        Me.Marco.Controls.Add(Me.cmdCanjear)
        Me.Marco.Controls.Add(Me.cmdMenos)
        Me.Marco.Controls.Add(Me.cmdMas)
        Me.Marco.Controls.Add(Me.cmdPagar)
        Me.Marco.Controls.Add(Me.Label6)
        Me.Marco.Controls.Add(Me.txtSaldo)
        Me.Marco.Controls.Add(Me.Label5)
        Me.Marco.Controls.Add(Me.txtPagado)
        Me.Marco.Controls.Add(Me.Label4)
        Me.Marco.Controls.Add(Me.txtTotal)
        Me.Marco.Controls.Add(Me.dgrDetalle)
        Me.Marco.Controls.Add(Me.Label3)
        Me.Marco.Controls.Add(Me.txtFecha)
        Me.Marco.Controls.Add(Me.txtNombreCliente)
        Me.Marco.Controls.Add(Me.cmdBuscarCliente)
        Me.Marco.Controls.Add(Me.Label2)
        Me.Marco.Controls.Add(Me.txtCodCliente)
        Me.Marco.Controls.Add(Me.Label1)
        Me.Marco.Controls.Add(Me.txtCodigo)
        Me.Marco.Enabled = False
        Me.Marco.Location = New System.Drawing.Point(154, 0)
        Me.Marco.Name = "Marco"
        Me.Marco.Size = New System.Drawing.Size(616, 367)
        Me.Marco.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.Marco.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.Marco.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.Marco.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.Marco.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.Marco.Style.GradientAngle = 90
        Me.Marco.TabIndex = 0
        '
        'chkEntregado
        '
        Me.chkEntregado.AutoSize = True
        Me.chkEntregado.Enabled = False
        Me.chkEntregado.Location = New System.Drawing.Point(530, 109)
        Me.chkEntregado.Name = "chkEntregado"
        Me.chkEntregado.Size = New System.Drawing.Size(80, 17)
        Me.chkEntregado.TabIndex = 22
        Me.chkEntregado.Text = "Entregado"
        Me.chkEntregado.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Enabled = False
        Me.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerrar.Location = New System.Drawing.Point(236, 104)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(108, 24)
        Me.cmdCerrar.TabIndex = 21
        Me.cmdCerrar.Text = "Cerrar nota"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdCanjear
        '
        Me.cmdCanjear.Enabled = False
        Me.cmdCanjear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCanjear.Location = New System.Drawing.Point(122, 104)
        Me.cmdCanjear.Name = "cmdCanjear"
        Me.cmdCanjear.Size = New System.Drawing.Size(108, 24)
        Me.cmdCanjear.TabIndex = 20
        Me.cmdCanjear.Text = "Canjear por vale"
        Me.cmdCanjear.UseVisualStyleBackColor = True
        '
        'cmdMenos
        '
        Me.cmdMenos.Enabled = False
        Me.cmdMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMenos.Location = New System.Drawing.Point(72, 104)
        Me.cmdMenos.Name = "cmdMenos"
        Me.cmdMenos.Size = New System.Drawing.Size(44, 24)
        Me.cmdMenos.TabIndex = 18
        Me.cmdMenos.Text = "-"
        Me.cmdMenos.UseVisualStyleBackColor = True
        '
        'cmdMas
        '
        Me.cmdMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMas.Location = New System.Drawing.Point(22, 104)
        Me.cmdMas.Name = "cmdMas"
        Me.cmdMas.Size = New System.Drawing.Size(44, 24)
        Me.cmdMas.TabIndex = 17
        Me.cmdMas.Text = "+"
        Me.cmdMas.UseVisualStyleBackColor = True
        '
        'cmdPagar
        '
        Me.cmdPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPagar.Location = New System.Drawing.Point(327, 324)
        Me.cmdPagar.Name = "cmdPagar"
        Me.cmdPagar.Size = New System.Drawing.Size(73, 25)
        Me.cmdPagar.TabIndex = 16
        Me.cmdPagar.Text = "Pagar"
        Me.cmdPagar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(401, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Saldo:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSaldo.Location = New System.Drawing.Point(452, 324)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(160, 25)
        Me.txtSaldo.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(177, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Pagado:"
        '
        'txtPagado
        '
        Me.txtPagado.Enabled = False
        Me.txtPagado.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPagado.Location = New System.Drawing.Point(241, 324)
        Me.txtPagado.Name = "txtPagado"
        Me.txtPagado.Size = New System.Drawing.Size(80, 25)
        Me.txtPagado.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(8, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtTotal.Location = New System.Drawing.Point(70, 324)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(101, 25)
        Me.txtTotal.TabIndex = 10
        '
        'dgrDetalle
        '
        Me.dgrDetalle.AllowUserToAddRows = False
        Me.dgrDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgrDetalle.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgrDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Proveedor, Me.Talla, Me.Estilo, Me.Color, Me.Recibido, Me.Entregado, Me.Precio})
        Me.dgrDetalle.Location = New System.Drawing.Point(12, 134)
        Me.dgrDetalle.Name = "dgrDetalle"
        Me.dgrDetalle.Size = New System.Drawing.Size(600, 184)
        Me.dgrDetalle.TabIndex = 9
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Visible = False
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.ReadOnly = True
        '
        'Talla
        '
        Me.Talla.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.Talla.BackgroundStyle.Class = "DataGridViewIpAddressBorder"
        Me.Talla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Talla.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Talla.HeaderText = "Talla"
        Me.Talla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Talla.Name = "Talla"
        Me.Talla.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Talla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Talla.Text = ""
        '
        'Estilo
        '
        Me.Estilo.HeaderText = "Estilo"
        Me.Estilo.Name = "Estilo"
        Me.Estilo.ReadOnly = True
        '
        'Color
        '
        Me.Color.HeaderText = "Color"
        Me.Color.Name = "Color"
        Me.Color.ReadOnly = True
        '
        'Recibido
        '
        Me.Recibido.HeaderText = "Recibido"
        Me.Recibido.Name = "Recibido"
        Me.Recibido.ReadOnly = True
        Me.Recibido.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Recibido.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Entregado
        '
        Me.Entregado.HeaderText = "Entregado"
        Me.Entregado.Name = "Entregado"
        Me.Entregado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Entregado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha:"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFecha.Location = New System.Drawing.Point(80, 73)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(532, 25)
        Me.txtFecha.TabIndex = 7
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtNombreCliente.Location = New System.Drawing.Point(205, 42)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(407, 25)
        Me.txtNombreCliente.TabIndex = 6
        '
        'cmdBuscarCliente
        '
        Me.cmdBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBuscarCliente.Location = New System.Drawing.Point(154, 42)
        Me.cmdBuscarCliente.Name = "cmdBuscarCliente"
        Me.cmdBuscarCliente.Size = New System.Drawing.Size(45, 25)
        Me.cmdBuscarCliente.TabIndex = 5
        Me.cmdBuscarCliente.Text = "..."
        Me.cmdBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cliente:"
        '
        'txtCodCliente
        '
        Me.txtCodCliente.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCodCliente.Location = New System.Drawing.Point(80, 42)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.Size = New System.Drawing.Size(68, 25)
        Me.txtCodCliente.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(18, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtCodigo.Location = New System.Drawing.Point(80, 11)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(532, 25)
        Me.txtCodigo.TabIndex = 1
        '
        'lvNotas
        '
        Me.lvNotas.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.lvNotas.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lvNotas.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lvNotas.Border.Class = "ListViewBorder"
        Me.lvNotas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lvNotas.Dock = System.Windows.Forms.DockStyle.Left
        Me.lvNotas.ForeColor = System.Drawing.Color.Black
        Me.lvNotas.Location = New System.Drawing.Point(0, 0)
        Me.lvNotas.MultiSelect = False
        Me.lvNotas.Name = "lvNotas"
        Me.lvNotas.Size = New System.Drawing.Size(148, 367)
        Me.lvNotas.TabIndex = 1
        Me.lvNotas.UseCompatibleStateImageBehavior = False
        Me.lvNotas.View = System.Windows.Forms.View.SmallIcon
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 367)
        Me.Controls.Add(Me.lvNotas)
        Me.Controls.Add(Me.Marco)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCaja"
        Me.Text = "Caja"
        Me.Marco.ResumeLayout(False)
        Me.Marco.PerformLayout()
        CType(Me.dgrDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Marco As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents cmdBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodCliente As System.Windows.Forms.TextBox
    Friend WithEvents dgrDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents cmdPagar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents cmdCanjear As System.Windows.Forms.Button
    Friend WithEvents cmdMenos As System.Windows.Forms.Button
    Friend WithEvents cmdMas As System.Windows.Forms.Button
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents chkEntregado As System.Windows.Forms.CheckBox
    Friend WithEvents lvNotas As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Talla As DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn
    Friend WithEvents Estilo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Color As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recibido As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Entregado As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
