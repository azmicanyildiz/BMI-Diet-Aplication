<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChagePassword
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ForgotId = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ForgotNewBox = New System.Windows.Forms.TextBox()
        Me.ForgotIdBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForgotCurrentBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(61, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ForgotId
        '
        Me.ForgotId.AutoSize = True
        Me.ForgotId.BackColor = System.Drawing.Color.Transparent
        Me.ForgotId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForgotId.ForeColor = System.Drawing.Color.White
        Me.ForgotId.Location = New System.Drawing.Point(90, 37)
        Me.ForgotId.Name = "ForgotId"
        Me.ForgotId.Size = New System.Drawing.Size(98, 22)
        Me.ForgotId.TabIndex = 1
        Me.ForgotId.Text = "Id Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(71, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "New Password"
        '
        'ForgotNewBox
        '
        Me.ForgotNewBox.Location = New System.Drawing.Point(35, 220)
        Me.ForgotNewBox.Name = "ForgotNewBox"
        Me.ForgotNewBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ForgotNewBox.Size = New System.Drawing.Size(199, 20)
        Me.ForgotNewBox.TabIndex = 2
        Me.ForgotNewBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ForgotIdBox
        '
        Me.ForgotIdBox.Location = New System.Drawing.Point(35, 68)
        Me.ForgotIdBox.Name = "ForgotIdBox"
        Me.ForgotIdBox.Size = New System.Drawing.Size(199, 20)
        Me.ForgotIdBox.TabIndex = 0
        Me.ForgotIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Current Password"
        '
        'ForgotCurrentBox
        '
        Me.ForgotCurrentBox.Location = New System.Drawing.Point(35, 142)
        Me.ForgotCurrentBox.Name = "ForgotCurrentBox"
        Me.ForgotCurrentBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ForgotCurrentBox.Size = New System.Drawing.Size(199, 20)
        Me.ForgotCurrentBox.TabIndex = 1
        Me.ForgotCurrentBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChagePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BMI_App.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(270, 323)
        Me.Controls.Add(Me.ForgotCurrentBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ForgotIdBox)
        Me.Controls.Add(Me.ForgotNewBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ForgotId)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChagePassword"
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ForgotId As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ForgotNewBox As TextBox
    Friend WithEvents ForgotIdBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ForgotCurrentBox As TextBox
End Class
