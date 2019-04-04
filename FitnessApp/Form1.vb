'Eddie Switek
'10-3-3018
'CST 171 Fall 2018
'Chapter 4 Exercise

'This program calculates how much you've exercised in your entire lifetime
'assuming you have exercised on an average of 2.5 hours a week.

Public Class FitnessApp
    Private Sub FitnessApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'This will calculate the difference in weeks between the User's birthday and today.
        Dim offset = New Date(1, 1, 1)
        Dim dateOne = birthDate.Value
        Dim dateTwo = today.Value
        Dim diff As TimeSpan = dateTwo - dateOne
        Dim years = (offset + diff).Year - 1
        Dim months = (dateTwo.Month - dateOne.Month) '+ 12 * (dateTwo.Year - dateOne.Year)
        Dim weeks = (years * 52) + (months * 4)

        'This calculates how many hours the User has excersized in their lifetime.
        Dim numHoursExercised As Integer = weeks * 2.5

        'Display results on screen.
        lblResults.Text = numHoursExercised.ToString & " hours!"
        lblResults.Show()
        label5.Show()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'This lets the User exit the program.
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'This allows to the User to clear and reset all forms.
        birthDate.ResetText()
        today.ResetText()
        firstName.Clear()
        lblResults.Hide()
        label5.Hide()

    End Sub
End Class
