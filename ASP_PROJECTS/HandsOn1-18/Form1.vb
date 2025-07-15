Public Class Form1



    Private Sub plusBtn_Click(sender As Object, e As EventArgs) Handles plusBtn.Click

        Dim firstNum, secondNum, result As Double

        If String.IsNullOrEmpty(firstNumTxt.Text) Or String.IsNullOrEmpty(secondNumberTxt.Text) Then

            MsgBox("Please enter a value.")

            Return
        End If

        firstNum = firstNumTxt.Text
        secondNum = secondNumberTxt.Text

        result = firstNum + secondNum
        resultTxt.Text = result
    End Sub

    Private Sub minusBtn_Click(sender As Object, e As EventArgs) Handles minusBtn.Click

        Dim firstNum, secondNum, result As Double

        If String.IsNullOrEmpty(firstNumTxt.Text) Or String.IsNullOrEmpty(secondNumberTxt.Text) Then

            MsgBox("Please enter a value.")

            Return
        End If

        firstNum = firstNumTxt.Text
        secondNum = secondNumberTxt.Text

        result = firstNum - secondNum
        resultTxt.Text = result
    End Sub

    Private Sub multiplyBtn_Click(sender As Object, e As EventArgs) Handles multiplyBtn.Click

        Dim firstNum, secondNum, result As Double

        If String.IsNullOrEmpty(firstNumTxt.Text) Or String.IsNullOrEmpty(secondNumberTxt.Text) Then

            MsgBox("Please enter a value.")

            Return
        End If

        firstNum = firstNumTxt.Text
        secondNum = secondNumberTxt.Text

        result = firstNum * secondNum
        resultTxt.Text = result
    End Sub

    Private Sub divideBtn_Click(sender As Object, e As EventArgs) Handles divideBtn.Click

        Dim firstNum, secondNum, result As Double

        If String.IsNullOrEmpty(firstNumTxt.Text) Or String.IsNullOrEmpty(secondNumberTxt.Text) Then

            MsgBox("Please enter a value.")

            Return
        End If

        firstNum = firstNumTxt.Text
        secondNum = secondNumberTxt.Text

        result = firstNum / secondNum
        resultTxt.Text = result.ToString("N2")
    End Sub

    Private Sub firstNumTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles firstNumTxt.KeyPress

        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso Not firstNumTxt.Text.Contains(".") AndAlso Not firstNumTxt.Text.Contains(".") Then
            Return
        End If

        e.Handled = True
    End Sub
End Class
