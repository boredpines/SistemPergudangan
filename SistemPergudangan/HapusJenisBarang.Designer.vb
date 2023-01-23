<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJenisBarang
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
        Me.LblHapusJenis = New System.Windows.Forms.Label()
        Me.BtnHapusJenis = New System.Windows.Forms.Button()
        Me.BtnCloseHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APAKAH ANDA YAKIN INGIN MENGHAPUS JENIS BARANG INI?"
        '
        'LblHapusJenis
        '
        Me.LblHapusJenis.AutoSize = True
        Me.LblHapusJenis.BackColor = System.Drawing.Color.Transparent
        Me.LblHapusJenis.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHapusJenis.ForeColor = System.Drawing.Color.IndianRed
        Me.LblHapusJenis.Location = New System.Drawing.Point(31, 85)
        Me.LblHapusJenis.Name = "LblHapusJenis"
        Me.LblHapusJenis.Size = New System.Drawing.Size(201, 37)
        Me.LblHapusJenis.TabIndex = 1
        Me.LblHapusJenis.Text = "Jenis Barang"
        '
        'BtnHapusJenis
        '
        Me.BtnHapusJenis.BackColor = System.Drawing.Color.White
        Me.BtnHapusJenis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusJenis.Location = New System.Drawing.Point(294, 159)
        Me.BtnHapusJenis.Name = "BtnHapusJenis"
        Me.BtnHapusJenis.Size = New System.Drawing.Size(79, 29)
        Me.BtnHapusJenis.TabIndex = 2
        Me.BtnHapusJenis.Text = "Hapus"
        Me.BtnHapusJenis.UseVisualStyleBackColor = False
        '
        'BtnCloseHapus
        '
        Me.BtnCloseHapus.BackColor = System.Drawing.Color.White
        Me.BtnCloseHapus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCloseHapus.Location = New System.Drawing.Point(398, 159)
        Me.BtnCloseHapus.Name = "BtnCloseHapus"
        Me.BtnCloseHapus.Size = New System.Drawing.Size(79, 29)
        Me.BtnCloseHapus.TabIndex = 3
        Me.BtnCloseHapus.Text = "Cancel"
        Me.BtnCloseHapus.UseVisualStyleBackColor = False
        '
        'HapusJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(515, 230)
        Me.Controls.Add(Me.BtnCloseHapus)
        Me.Controls.Add(Me.BtnHapusJenis)
        Me.Controls.Add(Me.LblHapusJenis)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "HapusJenisBarang"
        Me.Text = "HapusJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblHapusJenis As Label
    Friend WithEvents BtnHapusJenis As Button
    Friend WithEvents BtnCloseHapus As Button
End Class
