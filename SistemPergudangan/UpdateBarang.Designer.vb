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
        Me.TxtJenisUpdate = New System.Windows.Forms.TextBox()
        Me.TxtIDBUpdate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnUpdateBarang
        '
        Me.BtnUpdateBarang.Location = New System.Drawing.Point(555, 351)
        Me.BtnUpdateBarang.Name = "BtnUpdateBarang"
        Me.BtnUpdateBarang.Size = New System.Drawing.Size(131, 47)
        Me.BtnUpdateBarang.TabIndex = 31
        Me.BtnUpdateBarang.Text = "Update Barang"
        Me.BtnUpdateBarang.UseVisualStyleBackColor = True
        '
        'TxtStockUpdate
        '
        Me.TxtStockUpdate.Location = New System.Drawing.Point(372, 275)
        Me.TxtStockUpdate.Name = "TxtStockUpdate"
        Me.TxtStockUpdate.Size = New System.Drawing.Size(150, 31)
        Me.TxtStockUpdate.TabIndex = 30
        '
        'TxtBarangUpdate
        '
        Me.TxtBarangUpdate.Location = New System.Drawing.Point(372, 220)
        Me.TxtBarangUpdate.Name = "TxtBarangUpdate"
        Me.TxtBarangUpdate.Size = New System.Drawing.Size(150, 31)
        Me.TxtBarangUpdate.TabIndex = 29
        '
        'TxtJenisUpdate
        '
        Me.TxtJenisUpdate.Location = New System.Drawing.Point(372, 167)
        Me.TxtJenisUpdate.Name = "TxtJenisUpdate"
        Me.TxtJenisUpdate.Size = New System.Drawing.Size(150, 31)
        Me.TxtJenisUpdate.TabIndex = 28
        '
        'TxtIDBUpdate
        '
        Me.TxtIDBUpdate.Location = New System.Drawing.Point(372, 122)
        Me.TxtIDBUpdate.Name = "TxtIDBUpdate"
        Me.TxtIDBUpdate.Size = New System.Drawing.Size(150, 31)
        Me.TxtIDBUpdate.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 25)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ID jenis Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "ID Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(115, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Update Barang"
        '
        'UpdateBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnUpdateBarang)
        Me.Controls.Add(Me.TxtStockUpdate)
        Me.Controls.Add(Me.TxtBarangUpdate)
        Me.Controls.Add(Me.TxtJenisUpdate)
        Me.Controls.Add(Me.TxtIDBUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateBarang"
        Me.Text = "UpdateBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnUpdateBarang As Button
    Friend WithEvents TxtStockUpdate As TextBox
    Friend WithEvents TxtBarangUpdate As TextBox
    Friend WithEvents TxtJenisUpdate As TextBox
    Friend WithEvents TxtIDBUpdate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
