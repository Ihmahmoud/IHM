<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUP
    Inherits IHM.ShareForm

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
        Me.gpSupplier1 = New System.Windows.Forms.GroupBox()
        Me.txSupplierSerial = New System.Windows.Forms.TextBox()
        Me.lpSupplierSerial = New System.Windows.Forms.Label()
        Me.txSupplierName = New System.Windows.Forms.TextBox()
        Me.lpSupplierName = New System.Windows.Forms.Label()
        Me.txSupplierPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lpSupplierPhoneNumber = New System.Windows.Forms.Label()
        Me.gpSupplier1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpSupplier1
        '
        Me.gpSupplier1.Controls.Add(Me.txSupplierPhoneNumber)
        Me.gpSupplier1.Controls.Add(Me.lpSupplierPhoneNumber)
        Me.gpSupplier1.Controls.Add(Me.txSupplierName)
        Me.gpSupplier1.Controls.Add(Me.lpSupplierName)
        Me.gpSupplier1.Controls.Add(Me.txSupplierSerial)
        Me.gpSupplier1.Controls.Add(Me.lpSupplierSerial)
        Me.gpSupplier1.Location = New System.Drawing.Point(8, 51)
        Me.gpSupplier1.Name = "gpSupplier1"
        Me.gpSupplier1.Size = New System.Drawing.Size(702, 239)
        Me.gpSupplier1.TabIndex = 4
        Me.gpSupplier1.TabStop = False
        '
        'txSupplierSerial
        '
        Me.txSupplierSerial.Location = New System.Drawing.Point(9, 33)
        Me.txSupplierSerial.Name = "txSupplierSerial"
        Me.txSupplierSerial.Size = New System.Drawing.Size(100, 20)
        Me.txSupplierSerial.TabIndex = 1
        '
        'lpSupplierSerial
        '
        Me.lpSupplierSerial.AutoSize = True
        Me.lpSupplierSerial.Location = New System.Drawing.Point(6, 16)
        Me.lpSupplierSerial.Name = "lpSupplierSerial"
        Me.lpSupplierSerial.Size = New System.Drawing.Size(74, 13)
        Me.lpSupplierSerial.TabIndex = 0
        Me.lpSupplierSerial.Text = "Supplier Serial"
        '
        'txSupplierName
        '
        Me.txSupplierName.Location = New System.Drawing.Point(115, 33)
        Me.txSupplierName.Name = "txSupplierName"
        Me.txSupplierName.Size = New System.Drawing.Size(237, 20)
        Me.txSupplierName.TabIndex = 3
        '
        'lpSupplierName
        '
        Me.lpSupplierName.AutoSize = True
        Me.lpSupplierName.Location = New System.Drawing.Point(112, 16)
        Me.lpSupplierName.Name = "lpSupplierName"
        Me.lpSupplierName.Size = New System.Drawing.Size(75, 13)
        Me.lpSupplierName.TabIndex = 2
        Me.lpSupplierName.Text = "Supplier Name"
        '
        'txSupplierPhoneNumber
        '
        Me.txSupplierPhoneNumber.Location = New System.Drawing.Point(358, 33)
        Me.txSupplierPhoneNumber.Name = "txSupplierPhoneNumber"
        Me.txSupplierPhoneNumber.Size = New System.Drawing.Size(237, 20)
        Me.txSupplierPhoneNumber.TabIndex = 5
        '
        'lpSupplierPhoneNumber
        '
        Me.lpSupplierPhoneNumber.AutoSize = True
        Me.lpSupplierPhoneNumber.Location = New System.Drawing.Point(355, 16)
        Me.lpSupplierPhoneNumber.Name = "lpSupplierPhoneNumber"
        Me.lpSupplierPhoneNumber.Size = New System.Drawing.Size(118, 13)
        Me.lpSupplierPhoneNumber.TabIndex = 4
        Me.lpSupplierPhoneNumber.Text = "Supplier Phone Number"
        '
        'SUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.gpSupplier1)
        Me.Name = "SUP"
        Me.Text = "SUP"
        Me.Controls.SetChildIndex(Me.gpSupplier1, 0)
        Me.gpSupplier1.ResumeLayout(False)
        Me.gpSupplier1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpSupplier1 As System.Windows.Forms.GroupBox
    Friend WithEvents lpSupplierSerial As System.Windows.Forms.Label
    Friend WithEvents txSupplierSerial As System.Windows.Forms.TextBox
    Friend WithEvents txSupplierPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lpSupplierPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents txSupplierName As System.Windows.Forms.TextBox
    Friend WithEvents lpSupplierName As System.Windows.Forms.Label
End Class
