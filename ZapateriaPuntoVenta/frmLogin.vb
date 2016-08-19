Imports DevComponents.DotNetBar
Public Class frmLogin
    Dim cnn As Conexion
    Dim cerrar As Boolean = False
    Private Sub RadialMenu1_ItemClick(sender As Object, e As EventArgs) Handles RadialMenu1.ItemClick
        Select Case sender.name
            Case "cmdBaseDatos"
                Dim frm As New frmBaseDatos
                frm.ShowDialog()
                frmLogin_Load(Me, Nothing)
                Exit Select
            Case "cmdOlvido"
                Exit Select
        End Select
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If txtUsuario.Text = "" Then
            MessageBoxEx.Show("Ingrese un nombre de usuario", "Error", MessageBoxButtons.OK)
            txtUsuario.Focus()
            Exit Sub
        End If
        If txtPass.Text = "" Then
            MessageBoxEx.Show("Ingrese una contraeña", "Error", MessageBoxButtons.OK)
            txtPass.Focus()
            Exit Sub
        End If

        Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Usuarios WHERE Nombre='" & txtUsuario.Text & "'")

        If Not IsNothing(dt) Then
            If Des_Y_EncriptaContrasenia(txtPass.Text) = dt.Rows.Item(0).Item("Pass") Then
                If CBool(dt.Rows.Item(0).Item("Activo")) Then
                    nombreUser = txtUsuario.Text
                    nombreCUser = dt.Rows.Item(0).Item("NombreCompleto")
                    passUser = txtPass.Text
                    tipoUser = dt.Rows.Item(0).Item("Tipo")
                    codUser = dt.Rows.Item(0).Item("Codigo")

                    'frmPrincipal = New Principal
                    'frmPrincipal.Show()
                    cerrar = True
                    Me.Close()
                Else
                    MessageBoxEx.Show("La cuenta se encuentra deshabilitada" & vbNewLine & "No tiene permisos para acceder", "Insuficientes permisos", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            Else
                MessageBoxEx.Show("La contraseña es incorrecta", "Error", MessageBoxButtons.OK)
            End If
        Else
            MessageBoxEx.Show("El nombre de usuario es incorrecto", "Error", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not cerrar Then
            If MessageBoxEx.Show("¿Esta seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                frmPrincipal.Close()
            Else
                e.Cancel() = True
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonX1.Text = "Iniciar"
        If verificarBaseDatos() <> "" Then
            getCadenaConexion(verificarBaseDatos)
        Else
            MsgBox("La base de datos no se ha configurado", vbInformation, "Error")
            Dim form As New frmBaseDatos
            form.ShowDialog()
            If verificarBaseDatos() = "" Then
                MsgBox("La base de datos no se ha configurado", vbCritical, "Error fatal")
                Me.Close()
            End If
        End If
        Try
            cnn = New Conexion(cadConexion)
            Dim dt As DataTable = cnn.getConsulta("SELECT * FROM ConfiguracionLogin")
            If Not IsNothing(dt) Then
                If CBool(dt.Rows.Item(0).Item(1)) = False And CBool(dt.Rows.Item(0).Item(2)) = False Then
                    RadialMenu1.Visible = False
                ElseIf CBool(dt.Rows.Item(0).Item(1)) = False Then
                    cmdBaseDatos.Visible = False
                ElseIf CBool(dt.Rows.Item(0).Item(2)) = False Then
                    cmdOlvido.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox("La base de datos no se ha configurado", vbInformation, "Error")
            Dim form As New frmBaseDatos
            form.ShowDialog()
            If verificarBaseDatos() = "" Or verificarBaseDatos() = cadConexion Then
                MsgBox("La base de datos no se ha configurado", vbCritical, "Error fatal")
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub SwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles SwitchButton1.ValueChanged
        If SwitchButton1.Value Then
            txtPass.PasswordChar = ""
        Else
            txtPass.PasswordChar = "*"
        End If
    End Sub
End Class