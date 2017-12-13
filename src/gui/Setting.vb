Public Class Setting

    Private Sub Load_() Handles Me.Load

        ' AddHandler Me.Closed, Sub() End

        ' disable vertical scrolling

    End Sub

    Public Sub ReloadAlarmUI() Handles Me.Load

        Dim cnt As Integer = 1

        For Each i In AlarmList

            Dim panel_ As New AlarmPanel

            Me.Controls.Add(panel_)
            panel_.alarm_ = i
            panel_.ReloadUIwithAlarmInfo()
            panel_.Location = New Point(0, 80 + (cnt - 1) * 79)
            cnt += 1

        Next

        If Not AlarmList.Length = 0 Then 'todo : make a whole management class about this.
            NoAlarmLabel.Visible = False
            NoAlarmPic.Visible = False
        End If

    End Sub
End Class
