Public Class AlarmSettingShellForm
    Public WithEvents alarmpanel As New AlarmSettingPanel
    Private alarm__ As Alarm_

    Sub New(alarm_ As Alarm_, Optional new_one As Boolean = False) 'new one은 새 알람 추가 옵션.

        InitializeComponent()
        alarm__ = alarm_

        Me.Text = alarm__.AlarmName

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

        'basic settings
        alarmpanel.RingDayM.Checked = True

        'handler setting
        AddHandler alarmpanel.RingDayM.CheckedChanged, Sub() ChkBtnEvent()
        AddHandler alarmpanel.RingDayTu.CheckedChanged, Sub() ChkBtnEvent()
        AddHandler alarmpanel.RIngDayW.CheckedChanged, Sub() ChkBtnEvent()
        AddHandler alarmpanel.RingDayTh.CheckedChanged, Sub() ChkBtnEvent()
        AddHandler alarmpanel.RIngDayF.CheckedChanged, Sub() ChkBtnEvent()
        AddHandler alarmpanel.RingDaySa.CheckedChanged, Sub() ChkBtnEvent()
        AddHandler alarmpanel.RingDaySu.CheckedChanged, Sub() ChkBtnEvent()

        AddHandler alarmpanel.RIngDayWeekend.CheckedChanged, Sub() RadioBtnEvent()
        AddHandler alarmpanel.RIngDayWeekday.CheckedChanged, Sub() RadioBtnEvent()
        AddHandler alarmpanel.RingDayAll.CheckedChanged, Sub() RadioBtnEvent()


    End Sub

    Private RingdayCnt As Integer = 0
    Private ReactAtCheckedCHange As Boolean = True

    Private Sub ChkBtnEvent()

        If ReactAtCheckedCHange Then
            ReactAtCheckedCHange = False
            With alarmpanel
                If .RingDayM.Checked And .RingDayTu.Checked And .RIngDayW.Checked And .RingDayTh.Checked And .RIngDayF.Checked And
                    Not .RingDaySa.Checked And Not .RingDaySu.Checked Then

                    .RIngDayWeekday.Checked = True

                ElseIf Not .RingDayM.Checked And Not .RingDayTu.Checked And Not .RIngDayW.Checked And Not .RingDayTh.Checked And Not .RIngDayF.Checked And
                     .RingDaySa.Checked And .RingDaySu.Checked Then

                    .RIngDayWeekend.Checked = True

                ElseIf .RingDayM.Checked And .RingDayTu.Checked And .RIngDayW.Checked And .RingDayTh.Checked And .RIngDayF.Checked And
                        .RingDaySa.Checked And .RingDaySu.Checked Then

                    .RingDayAll.Checked = True

                Else
                    .RIngDayWeekday.Checked = False
                    .RIngDayWeekend.Checked = False
                    .RingDayAll.Checked = False
                End If
            End With
            ReactAtCheckedCHange = True
        End If
    End Sub

    Private Sub RadioBtnEvent()
        '  If ReactAtCheckedCHange Then
        '  ReactAtCheckedCHange = False
        With alarmpanel
                Select Case True
                    Case .RIngDayWeekday.Checked

                        .RingDayM.Checked = True
                        .RingDayTu.Checked = True
                        .RIngDayW.Checked = True
                        .RingDayTh.Checked = True
                        .RIngDayF.Checked = True
                        .RingDaySa.Checked = False
                        .RingDaySu.Checked = False

                    Case .RIngDayWeekend.Checked

                        .RingDayM.Checked = False
                        .RingDayTu.Checked = False
                        .RIngDayW.Checked = False
                        .RingDayTh.Checked = False
                        .RIngDayF.Checked = False
                        .RingDaySa.Checked = True
                        .RingDaySu.Checked = True

                    Case .RingDayAll.Checked

                        .RingDayM.Checked = True
                        .RingDayTu.Checked = True
                        .RIngDayW.Checked = True
                        .RingDayTh.Checked = True
                        .RIngDayF.Checked = True
                        .RingDaySa.Checked = True
                        .RingDaySu.Checked = True
                End Select
            End With
        '  ReactAtCheckedCHange = True
        '  End If
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


        AddHandler SaveBtn.Click, Sub() 'SAVE/CREATE ALARM
                                      Dim CreateMode As Boolean = SaveBtn.Text = "CREATE"

                                      If CreateMode Then
                                          DbgLog("SaveBtn.Click : creating alarm '" + alarm__.AlarmName + "', alarmlist-int=" + AlarmList.Length.ToString)
                                      Else
                                          DbgLog("SaveBtn.Click : saving alarm '" + alarm__.AlarmName + "', alarmlist-int=" + AlarmList.Length.ToString)
                                      End If

                                      With alarmpanel
                                          If .RingDayM.Checked = False And .RingDayTu.Checked = False And .RIngDayW.Checked = False _
                                              And .RingDayTh.Checked = False And .RIngDayF.Checked = False And .RingDaySa.Checked = False _
                                              And .RingDaySu.Checked = False Then

                                              MessageBox.Show("You have to check at least on day." _
                                                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                              Exit Sub

                                          End If
                                      End With


                                      alarm__.AlarmName = alarmpanel.AlarmName.Text
                                      alarm__.AlarmCaption = alarmpanel.AlarmCaption.Text
                                      alarm__.AlarmRingTime = {alarmpanel.RIngTimeH.Value, alarmpanel.RIngTImeM.Value}

                                      ''ringday
                                      Dim ringday_ As String() = {}
                                      Dim ringdayint_ As Integer = 0
                                      Dim loopint As Integer = 0

                                      If alarmpanel.RingDayM.Checked Then
                                          ReDim Preserve ringday_(ringdayint_)
                                          ringday_(ringdayint_) = "MON"
                                          ringdayint_ += 1
                                      End If
                                      If alarmpanel.RingDayTu.Checked Then
                                          ReDim Preserve ringday_(ringdayint_)
                                          ringday_(ringdayint_) = "TUE"
                                          ringdayint_ += 1
                                      End If
                                      If alarmpanel.RIngDayW.Checked Then
                                          ReDim Preserve ringday_(ringdayint_)
                                          ringday_(ringdayint_) = "WED"
                                          ringdayint_ += 1
                                      End If
                                      If alarmpanel.RingDayTh.Checked Then
                                          ReDim Preserve ringday_(ringdayint_)
                                          ringday_(ringdayint_) = "THUR"
                                          ringdayint_ += 1
                                      End If
                                      If alarmpanel.RIngDayF.Checked Then
                                          ReDim Preserve ringday_(ringdayint_)
                                          ringday_(ringdayint_) = "FRI"
                                          ringdayint_ += 1
                                      End If
                                      If alarmpanel.RingDaySa.Checked Then
                                          ReDim Preserve ringday_(ringdayint_)
                                          ringday_(ringdayint_) = "SAT"
                                          ringdayint_ += 1
                                      End If
                                      If alarmpanel.RingDaySu.Checked Then
                                          ReDim Preserve ringday_(ringdayint_)
                                          ringday_(ringdayint_) = "SUN"
                                          ringdayint_ += 1

                                      End If
                                      loopint += 1

                                      alarm__.AlarmRingDay = ringday_

                                      alarm__.ScheduleName = alarmpanel.ScheduleName.Text
                                      alarm__.ScheduleRingTimeAfter = {alarmpanel.ScheduleTimeH.Value, alarmpanel.ScheduleTImeM.Value}


                                      If CreateMode Then
                                          ''여기서 알람
                                          DoUpdateAlarmList = False '이거 안하면 아래꺼때문에 망함.
                                          ReDim Preserve AlarmList(AlarmList.Length) '<-- 여기서부터 알람리스트 변경됨!!
                                          DoUpdateAlarmList = True
                                          AlarmList(AlarmList.Length - 1) = alarm__ '이걸 알람리스트 프로퍼티에서 감지를 못함. 따로 해줘야됨.
                                          UpdateAlarmList(AlarmList)

                                          DbgLog("[CREATE] SaveBtn.Click : removing alarmringlock")
                                          AlarmList(AlarmList.Length - 1).AlarmRingLock = False

                                          DbgLog("[CREATE] SaveBtn.Click : alarmlist-int=" + AlarmList.Length.ToString)
                                      Else
                                          DbgLog("[SAVE] SaveBtn.Click : saving")

                                          Dim alllistinteger As Integer = 0
                                          Dim allist As Alarm_() = {}
                                          Dim foundblist As Boolean = False
                                          Dim firstloop As Boolean = True

                                          For i As Integer = 0 To AlarmList.Length - 1
                                              Dim blacklist As Alarm_ = alarm__

                                              If Not AlarmList(i) Is blacklist Then
                                                  ReDim Preserve allist(alllistinteger)
                                                  allist(alllistinteger) = AlarmList(i)
                                                  alllistinteger += 1
                                              Else
                                                  foundblist = True

                                                  ReDim Preserve allist(alllistinteger)
                                                  allist(alllistinteger) = alarm__
                                                  alllistinteger += 1
                                              End If

                                              If foundblist And i = AlarmList.Length - 1 Then
                                                  Exit For
                                              End If

                                          Next

                                          AlarmList = allist

                                      End If

                                      DbgLog("SaveBtn.Click : all done, closing.")
                                      Startup.ReloadAlarmList() '알람리스트 리셋
                                      Me.Close() '닫아보리기.
                                  End Sub

        AddHandler DeleteBtn.Click, Sub() 'ALARM DELETE
                                        DbgLog("DeleteBtn.Click : deleting alarm '" + alarm__.AlarmName + "'")

                                        alarm__.KillAlarm() '알람 종료.

                                            Dim alllistinteger As Integer = 0
                                            Dim allist As Alarm_() = {}
                                            Dim foundblist As Boolean = False
                                            Dim firstloop As Boolean = True

                                            For i As Integer = 0 To AlarmList.Length - 1
                                                Dim blacklist As Alarm_ = alarm__

                                                If Not AlarmList(i) Is blacklist Then
                                                    ReDim Preserve allist(alllistinteger)
                                                    allist(alllistinteger) = AlarmList(i)
                                                    alllistinteger += 1
                                                Else
                                                    foundblist = True
                                                End If

                                                If foundblist And i = AlarmList.Length - 1 Then
                                                    Exit For
                                                End If

                                            Next

                                        AlarmList = allist

                                        MsgBox("Alarm '" + alarm__.AlarmName + "' successfuly deleted.", MsgBoxStyle.Information, "Success")
                                        Me.Close()
                                    End Sub

        AddHandler ReloadBtn.Click, Sub()

                                        Dim me_ As New AlarmSettingShellForm(alarm__)
                                        me_.Show()
                                        Me.Close()

                                    End Sub

    End Sub

End Class