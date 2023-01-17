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
        Me.Close()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        JenisBarang.Jenis_Barang.GSNamaJenis = txtupjenis.Text.ToString()
        JenisBarang.Jenis_Barang.GSjumlah = Integer.Parse(txtupjumlah.Text)
        JenisBarang.Jenis_Barang.GSSatuanJenis = cbupsatuan.SelectedItem.ToString()

        JenisBarang.Jenis_Barang.UpdateDataJenisByID(JenisBarang.selectedTableKoleksiDB,
                                                    JenisBarang.Jenis_Barang.GSNamaJenis,
                                                    JenisBarang.Jenis_Barang.GSjumlah,
                                                    JenisBarang.Jenis_Barang.GSSatuanJenis)
        Dim back = New JenisBarang()
        back.Show()
        Me.Close()
    End Sub
End Class