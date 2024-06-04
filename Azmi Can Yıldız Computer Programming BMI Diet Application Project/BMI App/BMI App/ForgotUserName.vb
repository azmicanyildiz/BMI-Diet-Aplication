Imports System.Data.SqlClient

Public Class ForgotUserName
    Dim connectionString As String = "Server=AZMI-PC;Database=Proje;Integrated Security=True;"

    Private Sub ForgotUserName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ShowUserNameBox KeyPress 
        AddHandler ShowUserNameBox.KeyPress, AddressOf ShowUserNameBox_KeyPress
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Receiving and clearing the user's input
        Dim input As String = ShowUserNameBox.Text.Trim()

        ' Checking whether the user's input is empty and contains only numeric characters
        If String.IsNullOrEmpty(input) OrElse Not input.All(Function(c) Char.IsDigit(c)) Then
            MessageBox.Show("Geçerli bir kullanıcı ID'si girin.")
            Return
        End If

        ' Retrieving the password from the database and displaying it to the user
        Dim username As String = GetUserName(input)
        If Not String.IsNullOrEmpty(username) Then
            MessageBox.Show($"Kullanıcının User Name: {username}")
        Else
            MessageBox.Show("Kullanıcı bulunamadı.")
        End If
    End Sub

    Private Function GetUserName(userId As String) As String
        Dim username As String = ""
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT UserName FROM Uyeler WHERE IdNumber = @IdNumber"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IdNumber", userId)

            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                username = reader("UserName").ToString()
            End If
        End Using
        Return username
    End Function

    Private Sub ShowUserNameBox_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
