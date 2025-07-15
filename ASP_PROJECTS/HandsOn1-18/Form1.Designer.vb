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
        pesoTxt = New TextBox()
        dollarResult = New TextBox()
        Label2 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(76, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 0
        Label1.Text = "Peso:"
        ' 
        ' pesoTxt
        ' 
        pesoTxt.Location = New Point(117, 61)
        pesoTxt.Name = "pesoTxt"
        pesoTxt.Size = New Size(117, 23)
        pesoTxt.TabIndex = 1
        ' 
        ' dollarResult
        ' 
        dollarResult.Location = New Point(119, 102)
        dollarResult.Name = "dollarResult"
        dollarResult.ReadOnly = True
        dollarResult.Size = New Size(115, 23)
        dollarResult.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(70, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 3
        Label2.Text = "Dollar:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(119, 138)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 23)
        Button1.TabIndex = 4
        Button1.Text = "Convert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(dollarResult)
        Controls.Add(pesoTxt)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Peso to Dollar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pesoTxt As TextBox
    Friend WithEvents dollarResult As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button

End Class
