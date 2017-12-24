Public Class Startup

    Shared Sub StartUp()
        DbgLog("**** PSVA launch," + Now.ToString + " ****")

        DbgLog("Startup : alarminfofile exsistance=" + (FileIO.FileSystem.FileExists(SettingPath + AlarmInfoFileName)).ToString)
        If Not FileIO.FileSystem.FileExists(SettingPath + AlarmInfoFileName) Then
            If Not FileIO.FileSystem.DirectoryExists(SettingPath) Then
                IO.Directory.CreateDirectory(SettingPath)
            End If

            IO.File.Create(SettingPath + AlarmInfoFileName)
            DbgLog("Startup : created empty alarminfofile.")
        End If

        DbgLog("Startup : getting alarm list & setting to AlarmList..")
        ReloadAlarmList(True)

        DbgLog("Startup : startup procedure completed!")
    End Sub


    Shared Sub ReloadAlarmList(Optional IsThisStartupProcedure As Boolean = False) 'todo : 알람 리로드시 알람 리셋 후 다시시작하는거 작업하기!!
        DbgLog("ReloadAlarmList() : Reloading alarmlist and killing alarms in alarmlist.")

        '시작 전 알람 리스트에 있는 알람 모두 초기화.
        If Not IsThisStartupProcedure Then
            For Each i In AlarmList
                i.KillAlarm()
            Next
        End If

        Dim list As Alarm_() = Alarm_.SettingToAlarm(SettingPath + AlarmInfoFileName) '리스트 가져오기.
        AlarmListOnlyOnMemory = True '설정 안하면 중복 작업이 일어남.
        AlarmList = list '리스트에 올려놓는다.
        AlarmListOnlyOnMemory = False '다했으니까 해제

        For Each i In AlarmList '아까 알람 다 죽였으니까 다시 시작.
            i.StartAlarm()
        Next

    End Sub
End Class
