﻿Public Class Setting

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

        ' disable vertical scrolling

    End Sub

    Public Sub ReloadAlarmUI() Handles Me.Load
        DbgLog("ReloadAlarmUI(), alarmlist-int=" + AlarmList.Length.ToString)

        If Not firstload Then 'probably, i am called by alarmlisteventlistener, so reseting window.
            For Each i In alarmpanel_list
                i.Visible = False
                i.Dispose()
            Next
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

        If AlarmList.Length = 0 Then 'todo : make a whole management class about this.
            NoAlarmLabel.Visible = True
            NoAlarmPic.Visible = True
        End If

        firstload = False
    End Sub
End Class
