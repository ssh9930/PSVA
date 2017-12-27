Public Class AlarmPanel

    Public alarm_ As Alarm_

    Public Sub ReloadUIwithAlarmInfo()

        If alarm_.AlarmRingTime(0) > 12 Then
                AlarmTime.Text = alarm_.AlarmRingTime(0) - 12
            Else
                AlarmTime.Text = alarm_.AlarmRingTime(0)
            End If

        If alarm_.AlarmRingTime(1) > 10 Then
            AlarmTime.Text += ":" + alarm_.AlarmRingTime(1).ToString
        Else
            AlarmTime.Text += ":0" + alarm_.AlarmRingTime(1).ToString
        End If

        If alarm_.AlarmRingTime(1).ToString = 0 Then
                AlarmTime.Text += "0"
            End If

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

    Private Sub LoadHandler() Handles MyBase.Load

        AddHandler AlarmEditBtn.Click, Sub()

                                           Dim wnd As New AlarmSettingShellForm(alarm_)
                                           wnd.Show()

                                       End Sub

    End Sub
End Class
