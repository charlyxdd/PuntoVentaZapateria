Imports DevComponents.DotNetBar

Public Class frmPagar

    Private guardado As Boolean
    Private total As Double
    Private pagado As Double
    Private cliente As Integer
    Private nota As Integer
    Dim valorRetorno As Double = 0
    Dim cnn As Conexion
    Public Overloads Function showDialog(ByVal g As Boolean, ByVal t As Double, ByVal p As Double, ByVal c As Integer, ByVal n As Integer) As Integer
        guardado = g
        total = t
        pagado = p
        cliente = c
        nota = n
        Me.ShowDialog()
        Return valorRetorno
    End Function

    Private Sub frmPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn = New Conexion(cadConexion)
        If Not guardado Then
            cmdBuscar.Enabled = False
        End If
        txtTotal.Text = FormatCurrency(total, 2)
        txtPagado.Text = FormatCurrency(pagado, 2)
        txtSaldo.Text = FormatCurrency(txtTotal.Text - txtPagado.Text, 2)
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim encontrado As Boolean
        Dim claveBuscada As String
        Dim f As frmBuscar
        f = New frmBuscar
        Try
            With f
                .Text = "Pantalla de Búsqueda de Vales"
                .dgrBuscar.Rows.Clear()
                .dgrBuscar.Columns.Clear()
                .dgrBuscar.Columns.Add("Codigo", "Codigo")
                .dgrBuscar.Columns.Add("Nombre", "Monto")
            End With
            Dim dt As DataTable = cnn.getConsulta("SELECT Codigo, Cantidad FROM Vales WHERE Cliente=" & cliente & " AND Usado=0")
            If Not IsNothing(dt) Then
                For Each row As DataRow In dt.Rows
                    f.dgrBuscar.Rows.Add(row.Item("Codigo"), row.Item("Cantidad"))
                Next
            End If
            f.ShowDialog(Me)
            encontrado = f.SeEncontro
            claveBuscada = Trim(f.claveBuscada)

            If encontrado Then
                txtPagar.Text = "V" & claveBuscada & "&" & txtPagar.Text
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error: " & ex.ToString)
        End Try
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Dim cantidadEfectivo As Double = 0
        Dim cantidadVales As Double = 0
        Dim valor As String = txtPagar.Text
        Dim cantidades() As String = valor.Split("&")

        For i As Integer = 0 To cantidades.Length - 1
            If cantidades(i).Contains("V") Or cantidades(i).Contains("v") Then
                If cantidades(i).Length > 1 Then
                    If IsNumeric(cantidades(i).Remove(0, 1)) Then
                        Dim codigo As Integer = cantidades(i).Remove(0, 1)
                        Dim dt As DataTable = cnn.getConsulta("SELECT Cantidad FROM Vales WHERE Codigo=" & codigo & " AND Cliente=" & cliente)
                        If IsNothing(dt) Then
                            MessageBoxEx.Show("El vale seleccionado no es válido para el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else

                            cantidadVales += dt.Rows(0).Item(0)

                            cnn.setConsulta("UPDATE Vales SET Usado=1, PedidoUsado=" & nota & " WHERE Codigo=" & codigo)
                        End If
                    Else
                        MessageBoxEx.Show("El formato de pago no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            Else
                If cantidades(i).Contains("P") Or cantidades(i).Contains("p") Then
                    cantidades(i) = cantidades(i).Remove(0, 1)
                End If
                If IsNumeric(cantidades(i)) Then
                    cantidadEfectivo += cantidades(i)
                Else
                    If cantidades(i) <> "" Then
                        MessageBoxEx.Show("El formato de pago no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End If
        Next

        cnn.setConsulta("UPDATE PedidosClientes SET Pagado=" & (cantidadVales + cantidadEfectivo + txtPagado.Text) & " WHERE Codigo=" & nota)

        valorRetorno = (cantidadVales + cantidadEfectivo + txtPagado.Text)
        Me.Close()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        valorRetorno = 0
    End Sub

    Private Sub txtPagar_TextChanged(sender As Object, e As EventArgs) Handles txtPagar.TextChanged
        If txtPagar.Text.Contains("V") Or txtPagar.Text.Contains("v") Then
            If Not guardado Then
                MessageBoxEx.Show("No puede usar vales por que el pedido no esta guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        Dim cantidadEfectivo As Double = 0
        Dim cantidadVales As Double = 0
        Dim valor As String = txtPagar.Text
        Dim cantidades() As String = valor.Split("&")

        For i As Integer = 0 To cantidades.Length - 1
            If cantidades(i).Contains("V") Or cantidades(i).Contains("v") Then
                If cantidades(i).Length > 1 Then
                    If IsNumeric(cantidades(i).Remove(0, 1)) Then
                        Dim codigo As Integer = cantidades(i).Remove(0, 1)
                        Dim dt As DataTable = cnn.getConsulta("SELECT Cantidad FROM Vales WHERE Codigo=" & codigo & " AND Cliente=" & cliente & " AND Usado=0")
                        If IsNothing(dt) Then
                            MessageBoxEx.Show("El vale seleccionado no es válido para el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        Else

                            cantidadVales += dt.Rows(0).Item(0)
                        End If
                    Else
                        MessageBoxEx.Show("El formato de pago no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            Else
                If cantidades(i).Contains("P") Or cantidades(i).Contains("p") Then
                    cantidades(i) = cantidades(i).Remove(0, 1)
                End If
                If IsNumeric(cantidades(i)) Then
                    cantidadEfectivo += cantidades(i)
                Else
                    If cantidades(i) <> "" Then
                        MessageBoxEx.Show("El formato de pago no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End If
            End If
        Next
        Dim cambio As Double = 0
        Dim temp As Double = txtSaldo.Text
        If cantidadVales < temp Then
            temp -= cantidadVales
            If cantidadEfectivo > temp Then
                cambio = cantidadEfectivo - temp
            End If
        Else
            cambio = cantidadEfectivo
        End If
        'No se como hacerlo u.u
        txtTotal1.Text = FormatCurrency((cantidadEfectivo + cantidadVales), 2)
        txtCambio.Text = FormatCurrency(cambio, 2)
        txtVales.Text = FormatCurrency(cantidadVales, 2)
    End Sub
End Class