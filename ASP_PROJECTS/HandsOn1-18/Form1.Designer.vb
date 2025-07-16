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
        moveBtn = New Button()
        ListBox2 = New ListBox()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"hey", "heys", "heyss"})
        ListBox1.Location = New Point(12, 79)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(147, 139)
        ListBox1.TabIndex = 0
        ' 
        ' moveBtn
        ' 
        moveBtn.Location = New Point(12, 41)
        moveBtn.Name = "moveBtn"
        moveBtn.Size = New Size(75, 23)
        moveBtn.TabIndex = 2
        moveBtn.Text = "Move"
        moveBtn.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(180, 79)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(155, 139)
        ListBox2.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(ListBox2)
        Controls.Add(moveBtn)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "ListBoxExam3Move"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents moveBtn As Button
    Friend WithEvents ListBox2 As ListBox

End Class
