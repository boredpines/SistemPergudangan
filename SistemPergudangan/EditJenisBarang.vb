Public Class EditJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtupjenis.Text = JenisBarang.Jenis_Barang.GSNamaJenis
        txtupjumlah.Text = JenisBarang.Jenis_Barang.GSjumlah
        cbupsatuan.SelectedItem = JenisBarang.Jenis_Barang.GSSatuanJenis

    End Sub
    Private Sub BtnCloseJenisUpdate_Click(sender As Object, e As EventArgs) Handles BtnCloseJenisUpdate.Click
        JenisBarang.Show()
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        JenisBarang.Jenis_Barang.GSNamaJenis = txtupjenis.Text.ToString()
        JenisBarang.Jenis_Barang.GSjumlah = Integer.Parse(txtupjumlah.Text)
        JenisBarang.Jenis_Barang.GSSatuanJenis = cbupsatuan.Text.ToString()

        If cbupsatuan.Text = "" Then
            MessageBox.Show("Harap pilih satuan jenis!")
        Else
            JenisBarang.Jenis_Barang.UpdateDataJenisByID(JenisBarang.selectedTableKoleksiDB,
                                                    JenisBarang.Jenis_Barang.GSNamaJenis,
                                                    JenisBarang.Jenis_Barang.GSjumlah,
                                                    JenisBarang.Jenis_Barang.GSSatuanJenis)
            Dim back = New JenisBarang()
            back.Show()
            Me.Close()
        End If

    End Sub

    Private Sub txtupjenis_Leave(sender As Object, e As EventArgs) Handles txtupjenis.Leave
        If txtupjenis.Text.Length < 1 Then
            txtupjenis.Select()
            MessageBox.Show("Do Not leave this field empty!")
        End If
    End Sub

    Private Sub txtupjumlah_Leave(sender As Object, e As EventArgs) Handles txtupjumlah.Leave
        If txtupjumlah.Text.Length < 1 Then
            txtupjumlah.Select()
            MessageBox.Show("Do Not leave this field empty!")
        End If

    End Sub

    Private Sub txtupjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtupjumlah.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If

    End Sub

End Class