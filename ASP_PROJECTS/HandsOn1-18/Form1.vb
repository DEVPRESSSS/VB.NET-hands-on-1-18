Public Class Form1

    Private Sub magnitudeTxt_TextChanged(sender As Object, e As EventArgs) Handles magnitudeTxt.TextChanged

        Dim magnitudeInput As Double

        If Double.TryParse(magnitudeTxt.Text, magnitudeInput) Then

            If magnitudeInput > 7.5 Then

                effectTxt.Text = "Catastrophe"

            ElseIf magnitudeInput >= 6.6 And magnitudeInput <= 7.5 Then

                effectTxt.Text = "Disaster"

            ElseIf magnitudeInput >= 5.6 And magnitudeInput <= 6.5 Then

                effectTxt.Text = "Serious damage"

            ElseIf magnitudeInput >= 5 And magnitudeInput <= 5.5 Then

                effectTxt.Text = "Some damage"

            Else

                effectTxt.Text = "No damage"
            End If
        Else
            effectTxt.Clear()
        End If
    End Sub

    Private Sub magnitudeTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles magnitudeTxt.KeyPress

        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso Not magnitudeTxt.Text.Contains(".") Then
            Return
        End If
        e.Handled = True

    End Sub
End Class
