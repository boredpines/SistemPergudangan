<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusBarang
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
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.LblBarang = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(330, 289)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 34)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LblBarang
        '
        Me.LblBarang.AutoSize = True
        Me.LblBarang.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblBarang.ForeColor = System.Drawing.Color.Red
        Me.LblBarang.Location = New System.Drawing.Point(311, 199)
        Me.LblBarang.Name = "LblBarang"
        Me.LblBarang.Size = New System.Drawing.Size(166, 45)
        Me.LblBarang.TabIndex = 4
        Me.LblBarang.Text = "Barang A"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Apakah Anda Ingin Menghapus Barang ini ?"
        '
        'HapusBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblBarang)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusBarang"
        Me.Text = "HapusBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents LblBarang As Label
    Friend WithEvents Label1 As Label
End Class
