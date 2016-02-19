Public Class Form1
    Public letters(25) As Button
    Dim accept As Integer
    Dim space As Button
    Dim buttonpoint As Point
    Dim qwerty As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
    Dim myfont As Font = New Font(FontFamily.GenericSansSerif, 14.0F, FontStyle.Bold)
    Dim wordnum As Integer
    Dim guessletter As String
    Dim guesses As String
    Dim strWord As String
    Dim correct As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        accept = MsgBox("Accept?", 4, "Accept")
        If accept = 6 Then
            Me.Show()
        Else
            End
        End If
        buttonpoint.X = 535
        buttonpoint.Y = 65
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
                buttonpoint.Y = 105
                buttonpoint.X = 555
            End If
            If x = 18 Then
                buttonpoint.Y = 145
                buttonpoint.X = 575
            End If
            AddHandler letters(x).Click, AddressOf Clicked
            Me.Controls.Add(letters(x))
        Next
        buttonpoint.X = 655
        buttonpoint.Y = 185
        space = New Button
        space.Width = 195
        space.Height = 35
        space.Location = buttonpoint
        space.BackColor = Color.DodgerBlue
        space.ForeColor = Color.White
        space.FlatStyle = FlatStyle.Flat
        space.Font = myfont
        space.Text = "Space"
        AddHandler space.Click, AddressOf Clicked
        Me.Controls.Add(space)


        'Word Gen
        wordnum = 5 * Rnd()
        If wordnum = 0 Then
            strWord = "Hello"
        ElseIf wordnum = 1
            strWord = "Hi"
        ElseIf wordnum = 2
            strWord = "Yes"
        ElseIf wordnum = 3
            strWord = "No"
        ElseIf wordnum = 4
            strWord = "Bye"
        Else strWord = "Goodbye"
        End If
        Word.Text = strWord

    End Sub

    Private Sub Clicked(sender As System.Object, e As System.EventArgs)
        guesses = guesses & sender.text
        guessletter = sender.text
        For x = 1 To Len(strWord)
            If UCase(Mid(strWord, x, 1)) Like sender.text Then
                MsgBox("Yes")
            End If
        Next
        sender.visible = False
        For x = 1 To Len(strWord)
            For y = 1 To Len(guesses)
                If Mid(strWord, x, 1) Like Mid(guesses, y, 1) Then
                    correct = True
                Else correct = False
                End If
            Next
        Next
        If correct = True Then
            MsgBox("Congrats, you win!")
        End If
    End Sub

    Private Sub btnKeyboard_Click(sender As Object, e As EventArgs) Handles btnKeyboard.Click
        Me.Width = 960
        sender.hide
        btnHKeyboard.Show()
    End Sub

    Private Sub btnHKeyboard_Click(sender As Object, e As EventArgs) Handles btnHKeyboard.Click
        Me.Width = 544
        sender.hide
        btnKeyboard.Show()
    End Sub
End Class
