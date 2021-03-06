
Public Class ComponentALL
    Public Sub txBox(ByVal Tx As TextBox)
        Tx.BorderStyle = BorderStyle.FixedSingle
        Tx.Font = New Drawing.Font("Times New Roman", 9, FontStyle.Bold)
        Tx.TextAlign = HorizontalAlignment.Center
    End Sub
    Public Sub label(ByVal Lp As Label)
        Lp.Font = New Drawing.Font("Times New Roman", 9, FontStyle.Bold)
        Lp.AutoSize = True
        Lp.ForeColor = Color.Black
    End Sub
End Class
