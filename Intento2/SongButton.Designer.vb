<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SongButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_artistname = New System.Windows.Forms.Label()
        Me.lbl_songname = New System.Windows.Forms.Label()
        Me.cover = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_artistname
        '
        Me.lbl_artistname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_artistname.AutoSize = True
        Me.lbl_artistname.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_artistname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_artistname.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_artistname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_artistname.Location = New System.Drawing.Point(83, 42)
        Me.lbl_artistname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_artistname.MaximumSize = New System.Drawing.Size(550, 0)
        Me.lbl_artistname.Name = "lbl_artistname"
        Me.lbl_artistname.Size = New System.Drawing.Size(113, 19)
        Me.lbl_artistname.TabIndex = 32
        Me.lbl_artistname.Text = "lbl_artistname"
        '
        'lbl_songname
        '
        Me.lbl_songname.AutoSize = True
        Me.lbl_songname.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_songname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_songname.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_songname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_songname.Location = New System.Drawing.Point(83, 19)
        Me.lbl_songname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_songname.Name = "lbl_songname"
        Me.lbl_songname.Size = New System.Drawing.Size(115, 20)
        Me.lbl_songname.TabIndex = 31
        Me.lbl_songname.Text = "lbl_songname"
        '
        'cover
        '
        Me.cover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cover.Image = Global.Intento2.My.Resources.Resources.not_found
        Me.cover.Location = New System.Drawing.Point(24, 15)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(50, 50)
        Me.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover.TabIndex = 30
        Me.cover.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Intento2.My.Resources.Resources.banner_inicio
        Me.PictureBox1.Location = New System.Drawing.Point(4, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(382, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'SongButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Controls.Add(Me.lbl_artistname)
        Me.Controls.Add(Me.lbl_songname)
        Me.Controls.Add(Me.cover)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SongButton"
        Me.Size = New System.Drawing.Size(391, 81)
        CType(Me.cover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_artistname As Label
    Friend WithEvents lbl_songname As Label
    Friend WithEvents cover As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
