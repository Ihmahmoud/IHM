Public Class SupComponent : Inherits ComponentALL
    Dim SUP_Form As SUP = SUP
    Dim GetData As New SupDat
    Public Sub GetTheCollection()
        CheckOpenForm()
    End Sub
    Private Sub CUSStyleAndOpenChild()
        SUP_Form.Width = 1024
        SUP_Form.Height = 768
        SUP_Form.StartPosition = FormStartPosition.CenterScreen
        SUP_Form.WindowState = FormWindowState.Maximized
        SUP_Form.lpHeader.BackColor = Color.FromArgb(204, 204, 204)
        SUP_Form.lpFooter.BackColor = Color.FromArgb(204, 204, 204)
        SUP_Form.Text = "Add Supplier"
        SUP_Form.LpTitle.Text = "Add Supplier"
        Style()
    End Sub
    Private Sub CUSData()
        SUP_Form.txSupplierSerial.Text = GetData.Get_MAX_NUM()
    End Sub

    Private Sub CheckOpenForm()
        SUP_Form.MdiParent = Main
        If SUP_Form Is Nothing OrElse SUP_Form.IsDisposed Then
            SUP_Form.Close()
            SUP_Form = New SUP
            SUP_Form.MdiParent = Main
        End If
        CUSStyleAndOpenChild()
        CUSData()
        SUP_Form.Visible = True
    End Sub
    Private Sub Style()
        txStyle()
        lpStyle()
    End Sub
    Private Sub txStyle()
        For Each Crl In SUP_Form.gpSupplier1.Controls
            If TypeOf Crl Is TextBox Then
                txBox(Crl)
            End If
        Next
    End Sub
    Private Sub lpStyle()
        For Each Crl In SUP_Form.gpSupplier1.Controls()
            If TypeOf Crl Is Label Then
                label(Crl)
            End If
        Next
    End Sub
End Class
