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
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.LblIDBarang = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTglOrder = New System.Windows.Forms.Label()
        Me.LblJmlhOrder = New System.Windows.Forms.Label()
        Me.DateTimePickerOrder = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxJmlhOrder = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(347, 255)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnOrder.TabIndex = 17
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'LblIDBarang
        '
        Me.LblIDBarang.AutoSize = True
        Me.LblIDBarang.Location = New System.Drawing.Point(75, 96)
        Me.LblIDBarang.Name = "LblIDBarang"
        Me.LblIDBarang.Size = New System.Drawing.Size(44, 15)
        Me.LblIDBarang.TabIndex = 21
        Me.LblIDBarang.Text = "Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(28, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "ADD ORDER"
        '
        'LblTglOrder
        '
        Me.LblTglOrder.AutoSize = True
        Me.LblTglOrder.Location = New System.Drawing.Point(75, 140)
        Me.LblTglOrder.Name = "LblTglOrder"
        Me.LblTglOrder.Size = New System.Drawing.Size(81, 15)
        Me.LblTglOrder.TabIndex = 14
        Me.LblTglOrder.Text = "Tanggal Order"
        '
        'LblJmlhOrder
        '
        Me.LblJmlhOrder.AutoSize = True
        Me.LblJmlhOrder.Location = New System.Drawing.Point(75, 191)
        Me.LblJmlhOrder.Name = "LblJmlhOrder"
        Me.LblJmlhOrder.Size = New System.Drawing.Size(78, 15)
        Me.LblJmlhOrder.TabIndex = 15
        Me.LblJmlhOrder.Text = "Jumlah Order"
        '
        'DateTimePickerOrder
        '
        Me.DateTimePickerOrder.Location = New System.Drawing.Point(222, 134)
        Me.DateTimePickerOrder.Name = "DateTimePickerOrder"
        Me.DateTimePickerOrder.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerOrder.TabIndex = 18
        '
        'TextBoxJmlhOrder
        '
        Me.TextBoxJmlhOrder.Location = New System.Drawing.Point(222, 183)
        Me.TextBoxJmlhOrder.Name = "TextBoxJmlhOrder"
        Me.TextBoxJmlhOrder.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxJmlhOrder.TabIndex = 19
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(222, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 23)
        Me.ComboBox1.TabIndex = 24
        '
        'AddOrderBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 304)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxJmlhOrder)
        Me.Controls.Add(Me.DateTimePickerOrder)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.LblJmlhOrder)
        Me.Controls.Add(Me.LblTglOrder)
        Me.Controls.Add(Me.LblIDBarang)
        Me.Name = "AddOrderBarang"
        Me.Text = "AddOrderBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnOrder As Button
    Friend WithEvents LblIDBarang As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTglOrder As Label
    Friend WithEvents LblJmlhOrder As Label
    Friend WithEvents DateTimePickerOrder As DateTimePicker
    Friend WithEvents TextBoxJmlhOrder As TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
