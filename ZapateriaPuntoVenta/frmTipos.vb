Imports DevComponents.DotNetBar
Public Class frmTipos
    Dim ediNuevo, Editando As Boolean
    Dim indice As String
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
        actualizarGrid(0)
        permisos()
    End Sub

    Private Sub Limpiar()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        Marco.Enabled = False
        actualizarGrid(0)
    End Sub

    Private Sub actualizarGrid(ByVal i As Integer)
        If i > 0 Then
            Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Permisos WHERE Tipo=" & i)
            Dim modulos As DataTable

            dgrPermisos.Rows.Clear()

            If Not IsNothing(dt) Then
                If dt.Rows.Count > 0 Then
                    For Each row As DataRow In dt.Rows
                        modulos = cnn.getConsulta("SELECT Modulo FROM Modulos WHERE Codigo=" & row.Item("Modulo"))
                        Dim nombre As String = modulos.Rows.Item(0).Item("Modulo")
                        dgrPermisos.Rows.Add(nombre, row.Item("Consulta"), row.Item("Agregar"), row.Item("Editar"), row.Item("Eliminar"))
                    Next
                End If
            End If
        Else
            Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Modulos")

            dgrPermisos.Rows.Clear()

            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows
                    dgrPermisos.Rows.Add(row.Item("Modulo"), 0, 0, 0, 0)
                Next
            End If
        End If
    End Sub

    Public Sub Nuevo()
        Limpiar()
        ediNuevo = True
        Editando = False
        Marco.Enabled = True
        frmUsuarios_Activated(Me, Nothing)
    End Sub

    Private Sub permisos()
        Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Permisos WHERE Tipo=" & tipoUser & " AND Modulo=1")
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
                .Text = "Pantalla de Búsqueda de Tipos de Usuarios"
                .dgrBuscar.Rows.Clear()
                .dgrBuscar.Columns.Clear()
                .dgrBuscar.Columns.Add("Codigo", "Codigo")
                .dgrBuscar.Columns.Add("Nombre", "Nombre")
            End With
            Dim dt As DataTable = cnn.getConsulta("SELECT Codigo, Nombre, Activo FROM Tipos WHERE Nombre<>'master' AND Nombre<>'Personalizado'")
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
                Editando = False
                ediNuevo = False
                indice = claveBuscada
                PonerDatos()
            End If
            frmUsuarios_Activated(Me, Nothing)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try
    End Sub

    Private Sub PonerDatos()
        Dim user As DataTable = cnn.getConsulta("SELECT * FROM Tipos WHERE Codigo=" & indice)
        Dim row As DataRow = user.Rows.Item(0)
        If Not CBool(row.Item("Activo")) Then
            If MessageBoxEx.Show("El tipo de usuario está desactivado ¿Desea activarlo?" & vbNewLine & "Todos los usuarios con este tipo de cuenta serán activados", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cnn.setConsulta("UPDATE Usuarios SET Activo=1 WHERE Tipo=" & indice)
                cnn.setConsulta("UPDATE Tipos SET Activo=1 WHERE Codigo=" & indice)
            Else
                Exit Sub
            End If
        End If
        txtCodigo.Text = indice
        txtNombre.Text = row.Item("Nombre")
        actualizarGrid(indice)
    End Sub

    Public Sub Eliminar()
        If MessageBoxEx.Show("Al realizar la operación el tipo de cuenta pasará a un estado inactivo" & vbNewLine & _
                             "y por lo tanto todos los usuarios que estén asignados a este tipo serán deshabilitados" & vbNewLine _
                             & "¿Está seguro(a) que desea hacer la operación", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cnn.setConsulta("UPDATE Usuarios SET Activo=0 WHERE Tipo=" & txtCodigo.Text)
            cnn.setConsulta("UPDATE Tipos SET Activo=0 WHERE Codigo=" & txtCodigo.Text)
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
        indice = 0
        frmUsuarios_Activated(Me, Nothing)
    End Sub

    Private Sub dgrPermisos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgrPermisos.CellValueChanged
        If dgrPermisos.Rows.Count > 0 Then
            If e.ColumnIndex = 1 Then
                If dgrPermisos.Item(e.ColumnIndex, e.RowIndex).Value = False Then
                    dgrPermisos.Item(1, e.RowIndex).Value = False
                    dgrPermisos.Item(2, e.RowIndex).Value = False
                    dgrPermisos.Item(3, e.RowIndex).Value = False
                    dgrPermisos.Item(4, e.RowIndex).Value = False
                End If
            Else
                If dgrPermisos.Item(e.ColumnIndex, e.RowIndex).Value = True Then
                    dgrPermisos.Item(1, e.RowIndex).Value = True
                End If
            End If
        End If
    End Sub

    Public Sub Aceptar()
        If txtNombre.Text = "" Then
            MessageBoxEx.Show("Debe ingresar un nombre para el tipo de cuenta", "Error", MessageBoxButtons.OK)
            txtNombre.Focus()
            Exit Sub
        End If
        Dim dt As DataTable
        If ediNuevo Then
            dt = cnn.getConsulta("SELECT * FROM Tipos WHERE Nombre='" & txtNombre.Text & "'")
        Else
            dt = cnn.getConsulta("SELECT * FROM Tipos WHERE Nombre='" & txtNombre.Text & "' AND Codigo<>" & indice)
        End If
        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                MessageBoxEx.Show("El tipo de cuenta ya existe", "Error", MessageBoxButtons.OK)
                txtNombre.Focus()
                Exit Sub
            End If
        End If

        Dim tipos As DataTable
        If ediNuevo Then
            cnn.setConsulta("INSERT INTO Tipos (Nombre, Activo) VALUES('" & txtNombre.Text & "', 1)")
            tipos = cnn.getConsulta("SELECT Max(Codigo) FROM Tipos")
            Dim row As DataRow = tipos.Rows.Item(0)
            indice = row.Item(0)
        Else
            cnn.setConsulta("DELETE FROM Permisos WHERE Tipo=" & indice)
            cnn.setConsulta("UPDATE Tipos SET Nombre='" & txtNombre.Text & "' WHERE Codigo=" & indice)
        End If

        For i As Integer = 0 To dgrPermisos.Rows.Count - 1
            Dim modulos As DataTable = cnn.getConsulta("SELECT Codigo FROM Modulos WHERE Modulo='" & dgrPermisos.Item(0, i).Value & "'")
            Dim modulo As Integer
            If Not IsNothing(modulos) Then
                modulo = modulos.Rows.Item(0).Item(0)
            End If
            cnn.setConsulta("INSERT INTO Permisos VALUES (" & indice & "," & modulo & "," & CType(dgrPermisos.Item(1, i).Value, SqlDbType) & "," & CType(dgrPermisos.Item(2, i).Value, SqlDbType) & "," & CType(dgrPermisos.Item(3, i).Value, SqlDbType) & "," & CType(dgrPermisos.Item(4, i).Value, SqlDbType) & ")")
        Next
        Cancelar()
    End Sub
End Class