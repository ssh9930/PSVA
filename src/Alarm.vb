Public Class Alarm_

    Public AlarmRingTime As Integer() = {0, 0} 'Like {10,54} 10:54
    Public AlarmRingDay As String() = {} 'Like {"mon","wed","sun"}
    Public AlarmRingLock_ As Boolean = False
    Public Property AlarmRingLock As Boolean
        Get
            Return AlarmRingLock_
        End Get
        Set(value As Boolean)
            AlarmRingLock_ = value

            If value Then
                KillAlarm()
            ElseIf alarmthread.ThreadState = Threading.ThreadState.Unstarted Then
                StartAlarm()
            End If

        End Set
    End Property

    ' Private AlarmSound //todo

    Public AlarmName As String
    Public AlarmCaption As String
    Public ScheduleName As String
    Public ScheduleRingTimeAfter As Integer() = {0, 0} 'only time

    Private ReadOnly Property nmin As Integer
        Get
            Return Now.Hour * 60 + Now.Minute
        End Get
    End Property

    Private ReadOnly Property dmin As Integer
        Get
            Return AlarmRingTime(0) * 60 + AlarmRingTime(1)
        End Get
    End Property

    Public Event AlarmRingEvent(caption As String)

    Public alarmthread As New Threading.Thread(Sub()
                                                   DbgLog("[alarmthread] alarmthread started. the thread DOES NOT gets terminated itself.")
                                                   'TODO: 함수에서 빠지지 말고 다음알람 기다리기

                                                   Do
                                                       For i As Integer = 0 To AlarmRingDay.Length - 1
                                                           DbgLog("[alarmthread] alarmringday=" + AlarmRingDay(i).ToUpper + ", now=" + Now.DayOfWeek.ToString.ToUpper _
                                                          + ", contains=" + Now.DayOfWeek.ToString.ToUpper.Contains(AlarmRingDay(i).ToUpper).ToString)

                                                           If Now.DayOfWeek.ToString.ToUpper.Contains(AlarmRingDay(i).ToUpper) Then 'alarm day

                                                               If nmin >= dmin Then '알람이 울린걸로 간주..
                                                                   DbgLog("[alarmthread] alarmringtime already passed, terminating thread.")
                                                                   Exit Sub
                                                               End If

                                                               While Not dmin <= nmin + 60
                                                                   DbgLog("[alarmthread] 1Hterm/1Hloop, dmin=" + dmin.ToString + ", nmin=" + nmin.ToString)
                                                                   Threading.Thread.Sleep(1000 * 60 * 60) '1h
                                                               End While

                                                               While Not dmin <= nmin + 3
                                                                   DbgLog("[alarmthread] 3Mterm/2Mloop, dmin=" + dmin.ToString + ", nmin=" + nmin.ToString)
                                                                   Threading.Thread.Sleep(1000 * 60 * 2) '2m
                                                               End While

                                                               While nmin < dmin
                                                                   DbgLog("[alarmthread] 1Sterm/1Sloop, dmin=" + dmin.ToString + ", nmin=" + nmin.ToString)
                                                                   Threading.Thread.Sleep(1000) '1sec
                                                               End While

                                                               If Not AlarmRingLock Then
                                                                   DbgLog("[alarmthread] Bingo, raising event and waiting for another change") 'TODO: 함수에서 빠지지 말고 다음알람 기다리기
                                                                   RaiseEvent AlarmRingEvent(AlarmCaption) '조금 지나도 안쓰이면 이벤트 삭제할꺼임.
                                                                   AlarmRingManager.StartAlarmRingProcedure(Me)
                                                                   Exit Sub
                                                               End If
                                                           End If
                                                       Next

                                                       '다음 날이 오기를 기다림.
                                                       Dim dmin_ As Integer = (23 * 60) + 58 '23:58.

                                                       While Not dmin_ <= nmin + 60
                                                           DbgLog("[alarmthread] Waiting for another day, 1Hterm/1Hloop, dmin_ (23:58)=" + dmin_.ToString + ", nmin=" + nmin.ToString)
                                                           Threading.Thread.Sleep(1000 * 60 * 60) '1h
                                                       End While

                                                       While Not dmin_ <= nmin + 3
                                                           DbgLog("[alarmthread] Waiting for another day, 3Mterm/2Mloop, dmin_ (23:58)=" + dmin_.ToString + ", nmin=" + nmin.ToString)
                                                           Threading.Thread.Sleep(1000 * 60 * 2) '2m
                                                       End While

                                                       While nmin < dmin_
                                                           DbgLog("[alarmthread] Waiting for another day, 1Sterm/1Sloop, dmin_ (23:58)=" + dmin_.ToString + ", nmin=" + nmin.ToString)
                                                           Threading.Thread.Sleep(1000) '1sec

                                                       End While
                                                   Loop

                                               End Sub)

    Sub New(Name As String, Cap As String, RingDay As String(), RingTime As Integer(), SchName As String, SchRingTime As Integer())
        Try
            DbgLog("[alarm] Alarm instance created, ringing at " + RingTime(0).ToString + ":" + RingTime(1).ToString)
        Catch ex As Exception
            DbgLog("[alarm] Alarm instance created, but failed to get info!! guessing it is an empty instance...")
        End Try


        AlarmName = Name
        AlarmCaption = Cap
        AlarmRingDay = RingDay
        AlarmRingTime = RingTime
        ScheduleName = SchName
        ScheduleRingTimeAfter = SchRingTime

    End Sub

    Public Sub StartAlarm()
        DbgLog("[alarm] StartAlarm(), starting alarmthread")
        alarmthread.Start()
    End Sub

    Public Sub KillAlarm()
        DbgLog("[alarm] KillAlarm(), killing alarmthread")
        alarmthread.Abort()
    End Sub

    ''''''''''''''''''''''''''''''''''''''''

    Shared Function SettingToAlarm(text As String) As Alarm_() '만약에 알람 시간보다 현재 시간이 앞서다면 쓰레드 시작과 동시에 바로 이벤트 나감.

        DbgLog("[s2a] executed, text=" + text)

        Dim reader As New IO.StringReader(FileIO.FileSystem.ReadAllText(text)) 'peek < 0 then exit, sstring으로 보안.
        Dim ThisLine As String = ""
        Dim alarmsint As Integer = 0
        Dim alarms As Alarm_() = {}

        While Not reader.Peek < 0 'MAIN LOOP (actually, it doesnt have to be an 'loop'.)
            Try

                DbgLog("[s2a] loop #1, peek=" + reader.Peek.ToString + " ( < 0 )")
                ThisLine = reader.ReadLine()

                If Mid(ThisLine, 1, 2) = "@[" And Mid(ThisLine, ThisLine.Length - 1, 2) = "]@" Then
                    DbgLog("[s2a] First alarm set detected.")
                    Dim thisalarm As New Alarm_(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                    While Not reader.Peek < 0  '2ND LOOP, if stream ends or new set detected, loop will exit.
                        Try

                            DbgLog("[s2a] loop #2, peek=" + reader.Peek.ToString + " ( < 0 )")
                            ThisLine = reader.ReadLine()

                            If Mid(ThisLine, 1, 2) = "@[" And Mid(ThisLine, ThisLine.Length - 1, 2) = "]@" Then 'preparing to set next alarm

                                DbgLog("[s2a] New alarm set detected, preparing..")

                                'add thisalarm to alarms
                                ReDim Preserve alarms(alarmsint)
                                alarms(alarmsint) = thisalarm
                                alarmsint += 1

                                thisalarm = New Alarm_(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing) 'thisalarm reset

                                'next loop
                                Continue While

                            End If

                            If Mid(ThisLine, 1, 4) = "**^*" And ThisLine.Contains("=") Then

                                Select Case True
                                    Case Split(ThisLine, "=")(0).Replace("**^*", "") = "alarmname"
                                        DbgLog("[s2a] alarmname set!")
                                        thisalarm.AlarmName = Split(ThisLine, "=")(1)
                                    Case Split(ThisLine, "=")(0).Replace("**^*", "") = "alarmcaption"
                                        DbgLog("[s2a] alarmcaption set!")
                                        thisalarm.AlarmCaption = Split(ThisLine, "=")(1)
                                    Case Split(ThisLine, "=")(0).Replace("**^*", "") = "alarmringday" 'complex!
                                        DbgLog("[s2a] alarmringday set!")

                                        Dim raw As String = Split(ThisLine, "=")(1)
                                        Dim returndayint As Integer = 0
                                        Dim returnday As String() = {}
                                        Dim continue_ As Boolean = True

                                        While raw.Contains(",") = True Or continue_ = True
                                            continue_ = raw.Contains(",")
                                            ReDim Preserve returnday(returndayint)
                                            returnday(returndayint) = Split(raw, ",")(0)
                                            raw = raw.Replace(Split(raw, ",")(0) + ",", "")
                                            returndayint += 1
                                        End While
                                        thisalarm.AlarmRingDay = returnday

                                    Case Split(ThisLine, "=")(0).Replace("**^*", "") = "alarmringtime"
                                        DbgLog("[s2a] alarmringtime set!")
                                        thisalarm.AlarmRingTime = {CInt(Split(Split(ThisLine, "=")(1), ",")(0)), CInt(Split(Split(ThisLine, "=")(1), ",")(1))}
                                    Case Split(ThisLine, "=")(0).Replace("**^*", "") = "schedulename"
                                        DbgLog("[s2a] schedulename set!")
                                        thisalarm.ScheduleName = Split(ThisLine, "=")(1)
                                    Case Split(ThisLine, "=")(0).Replace("**^*", "") = "scheduleringtimeafter"
                                        DbgLog("[s2a] scheduleringtimeafter set!")
                                        thisalarm.ScheduleRingTimeAfter = {CInt(Split(Split(ThisLine, "=")(1), ",")(0)), CInt(Split(Split(ThisLine, "=")(1), ",")(1))}
                                End Select
                            End If



                        Catch ex As Exception
                            Continue While
                        End Try
                    End While

                    DbgLog("[s2a] escaping loop #2")

                    'add thisalarm to alarms
                    ReDim Preserve alarms(alarmsint)
                    alarms(alarmsint) = thisalarm
                    alarmsint += 1

                    DbgLog("[s2a] added last abandoned thisalarm to alarms.")

                End If

            Catch ex As Exception
                DbgLog("[s2a] loop #1 exception : " + ex.GetType.ToString + ", continue to next line..")
                Continue While
            End Try

        End While
        DbgLog("[s2a] escaping loop #1")
        DbgLog("[s2a] finished, returning value and exiting function.")
        Return alarms


    End Function


    Shared Sub AlarmsToSetting(list As Alarm_())
        DbgLog("[a2s] called.")

        Dim str As String = ""

        For Each i In list

            str += "@[" + i.AlarmName + "]@" + vbCrLf
            str += "**^*alarmname=" + i.AlarmName + vbCrLf
            str += "**^*alarmcaption=" + i.AlarmCaption + vbCrLf

            'complex
            str += "**^*alarmringday="
            For Each ii In i.AlarmRingDay
                str += ii + ","
            Next
            str = Mid(str, 1, str.Length - 1) '마지막에 붙은 쉼표 제거 작업.
            str += vbCrLf
            'complex

            str += "**^*alarmringtime=" + i.AlarmRingTime(0).ToString + "," + i.AlarmRingTime(1).ToString + vbCrLf
            str += "**^*schedulename=" + i.ScheduleName + vbCrLf
            str += "**^*scheduleringtimeafter=" + i.ScheduleRingTimeAfter(0).ToString + "," + i.ScheduleRingTimeAfter(1).ToString + vbCrLf

        Next

        If IO.File.Exists(SettingPath + AlarmInfoFileName) Then '파일 중복을 막음.
            DbgLog("[a2s] delteing alarminfofile.")
            IO.File.Delete(SettingPath + AlarmInfoFileName)
        End If

        DbgLog("[a2s] writting new alarminfofile.")
        IO.File.WriteAllText(SettingPath + AlarmInfoFileName, str) '파일을 씀.

        DbgLog("[a2s] done!")
        '끘!
    End Sub




End Class
