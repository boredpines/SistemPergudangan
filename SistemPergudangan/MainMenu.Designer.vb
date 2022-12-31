<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.DataGridBarang = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(148, 34)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(530, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 33)
        Me.ComboBox1.TabIndex = 14
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(339, 410)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(112, 34)
        Me.BtnRemove.TabIndex = 13
        Me.BtnRemove.Text = "Remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(473, 410)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(112, 34)
        Me.BtnUpdate.TabIndex = 12
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(473, 364)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(112, 34)
        Me.BtnAdd.TabIndex = 11
        Me.BtnAdd.Text = "Add" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(339, 364)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(112, 34)
        Me.BtnSelect.TabIndex = 10
        Me.BtnSelect.Text = "Select" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'DataGridBarang
        '
        Me.DataGridBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBarang.Location = New System.Drawing.Point(12, 116)
        Me.DataGridBarang.Name = "DataGridBarang"
        Me.DataGridBarang.RowHeadersWidth = 62
        Me.DataGridBarang.RowTemplate.Height = 33
        Me.DataGridBarang.Size = New System.Drawing.Size(788, 225)
        Me.DataGridBarang.TabIndex = 9
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridBarang)
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents DataGridBarang As DataGridView
End Class
