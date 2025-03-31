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
        Dim pen As New Pen(Color.Black)
        'pen.Color = Color.Black
        g.DrawLine(pen, 0, 0, 100, 100) 'Must have a defined pen starting x,y and ending x,y
        g.Dispose()
    End Sub

    Private Sub GraphicsExampleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawLine()
    End Sub

    Private Sub GraphicsExampleForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = $"({e.X}, {e.Y})"
    End Sub
End Class
