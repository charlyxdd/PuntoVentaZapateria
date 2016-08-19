Imports DevComponents.DotNetBar
'Imports System.IO
Public Class frmUsuarios
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
        'actualizarTipos()
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
        actualizarTipos()
        actualizarGrid(tipoUser)
        permisos()
    End Sub

    Private Sub Limpiar()
        txtCodigo.Text = ""
        txtNombre.Text = ""
        tipo = 0
        pass = ""
        actualizarTipos()
        Marco.Enabled = False
    End Sub

    Private Sub actualizarTipos()
        With cboTipos.Items
            .Clear()
            .Add("Personalizado")

            Dim dt As DataTable

            dt = cnn.getConsulta("SELECT Nombre FROM Tipos WHERE Nombre NOT LIKE 'Personalizado%' AND Nombre<>'Administrador' AND Activo=1")

            cboTipos.SelectedIndex = 0

            If Not IsNothing(dt) Then
                Dim nombre As String
                For Each row As DataRow In dt.Rows
                    nombre = row.Item("Nombre")
                    .Add(nombre)
                Next
                For i As Integer = 0 To cboTipos.Items.Count - 1
                    If cboTipos.Items.Item(i) = nombre Then
                        cboTipos.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
        End With
    End Sub

    Private Sub actualizarGrid(tipo As Integer)
        Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Permisos WHERE Tipo=" & tipo)
        Dim modulos As DataTable

        dgrPermisos.Rows.Clear()

        If Not IsNothing(dt) Then
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    modulos = cnn.getConsulta("SELECT Modulo FROM Modulos WHERE Codigo=" & row.Item("Modulo"))
                    Dim nombre As String = modulos.Rows.Item(0).Item("Modulo")
                    dgrPermisos.Rows.Add(nombre, row.Item("Consulta"), CBool(row.Item("Agregar")), CBool(row.Item("Editar")), CBool(row.Item("Eliminar")))
                Next
            Else
                modulos = cnn.getConsulta("SELECT Modulo FROM Modulos")
                If Not IsNothing(modulos) Then
                    For Each row As DataRow In modulos.Rows
                        dgrPermisos.Rows.Add(row.Item("Modulo"), 0, 0, 0, 0)
                    Next
                End If
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

    Private Sub cboTipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipos.SelectedIndexChanged
        If cboTipos.SelectedIndex <> 0 Then
            Dim dt As DataTable = cnn.getConsulta("SELECT Codigo FROM Tipos WHERE Nombre='" & cboTipos.Items.Item(cboTipos.SelectedIndex) & "'")
            If Not IsNothing(dt) Then
                actualizarGrid(dt.Rows.Item(0).Item("Codigo"))
            End If
        End If
    End Sub

    Private Sub permisos()
        Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Permisos WHERE Tipo=" & tipoUser & " AND Modulo=2")
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
                .Text = "Pantalla de Búsqueda de Usuarios"
                .dgrBuscar.Rows.Clear()
                .dgrBuscar.Columns.Clear()
                .dgrBuscar.Columns.Add("Codigo", "Codigo")
                .dgrBuscar.Columns.Add("Nombre", "Nombre")
            End With
            Dim dt As DataTable = cnn.getConsulta("SELECT Codigo, Nombre, Activo FROM Usuarios WHERE Nombre<>'root'")
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
        Dim user As DataTable = cnn.getConsulta("SELECT * FROM Usuarios WHERE Codigo=" & indice)
        Dim row As DataRow = user.Rows.Item(0)
        If Not CBool(row.Item("Activo")) Then
            If MessageBoxEx.Show("El usuario está desactivado ¿Desea activarlo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cnn.setConsulta("UPDATE Usuarios SET Activo=1 WHERE Codigo=" & indice)
            Else
                Exit Sub
            End If
        End If
        txtCodigo.Text = indice
        txtNombre.Text = row.Item("Nombre")
        txtNombreC.Text = row.Item("NombreCompleto")
        pass = row.Item("Pass")
        tipo = row.Item("Tipo")
        actualizarGrid(row.Item("Tipo"))
        Dim tipos As DataTable = cnn.getConsulta("SELECT Nombre FROM Tipos WHERE Codigo=" & row.Item("Tipo"))
        row = tipos.Rows.Item(0)
        If row.Item("Nombre").ToString.Contains("Personalizado") Then
            cboTipos.SelectedIndex = 0
        Else
            For i As Integer = 0 To cboTipos.Items.Count - 1
                If cboTipos.Items.Item(i) = row.Item("Nombre") Then
                    cboTipos.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub Eliminar()
        If MessageBoxEx.Show("¿Está seguro que desea eliminar al usuario?" & vbNewLine & "Sí realiza la operación el usuario " & _
                          "pasará a un estado inactivo y no podrá iniciar sesión.", "Confirmación", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cnn.setConsulta("UPDATE Usuarios SET Activo=0 WHERE Codigo=" & txtCodigo.Text)
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
            MessageBoxEx.Show("Debe ingresar un nombre de usuario", "Error", MessageBoxButtons.OK)
            txtNombre.Focus()
            Exit Sub
        End If
        If txtNombreC.Text = "" Then
            MessageBoxEx.Show("Debe ingresar un nombre completo al usuario", "Error", MessageBoxButtons.OK)
            txtNombreC.Focus()
            Exit Sub
        End If
        If pass = "" Then
            MessageBoxEx.Show("No ha asignado una contraseña", "Error", MessageBoxButtons.OK)
            cmdCambiar.Focus()
            Exit Sub
        End If
        Dim dt As DataTable
        If ediNuevo Then
            dt = cnn.getConsulta("SELECT Nombre FROM Usuarios WHERE Nombre='" & txtNombre.Text & "'")
        Else
            dt = cnn.getConsulta("SELECT Nombre FROM Usuarios WHERE Nombre='" & txtNombre.Text & "' AND Codigo<>" & indice)
        End If
        If IsNothing(dt) Then
            Dim tipoNuevo As Integer
            Dim insertar As Boolean

            If cboTipos.SelectedIndex = 0 Then
                Dim tipos As DataTable = cnn.getConsulta("SELECT Nombre FROM Tipos WHERE Codigo=" & tipo & " AND Nombre LIKE '%Personalizado%'")
                If Not IsNothing(tipos) Then
                    tipoNuevo = tipo
                    cnn.setConsulta("DELETE FROM Permisos WHERE Tipo=" & tipo)
                Else
                    cnn.setConsulta("INSERT INTO Tipos (Nombre, Activo) VALUES ('Personalizado',1)")
                    tipos = cnn.getConsulta("SELECT MAX(Codigo) AS Codigo FROM Tipos")
                    If IsNothing(tipos) Then
                        MsgBox("Ha ocurrido un error")
                        Exit Sub
                    End If
                    tipoNuevo = tipos.Rows.Item(0).Item(0)
                End If
                For i As Integer = 0 To dgrPermisos.Rows.Count - 1
                    Dim modulos As DataTable = cnn.getConsulta("SELECT Codigo FROM Modulos WHERE Modulo='" & dgrPermisos.Item(0, i).Value & "'")
                    Dim modulo As Integer
                    If Not IsNothing(modulos) Then
                        modulo = modulos.Rows.Item(0).Item(0)
                    End If
                    cnn.setConsulta("INSERT INTO Permisos VALUES (" & tipoNuevo & "," & modulo & "," & CType(dgrPermisos.Item(1, i).Value, SqlDbType) & "," & CType(dgrPermisos.Item(2, i).Value, SqlDbType) & "," & CType(dgrPermisos.Item(3, i).Value, SqlDbType) & "," & CType(dgrPermisos.Item(4, i).Value, SqlDbType) & ")")
                Next
            Else
                Dim tipos As DataTable
                If tipo <> 0 Then
                    tipos = cnn.getConsulta("SELECT Nombre FROM Tipos WHERE Codigo=" & tipo)
                    If tipos.Rows.Item(0).Item(0).ToString.Contains("Personalizado") Then
                        cnn.setConsulta("DELETE FROM Permisos WHERE Tipo=" & tipo)
                        cnn.setConsulta("DELETE FROM Usuarios WHERE Tipo=" & tipo)
                        cnn.setConsulta("DELETE FROM Tipos WHERE Codigo=" & tipo)
                        insertar = True
                    End If
                End If
                tipos = cnn.getConsulta("SELECT * FROM Tipos WHERE Nombre='" & cboTipos.Items.Item(cboTipos.SelectedIndex) & "'")
                tipoNuevo = tipos.Rows.Item(0).Item("Codigo")
            End If
            If ediNuevo Or insertar Then
                cnn.setConsulta("INSERT INTO Usuarios (Nombre,NombreCompleto, Pass, Tipo, Activo) VALUES ('" & txtNombre.Text & "','" & txtNombreC.Text & "','" & pass & "'," & tipoNuevo & ",1)")
            Else
                cnn.setConsulta("UPDATE Usuarios SET Nombre='" & txtNombre.Text & "',NombreCompleto='" & txtNombreC.Text & "',Pass='" & pass & "',Tipo=" & tipoNuevo & " WHERE Codigo=" & indice)
            End If
        Else
            MessageBoxEx.Show("El nombre de usuario ya existe", "No se puede duplicar", MessageBoxButtons.OK)
            txtNombre.Focus()
            Exit Sub
        End If
        Cancelar()

    End Sub

    Private Sub cmdCambiar_Click(sender As Object, e As EventArgs) Handles cmdCambiar.Click
        Dim f As New frmPass
        f.ShowDialog()
        pass = f.pass
    End Sub

    Private Sub dgrPermisos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgrPermisos.CellValueChanged
        cboTipos.SelectedIndex = 0
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
End Class