Public Class Form1



    Private Sub runBtn_Click(sender As Object, e As EventArgs) Handles runBtn.Click

        ListBox2.Items.Clear()

        For i As Integer = ListBox1.Items.Count - 1 To 0 Step -1

            Dim number As Integer = ListBox1.Items(i)
            ListBox2.Items.Add(number)
        Next


    End Sub
End Class
