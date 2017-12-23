<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AlarmMenuBtn = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NoAlarmLabel = New System.Windows.Forms.Label()
        Me.NoAlarmPic = New System.Windows.Forms.PictureBox()
        Me.AlarmMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewAlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Line4 = New PSVA.Line()
        Me.Panel3.SuspendLayout()
        CType(Me.AlarmMenuBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoAlarmPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlarmMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel3.Controls.Add(Me.AlarmMenuBtn)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Line4)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(586, 117)
        Me.Panel3.TabIndex = 16
        '
        'AlarmMenuBtn
        '
        Me.AlarmMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AlarmMenuBtn.Image = Global.PSVA.My.Resources.Resources.ic_menu_black_24dp
        Me.AlarmMenuBtn.Location = New System.Drawing.Point(17, 26)
        Me.AlarmMenuBtn.Name = "AlarmMenuBtn"
        Me.AlarmMenuBtn.Size = New System.Drawing.Size(36, 38)
        Me.AlarmMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AlarmMenuBtn.TabIndex = 21
        Me.AlarmMenuBtn.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(64, 69)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(263, 23)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "FIRST RELEASE @ PROTOTYPE 1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 26)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(449, 31)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "PERSONAL SCHEDULE VOICE ASSISTANT"
        '
        'NoAlarmLabel
        '
        Me.NoAlarmLabel.AutoSize = True
        Me.NoAlarmLabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoAlarmLabel.Location = New System.Drawing.Point(96, 464)
        Me.NoAlarmLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NoAlarmLabel.Name = "NoAlarmLabel"
        Me.NoAlarmLabel.Size = New System.Drawing.Size(384, 31)
        Me.NoAlarmLabel.TabIndex = 20
        Me.NoAlarmLabel.Text = "No alarm here. You can create one."
        Me.NoAlarmLabel.Visible = False
        '
        'NoAlarmPic
        '
        Me.NoAlarmPic.Image = Global.PSVA.My.Resources.Resources.ic_warning_black_24dp
        Me.NoAlarmPic.Location = New System.Drawing.Point(233, 338)
        Me.NoAlarmPic.Name = "NoAlarmPic"
        Me.NoAlarmPic.Size = New System.Drawing.Size(100, 100)
        Me.NoAlarmPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NoAlarmPic.TabIndex = 17
        Me.NoAlarmPic.TabStop = False
        Me.NoAlarmPic.Visible = False
        '
        'AlarmMenu
        '
        Me.AlarmMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.AlarmMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewAlarmToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.AlarmMenu.Name = "AlarmMenu"
        Me.AlarmMenu.Size = New System.Drawing.Size(183, 94)
        '
        'NewAlarmToolStripMenuItem
        '
        Me.NewAlarmToolStripMenuItem.Image = Global.PSVA.My.Resources.Resources.ic_alarm_add_black_24dp
        Me.NewAlarmToolStripMenuItem.Name = "NewAlarmToolStripMenuItem"
        Me.NewAlarmToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.NewAlarmToolStripMenuItem.Text = "New Alarm"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = Global.PSVA.My.Resources.Resources.ic_settings_black_24dp
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.PSVA.My.Resources.Resources.ic_info_black_24dp
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Line4
        '
        Me.Line4.BackColor = System.Drawing.Color.Black
        Me.Line4.Location = New System.Drawing.Point(69, 62)
        Me.Line4.Margin = New System.Windows.Forms.Padding(4)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(410, 3)
        Me.Line4.TabIndex = 18
        '
        'Setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(587, 804)
        Me.Controls.Add(Me.NoAlarmLabel)
        Me.Controls.Add(Me.NoAlarmPic)
        Me.Controls.Add(Me.Panel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Setting"
        Me.Text = "PSVA Prototype 1"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AlarmMenuBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoAlarmPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlarmMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Line4 As Line
    Friend WithEvents NoAlarmPic As PictureBox
    Friend WithEvents NoAlarmLabel As Label
    Friend WithEvents AlarmMenuBtn As PictureBox
    Friend WithEvents AlarmMenu As ContextMenuStrip
    Friend WithEvents NewAlarmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
