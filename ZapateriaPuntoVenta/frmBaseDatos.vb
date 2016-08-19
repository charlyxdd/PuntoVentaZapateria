Imports System.DirectoryServices
Imports System.Net

Public Class frmBaseDatos
    Dim chico As Boolean

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        verEquiposRed()
        chico = True
        tmrAnimacion.Enabled = True
    End Sub

    Private Sub frmBaseDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonX1.Text = "..."
        ButtonX2.Text = "Aceptar"
        txtIP.Value = verificarBaseDatos()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If txtIP.Value = "" Then
            MsgBox("Debe seleccionar una Base de datos", vbInformation, "Error")
            Exit Sub
        End If
        Try
            Dim cnn As New Conexion(getCadenaConexion(txtIP.Value))
            Dim dt As DataTable = cnn.getConsulta("SELECT * FROM sys.tables")

            If IsNothing(dt) Then
                MsgBox("El servidor no está disponible o la dirección no es correcta" & vbNewLine & "Verifiquelo", vbInformation + vbCritical, "Error")
                Exit Sub
            Else
                guardarConf(txtIP.Value)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Close()
    End Sub

    Private Sub verEquiposRed()
        lvEquipos.Items.Clear()
        Dim root As New DirectoryEntry("WinNT:")
        Dim parent As DirectoryServices.DirectoryEntries
        parent = root.Children
        Dim d As DirectoryEntries = parent
        For Each complist As DirectoryEntry In parent
            Application.DoEvents()
            For Each c As DirectoryEntry In complist.Children
                If c.Name <> "Schema" Then
                    lvEquipos.Items.Add(c.Name, 0)
                End If
            Next
        Next
    End Sub

    Private Sub tmrAnimacion_Tick(sender As Object, e As EventArgs) Handles tmrAnimacion.Tick
        If chico Then
            If Me.Height < 360 Then
                Me.Height += 10
            Else
                chico = False
                lvEquipos.Visible = True
                tmrAnimacion.Enabled = False
            End If
        Else
            If Me.Height > 120 Then
                Me.Height -= 10
            Else
                chico = True
                lvEquipos.Visible = False
                tmrAnimacion.Enabled = False
            End If
        End If
    End Sub

    Private Sub lvEquipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvEquipos.SelectedIndexChanged
        If lvEquipos.SelectedItems.Count > 0 Then
            Dim mIpHostEntry As IPHostEntry

            mIpHostEntry = Dns.GetHostEntry(lvEquipos.SelectedItems.Item(0).Text)
            For i As Integer = 0 To mIpHostEntry.AddressList.Length - 1
                If mIpHostEntry.AddressList(i).ToString.Contains(".") Then
                    txtIP.Value = mIpHostEntry.AddressList(i).ToString
                    Exit For
                End If
            Next
        Else
            txtIP.Value = ""
        End If
    End Sub
End Class