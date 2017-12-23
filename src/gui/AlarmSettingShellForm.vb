Public Class AlarmSettingShellForm

    Private alarmpanel As New AlarmSettingPanel
    Private alarm__ As Alarm_

    Sub New(alarm_ As Alarm_, Optional new_one As Boolean = False) 'new one은 새 알람 추가 옵션.

        InitializeComponent()
        alarm__ = alarm_

        If new_one Then
            DeleteBtn.Visible = False
            SaveBtn.Text = "Add"

            alarmpanel.AlarmName.Text = "ADD NEW ALARM"
            alarmpanel.AlarmCaption.Text = alarm_.AlarmCaption
        Else
            alarmpanel.AlarmName.Text = alarm_.AlarmName
            alarmpanel.AlarmCaption.Text = alarm_.AlarmCaption
        End If

        With alarmpanel

            ''ring time
            .RIngTimeH.Value = alarm_.AlarmRingTime(0)
            .RIngTImeM.Value = alarm_.AlarmRingTime(1)

            ''ring day
            For Each i In alarm_.AlarmRingDay
                Select Case True
                    Case i.ToUpper.Contains("MON")
                        .RingDayM.Checked = True
                    Case i.ToUpper.Contains("TUE")
                        .RingDayTu.Checked = True
                    Case i.ToUpper.Contains("WED")
                        .RIngDayW.Checked = True
                    Case i.ToUpper.Contains("THUR")
                        .RingDayTh.Checked = True
                    Case i.ToUpper.Contains("FRI")
                        .RIngDayF.Checked = True
                    Case i.ToUpper.Contains("SAT")
                        .RingDaySa.Checked = True
                    Case i.ToUpper.Contains("SUN")
                        .RingDaySu.Checked = True
                End Select
            Next

            If .RingDayM.Checked And .RingDayTu.Checked And .RIngDayW.Checked And .RingDayTh.Checked And .RIngDayF.Checked Then
                .RIngDayWeekday.Checked = True
            End If

            If .RingDaySa.Checked And .RingDaySu.Checked Then
                .RIngDayWeekend.Checked = True
            End If

            If .RingDayM.Checked And .RingDayTu.Checked And .RIngDayW.Checked And .RingDayTh.Checked And .RIngDayF.Checked And
                .RingDaySa.Checked And .RingDaySu.Checked Then

                .RingDayAll.Checked = True
            End If

            ''schedule setting
            .ScheduleName.Text = alarm_.ScheduleName
            .ScheduleTimeH.Value = alarm_.ScheduleRingTimeAfter(0)
            .ScheduleTImeM.Value = alarm_.ScheduleRingTimeAfter(1)

            ''ringtone setting
            ''WIP
        End With

        ''''  ADDING ALARMPANEL TO ALARMSETTINGSHELLFORM

        Me.Controls.Add(alarmpanel)
        alarmpanel.Location = New Point(0, 0)
        alarmpanel.Size = New Point(411, 500)


    End Sub

    Private Sub SetHandler() Handles Me.Load '핸들러 세팅

        '''''''''' 24:01 되는거 막음. 차라리 새 매서드를 만들어서 했으면 좋았을걸..
        AddHandler alarmpanel.RIngTimeH.ValueChanged, Sub()
                                                          If alarmpanel.RIngTimeH.Value = 24 And alarmpanel.RIngTImeM.Value <> 0 Then
                                                              alarmpanel.RIngTImeM.Value = 0
                                                          End If
                                                      End Sub
        AddHandler alarmpanel.RIngTImeM.ValueChanged, Sub()
                                                          If alarmpanel.RIngTimeH.Value = 24 And alarmpanel.RIngTImeM.Value <> 0 Then
                                                              alarmpanel.RIngTImeM.Value = 0
                                                          End If
                                                      End Sub
        AddHandler alarmpanel.ScheduleTimeH.ValueChanged, Sub()
                                                              If alarmpanel.ScheduleTimeH.Value = 24 And alarmpanel.ScheduleTImeM.Value <> 0 Then
                                                                  alarmpanel.ScheduleTImeM.Value = 0
                                                              End If
                                                          End Sub
        AddHandler alarmpanel.ScheduleTImeM.ValueChanged, Sub()
                                                              If alarmpanel.ScheduleTimeH.Value = 24 And alarmpanel.ScheduleTImeM.Value <> 0 Then
                                                                  alarmpanel.ScheduleTImeM.Value = 0
                                                              End If
                                                          End Sub
        ''''''''''


        AddHandler SaveBtn.Click, Sub()

                                      MsgBox("save")

                                  End Sub

        AddHandler DeleteBtn.Click, Sub()
                                        DbgLog("DeleteBtn.Click : deleting alarm '" + alarm__.AlarmName + "'")


                                        If MessageBox.Show("Are you sure want to delete alarm '" + alarm__.AlarmName + "' ?" _
                                                        , "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3) _
                                            = DialogResult.Yes Then


                                            Dim alllistinteger As Integer = 0
                                            Dim allist As Alarm_() = {}
                                            Dim foundblist As Boolean = False
                                            Dim firstloop As Boolean = True

                                            For i As Integer = 0 To AlarmList.Length - 1
                                                Dim blacklist As Alarm_ = alarm__

                                                If Not AlarmList(i).AlarmName Is blacklist.AlarmName Then
                                                    ReDim Preserve allist(alllistinteger)
                                                    allist(alllistinteger) = AlarmList(i)
                                                    alllistinteger += 1
                                                Else
                                                    MsgBox(5)
                                                    foundblist = True
                                                End If

                                                If foundblist And i = AlarmList.Length - 1 Then
                                                    Exit For
                                                End If

                                            Next

                                            AlarmList = allist

                                        End If

                                    End Sub

        AddHandler ReloadBtn.Click, Sub()

                                        Dim me_ As New AlarmSettingShellForm(alarm__)
                                        me_.Show()
                                        Me.Close()

                                    End Sub

    End Sub

End Class