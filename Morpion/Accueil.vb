Public Class Accueil

    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Valider.Enabled = False
    End Sub

    Private Sub RadioButton1_j1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1_j1.CheckedChanged, RadioButton2_j1.CheckedChanged
        If (RadioButton1_j1.Checked) = True Then
            RadioButton2_j2.Checked = True
        End If
        If (RadioButton2_j1.Checked) = True Then
            RadioButton1_j2.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_j2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1_j2.CheckedChanged, RadioButton2_j2.CheckedChanged
        If (RadioButton1_j2.Checked) = True Then
            RadioButton2_j1.Checked = True
        End If
        If (RadioButton2_j2.Checked) = True Then
            RadioButton1_j1.Checked = True
        End If
    End Sub

    Private Sub nom_joueur1_change(sender As Object, e As EventArgs) Handles nom_joueur1.TextChanged
        Motif_joueur1.Text = nom_joueur1.Text
    End Sub

    Private Sub nom_joueur2_change(sender As Object, e As EventArgs) Handles nom_joueur2.TextChanged
        Motif_joueur2.Text = nom_joueur2.Text
    End Sub

    Private Sub nom_joueur1_quitter(sender As Object, e As EventArgs) Handles nom_joueur1.Leave
        If (nom_joueur1.Text = "") Then
            MsgBox("Veuillez entrer un nom pour le joueur 1", vbOKOnly, "Nom de joueur manquant")
            Me.ActiveControl = nom_joueur1
        End If
        If (nom_joueur1.Text <> "" And nom_joueur1.Text = nom_joueur2.Text) Then
            MsgBox("Veuillez changer de nom pour le joueur 1", vbOKOnly, "Nom de joueur identique")
            Me.ActiveControl = nom_joueur1
        End If
    End Sub

    Private Sub nom_joueur2_quitter(sender As Object, e As EventArgs) Handles nom_joueur2.Leave
        If (nom_joueur2.Text = "") Then
            MsgBox("Veuillez entrer un nom pour le joueur 2", vbOKOnly, "Nom de joueur manquant")
            Me.ActiveControl = nom_joueur2
        End If
        If (nom_joueur2.Text <> "" And nom_joueur2.Text = nom_joueur1.Text) Then
            MsgBox("Veuillez changer de nom pour le joueur 2", vbOKOnly, "Nom de joueur identique")
            Me.ActiveControl = nom_joueur2
        End If
    End Sub

    Private Sub Statut_Valider(sender As Object, e As EventArgs) Handles nom_joueur1.TextChanged, nom_joueur2.TextChanged, RadioButton1_j1.CheckedChanged, RadioButton2_j1.CheckedChanged
        If nom_joueur1.Text <> "" And nom_joueur2.Text <> "" And nom_joueur1.Text <> nom_joueur2.Text And (RadioButton1_j1.Checked = True Or RadioButton2_j1.Checked = True) Then
            Valider.Enabled = True
        Else
            Valider.Enabled = False
        End If
    End Sub

    Private Sub Valider_Click(sender As Object, e As EventArgs) Handles Valider.Click
        Jeu.Show()
        Me.Hide()
    End Sub
End Class
