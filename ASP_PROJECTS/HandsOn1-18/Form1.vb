Public Class Form1



    Private Sub runBtn_Click(sender As Object, e As EventArgs) Handles runBtn.Click

        ListBox2.Items.Clear()

        For i As Integer = 1 To ListBox1.Items.Count Step 1

            Dim product As Integer = i * i
            ListBox2.Items.Add(product)
        Next


    End Sub

    End Sub
End Class
