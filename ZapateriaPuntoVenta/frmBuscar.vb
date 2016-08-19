Public Class frmBuscar
    Public SeEncontro As Boolean
    Public claveBuscada As String

    Private Sub frmBuscar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFiltro.Text = ""
        SeEncontro = False
    End Sub

    Private Sub dgrBuscar_DoubleClick(sender As Object, e As EventArgs) Handles dgrBuscar.DoubleClick
        SeEncontro = True
        claveBuscada = dgrBuscar.Item(0, dgrBuscar.SelectedCells(0).RowIndex).Value
        Me.Close()
    End Sub

    Private Sub txtFiltro_TextChanged(sender As Object, e As EventArgs) Handles txtFiltro.TextChanged
        For i As Integer = 0 To dgrBuscar.Rows.Count - 1
            dgrBuscar.Rows.Item(i).Visible = True
        Next
        If txtFiltro.Text <> "" Then
            For i As Integer = 0 To dgrBuscar.Rows.Count - 1
                Dim encontro As Boolean = False
                For x As Integer = 0 To dgrBuscar.Columns.Count - 1
                    If dgrBuscar.Item(x, i).Value.ToString.ToLower.Contains(txtFiltro.Text.ToLower) Then
                        'dgrBuscar.Rows.Item(i).Visible = False
                        encontro = True
                    End If
                Next
                If Not encontro Then
                    dgrBuscar.Rows.Item(i).Visible = False
                End If
            Next
            cmdQuitar.Enabled = True
        End If
    End Sub

    Private Sub cmdQuitar_Click(sender As Object, e As EventArgs) Handles cmdQuitar.Click
        txtFiltro.Text = ""
        cmdQuitar.Enabled = False
    End Sub
End Class