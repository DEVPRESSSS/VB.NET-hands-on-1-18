Public Class Form1
    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click

        If ListBox1.SelectedIndex <> -1 Then

            Dim selectedItem As String = ListBox1.SelectedItem
            ListBox1.Items.Remove(selectedItem)

        End If
    End Sub
End Class
