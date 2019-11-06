Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnDepositos_Click(sender As Object, e As EventArgs) Handles btnDepositos.Click
        frmTipoDeposito.Show()

    End Sub
End Class
