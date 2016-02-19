Public Class Form1
    Public letters(25) As Button
    Dim buttonpoint As Point
    Dim qwerty As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
    Dim myfont As Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buttonpoint.X = 35
        buttonpoint.Y = 35
        'Define buttons in button array
        For x = 0 To 25
            letters(x) = New Button
            letters(x).Width = 35
            letters(x).Height = 35
            letters(x).Location = buttonpoint
            buttonpoint.X = buttonpoint.X + 40
            letters(x).Text = Mid(qwerty, (x + 1), 1)
            letters(x).BackColor = Color.DodgerBlue
            letters(x).ForeColor = Color.White
            letters(x).FlatStyle = FlatStyle.Flat
            letters(x).Font = myfont
            If x = 9 Then
                buttonpoint.Y = 75
                buttonpoint.X = 55
            End If
            If x = 18 Then
                buttonpoint.Y = 115
                buttonpoint.X = 75
            End If
            AddHandler letters(x).Click, AddressOf Clicked
            Me.Controls.Add(letters(x))
        Next

    End Sub

    Private Sub Clicked(sender As System.Object, e As System.EventArgs)

    End Sub

End Class
