<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusOrder
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
        Me.LabelHapusOrder = New System.Windows.Forms.Label()
        Me.LabelKet = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(336, 208)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'LabelHapusOrder
        '
        Me.LabelHapusOrder.AutoSize = True
        Me.LabelHapusOrder.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHapusOrder.ForeColor = System.Drawing.Color.IndianRed
        Me.LabelHapusOrder.Location = New System.Drawing.Point(327, 126)
        Me.LabelHapusOrder.Name = "LabelHapusOrder"
        Me.LabelHapusOrder.Size = New System.Drawing.Size(93, 45)
        Me.LabelHapusOrder.TabIndex = 4
        Me.LabelHapusOrder.Text = "TEST"
        '
        'LabelKet
        '
        Me.LabelKet.AutoSize = True
        Me.LabelKet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelKet.Location = New System.Drawing.Point(180, 63)
        Me.LabelKet.Name = "LabelKet"
        Me.LabelKet.Size = New System.Drawing.Size(416, 19)
        Me.LabelKet.TabIndex = 3
        Me.LabelKet.Text = "APAKAH ANDA YAKIN MENGHAPUS ORDER BARANG"
        '
        'HapusOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 288)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LabelHapusOrder)
        Me.Controls.Add(Me.LabelKet)
        Me.Name = "HapusOrder"
        Me.Text = "HapusOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents LabelHapusOrder As Label
    Friend WithEvents LabelKet As Label
End Class
