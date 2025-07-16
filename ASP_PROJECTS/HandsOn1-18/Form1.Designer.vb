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
        fullNameTxt = New TextBox()
        CourseTxt = New TextBox()
        SetTxt = New TextBox()
        IdNumberTxt = New TextBox()
        StudentTable = New DataGridView()
        Addbtn = New Button()
        EditBtn = New Button()
        DeleteBtn = New Button()
        ClearBtn = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Id = New TextBox()
        Label5 = New Label()
        CType(StudentTable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' fullNameTxt
        ' 
        fullNameTxt.Location = New Point(175, 57)
        fullNameTxt.Name = "fullNameTxt"
        fullNameTxt.Size = New Size(127, 23)
        fullNameTxt.TabIndex = 0
        ' 
        ' CourseTxt
        ' 
        CourseTxt.Location = New Point(341, 57)
        CourseTxt.Name = "CourseTxt"
        CourseTxt.Size = New Size(122, 23)
        CourseTxt.TabIndex = 1
        ' 
        ' SetTxt
        ' 
        SetTxt.Location = New Point(175, 114)
        SetTxt.Name = "SetTxt"
        SetTxt.Size = New Size(127, 23)
        SetTxt.TabIndex = 2
        ' 
        ' IdNumberTxt
        ' 
        IdNumberTxt.Location = New Point(341, 114)
        IdNumberTxt.Name = "IdNumberTxt"
        IdNumberTxt.Size = New Size(122, 23)
        IdNumberTxt.TabIndex = 3
        ' 
        ' StudentTable
        ' 
        StudentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentTable.Location = New Point(29, 265)
        StudentTable.Name = "StudentTable"
        StudentTable.Size = New Size(572, 218)
        StudentTable.TabIndex = 4
        ' 
        ' Addbtn
        ' 
        Addbtn.Location = New Point(175, 163)
        Addbtn.Name = "Addbtn"
        Addbtn.Size = New Size(127, 23)
        Addbtn.TabIndex = 5
        Addbtn.Text = "Add"
        Addbtn.UseVisualStyleBackColor = True
        ' 
        ' EditBtn
        ' 
        EditBtn.Location = New Point(341, 163)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(119, 23)
        EditBtn.TabIndex = 6
        EditBtn.Text = "Update"
        EditBtn.UseVisualStyleBackColor = True
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.Location = New Point(175, 210)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(127, 23)
        DeleteBtn.TabIndex = 7
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Location = New Point(341, 210)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(121, 23)
        ClearBtn.TabIndex = 8
        ClearBtn.Text = "Clear"
        ClearBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(175, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 9
        Label1.Text = "Fullname:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(341, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 10
        Label2.Text = "Course:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(175, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(26, 15)
        Label3.TabIndex = 11
        Label3.Text = "Set:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(341, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 12
        Label4.Text = "ID Number:"
        ' 
        ' Id
        ' 
        Id.Location = New Point(29, 236)
        Id.Name = "Id"
        Id.ReadOnly = True
        Id.Size = New Size(100, 23)
        Id.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(21, 15)
        Label5.TabIndex = 14
        Label5.Text = "ID:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(657, 541)
        Controls.Add(Label5)
        Controls.Add(Id)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ClearBtn)
        Controls.Add(DeleteBtn)
        Controls.Add(EditBtn)
        Controls.Add(Addbtn)
        Controls.Add(StudentTable)
        Controls.Add(IdNumberTxt)
        Controls.Add(SetTxt)
        Controls.Add(CourseTxt)
        Controls.Add(fullNameTxt)
        Name = "Form1"
        Text = "CRUD"
        CType(StudentTable, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents fullNameTxt As TextBox
    Friend WithEvents CourseTxt As TextBox
    Friend WithEvents SetTxt As TextBox
    Friend WithEvents IdNumberTxt As TextBox
    Friend WithEvents StudentTable As DataGridView
    Friend WithEvents Addbtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Id As TextBox
    Friend WithEvents Label5 As Label

End Class
