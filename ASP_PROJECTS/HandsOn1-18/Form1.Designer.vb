<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ListBox1 = New ListBox()
        removeBtn = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"hey", "heys", "heyss"})
        ListBox1.Location = New Point(12, 79)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(323, 139)
        ListBox1.TabIndex = 0
        ' 
        ' removeBtn
        ' 
        removeBtn.Location = New Point(12, 41)
        removeBtn.Name = "removeBtn"
        removeBtn.Size = New Size(75, 23)
        removeBtn.TabIndex = 2
        removeBtn.Text = "Remove"
        removeBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(removeBtn)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "ListBoxExam2Removed"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents removeBtn As Button

End Class
