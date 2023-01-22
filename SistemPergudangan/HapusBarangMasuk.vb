Public Class HapusBarangMasuk

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblHapus.Text = Barang.selectedTableMasukNama.ToString()

    End Sub
    Private Sub BtnYa_Click(sender As Object, e As EventArgs) Handles BtnYa.Click
        Barang.incoming.DeleteDataMasukByIDDatabase(Barang.selectedTableMasuk)
        Me.Close()

    End Sub

    Private Sub BtnTidak_Click(sender As Object, e As EventArgs) Handles BtnTidak.Click
        Me.Close()

    End Sub
End Class