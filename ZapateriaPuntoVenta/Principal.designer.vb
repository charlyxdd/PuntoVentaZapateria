<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAceptar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImprimir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTipos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSesiones = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsumos = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntoVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCaja = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.barra = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.accesos = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.BubbleButton1 = New DevComponents.DotNetBar.BubbleButton()
        Me.cmdNuevo = New System.Windows.Forms.ToolStripButton()
        Me.cmdEditar = New System.Windows.Forms.ToolStripButton()
        Me.cmdEliminar = New System.Windows.Forms.ToolStripButton()
        Me.cmdBuscar = New System.Windows.Forms.ToolStripButton()
        Me.cmdAceptar = New System.Windows.Forms.ToolStripButton()
        Me.cmdCancelar = New System.Windows.Forms.ToolStripButton()
        Me.cmdImprmir = New System.Windows.Forms.ToolStripButton()
        Me.BubbleButton2 = New DevComponents.DotNetBar.BubbleButton()
        Me.MenuStrip1.SuspendLayout()
        Me.barra.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccionesToolStripMenuItem, Me.mnuCat, Me.OperacionesToolStripMenuItem, Me.PuntoVToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(725, 23)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccionesToolStripMenuItem
        '
        Me.AccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.mnuEditar, Me.mnuEliminar, Me.mnuBuscar, Me.mnuAceptar, Me.mnuCancelar, Me.mnuImprimir})
        Me.AccionesToolStripMenuItem.Name = "AccionesToolStripMenuItem"
        Me.AccionesToolStripMenuItem.Size = New System.Drawing.Size(67, 19)
        Me.AccionesToolStripMenuItem.Text = "Acciones"
        '
        'mnuNuevo
        '
        Me.mnuNuevo.Enabled = False
        Me.mnuNuevo.Name = "mnuNuevo"
        Me.mnuNuevo.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuNuevo.Size = New System.Drawing.Size(161, 22)
        Me.mnuNuevo.Text = "Nuevo"
        '
        'mnuEditar
        '
        Me.mnuEditar.Enabled = False
        Me.mnuEditar.Name = "mnuEditar"
        Me.mnuEditar.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuEditar.Size = New System.Drawing.Size(161, 22)
        Me.mnuEditar.Text = "Editar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Enabled = False
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.mnuEliminar.Size = New System.Drawing.Size(161, 22)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'mnuBuscar
        '
        Me.mnuBuscar.Enabled = False
        Me.mnuBuscar.Name = "mnuBuscar"
        Me.mnuBuscar.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.mnuBuscar.Size = New System.Drawing.Size(161, 22)
        Me.mnuBuscar.Text = "Buscar"
        '
        'mnuAceptar
        '
        Me.mnuAceptar.Enabled = False
        Me.mnuAceptar.Name = "mnuAceptar"
        Me.mnuAceptar.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.mnuAceptar.Size = New System.Drawing.Size(161, 22)
        Me.mnuAceptar.Text = "Aceptar"
        '
        'mnuCancelar
        '
        Me.mnuCancelar.Enabled = False
        Me.mnuCancelar.Name = "mnuCancelar"
        Me.mnuCancelar.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.mnuCancelar.Size = New System.Drawing.Size(161, 22)
        Me.mnuCancelar.Text = "Cancelar"
        '
        'mnuImprimir
        '
        Me.mnuImprimir.Enabled = False
        Me.mnuImprimir.Name = "mnuImprimir"
        Me.mnuImprimir.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuImprimir.Size = New System.Drawing.Size(161, 22)
        Me.mnuImprimir.Text = "Imprimir"
        '
        'mnuCat
        '
        Me.mnuCat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUsuarios, Me.mnuClientes, Me.mnuProveedores, Me.mnuInsumos})
        Me.mnuCat.Name = "mnuCat"
        Me.mnuCat.Size = New System.Drawing.Size(72, 19)
        Me.mnuCat.Text = "Catálogos"
        '
        'mnuUsuarios
        '
        Me.mnuUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTipos, Me.mnuSesiones})
        Me.mnuUsuarios.Name = "mnuUsuarios"
        Me.mnuUsuarios.Size = New System.Drawing.Size(139, 22)
        Me.mnuUsuarios.Text = "Usuarios"
        '
        'mnuTipos
        '
        Me.mnuTipos.Name = "mnuTipos"
        Me.mnuTipos.Size = New System.Drawing.Size(117, 22)
        Me.mnuTipos.Text = "Tipos"
        '
        'mnuSesiones
        '
        Me.mnuSesiones.Name = "mnuSesiones"
        Me.mnuSesiones.Size = New System.Drawing.Size(117, 22)
        Me.mnuSesiones.Text = "Cuentas"
        '
        'mnuClientes
        '
        Me.mnuClientes.Name = "mnuClientes"
        Me.mnuClientes.Size = New System.Drawing.Size(139, 22)
        Me.mnuClientes.Text = "Clientes"
        '
        'mnuProveedores
        '
        Me.mnuProveedores.Name = "mnuProveedores"
        Me.mnuProveedores.Size = New System.Drawing.Size(139, 22)
        Me.mnuProveedores.Text = "Proveedores"
        '
        'mnuInsumos
        '
        Me.mnuInsumos.Name = "mnuInsumos"
        Me.mnuInsumos.Size = New System.Drawing.Size(139, 22)
        Me.mnuInsumos.Text = "Productos"
        '
        'OperacionesToolStripMenuItem
        '
        Me.OperacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidosVentasToolStripMenuItem})
        Me.OperacionesToolStripMenuItem.Name = "OperacionesToolStripMenuItem"
        Me.OperacionesToolStripMenuItem.Size = New System.Drawing.Size(85, 19)
        Me.OperacionesToolStripMenuItem.Text = "Operaciones"
        '
        'PedidosVentasToolStripMenuItem
        '
        Me.PedidosVentasToolStripMenuItem.Name = "PedidosVentasToolStripMenuItem"
        Me.PedidosVentasToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.PedidosVentasToolStripMenuItem.Text = "Pedidos a proveedores"
        '
        'PuntoVToolStripMenuItem
        '
        Me.PuntoVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCaja})
        Me.PuntoVToolStripMenuItem.Name = "PuntoVToolStripMenuItem"
        Me.PuntoVToolStripMenuItem.Size = New System.Drawing.Size(61, 19)
        Me.PuntoVToolStripMenuItem.Text = "Punto V"
        '
        'mnuCaja
        '
        Me.mnuCaja.Name = "mnuCaja"
        Me.mnuCaja.Size = New System.Drawing.Size(152, 22)
        Me.mnuCaja.Text = "Notas-Pedidos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InventarioToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 19)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 19)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(88, 19)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 19)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'barra
        '
        Me.barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.cmdNuevo, Me.cmdEditar, Me.ToolStripSeparator2, Me.cmdEliminar, Me.cmdBuscar, Me.ToolStripSeparator1, Me.cmdAceptar, Me.cmdCancelar, Me.ToolStripSeparator4, Me.cmdImprmir})
        Me.barra.Location = New System.Drawing.Point(0, 23)
        Me.barra.Name = "barra"
        Me.barra.Size = New System.Drawing.Size(725, 72)
        Me.barra.TabIndex = 3
        Me.barra.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 72)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 72)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 72)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 72)
        '
        'BubbleBar1
        '
        Me.BubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.BubbleBar1.AntiAlias = True
        Me.BubbleBar1.BackColor = System.Drawing.Color.LightGray
        '
        '
        '
        Me.BubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        '
        '
        '
        Me.BubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BubbleBar1.ImageSizeNormal = New System.Drawing.Size(24, 24)
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 522)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.accesos
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(725, 32)
        Me.BubbleBar1.TabIndex = 5
        Me.BubbleBar1.Tabs.Add(Me.accesos)
        Me.BubbleBar1.TabsVisible = False
        '
        'accesos
        '
        Me.accesos.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.accesos.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.accesos.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.accesos.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.accesos.Name = "accesos"
        Me.accesos.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.accesos.Text = "Accesos rápidos"
        Me.accesos.TextColor = System.Drawing.Color.Black
        '
        'BubbleButton1
        '
        Me.BubbleButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BubbleButton1.Name = "BubbleButton1"
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Enabled = False
        Me.cmdNuevo.Image = CType(resources.GetObject("cmdNuevo.Image"), System.Drawing.Image)
        Me.cmdNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(54, 69)
        Me.cmdNuevo.Text = "Nuevo"
        Me.cmdNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdEditar
        '
        Me.cmdEditar.Enabled = False
        Me.cmdEditar.Image = CType(resources.GetObject("cmdEditar.Image"), System.Drawing.Image)
        Me.cmdEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Size = New System.Drawing.Size(54, 69)
        Me.cmdEditar.Text = "Editar"
        Me.cmdEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Image = CType(resources.GetObject("cmdEliminar.Image"), System.Drawing.Image)
        Me.cmdEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(54, 69)
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Enabled = False
        Me.cmdBuscar.Image = CType(resources.GetObject("cmdBuscar.Image"), System.Drawing.Image)
        Me.cmdBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(54, 69)
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Enabled = False
        Me.cmdAceptar.Image = CType(resources.GetObject("cmdAceptar.Image"), System.Drawing.Image)
        Me.cmdAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(54, 69)
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Image = CType(resources.GetObject("cmdCancelar.Image"), System.Drawing.Image)
        Me.cmdCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(57, 69)
        Me.cmdCancelar.Text = "Cancelar"
        Me.cmdCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cmdImprmir
        '
        Me.cmdImprmir.Enabled = False
        Me.cmdImprmir.Image = CType(resources.GetObject("cmdImprmir.Image"), System.Drawing.Image)
        Me.cmdImprmir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdImprmir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdImprmir.Name = "cmdImprmir"
        Me.cmdImprmir.Size = New System.Drawing.Size(57, 69)
        Me.cmdImprmir.Text = "Imprimir"
        Me.cmdImprmir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdImprmir.ToolTipText = "Imprimir"
        '
        'BubbleButton2
        '
        Me.BubbleButton2.Image = CType(resources.GetObject("BubbleButton2.Image"), System.Drawing.Image)
        Me.BubbleButton2.ImageLarge = CType(resources.GetObject("BubbleButton2.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton2.Name = "BubbleButton2"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(725, 554)
        Me.Controls.Add(Me.BubbleBar1)
        Me.Controls.Add(Me.barra)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.barra.ResumeLayout(False)
        Me.barra.PerformLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNuevo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEliminar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBuscar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAceptar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents barra As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdNuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdImprmir As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuImprimir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents accesos As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents BubbleButton1 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton2 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents mnuTipos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSesiones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuntoVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCaja As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInsumos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
