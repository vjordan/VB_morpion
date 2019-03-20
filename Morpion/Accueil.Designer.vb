<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.nom_joueur1 = New System.Windows.Forms.TextBox()
        Me.LesJoueurs = New System.Windows.Forms.Label()
        Me.Motif_joueur1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2_j1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1_j1 = New System.Windows.Forms.RadioButton()
        Me.Motif_joueur2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2_j2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1_j2 = New System.Windows.Forms.RadioButton()
        Me.nom_joueur2 = New System.Windows.Forms.TextBox()
        Me.Valider = New System.Windows.Forms.Button()
        Me.Motif_joueur1.SuspendLayout()
        Me.Motif_joueur2.SuspendLayout()
        Me.SuspendLayout()
        '
        'nom_joueur1
        '
        Me.nom_joueur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_joueur1.Location = New System.Drawing.Point(55, 115)
        Me.nom_joueur1.Name = "nom_joueur1"
        Me.nom_joueur1.Size = New System.Drawing.Size(106, 22)
        Me.nom_joueur1.TabIndex = 0
        '
        'LesJoueurs
        '
        Me.LesJoueurs.AutoSize = True
        Me.LesJoueurs.Font = New System.Drawing.Font("Buxton Sketch", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LesJoueurs.Location = New System.Drawing.Point(115, 12)
        Me.LesJoueurs.Name = "LesJoueurs"
        Me.LesJoueurs.Size = New System.Drawing.Size(148, 39)
        Me.LesJoueurs.TabIndex = 1
        Me.LesJoueurs.Text = "Les joueurs"
        '
        'Motif_joueur1
        '
        Me.Motif_joueur1.Controls.Add(Me.RadioButton2_j1)
        Me.Motif_joueur1.Controls.Add(Me.RadioButton1_j1)
        Me.Motif_joueur1.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Motif_joueur1.Location = New System.Drawing.Point(188, 54)
        Me.Motif_joueur1.Name = "Motif_joueur1"
        Me.Motif_joueur1.Size = New System.Drawing.Size(175, 145)
        Me.Motif_joueur1.TabIndex = 2
        Me.Motif_joueur1.TabStop = False
        Me.Motif_joueur1.Text = "Joueur 1"
        '
        'RadioButton2_j1
        '
        Me.RadioButton2_j1.BackgroundImage = Global.Morpion.My.Resources.Resources.circle
        Me.RadioButton2_j1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton2_j1.Location = New System.Drawing.Point(33, 83)
        Me.RadioButton2_j1.Name = "RadioButton2_j1"
        Me.RadioButton2_j1.Size = New System.Drawing.Size(87, 56)
        Me.RadioButton2_j1.TabIndex = 1
        Me.RadioButton2_j1.TabStop = True
        Me.RadioButton2_j1.UseVisualStyleBackColor = True
        '
        'RadioButton1_j1
        '
        Me.RadioButton1_j1.BackgroundImage = Global.Morpion.My.Resources.Resources.cross
        Me.RadioButton1_j1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton1_j1.Location = New System.Drawing.Point(33, 22)
        Me.RadioButton1_j1.Name = "RadioButton1_j1"
        Me.RadioButton1_j1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton1_j1.Size = New System.Drawing.Size(87, 61)
        Me.RadioButton1_j1.TabIndex = 0
        Me.RadioButton1_j1.TabStop = True
        Me.RadioButton1_j1.UseVisualStyleBackColor = True
        '
        'Motif_joueur2
        '
        Me.Motif_joueur2.Controls.Add(Me.RadioButton2_j2)
        Me.Motif_joueur2.Controls.Add(Me.RadioButton1_j2)
        Me.Motif_joueur2.Font = New System.Drawing.Font("Buxton Sketch", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Motif_joueur2.Location = New System.Drawing.Point(188, 205)
        Me.Motif_joueur2.Name = "Motif_joueur2"
        Me.Motif_joueur2.Size = New System.Drawing.Size(175, 144)
        Me.Motif_joueur2.TabIndex = 3
        Me.Motif_joueur2.TabStop = False
        Me.Motif_joueur2.Text = "Joueur 2"
        '
        'RadioButton2_j2
        '
        Me.RadioButton2_j2.BackgroundImage = Global.Morpion.My.Resources.Resources.circle
        Me.RadioButton2_j2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton2_j2.Location = New System.Drawing.Point(33, 80)
        Me.RadioButton2_j2.Name = "RadioButton2_j2"
        Me.RadioButton2_j2.Size = New System.Drawing.Size(87, 58)
        Me.RadioButton2_j2.TabIndex = 3
        Me.RadioButton2_j2.TabStop = True
        Me.RadioButton2_j2.UseVisualStyleBackColor = True
        '
        'RadioButton1_j2
        '
        Me.RadioButton1_j2.BackgroundImage = Global.Morpion.My.Resources.Resources.cross
        Me.RadioButton1_j2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RadioButton1_j2.Location = New System.Drawing.Point(33, 18)
        Me.RadioButton1_j2.Name = "RadioButton1_j2"
        Me.RadioButton1_j2.Size = New System.Drawing.Size(87, 58)
        Me.RadioButton1_j2.TabIndex = 2
        Me.RadioButton1_j2.TabStop = True
        Me.RadioButton1_j2.UseVisualStyleBackColor = True
        '
        'nom_joueur2
        '
        Me.nom_joueur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_joueur2.Location = New System.Drawing.Point(55, 259)
        Me.nom_joueur2.Name = "nom_joueur2"
        Me.nom_joueur2.Size = New System.Drawing.Size(106, 22)
        Me.nom_joueur2.TabIndex = 4
        '
        'Valider
        '
        Me.Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valider.Location = New System.Drawing.Point(188, 371)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(175, 37)
        Me.Valider.TabIndex = 5
        Me.Valider.Text = "Valider"
        Me.Valider.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 417)
        Me.Controls.Add(Me.Valider)
        Me.Controls.Add(Me.nom_joueur2)
        Me.Controls.Add(Me.Motif_joueur2)
        Me.Controls.Add(Me.Motif_joueur1)
        Me.Controls.Add(Me.LesJoueurs)
        Me.Controls.Add(Me.nom_joueur1)
        Me.MaximumSize = New System.Drawing.Size(427, 456)
        Me.MinimumSize = New System.Drawing.Size(427, 456)
        Me.Name = "Accueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nom des joueurs"
        Me.Motif_joueur1.ResumeLayout(False)
        Me.Motif_joueur2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nom_joueur1 As System.Windows.Forms.TextBox
    Friend WithEvents LesJoueurs As System.Windows.Forms.Label
    Friend WithEvents Motif_joueur1 As System.Windows.Forms.GroupBox
    Friend WithEvents Motif_joueur2 As System.Windows.Forms.GroupBox
    Friend WithEvents nom_joueur2 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2_j1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1_j1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2_j2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1_j2 As System.Windows.Forms.RadioButton
    Friend WithEvents Valider As System.Windows.Forms.Button

End Class
