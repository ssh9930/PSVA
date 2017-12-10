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
        Dim list As Alarm_() = Alarm_.SettingToAlarm(SettingPath + AlarmInfoFileName)
        AlarmList = list '리스트에 올려놓는다.

        DbgLog("Startup : starting each alarm.")
        For Each i In AlarmList
            i.StartAlarm()
        Next

        DbgLog("Startup : startup procedure completed!")
    End Sub

End Class
