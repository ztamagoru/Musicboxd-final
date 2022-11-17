<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.createAcc = New System.Windows.Forms.Label()
        Me._password = New System.Windows.Forms.TextBox()
        Me._username = New System.Windows.Forms.TextBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.fondo = New System.Windows.Forms.PictureBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(113, 492)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 86)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'createAcc
        '
        Me.createAcc.AutoSize = True
        Me.createAcc.BackColor = System.Drawing.Color.Transparent
        Me.createAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createAcc.Font = New System.Drawing.Font("Mark", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createAcc.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.createAcc.Location = New System.Drawing.Point(68, 594)
        Me.createAcc.Name = "createAcc"
        Me.createAcc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.createAcc.Size = New System.Drawing.Size(160, 21)
        Me.createAcc.TabIndex = 16
        Me.createAcc.Text = "Create an account"
        '
        '_password
        '
        Me._password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._password.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._password.ForeColor = System.Drawing.SystemColors.ControlDark
        Me._password.Location = New System.Drawing.Point(43, 295)
        Me._password.Margin = New System.Windows.Forms.Padding(4)
        Me._password.MaxLength = 20
        Me._password.Name = "_password"
        Me._password.Size = New System.Drawing.Size(263, 28)
        Me._password.TabIndex = 15
        Me._password.Text = "Password"
        '
        '_username
        '
        Me._username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._username.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.SystemColors.ControlDark
        Me._username.Location = New System.Drawing.Point(43, 247)
        Me._username.Margin = New System.Windows.Forms.Padding(4)
        Me._username.MaxLength = 50
        Me._username.Name = "_username"
        Me._username.Size = New System.Drawing.Size(263, 28)
        Me._username.TabIndex = 14
        Me._username.Text = "Username"
        '
        'logo
        '
        Me.logo.Image = Global.Intento2.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(27, 28)
        Me.logo.Margin = New System.Windows.Forms.Padding(4)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(296, 197)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 13
        Me.logo.TabStop = False
        '
        'fondo
        '
        Me.fondo.Image = Global.Intento2.My.Resources.Resources.fondo_inicio
        Me.fondo.Location = New System.Drawing.Point(297, -9)
        Me.fondo.Margin = New System.Windows.Forms.Padding(4)
        Me.fondo.Name = "fondo"
        Me.fondo.Size = New System.Drawing.Size(837, 656)
        Me.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fondo.TabIndex = 17
        Me.fondo.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1125, 638)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.createAcc)
        Me.Controls.Add(Me._password)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.fondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Musicboxd"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents createAcc As Label
    Friend WithEvents _password As TextBox
    Friend WithEvents _username As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents fondo As PictureBox
End Class
