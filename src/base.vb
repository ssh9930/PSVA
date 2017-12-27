Module base

    Public ReadOnly SettingPath As String = Environ("appdata") + "\PSVA\"
    Public ReadOnly EnableLogging As Boolean = False 'todo : work on this
    Public ReadOnly LogPath As String = "C:\Users\ssh9930\Desktop\psva.log"

    Private __readonly_alarm_list__ As Alarm_()

    Public ReadOnly AlarmInfoFileName As String = ".alarminfo" 'create this file if it isnt exist

    ''''''''''''''''''''''''''''''''
    Public DoUpdateAlarmList As Boolean = True
    Public AlarmListOnlyOnMemory As Boolean = False

    Public Property AlarmList As Alarm_()

        Get
            Return __readonly_alarm_list__
        End Get
        Set(value As Alarm_())
            DbgLog("[AlarmList] alarmlist value changed.")
            __readonly_alarm_list__ = value 'set value

            If DoUpdateAlarmList Then
                UpdateAlarmList(value)
            Else
                DbgLog("[AlarmList] UpdateAlarmList=0")
            End If
        End Set


    End Property

    Public Sub UpdateAlarmList(value As Alarm_()) '수동 업데이트
        DbgLog("[AlarmListUpdater] called.")

        For Each i In AlarmListEventListeners 'raise alarmlisteventlisteners' events
            DbgLog("[AlarmListUpdater] activating alarmlisteventlistener..")
            i.__base__activate()
        Next

        'save new alarmlist.

        If Not AlarmListOnlyOnMemory Then
            DbgLog("[AlarmListUpdater] saving new alarmlist to disk")
            Alarm_.AlarmsToSetting(AlarmList)
        Else
            DbgLog("[AlarmListUpdater] AlarmListOnlyOnMemory=1 !!")
        End If

        DbgLog("[AlarmListUpdater] ALL DONE!!")
    End Sub

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
