Public Class Form1



    Private Sub numberTxt_TextChanged(sender As Object, e As EventArgs) Handles numberTxt.TextChanged

        Dim inputNumber As Integer


        If Integer.TryParse(numberTxt.Text, inputNumber) Then
            If inputNumber > 1100 Then

                typeTxt.Text = "Civilian"

            ElseIf inputNumber >= 500 And inputNumber <= 1100 Then
                typeTxt.Text = "Military"

            Else
                typeTxt.Text = "Bird"

            End If
        End If





    End Sub

    Private Sub numberTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles numberTxt.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        e.Handled = True
    End Sub
End Class
