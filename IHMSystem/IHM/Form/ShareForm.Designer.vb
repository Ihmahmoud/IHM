<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShareForm
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
        Me.lpHeader = New System.Windows.Forms.Panel()
        Me.LpTitle = New System.Windows.Forms.Label()
        Me.lpFooter = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lpHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'lpHeader
        '
        Me.lpHeader.Controls.Add(Me.LpTitle)
        Me.lpHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lpHeader.Location = New System.Drawing.Point(0, 0)
        Me.lpHeader.Name = "lpHeader"
        Me.lpHeader.Size = New System.Drawing.Size(1264, 44)
        Me.lpHeader.TabIndex = 1
        '
        'LpTitle
        '
        Me.LpTitle.AutoSize = True
        Me.LpTitle.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LpTitle.Location = New System.Drawing.Point(4, 11)
        Me.LpTitle.Name = "LpTitle"
        Me.LpTitle.Size = New System.Drawing.Size(86, 22)
        Me.LpTitle.TabIndex = 2
        Me.LpTitle.Text = "Add Title"
        '
        'lpFooter
        '
        Me.lpFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lpFooter.Location = New System.Drawing.Point(0, 941)
        Me.lpFooter.Name = "lpFooter"
        Me.lpFooter.Size = New System.Drawing.Size(1264, 44)
        Me.lpFooter.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubmit.Location = New System.Drawing.Point(1107, 897)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(145, 38)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'ShareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lpFooter)
        Me.Controls.Add(Me.lpHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ShareForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ShareForm"
        Me.lpHeader.ResumeLayout(False)
        Me.lpHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lpHeader As System.Windows.Forms.Panel
    Friend WithEvents LpTitle As System.Windows.Forms.Label
    Friend WithEvents lpFooter As System.Windows.Forms.Panel
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
End Class
