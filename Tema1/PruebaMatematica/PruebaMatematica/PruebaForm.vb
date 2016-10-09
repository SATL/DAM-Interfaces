Public Class PruebaForm

    Dim randomizer As New Random

    Dim addend1 As Integer
    Dim addend2 As Integer

    Dim minuend As Integer
    Dim subtrahend As Integer

    Dim multiplicand As Integer
    Dim multiplier As Integer

    Dim dividend As Integer
    Dim divisor As Integer

    Dim timeLeft As Integer

    Dim soundCorrect = New System.Media.SoundPlayer("C:\Windows\Media\notify.wav")


    Sub StartTheQuiz()
        addend1 = randomizer.Next(51)
        addend2 = randomizer.Next(51)

        plusLeftLabel.Text = addend1.ToString
        plusRightLabel.Text = addend2.ToString

        suma.Value = 0

        minuend = randomizer.Next(1, 101)
        subtrahend = randomizer.Next(1, minuend)
        minusLeftLabel.Text = minuend.ToString
        minusRightLabel.Text = subtrahend.ToString
        diferencia.Value = 0

        multiplicand = randomizer.Next(2, 11)
        multiplier = randomizer.Next(2, 11)
        timesLeftLabel.Text = multiplicand.ToString
        timesRightLabel.Text = multiplier.ToString
        producto.Value = 0

        divisor = randomizer.Next(2, 11)
        Dim temporaryQuotient As Integer = randomizer.Next(2, 11)
        dividend = divisor * temporaryQuotient
        divideleftLabel.Text = dividend.ToString
        divideRightLabel.Text = divisor.ToString
        cociente.Value = 0

        timeLeft = 30
        timeLabel.Text = "30 segundos"
        Timer1.Start()

    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        startButton.Enabled = False
        StartTheQuiz()
    End Sub

    Public Function CheckTheAnswer() As Boolean

        If ((addend1 + addend2 = suma.Value) AndAlso (minuend - subtrahend = diferencia.Value) AndAlso (multiplicand * multiplier = producto.Value) AndAlso (dividend / divisor = cociente.Value)) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If CheckTheAnswer() Then
            Timer1.Stop()
            MessageBox.Show("¡Tienes todas las respuestas correctas!", "¡Felicidades!")
            startButton.Enabled = True
        ElseIf timeLeft > 0 Then
            timeLeft = timeLeft - 1
            timeLabel.Text = timeLeft & " segundos"
            If timeLeft <= 5 Then
                timeLabel.BackColor = Color.Red
            End If
        Else
            Timer1.Stop()
            timeLabel.Text = "Se acabo el tiempo"
            MessageBox.Show("No has terminado a tiempo.", "Lo siento")
            suma.Value = addend1 + addend2
            diferencia.Value = minuend - subtrahend

            producto.Value = multiplicand * multiplier
            cociente.Value = dividend / divisor
            startButton.Enabled = True
        End If
    End Sub

    Private Sub answer_Enter(sender As Object, e As EventArgs) Handles suma.Enter, diferencia.Enter, producto.Enter, cociente.Enter
        Dim answerBox As NumericUpDown = TryCast(sender, NumericUpDown)

        If answerBox IsNot Nothing Then
            Dim lengthOfAnswer As Integer = answerBox.Value.ToString().Length
            answerBox.Select(0, lengthOfAnswer)
        End If
    End Sub

    Private Sub suma_ValueChanged(sender As Object, e As EventArgs) Handles suma.ValueChanged
        If addend1 + addend2 = suma.Value Then
            soundCorrect.Play()
        End If
    End Sub
End Class
