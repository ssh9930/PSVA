Module base

    Public ReadOnly SettingPath As String = Environ("appdata") + "\PSVA\"
    Public ReadOnly EnableLogging As Boolean = False 'todo : work on this
    Public ReadOnly LogPath As String = "C:\Users\ssh9930\Desktop\psva.log"

    Public ReadOnly AlarmInfoFileName As String = ".alarminfo" 'create this file if it isnt exist

    Public AlarmList As Alarm_() = {}

    Public Sub DbgLog(text As String)
        Debug.WriteLine(text)

        If EnableLogging Then
            FileIO.FileSystem.WriteAllText(LogPath, "[PSVA]" + text + vbCrLf, 1)
        End If
    End Sub

End Module
