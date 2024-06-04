Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class NewUser
    Private Function CalculateBMI(weightName As Integer, heightName As Integer) As Double
        ' Converting height to meters
        Dim heightMeter As Double = heightName / 100.0 'convert cm to m


        Dim bmi As Double = weightName / (heightMeter * heightMeter)

        'Round and rotate BMI value
        Return Math.Round(bmi, 2)
    End Function

    'Determination of status
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
    Private Sub CreateAccButton_Click(sender As Object, e As EventArgs) Handles CreateAccButton.Click

        'Checking whether the user left the boxes empty or not

        If String.IsNullOrWhiteSpace(NameBoxSıgn.Text) Then
            MessageBox.Show("Please enter your name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            NameBoxSıgn.Focus()
            Return
        End If


        If String.IsNullOrWhiteSpace(SurnameBoxSıgn.Text) Then
            MessageBox.Show("Please enter your surname.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SurnameBoxSıgn.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(PasswordBoxSıgn.Text) Then
            MessageBox.Show("Please enter your password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PasswordBoxSıgn.Focus()
            Return
        End If

        If Not IsValidEmail(MailBoxSıgn.Text) Then
            MessageBox.Show("Please enter a valid email address. Example: .....@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            MailBoxSıgn.Focus()
            MailBoxSıgn.SelectAll()
            Return
        End If

        If String.IsNullOrWhiteSpace(HeightBoxSign.Text) Then
            MessageBox.Show("Please enter your height.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            HeightBoxSign.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(WeightBoxSıgn.Text) Then
            MessageBox.Show("Please enter your weight.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            WeightBoxSıgn.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(AgeBoxSıgn.Text) Then
            MessageBox.Show("Please enter your age.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            AgeBoxSıgn.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(IdNumberBoxSıgn.Text) Then
            MessageBox.Show("Please enter your ID Number.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            IdNumberBoxSıgn.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(KullanıcıAdıBoxSıgn.Text) Then
            MessageBox.Show("Please enter your User Name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            KullanıcıAdıBoxSıgn.Focus()
            Return
        End If

        If Not MaleRadio.Checked AndAlso Not FemaleRadio.Checked Then
            MessageBox.Show("Please select your gender.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please upload your profile picture.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim connectionString As String = "Server=AZMI-PC;Database=Proje;Integrated Security=True;"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Convert photo to byte array
            Dim profilePictureBytes As Byte() = Nothing
            If PictureBox1.Image IsNot Nothing Then
                profilePictureBytes = ConvertImageToBytes(PictureBox1.Image)
            End If

            ' BMI calculation and status determination
            Dim height As Double = Convert.ToInt32(HeightBoxSign.Text)
            Dim weight As Integer = Convert.ToInt32(WeightBoxSıgn.Text)
            Dim bmi As Double = CalculateBMI(weight, height)
            Dim status As String = DetermineWeightStatus(bmi)

            'Saving user data to sql table
            Dim insertSQL As String = "INSERT INTO Uyeler (Name, Surname, Password, Mail, Height, Weight, Age, IdNumber, Gender, UserName, Status, BMI, Picture) 
                               VALUES (@Name, @Surname, @Password, @Mail, @Height, @Weight, @Age, @IdNumber, @Gender, @UserName, @Status, @BMI, @Picture)"
            Using command As New SqlCommand(insertSQL, connection)
                command.Parameters.AddWithValue("@Name", NameBoxSıgn.Text)
                command.Parameters.AddWithValue("@Surname", SurnameBoxSıgn.Text)
                command.Parameters.AddWithValue("@Password", PasswordBoxSıgn.Text)
                command.Parameters.AddWithValue("@Mail", MailBoxSıgn.Text)
                command.Parameters.AddWithValue("@Height", HeightBoxSign.Text)
                command.Parameters.AddWithValue("@Weight", WeightBoxSıgn.Text)
                command.Parameters.AddWithValue("@Age", AgeBoxSıgn.Text)
                command.Parameters.AddWithValue("@IdNumber", IdNumberBoxSıgn.Text)
                command.Parameters.AddWithValue("@Gender", gender)
                command.Parameters.AddWithValue("@UserName", KullanıcıAdıBoxSıgn.Text)
                command.Parameters.AddWithValue("@Status", status)
                command.Parameters.AddWithValue("@BMI", bmi)
                command.Parameters.AddWithValue("@Picture", If(profilePictureBytes IsNot Nothing, profilePictureBytes, DBNull.Value))

                command.ExecuteNonQuery()

                MessageBox.Show("Successfully Registered.")
            End Using
        End Using

        Me.Close()

    End Sub

    ' 'If the user has image data, this data is converted to an Image object using a MemoryStream.
    Private Function ConvertImageToBytes(image As Image) As Byte()
        Dim memoryStream As New MemoryStream()
        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return memoryStream.ToArray()
    End Function


    Dim gender As String = ""
    Private Sub MaleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles MaleRadio.CheckedChanged
        If MaleRadio.Checked Then
            gender = "Male"
        End If
    End Sub

    Private Sub FemaleRadio_CheckedChanged(sender As Object, e As EventArgs) Handles FemaleRadio.CheckedChanged
        If FemaleRadio.Checked Then
            gender = "Female"
        End If
    End Sub

    Private Sub UploadPictureButton_Click(sender As Object, e As EventArgs) Handles UploadPictureButton.Click
        Dim openFileDialog As New OpenFileDialog()
        'Determines which file types are shown in the file selection window.
        openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp"
        openFileDialog.Title = "Select an image file"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedImage As Image = Image.FromFile(openFileDialog.FileName)
            PictureBox1.Image = selectedImage
        End If
    End Sub

    Private Sub NameBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NameBoxSıgn.KeyPress
        ' If the key pressed is not a letter or a space and is not a control key (for example, Delete or Backspace)...
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = " " AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Prevent key processing
            e.Handled = True
        End If
    End Sub

    Private Sub NameBoxSıgn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NameBoxSıgn.Validating
        Dim name As String = NameBoxSıgn.Text.Trim()
        If Not String.IsNullOrEmpty(name) Then
            If Not Regex.IsMatch(name, "^[a-zA-ZğüşıöçĞÜŞİÖÇ\s]{1,15}$") Then
                MessageBox.Show("Please enter only letters for the name, up to 15 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            Else
                NameBoxSıgn.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower())
            End If
        End If
    End Sub

    Private Sub SurnameBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SurnameBoxSıgn.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not e.KeyChar = " " AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub SurnameBoxSıgn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SurnameBoxSıgn.Validating
        Dim surname As String = SurnameBoxSıgn.Text.Trim()
        If Not String.IsNullOrEmpty(surname) Then
            If Not Regex.IsMatch(surname, "^[a-zA-ZğüşıöçĞÜŞİÖÇ\s]{1,15}$") Then
                MessageBox.Show("Please enter only letters for the surname, up to 15 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            Else
                SurnameBoxSıgn.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(surname.ToLower())
            End If
        End If
    End Sub

    Private Sub PasswordBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordBoxSıgn.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub PasswordBoxSıgn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PasswordBoxSıgn.Validating
        Dim password As String = PasswordBoxSıgn.Text.Trim()
        If Not String.IsNullOrEmpty(password) Then
            ' Boşluk karakterlerine izin vermeyen ve uzunluğu kontrol eden bir regex kullanımı
            If password.Length > 20 OrElse Regex.IsMatch(password, "\s") Then
                MessageBox.Show("Password should be maximum 20 characters and should not contain spaces.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MailBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MailBoxSıgn.KeyPress
        If e.KeyChar = " " Then
            e.Handled = True
        End If
    End Sub
    Private Sub MailBoxSıgn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MailBoxSıgn.Validating
        Dim email As String = MailBoxSıgn.Text.Trim()
        If Not String.IsNullOrEmpty(email) Then
            If email.Length > 30 Then
                MessageBox.Show("Email address should be maximum 30 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub
    Private Function IsValidEmail(email As String) As Boolean
        'Regular expression for real email address check
        Dim emailRegex As String = "^\w+([-+.']\w+)*@\w+([-.]\w+)*\.[a-zA-Z]{2,}$"
        Dim match As Match = Regex.Match(email, emailRegex)
        Return match.Success
    End Function
    Private Sub HeightBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles HeightBoxSign.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub HeightBoxSign_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles HeightBoxSign.Validating
        Dim height As Double
        If Not String.IsNullOrEmpty(HeightBoxSign.Text) Then
            If Not Double.TryParse(HeightBoxSign.Text, height) Then
                MessageBox.Show("Please enter a valid numeric value for height.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            ElseIf height < 50 OrElse height > 300 Then
                MessageBox.Show("Please enter a valid numeric value for weight between 50 and 300.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub WeightBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles WeightBoxSıgn.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub WeightBoxSıgn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WeightBoxSıgn.Validating
        Dim weight As Integer
        If Not String.IsNullOrEmpty(WeightBoxSıgn.Text) Then
            If Not Integer.TryParse(WeightBoxSıgn.Text, weight) Then
                MessageBox.Show("Please enter a valid numeric value for weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            ElseIf weight < 30 OrElse weight > 400 Then
                MessageBox.Show("Please enter a valid numeric value for weight between 30 and 400.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub AgeBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgeBoxSıgn.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AgeBoxSıgn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles AgeBoxSıgn.Validating
        Dim age As Integer
        If Not String.IsNullOrEmpty(AgeBoxSıgn.Text) Then
            If Not Integer.TryParse(AgeBoxSıgn.Text, age) Then
                MessageBox.Show("Please enter a valid numeric value for age.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            ElseIf age < 1 OrElse age > 130 Then
                MessageBox.Show("Please enter a valid numeric value for age between 1 and 130.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub IdNumberBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdNumberBoxSıgn.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub IdNumberBoxSıgn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles IdNumberBoxSıgn.Validating
        Dim idNumber As String = IdNumberBoxSıgn.Text.Trim()
        If Not String.IsNullOrEmpty(idNumber) Then
            If Not Regex.IsMatch(idNumber, "^[1-9]\d{8,14}$") Then
                MessageBox.Show("Please enter a valid ID Number with 9 to 15 digits and does not start with 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True ' İşlemi iptal eder
            Else
                Dim connectionString As String = "Server=AZMI-PC;Database=Proje;Integrated Security=True;"
                Dim query As String = "SELECT COUNT(*) FROM Uyeler WHERE IdNumber = @IdNumber"

                Using connection As New SqlConnection(connectionString)
                    connection.Open()

                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@IdNumber", idNumber)
                        Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                        If count > 0 Then
                            MessageBox.Show("An account with this ID number already exists. Please use a different ID number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            e.Cancel = True
                        End If
                    End Using
                End Using
            End If
        End If
    End Sub

    Private Sub KullanıcıAdıBoxSıgn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KullanıcıAdıBoxSıgn.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub KullanıcıAdıBoxSıgn_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles KullanıcıAdıBoxSıgn.Validating
        Dim userName As String = KullanıcıAdıBoxSıgn.Text.Trim()
        If Not String.IsNullOrEmpty(userName) Then
            If Not Regex.IsMatch(userName, "^[a-zA-Z0-9ığüşıöçĞÜŞİÖÇ]+$") Then
                MessageBox.Show("Please enter only letters and numbers for the username.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                e.Cancel = True
            End If
        End If
    End Sub


End Class