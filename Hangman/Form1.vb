Public Module GlobalVariables
    Public Points As Integer
End Module
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
    Dim Words(5) As String
    Dim correct As Boolean
    Dim word As String
    Dim letterpos As Integer

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
        Words(1) = "HI"
        Words(2) = "BYE"
        Words(3) = "HELLO"
        Words(4) = "NO"
        Words(5) = "YES"
        wordnum = 5 * Rnd()
        word = Words(wordnum)
        lblWord.Text = word

        For x = 1 To Len(word)
            Mid(lblWord.Text, x, 1) = "X"
        Next



    End Sub

    Private Sub Clicked(sender As System.Object, e As System.EventArgs)
        guesses = guesses & sender.text
        guessletter = sender.text
        If word.Contains(guessletter) = False Then
            Label3.Text = Label3.Text & guessletter
        Else
            Do While InStr(letterpos + 1, word, guessletter) > 0
                letterpos = InStr(letterpos + 1, word, guessletter)
                Mid(lblWord.Text, letterpos, 1) = guessletter
            Loop
        End If
        If lblWord.Text.Contains("X") Then
        Else MsgBox("You win!")
        End If

        If Len(Label3.Text) = 0 Then
            Points += 1000
        ElseIf Len(Label3.Text) <= 5
            Points += 750
        ElseIf Len(Label3.Text) <= 10
            Points += 500
        ElseIf Len(Label3.Text) <= 20
            Points += 200
        ElseIf Len(Label3.Text) <= 25
            Points += 100
        End If
        lblPoint.Text = Points
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
