Public Class AlarmCreateWnd

    Private Sub Load__() Handles MyBase.Load

        AddHandler Me.NextBtn.Click, Sub()

                                         If AlarmName.Text.Replace(" ", "").Replace("    ", "").Replace(vbCrLf, "").Length = 0 Or
                                        AlarmCaption.Text.Replace(" ", "").Replace("    ", "").Replace(vbCrLf, "").Length = 0 Then
                                             MessageBox.Show("You can't set alarm name or caption to blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                             Exit Sub
                                         End If

                                         Dim target As New Alarm_(Label_1.Text, Label_2.Text, {}, {0, 0} _
                                                                                         , "", {0, 0})
                                         target.AlarmRingLock = True
                                         Dim wnd As New AlarmSettingShellForm(target)

                                         wnd.DeleteBtn.Visible = False
                                         wnd.ReloadBtn.Visible = False
                                         wnd.SaveBtn.Text = "CREATE"
                                         wnd.alarmpanel.AlarmName.Text = AlarmName.Text
                                         wnd.alarmpanel.AlarmCaption.Text = AlarmCaption.Text
                                         wnd.Show()
                                         Me.Close()

                                     End Sub

    End Sub
End Class