<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmPanel
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Me.AlarmEditBtn = New PSVA.BorderButton()
        Me.AlarmName = New System.Windows.Forms.Label()
        Me.AlarmCaption = New System.Windows.Forms.Label()
        Me.Line = New PSVA.Line()
        Me.AlarmTime = New System.Windows.Forms.Label()
        Me.AppointmentPic = New System.Windows.Forms.PictureBox()
        Me.AppointName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AppointmentPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlarmEditBtn
        '
        Me.AlarmEditBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.AlarmEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlarmEditBtn.EnableBorder = True
        Me.AlarmEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.AlarmEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AlarmEditBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmEditBtn.ForeColor = System.Drawing.Color.Black
        Me.AlarmEditBtn.Location = New System.Drawing.Point(497, 63)
        Me.AlarmEditBtn.Name = "AlarmEditBtn"
        Me.AlarmEditBtn.Size = New System.Drawing.Size(80, 36)
        Me.AlarmEditBtn.TabIndex = 25
        Me.AlarmEditBtn.Text = "Edit"
        Me.AlarmEditBtn.UseVisualStyleBackColor = False
        '
        'AlarmName
        '
        Me.AlarmName.AutoSize = True
        Me.AlarmName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmName.Location = New System.Drawing.Point(164, 14)
        Me.AlarmName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AlarmName.Name = "AlarmName"
        Me.AlarmName.Size = New System.Drawing.Size(135, 25)
        Me.AlarmName.TabIndex = 24
        Me.AlarmName.Text = "ALARM NAME"
        '
        'AlarmCaption
        '
        Me.AlarmCaption.AutoSize = True
        Me.AlarmCaption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmCaption.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AlarmCaption.Location = New System.Drawing.Point(23, 48)
        Me.AlarmCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AlarmCaption.Name = "AlarmCaption"
        Me.AlarmCaption.Size = New System.Drawing.Size(212, 23)
        Me.AlarmCaption.TabIndex = 19
        Me.AlarmCaption.Text = "ALARM CAPTION OR ETC"
        '
        'Line
        '
        Me.Line.BackColor = System.Drawing.Color.Black
        Me.Line.Location = New System.Drawing.Point(20, 106)
        Me.Line.Margin = New System.Windows.Forms.Padding(4)
        Me.Line.Name = "Line"
        Me.Line.Size = New System.Drawing.Size(557, 3)
        Me.Line.TabIndex = 18
        '
        'AlarmTime
        '
        Me.AlarmTime.AutoSize = True
        Me.AlarmTime.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmTime.Location = New System.Drawing.Point(21, 10)
        Me.AlarmTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AlarmTime.Name = "AlarmTime"
        Me.AlarmTime.Size = New System.Drawing.Size(116, 31)
        Me.AlarmTime.TabIndex = 20
        Me.AlarmTime.Text = "00:00 AM"
        '
        'AppointmentPic
        '
        Me.AppointmentPic.Image = Global.PSVA.My.Resources.Resources.ic_alarm_add_black_24dp
        Me.AppointmentPic.Location = New System.Drawing.Point(137, 10)
        Me.AppointmentPic.Margin = New System.Windows.Forms.Padding(4)
        Me.AppointmentPic.Name = "AppointmentPic"
        Me.AppointmentPic.Size = New System.Drawing.Size(29, 30)
        Me.AppointmentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AppointmentPic.TabIndex = 23
        Me.AppointmentPic.TabStop = False
        '
        'AppointName
        '
        Me.AppointName.AutoSize = True
        Me.AppointName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointName.Location = New System.Drawing.Point(336, 14)
        Me.AppointName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AppointName.Name = "AppointName"
        Me.AppointName.Size = New System.Drawing.Size(203, 25)
        Me.AppointName.TabIndex = 27
        Me.AppointName.Text = "APPOINTMENT NAME"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PSVA.My.Resources.Resources.ic_done_black_24dp
        Me.PictureBox1.Location = New System.Drawing.Point(309, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'AlarmPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AppointName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AlarmEditBtn)
        Me.Controls.Add(Me.AlarmName)
        Me.Controls.Add(Me.AppointmentPic)
        Me.Controls.Add(Me.AlarmCaption)
        Me.Controls.Add(Me.Line)
        Me.Controls.Add(Me.AlarmTime)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AlarmPanel"
        Me.Size = New System.Drawing.Size(584, 120)
        CType(Me.AppointmentPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlarmEditBtn As BorderButton
    Friend WithEvents AlarmName As Label
    Friend WithEvents AppointmentPic As PictureBox
    Friend WithEvents AlarmCaption As Label
    Friend WithEvents Line As Line
    Friend WithEvents AlarmTime As Label
    Friend WithEvents AppointName As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
