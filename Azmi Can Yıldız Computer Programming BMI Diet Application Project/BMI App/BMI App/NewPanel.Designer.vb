<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewPanel
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.WeekThreeSpor = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DietList = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SeasonName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Food_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PortionName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CalorieName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeekTwoSpor = New System.Windows.Forms.Button()
        Me.WeekOneSpor = New System.Windows.Forms.Button()
        Me.WeekFourSpor = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.PictureBoxProfile = New System.Windows.Forms.PictureBox()
        Me.KullanıcıAdıUser = New System.Windows.Forms.Label()
        Me.StatusBoxUser = New System.Windows.Forms.Label()
        Me.BmiBoxUser = New System.Windows.Forms.Label()
        Me.IdBoxUser = New System.Windows.Forms.Label()
        Me.GenderBoxUser = New System.Windows.Forms.Label()
        Me.HeightBoxUser = New System.Windows.Forms.Label()
        Me.WeightBoxUser = New System.Windows.Forms.Label()
        Me.MailBoxUser = New System.Windows.Forms.Label()
        Me.AgeBoxUser = New System.Windows.Forms.Label()
        Me.SurnameBoxUser = New System.Windows.Forms.Label()
        Me.NameBoxUser = New System.Windows.Forms.Label()
        Me.SqLiteCommandBuilder1 = New System.Data.SQLite.SQLiteCommandBuilder()
        Me.UserInfo = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DietList.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'WeekThreeSpor
        '
        Me.WeekThreeSpor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WeekThreeSpor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.WeekThreeSpor.Location = New System.Drawing.Point(260, 520)
        Me.WeekThreeSpor.Name = "WeekThreeSpor"
        Me.WeekThreeSpor.Size = New System.Drawing.Size(247, 50)
        Me.WeekThreeSpor.TabIndex = 2
        Me.WeekThreeSpor.Text = "Biceps Area"
        Me.WeekThreeSpor.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(27, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 49)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Week One List"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImage = Global.BMI_App.My.Resources.Resources.SporResim1_removebg_preview
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(524, 475)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 150)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.BMI_App.My.Resources.Resources.SporResim2_removebg_preview
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(27, 466)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 168)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'DietList
        '
        Me.DietList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DietList.BackColor = System.Drawing.Color.Silver
        Me.DietList.Controls.Add(Me.PictureBox3)
        Me.DietList.Controls.Add(Me.ComboBox1)
        Me.DietList.Controls.Add(Me.Button4)
        Me.DietList.Controls.Add(Me.WeekThreeSpor)
        Me.DietList.Controls.Add(Me.Button3)
        Me.DietList.Controls.Add(Me.Button2)
        Me.DietList.Controls.Add(Me.Button1)
        Me.DietList.Controls.Add(Me.DataGridView1)
        Me.DietList.Controls.Add(Me.PictureBox2)
        Me.DietList.Controls.Add(Me.PictureBox1)
        Me.DietList.Controls.Add(Me.WeekTwoSpor)
        Me.DietList.Controls.Add(Me.WeekOneSpor)
        Me.DietList.Controls.Add(Me.WeekFourSpor)
        Me.DietList.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DietList.ForeColor = System.Drawing.Color.Black
        Me.DietList.Location = New System.Drawing.Point(361, 12)
        Me.DietList.Name = "DietList"
        Me.DietList.Size = New System.Drawing.Size(743, 676)
        Me.DietList.TabIndex = 3
        Me.DietList.TabStop = False
        Me.DietList.Text = "Diet Interface"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackgroundImage = Global.BMI_App.My.Resources.Resources.resim
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(61, 268)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(638, 192)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(27, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(575, 19)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 49)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Week Four List"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(386, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(157, 49)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Week Three List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(210, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 49)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Week Two List"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Silver
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SeasonName, Me.Food_Name, Me.PortionName, Me.CalorieName})
        Me.DataGridView1.Location = New System.Drawing.Point(27, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(697, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'SeasonName
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.SeasonName.DefaultCellStyle = DataGridViewCellStyle1
        Me.SeasonName.HeaderText = "Season"
        Me.SeasonName.Name = "SeasonName"
        Me.SeasonName.ReadOnly = True
        Me.SeasonName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SeasonName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.SeasonName.Width = 90
        '
        'Food_Name
        '
        Me.Food_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.Food_Name.DefaultCellStyle = DataGridViewCellStyle2
        Me.Food_Name.HeaderText = "Food"
        Me.Food_Name.Name = "Food_Name"
        Me.Food_Name.ReadOnly = True
        Me.Food_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Food_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PortionName
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.PortionName.DefaultCellStyle = DataGridViewCellStyle3
        Me.PortionName.HeaderText = "Portion"
        Me.PortionName.Name = "PortionName"
        Me.PortionName.ReadOnly = True
        Me.PortionName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PortionName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PortionName.Width = 80
        '
        'CalorieName
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.CalorieName.DefaultCellStyle = DataGridViewCellStyle4
        Me.CalorieName.HeaderText = "Calorie"
        Me.CalorieName.Name = "CalorieName"
        Me.CalorieName.ReadOnly = True
        Me.CalorieName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CalorieName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CalorieName.Width = 60
        '
        'WeekTwoSpor
        '
        Me.WeekTwoSpor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WeekTwoSpor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekTwoSpor.Location = New System.Drawing.Point(260, 520)
        Me.WeekTwoSpor.Name = "WeekTwoSpor"
        Me.WeekTwoSpor.Size = New System.Drawing.Size(247, 50)
        Me.WeekTwoSpor.TabIndex = 1
        Me.WeekTwoSpor.Text = "Back Area"
        Me.WeekTwoSpor.UseVisualStyleBackColor = True
        '
        'WeekOneSpor
        '
        Me.WeekOneSpor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WeekOneSpor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekOneSpor.Location = New System.Drawing.Point(260, 520)
        Me.WeekOneSpor.Name = "WeekOneSpor"
        Me.WeekOneSpor.Size = New System.Drawing.Size(247, 50)
        Me.WeekOneSpor.TabIndex = 0
        Me.WeekOneSpor.Text = "Abdominal Area"
        Me.WeekOneSpor.UseVisualStyleBackColor = True
        '
        'WeekFourSpor
        '
        Me.WeekFourSpor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WeekFourSpor.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekFourSpor.Location = New System.Drawing.Point(260, 520)
        Me.WeekFourSpor.Name = "WeekFourSpor"
        Me.WeekFourSpor.Size = New System.Drawing.Size(247, 50)
        Me.WeekFourSpor.TabIndex = 3
        Me.WeekFourSpor.Text = "Leg Movements"
        Me.WeekFourSpor.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(6, 639)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(163, 31)
        Me.UpdateButton.TabIndex = 23
        Me.UpdateButton.Text = "Change BMI"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'PictureBoxProfile
        '
        Me.PictureBoxProfile.BackColor = System.Drawing.Color.White
        Me.PictureBoxProfile.Location = New System.Drawing.Point(69, 21)
        Me.PictureBoxProfile.Name = "PictureBoxProfile"
        Me.PictureBoxProfile.Size = New System.Drawing.Size(191, 166)
        Me.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProfile.TabIndex = 22
        Me.PictureBoxProfile.TabStop = False
        '
        'KullanıcıAdıUser
        '
        Me.KullanıcıAdıUser.AutoSize = True
        Me.KullanıcıAdıUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KullanıcıAdıUser.Location = New System.Drawing.Point(29, 604)
        Me.KullanıcıAdıUser.Name = "KullanıcıAdıUser"
        Me.KullanıcıAdıUser.Size = New System.Drawing.Size(90, 19)
        Me.KullanıcıAdıUser.TabIndex = 21
        Me.KullanıcıAdıUser.Text = "UserName :"
        '
        'StatusBoxUser
        '
        Me.StatusBoxUser.AutoSize = True
        Me.StatusBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBoxUser.Location = New System.Drawing.Point(29, 445)
        Me.StatusBoxUser.Name = "StatusBoxUser"
        Me.StatusBoxUser.Size = New System.Drawing.Size(60, 19)
        Me.StatusBoxUser.TabIndex = 20
        Me.StatusBoxUser.Text = "Status :"
        '
        'BmiBoxUser
        '
        Me.BmiBoxUser.AutoSize = True
        Me.BmiBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BmiBoxUser.Location = New System.Drawing.Point(29, 485)
        Me.BmiBoxUser.Name = "BmiBoxUser"
        Me.BmiBoxUser.Size = New System.Drawing.Size(51, 19)
        Me.BmiBoxUser.TabIndex = 19
        Me.BmiBoxUser.Text = "BMI :"
        '
        'IdBoxUser
        '
        Me.IdBoxUser.AutoSize = True
        Me.IdBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdBoxUser.Location = New System.Drawing.Point(29, 565)
        Me.IdBoxUser.Name = "IdBoxUser"
        Me.IdBoxUser.Size = New System.Drawing.Size(36, 19)
        Me.IdBoxUser.TabIndex = 18
        Me.IdBoxUser.Text = "ID :"
        '
        'GenderBoxUser
        '
        Me.GenderBoxUser.AutoSize = True
        Me.GenderBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderBoxUser.Location = New System.Drawing.Point(29, 525)
        Me.GenderBoxUser.Name = "GenderBoxUser"
        Me.GenderBoxUser.Size = New System.Drawing.Size(68, 19)
        Me.GenderBoxUser.TabIndex = 17
        Me.GenderBoxUser.Text = "Gender :"
        '
        'HeightBoxUser
        '
        Me.HeightBoxUser.AutoSize = True
        Me.HeightBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightBoxUser.Location = New System.Drawing.Point(29, 405)
        Me.HeightBoxUser.Name = "HeightBoxUser"
        Me.HeightBoxUser.Size = New System.Drawing.Size(63, 19)
        Me.HeightBoxUser.TabIndex = 16
        Me.HeightBoxUser.Text = "Height :"
        '
        'WeightBoxUser
        '
        Me.WeightBoxUser.AutoSize = True
        Me.WeightBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightBoxUser.Location = New System.Drawing.Point(29, 365)
        Me.WeightBoxUser.Name = "WeightBoxUser"
        Me.WeightBoxUser.Size = New System.Drawing.Size(65, 19)
        Me.WeightBoxUser.TabIndex = 15
        Me.WeightBoxUser.Text = "Weight :"
        '
        'MailBoxUser
        '
        Me.MailBoxUser.AutoSize = True
        Me.MailBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailBoxUser.Location = New System.Drawing.Point(29, 325)
        Me.MailBoxUser.Name = "MailBoxUser"
        Me.MailBoxUser.Size = New System.Drawing.Size(50, 19)
        Me.MailBoxUser.TabIndex = 14
        Me.MailBoxUser.Text = "Mail :"
        '
        'AgeBoxUser
        '
        Me.AgeBoxUser.AutoSize = True
        Me.AgeBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeBoxUser.Location = New System.Drawing.Point(29, 285)
        Me.AgeBoxUser.Name = "AgeBoxUser"
        Me.AgeBoxUser.Size = New System.Drawing.Size(45, 19)
        Me.AgeBoxUser.TabIndex = 13
        Me.AgeBoxUser.Text = "Age :"
        '
        'SurnameBoxUser
        '
        Me.SurnameBoxUser.AutoSize = True
        Me.SurnameBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameBoxUser.Location = New System.Drawing.Point(29, 245)
        Me.SurnameBoxUser.Name = "SurnameBoxUser"
        Me.SurnameBoxUser.Size = New System.Drawing.Size(77, 19)
        Me.SurnameBoxUser.TabIndex = 12
        Me.SurnameBoxUser.Text = "Surname :"
        '
        'NameBoxUser
        '
        Me.NameBoxUser.AutoSize = True
        Me.NameBoxUser.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.NameBoxUser.Location = New System.Drawing.Point(29, 205)
        Me.NameBoxUser.Name = "NameBoxUser"
        Me.NameBoxUser.Size = New System.Drawing.Size(58, 19)
        Me.NameBoxUser.TabIndex = 11
        Me.NameBoxUser.Text = "Name :"
        '
        'SqLiteCommandBuilder1
        '
        Me.SqLiteCommandBuilder1.DataAdapter = Nothing
        Me.SqLiteCommandBuilder1.QuoteSuffix = "]"
        '
        'UserInfo
        '
        Me.UserInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.UserInfo.BackColor = System.Drawing.Color.Silver
        Me.UserInfo.Controls.Add(Me.UpdateButton)
        Me.UserInfo.Controls.Add(Me.PictureBoxProfile)
        Me.UserInfo.Controls.Add(Me.KullanıcıAdıUser)
        Me.UserInfo.Controls.Add(Me.StatusBoxUser)
        Me.UserInfo.Controls.Add(Me.BmiBoxUser)
        Me.UserInfo.Controls.Add(Me.IdBoxUser)
        Me.UserInfo.Controls.Add(Me.GenderBoxUser)
        Me.UserInfo.Controls.Add(Me.HeightBoxUser)
        Me.UserInfo.Controls.Add(Me.WeightBoxUser)
        Me.UserInfo.Controls.Add(Me.MailBoxUser)
        Me.UserInfo.Controls.Add(Me.AgeBoxUser)
        Me.UserInfo.Controls.Add(Me.SurnameBoxUser)
        Me.UserInfo.Controls.Add(Me.NameBoxUser)
        Me.UserInfo.Cursor = System.Windows.Forms.Cursors.Default
        Me.UserInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UserInfo.Location = New System.Drawing.Point(18, 12)
        Me.UserInfo.Name = "UserInfo"
        Me.UserInfo.Size = New System.Drawing.Size(320, 676)
        Me.UserInfo.TabIndex = 2
        Me.UserInfo.TabStop = False
        Me.UserInfo.Text = "User Interface"
        '
        'NewPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BMI_App.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1123, 700)
        Me.Controls.Add(Me.DietList)
        Me.Controls.Add(Me.UserInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewPanel"
        Me.Text = "UserPanel"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DietList.ResumeLayout(False)
        Me.DietList.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserInfo.ResumeLayout(False)
        Me.UserInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WeekThreeSpor As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DietList As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SeasonName As DataGridViewTextBoxColumn
    Friend WithEvents Food_Name As DataGridViewTextBoxColumn
    Friend WithEvents PortionName As DataGridViewTextBoxColumn
    Friend WithEvents CalorieName As DataGridViewTextBoxColumn
    Friend WithEvents WeekTwoSpor As Button
    Friend WithEvents WeekOneSpor As Button
    Friend WithEvents WeekFourSpor As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents UpdateButton As Button
    Friend WithEvents PictureBoxProfile As PictureBox
    Friend WithEvents KullanıcıAdıUser As Label
    Friend WithEvents StatusBoxUser As Label
    Friend WithEvents BmiBoxUser As Label
    Friend WithEvents IdBoxUser As Label
    Friend WithEvents GenderBoxUser As Label
    Friend WithEvents HeightBoxUser As Label
    Friend WithEvents WeightBoxUser As Label
    Friend WithEvents MailBoxUser As Label
    Friend WithEvents AgeBoxUser As Label
    Friend WithEvents SurnameBoxUser As Label
    Friend WithEvents NameBoxUser As Label
    Friend WithEvents SqLiteCommandBuilder1 As SQLite.SQLiteCommandBuilder
    Friend WithEvents UserInfo As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
