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
        Dim accesos As Boolean
        Dim row As DataRow

        If Not IsNothing(dt) Then 'Verificación de permisos para mostrar o ocultar las pestañas
            row = dt.Rows(0)
            If row.Item("Consulta") = False Then
                TabControl1.TabPages("Sesiones").Dispose()
                TabControl1.TabPages("General").Dispose()
                TabControl1.Refresh()
            End If
        End If

        dt = cnn.getConsulta("SELECT accesos FROM configuracionPrincipal") 'Verificar si los accesos directos estan activados
        If Not IsNothing(dt) Then
            row = dt.Rows(0)
            If row.Item("Accesos") = False Then
                TabControl1.TabPages("Accesos").Dispose()
                cerrar = True
            Else
                accesos = True
            End If
        End If

        If (accesos) Then 'Si estan habilitados los accesos entonces cargas los módulos donde se tengan permisos de acceso
            row = dt.Rows(0)
            If row.Item("Accesos") = True Then
                dt = cnn.getConsulta("SELECT Modulos.Codigo, Modulos.Modulo FROM Modulos INNER JOIN Permisos ON Permisos.Modulo=Modulos.Codigo WHERE Permisos.Tipo=" & tipoUser & " AND Permisos.Consulta=1")
                Dim dt2 As DataTable = cnn.getConsulta("SELECT Modulo FROM Accesos WHERE Usuario=" & codUser)
                Dim contador As Integer
                For contador = 0 To (dt.Rows.Count - 1)
                    row = dt.Rows(contador)
                    Dim rows As DataRow() = dt2.Select("Modulo=" & row.Item("Codigo"))
                    If rows.Length > 1 Then
                        chkModulos.SetItemChecked(row.Item("código") & "-" & row.Item("modulo"), True)
                    Else
                        chkModulos.Items.Add(row.Item("código") & "-" & row.Item("modulo"))


                    End If
                Next
            End If


        End If
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        cnn.setConsulta("DELETE FROM Accesos WHERE usuario=" & codUser)
        For i As Integer = 0 To (chkModulos.CheckedItems.Count - 1)
            Dim codigo As String() = Split(chkModulos.CheckedItems(i).Text, "-")
            cnn.setConsulta("INSERT INTO accesos (Usuario, Modulo) VALUES (" & codUser & "," & codigo(0))

        Next

    End Sub
End Class