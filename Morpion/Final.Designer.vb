<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Final
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RejouerIdem = New System.Windows.Forms.Button()
        Me.RejouerNew = New System.Windows.Forms.Button()
        Me.message_fin = New System.Windows.Forms.Label()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RejouerIdem
        '
        Me.RejouerIdem.Location = New System.Drawing.Point(43, 111)
        Me.RejouerIdem.Name = "RejouerIdem"
        Me.RejouerIdem.Size = New System.Drawing.Size(144, 63)
        Me.RejouerIdem.TabIndex = 1
        Me.RejouerIdem.Text = "Rejouer avec les mêmes joueurs"
        Me.RejouerIdem.UseVisualStyleBackColor = True
        '
        'RejouerNew
        '
        Me.RejouerNew.Location = New System.Drawing.Point(236, 111)
        Me.RejouerNew.Name = "RejouerNew"
        Me.RejouerNew.Size = New System.Drawing.Size(144, 63)
        Me.RejouerNew.TabIndex = 2
        Me.RejouerNew.Text = "Rejouer avec des nouveaux joueurs"
        Me.RejouerNew.UseVisualStyleBackColor = True
        '
        'message_fin
        '
        Me.message_fin.AutoSize = True
        Me.message_fin.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_fin.Location = New System.Drawing.Point(273, 51)
        Me.message_fin.Name = "message_fin"
        Me.message_fin.Size = New System.Drawing.Size(75, 20)
        Me.message_fin.TabIndex = 3
        Me.message_fin.Text = "message fin"
        '
        'Quitter
        '
        Me.Quitter.Location = New System.Drawing.Point(426, 111)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(144, 63)
        Me.Quitter.TabIndex = 4
        Me.Quitter.Text = "Arreter de jouer"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'Final
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 224)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.message_fin)
        Me.Controls.Add(Me.RejouerNew)
        Me.Controls.Add(Me.RejouerIdem)
        Me.Location = New System.Drawing.Point(450, 450)
        Me.MaximumSize = New System.Drawing.Size(635, 263)
        Me.MinimumSize = New System.Drawing.Size(635, 263)
        Me.Name = "Final"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Fin de partie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RejouerIdem As System.Windows.Forms.Button
    Friend WithEvents RejouerNew As System.Windows.Forms.Button
    Friend WithEvents message_fin As System.Windows.Forms.Label
    Friend WithEvents Quitter As System.Windows.Forms.Button
End Class
