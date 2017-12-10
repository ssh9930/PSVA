Public Class Setting

    Private Sub Setting_Load() Handles MyBase.Load
        ' Alarm.Show()
        'designer load
        Dim a As Alarm_ = Alarm_.SettingToAlarm("C:\Users\ssh9930\Desktop\alarminfo")(0)
        AlarmPanel1.alarm_ = a
        a.StartAlarm()

    End Sub

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' AlarmPanel1.alarm_ = New Alarm_("test alarm", "caption", New Date(2017, 11, 14, 0, 17, 0), "0123", "0321", New Date())
        AlarmPanel1.ReloadUIwithAlarmInfo()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
