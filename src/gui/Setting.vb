Public Class SettingWnd

    Private WithEvents alarm_list_listener As New AlarmListEventListener
    Private alarmpanel_list_int As Integer = 0
    Private alarmpanel_list As AlarmPanel()

    Private firstload As Boolean = True

    Private Sub Load_() Handles Me.Load

        'adding listener to the official list.
        AddAlarmListListener(alarm_list_listener)

        ' AddHandler Me.Closed, Sub() End
        AddHandler alarm_list_listener.AlarmListChanged, Sub()
                                                             ' MsgBox(&HFFFFFFF)
                                                             DbgLog("Calling ReloadAlarmUI() since alarmlistchange raised.")
                                                             ReloadAlarmUI()

                                                         End Sub

        AddHandler Me.AlarmMenuBtn.Click, Sub(sender As Object, e As MouseEventArgs)

                                              AlarmMenu.Show(New Point(Me.Location.X + AlarmMenuBtn.Location.X + AlarmMenuBtn.Width,
                                                                       Me.Location.Y + AlarmMenuBtn.Location.Y + AlarmMenuBtn.Height))
                                          End Sub

        AddHandler Me.ReloadBtn.Click, Sub()
                                           Startup.ReloadAlarmList()
                                           ReloadAlarmUI()
                                       End Sub

        AddHandler Me.AddBtn.Click, Sub() AlarmCreateWnd.ShowDialog()

        ' disable vertical scrolling

    End Sub

    Public Sub ReloadAlarmUI() Handles Me.Load

        DbgLog("ReloadAlarmUI(), called.")

        If Not firstload Then 'probably, i am called by alarmlisteventlistener, so reseting window.
            If Not alarmpanel_list_int = 0 Then '새로 추가해야 함.
                For Each i In alarmpanel_list
                    i.Visible = False
                    i.Dispose()
                Next
            End If
        End If

        If AlarmList Is Nothing Then '예외발생 방지 구문
            DbgLog("ReloadAlarmUI(), AlarmList=Nothing!")
            NoAlarmLabel.Visible = True
            NoAlarmPic.Visible = True
            Exit Sub
        End If

        If AlarmList.Length = 0 Then
            NoAlarmLabel.Visible = True
            NoAlarmPic.Visible = True
        Else
            NoAlarmLabel.Visible = False
            NoAlarmPic.Visible = False
        End If

        Dim cnt As Integer = 1

        For Each i In AlarmList

            Dim panel_ As New AlarmPanel

            Me.Controls.Add(panel_)
            panel_.alarm_ = i
            panel_.ReloadUIwithAlarmInfo()
            panel_.Location = New Point(0, 80 + (cnt - 1) * 79)
            cnt += 1

            ReDim Preserve alarmpanel_list(alarmpanel_list_int)
            alarmpanel_list(alarmpanel_list_int) = panel_
            alarmpanel_list_int += 1

        Next

        firstload = False
    End Sub
End Class
