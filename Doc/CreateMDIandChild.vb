Imports System
Imports System.Windows.Forms

Public Module AppModule
   Public Sub Main(  )
      Application.Run(New MainForm(  ))
   End Sub
End Module

Public Class MainForm
   Inherits Form
   
   Public Sub New(  )
      ' Set the main window caption.
      Text = "My MDI Application"
      ' Set this to be an MDI parent form.
      IsMdiContainer = True
      ' Create a child form.
      Dim myChild As New DocumentForm("My Document", Me)
      myChild.Show
   End Sub

End Class

Public Class DocumentForm
   Inherits Form
   
   Public Sub New(ByVal name As String, ByVal parent As Form)
      ' Set the document window caption.
      Text = name
      ' Set this to be an MDI child form.
      MdiParent = parent
   End Sub
   
End Class
