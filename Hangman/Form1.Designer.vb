<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnKeyboard = New System.Windows.Forms.Button()
        Me.btnHKeyboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Word = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnKeyboard
        '
        Me.btnKeyboard.Location = New System.Drawing.Point(448, 12)
        Me.btnKeyboard.Name = "btnKeyboard"
        Me.btnKeyboard.Size = New System.Drawing.Size(75, 43)
        Me.btnKeyboard.TabIndex = 0
        Me.btnKeyboard.Text = "Show Keyboard"
        Me.btnKeyboard.UseVisualStyleBackColor = True
        Me.btnKeyboard.Visible = False
        '
        'btnHKeyboard
        '
        Me.btnHKeyboard.Location = New System.Drawing.Point(448, 12)
        Me.btnHKeyboard.Name = "btnHKeyboard"
        Me.btnHKeyboard.Size = New System.Drawing.Size(75, 43)
        Me.btnHKeyboard.TabIndex = 1
        Me.btnHKeyboard.Text = "Hide Keyboard"
        Me.btnHKeyboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Failed Guesses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 3
        '
        'Word
        '
        Me.Word.AutoSize = True
        Me.Word.Location = New System.Drawing.Point(105, 259)
        Me.Word.Name = "Word"
        Me.Word.Size = New System.Drawing.Size(39, 13)
        Me.Word.TabIndex = 4
        Me.Word.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 542)
        Me.Controls.Add(Me.Word)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHKeyboard)
        Me.Controls.Add(Me.btnKeyboard)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnKeyboard As Button
    Friend WithEvents btnHKeyboard As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Word As Label
End Class
