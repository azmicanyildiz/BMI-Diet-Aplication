<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewUser
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
        Me.NameBoxSıgn = New System.Windows.Forms.TextBox()
        Me.SurnameBoxSıgn = New System.Windows.Forms.TextBox()
        Me.PasswordBoxSıgn = New System.Windows.Forms.TextBox()
        Me.MailBoxSıgn = New System.Windows.Forms.TextBox()
        Me.HeightBoxSign = New System.Windows.Forms.TextBox()
        Me.WeightBoxSıgn = New System.Windows.Forms.TextBox()
        Me.AgeBoxSıgn = New System.Windows.Forms.TextBox()
        Me.IdNumberBoxSıgn = New System.Windows.Forms.TextBox()
        Me.MaleRadio = New System.Windows.Forms.RadioButton()
        Me.FemaleRadio = New System.Windows.Forms.RadioButton()
        Me.CreateAccButton = New System.Windows.Forms.Button()
        Me.KullanıcıAdıBoxSıgn = New System.Windows.Forms.TextBox()
        Me.UploadPictureButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameBoxSıgn
        '
        Me.NameBoxSıgn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBoxSıgn.Location = New System.Drawing.Point(148, 22)
        Me.NameBoxSıgn.Name = "NameBoxSıgn"
        Me.NameBoxSıgn.Size = New System.Drawing.Size(202, 22)
        Me.NameBoxSıgn.TabIndex = 1
        Me.NameBoxSıgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SurnameBoxSıgn
        '
        Me.SurnameBoxSıgn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameBoxSıgn.Location = New System.Drawing.Point(148, 68)
        Me.SurnameBoxSıgn.Name = "SurnameBoxSıgn"
        Me.SurnameBoxSıgn.Size = New System.Drawing.Size(202, 22)
        Me.SurnameBoxSıgn.TabIndex = 2
        Me.SurnameBoxSıgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordBoxSıgn
        '
        Me.PasswordBoxSıgn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBoxSıgn.Location = New System.Drawing.Point(148, 119)
        Me.PasswordBoxSıgn.Name = "PasswordBoxSıgn"
        Me.PasswordBoxSıgn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBoxSıgn.Size = New System.Drawing.Size(202, 22)
        Me.PasswordBoxSıgn.TabIndex = 3
        Me.PasswordBoxSıgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MailBoxSıgn
        '
        Me.MailBoxSıgn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MailBoxSıgn.Location = New System.Drawing.Point(148, 171)
        Me.MailBoxSıgn.Name = "MailBoxSıgn"
        Me.MailBoxSıgn.Size = New System.Drawing.Size(202, 22)
        Me.MailBoxSıgn.TabIndex = 4
        Me.MailBoxSıgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeightBoxSign
        '
        Me.HeightBoxSign.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightBoxSign.Location = New System.Drawing.Point(148, 224)
        Me.HeightBoxSign.Name = "HeightBoxSign"
        Me.HeightBoxSign.Size = New System.Drawing.Size(202, 22)
        Me.HeightBoxSign.TabIndex = 5
        Me.HeightBoxSign.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WeightBoxSıgn
        '
        Me.WeightBoxSıgn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightBoxSıgn.Location = New System.Drawing.Point(148, 274)
        Me.WeightBoxSıgn.Name = "WeightBoxSıgn"
        Me.WeightBoxSıgn.Size = New System.Drawing.Size(202, 22)
        Me.WeightBoxSıgn.TabIndex = 6
        Me.WeightBoxSıgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AgeBoxSıgn
        '
        Me.AgeBoxSıgn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeBoxSıgn.Location = New System.Drawing.Point(148, 324)
        Me.AgeBoxSıgn.Name = "AgeBoxSıgn"
        Me.AgeBoxSıgn.Size = New System.Drawing.Size(202, 22)
        Me.AgeBoxSıgn.TabIndex = 7
        Me.AgeBoxSıgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IdNumberBoxSıgn
        '
        Me.IdNumberBoxSıgn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdNumberBoxSıgn.Location = New System.Drawing.Point(148, 375)
        Me.IdNumberBoxSıgn.Name = "IdNumberBoxSıgn"
        Me.IdNumberBoxSıgn.Size = New System.Drawing.Size(202, 22)
        Me.IdNumberBoxSıgn.TabIndex = 8
        Me.IdNumberBoxSıgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MaleRadio
        '
        Me.MaleRadio.AutoSize = True
        Me.MaleRadio.BackColor = System.Drawing.Color.Transparent
        Me.MaleRadio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.MaleRadio.ForeColor = System.Drawing.Color.White
        Me.MaleRadio.Location = New System.Drawing.Point(180, 460)
        Me.MaleRadio.Name = "MaleRadio"
        Me.MaleRadio.Size = New System.Drawing.Size(52, 19)
        Me.MaleRadio.TabIndex = 10
        Me.MaleRadio.TabStop = True
        Me.MaleRadio.Text = "Male"
        Me.MaleRadio.UseVisualStyleBackColor = False
        '
        'FemaleRadio
        '
        Me.FemaleRadio.AutoSize = True
        Me.FemaleRadio.BackColor = System.Drawing.Color.Transparent
        Me.FemaleRadio.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FemaleRadio.ForeColor = System.Drawing.Color.White
        Me.FemaleRadio.Location = New System.Drawing.Point(259, 460)
        Me.FemaleRadio.Name = "FemaleRadio"
        Me.FemaleRadio.Size = New System.Drawing.Size(64, 19)
        Me.FemaleRadio.TabIndex = 11
        Me.FemaleRadio.TabStop = True
        Me.FemaleRadio.Text = "Female"
        Me.FemaleRadio.UseVisualStyleBackColor = False
        '
        'CreateAccButton
        '
        Me.CreateAccButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateAccButton.Location = New System.Drawing.Point(180, 494)
        Me.CreateAccButton.Name = "CreateAccButton"
        Me.CreateAccButton.Size = New System.Drawing.Size(138, 32)
        Me.CreateAccButton.TabIndex = 0
        Me.CreateAccButton.Text = "SIGNUP"
        Me.CreateAccButton.UseVisualStyleBackColor = True
        '
        'KullanıcıAdıBoxSıgn
        '
        Me.KullanıcıAdıBoxSıgn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KullanıcıAdıBoxSıgn.Location = New System.Drawing.Point(148, 422)
        Me.KullanıcıAdıBoxSıgn.Name = "KullanıcıAdıBoxSıgn"
        Me.KullanıcıAdıBoxSıgn.Size = New System.Drawing.Size(202, 22)
        Me.KullanıcıAdıBoxSıgn.TabIndex = 9
        Me.KullanıcıAdıBoxSıgn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UploadPictureButton
        '
        Me.UploadPictureButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UploadPictureButton.Location = New System.Drawing.Point(408, 238)
        Me.UploadPictureButton.Name = "UploadPictureButton"
        Me.UploadPictureButton.Size = New System.Drawing.Size(138, 32)
        Me.UploadPictureButton.TabIndex = 12
        Me.UploadPictureButton.Text = "Choose File"
        Me.UploadPictureButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(396, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 158)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Surname :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(47, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Mail :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(47, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Height :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(47, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Weight :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(47, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Age :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(47, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 19)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Id Number :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(47, 422)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 19)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "User Name :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(446, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "IMAGE"
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BMI_App.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(585, 555)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UploadPictureButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.KullanıcıAdıBoxSıgn)
        Me.Controls.Add(Me.CreateAccButton)
        Me.Controls.Add(Me.FemaleRadio)
        Me.Controls.Add(Me.MaleRadio)
        Me.Controls.Add(Me.IdNumberBoxSıgn)
        Me.Controls.Add(Me.AgeBoxSıgn)
        Me.Controls.Add(Me.WeightBoxSıgn)
        Me.Controls.Add(Me.HeightBoxSign)
        Me.Controls.Add(Me.MailBoxSıgn)
        Me.Controls.Add(Me.PasswordBoxSıgn)
        Me.Controls.Add(Me.SurnameBoxSıgn)
        Me.Controls.Add(Me.NameBoxSıgn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewUser"
        Me.Text = "NewUser"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameBoxSıgn As TextBox
    Friend WithEvents SurnameBoxSıgn As TextBox
    Friend WithEvents PasswordBoxSıgn As TextBox
    Friend WithEvents MailBoxSıgn As TextBox
    Friend WithEvents HeightBoxSign As TextBox
    Friend WithEvents WeightBoxSıgn As TextBox
    Friend WithEvents AgeBoxSıgn As TextBox
    Friend WithEvents IdNumberBoxSıgn As TextBox
    Friend WithEvents MaleRadio As RadioButton
    Friend WithEvents FemaleRadio As RadioButton
    Friend WithEvents CreateAccButton As Button
    Friend WithEvents KullanıcıAdıBoxSıgn As TextBox
    Friend WithEvents UploadPictureButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
