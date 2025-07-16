Imports System.Data.OleDb

Public Class Form1

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Database21.accdb;"

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        fullNameTxt.Clear()
        CourseTxt.Clear()
        SetTxt.Clear()
        IdNumberTxt.Clear()
        Id.Clear()
    End Sub

    'Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click

    '    Dim connection As New OleDbConnection(connectionString)

    '    Try
    '        connection.Open()

    '        Dim fullName As String = fullNameTxt.Text
    '        Dim course As String = CourseTxt.Text
    '        Dim setInput As String = SetTxt.Text
    '        Dim idNumber As String = IdNumberTxt.Text



    '        Dim query As String = "INSERT INTO StudentInfo (FullName, Course, [Set], IdNumber) VALUES (?, ?, ?, ?)"
    '        Dim cmd As New OleDbCommand(query, connection)

    '        cmd.Parameters.AddWithValue("?", fullName)
    '        cmd.Parameters.AddWithValue("?", course)
    '        cmd.Parameters.AddWithValue("?", setInput)
    '        cmd.Parameters.AddWithValue("?", idNumber)

    '        Dim result As Integer = cmd.ExecuteNonQuery()

    '        If result > 0 Then
    '            MessageBox.Show("Student info inserted successfully!")
    '            LoadStudentData()
    '        Else
    '            MessageBox.Show("Insert failed.")
    '        End If

    '        connection.Close()

    '    Catch ex As Exception
    '        MessageBox.Show("Error: " & ex.Message)
    '    End Try

    'End Sub

    Private Sub LoadStudentData()
        Dim connection As New OleDbConnection(connectionString)

        Try
            connection.Open()

            Dim query As String = "SELECT * FROM StudentInfo"
            Dim adapter As New OleDbDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            StudentTable.DataSource = table

            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudentData()

    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Dim connection As New OleDbConnection(connectionString)

        Try
            connection.Open()

            Dim fullName As String = fullNameTxt.Text
            Dim course As String = CourseTxt.Text
            Dim setInput As String = SetTxt.Text
            Dim idNumber As String = IdNumberTxt.Text
            Dim rowId As String = Id.Text



            If String.IsNullOrWhiteSpace(fullName) OrElse
               String.IsNullOrWhiteSpace(course) OrElse
               String.IsNullOrWhiteSpace(setInput) OrElse
               String.IsNullOrWhiteSpace(idNumber) Then

                MessageBox.Show("Please fill out all fields properly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim query As String = "UPDATE StudentInfo SET FullName = ?, Course = ?, [Set] = ?, IdNumber = ? WHERE ID = ?"
            Dim cmd As New OleDbCommand(query, connection)

            cmd.Parameters.AddWithValue("?", fullName)
            cmd.Parameters.AddWithValue("?", course)
            cmd.Parameters.AddWithValue("?", setInput)
            cmd.Parameters.AddWithValue("?", idNumber)
            cmd.Parameters.AddWithValue("?", rowId)

            Dim result As Integer = cmd.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Student info updated successfully!")
                LoadStudentData()
            Else
                MessageBox.Show("Update failed. Record not found.")
            End If

            connection.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


    Private Sub StudentTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentTable.CellClick
        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = StudentTable.Rows(e.RowIndex)

            fullNameTxt.Text = row.Cells("FullName").Value.ToString()
            CourseTxt.Text = row.Cells("Course").Value.ToString()
            SetTxt.Text = row.Cells("Set").Value.ToString()
            IdNumberTxt.Text = row.Cells("IdNumber").Value.ToString()
            Id.Text = row.Cells("ID").Value.ToString()

        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Dim connection As New OleDbConnection(connectionString)

        Try
            If String.IsNullOrWhiteSpace(IdNumberTxt.Text) Then
                MessageBox.Show("Please select a student to delete.")
                Return
            End If

            Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If confirm = DialogResult.Yes Then
                connection.Open()

                Dim idNumber As String = Id.Text
                Dim query As String = "DELETE FROM StudentInfo WHERE ID = ?"
                Dim cmd As New OleDbCommand(query, connection)

                cmd.Parameters.AddWithValue("?", idNumber)

                Dim result As Integer = cmd.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Student deleted successfully!")
                    LoadStudentData()

                Else
                    MessageBox.Show("Delete failed. Record not found.")
                End If

                connection.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub fullNameTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fullNameTxt.KeyPress

        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If fullNameTxt.SelectionStart = 0 AndAlso e.KeyChar = " "c Then
            e.Handled = True
            Return
        End If

        If e.KeyChar = " "c AndAlso fullNameTxt.SelectionStart > 0 Then
            Dim prevChar As Char = fullNameTxt.Text(fullNameTxt.SelectionStart - 1)
            If prevChar = " "c Then
                e.Handled = True
                Return
            End If
        End If

        Dim pattern As String = "[A-Za-z .,]"
        If Not System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), pattern) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CourseTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CourseTxt.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsLetter(e.KeyChar) Then
            Return
        End If



        If e.KeyChar = " "c AndAlso CourseTxt.SelectionStart > 0 Then
            Dim prevChar As Char = CourseTxt.Text(CourseTxt.SelectionStart - 1)
            If prevChar = " "c Then
                e.Handled = True
                Return
            End If
        End If

        Dim pattern As String = "[A-Za-z .,]"
        If Not System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), pattern) Then
            e.Handled = True
        End If


        e.Handled = True
    End Sub

    Private Sub SetTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SetTxt.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsLetter(e.KeyChar) Then
            Return
        End If

        If CourseTxt.SelectionStart = 0 AndAlso e.KeyChar = " "c Then
            e.Handled = True
            Return
        End If


        If e.KeyChar = "-"c Then
            Return
        End If

        e.Handled = True
    End Sub


    Private Sub IdNumberTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdNumberTxt.KeyPress
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsLetter(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            Return
        End If


        e.Handled = True
    End Sub
End Class
