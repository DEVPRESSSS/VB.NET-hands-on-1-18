Public Class Form1


    Private Sub gradeTxt_TextChanged(sender As Object, e As EventArgs) Handles gradeTxt.TextChanged
        Dim grade As Integer

        If Integer.TryParse(gradeTxt.Text, grade) Then
            If grade >= 98 AndAlso grade <= 100 Then

                equivalentTxt.Text = "1.00"

            ElseIf grade >= 95 AndAlso grade <= 97 Then

                equivalentTxt.Text = "1.25"

            ElseIf grade >= 92 AndAlso grade <= 94 Then

                equivalentTxt.Text = "1.50"

            ElseIf grade >= 89 AndAlso grade <= 91 Then

                equivalentTxt.Text = "1.75"

            ElseIf grade >= 85 AndAlso grade <= 88 Then

                equivalentTxt.Text = "2.00"

            ElseIf grade >= 82 AndAlso grade <= 84 Then

                equivalentTxt.Text = "2.25"

            ElseIf grade >= 80 AndAlso grade <= 81 Then

                equivalentTxt.Text = "2.50"

            ElseIf grade >= 77 AndAlso grade <= 79 Then

                equivalentTxt.Text = "2.75"

            ElseIf grade >= 75 AndAlso grade <= 76 Then

                equivalentTxt.Text = "3.00"

            ElseIf grade >= 0 AndAlso grade <= 74 Then

                equivalentTxt.Text = "Failed"

            Else
                equivalentTxt.Text = "Invalid Grade"
            End If
        Else
            equivalentTxt.Clear()
        End If
    End Sub

    Private Sub equivalentTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles equivalentTxt.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        If e.KeyChar = "."c AndAlso Not gradeTxt.Text.Contains(".") Then
            Return
        End If
        e.Handled = True
    End Sub
End Class
