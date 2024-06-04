<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ForgotButton = New System.Windows.Forms.Button()
        Me.PasswordBox = New System.Windows.Forms.TextBox()
        Me.KullanıcıAdıBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ForgotNameButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(104, 123)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(140, 35)
        Me.LoginButton.TabIndex = 3
        Me.LoginButton.Text = "LOGIN"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(286, 123)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(140, 35)
        Me.RegisterButton.TabIndex = 4
        Me.RegisterButton.Text = "REGISTER"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'ForgotButton
        '
        Me.ForgotButton.BackColor = System.Drawing.Color.White
        Me.ForgotButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotButton.Location = New System.Drawing.Point(166, 164)
        Me.ForgotButton.Name = "ForgotButton"
        Me.ForgotButton.Size = New System.Drawing.Size(188, 27)
        Me.ForgotButton.TabIndex = 5
        Me.ForgotButton.Text = "Forgot Password"
        Me.ForgotButton.UseVisualStyleBackColor = False
        '
        'PasswordBox
        '
        Me.PasswordBox.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordBox.Location = New System.Drawing.Point(114, 84)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordBox.Size = New System.Drawing.Size(300, 23)
        Me.PasswordBox.TabIndex = 2
        Me.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KullanıcıAdıBox
        '
        Me.KullanıcıAdıBox.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KullanıcıAdıBox.Location = New System.Drawing.Point(114, 46)
        Me.KullanıcıAdıBox.Name = "KullanıcıAdıBox"
        Me.KullanıcıAdıBox.Size = New System.Drawing.Size(300, 23)
        Me.KullanıcıAdıBox.TabIndex = 1
        Me.KullanıcıAdıBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(166, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ForgotNameButton
        '
        Me.ForgotNameButton.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotNameButton.Location = New System.Drawing.Point(166, 197)
        Me.ForgotNameButton.Name = "ForgotNameButton"
        Me.ForgotNameButton.Size = New System.Drawing.Size(188, 27)
        Me.ForgotNameButton.TabIndex = 6
        Me.ForgotNameButton.Text = "Forgot User Name"
        Me.ForgotNameButton.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.BMI_App.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(511, 279)
        Me.Controls.Add(Me.ForgotNameButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.KullanıcıAdıBox)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.ForgotButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.LoginButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.Text = " Login Panel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginButton As Button
    Friend WithEvents RegisterButton As Button
    Friend WithEvents ForgotButton As Button
    Friend WithEvents PasswordBox As TextBox
    Friend WithEvents KullanıcıAdıBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ForgotNameButton As Button
End Class
