Public Class AlarmPanel

    Public alarm_ As Alarm_

    Public Sub ReloadUIwithAlarmInfo()

        If alarm_.AlarmRingTime(0) > 12 Then
            AlarmTime.Text = alarm_.AlarmRingTime(0) - 12
        Else
            AlarmTime.Text = alarm_.AlarmRingTime(0)
        End If

        AlarmTime.Text += ":" + alarm_.AlarmRingTime(1).ToString

        If alarm_.AlarmRingTime(0) > 12 Then
            AlarmTime.Text += " PM"
        Else
            AlarmTime.Text += " AM"
        End If

        AlarmName.Text = alarm_.AlarmName
        AppointName.Text = alarm_.ScheduleName

        AlarmCaption.Text = alarm_.AlarmCaption + vbCrLf
        For Each i As String In alarm_.AlarmRingDay
            AlarmCaption.Text += i.ToUpper + " "
        Next


    End Sub

End Class
