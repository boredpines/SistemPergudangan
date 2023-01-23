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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.White
        Me.BtnHapus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.Location = New System.Drawing.Point(265, 146)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(78, 29)
        Me.BtnHapus.TabIndex = 5
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'LabelHapusOrder
        '
        Me.LabelHapusOrder.AutoSize = True
        Me.LabelHapusOrder.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHapusOrder.ForeColor = System.Drawing.Color.IndianRed
        Me.LabelHapusOrder.Location = New System.Drawing.Point(31, 78)
        Me.LabelHapusOrder.Name = "LabelHapusOrder"
        Me.LabelHapusOrder.Size = New System.Drawing.Size(110, 34)
        Me.LabelHapusOrder.TabIndex = 4
        Me.LabelHapusOrder.Text = "ORDER"
        '
        'LabelKet
        '
        Me.LabelKet.AutoSize = True
        Me.LabelKet.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelKet.Location = New System.Drawing.Point(31, 33)
        Me.LabelKet.Name = "LabelKet"
        Me.LabelKet.Size = New System.Drawing.Size(413, 21)
        Me.LabelKet.TabIndex = 3
        Me.LabelKet.Text = "APAKAH ANDA YAKIN MENGHAPUS ORDER BARANG INI?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(366, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'HapusOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(480, 206)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LabelHapusOrder)
        Me.Controls.Add(Me.LabelKet)
        Me.MaximizeBox = False
        Me.Name = "HapusOrder"
        Me.Text = "HapusOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnHapus As Button
    Friend WithEvents LabelHapusOrder As Label
    Friend WithEvents LabelKet As Label
    Friend WithEvents Button1 As Button
End Class
