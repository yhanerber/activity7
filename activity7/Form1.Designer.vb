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
        txtbox1 = New TextBox()
        TextBox2 = New TextBox()
        lbl1 = New Label()
        txtbox2 = New Label()
        Button1 = New Button()
        LinkLabel1 = New LinkLabel()
        LinkLabel2 = New LinkLabel()
        SuspendLayout()
        ' 
        ' txtbox1
        ' 
        txtbox1.Location = New Point(46, 76)
        txtbox1.Name = "txtbox1"
        txtbox1.Size = New Size(125, 27)
        txtbox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(46, 163)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 1
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Location = New Point(70, 43)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(75, 20)
        lbl1.TabIndex = 2
        lbl1.Text = "Username"
        ' 
        ' txtbox2
        ' 
        txtbox2.AutoSize = True
        txtbox2.Location = New Point(70, 129)
        txtbox2.Name = "txtbox2"
        txtbox2.Size = New Size(70, 20)
        txtbox2.TabIndex = 3
        txtbox2.Text = "Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(61, 210)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(61, 274)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(95, 20)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Register now"
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.Location = New Point(46, 314)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(120, 20)
        LinkLabel2.TabIndex = 6
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Forgot password"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel2)
        Controls.Add(LinkLabel1)
        Controls.Add(Button1)
        Controls.Add(txtbox2)
        Controls.Add(lbl1)
        Controls.Add(TextBox2)
        Controls.Add(txtbox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtbox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtbox2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel

End Class
