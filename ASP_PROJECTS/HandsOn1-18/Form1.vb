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
End Class
