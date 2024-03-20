<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtbox2 = New TextBox()
        txtbox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        DateTimePicker1 = New DateTimePicker()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        txtbox3 = New TextBox()
        txtbox4 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtbox2
        ' 
        txtbox2.Location = New Point(28, 169)
        txtbox2.Name = "txtbox2"
        txtbox2.Size = New Size(163, 27)
        txtbox2.TabIndex = 0
        ' 
        ' txtbox1
        ' 
        txtbox1.Location = New Point(28, 82)
        txtbox1.Name = "txtbox1"
        txtbox1.Size = New Size(163, 27)
        txtbox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(58, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 2
        Label1.Text = "First Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 3
        Label2.Text = "Middle Name"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(80, 332)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(40, 20)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Back"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(273, 389)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(120, 20)
        LinkLabel2.TabIndex = 5
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forgot password"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(294, 80)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(244, 27)
        DateTimePicker1.TabIndex = 6
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(294, 260)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(64, 24)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Male"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(428, 259)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(79, 24)
        CheckBox2.TabIndex = 8
        CheckBox2.Text = "Female"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' txtbox3
        ' 
        txtbox3.Location = New Point(365, 173)
        txtbox3.Name = "txtbox3"
        txtbox3.Size = New Size(110, 27)
        txtbox3.TabIndex = 9
        ' 
        ' txtbox4
        ' 
        txtbox4.Location = New Point(28, 257)
        txtbox4.Name = "txtbox4"
        txtbox4.Size = New Size(163, 27)
        txtbox4.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(66, 234)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 11
        Label3.Text = "Surname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(323, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 20)
        Label4.TabIndex = 12
        Label4.Text = "Age"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(285, 332)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 13
        Button1.Text = "Sign in"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtbox4)
        Controls.Add(txtbox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(DateTimePicker1)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtbox1)
        Controls.Add(txtbox2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents txtbox3 As TextBox
    Friend WithEvents txtbox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
End Class
