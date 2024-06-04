Imports System.Data.SqlClient
Imports System.IO

Public Class LoginForm
    'This part is for placeholders
    Private Sub KullanıcıAdıBox_GotFocus(sender As Object, e As EventArgs) Handles KullanıcıAdıBox.GotFocus
        If KullanıcıAdıBox.Text = "UserName" Then
            KullanıcıAdıBox.Text = ""
            KullanıcıAdıBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub KullanıcıAdıBox_LostFocus(sender As Object, e As EventArgs) Handles KullanıcıAdıBox.LostFocus
        If KullanıcıAdıBox.Text = "" Then
            KullanıcıAdıBox.Text = "UserName"
            KullanıcıAdıBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub PasswordBox_GotFocus(sender As Object, e As EventArgs) Handles PasswordBox.GotFocus
        If PasswordBox.Text = "Password" Then
            PasswordBox.Text = ""
            PasswordBox.ForeColor = Color.Black
        End If
    End Sub

    Private Sub PasswordBox_LostFocus(sender As Object, e As EventArgs) Handles PasswordBox.LostFocus
        If PasswordBox.Text = "" Then
            PasswordBox.Text = "Password"
            PasswordBox.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PasswordBox.Text = "Password"
        PasswordBox.ForeColor = Color.Gray
        KullanıcıAdıBox.Text = "UserName"
        KullanıcıAdıBox.ForeColor = Color.Gray
    End Sub


    'I specified string to connect SQL
    Dim connectionString As String = "Server=AZMI-PC;Database=Proje;Integrated Security=True;"

    'The username and password are retrieved from the UI and white spaces are cleared.
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim password As String = PasswordBox.Text.Trim()
        Dim kullanıcı As String = KullanıcıAdıBox.Text.Trim()

        'I wrote a query sentence to find the user. I used COLLATE in upper and lower case.

        Dim query As String = "SELECT Name, Surname, Age, Mail, Weight, Height, Gender, IdNumber, Status, BMI, UserName, Picture FROM Uyeler WHERE Password = @Password COLLATE SQL_Latin1_General_CP1_CS_AS AND UserName = @UserName COLLATE SQL_Latin1_General_CP1_CS_AS"



        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Password", password)
                    command.Parameters.AddWithValue("@UserName", kullanıcı)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()

                            Dim firstName As String = reader.GetString(reader.GetOrdinal("Name"))
                            Dim surName As String = reader.GetString(reader.GetOrdinal("Surname"))
                            Dim ageName As Integer = reader.GetInt32(reader.GetOrdinal("Age"))
                            Dim mailName As String = reader.GetString(reader.GetOrdinal("Mail"))
                            Dim weightName As Integer = reader.GetInt32(reader.GetOrdinal("Weight"))
                            Dim heightName As Integer = reader.GetInt32(reader.GetOrdinal("Height"))
                            Dim genderName As String = reader.GetString(reader.GetOrdinal("Gender"))
                            Dim bosluk As String = reader.GetString(reader.GetOrdinal("IdNumber"))
                            Dim status As String = reader.GetString(reader.GetOrdinal("Status"))
                            Dim bmi As Double = reader.GetDouble(reader.GetOrdinal("BMI"))
                            Dim kullanıcıAdı As String = reader.GetString(reader.GetOrdinal("UserName"))

                            'If the user has image data, this data is converted to an Image object using a MemoryStream.
                            Dim picture As Image = Nothing
                            Dim pictureData As Byte() = DirectCast(reader("Picture"), Byte())
                            If pictureData IsNot Nothing Then
                                Using ms As New MemoryStream(pictureData)
                                    picture = Image.FromStream(ms)
                                End Using
                            End If

                            Dim userPanelForm As New NewPanel(firstName, surName, ageName, mailName, weightName, heightName,
                                                       genderName, bosluk, bmi, status, kullanıcıAdı, picture)

                            userPanelForm.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("UserName or Password is incorrect.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub



    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        NewUser.Show()
    End Sub

    Private Sub ForgotButton_Click(sender As Object, e As EventArgs) Handles ForgotButton.Click
        ForgotPassword.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChagePassword.Show()

    End Sub

    Private Sub ForgotNameButton_Click(sender As Object, e As EventArgs) Handles ForgotNameButton.Click
        ForgotUserName.Show()
    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class
