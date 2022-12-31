<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.tbuname = New System.Windows.Forms.TextBox()
        Me.btnreg = New System.Windows.Forms.Button()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Username"
        '
        'tbpass
        '
        Me.tbpass.Location = New System.Drawing.Point(115, 170)
        Me.tbpass.Name = "tbpass"
        Me.tbpass.Size = New System.Drawing.Size(296, 23)
        Me.tbpass.TabIndex = 11
        '
        'tbuname
        '
        Me.tbuname.Location = New System.Drawing.Point(115, 125)
        Me.tbuname.Name = "tbuname"
        Me.tbuname.Size = New System.Drawing.Size(296, 23)
        Me.tbuname.TabIndex = 10
        '
        'btnreg
        '
        Me.btnreg.AutoSize = True
        Me.btnreg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnreg.BackColor = System.Drawing.Color.White
        Me.btnreg.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnreg.ForeColor = System.Drawing.Color.Black
        Me.btnreg.Location = New System.Drawing.Point(115, 237)
        Me.btnreg.Name = "btnreg"
        Me.btnreg.Size = New System.Drawing.Size(94, 33)
        Me.btnreg.TabIndex = 9
        Me.btnreg.Text = "REGISTER"
        Me.btnreg.UseVisualStyleBackColor = False
        '
        'btnlog
        '
        Me.btnlog.AutoSize = True
        Me.btnlog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnlog.BackColor = System.Drawing.Color.White
        Me.btnlog.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlog.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnlog.ForeColor = System.Drawing.Color.Black
        Me.btnlog.Location = New System.Drawing.Point(271, 237)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(140, 33)
        Me.btnlog.TabIndex = 8
        Me.btnlog.Text = "BACK TO LOGIN"
        Me.btnlog.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(115, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 45)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SIGN UP"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(225, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "OR"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 325)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbpass)
        Me.Controls.Add(Me.tbuname)
        Me.Controls.Add(Me.btnreg)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbpass As TextBox
    Friend WithEvents tbuname As TextBox
    Friend WithEvents btnreg As Button
    Friend WithEvents btnlog As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
