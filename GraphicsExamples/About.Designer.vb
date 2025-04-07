<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AboutLabel
        '
        Me.AboutLabel.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutLabel.Location = New System.Drawing.Point(12, 9)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(776, 227)
        Me.AboutLabel.TabIndex = 0
        Me.AboutLabel.Text = "ISU Crayon application" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jason Permann" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ACME Software LLC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spring 2025"
        '
        'OkButton
        '
        Me.OkButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.OkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.OkButton.Location = New System.Drawing.Point(708, 392)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(80, 46)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "&OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.AboutLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About ISU Crayon"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AboutLabel As Label
    Friend WithEvents OkButton As Button
End Class
