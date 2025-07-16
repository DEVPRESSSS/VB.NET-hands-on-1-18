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
        Label1 = New Label()
        equivalentTxt = New TextBox()
        Label2 = New Label()
        gradeTxt = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(99, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Grade:"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' equivalentTxt
        ' 
        equivalentTxt.Location = New Point(148, 101)
        equivalentTxt.Name = "equivalentTxt"
        equivalentTxt.ReadOnly = True
        equivalentTxt.Size = New Size(115, 23)
        equivalentTxt.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 15)
        Label2.TabIndex = 3
        Label2.Text = "Equivalent:"
        ' 
        ' gradeTxt
        ' 
        gradeTxt.Location = New Point(146, 60)
        gradeTxt.Name = "gradeTxt"
        gradeTxt.Size = New Size(117, 23)
        gradeTxt.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(Label2)
        Controls.Add(equivalentTxt)
        Controls.Add(gradeTxt)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Grading System"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents equivalentTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents gradeTxt As TextBox

End Class
