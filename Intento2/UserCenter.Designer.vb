<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserCenter))
        Me.dgUsers = New System.Windows.Forms.DataGridView()
        Me._username = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.userBttn = New System.Windows.Forms.Button()
        Me.filterBttn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.searchbar = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.role = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.Button()
        Me.pfp = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgUsers
        '
        Me.dgUsers.AllowUserToAddRows = False
        Me.dgUsers.AllowUserToDeleteRows = False
        Me.dgUsers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.dgUsers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsers.Location = New System.Drawing.Point(560, 225)
        Me.dgUsers.Margin = New System.Windows.Forms.Padding(4)
        Me.dgUsers.Name = "dgUsers"
        Me.dgUsers.ReadOnly = True
        Me.dgUsers.RowHeadersWidth = 51
        Me.dgUsers.Size = New System.Drawing.Size(687, 426)
        Me.dgUsers.TabIndex = 0
        '
        '_username
        '
        Me._username.AutoSize = True
        Me._username.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me._username.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._username.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._username.Location = New System.Drawing.Point(188, 27)
        Me._username.Name = "_username"
        Me._username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._username.Size = New System.Drawing.Size(116, 28)
        Me._username.TabIndex = 36
        Me._username.Text = "username"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.label1.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(39, 124)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label1.Size = New System.Drawing.Size(201, 41)
        Me.label1.TabIndex = 37
        Me.label1.Text = "User center"
        '
        'userBttn
        '
        Me.userBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.userBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBttn.Location = New System.Drawing.Point(469, 21)
        Me.userBttn.Margin = New System.Windows.Forms.Padding(4)
        Me.userBttn.Name = "userBttn"
        Me.userBttn.Size = New System.Drawing.Size(160, 41)
        Me.userBttn.TabIndex = 42
        Me.userBttn.Text = "User center"
        Me.userBttn.UseVisualStyleBackColor = False
        Me.userBttn.Visible = False
        '
        'filterBttn
        '
        Me.filterBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.filterBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterBttn.Location = New System.Drawing.Point(649, 21)
        Me.filterBttn.Margin = New System.Windows.Forms.Padding(4)
        Me.filterBttn.Name = "filterBttn"
        Me.filterBttn.Size = New System.Drawing.Size(179, 41)
        Me.filterBttn.TabIndex = 39
        Me.filterBttn.Text = "Filter center"
        Me.filterBttn.UseVisualStyleBackColor = False
        Me.filterBttn.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1200, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 41)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'searchbar
        '
        Me.searchbar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchbar.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.searchbar.Location = New System.Drawing.Point(851, 27)
        Me.searchbar.Margin = New System.Windows.Forms.Padding(4)
        Me.searchbar.MaxLength = 100
        Me.searchbar.Name = "searchbar"
        Me.searchbar.Size = New System.Drawing.Size(327, 28)
        Me.searchbar.TabIndex = 40
        Me.searchbar.Text = "Search song, album or artist"
        '
        'txtusername
        '
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Enabled = False
        Me.txtusername.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtusername.Location = New System.Drawing.Point(47, 249)
        Me.txtusername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtusername.MaxLength = 100
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(440, 28)
        Me.txtusername.TabIndex = 44
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Enabled = False
        Me.txtemail.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtemail.Location = New System.Drawing.Point(47, 316)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtemail.MaxLength = 100
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(440, 28)
        Me.txtemail.TabIndex = 45
        '
        'txtname
        '
        Me.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtname.Enabled = False
        Me.txtname.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtname.Location = New System.Drawing.Point(47, 384)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.MaxLength = 100
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(440, 28)
        Me.txtname.TabIndex = 46
        '
        'role
        '
        Me.role.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.role.Cursor = System.Windows.Forms.Cursors.Default
        Me.role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.role.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.role.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.role.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.role.FormattingEnabled = True
        Me.role.Items.AddRange(New Object() {"Owner", "Administrador", "Usuario"})
        Me.role.Location = New System.Drawing.Point(111, 505)
        Me.role.Margin = New System.Windows.Forms.Padding(4)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(235, 32)
        Me.role.TabIndex = 47
        Me.role.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(41, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(41, 288)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(41, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(75, 25)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label5.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(41, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(105, 25)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Surname:"
        '
        'txtsurname
        '
        Me.txtsurname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsurname.Enabled = False
        Me.txtsurname.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsurname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.txtsurname.Location = New System.Drawing.Point(47, 455)
        Me.txtsurname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsurname.MaxLength = 100
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(440, 28)
        Me.txtsurname.TabIndex = 75
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label6.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(41, 507)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(60, 25)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Role:"
        '
        'change
        '
        Me.change.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.change.Enabled = False
        Me.change.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(147, 596)
        Me.change.Margin = New System.Windows.Forms.Padding(4)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(241, 41)
        Me.change.TabIndex = 77
        Me.change.Text = "Make changes"
        Me.change.UseVisualStyleBackColor = False
        '
        'pfp
        '
        Me.pfp.Image = Global.Intento2.My.Resources.Resources.image
        Me.pfp.Location = New System.Drawing.Point(123, 11)
        Me.pfp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pfp.Name = "pfp"
        Me.pfp.Size = New System.Drawing.Size(60, 60)
        Me.pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pfp.TabIndex = 35
        Me.pfp.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Intento2.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(9, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'banner
        '
        Me.banner.Image = CType(resources.GetObject("banner.Image"), System.Drawing.Image)
        Me.banner.Location = New System.Drawing.Point(0, 0)
        Me.banner.Margin = New System.Windows.Forms.Padding(4)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(1315, 105)
        Me.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.banner.TabIndex = 38
        Me.banner.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Intento2.My.Resources.Resources.Untitled_3
        Me.PictureBox2.Location = New System.Drawing.Point(536, 203)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(735, 470)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'UserCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1312, 710)
        Me.Controls.Add(Me.change)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtsurname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.role)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.userBttn)
        Me.Controls.Add(Me.filterBttn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.searchbar)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.pfp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgUsers)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "UserCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.dgUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgUsers As DataGridView
    Friend WithEvents _username As Label
    Friend WithEvents pfp As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents label1 As Label
    Friend WithEvents banner As PictureBox
    Friend WithEvents userBttn As Button
    Friend WithEvents filterBttn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents searchbar As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents role As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsurname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents change As Button
End Class
