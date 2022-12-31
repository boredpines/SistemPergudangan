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
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.CbSatuanJenis = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNamaJenis = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdJenis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCloseJenisUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdd.Location = New System.Drawing.Point(234, 289)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 19
        Me.BtnAdd.Text = "Update"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'CbSatuanJenis
        '
        Me.CbSatuanJenis.FormattingEnabled = True
        Me.CbSatuanJenis.Items.AddRange(New Object() {"PCS", "Kilogram", "Gram", "Bungkus", "Buah"})
        Me.CbSatuanJenis.Location = New System.Drawing.Point(234, 216)
        Me.CbSatuanJenis.Name = "CbSatuanJenis"
        Me.CbSatuanJenis.Size = New System.Drawing.Size(262, 23)
        Me.CbSatuanJenis.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(36, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Satuan :"
        '
        'TxtNamaJenis
        '
        Me.TxtNamaJenis.Location = New System.Drawing.Point(234, 156)
        Me.TxtNamaJenis.Name = "TxtNamaJenis"
        Me.TxtNamaJenis.Size = New System.Drawing.Size(262, 23)
        Me.TxtNamaJenis.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(36, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 14)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nama Jenis Barang :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(36, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ID Jenis Barang :"
        '
        'TxtIdJenis
        '
        Me.TxtIdJenis.Location = New System.Drawing.Point(234, 106)
        Me.TxtIdJenis.Name = "TxtIdJenis"
        Me.TxtIdJenis.Size = New System.Drawing.Size(262, 23)
        Me.TxtIdJenis.TabIndex = 13
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
        Me.BtnCloseJenisUpdate.Location = New System.Drawing.Point(462, 403)
        Me.BtnCloseJenisUpdate.Name = "BtnCloseJenisUpdate"
        Me.BtnCloseJenisUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCloseJenisUpdate.TabIndex = 22
        Me.BtnCloseJenisUpdate.Text = "Close"
        Me.BtnCloseJenisUpdate.UseVisualStyleBackColor = True
        '
        'EditJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 438)
        Me.Controls.Add(Me.BtnCloseJenisUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.CbSatuanJenis)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNamaJenis)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIdJenis)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditJenisBarang"
        Me.Text = "EditJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAdd As Button
    Friend WithEvents CbSatuanJenis As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNamaJenis As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdJenis As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCloseJenisUpdate As Button
End Class
