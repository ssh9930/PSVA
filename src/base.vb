Module base

    Public ReadOnly SettingPath As String = Environ("appdata") + "\PSVA"
    Public ReadOnly EnableLogging As Boolean = True 'todo : work on this
    Public ReadOnly LogPath As String = "C:\Users\ssh9930\Desktop\psva.log"

    Public Sub DbgLog(text As String)
        Debug.WriteLine(text)

        If EnableLogging Then
            FileIO.FileSystem.WriteAllText(LogPath, text + vbCrLf, 1)
        End If
    End Sub

End Module
