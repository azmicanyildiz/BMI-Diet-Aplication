Imports System.Data.SqlClient

Public Class ChagePassword
    Dim connectionString As String = "Server=AZMI-PC;Database=Proje;Integrated Security=True;"

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ForgotIdBox KeyPress olayını bağlama
        AddHandler ForgotIdBox.KeyPress, AddressOf ForgotIdBox_KeyPress
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim currentId As String = ForgotIdBox.Text
        Dim currentPassword As String = ForgotCurrentBox.Text
        Dim newPassword As String = ForgotNewBox.Text

        If String.IsNullOrEmpty(currentId) OrElse String.IsNullOrEmpty(currentPassword) OrElse String.IsNullOrEmpty(newPassword) Then
            MessageBox.Show("Please enter ID, current password and new password.")
            Return
        End If

        ' Checking the username
        If CheckIDAndPassword(currentId, currentPassword) Then
            'Update new password
            If UpdatePassword(currentId, newPassword) Then
                MessageBox.Show("Password has been updated successfully.")
            End If
        Else
            MessageBox.Show("The username or current password is incorrect.")
        End If
    End Sub

    Private Function CheckIDAndPassword(currentId As String, password As String) As Boolean

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM Uyeler WHERE IdNumber = @IdNumber AND Password = @Password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdNumber", currentId)
            command.Parameters.AddWithValue("@Password", password)

            connection.Open()
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())
            Return result > 0
        End Using
    End Function

    Private Function UpdatePassword(currentId As String, newPassword As String) As Boolean
        If newPassword.Contains(" ") Then
            MessageBox.Show("The password cannot contain space characters.")
            Return False
        End If
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "UPDATE Uyeler SET Password = @Password WHERE IdNumber = @IdNumber"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdNumber", currentId)
            command.Parameters.AddWithValue("@Password", newPassword)

            connection.Open()
            Dim rowsAffected As Integer = command.ExecuteNonQuery()
            Return rowsAffected > 0
        End Using
    End Function

    Private Sub ForgotIdBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ForgotIdBox.KeyPress
        ' Sadece sayısal karakterlerin girişine izin ver
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub ForgotCurrentBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ForgotCurrentBox.KeyPress

        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub

    Private Sub ForgotNewBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ForgotNewBox.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
End Class


