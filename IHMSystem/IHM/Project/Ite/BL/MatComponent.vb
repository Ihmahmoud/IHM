Public Class MatComponent
    Inherits ComponentALL
    Dim MAT_Form As MAT = MAT
    Dim GetData As New MatDAT
    Public Sub GetTheCollectioon()
        CheckOpenForm()
    End Sub
    Private Sub MatStyleAndOpenChild()
        MAT_Form.Width = 1024
        MAT_Form.Height = 768
        MAT_Form.StartPosition = FormStartPosition.CenterScreen
        MAT_Form.WindowState = FormWindowState.Maximized
        MAT_Form.lpHeader.BackColor = Color.FromArgb(204, 204, 204)
        MAT_Form.lpFooter.BackColor = Color.FromArgb(204, 204, 204)
        MAT_Form.Text = "Add Item"
        MAT_Form.LpTitle.Text = "Add Item"
        Style()
    End Sub
    Private Sub MatData()
        MAT_Form.txItemNumber.Text = GetData.Get_MAX_NUM()
    End Sub
    Private Sub CheckOpenForm()
        MAT_Form.MdiParent = Main
        If MAT_Form Is Nothing OrElse MAT_Form.IsDisposed Then
            MAT_Form.Close()
            MAT_Form = New MAT
            MAT_Form.MdiParent = Main
        End If
        MatStyleAndOpenChild()
        MatData()
        MAT_Form.Visible = True
    End Sub
    Private Sub Style()
        txStyle()
        lpStyle()
    End Sub
    Private Sub txStyle()
        For Each Crl In MAT_Form.gpItems1.Controls
            If TypeOf Crl Is TextBox Then
                txBox(Crl)
            End If
        Next
    End Sub
    Private Sub lpStyle()
        For Each Crl In MAT_Form.gpItems1.Controls
            If TypeOf Crl Is Label Then
                label(Crl)
            End If
        Next
    End Sub
End Class
