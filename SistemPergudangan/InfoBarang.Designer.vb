<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoBarang
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
        Me.BtnCLose = New System.Windows.Forms.Button()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblBarangValue = New System.Windows.Forms.Label()
        Me.LblIDJenisValue = New System.Windows.Forms.Label()
        Me.LblIDBrgValue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCLose
        '
        Me.BtnCLose.Location = New System.Drawing.Point(560, 335)
        Me.BtnCLose.Name = "BtnCLose"
        Me.BtnCLose.Size = New System.Drawing.Size(112, 34)
        Me.BtnCLose.TabIndex = 20
        Me.BtnCLose.Text = "CLose"
        Me.BtnCLose.UseVisualStyleBackColor = True
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(388, 284)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(24, 25)
        Me.LblStock.TabIndex = 19
        Me.LblStock.Text = "..."
        '
        'LblBarangValue
        '
        Me.LblBarangValue.AutoSize = True
        Me.LblBarangValue.Location = New System.Drawing.Point(388, 234)
        Me.LblBarangValue.Name = "LblBarangValue"
        Me.LblBarangValue.Size = New System.Drawing.Size(24, 25)
        Me.LblBarangValue.TabIndex = 18
        Me.LblBarangValue.Text = "..."
        '
        'LblIDJenisValue
        '
        Me.LblIDJenisValue.AutoSize = True
        Me.LblIDJenisValue.Location = New System.Drawing.Point(388, 187)
        Me.LblIDJenisValue.Name = "LblIDJenisValue"
        Me.LblIDJenisValue.Size = New System.Drawing.Size(24, 25)
        Me.LblIDJenisValue.TabIndex = 17
        Me.LblIDJenisValue.Text = "..."
        '
        'LblIDBrgValue
        '
        Me.LblIDBrgValue.AutoSize = True
        Me.LblIDBrgValue.Location = New System.Drawing.Point(388, 139)
        Me.LblIDBrgValue.Name = "LblIDBrgValue"
        Me.LblIDBrgValue.Size = New System.Drawing.Size(24, 25)
        Me.LblIDBrgValue.TabIndex = 16
        Me.LblIDBrgValue.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(232, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "ID Jenis Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(232, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ID Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(128, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Info Barang"
        '
        'InfoBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCLose)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.LblBarangValue)
        Me.Controls.Add(Me.LblIDJenisValue)
        Me.Controls.Add(Me.LblIDBrgValue)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InfoBarang"
        Me.Text = "InfoBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCLose As Button
    Friend WithEvents LblStock As Label
    Friend WithEvents LblBarangValue As Label
    Friend WithEvents LblIDJenisValue As Label
    Friend WithEvents LblIDBrgValue As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
