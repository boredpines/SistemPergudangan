<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.butlogin = New System.Windows.Forms.Button()
        Me.butreg = New System.Windows.Forms.Button()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(116, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIGN IN"
        '
        'butlogin
        '
        Me.butlogin.AutoSize = True
        Me.butlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.butlogin.BackColor = System.Drawing.Color.White
        Me.butlogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.butlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butlogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butlogin.ForeColor = System.Drawing.Color.Black
        Me.butlogin.Location = New System.Drawing.Point(116, 240)
        Me.butlogin.Name = "butlogin"
        Me.butlogin.Size = New System.Drawing.Size(71, 33)
        Me.butlogin.TabIndex = 1
        Me.butlogin.Text = "LOGIN"
        Me.butlogin.UseVisualStyleBackColor = False
        '
        'butreg
        '
        Me.butreg.AutoSize = True
        Me.butreg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.butreg.BackColor = System.Drawing.Color.White
        Me.butreg.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.butreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butreg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butreg.ForeColor = System.Drawing.Color.Black
        Me.butreg.Location = New System.Drawing.Point(244, 240)
        Me.butreg.Name = "butreg"
        Me.butreg.Size = New System.Drawing.Size(94, 33)
        Me.butreg.TabIndex = 2
        Me.butreg.Text = "REGISTER"
        Me.butreg.UseVisualStyleBackColor = False
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(116, 128)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(293, 23)
        Me.txtuname.TabIndex = 3
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(116, 173)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(293, 23)
        Me.txtpass.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(203, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "OR"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(468, 325)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.butreg)
        Me.Controls.Add(Me.butlogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents butlogin As Button
    Friend WithEvents butreg As Button
    Friend WithEvents txtuname As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
