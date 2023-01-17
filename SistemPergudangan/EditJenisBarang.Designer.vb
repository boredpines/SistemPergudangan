<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJenisBarang
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
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.cbupsatuan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtupjenis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtupjumlah = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCloseJenisUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnupdate.Location = New System.Drawing.Point(248, 261)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 19
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'cbupsatuan
        '
        Me.cbupsatuan.FormattingEnabled = True
        Me.cbupsatuan.Items.AddRange(New Object() {"PCS", "Kilogram", "Gram", "Bungkus", "Buah"})
        Me.cbupsatuan.Location = New System.Drawing.Point(248, 149)
        Me.cbupsatuan.Name = "cbupsatuan"
        Me.cbupsatuan.Size = New System.Drawing.Size(262, 23)
        Me.cbupsatuan.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(50, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Satuan :"
        '
        'txtupjenis
        '
        Me.txtupjenis.Location = New System.Drawing.Point(248, 103)
        Me.txtupjenis.Name = "txtupjenis"
        Me.txtupjenis.Size = New System.Drawing.Size(262, 23)
        Me.txtupjenis.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(50, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nama Jenis Barang :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(50, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Jumlah :"
        '
        'txtupjumlah
        '
        Me.txtupjumlah.Location = New System.Drawing.Point(248, 196)
        Me.txtupjumlah.Name = "txtupjumlah"
        Me.txtupjumlah.Size = New System.Drawing.Size(262, 23)
        Me.txtupjumlah.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(179, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "EDIT JENIS BARANG"
        '
        'BtnCloseJenisUpdate
        '
        Me.BtnCloseJenisUpdate.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCloseJenisUpdate.Location = New System.Drawing.Point(344, 261)
        Me.BtnCloseJenisUpdate.Name = "BtnCloseJenisUpdate"
        Me.BtnCloseJenisUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCloseJenisUpdate.TabIndex = 22
        Me.BtnCloseJenisUpdate.Text = "Cancel"
        Me.BtnCloseJenisUpdate.UseVisualStyleBackColor = True
        '
        'EditJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 320)
        Me.Controls.Add(Me.BtnCloseJenisUpdate)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.cbupsatuan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtupjenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtupjumlah)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditJenisBarang"
        Me.Text = "EditJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnupdate As Button
    Friend WithEvents cbupsatuan As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtupjenis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtupjumlah As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCloseJenisUpdate As Button
End Class
