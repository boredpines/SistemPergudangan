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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butlogin = New System.Windows.Forms.Button()
        Me.butreg = New System.Windows.Forms.Button()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(709, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIGN IN"
        '
        'butlogin
        '
        Me.butlogin.AutoSize = True
        Me.butlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.butlogin.BackColor = System.Drawing.Color.DodgerBlue
        Me.butlogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.butlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butlogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butlogin.ForeColor = System.Drawing.Color.White
        Me.butlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butlogin.Location = New System.Drawing.Point(756, 337)
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
        Me.butreg.BackColor = System.Drawing.Color.DodgerBlue
        Me.butreg.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.butreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butreg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.butreg.ForeColor = System.Drawing.Color.White
        Me.butreg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butreg.Location = New System.Drawing.Point(861, 337)
        Me.butreg.Name = "butreg"
        Me.butreg.Size = New System.Drawing.Size(94, 33)
        Me.butreg.TabIndex = 2
        Me.butreg.Text = "REGISTER"
        Me.butreg.UseVisualStyleBackColor = False
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(662, 194)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(293, 23)
        Me.txtuname.TabIndex = 3
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(662, 261)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(293, 23)
        Me.txtpass.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(573, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(577, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(527, 525)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(137, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(227, 45)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "WELCOME TO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(494, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "THE WAREHOUSE MANAGEMENT SYSTEM"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 525)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.butreg)
        Me.Controls.Add(Me.butlogin)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
