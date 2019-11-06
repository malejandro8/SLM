<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnDepositos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        'HOLA MUNDO
        'btnDepositos
        '
        Me.btnDepositos.BackColor = System.Drawing.Color.Transparent
        Me.btnDepositos.BackgroundImage = CType(resources.GetObject("btnDepositos.BackgroundImage"), System.Drawing.Image)
        Me.btnDepositos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDepositos.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDepositos.FlatAppearance.BorderSize = 0
        Me.btnDepositos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDepositos.ForeColor = System.Drawing.Color.Transparent
        Me.btnDepositos.Location = New System.Drawing.Point(39, 12)
        Me.btnDepositos.Name = "btnDepositos"
        Me.btnDepositos.Size = New System.Drawing.Size(42, 39)
        Me.btnDepositos.TabIndex = 0
        Me.btnDepositos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Depositos Bancarios"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(502, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDepositos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDepositos As Button
    Friend WithEvents Label1 As Label
End Class
