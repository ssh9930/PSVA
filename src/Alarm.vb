﻿Public Class Alarm_

    Public AlarmRingTime As Integer() = {0, 0} 'Like {10,54} 10:54
    Public AlarmRingDay As String() = {} 'Like {"mon","wed","sun"}
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

    Dim alarmthread As New Threading.Thread(Sub()
                                                DbgLog("[alarmthread] alarmthread started.")


                                                For Each i As String In AlarmRingDay
                                                    DbgLog("[alarmthread] i=" + i.ToUpper + ", alarmringday=" + Now.DayOfWeek.ToString.ToUpper _
                                                          + ", contains=" + Now.DayOfWeek.ToString.ToUpper.Contains(i.ToUpper).ToString)

                                                    If Now.DayOfWeek.ToString.ToUpper.Contains(i.ToUpper) Then 'alarm day!

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

                                                        DbgLog("[alarmthread] Bingo, raising event and terminating current thread.")
                                                        RaiseEvent AlarmRingEvent(AlarmCaption)
                                                        Exit Sub

                                                    End If
                                                Next


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

        Dim reader As New IO.StringReader(FileIO.FileSystem.ReadAllText(text)) 'peek < 0 then exit
        Dim ThisLine As String = ""
        Dim alarmsint As Integer = 0
        Dim alarms As Alarm_() = {}

        While Not reader.Peek < 0 'MAIN LOOP (actually, it doesnt have to be an 'loop'.)
            DbgLog("[s2a] loop #1, peek=" + reader.Peek.ToString + " ( < 0 )")
            ThisLine = reader.ReadLine()

            If Mid(ThisLine, 1, 2) = "@[" And Mid(ThisLine, ThisLine.Length - 1, 2) = "]@" Then
                DbgLog("[s2a] First alarm set detected.")
                Dim thisalarm As New Alarm_(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

                While Not reader.Peek < 0  '2ND LOOP, if stream ends or new set detected, loop will exit.
                    DbgLog("[s2a] loop #2, setting zone.")
                    ThisLine = reader.ReadLine()

                    If Mid(ThisLine, 1, 2) = "@[" And Mid(ThisLine, ThisLine.Length - 1, 2) = "]@" Then 'preparing to set next alarm

                        DbgLog("[s2a] New alarm set detected, preparing..")

                        thisalarm = New Alarm_(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing) 'thisalarm reset

                        'add thisalarm to alarms
                        ReDim Preserve alarms(alarmsint)
                        alarms(alarmsint) = thisalarm
                        alarmsint += 1

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

                                While raw.Contains(",") Or continue_
                                    ReDim Preserve returnday(returndayint)
                                    returnday(returndayint) = Split(raw, ",")(0)
                                    raw = raw.Replace(Split(raw, ",")(0) + ",", "")
                                    returndayint += 1
                                    continue_ = raw.Contains(",") 'if raw.Contains(",") = false, it means that one item is left.
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

                    If reader.Peek < 1 Then 'if it its the last line, must add thisalarm to the alarms and then could exit.
                        DbgLog("[s2a] Last line. preparing to exit on next line..")

                        'add thisalarm to alarms
                        ReDim Preserve alarms(alarmsint)
                        alarms(alarmsint) = thisalarm
                        alarmsint += 1

                    End If

                End While
                DbgLog("[s2a] escaping loop #2")

            End If


        End While
        DbgLog("[s2a] escaping loop #1")
        Return alarms


    End Function



End Class