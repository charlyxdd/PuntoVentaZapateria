Imports DevComponents.DotNetBar

Public Class frmProductos
    Dim ediNuevo, Editando As Boolean
    Dim pass, indice As String
    Dim cnn As Conexion
    Dim agregarP, editarP, eliminarP, consultaP As Boolean
    Dim tipo As Integer

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
    End Sub

    Private Sub Limpiar()
        txtCodigo.Text = ""
        txtPagina.Text = ""
        txtClave.Text = ""
        txtCod.Text = ""
        txtEstilo.Text = ""
        txtMarca.Text = ""
        txtTalla.Text = ""
        txtColor.Text = ""
        txtPrecio.Text = ""
        txtCosto.Text = ""
        txtExistencia.Text = "0"
        txtCodProv.Text = ""
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
        Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Permisos WHERE Tipo=" & tipoUser & " AND Modulo=5")
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
                            estilo.BackColor = Color.Red
                            estilo.ForeColor = Color.White
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
        Dim user As DataTable = cnn.getConsulta("SELECT * FROM Productos WHERE Codigo=" & indice)
        Dim inventario As DataTable = cnn.getConsulta("SELECT SUM(Existencia) FROM Inventario WHERE Producto=" & indice)
        Dim row As DataRow = user.Rows.Item(0)
        If Not CBool(row.Item("Activo")) Then
            If MessageBoxEx.Show("El producto está desactivado ¿Desea activarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cnn.setConsulta("UPDATE Productos SET Activo=1 WHERE Codigo=" & indice)
            Else
                Exit Sub
            End If
        End If
        txtCodigo.Text = indice
        txtPagina.Text = row.Item("Pagina")
        txtClave.Text = row.Item("Clave")
        txtCod.Text = row.Item("Cod")
        txtEstilo.Text = row.Item("Estilo")
        txtMarca.Text = row.Item("Marca")
        txtTalla.Text = row.Item("Talla")
        txtColor.Text = row.Item("Color")
        txtPrecio.Text = FormatCurrency(row.Item("Precio"), 2)
        txtCosto.Text = FormatCurrency(row.Item("Costo"), 2)
        txtExistencia.Text = inventario.Rows(0).Item(0)
        txtCodProv.Text = row.Item("Proveedor")
    End Sub

    Public Sub Eliminar()
        If MessageBoxEx.Show("¿Está seguro que desea eliminar al producto?" & vbNewLine & "Sí realiza la operación el producto " & _
                          "pasará a un estado inactivo.", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cnn.setConsulta("UPDATE Productos SET Activo=0 WHERE Codigo=" & txtCodigo.Text)
            Limpiar()
            ediNuevo = False
            Editando = False
            frmUsuarios_Activated(Me, Nothing)
        End If
    End Sub

    Public Sub Cancelar()
        Limpiar()
        ediNuevo = False
        Editando = False
        frmUsuarios_Activated(Me, Nothing)
    End Sub

    Public Sub Aceptar()
        If txtCod.Text = "" Then
            MessageBoxEx.Show("Debe ingresar un código al producto", "Error", MessageBoxButtons.OK)
            txtCod.Focus()
            Exit Sub
        End If
        If txtTalla.Text = "" Then
            MessageBoxEx.Show("Debe ingresar las posibles tallas", "Error", MessageBoxButtons.OK)
            txtTalla.Focus()
            Exit Sub
        End If
        If txtColor.Text = "" Then
            MessageBoxEx.Show("Debe ingresar los posibles colores", "Error", MessageBoxButtons.OK)
            txtColor.Focus()
            Exit Sub
        End If
        If txtPrecio.Text = "" Then
            MessageBoxEx.Show("Debe ingresar el precio al producto", "Error", MessageBoxButtons.OK)
            txtPrecio.Focus()
            Exit Sub
        End If
        If txtCosto.Text = "" Then
            MessageBoxEx.Show("Debe ingresar el costo al producto", "Error", MessageBoxButtons.OK)
            txtCosto.Focus()
            Exit Sub
        End If
        If txtCodProv.Text = "" Or txtNombreProv.Text = "" Then
            MessageBoxEx.Show("Debe seleccionar un proveedor del producto", "Error", MessageBoxButtons.OK)
            cmdBuscaProv.Focus()
            Exit Sub
        End If
        Dim codigo As Integer
        If ediNuevo Then
            cnn.setConsulta("INSERT INTO Productos (Pagina,Clave,Cod,Estilo,Marca,Talla,Color,Precio,Costo,Proveedor,Activo) VALUES (" & txtPagina.Text & ",'" & txtClave.Text & "','" & txtCod.Text & "','" & txtEstilo.Text & "','" & txtMarca.Text & "','" & txtTalla.Text & "','" & txtColor.Text & "'," & txtPrecio.Text & "," & txtCosto.Text & "," & txtCodProv.Text & ",1)")
            Dim dt As DataTable
            dt = cnn.getConsulta("SELECT Max(Codigo) AS Codigo FROM Productos")
            codigo = dt.Rows(0).Item(0)
        ElseIf Editando Then
            cnn.setConsulta("UPDATE Productos SET Pagina=" & txtPagina.Text & ",Clave='" & txtClave.Text & "',Cod='" & txtCod.Text & "',Estilo='" & txtEstilo.Text & "',Marca='" & txtMarca.Text & "',Talla='" & txtTalla.Text & "',Color='" & txtColor.Text & "',Precio=" & txtPrecio.Text & ",Costo=" & txtCosto.Text & ",Proveedor=" & txtCodProv.Text & " WHERE Codigo=" & txtCodigo.Text)
            codigo = indice
        End If
        Dim tallas As String() = txtTalla.Text.Split(";")
        For Each talla As String In tallas
            If IsNumeric(talla) Then
                Dim dt As DataTable = cnn.getConsulta("SELECT Existencia FROM Inventario WHERE Producto=" & codigo & " AND Talla=" & talla)
                If IsNothing(dt) Then
                    cnn.setConsulta("INSERT INTO Inventario VALUES (" & codigo & "," & talla & ",0)")
                End If
            End If
        Next
        Cancelar()
    End Sub

    Private Sub cmdBuscaProv_Click(sender As Object, e As EventArgs) Handles cmdBuscaProv.Click
        Dim encontrado As Boolean
        Dim claveBuscada As String
        Dim f As frmBuscar
        f = New frmBuscar
        Try
            With f
                .Text = "Pantalla de Búsqueda de Proveedores"
                .dgrBuscar.Rows.Clear()
                .dgrBuscar.Columns.Clear()
                .dgrBuscar.Columns.Add("Codigo", "Codigo")
                .dgrBuscar.Columns.Add("Nombre", "Nombre")
            End With
            Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Proveedores WHERE Activo=1")
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows
                    f.dgrBuscar.Rows.Add(row.Item("Codigo"), row.Item("Nombre"))
                    If Not CBool(row.Item("Activo")) Then
                        For Each cell As DataGridViewCell In f.dgrBuscar.Rows(f.dgrBuscar.Rows.Count - 1).Cells
                            Dim estilo As New DataGridViewCellStyle()
                            estilo.BackColor = Color.Red
                            estilo.ForeColor = Color.White
                            cell.Style = estilo
                        Next
                    End If
                Next
            End If
            f.ShowDialog(Me)
            encontrado = f.SeEncontro
            claveBuscada = Trim(f.claveBuscada)

            If encontrado Then
                txtCodProv.Text = claveBuscada
            End If
            'frmUsuarios_Activated(Me, Nothing)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try
    End Sub

    Private Sub txtCodProv_TextChanged(sender As Object, e As EventArgs) Handles txtCodProv.TextChanged
        If txtCodProv.Text <> "" Then
            Dim dt As DataTable = cnn.getConsulta("SELECT Nombre FROM Proveedores WHERE Codigo=" & txtCodProv.Text)
            If Not IsNothing(dt) Then
                txtNombreProv.Text = dt.Rows(0).Item("Nombre")
                Exit Sub
            End If
        End If
        txtNombreProv.Text = ""
    End Sub

    Private Sub txtNombreProv_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProv.TextChanged
        If txtNombreProv.Text <> "" Then
            Dim dt As DataTable = cnn.getConsulta("SELECT Codigo FROM Proveedores WHERE Nombre='" & txtNombreProv.Text & "'")
            If Not IsNothing(dt) Then
                txtCodProv.Text = dt.Rows(0).Item("Codigo")
                Exit Sub
            End If
        End If
        txtCodProv.Text = ""
    End Sub

    Private Sub txtTalla_TextChanged(sender As Object, e As EventArgs) Handles txtTalla.LostFocus
        If txtTalla.Text <> "" Then
            Dim enteros As Boolean = False
            If Not IsNumeric(txtTalla.Text.Substring(0, 1)) Then
                If txtTalla.Text.Substring(0, 1) <> "!" Then
                    txtTalla.Text = ""
                    Beep()
                    Exit Sub
                Else
                    enteros = True
                End If
            End If
            Dim indice As Integer = txtTalla.Text.IndexOf("-")
            If indice <> -1 Then
                Dim antes, despues As String
                Dim s As Double
                If enteros Then
                    antes = txtTalla.Text.Substring(1, indice - 1)
                    s = 1
                Else
                    antes = txtTalla.Text.Substring(0, indice)
                    s = 0.5
                End If
                despues = txtTalla.Text.Substring(indice + 1)
                Dim texto As String = ""
                For i As Double = antes To despues Step s
                    texto = texto & i & ";"
                Next
                txtTalla.Text = texto
            Else
                If Not IsNumeric(txtTalla.Text) Then
                    txtTalla.Text = ""
                    Beep()
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged, txtCosto.TextChanged, txtPagina.TextChanged
        If sender.text <> "" Then
            If Not IsNumeric(sender.text) Then
                Beep()
                sender.text = ""
            End If
        End If
    End Sub
End Class