Imports System.Data.SqlClient


Public Class NewPanel

    Inherits System.Windows.Forms.Form

    'These fields hold user information that will be displayed on the form.
    Private _firstName As String
    Private _surname As String
    Private _age As String
    Private _mail As String
    Private _weight As String
    Private _height As String
    Private UserStatus As String
    Private _bmi As String
    Private _gender As String
    Private _bosluk As String
    Private _kullanıcı As String
    Private _picture As Image




    'This constructor is a method that takes user information when creating an instance of the class and
    'places this information in the appropriate text boxes on the form.
    Public Sub New(ByVal firstName As String, ByVal surName As String, ByVal ageName As String, ByVal mailName As String,
                   ByVal weightName As String, ByVal heightName As String,
                   ByVal genderName As String, ByVal bosluk As String, ByVal bmi As String, ByVal status As String, ByVal kullanıcıAdı As String, ByVal picture As Image)
        InitializeComponent()
        _firstName = firstName
        _surname = surName
        _age = ageName
        _mail = mailName
        _weight = weightName
        _height = heightName
        _gender = genderName
        _bosluk = bosluk
        _bmi = bmi
        _gender = genderName
        UserStatus = status
        _kullanıcı = kullanıcıAdı
        _picture = picture


        NameBoxUser.Text = "Name: " & _firstName
        SurnameBoxUser.Text = "Surname: " & _surname
        AgeBoxUser.Text = "Age: " & _age
        MailBoxUser.Text = "Mail: " & _mail
        WeightBoxUser.Text = "Weight: " & _weight
        HeightBoxUser.Text = "Height: " & _height
        IdBoxUser.Text = "IdNumber: " & _bosluk
        BmiBoxUser.Text = "BMI: " & _bmi
        GenderBoxUser.Text = "Gender: " & _gender
        StatusBoxUser.Text = "Status: " & UserStatus
        KullanıcıAdıUser.Text = "UserName: " & _kullanıcı
        PictureBoxProfile.Image = _picture
    End Sub

    Private Sub WeekOneSpor_Click(sender As Object, e As EventArgs) Handles WeekOneSpor.Click
        Select Case UserStatus

            Case "UnderWeight"
                Dim underWeightForm As New WeekOneMoveUW()
                underWeightForm.Show()
            Case "NormalWeight"
                Dim normalWeightForm As New WeekOneMoveN()
                normalWeightForm.Show()
            Case "OverWeight"
                Dim overWeightForm As New WeekOneMoveOW()
                overWeightForm.Show()
            Case "Obese"
                Dim obeseWeightForm As New WeekOneMoveO()
                obeseWeightForm.Show()
            Case "ExtremelyObese"
                Dim extremelyobeseWeightForm As New WeekOneMoveEO()
                extremelyobeseWeightForm.Show()
        End Select

    End Sub

    Private Sub WeekTwoSpor_Click(sender As Object, e As EventArgs) Handles WeekTwoSpor.Click
        Select Case UserStatus

            Case "UnderWeight"
                Dim underWeightForm As New WeekTwoMoveUW()
                underWeightForm.Show()
            Case "NormalWeight"
                Dim normalWeightForm As New WeekTwoMoveN()
                normalWeightForm.Show()
            Case "OverWeight"
                Dim overWeightForm As New WeekTwoMoveOW()
                overWeightForm.Show()
            Case "Obese"
                Dim obeseWeightForm As New WeekTwoMoveO()
                obeseWeightForm.Show()
            Case "ExtremelyObese"
                Dim extremelyobeseWeightForm As New WeekTwoMoveEO()
                extremelyobeseWeightForm.Show()
        End Select
    End Sub

    Private Sub WeekThreeSpor_Click(sender As Object, e As EventArgs) Handles WeekThreeSpor.Click
        Select Case UserStatus

            Case "UnderWeight"
                Dim underWeightForm As New WeekThreeMoveUW()
                underWeightForm.Show()
            Case "NormalWeight"
                Dim normalWeightForm As New WeekThreeMoveN()
                normalWeightForm.Show()
            Case "OverWeight"
                Dim overWeightForm As New WeekThreeMoveOW()
                overWeightForm.Show()
            Case "Obese"
                Dim obeseWeightForm As New WeekThreeMoveO()
                obeseWeightForm.Show()
            Case "ExtremelyObese"
                Dim extremelyobeseWeightForm As New WeekThreeMoveEO()
                extremelyobeseWeightForm.Show()
        End Select
    End Sub

    Private Sub WeekFourSpor_Click(sender As Object, e As EventArgs) Handles WeekFourSpor.Click
        Select Case UserStatus

            Case "UnderWeight"
                Dim underWeightForm As New WeekFourMoveUW()
                underWeightForm.Show()
            Case "NormalWeight"
                Dim normalWeightForm As New WeekFourMoveN()
                normalWeightForm.Show()
            Case "OverWeight"
                Dim overWeightForm As New WeekFourMoveOW()
                overWeightForm.Show()
            Case "Obese"
                Dim obeseWeightForm As New WeekFourMoveO()
                obeseWeightForm.Show()
            Case "ExtremelyObese"
                Dim extremelyobeseWeightForm As New WeekFourMoveEO()
                extremelyobeseWeightForm.Show()
        End Select
    End Sub
    Private connectionString As String = "Server=AZMI-PC;Database=Proje;Integrated Security=True;"

    Public globalWeek As String = "WeekOne"


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Get the number of the selected day
        Dim selectedDay As Integer = ComboBox1.SelectedIndex + 1

        'Determine which week's list to upload

        'Load the list of the selected week
        LoadWeekList(UserStatus, globalWeek, selectedDay)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ComboBox1.Items.Clear()

        ' Just add days of the week to ComboBox
        For i As Integer = 1 To 7
            ComboBox1.Items.Add("Day " & i)
        Next

        ' Select the first day
        ComboBox1.SelectedIndex = 0

        globalWeek = "WeekOne"
        LoadWeekList(UserStatus, globalWeek, 1)

        WeekOneSpor.Visible = True
        WeekTwoSpor.Visible = False
        WeekThreeSpor.Visible = False
        WeekFourSpor.Visible = False



    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ComboBox1.Items.Clear()


        For i As Integer = 1 To 7
            ComboBox1.Items.Add("Day " & i)
        Next


        ComboBox1.SelectedIndex = 0


        globalWeek = "WeekTwo"
        LoadWeekList(UserStatus, globalWeek, 1)

        WeekOneSpor.Visible = False
        WeekTwoSpor.Visible = True
        WeekThreeSpor.Visible = False
        WeekFourSpor.Visible = False


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ComboBox1.Items.Clear()


        For i As Integer = 1 To 7
            ComboBox1.Items.Add("Day " & i)
        Next


        ComboBox1.SelectedIndex = 0


        globalWeek = "WeekThree"
        LoadWeekList(UserStatus, globalWeek, 1)

        WeekOneSpor.Visible = False
        WeekTwoSpor.Visible = False
        WeekThreeSpor.Visible = True
        WeekFourSpor.Visible = False


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ComboBox1.Items.Clear()


        For i As Integer = 1 To 7
            ComboBox1.Items.Add("Day " & i)
        Next


        ComboBox1.SelectedIndex = 0

        globalWeek = "WeekFour"
        LoadWeekList(UserStatus, globalWeek, 1)

        WeekOneSpor.Visible = False
        WeekTwoSpor.Visible = False
        WeekThreeSpor.Visible = False
        WeekFourSpor.Visible = True

    End Sub

    Private Sub LoadWeekList(status As String, weekName As String, startDay As Integer)


        DataGridView1.Rows.Clear()

        'Define a variable to determine the week number
        Dim weekNumber As Integer = -1

        ' Determine the week number based on the week name
        Select Case weekName
            Case "WeekOne"
                weekNumber = 1
            Case "WeekTwo"
                weekNumber = 2
            Case "WeekThree"
                weekNumber = 3
            Case "WeekFour"
                weekNumber = 4
            Case "none"
                weekNumber = 1
        End Select

        ' If a valid week number is found
        If weekNumber <> -1 Then
            ' Load data from database and add DataGridView
            Using connection As New SqlConnection(connectionString)
                Dim query As String = ""
                Select Case status
                    Case "UnderWeight"
                        query = "SELECT * FROM UnderWeight WHERE Weekly = @WeekNumber AND Daily = @Day"
                    Case "NormalWeight"
                        query = "SELECT * FROM NormalWeight WHERE Weekly = @WeekNumber AND Daily = @Day"
                    Case "OverWeight"
                        query = "SELECT * FROM OwerWeight WHERE Weekly = @WeekNumber AND Daily = @Day"
                    Case "Obese"
                        query = "SELECT * FROM Obese WHERE Weekly = @WeekNumber AND Daily = @Day"
                    Case "ExtremelyObese"
                        query = "SELECT * FROM ExtremelyObese WHERE Weekly = @WeekNumber AND Daily = @Day"
                End Select

                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@WeekNumber", weekNumber)
                command.Parameters.AddWithValue("@Day", startDay)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()


                If reader.HasRows Then
                    While reader.Read()
                        ' Add each row to DataGridView
                        DataGridView1.Rows.Add(reader("Season"), reader("FoodName"), reader("Portion"), reader("Calorie"))
                    End While
                End If

                reader.Close()
            End Using
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Clear()


        For i As Integer = 1 To 7
            ComboBox1.Items.Add("Day " & i)
        Next


        ComboBox1.SelectedIndex = 0


        LoadWeekList(UserStatus, globalWeek, 1)

        ShowWeekOneSporButton()

    End Sub


    Private Sub ShowWeekOneSporButton()

        WeekOneSpor.Visible = False
        WeekTwoSpor.Visible = False
        WeekThreeSpor.Visible = False
        WeekFourSpor.Visible = False


        WeekOneSpor.Visible = True
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        UpdateBMI.Show()
    End Sub

    Private Sub NewPanel_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            Application.Exit()
        End If
    End Sub

End Class