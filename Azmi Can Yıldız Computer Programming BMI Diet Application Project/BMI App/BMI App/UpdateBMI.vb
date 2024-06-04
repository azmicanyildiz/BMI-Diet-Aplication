Imports System.Data.SqlClient

Public Class UpdateBMI

    Private connectionString As String = "Server=AZMI-PC;Database=Proje;Integrated Security=True;"
    Private Sub UpdateWH_Click(sender As Object, e As EventArgs) Handles UpdateWH.Click
        Try
            ' Get new Weight, Height and ID values
            Dim newWeight As Integer = Convert.ToInt32(NewWeightBox.Text)
            Dim newHeight As Double = Convert.ToDouble(NewHeightBox.Text)
            Dim userId As String = IDNumberBox.Text

            ' Update profile
            UpdateProfile(userId, newWeight, newHeight)
        Catch ex As Exception
            MessageBox.Show("Invalid input. Please enter numeric values for weight and height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Profile information update function
    Private Sub UpdateProfile(ByVal userId As String, ByVal newWeight As Integer, ByVal newHeight As Double)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Calculate BMI and determine status
                Dim bmi As Double = CalculateBMI(newWeight, newHeight)
                Dim status As String = DetermineWeightStatus(bmi)

                ' Update query
                Dim updateSQL As String = "UPDATE Uyeler SET Height = @Height, Weight = @Weight, Status = @Status, BMI = @BMI WHERE IdNumber = @IdNumber"

                ' Execute the query
                Using command As New SqlCommand(updateSQL, connection)
                    command.Parameters.AddWithValue("@Weight", newWeight)
                    command.Parameters.AddWithValue("@Height", newHeight)
                    command.Parameters.AddWithValue("@Status", status)
                    command.Parameters.AddWithValue("@BMI", bmi)
                    command.Parameters.AddWithValue("@IdNumber", userId)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Profile information has been updated successfully. Please log in again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Application.Exit()
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating profile information: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function CalculateBMI(weightName As Integer, heightName As Integer) As Double

        Dim heightMeter As Double = heightName / 100.0


        Dim bmi As Double = weightName / (heightMeter * heightMeter)


        Return Math.Round(bmi, 2)
    End Function

    Private Function DetermineWeightStatus(bmi As Double) As String
        If bmi < 18.5 Then
            Return "UnderWeight"
        ElseIf bmi >= 18.5 AndAlso bmi < 25 Then
            Return "NormalWeight"
        ElseIf bmi >= 25 AndAlso bmi < 30 Then
            Return "OverWeight"
        ElseIf bmi >= 30 AndAlso bmi < 35 Then
            Return "Obese"
        Else
            Return "ExtremelyObese"
        End If
    End Function

    Private Sub NewHeightBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewHeightBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub NewHeightBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NewHeightBox.Validating
        Dim height As Double
        If Not String.IsNullOrEmpty(NewHeightBox.Text) Then
            If Not Double.TryParse(NewHeightBox.Text, height) Then
                MessageBox.Show("Please enter a valid numeric value for height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            ElseIf height < 50 OrElse height > 300 Then
                MessageBox.Show("Please enter a valid numeric value for weight between 50 and 300.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub NewWeightBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewWeightBox.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub NewWeightBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NewWeightBox.Validating
        Dim weight As Integer
        If Not String.IsNullOrEmpty(NewWeightBox.Text) Then
            If Not Integer.TryParse(NewWeightBox.Text, weight) Then
                MessageBox.Show("Please enter a valid numeric value for weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            ElseIf weight < 30 OrElse weight > 400 Then
                MessageBox.Show("Please enter a valid numeric value for weight between 30 and 400.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub
End Class
