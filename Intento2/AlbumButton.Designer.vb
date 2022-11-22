<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlbumButton
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
        Me.lbl_albumname = New System.Windows.Forms.Label()
        Me.cover = New System.Windows.Forms.PictureBox()
        Me.buttonbackground = New System.Windows.Forms.PictureBox()
        CType(Me.cover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.buttonbackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_artistname
        '
        Me.lbl_artistname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_artistname.AutoSize = True
        Me.lbl_artistname.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lbl_artistname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_artistname.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_artistname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_artistname.Location = New System.Drawing.Point(83, 38)
        Me.lbl_artistname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_artistname.MaximumSize = New System.Drawing.Size(550, 0)
        Me.lbl_artistname.Name = "lbl_artistname"
        Me.lbl_artistname.Size = New System.Drawing.Size(113, 19)
        Me.lbl_artistname.TabIndex = 36
        Me.lbl_artistname.Text = "lbl_artistname"
        '
        'lbl_albumname
        '
        Me.lbl_albumname.AutoSize = True
        Me.lbl_albumname.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lbl_albumname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_albumname.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_albumname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_albumname.Location = New System.Drawing.Point(83, 15)
        Me.lbl_albumname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_albumname.Name = "lbl_albumname"
        Me.lbl_albumname.Size = New System.Drawing.Size(126, 20)
        Me.lbl_albumname.TabIndex = 35
        Me.lbl_albumname.Text = "lbl_albumname"
        '
        'cover
        '
        Me.cover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cover.Image = Global.Intento2.My.Resources.Resources.not_found
        Me.cover.Location = New System.Drawing.Point(24, 11)
        Me.cover.Name = "cover"
        Me.cover.Size = New System.Drawing.Size(50, 50)
        Me.cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cover.TabIndex = 34
        Me.cover.TabStop = False
        '
        'buttonbackground
        '
        Me.buttonbackground.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonbackground.Image = Global.Intento2.My.Resources.Resources.fondo_boton_claro
        Me.buttonbackground.Location = New System.Drawing.Point(3, 2)
        Me.buttonbackground.Name = "buttonbackground"
        Me.buttonbackground.Size = New System.Drawing.Size(318, 69)
        Me.buttonbackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.buttonbackground.TabIndex = 33
        Me.buttonbackground.TabStop = False
        '
        'AlbumButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Controls.Add(Me.lbl_artistname)
        Me.Controls.Add(Me.lbl_albumname)
        Me.Controls.Add(Me.cover)
        Me.Controls.Add(Me.buttonbackground)
        Me.Name = "AlbumButton"
        Me.Size = New System.Drawing.Size(325, 72)
        CType(Me.cover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.buttonbackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_artistname As Label
    Friend WithEvents lbl_albumname As Label
    Friend WithEvents cover As PictureBox
    Friend WithEvents buttonbackground As PictureBox
End Class
