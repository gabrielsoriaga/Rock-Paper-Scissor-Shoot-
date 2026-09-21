Imports System.Media

Public Class Form3

    'This is to check whether the user have chosen from the choices
    Public choiceRock As Boolean
    Public choicePaper As Boolean
    Public choiceScissor As Boolean

    'This is to check whether the user has won
    Dim winLose As Integer

    'This is used for the display timings of each gif
    Dim elapsedTime As Integer = 0

    'Sound Effects
    Public rockpaperscissorSFX As New SoundPlayer("C:\Users\gabri\source\repos\RockPaperScissorShoot!\RockPaperScissorShoot!\Rock Paper Scissors - Sound Effect-[AudioTrimmer.com].wav")
    Public shootSFX As New SoundPlayer("C:\Users\gabri\source\repos\RockPaperScissorShoot!\RockPaperScissorShoot!\Gunshot Sound Effect Single Shot.wav")

    Dim victorySound As New SoundPlayer("C:\Users\gabri\source\repos\RockPaperScissorShoot!\RockPaperScissorShoot!\Happy Wheels victory green screen.wav")
    Dim loseSound As New SoundPlayer("C:\Users\gabri\source\repos\RockPaperScissorShoot!\RockPaperScissorShoot!\Lose sound effects.wav")
    Dim tieSound As New SoundPlayer("C:\Users\gabri\source\repos\RockPaperScissorShoot!\RockPaperScissorShoot!\You Lose - Is A Tie Sound Effect(2).wav")

    Dim random As New Random

    'This is to show the GIFS in corresponding order based on the sfx
    Sub showGIF(elapsedTime As Integer)
        If elapsedTime = 1000 Then
            rockGIF.Show()
            paperGIF.Hide()
            scissorGIF.Hide()
            rockGIFBot.Show()
            paperGIFBot.Hide()
            scissorGIFBot.Hide()
        ElseIf elapsedTime = 2000 Then
            rockGIF.Hide()
            paperGIF.Show()
            scissorGIF.Hide()
            rockGIFBot.Hide()
            paperGIFBot.Show()
            scissorGIFBot.Hide()
        ElseIf elapsedTime = 3000 Then
            rockGIF.Hide()
            paperGIF.Hide()
            scissorGIF.Show()
            rockGIFBot.Hide()
            paperGIF.Hide()
            scissorGIFBot.Show()
        Else
            rockGIF.Hide()
            paperGIF.Hide()
            scissorGIF.Hide()
            rockGIFBot.Hide()
            paperGIFBot.Hide()
            scissorGIFBot.Hide()
        End If
    End Sub

    'This shows the GIFS based on the users and bot's choice
    Sub winOrLose(botChoice As Integer)

        If choiceRock Then
            rockGIF.Show()
            paperGIF.Hide()
            scissorGIF.Hide()
        ElseIf choicePaper Then
            rockGIF.Hide()
            paperGIF.Show()
            scissorGIF.Hide()
        ElseIf choiceScissor Then
            rockGIF.Hide()
            paperGIF.Hide()
            scissorGIF.Show()
        End If

        If botChoice = 1 Then
            rockGIFBot.Show()
            paperGIFBot.Hide()
            scissorGIFBot.Hide()
        ElseIf botChoice = 2 Then
            rockGIFBot.Hide()
            paperGIFBot.Show()
            scissorGIFBot.Hide()
        ElseIf botChoice = 3 Then
            rockGIFBot.Hide()
            paperGIFBot.Hide()
            scissorGIFBot.Show()
        End If

        'This determines whether the user has won or lost the round with 1 being win, 2 being lose, 3 being a tie
        If (choiceRock And botChoice = 3) Or (choicePaper And botChoice = 1) Or (choiceScissor And botChoice = 2) Then
            winLose = 1
        ElseIf (choiceRock And botChoice = 2) Or (choicePaper And botChoice = 3) Or (choiceScissor And botChoice = 1) Then
            winLose = 2
        ElseIf (choiceRock And botChoice = 1) Or (choicePaper And botChoice = 2) Or (choiceScissor And botChoice = 3) Then
            winLose = 3
        End If
    End Sub

    'This resets everything 
    Public Sub resetGame()
        'This will hide all GIFs
        rockGIF.Hide()
        paperGIF.Hide()
        scissorGIF.Hide()
        rockGIFBot.Hide()
        paperGIFBot.Hide()
        scissorGIFBot.Hide()

        'This will stop all timers
        rockpaperscissortimer.Stop()
        shootTimer.Stop()
        showStatusTimer.Stop()

        'This will reset all variables
        choiceRock = False
        choicePaper = False
        choiceScissor = False
        winLose = Nothing
        elapsedTime = 0

        'This will stop any playing sounds
        rockpaperscissorSFX.Stop()
        shootSFX.Stop()
        victorySound.Stop()
        loseSound.Stop()
        tieSound.Stop()

        'This will hide status and buttons
        statusLabel.Hide()
        retryButton.Hide()
        backButton.Hide()

        'This will restart start the game sound
        Form1.loadGame.Play()

        'This will restart timers for the next game
        rockpaperscissortimer.Interval = 1000
        shootTimer.Interval = 4000
        showStatusTimer.Interval = 6000

        'This will reset the label text
        statusLabel.Text = ""

        'This will restart the rock-paper-scissors sound
        rockpaperscissorSFX.Play()
        rockpaperscissortimer.Start()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This is to hide the GIFS when the form loads
        rockGIF.Hide()
        paperGIF.Hide()
        scissorGIF.Hide()
        rockGIFBot.Hide()
        paperGIFBot.Hide()
        scissorGIFBot.Hide()


        'This starts a timer for the GIFS to show
        rockpaperscissortimer.Interval = 1000
        rockpaperscissortimer.Start()

        'Starting time for corresponding GIFS
        elapsedTime = 0

        'This will hide the status whether win or lose, the try again button and back to menu button
        statusLabel.Hide()
        retryButton.Hide()
        backButton.Hide()

        'This stops the game audio
        Form1.loadGame.Stop()

        'This plays the rock paper scissor audio
        rockpaperscissorSFX.Play()

        'This timer is to time when the status is shown
        showStatusTimer.Interval = 6000
        showStatusTimer.Start()

        shootTimer.Interval = 4000
        shootTimer.Start()

    End Sub

    Private Sub rockpaperscissortimer_Tick(sender As Object, e As EventArgs) Handles rockpaperscissortimer.Tick
        'This is an elapse timer for the GIFS to show one by one
        elapsedTime += 1000

        showGIF(elapsedTime)

        If elapsedTime > 3000 Then
            rockpaperscissortimer.Stop()

        End If
    End Sub

    Private Sub showStatusTimer_Tick(sender As Object, e As EventArgs) Handles showStatusTimer.Tick
        'This shows the menu after the game
        statusLabel.Show()
        retryButton.Show()
        backButton.Show()
    End Sub

    Private Sub shootTimer_Tick(sender As Object, e As EventArgs) Handles shootTimer.Tick
        'This is for the shoot SFX
        shootSFX.Play()
        shootTimer.Stop()

        'To generate the bot's choice
        Dim botChoice As Integer = random.Next(1, 4)

        'To determine the win or lose
        winOrLose(botChoice)

        'This displays the status of the user
        If winLose = 1 Then
            statusLabel.ForeColor = Color.Green
            statusLabel.Text = "You Win!"
            victorySound.Play()
        ElseIf winLose = 2 Then
            statusLabel.ForeColor = Color.Red
            statusLabel.Text = "You Lose."
            loseSound.Play()
        ElseIf winLose = 3 Then
            statusLabel.ForeColor = Color.Brown
            statusLabel.Text = "Tie!"
            tieSound.Play()
        End If
    End Sub
    Private Sub retryButton_Click(sender As Object, e As EventArgs) Handles retryButton.Click
        'This creates a new form so form2 resets
        Dim newForm2 As New Form2()
        newForm2.Show()

        Form1.loadGame.PlayLooping()

        Me.Hide()
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        'This resets a new form for form1 so everything will reset
        Dim newForm1 As New Form1()
        newForm1.Show()
        Me.Hide()
    End Sub

    Private Sub statusLabel_Click(sender As Object, e As EventArgs) Handles statusLabel.Click

    End Sub
End Class