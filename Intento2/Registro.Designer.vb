<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.Button1 = New System.Windows.Forms.Button()
        Me._password = New System.Windows.Forms.TextBox()
        Me._username = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me._email = New System.Windows.Forms.TextBox()
        Me._name = New System.Windows.Forms.TextBox()
        Me._surname = New System.Windows.Forms.TextBox()
        Me.signin = New System.Windows.Forms.Label()
        Me.eye = New System.Windows.Forms.PictureBox()
        CType(Me.eye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(123, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 70)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        '_password
        '
        Me._password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._password.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._password.ForeColor = System.Drawing.SystemColors.ControlDark
        Me._password.Location = New System.Drawing.Point(38, 111)
        Me._password.MaxLength = 20
        Me._password.Name = "_password"
        Me._password.Size = New System.Drawing.Size(240, 22)
        Me._password.TabIndex = 2
        Me._password.Text = "Password"
        '
        '_username
        '
        Me._username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._username.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.SystemColors.ControlDark
        Me._username.Location = New System.Drawing.Point(38, 72)
        Me._username.MaxLength = 50
        Me._username.Name = "_username"
        Me._username.Size = New System.Drawing.Size(240, 22)
        Me._username.TabIndex = 1
        Me._username.Text = "Username"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.label1.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(29, 20)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label1.Size = New System.Drawing.Size(259, 34)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Create an account"
        '
        '_email
        '
        Me._email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._email.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._email.ForeColor = System.Drawing.SystemColors.ControlDark
        Me._email.Location = New System.Drawing.Point(38, 150)
        Me._email.MaxLength = 150
        Me._email.Name = "_email"
        Me._email.Size = New System.Drawing.Size(240, 22)
        Me._email.TabIndex = 3
        Me._email.Text = "Email"
        '
        '_name
        '
        Me._name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._name.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._name.ForeColor = System.Drawing.SystemColors.ControlDark
        Me._name.Location = New System.Drawing.Point(38, 189)
        Me._name.MaxLength = 100
        Me._name.Name = "_name"
        Me._name.Size = New System.Drawing.Size(240, 22)
        Me._name.TabIndex = 4
        Me._name.Text = "Name"
        '
        '_surname
        '
        Me._surname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._surname.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._surname.ForeColor = System.Drawing.SystemColors.ControlDark
        Me._surname.Location = New System.Drawing.Point(38, 228)
        Me._surname.MaxLength = 100
        Me._surname.Name = "_surname"
        Me._surname.Size = New System.Drawing.Size(240, 22)
        Me._surname.TabIndex = 5
        Me._surname.Text = "Surname"
        '
        'signin
        '
        Me.signin.AutoSize = True
        Me.signin.BackColor = System.Drawing.Color.Transparent
        Me.signin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.signin.Font = New System.Drawing.Font("Mark", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signin.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.signin.Location = New System.Drawing.Point(44, 444)
        Me.signin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.signin.Name = "signin"
        Me.signin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.signin.Size = New System.Drawing.Size(229, 18)
        Me.signin.TabIndex = 26
        Me.signin.Text = "Already have an account? Sign in"
        '
        'eye
        '
        Me.eye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.eye.Image = Global.Intento2.My.Resources.Resources.view__1_
        Me.eye.Location = New System.Drawing.Point(282, 109)
        Me.eye.Name = "eye"
        Me.eye.Size = New System.Drawing.Size(30, 26)
        Me.eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.eye.TabIndex = 27
        Me.eye.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(317, 475)
        Me.Controls.Add(Me.eye)
        Me.Controls.Add(Me.signin)
        Me.Controls.Add(Me._surname)
        Me.Controls.Add(Me._name)
        Me.Controls.Add(Me._email)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me._password)
        Me.Controls.Add(Me._username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.eye, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents eye As PictureBox
End Class
