<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchMenu))
        Me._username = New System.Windows.Forms.Label()
        Me.userBttn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.searchbar = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.songspanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.albumpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblsong = New System.Windows.Forms.Label()
        Me.lblalbum = New System.Windows.Forms.Label()
        Me.lblartist = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pfp = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.artistpanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.filterBttn = New System.Windows.Forms.Button()
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me._username.TabIndex = 49
        Me._username.Text = "username"
        '
        'userBttn
        '
        Me.userBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.userBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBttn.Location = New System.Drawing.Point(461, 21)
        Me.userBttn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userBttn.Name = "userBttn"
        Me.userBttn.Size = New System.Drawing.Size(160, 41)
        Me.userBttn.TabIndex = 43
        Me.userBttn.Text = "User center"
        Me.userBttn.UseVisualStyleBackColor = False
        Me.userBttn.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1200, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 41)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.searchbar.TabIndex = 45
        Me.searchbar.Text = "Search song, album or artist"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(15, 121)
        Me.lbl.Name = "lbl"
        Me.lbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl.Size = New System.Drawing.Size(307, 41)
        Me.lbl.TabIndex = 51
        Me.lbl.Text = "Search results for:"
        '
        'songspanel
        '
        Me.songspanel.Location = New System.Drawing.Point(0, 218)
        Me.songspanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.songspanel.Name = "songspanel"
        Me.songspanel.Size = New System.Drawing.Size(433, 492)
        Me.songspanel.TabIndex = 52
        '
        'albumpanel
        '
        Me.albumpanel.Location = New System.Drawing.Point(439, 218)
        Me.albumpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.albumpanel.Name = "albumpanel"
        Me.albumpanel.Size = New System.Drawing.Size(433, 492)
        Me.albumpanel.TabIndex = 53
        '
        'lblsong
        '
        Me.lblsong.AutoSize = True
        Me.lblsong.BackColor = System.Drawing.Color.Transparent
        Me.lblsong.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblsong.Font = New System.Drawing.Font("Mark", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lblsong.Location = New System.Drawing.Point(0, 177)
        Me.lblsong.Name = "lblsong"
        Me.lblsong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblsong.Size = New System.Drawing.Size(110, 36)
        Me.lblsong.TabIndex = 54
        Me.lblsong.Text = "Songs:"
        '
        'lblalbum
        '
        Me.lblalbum.AutoSize = True
        Me.lblalbum.BackColor = System.Drawing.Color.Transparent
        Me.lblalbum.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblalbum.Font = New System.Drawing.Font("Mark", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblalbum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lblalbum.Location = New System.Drawing.Point(439, 177)
        Me.lblalbum.Name = "lblalbum"
        Me.lblalbum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblalbum.Size = New System.Drawing.Size(129, 36)
        Me.lblalbum.TabIndex = 55
        Me.lblalbum.Text = "Albums:"
        '
        'lblartist
        '
        Me.lblartist.AutoSize = True
        Me.lblartist.BackColor = System.Drawing.Color.Transparent
        Me.lblartist.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblartist.Font = New System.Drawing.Font("Mark", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblartist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lblartist.Location = New System.Drawing.Point(883, 177)
        Me.lblartist.Name = "lblartist"
        Me.lblartist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblartist.Size = New System.Drawing.Size(122, 36)
        Me.lblartist.TabIndex = 56
        Me.lblartist.Text = "Artists:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label1.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(68, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(268, 82)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "No songs at the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "moment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(24, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 31)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Try searching something else"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(463, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(360, 31)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Try searching something else"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label4.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(493, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(290, 82)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "No albums at the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "moment"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Location = New System.Drawing.Point(904, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(360, 31)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Try searching something else"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label6.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Location = New System.Drawing.Point(939, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(282, 82)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "No artists at the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "moment"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.pfp.TabIndex = 48
        Me.pfp.TabStop = False
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
        Me.logo.TabIndex = 47
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
        Me.banner.TabIndex = 50
        Me.banner.TabStop = False
        '
        'artistpanel
        '
        Me.artistpanel.Location = New System.Drawing.Point(879, 218)
        Me.artistpanel.Margin = New System.Windows.Forms.Padding(4)
        Me.artistpanel.Name = "artistpanel"
        Me.artistpanel.Size = New System.Drawing.Size(433, 490)
        Me.artistpanel.TabIndex = 53
        '
        'filterBttn
        '
        Me.filterBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.filterBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterBttn.Location = New System.Drawing.Point(647, 21)
        Me.filterBttn.Margin = New System.Windows.Forms.Padding(4)
        Me.filterBttn.Name = "filterBttn"
        Me.filterBttn.Size = New System.Drawing.Size(181, 41)
        Me.filterBttn.TabIndex = 44
        Me.filterBttn.Text = "Filter center"
        Me.filterBttn.UseVisualStyleBackColor = False
        Me.filterBttn.Visible = False
        '
        'SearchMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1312, 710)
        Me.Controls.Add(Me.artistpanel)
        Me.Controls.Add(Me.albumpanel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblartist)
        Me.Controls.Add(Me.lblalbum)
        Me.Controls.Add(Me.lblsong)
        Me.Controls.Add(Me.songspanel)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.pfp)
        Me.Controls.Add(Me.userBttn)
        Me.Controls.Add(Me.filterBttn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.searchbar)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "SearchMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _username As Label
    Friend WithEvents pfp As PictureBox
    Friend WithEvents userBttn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents searchbar As TextBox
    Friend WithEvents banner As PictureBox
    Friend WithEvents lbl As Label
    Friend WithEvents songspanel As FlowLayoutPanel
    Friend WithEvents albumpanel As FlowLayoutPanel
    Friend WithEvents lblsong As Label
    Friend WithEvents lblalbum As Label
    Friend WithEvents lblartist As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents artistpanel As FlowLayoutPanel
    Friend WithEvents filterBttn As Button
End Class
