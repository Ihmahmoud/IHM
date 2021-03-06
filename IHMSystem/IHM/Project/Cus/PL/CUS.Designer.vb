<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUS
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
        Me.lpCustomerSerial = New System.Windows.Forms.Label()
        Me.txCustomerSerial = New System.Windows.Forms.TextBox()
        Me.gpCustomer1 = New System.Windows.Forms.GroupBox()
        Me.txCustomerPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lpCustomerPhoneNumber = New System.Windows.Forms.Label()
        Me.txCustomerLastName = New System.Windows.Forms.TextBox()
        Me.lpCustomerLastName = New System.Windows.Forms.Label()
        Me.txCustomerSecondName = New System.Windows.Forms.TextBox()
        Me.lpCustomerSecondName = New System.Windows.Forms.Label()
        Me.txCustomerCivilID = New System.Windows.Forms.TextBox()
        Me.lpCustomerCivilID = New System.Windows.Forms.Label()
        Me.txCustomerFirstName = New System.Windows.Forms.TextBox()
        Me.lpCustomerFirstName = New System.Windows.Forms.Label()
        Me.gpCustomer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lpCustomerSerial
        '
        Me.lpCustomerSerial.AutoSize = True
        Me.lpCustomerSerial.Location = New System.Drawing.Point(3, 14)
        Me.lpCustomerSerial.Name = "lpCustomerSerial"
        Me.lpCustomerSerial.Size = New System.Drawing.Size(82, 13)
        Me.lpCustomerSerial.TabIndex = 1
        Me.lpCustomerSerial.Text = "Customer Serial"
        '
        'txCustomerSerial
        '
        Me.txCustomerSerial.Location = New System.Drawing.Point(6, 30)
        Me.txCustomerSerial.Name = "txCustomerSerial"
        Me.txCustomerSerial.Size = New System.Drawing.Size(147, 20)
        Me.txCustomerSerial.TabIndex = 1
        '
        'gpCustomer1
        '
        Me.gpCustomer1.Controls.Add(Me.txCustomerPhoneNumber)
        Me.gpCustomer1.Controls.Add(Me.lpCustomerPhoneNumber)
        Me.gpCustomer1.Controls.Add(Me.txCustomerLastName)
        Me.gpCustomer1.Controls.Add(Me.lpCustomerLastName)
        Me.gpCustomer1.Controls.Add(Me.txCustomerSecondName)
        Me.gpCustomer1.Controls.Add(Me.lpCustomerSecondName)
        Me.gpCustomer1.Controls.Add(Me.txCustomerCivilID)
        Me.gpCustomer1.Controls.Add(Me.lpCustomerCivilID)
        Me.gpCustomer1.Controls.Add(Me.txCustomerFirstName)
        Me.gpCustomer1.Controls.Add(Me.txCustomerSerial)
        Me.gpCustomer1.Controls.Add(Me.lpCustomerFirstName)
        Me.gpCustomer1.Controls.Add(Me.lpCustomerSerial)
        Me.gpCustomer1.Location = New System.Drawing.Point(8, 50)
        Me.gpCustomer1.Name = "gpCustomer1"
        Me.gpCustomer1.Size = New System.Drawing.Size(772, 100)
        Me.gpCustomer1.TabIndex = 6
        Me.gpCustomer1.TabStop = False
        '
        'txCustomerPhoneNumber
        '
        Me.txCustomerPhoneNumber.Location = New System.Drawing.Point(245, 74)
        Me.txCustomerPhoneNumber.Name = "txCustomerPhoneNumber"
        Me.txCustomerPhoneNumber.Size = New System.Drawing.Size(233, 20)
        Me.txCustomerPhoneNumber.TabIndex = 6
        '
        'lpCustomerPhoneNumber
        '
        Me.lpCustomerPhoneNumber.AutoSize = True
        Me.lpCustomerPhoneNumber.Location = New System.Drawing.Point(242, 58)
        Me.lpCustomerPhoneNumber.Name = "lpCustomerPhoneNumber"
        Me.lpCustomerPhoneNumber.Size = New System.Drawing.Size(126, 13)
        Me.lpCustomerPhoneNumber.TabIndex = 16
        Me.lpCustomerPhoneNumber.Text = "Customer Phone Number"
        '
        'txCustomerLastName
        '
        Me.txCustomerLastName.Location = New System.Drawing.Point(465, 30)
        Me.txCustomerLastName.Name = "txCustomerLastName"
        Me.txCustomerLastName.Size = New System.Drawing.Size(147, 20)
        Me.txCustomerLastName.TabIndex = 4
        '
        'lpCustomerLastName
        '
        Me.lpCustomerLastName.AutoSize = True
        Me.lpCustomerLastName.Location = New System.Drawing.Point(462, 14)
        Me.lpCustomerLastName.Name = "lpCustomerLastName"
        Me.lpCustomerLastName.Size = New System.Drawing.Size(106, 13)
        Me.lpCustomerLastName.TabIndex = 14
        Me.lpCustomerLastName.Text = "Customer Last Name"
        '
        'txCustomerSecondName
        '
        Me.txCustomerSecondName.Location = New System.Drawing.Point(312, 30)
        Me.txCustomerSecondName.Name = "txCustomerSecondName"
        Me.txCustomerSecondName.Size = New System.Drawing.Size(147, 20)
        Me.txCustomerSecondName.TabIndex = 3
        '
        'lpCustomerSecondName
        '
        Me.lpCustomerSecondName.AutoSize = True
        Me.lpCustomerSecondName.Location = New System.Drawing.Point(309, 14)
        Me.lpCustomerSecondName.Name = "lpCustomerSecondName"
        Me.lpCustomerSecondName.Size = New System.Drawing.Size(121, 13)
        Me.lpCustomerSecondName.TabIndex = 3
        Me.lpCustomerSecondName.Text = "Customer Second Name"
        '
        'txCustomerCivilID
        '
        Me.txCustomerCivilID.Location = New System.Drawing.Point(6, 74)
        Me.txCustomerCivilID.Name = "txCustomerCivilID"
        Me.txCustomerCivilID.Size = New System.Drawing.Size(233, 20)
        Me.txCustomerCivilID.TabIndex = 5
        '
        'lpCustomerCivilID
        '
        Me.lpCustomerCivilID.AutoSize = True
        Me.lpCustomerCivilID.Location = New System.Drawing.Point(3, 58)
        Me.lpCustomerCivilID.Name = "lpCustomerCivilID"
        Me.lpCustomerCivilID.Size = New System.Drawing.Size(89, 13)
        Me.lpCustomerCivilID.TabIndex = 10
        Me.lpCustomerCivilID.Text = "Customer Civil ID"
        '
        'txCustomerFirstName
        '
        Me.txCustomerFirstName.Location = New System.Drawing.Point(159, 30)
        Me.txCustomerFirstName.Name = "txCustomerFirstName"
        Me.txCustomerFirstName.Size = New System.Drawing.Size(147, 20)
        Me.txCustomerFirstName.TabIndex = 2
        '
        'lpCustomerFirstName
        '
        Me.lpCustomerFirstName.AutoSize = True
        Me.lpCustomerFirstName.Location = New System.Drawing.Point(156, 14)
        Me.lpCustomerFirstName.Name = "lpCustomerFirstName"
        Me.lpCustomerFirstName.Size = New System.Drawing.Size(107, 13)
        Me.lpCustomerFirstName.TabIndex = 2
        Me.lpCustomerFirstName.Text = "Customer First Name"
        '
        'CUS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.gpCustomer1)
        Me.Name = "CUS"
        Me.Text = "CUS"
        Me.Controls.SetChildIndex(Me.gpCustomer1, 0)
        Me.gpCustomer1.ResumeLayout(False)
        Me.gpCustomer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lpCustomerSerial As System.Windows.Forms.Label
    Friend WithEvents txCustomerSerial As System.Windows.Forms.TextBox
    Friend WithEvents gpCustomer1 As System.Windows.Forms.GroupBox
    Friend WithEvents txCustomerFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lpCustomerFirstName As System.Windows.Forms.Label
    Friend WithEvents txCustomerCivilID As System.Windows.Forms.TextBox
    Friend WithEvents lpCustomerCivilID As System.Windows.Forms.Label
    Friend WithEvents txCustomerLastName As System.Windows.Forms.TextBox
    Friend WithEvents lpCustomerLastName As System.Windows.Forms.Label
    Friend WithEvents txCustomerSecondName As System.Windows.Forms.TextBox
    Friend WithEvents lpCustomerSecondName As System.Windows.Forms.Label
    Friend WithEvents txCustomerPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lpCustomerPhoneNumber As System.Windows.Forms.Label
End Class
