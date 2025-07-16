Public Class Form1



    Private Sub runBtn_Click(sender As Object, e As EventArgs) Handles runBtn.Click


        ListBox1.Items.Clear()

        For i As Integer = 8 To 1 Step -1

            Dim number As Integer = i * 3

            ListBox1.Items.Add(number)
        Next


    End Sub


End Class
