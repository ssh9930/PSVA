Public Class SAPI

    Shared Sub Speak(text As String, Optional Asynchronous As Boolean = True) 'multithread

        If Asynchronous Then

            Dim sapithread As New Threading.Thread(Sub()
                                                       Dim caller As New SAPI
                                                       caller.Speak_(text)
                                                   End Sub)


            sapithread.Start() 'start thread

        Else
            Dim caller As New SAPI
            caller.Speak_(text)
        End If

    End Sub

    Private Sub Speak_(text As String)

        Dim sapi As Object = CreateObject("SAPI.SpVoice")
        sapi.Rate = 0.1
        sapi.Speak(text)

    End Sub

End Class
