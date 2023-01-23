Public Class HapusJenisBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapusJenis.Text = JenisBarang.selectedTableKoleksiNama.ToString()

    End Sub
    Private Sub BtnCloseHapus_Click(sender As Object, e As EventArgs) Handles BtnCloseHapus.Click
        Me.Close()
    End Sub

    Private Sub BtnHapusJenis_Click(sender As Object, e As EventArgs) Handles BtnHapusJenis.Click
        JenisBarang.Jenis_Barang.DeleteDataJenisByIDDatabase(JenisBarang.selectedTableKoleksiDB)
        Me.Close()
    End Sub

End Class