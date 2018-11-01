Imports System.Text.RegularExpressions

Public Class frmCalorieCounter

    ' Auther: Robert Owens   Class: CPS110   Project: Calorie Counter (Procedures)


    ' Restricts user input to numeric only characters including a decimal point.
    ' Uses regex to test if entered text is a valid number.
    ' If the entered text contains a non numeric character or misplaced decimal points, it is replaced with an empty string.

    Private Sub TextBox_Data_Validation(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCarbohydrates.TextChanged,
                                                                                                        txtFat.TextChanged,
                                                                                                        txtProtein.TextChanged

        Dim digitsOnly As Regex = New Regex("^[+|-]?[0-9]*\.?[0-9]*$")     ' Regex matches any valid whole number or decimal.


        ' If there is not a match for a valid number, then remove the typed charecter from the textbox

        If Not digitsOnly.IsMatch(sender.text) And sender.Text.Length > 0 Then

            sender.Text = sender.Text.SubString(0, sender.Text.Length - 1)

        End If

        ' If there is a single character in the textbox and its a decimal point, it is removed.

        If sender.Text.Length = 1 And sender.Text = "." Then

            sender.Text = sender.Text.SubString(0, sender.Text.Length - 1)

        End If


        sender.SelectionStart = sender.Text.Length + 1      ' Set curser position to far right of textbox for ease of typing.

    End Sub



    ' Calls the Calorie computation function on button press.
    ' Then updates the programs output with the result.

    Private Sub btnComputeCalories_Click(sender As Object, e As EventArgs) Handles btnComputeCalories.Click

        UpdateOutput(ComputeCalories)

    End Sub


    ' Clears the Programs output and input when the reset button is clicked.

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ClearOutput()
        ClearInput()

    End Sub


    ' Clears Programs output texboxes.

    Private Sub ClearOutput()

        txtCalculationOutput.Clear()
        txtCalculationOutput.Text = "0 calories per ounce serving."

    End Sub


    ' Clears Programs input textboxes.

    Private Sub ClearInput()

        txtCarbohydrates.Clear()
        txtFat.Clear()
        txtProtein.Clear()

    End Sub


    ' Updated programs output with computed results as digits.

    Private Sub UpdateOutput(ByRef calories_per_ounce As Double)

        If calories_per_ounce > 0 Then
            txtCalculationOutput.Text = calories_per_ounce & " calories per ounce serving."
        Else
            txtCalculationOutput.Text = "0 calories per ounce serving."
        End If


    End Sub


    ' Display dynamic Error Messages to the user.

    Private Sub DisplayError(ByRef error_message As String)

        MessageBox.Show(error_message)

    End Sub


    ' Closes the Windows Form when the exit button is pressed.

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub


    ' Calculates total calories per once of food.
    ' Formula is as follows: (total calories / total grams ) / 28.25.
    ' Where grams per ounce equals 28.25.
    ' Returns a double containing calories per ounce of food.

    Function ComputeCalories()

        'Constants for calories per gram of nutrient.

        Const CALORIES_PER_CARBOHYDRATE_GRAM As Integer = 4
        Const CALORIES_PER_FAT_GRAM As Integer = 9
        Const CALORIES_PER_PROTEIN_GRAM As Integer = 4
        Const GRAMS_PER_OUNCE As Double = 28.35

        ' If there is an empty value an error message is displayed
        ' Else the computation continues

        If txtCarbohydrates.TextLength < 1 OrElse
           txtFat.TextLength < 1 OrElse
           txtProtein.TextLength < 1 Then

            DisplayError("Value Not Entered")

            Return 0

        Else

            ' Local Variables for storing user input.
            Dim grams_of_Carbohydrates As Integer = txtCarbohydrates.Text
            Dim grams_of_fat As Integer = txtFat.Text
            Dim grams_of_protein As Integer = txtProtein.Text

            ' Local Variables to store computations.
            Dim total_grams As Integer = grams_of_Carbohydrates + grams_of_fat + grams_of_protein

            ' Local Variables to store Computed Calories.
            Dim calories_from_carbohydrates As Integer = grams_of_Carbohydrates * CALORIES_PER_CARBOHYDRATE_GRAM
            Dim calories_from_fat As Integer = grams_of_fat * CALORIES_PER_FAT_GRAM
            Dim calories_from_protein As Integer = grams_of_protein * CALORIES_PER_PROTEIN_GRAM

            Dim total_calories As Integer = calories_from_carbohydrates + calories_from_fat + calories_from_protein

            Dim calories_per_gram As Double = total_calories / total_grams
            Dim calories_per_ounce As Double = calories_per_gram * GRAMS_PER_OUNCE

            Return Math.Round(calories_per_ounce, 2) ' Round awnser to 2 decimal places for ease of viewing on screen.

        End If

    End Function

End Class
