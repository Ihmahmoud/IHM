<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.StatusScreenConnection = New System.Windows.Forms.StatusStrip()
        Me.ConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_ConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsumersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusScreenConnection.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusScreenConnection
        '
        Me.StatusScreenConnection.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionStatus, Me.TSSL_ConnectionStatus})
        Me.StatusScreenConnection.Location = New System.Drawing.Point(0, 963)
        Me.StatusScreenConnection.Name = "StatusScreenConnection"
        Me.StatusScreenConnection.Size = New System.Drawing.Size(1264, 22)
        Me.StatusScreenConnection.TabIndex = 0
        Me.StatusScreenConnection.Text = "StatusStrip1"
        '
        'ConnectionStatus
        '
        Me.ConnectionStatus.Name = "ConnectionStatus"
        Me.ConnectionStatus.Size = New System.Drawing.Size(104, 17)
        Me.ConnectionStatus.Text = "Connection Status"
        '
        'TSSL_ConnectionStatus
        '
        Me.TSSL_ConnectionStatus.Name = "TSSL_ConnectionStatus"
        Me.TSSL_ConnectionStatus.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StoreToolStripMenuItem, Me.ConsumersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StoreToolStripMenuItem
        '
        Me.StoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaterialGuideToolStripMenuItem})
        Me.StoreToolStripMenuItem.Name = "StoreToolStripMenuItem"
        Me.StoreToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.StoreToolStripMenuItem.Text = "Stores"
        '
        'MaterialGuideToolStripMenuItem
        '
        Me.MaterialGuideToolStripMenuItem.Name = "MaterialGuideToolStripMenuItem"
        Me.MaterialGuideToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.MaterialGuideToolStripMenuItem.Text = "Material Guide "
        '
        'ConsumersToolStripMenuItem
        '
        Me.ConsumersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomersToolStripMenuItem, Me.SuppliersToolStripMenuItem})
        Me.ConsumersToolStripMenuItem.Name = "ConsumersToolStripMenuItem"
        Me.ConsumersToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.ConsumersToolStripMenuItem.Text = "Accounts guide"
        '
        'CustomersToolStripMenuItem
        '
        Me.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        Me.CustomersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CustomersToolStripMenuItem.Text = "Customers"
        '
        'SuppliersToolStripMenuItem
        '
        Me.SuppliersToolStripMenuItem.Name = "SuppliersToolStripMenuItem"
        Me.SuppliersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SuppliersToolStripMenuItem.Text = "Suppliers"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.StatusScreenConnection)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Main"
        Me.StatusScreenConnection.ResumeLayout(False)
        Me.StatusScreenConnection.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusScreenConnection As System.Windows.Forms.StatusStrip
    Friend WithEvents ConnectionStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_ConnectionStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaterialGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsumersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
