Public Class extras
    Public Sub buttons(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        'btn.BackColor = Color.Red
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()

        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)

        Raduis.AddLine(10, 0, btn.Width - 20, 0)

        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)

        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)

        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

        Raduis.CloseFigure()

        btn.Region = New Region(Raduis)
    End Sub

    Private result As String

    Public Function show(options As IEnumerable(Of String), Optional message As String = "", Optional title As String = "") As String
        result = "Cancel"

        Dim menu As New Form With {.Text = title, .StartPosition = FormStartPosition.CenterParent}
        Dim tlp As New TableLayoutPanel With {.ColumnCount = 1, .RowCount = 2}
        Dim flp As New FlowLayoutPanel()
        Dim l As New Label With {.Text = message}

        menu.Controls.Add(tlp)


        tlp.Dock = DockStyle.Fill
        tlp.Controls.Add(l)
        l.Dock = DockStyle.Fill
        tlp.Controls.Add(flp)
        flp.Dock = DockStyle.Fill

        For Each o In options
            Dim b As New Button With {.Text = o}
            flp.Controls.Add(b)
            AddHandler b.Click,
                Sub(sender As Object, e As EventArgs)
                    result = DirectCast(sender, Button).Text
                    menu.Close()
                End Sub
        Next

        menu.FormBorderStyle = FormBorderStyle.FixedDialog
        menu.Height = 100
        menu.ShowDialog()

        Return result
    End Function
End Class
