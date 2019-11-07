Imports SLM.ClsConnection
Imports SLM.ClsPaciente

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cls As New ClsConnection
        Dim clsP As New ClsPaciente
        With clsP
            .Primer_apellido1 = ""
            .Segundo_apellido1 = ""
            .Segundo_nombre1 = ""
            .Primer_nombre1 = "Erick"
        End With

        MsgBox(clsP.Primer_nombre1 + clsP.Segundo_nombre1)




    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnDepositos_Click(sender As Object, e As EventArgs) Handles btnDepositos.Click
        frmTipoDeposito.Show()

    End Sub
End Class
