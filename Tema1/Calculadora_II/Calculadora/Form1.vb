Public Class Form1

    Private num = ""

    Dim total = 0

    Dim operador As String

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        num += "0"
        onNumChanged()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num += "1"
        onNumChanged()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num += "2"
        onNumChanged()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num += "3"
        onNumChanged()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num += "4"
        onNumChanged()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num += "5"
        onNumChanged()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num += "6"
        onNumChanged()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        num += "7"
        onNumChanged()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        num += "8"
        onNumChanged()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        num += "9"
        onNumChanged()
    End Sub


    Private Sub onNumChanged()
        NumberLabel.Text = num
    End Sub

    Private Sub ButtonCE_Click(sender As Object, e As EventArgs) Handles ButtonCE.Click
        num = ""
        operador = ""
        total = 0
        onNumChanged()
    End Sub

    Private Sub ButtonMore_Click(sender As Object, e As EventArgs) Handles ButtonMore.Click
        onOperator()
        operador = "+"
    End Sub

    Private Sub ButtonMinus_Click(sender As Object, e As EventArgs) Handles ButtonMinus.Click
        onOperator()
        operador = "-"
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        onOperator()
        operador = "*"
    End Sub

    Private Sub ButtonDivide_Click(sender As Object, e As EventArgs) Handles ButtonDivide.Click
        onOperator()
        operador = "/"
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        onOperator()
        operador = ""
        NumberLabel.Text = total
    End Sub

    Private Sub onOperator()
        If total = 0 Then
            total = Val(NumberLabel.Text)
            NumberLabel.Text = ""
            num = ""
        Else
            If operador = "+" Then
                total = total + Val(NumberLabel.Text)
            End If
            If operador = "-" Then
                total = total - Val(NumberLabel.Text)
            End If
            If operador = "*" Then
                total = total * Val(NumberLabel.Text)
            End If
            If operador = "/" Then
                total = total / Val(NumberLabel.Text)
            End If

            NumberLabel.Text = ""
            num = ""
        End If


    End Sub

    Private Sub ButtonPoint_Click(sender As Object, e As EventArgs) Handles ButtonPoint.Click
        num += "."
        onNumChanged()
    End Sub
End Class
