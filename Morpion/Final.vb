Public Class Final

    Private Sub Final_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        message_fin.Text = Jeu.message
        message_fin.Left = (Me.Width - message_fin.Width) / 2
    End Sub

    Private Sub RejouerNew_Click(sender As Object, e As EventArgs) Handles RejouerNew.Click
        Accueil.Close()
        Jeu.Close()
        Accueil.Show()
        Me.Close()
    End Sub

    Private Sub RejouerIdem_Click(sender As Object, e As EventArgs) Handles RejouerIdem.Click
        Jeu.Close()
        Me.Close()
        Jeu.Show()
    End Sub

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Accueil.Close()
        Jeu.Close()
        Me.Close()
    End Sub
End Class