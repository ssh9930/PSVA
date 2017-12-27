<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmCreateWnd
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AlarmMenuBtn = New System.Windows.Forms.PictureBox()
        Me.Label_2 = New System.Windows.Forms.Label()
        Me.Label_1 = New System.Windows.Forms.Label()
        Me.Line4 = New PSVA.Line()
        Me.AlarmName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Line1 = New PSVA.Line()
        Me.Line2 = New PSVA.Line()
        Me.AlarmCaption = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NextBtn = New PSVA.BorderButton()
        Me.Panel3.SuspendLayout()
        CType(Me.AlarmMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.AlarmMenuBtn)
        Me.Panel3.Controls.Add(Me.Label_2)
        Me.Panel3.Controls.Add(Me.Label_1)
        Me.Panel3.Controls.Add(Me.Line4)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(420, 78)
        Me.Panel3.TabIndex = 18
        '
        'AlarmMenuBtn
        '
        Me.AlarmMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlarmMenuBtn.Image = Global.PSVA.My.Resources.Resources.ic_alarm_add_black_24dp
        Me.AlarmMenuBtn.Location = New System.Drawing.Point(12, 17)
        Me.AlarmMenuBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AlarmMenuBtn.Name = "AlarmMenuBtn"
        Me.AlarmMenuBtn.Size = New System.Drawing.Size(40, 40)
        Me.AlarmMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlarmMenuBtn.TabIndex = 21
        Me.AlarmMenuBtn.TabStop = False
        '
        'Label_2
        '
        Me.Label_2.AutoSize = True
        Me.Label_2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_2.ForeColor = System.Drawing.Color.Black
        Me.Label_2.Location = New System.Drawing.Point(58, 46)
        Me.Label_2.Name = "Label_2"
        Me.Label_2.Size = New System.Drawing.Size(203, 13)
        Me.Label_2.TabIndex = 19
        Me.Label_2.Text = "ENTER ALARM NAME AND CAPTION."
        '
        'Label_1
        '
        Me.Label_1.AutoSize = True
        Me.Label_1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_1.Location = New System.Drawing.Point(57, 17)
        Me.Label_1.Name = "Label_1"
        Me.Label_1.Size = New System.Drawing.Size(121, 20)
        Me.Label_1.TabIndex = 17
        Me.Label_1.Text = "CREATE ALARM"
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Black
        Me.Line4.Location = New System.Drawing.Point(61, 41)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(200, 2)
        Me.Line4.TabIndex = 18
        '
        'AlarmName
        '
        Me.AlarmName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmName.Location = New System.Drawing.Point(12, 128)
        Me.AlarmName.Name = "AlarmName"
        Me.AlarmName.Size = New System.Drawing.Size(351, 25)
        Me.AlarmName.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(12, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "ALARM NAME"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Black
        Me.Line1.Location = New System.Drawing.Point(103, 102)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(260, 2)
        Me.Line1.TabIndex = 19
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.Black
        Me.Line2.Location = New System.Drawing.Point(123, 175)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(240, 2)
        Me.Line2.TabIndex = 30
        '
        'AlarmCaption
        '
        Me.AlarmCaption.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmCaption.Location = New System.Drawing.Point(12, 201)
        Me.AlarmCaption.Name = "AlarmCaption"
        Me.AlarmCaption.Size = New System.Drawing.Size(351, 25)
        Me.AlarmCaption.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ALARM CAPTION"
        '
        'NextBtn
        '
        Me.NextBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NextBtn.EnableBorder = True
        Me.NextBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextBtn.Location = New System.Drawing.Point(307, 255)
        Me.NextBtn.Name = "NextBtn"
        Me.NextBtn.Size = New System.Drawing.Size(56, 23)
        Me.NextBtn.TabIndex = 33
        Me.NextBtn.Text = "NEXT"
        Me.NextBtn.UseVisualStyleBackColor = False
        '
        'AlarmCreateWnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 290)
        Me.Controls.Add(Me.NextBtn)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.AlarmCaption)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AlarmName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(402, 329)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(402, 329)
        Me.Name = "AlarmCreateWnd"
        Me.Text = "Create New Alarm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AlarmMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents AlarmMenuBtn As PictureBox
    Friend WithEvents Label_2 As Label
    Friend WithEvents Label_1 As Label
    Friend WithEvents Line4 As Line
    Friend WithEvents AlarmName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Line1 As Line
    Friend WithEvents Line2 As Line
    Friend WithEvents AlarmCaption As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NextBtn As BorderButton
End Class
