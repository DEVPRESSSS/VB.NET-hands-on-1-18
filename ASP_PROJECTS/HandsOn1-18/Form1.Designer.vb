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
        enterBtn = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(12, 102)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(323, 139)
        ListBox1.TabIndex = 0
        ' 
        ' enterBtn
        ' 
        enterBtn.Location = New Point(12, 41)
        enterBtn.Name = "enterBtn"
        enterBtn.Size = New Size(75, 23)
        enterBtn.TabIndex = 2
        enterBtn.Text = "Enter"
        enterBtn.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(14, 74)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(321, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(TextBox1)
        Controls.Add(enterBtn)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "LoopExam5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents enterBtn As Button
    Friend WithEvents TextBox1 As TextBox

End Class
