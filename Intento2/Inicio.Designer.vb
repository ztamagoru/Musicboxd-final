﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.createAcc = New System.Windows.Forms.Label()
        Me._password = New System.Windows.Forms.TextBox()
        Me._username = New System.Windows.Forms.TextBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.fondo = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Intento2.My.Resources.Resources.tamagorublue
        Me.PictureBox2.Location = New System.Drawing.Point(9, 474)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'createAcc
        '
        Me.createAcc.AutoSize = True
        Me.createAcc.BackColor = System.Drawing.Color.Transparent
        Me.createAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createAcc.Font = New System.Drawing.Font("Mark", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createAcc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.createAcc.Location = New System.Drawing.Point(103, 279)
        Me.createAcc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.createAcc.Name = "createAcc"
        Me.createAcc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.createAcc.Size = New System.Drawing.Size(106, 14)
        Me.createAcc.TabIndex = 16
        Me.createAcc.Text = "Create an account"
        '
        '_password
        '
        Me._password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._password.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._password.Location = New System.Drawing.Point(20, 240)
        Me._password.MaxLength = 20
        Me._password.Name = "_password"
        Me._password.Size = New System.Drawing.Size(222, 22)
        Me._password.TabIndex = 15
        Me._password.Text = "Password"
        '
        '_username
        '
        Me._username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._username.Font = New System.Drawing.Font("Mark", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me._username.Location = New System.Drawing.Point(20, 201)
        Me._username.MaxLength = 50
        Me._username.Name = "_username"
        Me._username.Size = New System.Drawing.Size(222, 22)
        Me._username.TabIndex = 14
        Me._username.Text = "Username"
        '
        'logo
        '
        Me.logo.Image = Global.Intento2.My.Resources.Resources.logo
        Me.logo.Location = New System.Drawing.Point(8, 23)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(222, 160)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo.TabIndex = 13
        Me.logo.TabStop = False
        '
        'fondo
        '
        Me.fondo.Image = Global.Intento2.My.Resources.Resources.fondo_inicio
        Me.fondo.Location = New System.Drawing.Point(223, -7)
        Me.fondo.Name = "fondo"
        Me.fondo.Size = New System.Drawing.Size(628, 533)
        Me.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fondo.TabIndex = 17
        Me.fondo.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 518)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.createAcc)
        Me.Controls.Add(Me._password)
        Me.Controls.Add(Me._username)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.fondo)
        Me.Name = "Inicio"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents createAcc As Label
    Friend WithEvents _password As TextBox
    Friend WithEvents _username As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents fondo As PictureBox
End Class
