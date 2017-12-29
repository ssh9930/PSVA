Public Class AlarmRingManager

    Shared Sub StartAlarmRingProcedure(al As Alarm_)

        Select Case True '################################################
            Case al.AlarmRingTime(0) < 12
                SAPI.Speak("좋은 아침입니다.")
            Case al.AlarmRingTime(0) < 19
                SAPI.Speak("좋은 점심입니다.")
            Case al.AlarmRingTime(0) < 25
                SAPI.Speak("좋은 저녁입니다.")
        End Select

        Dim h As String = Now.Hour.ToString '################################################

        If h > 12 Then
            h -= 12
        End If

        Select Case True
            Case h = "1"
                h = "한"
            Case h = "2"
                h = "두"
            Case h = "3"
                h = "세"
            Case h = "4"
                h = "네"
            Case h = "5"
                h = "다섯"
            Case h = "6"
                h = "여섯"
            Case h = "7"
                h = "일곱"
            Case h = "8"
                h = "여덟"
            Case h = "9"
                h = "아홉"
            Case h = "10"
                h = "열"
            Case h = "11"
                h = "열한"
            Case h = "12"
                h = "열두"
        End Select

        If Now.Minute = 0 Then
            SAPI.Speak("현재시각은   " + h + "   시   " + Now.Minute.ToString + "   정각 입니다.")
        Else
            SAPI.Speak("현재시각은   " + h + "   시   " + Now.Minute.ToString + "   분 입니다.")
        End If

        '################################################
        'todo : 이거 정확하게 고치기
        SAPI.Speak("알람이 울린 시각으로부터    " + ((Now.Hour * 60 + Now.Minute) - (al.AlarmRingTime(0) * 60 + al.AlarmRingTime(1))).ToString + "분 경과했습니다.")

    End Sub


End Class
