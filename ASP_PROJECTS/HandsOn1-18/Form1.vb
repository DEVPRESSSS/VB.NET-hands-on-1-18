Public Class Form1
    Private Sub moveBtn_Click(sender As Object, e As EventArgs) Handles moveBtn.Click

        If ListBox1.SelectedIndex <> -1 Then

            Dim selectedItem As String = ListBox1.SelectedItem
            ListBox2.Items.Add(selectedItem)
            ListBox1.Items.Remove(selectedItem)

        End If
    End Sub
End Class
