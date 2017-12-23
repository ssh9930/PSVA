Public Class AlarmListEventListener

    Public Event AlarmListChanged()

    Public Sub __base__activate() 'DO NOT USE THIS
        DbgLog("AlarmListChanged() event raise")
        RaiseEvent AlarmListChanged()
    End Sub

End Class
