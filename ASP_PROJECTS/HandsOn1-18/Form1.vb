Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim peso, dollarValue As Double

        peso = pesoTxt.Text

        dollarValue = peso * 0.18

        dollarResult.Text = dollarValue

    End Sub

    Private Sub pesoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pesoTxt.KeyPress

        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso Not pesoTxt.Text.Contains(".") Then
            Return
        End If

        e.Handled = True

    End Sub
End Class
