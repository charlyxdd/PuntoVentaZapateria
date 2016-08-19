Imports DevComponents.DotNetBar

Public Class frmProveedores
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
        txtNombre.Text = ""
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
        Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Permisos WHERE Tipo=" & tipoUser & " AND Modulo=4")
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
                .Text = "Pantalla de Búsqueda de Proveedores"
                .dgrBuscar.Rows.Clear()
                .dgrBuscar.Columns.Clear()
                .dgrBuscar.Columns.Add("Codigo", "Codigo")
                .dgrBuscar.Columns.Add("Nombre", "Nombre")
            End With
            Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Proveedores")
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
        Dim user As DataTable = cnn.getConsulta("SELECT * FROM Proveedores WHERE Codigo=" & indice)
        Dim row As DataRow = user.Rows.Item(0)
        If Not CBool(row.Item("Activo")) Then
            If MessageBoxEx.Show("El proveedor está desactivado ¿Desea activarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cnn.setConsulta("UPDATE Proveedores SET Activo=1 WHERE Codigo=" & indice)
            Else
                Exit Sub
            End If
        End If
        txtCodigo.Text = indice
        txtNombre.Text = row.Item("Nombre")

    End Sub

    Public Sub Eliminar()
        If MessageBoxEx.Show("¿Está seguro que desea eliminar al proveedore?" & vbNewLine & "Sí realiza la operación el proveedor " & _
                          "pasará a un estado inactivo.", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cnn.setConsulta("UPDATE Proveedores SET Activo=0 WHERE Codigo=" & txtCodigo.Text)
            'cnn.setConsulta("UPDATE Productos SET Activo=0 WHERE Proveedor=" & txtCodigo.Text)
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
        If txtNombre.Text = "" Then
            MessageBoxEx.Show("Debe ingresar un nombre al proveedor", "Error", MessageBoxButtons.OK)
            txtNombre.Focus()
            Exit Sub
        End If
        If ediNuevo Then
            cnn.setConsulta("INSERT INTO Proveedores (Nombre,Activo) VALUES ('" & txtNombre.Text & "',1)")
        ElseIf Editando Then
            cnn.setConsulta("UPDATE Proveedores SET Nombre='" & txtNombre.Text & "' WHERE Codigo=" & txtCodigo.Text)
        End If
        Cancelar()
    End Sub
End Class