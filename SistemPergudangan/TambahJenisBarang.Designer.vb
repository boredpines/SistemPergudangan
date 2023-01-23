<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TambahJenisBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNamaJenis = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbSatuanJenis = New System.Windows.Forms.ComboBox()
        Me.BtnCloseJenis = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TAMBAH JENIS BARANG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(41, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Jenis Barang"
        '
        'TxtNamaJenis
        '
        Me.TxtNamaJenis.Location = New System.Drawing.Point(206, 94)
        Me.TxtNamaJenis.Name = "TxtNamaJenis"
        Me.TxtNamaJenis.Size = New System.Drawing.Size(211, 23)
        Me.TxtNamaJenis.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(43, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Satuan"
        '
        'CbSatuanJenis
        '
        Me.CbSatuanJenis.FormattingEnabled = True
        Me.CbSatuanJenis.Items.AddRange(New Object() {"Pcs", "Kilogram", "Gram", "Bungkus", "Buah"})
        Me.CbSatuanJenis.Location = New System.Drawing.Point(206, 134)
        Me.CbSatuanJenis.Name = "CbSatuanJenis"
        Me.CbSatuanJenis.Size = New System.Drawing.Size(211, 23)
        Me.CbSatuanJenis.TabIndex = 7
        '
        'BtnCloseJenis
        '
        Me.BtnCloseJenis.BackColor = System.Drawing.Color.White
        Me.BtnCloseJenis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCloseJenis.Location = New System.Drawing.Point(335, 234)
        Me.BtnCloseJenis.Name = "BtnCloseJenis"
        Me.BtnCloseJenis.Size = New System.Drawing.Size(82, 30)
        Me.BtnCloseJenis.TabIndex = 8
        Me.BtnCloseJenis.Text = "Cancel"
        Me.BtnCloseJenis.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.White
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdd.Location = New System.Drawing.Point(228, 234)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(82, 30)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Tambah"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(41, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Jumlah"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(206, 176)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(211, 23)
        Me.txtjumlah.TabIndex = 11
        '
        'TambahJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(457, 306)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnCloseJenis)
        Me.Controls.Add(Me.CbSatuanJenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNamaJenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MaximizeBox = False
        Me.Name = "TambahJenisBarang"
        Me.Text = "TambahJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNamaJenis As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbSatuanJenis As ComboBox
    Friend WithEvents BtnCloseJenis As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjumlah As TextBox
End Class
