'Jason Permann
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

    Function BackGroundColor(Optional newColor As Color = Nothing) As Color
        Static _backcolor As Color = Color.Black
        If newColor <> Nothing Then
            _backcolor = newColor
        End If
        Return _backcolor
    End Function

    Function PenWidth(Optional newWidth As Integer = -1) As Integer
        Static _penWidth As Integer = 10
        'define valid range
        If newWidth <= 100 Then
            _penWidth = 100
        ElseIf newWidth >= 0 Then
            _penWidth = newWidth
        End If

        Return _penWidth
    End Function

    Sub DrawLine()
        ' Dim g As Graphics = Me.CreateGraphics
        ' Dim pen As New Pen(Color.Black, 3)
        ' g.DrawLine(pen, 0, 50, 100, 50) 'Must have a defined pen starting x,y and ending x,y
        ' g.Dispose()
    End Sub

    Sub DrawRectangle()
        'Dim g As Graphics = Me.CreateGraphics
        'Dim pen As New Pen(Color.Red)
        'g.DrawRectangle(pen, 150, 150, 300, 300) 'Must have a defined pen starting x,y and ending x,y
        ' g.Dispose()
    End Sub

    Sub DrawCircle()
        'Dim g As Graphics = Me.CreateGraphics
        'Dim pen As New Pen(Color.Blue)

        'g.DrawEllipse(pen, 150, 150, 300, 300) 'Must have a defined pen starting x,y and ending x,y
        'g.Dispose()
    End Sub

    Sub DrawString()

    End Sub

    Sub DrawWithMouse(oldx As Integer, oldY As Integer, newX As Integer, newY As Integer)
        'Dim g As Graphics = Me.CreateGraphics    (OLD one for just form)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
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
    Private Sub GraphicsExampleForm_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
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
        'Me.Refresh    (OLD one for just form)
        DrawingPictureBox.Refresh()
    End Sub

    Private Sub BackgroundColorContextMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorContextMenuItem.Click, BackgroundColorToolStripMenuItem1.Click
        ColorDialog.ShowDialog()
        BackGroundColor(DrawingPictureBox.BackColor) 'not working
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        About.Show()
    End Sub

    Private Sub GraphicsExampleForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SplashForm.Show()
        Me.Hide()
    End Sub
End Class
