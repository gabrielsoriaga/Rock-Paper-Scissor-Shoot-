Imports System.Media

Public Class Form1

    'This is the game sound
    Public loadGame As New SoundPlayer("C:\Users\gabri\source\repos\RockPaperScissorShoot!\RockPaperScissorShoot!\The Game Show Theme Music.wav")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadGame.PlayLooping()

    End Sub

    Private Sub playButton_Click(sender As Object, e As EventArgs) Handles playButton.Click
        'This will reset Form2() for a new form to be loaded
        Dim newForm2 As New Form2()
        newForm2.Show()
        Me.Hide()

    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Me.Close()
    End Sub

    Private Sub rulesButton_Click(sender As Object, e As EventArgs) Handles rulesButton.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class
