<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateBMI
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
        Me.UpdateWH = New System.Windows.Forms.Button()
        Me.NewHeightBox = New System.Windows.Forms.TextBox()
        Me.NewWeightBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDNumberBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UpdateWH
        '
        Me.UpdateWH.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateWH.Location = New System.Drawing.Point(97, 214)
        Me.UpdateWH.Name = "UpdateWH"
        Me.UpdateWH.Size = New System.Drawing.Size(140, 35)
        Me.UpdateWH.TabIndex = 4
        Me.UpdateWH.Text = "UPDATE"
        Me.UpdateWH.UseVisualStyleBackColor = True
        '
        'NewHeightBox
        '
        Me.NewHeightBox.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewHeightBox.Location = New System.Drawing.Point(64, 39)
        Me.NewHeightBox.Name = "NewHeightBox"
        Me.NewHeightBox.Size = New System.Drawing.Size(204, 23)
        Me.NewHeightBox.TabIndex = 5
        Me.NewHeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NewWeightBox
        '
        Me.NewWeightBox.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewWeightBox.Location = New System.Drawing.Point(64, 102)
        Me.NewWeightBox.Name = "NewWeightBox"
        Me.NewWeightBox.Size = New System.Drawing.Size(204, 23)
        Me.NewWeightBox.TabIndex = 6
        Me.NewWeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(122, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "New Weight"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(122, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "New Height"
        '
        'IDNumberBox
        '
        Me.IDNumberBox.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDNumberBox.Location = New System.Drawing.Point(64, 167)
        Me.IDNumberBox.Name = "IDNumberBox"
        Me.IDNumberBox.Size = New System.Drawing.Size(204, 23)
        Me.IDNumberBox.TabIndex = 9
        Me.IDNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(127, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ID Number"
        '
        'UpdateBMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BMI_App.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(335, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IDNumberBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewWeightBox)
        Me.Controls.Add(Me.NewHeightBox)
        Me.Controls.Add(Me.UpdateWH)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UpdateBMI"
        Me.Text = "UpdateBMI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateWH As Button
    Friend WithEvents NewHeightBox As TextBox
    Friend WithEvents NewWeightBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IDNumberBox As TextBox
    Friend WithEvents Label3 As Label
End Class
