<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReviewItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_review = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_review
        '
        Me.lbl_review.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_review.AutoSize = True
        Me.lbl_review.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_review.Font = New System.Drawing.Font("Mark", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_review.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_review.Location = New System.Drawing.Point(20, 28)
        Me.lbl_review.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_review.MaximumSize = New System.Drawing.Size(550, 0)
        Me.lbl_review.Name = "lbl_review"
        Me.lbl_review.Size = New System.Drawing.Size(546, 19)
        Me.lbl_review.TabIndex = 27
        Me.lbl_review.Text = "review aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lbl_username.Font = New System.Drawing.Font("Mark", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(2, 3)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(111, 20)
        Me.lbl_username.TabIndex = 26
        Me.lbl_username.Text = "lbl_username"
        '
        'ReviewItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Controls.Add(Me.lbl_review)
        Me.Controls.Add(Me.lbl_username)
        Me.Name = "ReviewItem"
        Me.Size = New System.Drawing.Size(580, 61)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_review As Label
    Friend WithEvents lbl_username As Label
End Class
