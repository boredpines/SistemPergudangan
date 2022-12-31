<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrderBarang
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
        Me.GroupBoxStatus = New System.Windows.Forms.GroupBox()
        Me.RadioButton0 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TextBoxJmlhOrder = New System.Windows.Forms.TextBox()
        Me.DateTimePickerOrder = New System.Windows.Forms.DateTimePicker()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.LblJmlhOrder = New System.Windows.Forms.Label()
        Me.LblTglOrder = New System.Windows.Forms.Label()
        Me.Lblidbrng = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxIDBarang = New System.Windows.Forms.TextBox()
        Me.LblIDBarang = New System.Windows.Forms.Label()
        Me.GroupBoxStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxStatus
        '
        Me.GroupBoxStatus.Controls.Add(Me.RadioButton0)
        Me.GroupBoxStatus.Controls.Add(Me.RadioButton1)
        Me.GroupBoxStatus.Location = New System.Drawing.Point(362, 179)
        Me.GroupBoxStatus.Name = "GroupBoxStatus"
        Me.GroupBoxStatus.Size = New System.Drawing.Size(142, 73)
        Me.GroupBoxStatus.TabIndex = 20
        Me.GroupBoxStatus.TabStop = False
        Me.GroupBoxStatus.Text = "status"
        '
        'RadioButton0
        '
        Me.RadioButton0.AutoSize = True
        Me.RadioButton0.Location = New System.Drawing.Point(14, 48)
        Me.RadioButton0.Name = "RadioButton0"
        Me.RadioButton0.Size = New System.Drawing.Size(94, 19)
        Me.RadioButton0.TabIndex = 1
        Me.RadioButton0.TabStop = True
        Me.RadioButton0.Text = "0 (Terpenuhi)"
        Me.RadioButton0.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1 (Aktif)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBoxJmlhOrder
        '
        Me.TextBoxJmlhOrder.Location = New System.Drawing.Point(351, 125)
        Me.TextBoxJmlhOrder.Name = "TextBoxJmlhOrder"
        Me.TextBoxJmlhOrder.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxJmlhOrder.TabIndex = 19
        '
        'DateTimePickerOrder
        '
        Me.DateTimePickerOrder.Location = New System.Drawing.Point(351, 76)
        Me.DateTimePickerOrder.Name = "DateTimePickerOrder"
        Me.DateTimePickerOrder.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerOrder.TabIndex = 18
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(351, 295)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnOrder.TabIndex = 17
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(204, 180)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(39, 15)
        Me.LblStatus.TabIndex = 16
        Me.LblStatus.Text = "Status"
        '
        'LblJmlhOrder
        '
        Me.LblJmlhOrder.AutoSize = True
        Me.LblJmlhOrder.Location = New System.Drawing.Point(204, 133)
        Me.LblJmlhOrder.Name = "LblJmlhOrder"
        Me.LblJmlhOrder.Size = New System.Drawing.Size(78, 15)
        Me.LblJmlhOrder.TabIndex = 15
        Me.LblJmlhOrder.Text = "Jumlah Order"
        '
        'LblTglOrder
        '
        Me.LblTglOrder.AutoSize = True
        Me.LblTglOrder.Location = New System.Drawing.Point(204, 82)
        Me.LblTglOrder.Name = "LblTglOrder"
        Me.LblTglOrder.Size = New System.Drawing.Size(81, 15)
        Me.LblTglOrder.TabIndex = 14
        Me.LblTglOrder.Text = "Tanggal Order"
        '
        'Lblidbrng
        '
        Me.Lblidbrng.AutoSize = True
        Me.Lblidbrng.Location = New System.Drawing.Point(204, 37)
        Me.Lblidbrng.Name = "Lblidbrng"
        Me.Lblidbrng.Size = New System.Drawing.Size(0, 15)
        Me.Lblidbrng.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "  "
        '
        'TextBoxIDBarang
        '
        Me.TextBoxIDBarang.Location = New System.Drawing.Point(351, 35)
        Me.TextBoxIDBarang.Name = "TextBoxIDBarang"
        Me.TextBoxIDBarang.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxIDBarang.TabIndex = 22
        '
        'LblIDBarang
        '
        Me.LblIDBarang.AutoSize = True
        Me.LblIDBarang.Location = New System.Drawing.Point(201, 37)
        Me.LblIDBarang.Name = "LblIDBarang"
        Me.LblIDBarang.Size = New System.Drawing.Size(58, 15)
        Me.LblIDBarang.TabIndex = 21
        Me.LblIDBarang.Text = "ID Barang"
        '
        'AddOrderBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBoxStatus)
        Me.Controls.Add(Me.TextBoxJmlhOrder)
        Me.Controls.Add(Me.DateTimePickerOrder)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblJmlhOrder)
        Me.Controls.Add(Me.LblTglOrder)
        Me.Controls.Add(Me.Lblidbrng)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxIDBarang)
        Me.Controls.Add(Me.LblIDBarang)
        Me.Name = "AddOrderBarang"
        Me.Text = "AddOrderBarang"
        Me.GroupBoxStatus.ResumeLayout(False)
        Me.GroupBoxStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBoxStatus As GroupBox
    Friend WithEvents RadioButton0 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBoxJmlhOrder As TextBox
    Friend WithEvents DateTimePickerOrder As DateTimePicker
    Friend WithEvents BtnOrder As Button
    Friend WithEvents LblStatus As Label
    Friend WithEvents LblJmlhOrder As Label
    Friend WithEvents LblTglOrder As Label
    Friend WithEvents Lblidbrng As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxIDBarang As TextBox
    Friend WithEvents LblIDBarang As Label
End Class
