﻿Public Class BorderPanel : Inherits Panel

    Public BorderSize As Integer = 1

    Private Right_ As New Control
    Private Left_ As New Control
    Private Top_ As New Control
    Private Bot_ As New Control

    Private BorderColor As System.Drawing.Color = System.Drawing.Color.FromArgb(Me.BackColor.R - 30, Me.BackColor.G - 30, Me.BackColor.B - 30)

    Sub New()

        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)

        SetRelativeSizeLocation()
        SetRelativeColor()

        Me.Controls.Add(Right_)
        Me.Controls.Add(Left_)
        Me.Controls.Add(Top_)
        Me.Controls.Add(Bot_)

    End Sub

    Private Sub SetRelativeSizeLocation() Handles Me.Paint 'TODO: change to sizechanged and build at main ide

        Right_.Size = New Point(BorderSize, Me.Height)
        Left_.Size = New Point(BorderSize, Me.Height)
        Top_.Size = New Point(Me.Width, BorderSize)
        Bot_.Size = New Point(Me.Width, BorderSize)

        Right_.Location = New Point(0, 0)
        Left_.Location = New Point(Me.Width - BorderSize, 0)
        Top_.Location = New Point(0, 0)
        Bot_.Location = New Point(0, Me.Height - BorderSize)

    End Sub

    Private Sub SetRelativeColor() Handles Me.BackColorChanged

        Right_.BackColor = BorderColor
        Left_.BackColor = BorderColor
        Top_.BackColor = BorderColor
        Bot_.BackColor = BorderColor

    End Sub

End Class