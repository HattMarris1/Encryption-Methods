<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Steganography_Visual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.encrypt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "When the key is 3:"
        '
        'encrypt
        '
        Me.encrypt.Location = New System.Drawing.Point(152, 9)
        Me.encrypt.Name = "encrypt"
        Me.encrypt.Size = New System.Drawing.Size(151, 29)
        Me.encrypt.TabIndex = 1
        Me.encrypt.Text = "Encrypt!"
        Me.encrypt.UseVisualStyleBackColor = True
        '
        'Steganography_Visual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1708, 367)
        Me.Controls.Add(Me.encrypt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Steganography_Visual"
        Me.Text = "Steganography_Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents encrypt As System.Windows.Forms.Button
End Class
