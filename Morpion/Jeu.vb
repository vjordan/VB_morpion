Public Class Jeu

    Dim tour As String = "j1"
    Dim nbtours As Integer = 0
    Dim victoire As Boolean = False
    Dim cause As String
    Dim joueur1 As String
    Dim joueur2 As String
    Dim fin As Boolean = False
    Public message As String
    Dim MouseIsDown As Boolean = False

    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Case0.Image = My.Resources.cross

        If (Accueil.RadioButton1_j1.Checked = True) Then
            joueur1 = Accueil.nom_joueur1.Text
            joueur2 = Accueil.nom_joueur2.Text
        Else
            joueur1 = Accueil.nom_joueur2.Text
            joueur2 = Accueil.nom_joueur1.Text
        End If
        JoueurActuel.Text = joueur1

        For i As Byte = 1 To 3
            For j As Byte = 1 To 3
                Me.Controls("Case" & i & "_" & j).BackgroundImage = Nothing
                Me.Controls("Case" & i & "_" & j).AllowDrop = True
            Next
        Next

        Me.Text = "Morpion - " + Accueil.nom_joueur1.Text + " vs " + Accueil.nom_joueur2.Text

        ShapeContainer1.BringToFront()
    End Sub

    Private Sub Jeu_alterne(casejouee)
        If tour = "j1" Then
            Case0.Image = My.Resources.circle
            JoueurActuel.Text = joueur2
            tour = "j2"
        Else
            Case0.Image = My.Resources.cross
            JoueurActuel.Text = joueur1
            tour = "j1"
        End If

        If (nbtours >= 5) Then
            If (casejouee.name = "Case1_1" Or casejouee.name = "Case1_2" Or casejouee.name = "Case1_3") Then
                If (Case1_2.Tag = Case1_1.Tag And Case1_3.Tag = Case1_1.Tag) Then
                    cause = "1ère ligne"
                    victoire = True
                    ligne1.Visible = True
                End If
            End If
            If (casejouee.name = "Case2_1" Or casejouee.name = "Case2_2" Or casejouee.name = "Case2_3") Then
                If (Case2_2.Tag = Case2_1.Tag And Case2_3.Tag = Case2_1.Tag) Then
                    cause = "2ème ligne"
                    victoire = True
                    ligne2.Visible = True
                End If
            End If
            If (casejouee.name = "Case3_1" Or casejouee.name = "Case3_2" Or casejouee.name = "Case3_3") Then
                If (Case3_2.Tag = Case3_1.Tag And Case3_3.Tag = Case3_1.Tag) Then
                    cause = "3ème ligne"
                    victoire = True
                    ligne3.Visible = True
                End If
            End If
            If (casejouee.name = "Case1_1" Or casejouee.name = "Case2_1" Or casejouee.name = "Case3_1") Then
                If (Case2_1.Tag = Case1_1.Tag And Case3_1.Tag = Case1_1.Tag) Then
                    cause = "1ère colonne"
                    victoire = True
                    ligne4.Visible = True
                End If
            End If
            If (casejouee.name = "Case1_2" Or casejouee.name = "Case2_2" Or casejouee.name = "Case3_2") Then
                If (Case2_2.Tag = Case1_2.Tag And Case3_2.Tag = Case1_2.Tag) Then
                    cause = "2ème colonne"
                    victoire = True
                    ligne5.Visible = True
                End If
            End If
            If (casejouee.name = "Case1_3" Or casejouee.name = "Case2_3" Or casejouee.name = "Case3_3") Then
                If (Case2_3.Tag = Case1_3.Tag And Case3_3.Tag = Case1_3.Tag) Then
                    cause = "3ème colonne"
                    victoire = True
                    ligne6.Visible = True
                End If
            End If
            If (casejouee.name = "Case1_1" Or casejouee.name = "Case2_2" Or casejouee.name = "Case3_3") Then
                If (Case2_2.Tag = Case1_1.Tag And Case3_3.Tag = Case1_1.Tag) Then
                    cause = "1ère diagonale"
                    victoire = True
                    ligne7.Visible = True
                End If
            End If
            If (casejouee.name = "Case1_3" Or casejouee.name = "Case2_2" Or casejouee.name = "Case3_1") Then
                If (Case2_2.Tag = Case1_3.Tag And Case3_1.Tag = Case1_3.Tag) Then
                    cause = "2nde diagonale"
                    victoire = True
                    ligne8.Visible = True
                End If
            End If

        End If

        If (victoire = True) Then
            If (tour = "j1") Then
                message = "Victoire de " & joueur2 & " avec les ronds sur la " & cause & " au " & nbtours.ToString & "ème coup !"
            Else
                message = "Victoire de " & joueur1 & " avec les croix sur la " & cause & " au " & nbtours.ToString & "ème coup !"
            End If
            fin = True
        End If

        If (nbtours = 9 And victoire = False) Then
            message = "Egalité !"
            fin = True
        End If

        If (fin = True) Then
            Case0.Image = Nothing
            JoueurActuel.Text = "Aucun : partie terminée"
            Final.Show()
        End If
    End Sub

    Private Sub Case0_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Case0.MouseDown
        If Not Case0.Image Is Nothing Then
            MouseIsDown = True
        End If
    End Sub

    Private Sub Case0_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Case0.MouseMove
        If MouseIsDown Then
            Case0.DoDragDrop(Case0.Image, DragDropEffects.Copy Or DragDropEffects.Move)
            MouseIsDown = False
        End If
    End Sub

    Private Sub Case_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Case1_1.DragEnter, Case1_2.DragEnter, Case1_3.DragEnter, Case2_1.DragEnter, Case2_2.DragEnter, Case2_3.DragEnter, Case3_1.DragEnter, Case3_2.DragEnter, Case3_3.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            If e.KeyState = 9 Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub Case_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Case1_1.DragDrop, Case1_2.DragDrop, Case1_3.DragDrop, Case2_1.DragDrop, Case2_2.DragDrop, Case2_3.DragDrop, Case3_1.DragDrop, Case3_2.DragDrop, Case3_3.DragDrop
        sender.Image = e.Data.GetData(DataFormats.Bitmap)
        sender.Enabled = False
        nbtours = nbtours + 1
        If (nbtours Mod 2 <> 0) Then
            sender.Tag = 1
        Else
            sender.Tag = 2
        End If
        Jeu_alterne(sender)
    End Sub

    Private Sub Case_Click(sender As Object, e As EventArgs) Handles Case1_1.Click, Case1_2.Click, Case1_3.Click, Case2_1.Click, Case2_2.Click, Case2_3.Click, Case3_1.Click, Case3_2.Click, Case3_3.Click
        sender.Image = Case0.Image
        sender.Enabled = False
        nbtours = nbtours + 1
        If (nbtours Mod 2 <> 0) Then
            sender.Tag = 1
        Else
            sender.Tag = 2
        End If
        Jeu_alterne(sender)
    End Sub
End Class