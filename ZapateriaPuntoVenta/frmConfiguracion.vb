Imports DevComponents.DotNetBar

Public Class frmConfiguracion
    Dim cnn As Conexion
    Dim cerrar As Boolean = False

    Private Sub frmConfiguracion_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If cerrar Then
            'Me.Close()
        End If
    End Sub

    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles Me.Load
        'chkModulos.Items.Add("numero 1")
        cnn = New Conexion(cadConexion)
        Dim dt As DataTable = cnn.getConsulta("SELECT Consulta FROM Permisos WHERE Tipo=" & tipoUser & " AND Modulo=7")
        If Not IsNothing(dt) Then
            Dim row As DataRow = dt.Rows(0)
            If row.Item("Consulta") = False Then
                TabControl1.TabPages("Sesiones").Dispose()
                TabControl1.TabPages("General").Dispose()
                TabControl1.Refresh()
                dt = cnn.getConsulta("SELECT accesos FROM configuracionPrincipal")
                If Not IsNothing(dt) Then
                    row = dt.Rows(0)
                    If row.Item("Accesos") = False Then
                        TabControl1.TabPages("Accesos").Dispose()
                        cerrar = True

                    End If
                End If
            End If
        End If

        dt = cnn.getConsulta("SELECT accesos FROM ConfiguracionPrincipal")
        If Not IsNothing(dt) Then
            Dim row As DataRow = dt.Rows(0)
            If row.Item("Accesos") = True Then
                dt = cnn.getConsulta("SELECT Codigo, Modulo FROM Modulos INNER JOIN Permisos ON Permisos.Modulo=Modulos.Codigo WHERE Permisos.Tipo=" & tipoUser & " AND Permisos.Consulta=True")
                Dim contador As Integer
                For contador = 0 To (dt.Rows.Count - 1)
                    row = dt.Rows(contador)
                    chkModulos.Items.Add(row.Item("Modulo"))
                Next
            End If
        End If






    End Sub
End Class