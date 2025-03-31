'Jason Permann
'Spring 2025
'RCET2265
'Graphics Example
' 
Option Compare Text
Option Explicit On
Option Strict On

Public Class GraphicsExampleForm

    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Black, 3)
        'pen.Color = Color.Black
        g.DrawLine(pen, 0, 50, 100, 50) 'Must have a defined pen starting x,y and ending x,y
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Red)
        'pen.Color = Color.Black
        g.DrawRectangle(pen, 150, 150, 300, 300) 'Must have a defined pen starting x,y and ending x,y
        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Blue)
        'pen.Color = Color.Black
        g.DrawEllipse(pen, 150, 150, 300, 300) 'Must have a defined pen starting x,y and ending x,y
        g.Dispose()
    End Sub

    'Event Handelers-------------------------------------------------------------------------------------
    Private Sub GraphicsExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        DrawLine()
        DrawRectangle()
        DrawCircle()
    End Sub
    Private Sub GraphicsExampleForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X}, {e.Y})"

    End Sub
End Class
