Module base

    Public ReadOnly SettingPath As String = Environ("appdata") + "\PSVA\"
    Public ReadOnly EnableLogging As Boolean = False 'todo : work on this
    Public ReadOnly LogPath As String = "C:\Users\ssh9930\Desktop\psva.log"

    Private __readonly_alarm_list__ As Alarm_()

    Public ReadOnly AlarmInfoFileName As String = ".alarminfo" 'create this file if it isnt exist

    ''''''''''''''''''''''''''''''''

    Public Property AlarmList As Alarm_()
        Get
            Return __readonly_alarm_list__
        End Get
        Set(value As Alarm_())

            __readonly_alarm_list__ = value

            For Each i In AlarmListEventListeners
                i.__base__activate()
            Next

        End Set


    End Property

    Private ALELint As Integer = 0
    Private AlarmListEventListeners As AlarmListEventListener() = {}

    Public Sub AddAlarmListListener(listener As AlarmListEventListener)

        ReDim Preserve AlarmListEventListeners(ALELint)
        AlarmListEventListeners(ALELint) = listener
        ALELint += 1

    End Sub

    Public Sub ResetAlarmListListener(listener As AlarmListEventListener) 'DO NOT USE THIS AT NORMAL SITUATION!!!!!
        AlarmListEventListeners = {}
    End Sub


    ''''''''''''''''''''''''''''''''


    Public Sub DbgLog(text As String)
        Debug.WriteLine(text)

        If EnableLogging Then
            FileIO.FileSystem.WriteAllText(LogPath, "[PSVA]" + text + vbCrLf, 1)
        End If

    End Sub

End Module
