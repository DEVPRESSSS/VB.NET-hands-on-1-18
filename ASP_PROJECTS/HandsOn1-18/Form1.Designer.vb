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
        typeTxt = New TextBox()
        Label2 = New Label()
        numberTxt = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(86, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = "Number:"
        ' 
        ' typeTxt
        ' 
        typeTxt.Location = New Point(148, 101)
        typeTxt.Name = "typeTxt"
        typeTxt.ReadOnly = True
        typeTxt.Size = New Size(115, 23)
        typeTxt.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(106, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 3
        Label2.Text = "Type:"
        ' 
        ' numberTxt
        ' 
        numberTxt.Location = New Point(146, 60)
        numberTxt.Name = "numberTxt"
        numberTxt.Size = New Size(117, 23)
        numberTxt.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(Label2)
        Controls.Add(typeTxt)
        Controls.Add(numberTxt)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "AirCraft"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents typeTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numberTxt As TextBox

End Class
