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
        secondNumberTxt = New TextBox()
        Label2 = New Label()
        plusBtn = New Button()
        firstNumTxt = New TextBox()
        minusBtn = New Button()
        multiplyBtn = New Button()
        divideBtn = New Button()
        resultTxt = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Number:"
        ' 
        ' secondNumberTxt
        ' 
        secondNumberTxt.Location = New Point(148, 101)
        secondNumberTxt.Name = "secondNumberTxt"
        secondNumberTxt.Size = New Size(115, 23)
        secondNumberTxt.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 3
        Label2.Text = "Second Number:"
        ' 
        ' plusBtn
        ' 
        plusBtn.Location = New Point(148, 137)
        plusBtn.Name = "plusBtn"
        plusBtn.Size = New Size(55, 23)
        plusBtn.TabIndex = 4
        plusBtn.Text = "+"
        plusBtn.UseVisualStyleBackColor = True
        ' 
        ' firstNumTxt
        ' 
        firstNumTxt.Location = New Point(146, 60)
        firstNumTxt.Name = "firstNumTxt"
        firstNumTxt.Size = New Size(117, 23)
        firstNumTxt.TabIndex = 1
        ' 
        ' minusBtn
        ' 
        minusBtn.Location = New Point(208, 137)
        minusBtn.Name = "minusBtn"
        minusBtn.Size = New Size(55, 23)
        minusBtn.TabIndex = 5
        minusBtn.Text = "-"
        minusBtn.UseVisualStyleBackColor = True
        ' 
        ' multiplyBtn
        ' 
        multiplyBtn.Location = New Point(148, 166)
        multiplyBtn.Name = "multiplyBtn"
        multiplyBtn.Size = New Size(55, 23)
        multiplyBtn.TabIndex = 6
        multiplyBtn.Text = "*"
        multiplyBtn.UseVisualStyleBackColor = True
        ' 
        ' divideBtn
        ' 
        divideBtn.Location = New Point(209, 166)
        divideBtn.Name = "divideBtn"
        divideBtn.Size = New Size(55, 23)
        divideBtn.TabIndex = 7
        divideBtn.Text = "/"
        divideBtn.UseVisualStyleBackColor = True
        ' 
        ' resultTxt
        ' 
        resultTxt.Location = New Point(146, 195)
        resultTxt.Name = "resultTxt"
        resultTxt.ReadOnly = True
        resultTxt.Size = New Size(115, 23)
        resultTxt.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(347, 246)
        Controls.Add(resultTxt)
        Controls.Add(divideBtn)
        Controls.Add(multiplyBtn)
        Controls.Add(minusBtn)
        Controls.Add(plusBtn)
        Controls.Add(Label2)
        Controls.Add(secondNumberTxt)
        Controls.Add(firstNumTxt)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents secondNumberTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents plusBtn As Button
    Friend WithEvents firstNumTxt As TextBox
    Friend WithEvents minusBtn As Button
    Friend WithEvents multiplyBtn As Button
    Friend WithEvents divideBtn As Button
    Friend WithEvents resultTxt As TextBox

End Class
