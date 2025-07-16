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
        ListBox2 = New ListBox()
        runBtn = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        ListBox1.Location = New Point(12, 72)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(148, 169)
        ListBox1.TabIndex = 0
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(174, 72)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(161, 169)
        ListBox2.TabIndex = 1
        ' 
        ' runBtn
        ' 
        runBtn.Location = New Point(12, 41)
        runBtn.Name = "runBtn"
        runBtn.Size = New Size(75, 23)
        runBtn.TabIndex = 2
        runBtn.Text = "Run"
        runBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(runBtn)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "LoopExam1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents runBtn As Button

End Class
