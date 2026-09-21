Public Class Form2

    'This ensures that whenever a user has clicked on a icon or GIF, the boolean value will change to true

    Dim choiceRock As Boolean = False
    Dim choicePaper As Boolean = False
    Dim choiceScissor As Boolean = False

    'This helps reset the boolean values if the user wants to retry the game
    Sub showForm3()
        Dim newForm3 As New Form3()

        newForm3.choiceRock = choiceRock
        newForm3.choicePaper = choicePaper
        newForm3.choiceScissor = choiceScissor

        newForm3.Show()
        Me.Hide()
    End Sub

    'This checks what icon or GIF the user has chosen and transfers the boolean values to Form3
    Sub choice()
        If choiceRock = True Then
            Form3.choiceRock = True
        ElseIf choicePaper = True Then
            Form3.choicePaper = True
        ElseIf choiceScissor = True Then
            Form3.choiceScissor = True
        End If
    End Sub

    'Whenever the user picks rock
    Private Sub rockGIF_Click(sender As Object, e As EventArgs) Handles rockGIF.Click
        choiceRock = True
        choicePaper = False
        choiceScissor = False

        choice()

        showForm3()

    End Sub

    'Whenever the user picks paper
    Private Sub paperGIF_Click(sender As Object, e As EventArgs) Handles paperGIF.Click
        choicePaper = True
        choiceRock = False
        choiceScissor = False

        choice()

        showForm3()

    End Sub

    'Whenever the user picks scissor
    Private Sub scissorGIF_Click(sender As Object, e As EventArgs) Handles scissorGIF.Click
        choicePaper = False
        choiceRock = False
        choiceScissor = True

        choice()

        showForm3()

    End Sub

    'This resets the boolean value for both form2 and form3

    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        choiceRock = False
        choicePaper = False
        choiceScissor = False

        Form3.choiceRock = False
        Form3.choicePaper = False
        Form3.choiceScissor = False


    End Sub
End Class