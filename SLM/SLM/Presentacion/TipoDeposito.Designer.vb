<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoDeposito
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnTarjeta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTarjeta
        '
        Me.btnTarjeta.Location = New System.Drawing.Point(12, 25)
        Me.btnTarjeta.Name = "btnTarjeta"
        Me.btnTarjeta.Size = New System.Drawing.Size(112, 108)
        Me.btnTarjeta.TabIndex = 0
        Me.btnTarjeta.Text = "Button1"
        Me.btnTarjeta.UseVisualStyleBackColor = True
        '
        'frmTipoDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 155)
        Me.Controls.Add(Me.btnTarjeta)
        Me.Name = "frmTipoDeposito"
        Me.Text = "TipoDeposito"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTarjeta As Button
End Class
