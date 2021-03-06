<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAT
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
        Me.lpItemNumber = New System.Windows.Forms.Label()
        Me.txItemNumber = New System.Windows.Forms.TextBox()
        Me.txItemCode = New System.Windows.Forms.TextBox()
        Me.lpItemCode = New System.Windows.Forms.Label()
        Me.txItemName = New System.Windows.Forms.TextBox()
        Me.lpItemName = New System.Windows.Forms.Label()
        Me.txItemConsumerPrice = New System.Windows.Forms.TextBox()
        Me.lpItemConsumerPrice = New System.Windows.Forms.Label()
        Me.gpItems1 = New System.Windows.Forms.GroupBox()
        Me.gpItems1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lpItemNumber
        '
        Me.lpItemNumber.AutoSize = True
        Me.lpItemNumber.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpItemNumber.Location = New System.Drawing.Point(3, 13)
        Me.lpItemNumber.Name = "lpItemNumber"
        Me.lpItemNumber.Size = New System.Drawing.Size(77, 15)
        Me.lpItemNumber.TabIndex = 1
        Me.lpItemNumber.Text = "Item Number"
        '
        'txItemNumber
        '
        Me.txItemNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txItemNumber.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txItemNumber.Location = New System.Drawing.Point(6, 31)
        Me.txItemNumber.Name = "txItemNumber"
        Me.txItemNumber.Size = New System.Drawing.Size(147, 21)
        Me.txItemNumber.TabIndex = 1
        Me.txItemNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txItemCode
        '
        Me.txItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txItemCode.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txItemCode.Location = New System.Drawing.Point(159, 31)
        Me.txItemCode.Name = "txItemCode"
        Me.txItemCode.Size = New System.Drawing.Size(147, 21)
        Me.txItemCode.TabIndex = 2
        Me.txItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lpItemCode
        '
        Me.lpItemCode.AutoSize = True
        Me.lpItemCode.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpItemCode.Location = New System.Drawing.Point(156, 13)
        Me.lpItemCode.Name = "lpItemCode"
        Me.lpItemCode.Size = New System.Drawing.Size(61, 15)
        Me.lpItemCode.TabIndex = 3
        Me.lpItemCode.Text = "Item Code"
        '
        'txItemName
        '
        Me.txItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txItemName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txItemName.Location = New System.Drawing.Point(312, 31)
        Me.txItemName.Name = "txItemName"
        Me.txItemName.Size = New System.Drawing.Size(211, 21)
        Me.txItemName.TabIndex = 4
        Me.txItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lpItemName
        '
        Me.lpItemName.AutoSize = True
        Me.lpItemName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpItemName.Location = New System.Drawing.Point(309, 13)
        Me.lpItemName.Name = "lpItemName"
        Me.lpItemName.Size = New System.Drawing.Size(65, 15)
        Me.lpItemName.TabIndex = 5
        Me.lpItemName.Text = "Item Name"
        '
        'txItemConsumerPrice
        '
        Me.txItemConsumerPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txItemConsumerPrice.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txItemConsumerPrice.Location = New System.Drawing.Point(529, 31)
        Me.txItemConsumerPrice.Name = "txItemConsumerPrice"
        Me.txItemConsumerPrice.Size = New System.Drawing.Size(122, 21)
        Me.txItemConsumerPrice.TabIndex = 6
        Me.txItemConsumerPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lpItemConsumerPrice
        '
        Me.lpItemConsumerPrice.AutoSize = True
        Me.lpItemConsumerPrice.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lpItemConsumerPrice.Location = New System.Drawing.Point(526, 13)
        Me.lpItemConsumerPrice.Name = "lpItemConsumerPrice"
        Me.lpItemConsumerPrice.Size = New System.Drawing.Size(122, 15)
        Me.lpItemConsumerPrice.TabIndex = 7
        Me.lpItemConsumerPrice.Text = "Item Consumer Price "
        '
        'gpItems1
        '
        Me.gpItems1.Controls.Add(Me.txItemNumber)
        Me.gpItems1.Controls.Add(Me.txItemConsumerPrice)
        Me.gpItems1.Controls.Add(Me.lpItemNumber)
        Me.gpItems1.Controls.Add(Me.lpItemConsumerPrice)
        Me.gpItems1.Controls.Add(Me.lpItemCode)
        Me.gpItems1.Controls.Add(Me.txItemName)
        Me.gpItems1.Controls.Add(Me.txItemCode)
        Me.gpItems1.Controls.Add(Me.lpItemName)
        Me.gpItems1.Location = New System.Drawing.Point(8, 50)
        Me.gpItems1.Name = "gpItems1"
        Me.gpItems1.Size = New System.Drawing.Size(659, 69)
        Me.gpItems1.TabIndex = 8
        Me.gpItems1.TabStop = False
        '
        'MAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.gpItems1)
        Me.Name = "MAT"
        Me.Text = "MAT"
        Me.Controls.SetChildIndex(Me.gpItems1, 0)
        Me.gpItems1.ResumeLayout(False)
        Me.gpItems1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lpItemNumber As System.Windows.Forms.Label
    Friend WithEvents txItemNumber As System.Windows.Forms.TextBox
    Friend WithEvents txItemCode As System.Windows.Forms.TextBox
    Friend WithEvents lpItemCode As System.Windows.Forms.Label
    Friend WithEvents txItemName As System.Windows.Forms.TextBox
    Friend WithEvents lpItemName As System.Windows.Forms.Label
    Friend WithEvents txItemConsumerPrice As System.Windows.Forms.TextBox
    Friend WithEvents lpItemConsumerPrice As System.Windows.Forms.Label
    Friend WithEvents gpItems1 As System.Windows.Forms.GroupBox
    'Friend WithEvents LpTitle As System.Windows.Forms.Label
End Class
