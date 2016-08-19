Imports DevComponents.DotNetBar
Public Class frmPass
    Public pass As String

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        If txtPass.Text = "" Then
            MessageBoxEx.Show("Debe ingresar una contraseña", "Error", MessageBoxButtons.OK)
            txtPass.Focus()
            Exit Sub
        End If
        If txtCon.Text = "" Then
            MessageBoxEx.Show("Debe confirmar la contraseña", "Error", MessageBoxButtons.OK)
            txtCon.Focus()
            Exit Sub
        End If
        If txtPass.Text <> txtCon.Text Then
            MessageBoxEx.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK)
            txtPass.Focus()
            Exit Sub
        End If
        pass = Des_Y_EncriptaContrasenia(txtPass.Text
                                         )
        Me.Close()
    End Sub
End Class