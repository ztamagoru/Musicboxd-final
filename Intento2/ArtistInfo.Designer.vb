﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArtistInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ArtistInfo))
        Me._username = New System.Windows.Forms.Label()
        Me.userBttn = New System.Windows.Forms.Button()
        Me.parameterBttn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.searchbar = New System.Windows.Forms.TextBox()
        Me.pfp = New System.Windows.Forms.PictureBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.lbl_albumlist2 = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_albumlist1 = New System.Windows.Forms.Label()
        Me.deezerLink = New System.Windows.Forms.LinkLabel()
        Me.itunesLink = New System.Windows.Forms.LinkLabel()
        Me.spotifyLink = New System.Windows.Forms.LinkLabel()
        Me.photo = New System.Windows.Forms.PictureBox()
        Me.lbl_artistname = New System.Windows.Forms.Label()
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me._username.TabIndex = 65
        Me._username.Text = "username"
        '
        'userBttn
        '
        Me.userBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.userBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBttn.Location = New System.Drawing.Point(320, 17)
        Me.userBttn.Name = "userBttn"
        Me.userBttn.Size = New System.Drawing.Size(120, 33)
        Me.userBttn.TabIndex = 59
        Me.userBttn.Text = "User center"
        Me.userBttn.UseVisualStyleBackColor = False
        Me.userBttn.Visible = False
        '
        'parameterBttn
        '
        Me.parameterBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.parameterBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parameterBttn.Location = New System.Drawing.Point(456, 17)
        Me.parameterBttn.Name = "parameterBttn"
        Me.parameterBttn.Size = New System.Drawing.Size(165, 33)
        Me.parameterBttn.TabIndex = 60
        Me.parameterBttn.Text = "Parameter center"
        Me.parameterBttn.UseVisualStyleBackColor = False
        Me.parameterBttn.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(900, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 33)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.searchbar.TabIndex = 61
        Me.searchbar.Text = "Search song, album or artist"
        '
        'pfp
        '
        Me.pfp.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.pfp.Image = Global.Intento2.My.Resources.Resources.image
        Me.pfp.Location = New System.Drawing.Point(92, 9)
        Me.pfp.Margin = New System.Windows.Forms.Padding(2)
        Me.pfp.Name = "pfp"
        Me.pfp.Size = New System.Drawing.Size(45, 49)
        Me.pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pfp.TabIndex = 64
        Me.pfp.TabStop = False
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
        Me.logo.TabIndex = 63
        Me.logo.TabStop = False
        '
        'banner
        '
        Me.banner.Image = CType(resources.GetObject("banner.Image"), System.Drawing.Image)
        Me.banner.Location = New System.Drawing.Point(0, 0)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(986, 85)
        Me.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.banner.TabIndex = 66
        Me.banner.TabStop = False
        '
        'lbl_albumlist2
        '
        Me.lbl_albumlist2.AutoSize = True
        Me.lbl_albumlist2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_albumlist2.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_albumlist2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_albumlist2.Location = New System.Drawing.Point(344, 332)
        Me.lbl_albumlist2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_albumlist2.Name = "lbl_albumlist2"
        Me.lbl_albumlist2.Size = New System.Drawing.Size(90, 20)
        Me.lbl_albumlist2.TabIndex = 77
        Me.lbl_albumlist2.Text = "albumlist2"
        '
        'lbl_description
        '
        Me.lbl_description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_description.Font = New System.Drawing.Font("Mark", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_description.Location = New System.Drawing.Point(32, 152)
        Me.lbl_description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_description.MaximumSize = New System.Drawing.Size(640, 0)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(636, 75)
        Me.lbl_description.TabIndex = 76
        Me.lbl_description.Text = "review aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        '
        'lbl_albumlist1
        '
        Me.lbl_albumlist1.AutoSize = True
        Me.lbl_albumlist1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl_albumlist1.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_albumlist1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_albumlist1.Location = New System.Drawing.Point(33, 332)
        Me.lbl_albumlist1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_albumlist1.Name = "lbl_albumlist1"
        Me.lbl_albumlist1.Size = New System.Drawing.Size(90, 20)
        Me.lbl_albumlist1.TabIndex = 75
        Me.lbl_albumlist1.Text = "albumlist1"
        '
        'deezerLink
        '
        Me.deezerLink.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.deezerLink.AutoSize = True
        Me.deezerLink.Font = New System.Drawing.Font("Mark", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deezerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.deezerLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.deezerLink.Location = New System.Drawing.Point(805, 437)
        Me.deezerLink.Name = "deezerLink"
        Me.deezerLink.Size = New System.Drawing.Size(149, 23)
        Me.deezerLink.TabIndex = 74
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
        Me.itunesLink.Location = New System.Drawing.Point(810, 401)
        Me.itunesLink.Name = "itunesLink"
        Me.itunesLink.Size = New System.Drawing.Size(144, 23)
        Me.itunesLink.TabIndex = 73
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
        Me.spotifyLink.Location = New System.Drawing.Point(801, 365)
        Me.spotifyLink.Name = "spotifyLink"
        Me.spotifyLink.Size = New System.Drawing.Size(153, 23)
        Me.spotifyLink.TabIndex = 72
        Me.spotifyLink.TabStop = True
        Me.spotifyLink.Text = "Listen in Spotify"
        Me.spotifyLink.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(118, Byte), Integer))
        '
        'photo
        '
        Me.photo.Cursor = System.Windows.Forms.Cursors.Default
        Me.photo.Image = Global.Intento2.My.Resources.Resources.not_found
        Me.photo.Location = New System.Drawing.Point(704, 104)
        Me.photo.Margin = New System.Windows.Forms.Padding(2)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(250, 250)
        Me.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.photo.TabIndex = 71
        Me.photo.TabStop = False
        '
        'lbl_artistname
        '
        Me.lbl_artistname.AutoSize = True
        Me.lbl_artistname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_artistname.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_artistname.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_artistname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_artistname.Location = New System.Drawing.Point(31, 107)
        Me.lbl_artistname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_artistname.Name = "lbl_artistname"
        Me.lbl_artistname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_artistname.Size = New System.Drawing.Size(170, 34)
        Me.lbl_artistname.TabIndex = 69
        Me.lbl_artistname.Text = "artist name"
        '
        'ArtistInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 577)
        Me.Controls.Add(Me.lbl_albumlist2)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.lbl_albumlist1)
        Me.Controls.Add(Me.deezerLink)
        Me.Controls.Add(Me.itunesLink)
        Me.Controls.Add(Me.spotifyLink)
        Me.Controls.Add(Me.photo)
        Me.Controls.Add(Me.lbl_artistname)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.pfp)
        Me.Controls.Add(Me.userBttn)
        Me.Controls.Add(Me.parameterBttn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.searchbar)
        Me.Controls.Add(Me.banner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ArtistInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _username As Label
    Friend WithEvents pfp As PictureBox
    Friend WithEvents userBttn As Button
    Friend WithEvents parameterBttn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents logo As PictureBox
    Friend WithEvents searchbar As TextBox
    Friend WithEvents banner As PictureBox
    Friend WithEvents lbl_albumlist2 As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents lbl_albumlist1 As Label
    Friend WithEvents deezerLink As LinkLabel
    Friend WithEvents itunesLink As LinkLabel
    Friend WithEvents spotifyLink As LinkLabel
    Friend WithEvents photo As PictureBox
    Friend WithEvents lbl_artistname As Label
End Class
