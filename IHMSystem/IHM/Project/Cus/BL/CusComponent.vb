Public Class CusComponent : Inherits ComponentALL
    Dim CUS_Form As CUS = CUS
    Dim GetData As New CusDat
    Public Sub GetTheCollection()
        CheckOpenForm()
    End Sub
    Private Sub CUSStyleAndOpenChild()
        CUS_Form.Width = 1024
        CUS_Form.Height = 768
        CUS_Form.StartPosition = FormStartPosition.CenterScreen
        CUS_Form.WindowState = FormWindowState.Maximized
        CUS_Form.lpHeader.BackColor = Color.FromArgb(204, 204, 204)
        CUS_Form.lpFooter.BackColor = Color.FromArgb(204, 204, 204)
        CUS_Form.Text = "Add Customer"
        CUS_Form.LpTitle.Text = "Add Customer"
        Style()
    End Sub
    Private Sub CUSData()
        CUS_Form.txCustomerSerial.Text = GetData.Get_MAX_Serial()
    End Sub
    Private Sub CheckOpenForm()
        CUS_Form.MdiParent = Main
        If CUS_Form Is Nothing OrElse CUS_Form.IsDisposed Then
            CUS_Form.Close()
            CUS_Form = New CUS
            CUS_Form.MdiParent = Main
        End If
        CUSStyleAndOpenChild()
        CUSData()
        CUS_Form.Visible = True
    End Sub
    Private Sub Style()
        txStyle()
        lpStyle()
    End Sub
    Private Sub txStyle()
        For Each Crl In CUS_Form.gpCustomer1.Controls
            If TypeOf Crl Is TextBox Then
                txBox(Crl)
            End If
        Next
    End Sub
    Private Sub lpStyle()
        For Each Crl In CUS_Form.gpCustomer1.Controls
            If TypeOf Crl Is Label Then
                Label(Crl)
            End If
        Next
    End Sub
End Class
