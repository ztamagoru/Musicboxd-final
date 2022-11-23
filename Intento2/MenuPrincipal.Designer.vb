<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.searchbar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.filterBttn = New System.Windows.Forms.Button()
        Me.userBttn = New System.Windows.Forms.Button()
        Me.songName1 = New System.Windows.Forms.Label()
        Me.artistName1 = New System.Windows.Forms.Label()
        Me.artistName2 = New System.Windows.Forms.Label()
        Me.songName2 = New System.Windows.Forms.Label()
        Me.artistName4 = New System.Windows.Forms.Label()
        Me.songName4 = New System.Windows.Forms.Label()
        Me.artistName3 = New System.Windows.Forms.Label()
        Me.songName3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me._username = New System.Windows.Forms.Label()
        Me.pfp = New System.Windows.Forms.PictureBox()
        Me.cover4 = New System.Windows.Forms.PictureBox()
        Me.cover3 = New System.Windows.Forms.PictureBox()
        Me.cover2 = New System.Windows.Forms.PictureBox()
        Me.cover1 = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cover4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cover3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cover2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cover1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchbar
        '
        Me.searchbar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchbar.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.searchbar.Location = New System.Drawing.Point(851, 27)
        Me.searchbar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.searchbar.MaxLength = 100
        Me.searchbar.Name = "searchbar"
        Me.searchbar.Size = New System.Drawing.Size(327, 28)
        Me.searchbar.TabIndex = 3
        Me.searchbar.Text = "Search song, album or artist"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1200, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'filterBttn
        '
        Me.filterBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.filterBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterBttn.Location = New System.Drawing.Point(641, 21)
        Me.filterBttn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.filterBttn.Name = "filterBttn"
        Me.filterBttn.Size = New System.Drawing.Size(187, 41)
        Me.filterBttn.TabIndex = 1
        Me.filterBttn.Text = "Filter center"
        Me.filterBttn.UseVisualStyleBackColor = False
        Me.filterBttn.Visible = False
        '
        'userBttn
        '
        Me.userBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.userBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBttn.Location = New System.Drawing.Point(463, 21)
        Me.userBttn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userBttn.Name = "userBttn"
        Me.userBttn.Size = New System.Drawing.Size(160, 41)
        Me.userBttn.TabIndex = 17
        Me.userBttn.Text = "User center"
        Me.userBttn.UseVisualStyleBackColor = False
        Me.userBttn.Visible = False
        '
        'songName1
        '
        Me.songName1.AutoSize = True
        Me.songName1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.songName1.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songName1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.songName1.Location = New System.Drawing.Point(271, 226)
        Me.songName1.Name = "songName1"
        Me.songName1.Size = New System.Drawing.Size(160, 31)
        Me.songName1.TabIndex = 20
        Me.songName1.Text = "songName1"
        '
        'artistName1
        '
        Me.artistName1.AutoSize = True
        Me.artistName1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.artistName1.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.artistName1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.artistName1.Location = New System.Drawing.Point(271, 270)
        Me.artistName1.Name = "artistName1"
        Me.artistName1.Size = New System.Drawing.Size(135, 25)
        Me.artistName1.TabIndex = 21
        Me.artistName1.Text = "artistName1"
        '
        'artistName2
        '
        Me.artistName2.AutoSize = True
        Me.artistName2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.artistName2.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.artistName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.artistName2.Location = New System.Drawing.Point(865, 270)
        Me.artistName2.Name = "artistName2"
        Me.artistName2.Size = New System.Drawing.Size(135, 25)
        Me.artistName2.TabIndex = 24
        Me.artistName2.Text = "artistName2"
        '
        'songName2
        '
        Me.songName2.AutoSize = True
        Me.songName2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.songName2.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songName2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.songName2.Location = New System.Drawing.Point(865, 226)
        Me.songName2.Name = "songName2"
        Me.songName2.Size = New System.Drawing.Size(160, 31)
        Me.songName2.TabIndex = 23
        Me.songName2.Text = "songName2"
        '
        'artistName4
        '
        Me.artistName4.AutoSize = True
        Me.artistName4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.artistName4.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.artistName4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.artistName4.Location = New System.Drawing.Point(865, 529)
        Me.artistName4.Name = "artistName4"
        Me.artistName4.Size = New System.Drawing.Size(135, 25)
        Me.artistName4.TabIndex = 30
        Me.artistName4.Text = "artistName4"
        '
        'songName4
        '
        Me.songName4.AutoSize = True
        Me.songName4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.songName4.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songName4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.songName4.Location = New System.Drawing.Point(865, 487)
        Me.songName4.Name = "songName4"
        Me.songName4.Size = New System.Drawing.Size(160, 31)
        Me.songName4.TabIndex = 29
        Me.songName4.Text = "songName4"
        '
        'artistName3
        '
        Me.artistName3.AutoSize = True
        Me.artistName3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.artistName3.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.artistName3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.artistName3.Location = New System.Drawing.Point(271, 529)
        Me.artistName3.Name = "artistName3"
        Me.artistName3.Size = New System.Drawing.Size(135, 25)
        Me.artistName3.TabIndex = 27
        Me.artistName3.Text = "artistName3"
        '
        'songName3
        '
        Me.songName3.AutoSize = True
        Me.songName3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.songName3.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songName3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.songName3.Location = New System.Drawing.Point(271, 487)
        Me.songName3.Name = "songName3"
        Me.songName3.Size = New System.Drawing.Size(160, 31)
        Me.songName3.TabIndex = 26
        Me.songName3.Text = "songName3"
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
        Me.label1.Size = New System.Drawing.Size(498, 41)
        Me.label1.TabIndex = 32
        Me.label1.Text = "Our recomendations for today"
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
        Me._username.TabIndex = 33
        Me._username.Text = "username"
        '
        'pfp
        '
        Me.pfp.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pfp.Image = Global.Intento2.My.Resources.Resources.image
        Me.pfp.Location = New System.Drawing.Point(123, 11)
        Me.pfp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pfp.Name = "pfp"
        Me.pfp.Size = New System.Drawing.Size(60, 60)
        Me.pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pfp.TabIndex = 31
        Me.pfp.TabStop = False
        '
        'cover4
        '
        Me.cover4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cover4.Image = Global.Intento2.My.Resources.Resources.not_found
        Me.cover4.Location = New System.Drawing.Point(656, 462)
        Me.cover4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cover4.Name = "cover4"
        Me.cover4.Size = New System.Drawing.Size(200, 185)
        Me.cover4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover4.TabIndex = 28
        Me.cover4.TabStop = False
        '
        'cover3
        '
        Me.cover3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cover3.Image = Global.Intento2.My.Resources.Resources.not_found
        Me.cover3.Location = New System.Drawing.Point(60, 462)
        Me.cover3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cover3.Name = "cover3"
        Me.cover3.Size = New System.Drawing.Size(200, 185)
        Me.cover3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover3.TabIndex = 25
        Me.cover3.TabStop = False
        '
        'cover2
        '
        Me.cover2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cover2.Image = Global.Intento2.My.Resources.Resources.not_found
        Me.cover2.Location = New System.Drawing.Point(656, 201)
        Me.cover2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cover2.Name = "cover2"
        Me.cover2.Size = New System.Drawing.Size(200, 185)
        Me.cover2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover2.TabIndex = 22
        Me.cover2.TabStop = False
        '
        'cover1
        '
        Me.cover1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cover1.Image = Global.Intento2.My.Resources.Resources.not_found
        Me.cover1.Location = New System.Drawing.Point(60, 201)
        Me.cover1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cover1.Name = "cover1"
        Me.cover1.Size = New System.Drawing.Size(200, 185)
        Me.cover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover1.TabIndex = 18
        Me.cover1.TabStop = False
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo.Image = Global.Intento2.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(9, 6)
        Me.logo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(107, 70)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 16
        Me.logo.TabStop = False
        '
        'banner
        '
        Me.banner.Image = CType(resources.GetObject("banner.Image"), System.Drawing.Image)
        Me.banner.Location = New System.Drawing.Point(0, 0)
        Me.banner.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(1315, 105)
        Me.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.banner.TabIndex = 34
        Me.banner.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(33, 182)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(600, 239)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Location = New System.Drawing.Point(33, 428)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(600, 239)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Location = New System.Drawing.Point(641, 182)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(625, 239)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 37
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Location = New System.Drawing.Point(641, 428)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(625, 239)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1312, 710)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.pfp)
        Me.Controls.Add(Me.artistName4)
        Me.Controls.Add(Me.songName4)
        Me.Controls.Add(Me.cover4)
        Me.Controls.Add(Me.artistName3)
        Me.Controls.Add(Me.songName3)
        Me.Controls.Add(Me.cover3)
        Me.Controls.Add(Me.artistName2)
        Me.Controls.Add(Me.songName2)
        Me.Controls.Add(Me.cover2)
        Me.Controls.Add(Me.artistName1)
        Me.Controls.Add(Me.songName1)
        Me.Controls.Add(Me.cover1)
        Me.Controls.Add(Me.userBttn)
        Me.Controls.Add(Me.filterBttn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.searchbar)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cover4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cover3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cover2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cover1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchbar As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents filterBttn As Button
    Friend WithEvents userBttn As Button
    Friend WithEvents cover1 As PictureBox
    Friend WithEvents songName1 As Label
    Friend WithEvents artistName1 As Label
    Friend WithEvents artistName2 As Label
    Friend WithEvents songName2 As Label
    Friend WithEvents cover2 As PictureBox
    Friend WithEvents artistName4 As Label
    Friend WithEvents songName4 As Label
    Friend WithEvents cover4 As PictureBox
    Friend WithEvents artistName3 As Label
    Friend WithEvents songName3 As Label
    Friend WithEvents cover3 As PictureBox
    Friend WithEvents pfp As PictureBox
    Friend WithEvents label1 As Label
    Friend WithEvents _username As Label
    Friend WithEvents banner As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
