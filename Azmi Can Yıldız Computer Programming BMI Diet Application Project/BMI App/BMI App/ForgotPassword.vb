Imports System.Data.SqlClient

Public Class ForgotPassword
    Dim connectionString As String = "Server=AZMI-PC;Database=Proje;Integrated Security=True;"

    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ShowPasswordBox KeyPress 
        AddHandler ShowPasswordBox.KeyPress, AddressOf ShowPasswordBox_KeyPress
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String = ShowPasswordBox.Text.Trim()

        If String.IsNullOrEmpty(input) OrElse Not input.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Enter a valid user ID.")
            Return
        End If

        Dim password As String = GetPassword(input)
        If Not String.IsNullOrEmpty(password) Then
            MessageBox.Show($"User's password: {password}")
        Else
            MessageBox.Show("User not found.")
        End If
    End Sub

    Private Function GetPassword(userId As String) As String
        Dim password As String = ""
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT Password FROM Uyeler WHERE IdNumber = @IdNumber"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdNumber", userId)

            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                password = reader("Password").ToString()
            End If
        End Using
        Return password
    End Function

    Private Sub ShowPasswordBox_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
