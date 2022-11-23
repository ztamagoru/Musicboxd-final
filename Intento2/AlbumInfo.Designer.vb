<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlbumInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlbumInfo))
        Me._username = New System.Windows.Forms.Label()
        Me.pfp = New System.Windows.Forms.PictureBox()
        Me.userBttn = New System.Windows.Forms.Button()
        Me.filterBttn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.searchbar = New System.Windows.Forms.TextBox()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.lbl_album = New System.Windows.Forms.Label()
        Me.lbl_artist = New System.Windows.Forms.Label()
        Me.cover = New System.Windows.Forms.PictureBox()
        Me.lbl_songslist1 = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_songslist2 = New System.Windows.Forms.Label()
        Me.deezerLink = New System.Windows.Forms.LinkLabel()
        Me.itunesLink = New System.Windows.Forms.LinkLabel()
        Me.spotifyLink = New System.Windows.Forms.LinkLabel()
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_username
        '
        Me._username.AutoSize = True
        Me._username.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me._username.Cursor = System.Windows.Forms.Cursors.Arrow
        Me._username.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._username.Location = New System.Drawing.Point(141, 22)
        Me._username.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me._username.Name = "_username"
        Me._username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._username.Size = New System.Drawing.Size(97, 23)
        Me._username.TabIndex = 57
        Me._username.Text = "username"
        '
        'pfp
        '
        Me.pfp.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pfp.Image = Global.Intento2.My.Resources.Resources.image
        Me.pfp.Location = New System.Drawing.Point(92, 9)
        Me.pfp.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pfp.Name = "pfp"
        Me.pfp.Size = New System.Drawing.Size(45, 49)
        Me.pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pfp.TabIndex = 56
        Me.pfp.TabStop = False
        '
        'userBttn
        '
        Me.userBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.userBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBttn.Location = New System.Drawing.Point(356, 17)
        Me.userBttn.Name = "userBttn"
        Me.userBttn.Size = New System.Drawing.Size(120, 33)
        Me.userBttn.TabIndex = 51
        Me.userBttn.Text = "User center"
        Me.userBttn.UseVisualStyleBackColor = False
        Me.userBttn.Visible = False
        '
        'filterBttn
        '
        Me.filterBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.filterBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterBttn.Location = New System.Drawing.Point(493, 17)
        Me.filterBttn.Name = "filterBttn"
        Me.filterBttn.Size = New System.Drawing.Size(128, 33)
        Me.filterBttn.TabIndex = 52
        Me.filterBttn.Text = "Filter center"
        Me.filterBttn.UseVisualStyleBackColor = False
        Me.filterBttn.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(900, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 33)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.logo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logo.Image = Global.Intento2.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(7, 5)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(80, 57)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 55
        Me.logo.TabStop = False
        '
        'searchbar
        '
        Me.searchbar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.searchbar.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbar.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.searchbar.Location = New System.Drawing.Point(638, 22)
        Me.searchbar.MaxLength = 100
        Me.searchbar.Name = "searchbar"
        Me.searchbar.Size = New System.Drawing.Size(245, 22)
        Me.searchbar.TabIndex = 53
        Me.searchbar.Text = "Search song, album or artist"
        '
        'banner
        '
        Me.banner.Image = CType(resources.GetObject("banner.Image"), System.Drawing.Image)
        Me.banner.Location = New System.Drawing.Point(0, 0)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(986, 85)
        Me.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.banner.TabIndex = 58
        Me.banner.TabStop = False
        '
        'lbl_album
        '
        Me.lbl_album.AutoSize = True
        Me.lbl_album.BackColor = System.Drawing.Color.Transparent
        Me.lbl_album.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_album.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_album.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_album.Location = New System.Drawing.Point(31, 107)
        Me.lbl_album.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_album.Name = "lbl_album"
        Me.lbl_album.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_album.Size = New System.Drawing.Size(170, 34)
        Me.lbl_album.TabIndex = 59
        Me.lbl_album.Text = "albumname"
        '
        'lbl_artist
        '
        Me.lbl_artist.AutoSize = True
        Me.lbl_artist.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_artist.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_artist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_artist.Location = New System.Drawing.Point(32, 148)
        Me.lbl_artist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_artist.Name = "lbl_artist"
        Me.lbl_artist.Size = New System.Drawing.Size(119, 25)
        Me.lbl_artist.TabIndex = 60
        Me.lbl_artist.Text = "artistname"
        '
        'cover
        '
        Me.cover.Cursor = System.Windows.Forms.Cursors.Default
        Me.cover.Image = Global.Intento2.My.Resources.Resources.not_found
        Me.cover.Location = New System.Drawing.Point(704, 104)
        Me.cover.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(250, 250)
        Me.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover.TabIndex = 61
        Me.cover.TabStop = False
        '
        'lbl_songslist1
        '
        Me.lbl_songslist1.AutoSize = True
        Me.lbl_songslist1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_songslist1.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_songslist1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_songslist1.Location = New System.Drawing.Point(33, 334)
        Me.lbl_songslist1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_songslist1.Name = "lbl_songslist1"
        Me.lbl_songslist1.Size = New System.Drawing.Size(88, 20)
        Me.lbl_songslist1.TabIndex = 66
        Me.lbl_songslist1.Text = "songslist1"
        '
        'lbl_description
        '
        Me.lbl_description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_description.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_description.Location = New System.Drawing.Point(32, 185)
        Me.lbl_description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_description.MaximumSize = New System.Drawing.Size(640, 0)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(636, 75)
        Me.lbl_description.TabIndex = 67
        Me.lbl_description.Text = "review aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        '
        'lbl_songslist2
        '
        Me.lbl_songslist2.AutoSize = True
        Me.lbl_songslist2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_songslist2.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_songslist2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_songslist2.Location = New System.Drawing.Point(344, 334)
        Me.lbl_songslist2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_songslist2.Name = "lbl_songslist2"
        Me.lbl_songslist2.Size = New System.Drawing.Size(88, 20)
        Me.lbl_songslist2.TabIndex = 68
        Me.lbl_songslist2.Text = "songslist2"
        '
        'deezerLink
        '
        Me.deezerLink.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.deezerLink.AutoSize = True
        Me.deezerLink.Font = New System.Drawing.Font("Mark", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deezerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.deezerLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.deezerLink.Location = New System.Drawing.Point(805, 440)
        Me.deezerLink.Name = "deezerLink"
        Me.deezerLink.Size = New System.Drawing.Size(149, 23)
        Me.deezerLink.TabIndex = 77
        Me.deezerLink.TabStop = True
        Me.deezerLink.Text = "Listen in Deezer"
        Me.deezerLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(118, Byte), Integer))
        '
        'itunesLink
        '
        Me.itunesLink.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.itunesLink.AutoSize = True
        Me.itunesLink.Font = New System.Drawing.Font("Mark", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itunesLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.itunesLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.itunesLink.Location = New System.Drawing.Point(810, 404)
        Me.itunesLink.Name = "itunesLink"
        Me.itunesLink.Size = New System.Drawing.Size(144, 23)
        Me.itunesLink.TabIndex = 76
        Me.itunesLink.TabStop = True
        Me.itunesLink.Text = "Listen in iTunes"
        Me.itunesLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(118, Byte), Integer))
        '
        'spotifyLink
        '
        Me.spotifyLink.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.spotifyLink.AutoSize = True
        Me.spotifyLink.Font = New System.Drawing.Font("Mark", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spotifyLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.spotifyLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.spotifyLink.Location = New System.Drawing.Point(801, 368)
        Me.spotifyLink.Name = "spotifyLink"
        Me.spotifyLink.Size = New System.Drawing.Size(153, 23)
        Me.spotifyLink.TabIndex = 75
        Me.spotifyLink.TabStop = True
        Me.spotifyLink.Text = "Listen in Spotify"
        Me.spotifyLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(118, Byte), Integer))
        '
        'AlbumInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 577)
        Me.Controls.Add(Me.deezerLink)
        Me.Controls.Add(Me.itunesLink)
        Me.Controls.Add(Me.spotifyLink)
        Me.Controls.Add(Me.lbl_songslist2)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.lbl_songslist1)
        Me.Controls.Add(Me.cover)
        Me.Controls.Add(Me.lbl_artist)
        Me.Controls.Add(Me.lbl_album)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.pfp)
        Me.Controls.Add(Me.userBttn)
        Me.Controls.Add(Me.filterBttn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.searchbar)
        Me.Controls.Add(Me.banner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AlbumInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _username As Label
    Friend WithEvents pfp As PictureBox
    Friend WithEvents userBttn As Button
    Friend WithEvents filterBttn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents searchbar As TextBox
    Friend WithEvents banner As PictureBox
    Friend WithEvents lbl_album As Label
    Friend WithEvents lbl_artist As Label
    Friend WithEvents cover As PictureBox
    Friend WithEvents lbl_songslist1 As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents lbl_songslist2 As Label
    Friend WithEvents deezerLink As LinkLabel
    Friend WithEvents itunesLink As LinkLabel
    Friend WithEvents spotifyLink As LinkLabel
End Class
