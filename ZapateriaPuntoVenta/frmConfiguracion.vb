Imports DevComponents.DotNetBar

Public Class frmConfiguracion
    Dim cnn As Conexion

    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles Me.Load
        cnn = New Conexion(cadConexion)
        Dim dt As DataTable = cnn.getConsulta("SELECT Consulta FROM Permisos WHERE Tipo=" & tipoUser & " AND Modulo=7")
        If Not IsNothing(dt) Then
            Dim row As DataRow = dt.Rows(0)
            If row.Item("Consulta") = False Then
                TabControl1.TabPages("Sesiones").Dispose()
                TabControl1.TabPages("General").Dispose()
                TabControl1.Refresh

            End If
        End If
    End Sub
End Class