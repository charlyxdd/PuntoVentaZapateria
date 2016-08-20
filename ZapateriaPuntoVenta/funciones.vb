Imports System.IO

Module funciones
    Public cadConexion As String
    Public tipoUser As String
    Public codUser As Integer
    Public nombreUser As String
    Public nombreCUser As String
    Public passUser As String
    Public activo As Object
    Public frmPrincipal As Principal
    Public cajaAbierta As Boolean

    Public Function verificarBaseDatos()
        Dim direccion As String = Application.StartupPath & "\conf.ini"

        Dim texto As String
        Try
            Dim sr As New StreamReader(direccion)
            texto = sr.ReadLine
            sr.Close()
            Return texto
        Catch e As Exception
            Return ""
        End Try
    End Function

    Public Sub guardarConf(ByVal BD As String)
        EliminarConf()
        Dim direccion As String = Application.StartupPath & "\conf.ini"

        Dim sw As New StreamWriter(direccion)

        sw.WriteLine(BD)
        sw.Close()
        inicializarBD()
    End Sub

    Public Sub EliminarConf()
        If File.Exists(Application.StartupPath & "\conf.ini") Then
            File.Delete(Dir(Application.StartupPath & "\conf.ini"))
        End If
    End Sub

    Public Function getCadenaConexion(ByVal BD As String)
        cadConexion = "data source = " & BD & "; initial catalog = zapateria; user id = sa; password = 45432536"
        Return cadConexion
    End Function

    Public Function Des_Y_EncriptaContrasenia(cad As String) As String
        Dim resultado As String = ""
        For i As Integer = 1 To cad.Length
            resultado = resultado & Chr(Asc(Mid(cad, i, 1)) Xor 8)
        Next

        Return resultado
    End Function

    Public Sub activarControles(agregar As Boolean)
        With frmPrincipal
            .cmdBuscar.Enabled = True
            .mnuBuscar.Enabled = True
            If agregar Then
                .cmdNuevo.Enabled = True
                .mnuNuevo.Enabled = True
            Else
                .cmdNuevo.Enabled = False
                .mnuNuevo.Enabled = False
            End If
        End With
    End Sub

    Public Sub desactivarControles()
        With frmPrincipal
            .cmdNuevo.Enabled = False
            .cmdBuscar.Enabled = False
            .mnuNuevo.Enabled = False
            .mnuBuscar.Enabled = False
        End With
    End Sub

    Public Sub activarEdicion(editar As Boolean, eliminar As Boolean)
        With frmPrincipal
            If editar Then
                .mnuEditar.Enabled = True
                .cmdEditar.Enabled = True
            Else
                .mnuEditar.Enabled = False
                .cmdEditar.Enabled = False
            End If
            If eliminar Then
                .mnuEliminar.Enabled = True
                .cmdEliminar.Enabled = True
            Else
                .mnuEliminar.Enabled = False
                .cmdEliminar.Enabled = False
            End If
        End With
    End Sub

    Public Sub desactivarEdicion()
        With frmPrincipal
            .mnuEditar.Enabled = False
            .mnuEliminar.Enabled = False
            .cmdEditar.Enabled = False
            .cmdEliminar.Enabled = False
        End With
    End Sub

    Public Sub activarAcciones()
        With frmPrincipal
            .mnuAceptar.Enabled = True
            .mnuCancelar.Enabled = True
            .cmdAceptar.Enabled = True
            .cmdCancelar.Enabled = True
        End With
    End Sub

    Public Sub desactivarAcciones()
        With frmPrincipal
            .mnuAceptar.Enabled = False
            .mnuCancelar.Enabled = False
            .cmdAceptar.Enabled = False
            .cmdCancelar.Enabled = False
        End With
    End Sub

    Public Sub activarImpresion()
        With frmPrincipal
            .mnuImprimir.Enabled = True
            .cmdImprmir.Enabled = True
        End With
    End Sub

    Public Sub desactivarImpresion()
        With frmPrincipal
            .mnuImprimir.Enabled = False
            .cmdImprmir.Enabled = False
        End With
    End Sub

    Public Sub mostrarBarra()
        'frmPrincipal.barra.Visible = True
    End Sub

    Public Sub ocultarBarra()
        'frmPrincipal.barra.Visible = False
    End Sub

    Public Sub inicializarBD()
        Dim cnn As New Conexion(cadConexion)
        Dim dt As New DataTable

        dt = cnn.getConsulta("SELECT * FROM ConfiguracionLogin")
        If (IsNothing(dt)) Then
            'Inicializar tablas principales
            'ConfiguracionLogin
            cnn.setConsulta("INSERT INTO ConfiguracionLogin (cmdBaseDatos,cmdOlvido) VALUES (1,1)")
            'ConfiguracionPrincipal
            cnn.setConsulta("INSERT INTO ConfiguracionPrincipal (Accesos,Rojo,Verde,Azul,Imagen) VALUES (0,255,138,0,'C:/Sistemas/Logo.png')")
            'Tablas respectivas a usuarios
            cnn.setConsulta("INSERT INTO Tipos (Nombre,Activo) VALUES ('master',1)")
            cnn.setConsulta("INSERT INTO Usuarios (Nombre,NombreCompleto,Pass,Tipo,Activo) VALUES ('root','root','" & Des_Y_EncriptaContrasenia("120315Flaca") & "',0 ,1)")

            'Tabla de modulos
            cnn.setConsulta("INSERT INTO Modulos (Modulo,Nombre,Icono) VALUES ('Tipos de cuenta','frmTipos','C:/Sistemas/frmTipos.ico')")
            cnn.setConsulta("INSERT INTO Modulos (Modulo,Nombre,Icono) VALUES ('Cuentas de usuarios','frmUsuarios','C:/Sistemas/frmUsuarios.ico')")
            'Personalizados
            cnn.setConsulta("INSERT INTO Modulos (Modulo,Nombre,Icono) VALUES ('Clientes','frmClientes','C:/Sistemas/frmClientes.ico')")
            cnn.setConsulta("INSERT INTO Modulos (Modulo,Nombre,Icono) VALUES ('Proveedores','frmProveedores','C:/Sistemas/frmProveedores.ico')")
            cnn.setConsulta("INSERT INTO Modulos (Modulo,Nombre,Icono) VALUES ('Productos','frmProductos','C:/Sistemas/frmProductos.ico')")
            cnn.setConsulta("INSERT INTO Modulos (Modulo,Nombre,Icono) VALUES ('Caja','frmCaja','C:/Sistemas/frmCaja.ico')")

            'Permisos
            cnn.setConsulta("INSERT INTO Permisos VALUES (0,1,1,1,1,1)")
            cnn.setConsulta("INSERT INTO Permisos VALUES (0,2,1,1,1,1)")
            'Personalizados
            cnn.setConsulta("INSERT INTO Permisos VALUES (0,3,1,1,1,1)")
            cnn.setConsulta("INSERT INTO Permisos VALUES (0,4,1,1,1,1)")
            cnn.setConsulta("INSERT INTO Permisos VALUES (0,5,1,1,1,1)")
            cnn.setConsulta("INSERT INTO Permisos VALUES (0,6,1,1,1,1)")
        End If

    End Sub
End Module
