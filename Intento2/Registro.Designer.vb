<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.Button1 = New System.Windows.Forms.Button()
        Me._password = New System.Windows.Forms.TextBox()
        Me._username = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me._email = New System.Windows.Forms.TextBox()
        Me._name = New System.Windows.Forms.TextBox()
        Me._surname = New System.Windows.Forms.TextBox()
        Me.signin = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(165, 437)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 86)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        '_password
        '
        Me._password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._password.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._password.Location = New System.Drawing.Point(80, 137)
        Me._password.Margin = New System.Windows.Forms.Padding(4)
        Me._password.MaxLength = 20
        Me._password.Name = "_password"
        Me._password.Size = New System.Drawing.Size(263, 28)
        Me._password.TabIndex = 20
        Me._password.Text = "Password"
        '
        '_username
        '
        Me._username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._username.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._username.Location = New System.Drawing.Point(80, 89)
        Me._username.Margin = New System.Windows.Forms.Padding(4)
        Me._username.MaxLength = 50
        Me._username.Name = "_username"
        Me._username.Size = New System.Drawing.Size(263, 28)
        Me._username.TabIndex = 19
        Me._username.Text = "Username"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.label1.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(50, 24)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label1.Size = New System.Drawing.Size(323, 43)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Create an account"
        '
        '_email
        '
        Me._email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._email.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._email.Location = New System.Drawing.Point(80, 185)
        Me._email.Margin = New System.Windows.Forms.Padding(4)
        Me._email.MaxLength = 20
        Me._email.Name = "_email"
        Me._email.Size = New System.Drawing.Size(263, 28)
        Me._email.TabIndex = 23
        Me._email.Text = "Email"
        '
        '_name
        '
        Me._name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._name.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._name.Location = New System.Drawing.Point(80, 235)
        Me._name.Margin = New System.Windows.Forms.Padding(4)
        Me._name.MaxLength = 20
        Me._name.Name = "_name"
        Me._name.Size = New System.Drawing.Size(263, 28)
        Me._name.TabIndex = 24
        Me._name.Text = "Name"
        '
        '_surname
        '
        Me._surname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._surname.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._surname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._surname.Location = New System.Drawing.Point(80, 284)
        Me._surname.Margin = New System.Windows.Forms.Padding(4)
        Me._surname.MaxLength = 20
        Me._surname.Name = "_surname"
        Me._surname.Size = New System.Drawing.Size(263, 28)
        Me._surname.TabIndex = 25
        Me._surname.Text = "Surname"
        '
        'signin
        '
        Me.signin.AutoSize = True
        Me.signin.BackColor = System.Drawing.Color.Transparent
        Me.signin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signin.Font = New System.Drawing.Font("Mark", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signin.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.signin.Location = New System.Drawing.Point(73, 547)
        Me.signin.Name = "signin"
        Me.signin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.signin.Size = New System.Drawing.Size(277, 21)
        Me.signin.TabIndex = 26
        Me.signin.Text = "Already have an account? Sign in"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(423, 585)
        Me.Controls.Add(Me.signin)
        Me.Controls.Add(Me._surname)
        Me.Controls.Add(Me._name)
        Me.Controls.Add(Me._email)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me._password)
        Me.Controls.Add(Me._username)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro"
        Me.Text = "Musicboxd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents _password As TextBox
    Friend WithEvents _username As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents _email As TextBox
    Friend WithEvents _name As TextBox
    Friend WithEvents _surname As TextBox
    Friend WithEvents signin As Label
End Class
