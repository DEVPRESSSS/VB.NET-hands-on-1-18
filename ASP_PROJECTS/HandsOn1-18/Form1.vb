Public Class Form1



    Private Sub numberTxt_TextChanged(sender As Object, e As EventArgs) Handles letterInputTxt.TextChanged

        Dim letter As String

        letter = letterInputTxt.Text.ToLower()

        If letter = "b" Then
            typeTxt.Text = "Battleship"

        ElseIf letter = "c" Then
            typeTxt.Text = "Cruiser"

        ElseIf letter = "d" Then
            typeTxt.Text = "Destroyer"

        ElseIf letter = "f" Then
            typeTxt.Text = "Frigate"
        Else
            typeTxt.Text = "No info"
        End If





    End Sub

    Private Sub numberTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles letterInputTxt.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsLetter(e.KeyChar) Then
            Return
        End If

        e.Handled = True
    End Sub


End Class
