<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusBarangMasuk
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnYa = New System.Windows.Forms.Button()
        Me.BtnTidak = New System.Windows.Forms.Button()
        Me.LblHapus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(93, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "APAKAH ANDA YAKIN INGIN MENGHAPUS JENIS BARANG INI?"
        '
        'BtnYa
        '
        Me.BtnYa.Location = New System.Drawing.Point(209, 224)
        Me.BtnYa.Name = "BtnYa"
        Me.BtnYa.Size = New System.Drawing.Size(75, 23)
        Me.BtnYa.TabIndex = 2
        Me.BtnYa.Text = "Hapus"
        Me.BtnYa.UseVisualStyleBackColor = True
        '
        'BtnTidak
        '
        Me.BtnTidak.Location = New System.Drawing.Point(327, 224)
        Me.BtnTidak.Name = "BtnTidak"
        Me.BtnTidak.Size = New System.Drawing.Size(75, 23)
        Me.BtnTidak.TabIndex = 3
        Me.BtnTidak.Text = "Cancel"
        Me.BtnTidak.UseVisualStyleBackColor = True
        '
        'LblHapus
        '
        Me.LblHapus.AutoSize = True
        Me.LblHapus.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHapus.ForeColor = System.Drawing.Color.Red
        Me.LblHapus.Location = New System.Drawing.Point(209, 127)
        Me.LblHapus.Name = "LblHapus"
        Me.LblHapus.Size = New System.Drawing.Size(193, 28)
        Me.LblHapus.TabIndex = 4
        Me.LblHapus.Text = "BARANG MASUK"
        '
        'HapusBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 273)
        Me.Controls.Add(Me.LblHapus)
        Me.Controls.Add(Me.BtnTidak)
        Me.Controls.Add(Me.BtnYa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusBarangMasuk"
        Me.Text = "HapusBarangMasuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnYa As Button
    Friend WithEvents BtnTidak As Button
    Friend WithEvents LblHapus As Label
End Class
