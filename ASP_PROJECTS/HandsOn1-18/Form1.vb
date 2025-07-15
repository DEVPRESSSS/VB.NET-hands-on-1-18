Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Variables to store the peso and dollar conversion Value
        Dim peso, dollarValue As Double

        'Get the value of Peso from pesoTxt.Text (TextBox)
        peso = pesoTxt.Text

        'Calculate the value of dollar
        dollarValue = peso * 0.18

        'Display the result in the dollarResult.Text (TextBox)
        dollarResult.Text = dollarValue

    End Sub

    Private Sub pesoTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pesoTxt.KeyPress

        ' Allow control characters like Backspace
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        ' Allow digits (0-9)
        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        ' Allow one decimal point only
        If e.KeyChar = "."c AndAlso Not pesoTxt.Text.Contains(".") Then
            Return
        End If

        ' Block everything else (like letters and symbols)
        e.Handled = True

    End Sub
End Class
