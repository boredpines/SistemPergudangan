<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateBarang
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
        Me.BtnUpdateBarang = New System.Windows.Forms.Button()
        Me.TxtStockUpdate = New System.Windows.Forms.TextBox()
        Me.TxtBarangUpdate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbjenisup = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnUpdateBarang
        '
        Me.BtnUpdateBarang.Location = New System.Drawing.Point(304, 227)
        Me.BtnUpdateBarang.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnUpdateBarang.Name = "BtnUpdateBarang"
        Me.BtnUpdateBarang.Size = New System.Drawing.Size(92, 25)
        Me.BtnUpdateBarang.TabIndex = 31
        Me.BtnUpdateBarang.Text = "Update Barang"
        Me.BtnUpdateBarang.UseVisualStyleBackColor = True
        '
        'TxtStockUpdate
        '
        Me.TxtStockUpdate.Location = New System.Drawing.Point(205, 136)
        Me.TxtStockUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtStockUpdate.Name = "TxtStockUpdate"
        Me.TxtStockUpdate.Size = New System.Drawing.Size(191, 23)
        Me.TxtStockUpdate.TabIndex = 30
        '
        'TxtBarangUpdate
        '
        Me.TxtBarangUpdate.Location = New System.Drawing.Point(205, 103)
        Me.TxtBarangUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBarangUpdate.Name = "TxtBarangUpdate"
        Me.TxtBarangUpdate.Size = New System.Drawing.Size(191, 23)
        Me.TxtBarangUpdate.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 136)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(32, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 25)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "UPDATE BARANG"
        '
        'cbjenisup
        '
        Me.cbjenisup.FormattingEnabled = True
        Me.cbjenisup.Location = New System.Drawing.Point(205, 164)
        Me.cbjenisup.Name = "cbjenisup"
        Me.cbjenisup.Size = New System.Drawing.Size(191, 23)
        Me.cbjenisup.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 167)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Jenis Barang"
        '
        'UpdateBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 314)
        Me.Controls.Add(Me.cbjenisup)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnUpdateBarang)
        Me.Controls.Add(Me.TxtStockUpdate)
        Me.Controls.Add(Me.TxtBarangUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UpdateBarang"
        Me.Text = "UpdateBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdateBarang As Button
    Friend WithEvents TxtStockUpdate As TextBox
    Friend WithEvents TxtBarangUpdate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbjenisup As ComboBox
    Friend WithEvents Label4 As Label
End Class
