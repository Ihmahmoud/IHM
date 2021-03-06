Public Class MainComponent
    Public Sub StylyMainForm()
        Main.Text = "IHM System"
        Main.StartPosition = FormStartPosition.CenterScreen
        Main.WindowState = FormWindowState.Maximized
        Main.IsMdiContainer = True
        Main.Width = 1280
        Main.Height = 1024
        ChangeMdiColor()
    End Sub
    Public Sub ChangeMdiColor()
        For Each Ctl As Control In Main.Controls
            If TypeOf Ctl Is MdiClient Then
                Ctl.BackColor = Color.FromArgb(232, 232, 232)
            End If
        Next
    End Sub
End Class
