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
        Me.dateorder = New System.Windows.Forms.DateTimePicker()
        Me.txtjumlahorder = New System.Windows.Forms.TextBox()
        Me.cbnamabarang = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnOrder
        '
        Me.BtnOrder.BackColor = System.Drawing.Color.White
        Me.BtnOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnOrder.Location = New System.Drawing.Point(251, 218)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(78, 30)
        Me.BtnOrder.TabIndex = 17
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = False
        '
        'LblIDBarang
        '
        Me.LblIDBarang.AutoSize = True
        Me.LblIDBarang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblIDBarang.Location = New System.Drawing.Point(74, 82)
        Me.LblIDBarang.Name = "LblIDBarang"
        Me.LblIDBarang.Size = New System.Drawing.Size(88, 17)
        Me.LblIDBarang.TabIndex = 21
        Me.LblIDBarang.Text = "Nama Barang"
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
        Me.LblTglOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTglOrder.Location = New System.Drawing.Point(74, 121)
        Me.LblTglOrder.Name = "LblTglOrder"
        Me.LblTglOrder.Size = New System.Drawing.Size(93, 17)
        Me.LblTglOrder.TabIndex = 14
        Me.LblTglOrder.Text = "Tanggal Order"
        '
        'LblJmlhOrder
        '
        Me.LblJmlhOrder.AutoSize = True
        Me.LblJmlhOrder.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblJmlhOrder.Location = New System.Drawing.Point(74, 163)
        Me.LblJmlhOrder.Name = "LblJmlhOrder"
        Me.LblJmlhOrder.Size = New System.Drawing.Size(87, 17)
        Me.LblJmlhOrder.TabIndex = 15
        Me.LblJmlhOrder.Text = "Jumlah Order"
        '
        'dateorder
        '
        Me.dateorder.Location = New System.Drawing.Point(221, 121)
        Me.dateorder.Name = "dateorder"
        Me.dateorder.Size = New System.Drawing.Size(200, 23)
        Me.dateorder.TabIndex = 18
        '
        'txtjumlahorder
        '
        Me.txtjumlahorder.Location = New System.Drawing.Point(221, 162)
        Me.txtjumlahorder.Name = "txtjumlahorder"
        Me.txtjumlahorder.Size = New System.Drawing.Size(200, 23)
        Me.txtjumlahorder.TabIndex = 19
        '
        'cbnamabarang
        '
        Me.cbnamabarang.FormattingEnabled = True
        Me.cbnamabarang.Location = New System.Drawing.Point(221, 81)
        Me.cbnamabarang.Name = "cbnamabarang"
        Me.cbnamabarang.Size = New System.Drawing.Size(200, 23)
        Me.cbnamabarang.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(343, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 30)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AddOrderBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(468, 277)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbnamabarang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtjumlahorder)
        Me.Controls.Add(Me.dateorder)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.LblJmlhOrder)
        Me.Controls.Add(Me.LblTglOrder)
        Me.Controls.Add(Me.LblIDBarang)
        Me.MaximizeBox = False
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
    Friend WithEvents dateorder As DateTimePicker
    Friend WithEvents txtjumlahorder As TextBox
    Friend WithEvents cbnamabarang As ComboBox
    Friend WithEvents Button1 As Button
End Class
