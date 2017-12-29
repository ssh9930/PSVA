Public Class SAPI

    Shared Sub Speak(text As String, Optional Asynchronous As Boolean = False) 'multithread
        DbgLog("[sapi] Speak() : text=private, asynchronous=" + Asynchronous.ToString)

        If Asynchronous Then

            Dim sapithread As New Threading.Thread(Sub()
                                                       DbgLog("[sapi-asynchronous] working on the another thread.")
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
        DbgLog("[sapi.speak] speaking..")

        Dim sapi As Object = CreateObject("SAPI.SpVoice")
        sapi.Rate = 0.1
        sapi.Speak(text)

        DbgLog("[sapi.speak] done.")
    End Sub

End Class
