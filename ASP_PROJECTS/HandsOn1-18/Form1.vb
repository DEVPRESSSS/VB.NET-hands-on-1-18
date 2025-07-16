Public Class Form1
    Private Sub enterBtn_Click(sender As Object, e As EventArgs) Handles enterBtn.Click

        Dim inputText As String = TextBox1.Text

        If Not String.IsNullOrWhiteSpace(inputText) Then
            ListBox1.Items.Add(inputText)
            TextBox1.Clear()

        Else
            MsgBox("Please enter a value")
        End If

    End Sub
End Class
