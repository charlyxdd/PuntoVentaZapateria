Imports DevComponents.DotNetBar

Public Class frmCaja
    Dim ediNuevo, Editando As Boolean
    Dim pass, indice As String
    Dim cnn As Conexion
    Dim agregarP, editarP, eliminarP, consultaP As Boolean

    Private Sub frmUsuarios_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        activo = Me
        mostrarBarra()
        If consultaP Then
            If Editando Or ediNuevo Then
                desactivarEdicion()
                activarControles(agregarP)
                desactivarImpresion()
                activarAcciones()
            Else
                If txtCodigo.TextLength = 0 Then
                    activarControles(agregarP)
                    desactivarAcciones()
                    desactivarImpresion()
                    desactivarEdicion()
                Else
                    activarControles(agregarP)
                    activarEdicion(editarP, eliminarP)
                    desactivarAcciones()
                    desactivarImpresion()
                End If
            End If
        End If
    End Sub

    Private Sub frmUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        activo = Nothing
        desactivarControles()
        desactivarEdicion()
        desactivarAcciones()
        desactivarImpresion()
        ocultarBarra()
    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        cnn = New Conexion(cadConexion)
        permisos()
        actualizarNotas()
    End Sub

    Private Sub Limpiar()
        txtCodigo.Text = ""
        txtCodCliente.Text = ""
        txtNombreCliente.Text = ""
        txtFecha.Text = Date.Today
        dgrDetalle.Rows.Clear()
        txtTotal.Text = ""
        txtPagado.Text = FormatCurrency(0, 2)
        txtSaldo.Text = ""
        chkEntregado.Checked = False
        cmdCanjear.Enabled = False
        cmdCerrar.Enabled = False
        cmdMenos.Enabled = False
        cmdMas.Enabled = True
        cmdPagar.Enabled = True
        dgrDetalle.ReadOnly = False
        Marco.Enabled = False
    End Sub

    Public Sub Nuevo()
        Limpiar()
        ediNuevo = True
        Editando = False
        Marco.Enabled = True
        frmUsuarios_Activated(Me, Nothing)
    End Sub

    Private Sub permisos()
        Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Permisos WHERE Tipo=" & tipoUser & " AND Modulo=6")
        If Not IsNothing(dt) Then
            Dim row As DataRow = dt.Rows.Item(0)
            agregarP = row.Item("Agregar")
            editarP = row.Item("Editar")
            eliminarP = row.Item("Eliminar")
            consultaP = row.Item("Consulta")
        End If
    End Sub

    Public Sub Editar()
        ediNuevo = False
        Editando = True
        Marco.Enabled = True
        frmUsuarios_Activated(Me, Nothing)
    End Sub

    Public Sub Buscar()
        Dim encontrado As Boolean
        Dim claveBuscada As String
        Dim f As frmBuscar
        f = New frmBuscar
        Try
            With f
                .Text = "Pantalla de Búsqueda de Pedidos/Notas de venta"
                .dgrBuscar.Rows.Clear()
                .dgrBuscar.Columns.Clear()
                .dgrBuscar.Columns.Add("Codigo", "Codigo")
                .dgrBuscar.Columns.Add("Nombre", "Cliente")
                .dgrBuscar.Columns.Add("Fecha", "Fecha")
                .dgrBuscar.Columns.Add("Fecha", "Total")
                .dgrBuscar.Columns.Add("Fecha", "Pagado")
                .dgrBuscar.Columns.Add("Fecha", "Entregado")
            End With
            Dim dt As DataTable = cnn.getConsulta("SELECT PedidosClientes.Codigo,Clientes.Nombre,PedidosClientes.Fecha,PedidosClientes.Total,PedidosClientes.Pagado,PedidosClientes.Entregado,PedidosClientes.Activo FROM PedidosClientes INNER JOIN Clientes ON PedidosClientes.Cliente=Clientes.Codigo")
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows
                    Dim en As String
                    If row.Item("Entregado") = True Then
                        en = "Sí"
                    Else
                        en = "No"
                    End If
                    f.dgrBuscar.Rows.Add(row.Item("Codigo"), row.Item("Nombre"), row.Item("Fecha"), row.Item("Total"), row.Item("Pagado"), en)
                    If Not CBool(row.Item("Activo")) Then
                        For Each cell As DataGridViewCell In f.dgrBuscar.Rows(f.dgrBuscar.Rows.Count - 1).Cells
                            Dim estilo As New DataGridViewCellStyle()
                            estilo.BackColor = Drawing.Color.Red
                            estilo.ForeColor = Drawing.Color.White
                            cell.Style = estilo
                        Next
                    End If
                Next
            End If
            f.ShowDialog(Me)
            encontrado = f.SeEncontro
            claveBuscada = Trim(f.claveBuscada)

            If encontrado Then
                Limpiar()
                ediNuevo = False
                Editando = False
                indice = claveBuscada
                PonerDatos()
            End If
            frmUsuarios_Activated(Me, Nothing)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try
    End Sub

    Private Sub PonerDatos()
        Dim pedido As DataTable = cnn.getConsulta("SELECT * FROM PedidosClientes WHERE Codigo=" & indice)
        Dim detalle As DataTable = cnn.getConsulta("SELECT * FROM DetallePedidosClientes WHERE Pedido=" & indice)
        Dim row As DataRow = pedido.Rows.Item(0)
        'If Not CBool(row.Item("Activo")) Then
        '    If MessageBoxEx.Show("El usuario está desactivado ¿Desea activarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '        cnn.setConsulta("UPDATE Usuarios SET Activo=1 WHERE Codigo=" & indice)
        '    Else
        '        Exit Sub
        '    End If
        'End If
        txtCodigo.Text = indice
        txtCodCliente.Text = row.Item("Cliente")
        txtFecha.Text = row.Item("Fecha")
        txtTotal.Text = row.Item("Total")
        txtPagado.Text = row.Item("Pagado")
        txtSaldo.Text = txtTotal.Text - txtPagado.Text
        chkEntregado.Checked = row.Item("Entregado")
        For Each row In detalle.Rows
            Dim pro As DataTable = cnn.getConsulta("SELECT Productos.Cod,Productos.Estilo,Productos.Marca,Productos.Talla,Productos.Color,Productos.Precio,Proveedores.Nombre FROM Productos INNER JOIN PRoveedores ON Productos.Proveedor=Proveedores.Codigo WHERE Productos.Codigo=" & row.Item("Producto"))
            Dim detalleProductos As DataRow = pro.Rows.Item(0)

            Dim tallas As String() = detalleProductos.Item("Talla").ToString.Split(";")

            Dim clmTalla As New DataGridViewComboBoxCell
            For Each talla As String In tallas
                clmTalla.Items.Add(talla)
            Next
            clmTalla.Value = row.Item("Talla")
            dgrDetalle.Rows.Add()

            Dim dgrRow As DataGridViewRow = dgrDetalle.Rows(dgrDetalle.Rows.GetLastRow(DataGridViewElementStates.Displayed))

            dgrRow.Cells("Codigo").Value = row.Item("Producto")
            dgrRow.Cells("Producto").Value = detalleProductos.Item("Cod")
            dgrRow.Cells("Proveedor").Value = detalleProductos.Item("Nombre")
            dgrRow.Cells("Talla") = clmTalla
            dgrRow.Cells("Estilo").Value = detalleProductos.Item("Estilo")
            dgrRow.Cells("Color").Value = detalleProductos.Item("Color")
            dgrRow.Cells("Producto").Value = detalleProductos.Item("Cod")
            'dgrRow.Cells("Cantidad").Value = row.Item("Cantidad")
            dgrRow.Cells("Entregado").Value = row.Item("Entregado")
            dgrRow.Cells("Precio").Value = FormatCurrency(detalleProductos.Item("Precio"), 2)

            actualizarTotal()
            seleccionarTalla(dgrRow.Index)

            If (row.Item("Activo") = 0) Then
                For Each cell As DataGridViewCell In dgrRow.Cells
                    Dim estilo As New DataGridViewCellStyle()
                    estilo.BackColor = Drawing.Color.Red
                    estilo.ForeColor = Drawing.Color.White
                    cell.Style = estilo
                    cell.ReadOnly = True
                Next
            Else
                'If dgrRow.Cells("Entregado").Value = True Then
                '    Dim inventario As DataTable = cnn.getConsulta("SELECT Existencia FROM Inventario WHERE Producto=" & dgrRow.Cells("Codigo").Value & " AND Talla=" & dgrRow.Cells("Talla").Value)

                '    cnn.setConsulta("UPDATE Inventario SET Existencia=" & (inventario.Rows(0).Item(0) + 1) & " WHERE Producto=" & dgrRow.Cells("Codigo").Value & " AND Talla=" & dgrRow.Cells("Talla").Value)
                'End If
            End If

            
        Next

        For Each row1 As DataGridViewRow In dgrDetalle.Rows
            If row1.Cells("Entregado").Value = False Then
                chkEntregado.Checked = False
                Exit Sub
            End If
            chkEntregado.Checked = True
        Next

        If chkEntregado.Checked Then
            dgrDetalle.ReadOnly = True
        End If

        txtCodCliente.Enabled = False
        If chkEntregado.Checked Then
            cmdMas.Enabled = False
            cmdMenos.Enabled = False
            If txtSaldo.Text = 0 Then
                cmdPagar.Enabled = False
            End If
        End If
    End Sub

    Public Sub Eliminar()
        'If MessageBoxEx.Show("¿Está seguro que desea eliminar al usuario?" & vbNewLine & "Sí realiza la operación el usuario " & _
        '                  "pasará a un estado inactivo y no podrá iniciar sesión.", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        '    cnn.setConsulta("UPDATE Usuarios SET Activo=0 WHERE Codigo=" & txtCodigo.Text)
        '    Limpiar()
        '    ediNuevo = False
        '    Editando = False
        '    frmUsuarios_Activated(Me, Nothing)
        'End If
    End Sub

    Public Sub Cancelar()
        Limpiar()
        ediNuevo = False
        Editando = False
        frmUsuarios_Activated(Me, Nothing)
    End Sub

    Public Sub Aceptar()
        dgrDetalle.EndEdit()
        If txtCodCliente.Text = "" Or txtNombreCliente.Text = "" Then
            MessageBoxEx.Show("Debe selecionar un cliente para la venta", "Error", MessageBoxButtons.OK)
            txtCodCliente.Focus()
            Exit Sub
        End If
        If dgrDetalle.Rows.Count = 0 Then
            MessageBoxEx.Show("No ha agregado ningún producto a la lista", "Error", MessageBoxButtons.OK)
            dgrDetalle.Focus()
            Exit Sub
        End If
        Dim codigo As Integer
        Dim dt As DataTable
        If ediNuevo Then
            cnn.setConsulta("INSERT INTO PedidosClientes (Cliente,Fecha,Total,Pagado,Entregado,Activo) VALUES (" & txtCodCliente.Text & ",'" & txtFecha.Text & "'," & txtTotal.Text & "," & txtPagado.Text & "," & CInt(chkEntregado.Checked) & ",1)")
            dt = cnn.getConsulta("SELECT MAX(Codigo) FROM PedidosClientes")
            codigo = dt.Rows(0).Item(0)
        ElseIf Editando Then
            cnn.setConsulta("UPDATE PedidosClientes SET Cliente=" & txtCodCliente.Text & ",Fecha='" & txtFecha.Text & "',Total=" & txtTotal.Text & ",Pagado=" & txtPagado.Text & ",Entregado=" & CInt(chkEntregado.Checked) & " WHERE Codigo=" & txtCodigo.Text)
            cnn.setConsulta("DELETE FROM DetallePedidosClientes WHERE Pedido=" & txtCodigo.Text)
            codigo = txtCodigo.Text
        End If
        Dim producto As Integer
        Dim estadoPedido = 0, recibido = 0, entregado As Integer = 0
        Dim talla, precio As Double
        Dim activo As Integer = 0
        For i As Integer = 0 To dgrDetalle.Rows.Count - 1
            If dgrDetalle.Item(0, i).Style.BackColor = Red Then
                activo = 0
            Else
                activo = 1
            End If
            producto = dgrDetalle.Item("Codigo", i).Value
            If dgrDetalle.Item("Recibido", i).Value Then
                recibido = 1
            End If
            If dgrDetalle.Item("Entregado", i).Value Then
                entregado = 1
            End If
            talla = dgrDetalle.Item("Talla", i).Value
            precio = dgrDetalle.Item("Precio", i).Value
            estadoPedido = 0
            dt = cnn.getConsulta("SELECT Existencia FROM Inventario WHERE Producto=" & producto & " AND Talla=" & talla)
            If dt.Rows(0).Item(0) > 0 Then
                estadoPedido = 1
                recibido = 1
            End If
            cnn.setConsulta("INSERT INTO DetallePedidosClientes VALUES (" & i & "," & codigo & "," & producto & ",'" & talla & "'," & CInt(estadoPedido) & "," & CInt(recibido) & "," & CInt(entregado) & "," & precio & "," & activo & ")")
            If entregado = 1 Then
                cnn.setConsulta("UPDATE Inventario SET Existencia=" & (dt.Rows(0).Item(0) - 1) & " WHERE Producto=" & producto & " AND Talla=" & talla)
            End If
        Next
        Cancelar()
        actualizarNotas()
    End Sub

    Private Sub actualizarNotas()
        lvNotas.Items.Clear()
        Dim dt As DataTable = cnn.getConsulta("SELECT PedidosClientes.Codigo, Clientes.Nombre, PedidosClientes.Fecha,PedidosClientes.Total FROM PedidosClientes INNER JOIN Clientes ON PedidosClientes.Cliente=Clientes.Codigo WHERE PedidosClientes.Entregado=0 AND PedidosClientes.Activo=1")
        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows
                lvNotas.Items.Add(row.Item("Codigo") & " -" & row.Item("Nombre") & " - " & row.Item("Fecha") & " - " & FormatCurrency(row.Item("Total"), 2))
            Next
        End If
    End Sub

    Private Sub cmdBuscarCliente_Click(sender As Object, e As EventArgs) Handles cmdBuscarCliente.Click
        Dim encontrado As Boolean
        Dim claveBuscada As String
        Dim f As frmBuscar
        f = New frmBuscar
        Try
            With f
                .Text = "Pantalla de Búsqueda de Clientes"
                .dgrBuscar.Rows.Clear()
                .dgrBuscar.Columns.Clear()
                .dgrBuscar.Columns.Add("Codigo", "Codigo")
                .dgrBuscar.Columns.Add("Nombre", "Nombre")
                .dgrBuscar.Columns.Add("Nombre", "Telefono")
                .dgrBuscar.Columns.Add("Nombre", "Celular")
                .dgrBuscar.Columns.Add("Nombre", "Facebook")
            End With
            Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Clientes")
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows
                    f.dgrBuscar.Rows.Add(row.Item("Codigo"), row.Item("Nombre"), row.Item("Telefono"), row.Item("Celular"), row.Item("Fb"))
                    If Not CBool(row.Item("Activo")) Then
                        For Each cell As DataGridViewCell In f.dgrBuscar.Rows(f.dgrBuscar.Rows.Count - 1).Cells
                            Dim estilo As New DataGridViewCellStyle()
                            estilo.BackColor = Drawing.Color.Red
                            estilo.ForeColor = Drawing.Color.White
                            cell.Style = estilo
                        Next
                    End If
                Next
            End If
            f.ShowDialog(Me)
            encontrado = f.SeEncontro
            claveBuscada = Trim(f.claveBuscada)

            If encontrado Then
                txtCodCliente.Text = claveBuscada
            End If
            frmUsuarios_Activated(Me, Nothing)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try
    End Sub

    Private Sub txtCodCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged
        If txtCodCliente.Text <> "" Then
            Dim dt As DataTable = cnn.getConsulta("SELECT Nombre FROM Clientes WHERE Codigo=" & txtCodCliente.Text)
            If Not IsNothing(dt) Then
                txtNombreCliente.Text = dt.Rows(0).Item("Nombre")
                Exit Sub
            End If
        End If
        txtNombreCliente.Text = ""
    End Sub

    Private Sub txtNombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCliente.TextChanged
        If txtNombreCliente.Text <> "" Then
            Dim dt As DataTable = cnn.getConsulta("SELECT Codigo FROM Clientes WHERE Nombre='" & txtNombreCliente.Text & "'")
            If Not IsNothing(dt) Then
                txtCodCliente.Text = dt.Rows(0).Item("Codigo")
                Exit Sub
            End If
        End If
        txtCodCliente.Text = ""
    End Sub

    Private Sub dgrDetalle_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgrDetalle.CellEndEdit
        If e.ColumnIndex = dgrDetalle.Columns("Talla").Index Then
            seleccionarTalla(e.RowIndex)
        ElseIf e.ColumnIndex = dgrDetalle.Columns("Entregado").Index Then
            For Each row As DataGridViewRow In dgrDetalle.Rows
                If row.Cells("Entregado").Value = False Then
                    chkEntregado.Checked = False
                    Exit Sub
                End If
                chkEntregado.Checked = True
            Next
        End If
    End Sub

    Private Sub dgrDetalle_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgrDetalle.RowsAdded
        If chkEntregado.Checked = False Then
            cmdCerrar.Enabled = True
        End If
    End Sub

    Private Sub dgrDetalle_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgrDetalle.RowsRemoved
        actualizarTotal()
    End Sub

    Private Sub dgrDetalle_SelectionChanged(sender As Object, e As EventArgs) Handles dgrDetalle.SelectionChanged
        If dgrDetalle.SelectedRows.Count = 1 Then
            If chkEntregado.Checked Then
                cmdMenos.Enabled = False
                cmdMas.Enabled = False
            Else
                cmdMenos.Enabled = True
                cmdMas.Enabled = True
            End If
            If txtCodigo.Text <> "" Then
                If dgrDetalle.SelectedRows.Item(0).Cells(0).Style.BackColor = Red Then
                    cmdCanjear.Enabled = False
                Else
                    cmdCanjear.Enabled = True
                End If
            End If

        End If
    End Sub

    Private Sub cmdMas_Click(sender As Object, e As EventArgs) Handles cmdMas.Click
        Dim encontrado As Boolean
        Dim claveBuscada As String
        Dim f As frmBuscar
        f = New frmBuscar
        Try
            With f
                .Text = "Pantalla de Búsqueda de Productos"
                .dgrBuscar.Rows.Clear()
                .dgrBuscar.Columns.Clear()
                .dgrBuscar.Columns.Add("Codigo", "No. Control")
                .dgrBuscar.Columns.Add("Nombre", "Página")
                .dgrBuscar.Columns.Add("Nombre", "Clave")
                .dgrBuscar.Columns.Add("Nombre", "Código")
                .dgrBuscar.Columns.Add("Nombre", "Estilo")
                .dgrBuscar.Columns.Add("Nombre", "Marca")
                .dgrBuscar.Columns.Add("Nombre", "Talla")
                .dgrBuscar.Columns.Add("Nombre", "Color")
                .dgrBuscar.Columns.Add("Nombre", "Precio")
                .dgrBuscar.Columns.Add("Nombre", "Costo")
                .dgrBuscar.Columns.Add("Nombre", "Proveedor")
            End With
            Dim dt As DataTable = cnn.getConsulta("SELECT Productos.Codigo,Productos.Pagina,Productos.Clave,Productos.Cod,Productos.Estilo,Productos.Marca,Productos.Talla,Productos.Color,Productos.Precio,Productos.Costo,Proveedores.Nombre,Productos.Activo FROM Productos INNER JOIN Proveedores ON Productos.Proveedor=Proveedores.Codigo WHERE Proveedores.Activo=1")
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows
                    f.dgrBuscar.Rows.Add(row.Item("Codigo"), row.Item("Pagina"), row.Item("Clave"), row.Item("Cod"), row.Item("Estilo"), row.Item("Marca"), row.Item("Talla"), row.Item("Color"), row.Item("Precio"), row.Item("Costo"), row.Item("Nombre"))
                    If Not CBool(row.Item("Activo")) Then
                        For Each cell As DataGridViewCell In f.dgrBuscar.Rows(f.dgrBuscar.Rows.Count - 1).Cells
                            Dim estilo As New DataGridViewCellStyle()
                            estilo.BackColor = Drawing.Color.Red
                            estilo.ForeColor = Drawing.Color.White
                            cell.Style = estilo
                        Next
                    End If
                Next
            End If
            f.ShowDialog(Me)
            encontrado = f.SeEncontro
            claveBuscada = Trim(f.claveBuscada)

            If encontrado Then
                dt = cnn.getConsulta("SELECT Productos.Codigo,Productos.Pagina,Productos.Clave,Productos.Cod,Productos.Estilo,Productos.Marca,Productos.Talla,Productos.Color,Productos.Precio,Productos.Costo,Proveedores.Nombre,Productos.Activo FROM Productos INNER JOIN Proveedores ON Productos.Proveedor=Proveedores.Codigo WHERE Productos.Activo=1 AND Productos.Codigo=" & claveBuscada)
                Dim row As DataRow = dt.Rows(0)

                Dim tallas As String() = row.Item("Talla").ToString.Split(";")

                Dim clmTalla As New DataGridViewComboBoxCell
                For Each talla As String In tallas
                    clmTalla.Items.Add(talla)
                Next
                clmTalla.Value = clmTalla.Items(0)
                dgrDetalle.Rows.Add()

                Dim dgrRow As DataGridViewRow = dgrDetalle.Rows(dgrDetalle.Rows.GetLastRow(DataGridViewElementStates.Displayed))

                dgrRow.Cells("Codigo").Value = row.Item("Codigo")
                dgrRow.Cells("Producto").Value = row.Item("Cod")
                dgrRow.Cells("Proveedor").Value = row.Item("Nombre")
                dgrRow.Cells("Talla") = clmTalla
                dgrRow.Cells("Estilo").Value = row.Item("Estilo")
                dgrRow.Cells("Color").Value = row.Item("Color")
                dgrRow.Cells("Producto").Value = row.Item("Cod")
                dgrRow.Cells("Entregado").Value = False
                dgrRow.Cells("Precio").Value = FormatCurrency(row.Item("Precio"), 2)

                actualizarTotal()
                seleccionarTalla(dgrRow.Index)
            End If
                frmUsuarios_Activated(Me, Nothing)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try
    End Sub

    Private Sub cmdMenos_Click(sender As Object, e As EventArgs) Handles cmdMenos.Click
        If dgrDetalle.SelectedRows.Count = 1 Then
            If MessageBoxEx.Show("¿Desea borrar de la nota el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                dgrDetalle.Rows.Remove(dgrDetalle.SelectedRows(0))
            End If
        Else
            MessageBoxEx.Show("Se debe seleccionar el producto a borrar de la nota", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub actualizarTotal()
        Dim total As Double = 0
        For Each row As DataGridViewRow In dgrDetalle.Rows
            Dim estilo As DataGridViewCellStyle = row.Cells("Precio").Style
            If estilo.BackColor <> Red Then
                Dim precio As Double = IIf(IsNumeric(row.Cells("Precio").Value), row.Cells("Precio").Value, 0)
                total += precio
            End If
        Next
        txtTotal.Text = FormatCurrency(total, 2)
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        If txtTotal.Text <> "" And txtPagado.Text <> "" Then
            txtSaldo.Text = FormatCurrency(txtTotal.Text - txtPagado.Text, 2)
        End If
    End Sub

    Private Sub seleccionarTalla(ByVal codigo As Integer)
        Dim clmTalla As DataGridViewComboBoxCell
        Dim dgrRow As DataGridViewRow = dgrDetalle.Rows(codigo)
        clmTalla = dgrRow.Cells("Talla")

        Dim inventario As DataTable = cnn.getConsulta("SELECT * FROM Inventario WHERE Producto=" & dgrRow.Cells("Codigo").Value & " AND Talla=" & clmTalla.Value)

        Dim cantidad As Integer = inventario.Rows(0).Item("Existencia")
        For Each row As DataGridViewRow In dgrDetalle.Rows
            If row.Cells("Codigo").Value = dgrRow.Cells("Codigo").Value Then
                If cantidad > 0 Then
                    row.Cells("Recibido").Value = True
                Else
                    If row.Cells("Entregado").Value = False Then
                        row.Cells("Recibido").Value = False
                    Else
                        row.Cells("Recibido").Value = True
                    End If
                End If
                If row.Cells("Recibido").Value = False Then
                    row.Cells("Entregado").ReadOnly = True
                Else
                    row.Cells("Entregado").ReadOnly = False
                End If
                    cantidad -= 1
            End If
        Next
    End Sub

    Private Sub lvNotas_ItemActivate(sender As Object, e As EventArgs) Handles lvNotas.ItemActivate
        Dim codigo As Integer
        codigo = lvNotas.SelectedItems.Item(0).Text.Substring(0, (lvNotas.SelectedItems.Item(0).Text.IndexOf("-") - 1))
        indice = codigo
        Limpiar()
        ediNuevo = False
        Editando = False
        PonerDatos()
        frmUsuarios_Activated(Me, Nothing)
    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        If Not chkEntregado.Checked Then
            If CDbl(txtTotal.Text) > CDbl(txtSaldo.Text) Then
                MessageBoxEx.Show("Todavía no se ha terminado de pagar por lo tanto no se puede cerrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBoxEx.Show("No se han entregado todos los zapatos" & vbNewLine & "¿Desea marcarlos todos como entregados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For Each row As DataGridViewRow In dgrDetalle.Rows
                    Dim codigo As Integer
                    Dim talla As Double
                    Dim cantidad As Integer = 0

                    codigo = row.Cells("Codigo").Value
                    talla = row.Cells("Talla").Value

                    Dim dt As DataTable = cnn.getConsulta("SELECT Existencia FROM Inventario WHERE Producto=" & codigo & " AND Talla=" & talla)
                    For Each inRow As DataGridViewRow In dgrDetalle.Rows
                        If inRow.Cells("Codigo").Value = codigo Then
                            cantidad += 1
                        End If
                    Next
                    If dt.Rows(0).Item(0) < cantidad Then
                        MessageBoxEx.Show("No se puede cerrar el pedido ya que no hay suficientes productos en el inventario para entregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If

                    row.Cells("Entregado").Value = True
                Next
                chkEntregado.Checked = True
            End If
        End If
        Aceptar()
    End Sub

    Private Sub cmdCanjear_Click(sender As Object, e As EventArgs) Handles cmdCanjear.Click
        If dgrDetalle.SelectedRows.Count = 1 Then
            Dim row As DataGridViewRow = dgrDetalle.SelectedRows(0)
            Dim codigo As Integer
            Dim talla, precio As Double
            Dim motivo As String = InputBox("Ingrese el motivo por el cual se está canjeando por un vale", "Confirmación", "Necesitaba una talla diferente")

            If motivo = "" Then
                MessageBoxEx.Show("Se ha cancelado el canje", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            codigo = row.Cells("Codigo").Value
            talla = row.Cells("Talla").Value
            precio = row.Cells("Precio").Value


            cnn.setConsulta("INSERT INTO Vales (Cliente,Cantidad,Motivo,PedidoGenerado,Usado,Producto,Talla) VALUES (" & txtCodCliente.Text & "," & precio & ",'" & motivo & "'," & txtCodigo.Text & ",0," & codigo & "," & talla & ")")
            cnn.setConsulta("UPDATE DetallePedidosClientes SET Activo=0 WHERE Codigo=" & row.Index & " AND Pedido=" & txtCodigo.Text & " AND Producto=" & codigo)
            If row.Cells("Entregado").Value Then
                Dim dt As DataTable = cnn.getConsulta("SELECT Existencia FROM Inventario WHERE Producto=" & codigo & " AND Talla=" & talla)
                cnn.setConsulta("UPDATE Inventario SET Existencia=" & (dt.Rows(0).Item(0) + 1) & " WHERE Producto=" & codigo & " AND Talla=" & talla)
                'dt = cnn.getConsulta("SELECT MAX(Codigo) FROM Vales")
            End If

            For Each cell As DataGridViewCell In row.Cells
                Dim estilo As New DataGridViewCellStyle()
                estilo.BackColor = Drawing.Color.Red
                estilo.ForeColor = Drawing.Color.White
                cell.Style = estilo
                cell.ReadOnly = True
            Next
        Else
            MessageBoxEx.Show("Se debe seleccionar el producto a canjear por un vale", "Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub cmdPagar_Click(sender As Object, e As EventArgs) Handles cmdPagar.Click
        If IsNumeric(txtTotal.Text) Then
            Dim guardado As Boolean = True
            If txtCodigo.Text = "" Then
                If MessageBoxEx.Show("El pedido no ha sido guardado por lo tanto no se pueden usar los vales" & vbNewLine & "¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
                guardado = False
            End If
            Dim frm As New frmPagar
            Dim pagado As Double = frm.ShowDialog(guardado, txtTotal.Text, txtPagado.Text, txtCodCliente.Text, txtCodigo.Text)
            If pagado > 0 Then
                txtPagado.Text = pagado
            End If
        Else
            MessageBoxEx.Show("No se ha agregado ningún producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub
End Class