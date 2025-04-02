﻿'Jason Permann
'Spring 2025
'RCET2265
'Graphics Example
' 
Option Compare Text
Option Explicit On
Option Strict On

Public Class GraphicsExampleForm

    Function ForeGroundColor(Optional newColor As Color = Nothing) As Color
        Static _forecolor As Color = Color.Black
        If newColor <> Nothing Then
            _forecolor = newColor
        End If
        Return _forecolor
    End Function

    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black, 3)
        g.DrawLine(pen, 0, 50, 100, 50) 'Must have a defined pen starting x,y and ending x,y
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red)

        g.DrawRectangle(pen, 150, 150, 300, 300) 'Must have a defined pen starting x,y and ending x,y
        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Blue)

        g.DrawEllipse(pen, 150, 150, 300, 300) 'Must have a defined pen starting x,y and ending x,y
        g.Dispose()
    End Sub

    Sub DrawString()

    End Sub

    Sub DrawWithMouse(oldx As Integer, oldY As Integer, newX As Integer, newY As Integer)
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(ForeGroundColor)
        g.DrawLine(pen, oldX, oldY, newX, newY)
        g.Dispose()
    End Sub

    'Event Handelers-------------------------------------------------------------------------------------
    Private Sub GraphicsExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Me.Refresh()
        'DrawLine()
        'DrawRectangle()
        'DrawCircle()

    End Sub
    Private Sub GraphicsExampleForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Static oldX, oldY As Integer 'static neccesary
        Me.Text = $"({e.X}, {e.Y}) {e.Button.ToString}"
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldX, oldY, e.X, e.Y)
            Case "Right"
            Case "Middle"
        End Select
        oldX = e.X 'must be down here to draw correctly 
        oldY = e.Y 'must be down here to draw correctly

    End Sub
    Private Sub ForeGroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForeGroundColorToolStripMenuItem.Click, ForegroundColorContextMenuItem.Click
        ColorDialog.ShowDialog()
        ForeGroundColor(ColorDialog.Color)
    End Sub

    Private Sub ClearContextMenuItem_Click(sender As Object, e As EventArgs) Handles ClearContextMenuItem.Click
        Me.Refresh()
    End Sub
End Class
