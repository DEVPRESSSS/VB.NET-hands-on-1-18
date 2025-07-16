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
        effectTxt = New TextBox()
        Label2 = New Label()
        magnitudeTxt = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 0
        Label1.Text = "Magnitude:"
        ' 
        ' effectTxt
        ' 
        effectTxt.Location = New Point(148, 101)
        effectTxt.Name = "effectTxt"
        effectTxt.ReadOnly = True
        effectTxt.Size = New Size(115, 23)
        effectTxt.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(100, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 3
        Label2.Text = "Effect:"
        ' 
        ' magnitudeTxt
        ' 
        magnitudeTxt.Location = New Point(146, 60)
        magnitudeTxt.Name = "magnitudeTxt"
        magnitudeTxt.Size = New Size(117, 23)
        magnitudeTxt.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(Label2)
        Controls.Add(effectTxt)
        Controls.Add(magnitudeTxt)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Earthquake"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents effectTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents magnitudeTxt As TextBox

End Class
