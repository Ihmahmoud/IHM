
Public Class Main
    Dim Compo_Main As New MainComponent
    Dim Compo_Mat As New MatComponent
    Dim Compo_Cus As New CusComponent
    Dim Compo_Sup As New SupComponent

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Compo_Main.StylyMainForm()
    End Sub

    Private Sub MaterialGuideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialGuideToolStripMenuItem.Click
        Compo_Mat.GetTheCollectioon()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Compo_Cus.GetTheCollection()
    End Sub

    Private Sub SuppliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliersToolStripMenuItem.Click
        Compo_Sup.GetTheCollection()
    End Sub
End Class