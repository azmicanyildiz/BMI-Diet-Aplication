<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.ShowPasswordBox = New System.Windows.Forms.TextBox()
        Me.ShowId = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ShowPasswordBox
        '
        Me.ShowPasswordBox.Location = New System.Drawing.Point(70, 90)
        Me.ShowPasswordBox.Name = "ShowPasswordBox"
        Me.ShowPasswordBox.Size = New System.Drawing.Size(199, 20)
        Me.ShowPasswordBox.TabIndex = 10
        Me.ShowPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ShowId
        '
        Me.ShowId.AutoSize = True
        Me.ShowId.BackColor = System.Drawing.Color.Transparent
        Me.ShowId.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ShowId.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ShowId.Location = New System.Drawing.Point(120, 55)
        Me.ShowId.Name = "ShowId"
        Me.ShowId.Size = New System.Drawing.Size(98, 22)
        Me.ShowId.TabIndex = 9
        Me.ShowId.Text = "Id Number"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(100, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Show Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BMI_App.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(334, 211)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShowPasswordBox)
        Me.Controls.Add(Me.ShowId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ForgotPassword"
        Me.Text = "ForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowPasswordBox As TextBox
    Friend WithEvents ShowId As Label
    Friend WithEvents Button1 As Button
End Class
