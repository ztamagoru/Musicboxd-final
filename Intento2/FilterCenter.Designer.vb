<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilterCenter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterCenter))
        Me.userBttn = New System.Windows.Forms.Button()
        Me.filterBttn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.searchbar = New System.Windows.Forms.TextBox()
        Me._username = New System.Windows.Forms.Label()
        Me.pfp = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.banner = New System.Windows.Forms.PictureBox()
        Me.listapalabras = New System.Windows.Forms.ListBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.newword = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.orderby = New System.Windows.Forms.ComboBox()
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userBttn
        '
        Me.userBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.userBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBttn.Location = New System.Drawing.Point(352, 17)
        Me.userBttn.Name = "userBttn"
        Me.userBttn.Size = New System.Drawing.Size(120, 33)
        Me.userBttn.TabIndex = 50
        Me.userBttn.Text = "User center"
        Me.userBttn.UseVisualStyleBackColor = False
        Me.userBttn.Visible = False
        '
        'filterBttn
        '
        Me.filterBttn.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.filterBttn.Font = New System.Drawing.Font("Mark", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterBttn.Location = New System.Drawing.Point(487, 17)
        Me.filterBttn.Name = "filterBttn"
        Me.filterBttn.Size = New System.Drawing.Size(134, 33)
        Me.filterBttn.TabIndex = 47
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
        Me.Button1.TabIndex = 49
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
        Me.searchbar.TabIndex = 48
        Me.searchbar.Text = "Search song, album or artist"
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
        Me._username.TabIndex = 45
        Me._username.Text = "username"
        '
        'pfp
        '
        Me.pfp.Image = Global.Intento2.My.Resources.Resources.image
        Me.pfp.Location = New System.Drawing.Point(92, 9)
        Me.pfp.Margin = New System.Windows.Forms.Padding(2)
        Me.pfp.Name = "pfp"
        Me.pfp.Size = New System.Drawing.Size(45, 49)
        Me.pfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pfp.TabIndex = 44
        Me.pfp.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Intento2.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(7, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'banner
        '
        Me.banner.Image = CType(resources.GetObject("banner.Image"), System.Drawing.Image)
        Me.banner.Location = New System.Drawing.Point(0, 0)
        Me.banner.Name = "banner"
        Me.banner.Size = New System.Drawing.Size(986, 85)
        Me.banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.banner.TabIndex = 46
        Me.banner.TabStop = False
        '
        'listapalabras
        '
        Me.listapalabras.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.listapalabras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listapalabras.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listapalabras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.listapalabras.FormattingEnabled = True
        Me.listapalabras.ItemHeight = 20
        Me.listapalabras.Location = New System.Drawing.Point(608, 164)
        Me.listapalabras.Margin = New System.Windows.Forms.Padding(2)
        Me.listapalabras.Name = "listapalabras"
        Me.listapalabras.Size = New System.Drawing.Size(297, 360)
        Me.listapalabras.TabIndex = 51
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Intento2.My.Resources.Resources.Untitled_3
        Me.PictureBox2.Location = New System.Drawing.Point(586, 122)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(343, 419)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 54
        Me.PictureBox2.TabStop = False
        '
        'newword
        '
        Me.newword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.newword.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newword.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.newword.Location = New System.Drawing.Point(76, 223)
        Me.newword.MaxLength = 100
        Me.newword.Name = "newword"
        Me.newword.Size = New System.Drawing.Size(245, 22)
        Me.newword.TabIndex = 55
        Me.newword.Text = "Insert new word to filter"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.label1.Font = New System.Drawing.Font("Mark", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(29, 101)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.label1.Size = New System.Drawing.Size(176, 34)
        Me.label1.TabIndex = 56
        Me.label1.Text = "Filter center"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(339, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 33)
        Me.Button2.TabIndex = 57
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(72, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(212, 23)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Add new word to filter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(686, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Order by:"
        '
        'orderby
        '
        Me.orderby.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.orderby.Cursor = System.Windows.Forms.Cursors.Default
        Me.orderby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.orderby.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.orderby.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.orderby.FormattingEnabled = True
        Me.orderby.Items.AddRange(New Object() {"Recently added", "Older"})
        Me.orderby.Location = New System.Drawing.Point(773, 132)
        Me.orderby.Name = "orderby"
        Me.orderby.Size = New System.Drawing.Size(143, 27)
        Me.orderby.TabIndex = 73
        Me.orderby.TabStop = False
        '
        'FilterCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 577)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.orderby)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.newword)
        Me.Controls.Add(Me.listapalabras)
        Me.Controls.Add(Me.userBttn)
        Me.Controls.Add(Me.filterBttn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.searchbar)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.pfp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.banner)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FilterCenter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.pfp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.banner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userBttn As Button
    Friend WithEvents filterBttn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents searchbar As TextBox
    Friend WithEvents _username As Label
    Friend WithEvents pfp As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents banner As PictureBox
    Friend WithEvents listapalabras As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents newword As TextBox
    Friend WithEvents label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents orderby As ComboBox
End Class
