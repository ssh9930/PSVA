<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmSettingPanel
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AlarmMenuBtn = New System.Windows.Forms.PictureBox()
        Me.AlarmCaption = New System.Windows.Forms.Label()
        Me.AlarmName = New System.Windows.Forms.Label()
        Me.Line4 = New PSVA.Line()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Line1 = New PSVA.Line()
        Me.RIngTimeH = New System.Windows.Forms.NumericUpDown()
        Me.RIngTImeM = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox__ = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RIngDayWeekday = New System.Windows.Forms.RadioButton()
        Me.RIngDayWeekend = New System.Windows.Forms.RadioButton()
        Me.RingDayAll = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RingDaySa = New System.Windows.Forms.CheckBox()
        Me.RIngDayW = New System.Windows.Forms.CheckBox()
        Me.RIngDayF = New System.Windows.Forms.CheckBox()
        Me.RingDayTu = New System.Windows.Forms.CheckBox()
        Me.RingDaySu = New System.Windows.Forms.CheckBox()
        Me.RingDayTh = New System.Windows.Forms.CheckBox()
        Me.RingDayM = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Line2 = New PSVA.Line()
        Me.Line3 = New PSVA.Line()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ScheduleName = New System.Windows.Forms.TextBox()
        Me.ScheduleTImeM = New System.Windows.Forms.NumericUpDown()
        Me.ScheduleTimeH = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Line5 = New PSVA.Line()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.AlarmMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIngTimeH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIngTImeM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox__.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ScheduleTImeM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleTimeH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.AlarmMenuBtn)
        Me.Panel3.Controls.Add(Me.AlarmCaption)
        Me.Panel3.Controls.Add(Me.AlarmName)
        Me.Panel3.Controls.Add(Me.Line4)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 117)
        Me.Panel3.TabIndex = 17
        '
        'AlarmMenuBtn
        '
        Me.AlarmMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlarmMenuBtn.Image = Global.PSVA.My.Resources.Resources.ic_alarm_add_black_24dp
        Me.AlarmMenuBtn.Location = New System.Drawing.Point(17, 26)
        Me.AlarmMenuBtn.Name = "AlarmMenuBtn"
        Me.AlarmMenuBtn.Size = New System.Drawing.Size(57, 60)
        Me.AlarmMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlarmMenuBtn.TabIndex = 21
        Me.AlarmMenuBtn.TabStop = False
        '
        'AlarmCaption
        '
        Me.AlarmCaption.AutoSize = True
        Me.AlarmCaption.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmCaption.ForeColor = System.Drawing.Color.Maroon
        Me.AlarmCaption.Location = New System.Drawing.Point(83, 69)
        Me.AlarmCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AlarmCaption.Name = "AlarmCaption"
        Me.AlarmCaption.Size = New System.Drawing.Size(495, 23)
        Me.AlarmCaption.TabIndex = 19
        Me.AlarmCaption.Text = "NOT AN COMPLETE USER INTERFACE, MAY BE SUPERA UGLY"
        '
        'AlarmName
        '
        Me.AlarmName.AutoSize = True
        Me.AlarmName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlarmName.Location = New System.Drawing.Point(81, 26)
        Me.AlarmName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AlarmName.Name = "AlarmName"
        Me.AlarmName.Size = New System.Drawing.Size(207, 31)
        Me.AlarmName.TabIndex = 17
        Me.AlarmName.Text = "ALARM SETTINGS"
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Black
        Me.Line4.Location = New System.Drawing.Point(87, 62)
        Me.Line4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(410, 3)
        Me.Line4.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 141)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "RING TIME SETTINGS"
        '
        'Line1
        '
        Me.Line1.BackColor = System.Drawing.Color.Black
        Me.Line1.Location = New System.Drawing.Point(219, 152)
        Me.Line1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(286, 3)
        Me.Line1.TabIndex = 19
        '
        'RIngTimeH
        '
        Me.RIngTimeH.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIngTimeH.Location = New System.Drawing.Point(29, 74)
        Me.RIngTimeH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RIngTimeH.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.RIngTimeH.Name = "RIngTimeH"
        Me.RIngTimeH.Size = New System.Drawing.Size(100, 58)
        Me.RIngTimeH.TabIndex = 23
        '
        'RIngTImeM
        '
        Me.RIngTImeM.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIngTImeM.Location = New System.Drawing.Point(173, 74)
        Me.RIngTImeM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RIngTImeM.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.RIngTImeM.Name = "RIngTImeM"
        Me.RIngTImeM.Size = New System.Drawing.Size(100, 58)
        Me.RIngTImeM.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ALARM RING TIME"
        '
        'GroupBox__
        '
        Me.GroupBox__.Controls.Add(Me.Label7)
        Me.GroupBox__.Controls.Add(Me.Label5)
        Me.GroupBox__.Controls.Add(Me.Label4)
        Me.GroupBox__.Controls.Add(Me.Label3)
        Me.GroupBox__.Controls.Add(Me.Label2)
        Me.GroupBox__.Controls.Add(Me.RIngTImeM)
        Me.GroupBox__.Controls.Add(Me.RIngTimeH)
        Me.GroupBox__.Location = New System.Drawing.Point(33, 183)
        Me.GroupBox__.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox__.Name = "GroupBox__"
        Me.GroupBox__.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox__.Size = New System.Drawing.Size(480, 184)
        Me.GroupBox__.TabIndex = 25
        Me.GroupBox__.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(181, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "24HRS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(171, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 25)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "MINUTES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(27, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "HOURS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(137, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 45)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = ":"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RIngDayWeekday)
        Me.GroupBox1.Controls.Add(Me.RIngDayWeekend)
        Me.GroupBox1.Controls.Add(Me.RingDayAll)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.RingDaySa)
        Me.GroupBox1.Controls.Add(Me.RIngDayW)
        Me.GroupBox1.Controls.Add(Me.RIngDayF)
        Me.GroupBox1.Controls.Add(Me.RingDayTu)
        Me.GroupBox1.Controls.Add(Me.RingDaySu)
        Me.GroupBox1.Controls.Add(Me.RingDayTh)
        Me.GroupBox1.Controls.Add(Me.RingDayM)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 426)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(487, 322)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'RIngDayWeekday
        '
        Me.RIngDayWeekday.AutoSize = True
        Me.RIngDayWeekday.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIngDayWeekday.Location = New System.Drawing.Point(283, 258)
        Me.RIngDayWeekday.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RIngDayWeekday.Name = "RIngDayWeekday"
        Me.RIngDayWeekday.Size = New System.Drawing.Size(125, 32)
        Me.RIngDayWeekday.TabIndex = 36
        Me.RIngDayWeekday.TabStop = True
        Me.RIngDayWeekday.Text = "WEEKDAY"
        Me.RIngDayWeekday.UseVisualStyleBackColor = True
        '
        'RIngDayWeekend
        '
        Me.RIngDayWeekend.AutoSize = True
        Me.RIngDayWeekend.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIngDayWeekend.Location = New System.Drawing.Point(151, 258)
        Me.RIngDayWeekend.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RIngDayWeekend.Name = "RIngDayWeekend"
        Me.RIngDayWeekend.Size = New System.Drawing.Size(127, 32)
        Me.RIngDayWeekend.TabIndex = 35
        Me.RIngDayWeekend.TabStop = True
        Me.RIngDayWeekend.Text = "WEEKEND"
        Me.RIngDayWeekend.UseVisualStyleBackColor = True
        '
        'RingDayAll
        '
        Me.RingDayAll.AutoSize = True
        Me.RingDayAll.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RingDayAll.Location = New System.Drawing.Point(29, 258)
        Me.RingDayAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RingDayAll.Name = "RingDayAll"
        Me.RingDayAll.Size = New System.Drawing.Size(110, 32)
        Me.RingDayAll.TabIndex = 34
        Me.RingDayAll.TabStop = True
        Me.RingDayAll.Text = "ALL DAY"
        Me.RingDayAll.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(23, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 25)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "SHORTCUTS"
        '
        'RingDaySa
        '
        Me.RingDaySa.AutoSize = True
        Me.RingDaySa.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RingDaySa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RingDaySa.Location = New System.Drawing.Point(324, 70)
        Me.RingDaySa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RingDaySa.Name = "RingDaySa"
        Me.RingDaySa.Size = New System.Drawing.Size(135, 35)
        Me.RingDaySa.TabIndex = 32
        Me.RingDaySa.Text = "Saturday"
        Me.RingDaySa.UseVisualStyleBackColor = True
        '
        'RIngDayW
        '
        Me.RIngDayW.AutoSize = True
        Me.RIngDayW.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIngDayW.Location = New System.Drawing.Point(33, 156)
        Me.RIngDayW.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RIngDayW.Name = "RIngDayW"
        Me.RIngDayW.Size = New System.Drawing.Size(162, 35)
        Me.RIngDayW.TabIndex = 31
        Me.RIngDayW.Text = "Wednesday"
        Me.RIngDayW.UseVisualStyleBackColor = True
        '
        'RIngDayF
        '
        Me.RIngDayF.AutoSize = True
        Me.RIngDayF.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RIngDayF.Location = New System.Drawing.Point(183, 111)
        Me.RIngDayF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RIngDayF.Name = "RIngDayF"
        Me.RIngDayF.Size = New System.Drawing.Size(106, 35)
        Me.RIngDayF.TabIndex = 30
        Me.RIngDayF.Text = "Friday"
        Me.RIngDayF.UseVisualStyleBackColor = True
        '
        'RingDayTu
        '
        Me.RingDayTu.AutoSize = True
        Me.RingDayTu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RingDayTu.Location = New System.Drawing.Point(36, 111)
        Me.RingDayTu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RingDayTu.Name = "RingDayTu"
        Me.RingDayTu.Size = New System.Drawing.Size(125, 35)
        Me.RingDayTu.TabIndex = 29
        Me.RingDayTu.Text = "Tuesday"
        Me.RingDayTu.UseVisualStyleBackColor = True
        '
        'RingDaySu
        '
        Me.RingDaySu.AutoSize = True
        Me.RingDaySu.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RingDaySu.ForeColor = System.Drawing.Color.Maroon
        Me.RingDaySu.Location = New System.Drawing.Point(324, 111)
        Me.RingDaySu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RingDaySu.Name = "RingDaySu"
        Me.RingDaySu.Size = New System.Drawing.Size(119, 35)
        Me.RingDaySu.TabIndex = 28
        Me.RingDaySu.Text = "Sunday"
        Me.RingDaySu.UseVisualStyleBackColor = True
        '
        'RingDayTh
        '
        Me.RingDayTh.AutoSize = True
        Me.RingDayTh.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RingDayTh.Location = New System.Drawing.Point(183, 70)
        Me.RingDayTh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RingDayTh.Name = "RingDayTh"
        Me.RingDayTh.Size = New System.Drawing.Size(138, 35)
        Me.RingDayTh.TabIndex = 27
        Me.RingDayTh.Text = "Thursday"
        Me.RingDayTh.UseVisualStyleBackColor = True
        '
        'RingDayM
        '
        Me.RingDayM.AutoSize = True
        Me.RingDayM.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RingDayM.Location = New System.Drawing.Point(36, 70)
        Me.RingDayM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RingDayM.Name = "RingDayM"
        Me.RingDayM.Size = New System.Drawing.Size(128, 35)
        Me.RingDayM.TabIndex = 26
        Me.RingDayM.Text = "Monday"
        Me.RingDayM.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(24, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 25)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "ALARM RING DAYS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(29, 384)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(188, 25)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "RING DAY SETTINGS"
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.Color.Black
        Me.Line2.Location = New System.Drawing.Point(213, 394)
        Me.Line2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(286, 3)
        Me.Line2.TabIndex = 20
        '
        'Line3
        '
        Me.Line3.BackColor = System.Drawing.Color.Black
        Me.Line3.Location = New System.Drawing.Point(209, 789)
        Me.Line3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(286, 3)
        Me.Line3.TabIndex = 32
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.ScheduleName)
        Me.GroupBox2.Controls.Add(Me.ScheduleTImeM)
        Me.GroupBox2.Controls.Add(Me.ScheduleTimeH)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 820)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(491, 447)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(20, 390)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(213, 23)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "AFTER THE ALARM TIME."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(24, 249)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(178, 23)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "SCHEDULE TIME IS - "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(167, 354)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 25)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "MINUTES"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(24, 170)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(407, 46)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "ex) Alarm rings at 6am, and schedule time is 7am" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " then the term will be 1 hour."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(23, 354)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 25)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "HOURS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(24, 134)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(459, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "TERM BETWEEN ALARM TIME AND SCHEDULE TIME"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(133, 296)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 45)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = ":"
        '
        'ScheduleName
        '
        Me.ScheduleName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleName.Location = New System.Drawing.Point(29, 69)
        Me.ScheduleName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduleName.Name = "ScheduleName"
        Me.ScheduleName.Size = New System.Drawing.Size(413, 33)
        Me.ScheduleName.TabIndex = 26
        '
        'ScheduleTImeM
        '
        Me.ScheduleTImeM.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleTImeM.Location = New System.Drawing.Point(169, 288)
        Me.ScheduleTImeM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduleTImeM.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.ScheduleTImeM.Name = "ScheduleTImeM"
        Me.ScheduleTImeM.Size = New System.Drawing.Size(100, 58)
        Me.ScheduleTImeM.TabIndex = 30
        '
        'ScheduleTimeH
        '
        Me.ScheduleTimeH.Font = New System.Drawing.Font("Consolas", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScheduleTimeH.Location = New System.Drawing.Point(24, 288)
        Me.ScheduleTimeH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScheduleTimeH.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.ScheduleTimeH.Name = "ScheduleTimeH"
        Me.ScheduleTimeH.Size = New System.Drawing.Size(100, 58)
        Me.ScheduleTimeH.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(24, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 25)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "SCHEDULE NAME"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 778)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(192, 25)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "SCHEDULE SETTINGS"
        '
        'Line5
        '
        Me.Line5.BackColor = System.Drawing.Color.Black
        Me.Line5.Location = New System.Drawing.Point(206, 1300)
        Me.Line5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Line5.Name = "Line5"
        Me.Line5.Size = New System.Drawing.Size(286, 3)
        Me.Line5.TabIndex = 34
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(21, 1290)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(195, 25)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "RINGTONE SETTINGS"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(209, 1359)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(176, 23)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "WORK IN PROGRESS"
        '
        'AlarmSettingPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Line5)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Line3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Line2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox__)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AlarmSettingPanel"
        Me.Size = New System.Drawing.Size(525, 1372)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AlarmMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIngTimeH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIngTImeM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox__.ResumeLayout(False)
        Me.GroupBox__.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ScheduleTImeM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ScheduleTimeH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents AlarmMenuBtn As PictureBox
    Friend WithEvents AlarmCaption As Label
    Friend WithEvents AlarmName As Label
    Friend WithEvents Line4 As Line
    Friend WithEvents Label1 As Label
    Friend WithEvents Line1 As Line
    Friend WithEvents RIngTimeH As NumericUpDown
    Friend WithEvents RIngTImeM As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox__ As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RingDaySa As CheckBox
    Friend WithEvents RIngDayW As CheckBox
    Friend WithEvents RIngDayF As CheckBox
    Friend WithEvents RingDayTu As CheckBox
    Friend WithEvents RingDaySu As CheckBox
    Friend WithEvents RingDayTh As CheckBox
    Friend WithEvents RingDayM As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Line2 As Line
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Line3 As Line
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents ScheduleName As TextBox
    Friend WithEvents ScheduleTImeM As NumericUpDown
    Friend WithEvents ScheduleTimeH As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Line5 As Line
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents RIngDayWeekday As RadioButton
    Friend WithEvents RIngDayWeekend As RadioButton
    Friend WithEvents RingDayAll As RadioButton
End Class
