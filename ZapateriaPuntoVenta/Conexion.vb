Public Class Conexion
    Private cnnPrincipal As New SqlClient.SqlConnection
    Private cmd As New SqlClient.SqlCommand
    'Private dr As OleDb.OleDbDataReader
    Private da As SqlClient.SqlDataAdapter
    Private ds As New DataSet
    Private dt As DataTable
    Private cadena As String

    Private Sub cnn(ByVal abrir As Boolean)
        If abrir Then
            If cnnPrincipal.State = ConnectionState.Open Then cnnPrincipal.Close()
            cnnPrincipal.Open()
        Else
            If cnnPrincipal.State = ConnectionState.Closed Then cnnPrincipal.Open()
            cnnPrincipal.Close()
        End If
    End Sub

    Public Sub New(ByVal cadConexion As String)
        cadena = cadConexion
        cnnPrincipal.ConnectionString = cadena
        cmd.Connection = cnnPrincipal
        cmd.CommandType = CommandType.Text
    End Sub

    Public Function getConsulta(ByVal SQL As String)
        Try
            cnn(True)
            da = New SqlClient.SqlDataAdapter(SQL, cnnPrincipal)
            Dim tabla As String
            Try
                tabla = SQL.Substring(SQL.IndexOf("FROM ") + 5, SQL.Substring(SQL.IndexOf("FROM ") + 5).IndexOf(" "))
            Catch ex As Exception
                tabla = SQL.Substring(SQL.IndexOf("FROM ") + 5)
            End Try

            Try
                ds.Tables.Item(tabla).Rows.Clear()
                ds.Tables.Item(tabla).Columns.Clear()
            Catch ex As Exception
            End Try

            da.Fill(ds, tabla)

            dt = ds.Tables(tabla)
            cnn(False)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch e As Exception
            MsgBox(e.Message)
            Return Nothing
        End Try
    End Function

    Public Sub setConsulta(ByVal SQL As String)
        cnn(True)
        cmd.CommandText = SQL
        cmd.ExecuteReader()
        cnn(False)
    End Sub
End Class
