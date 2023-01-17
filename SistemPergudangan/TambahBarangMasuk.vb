Public Class TambahBarangMasuk
    Dim datas As New List(Of String)
    Public Shared FungsiBarangMasuk As FungsiBarangMasuk

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FungsiBarangMasuk = New FungsiBarangMasuk()
    End Sub

    Private Sub TambahBarangMasuk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        CbBarang.Text = "Pilih Barang"
        datas = FungsiBarangMasuk.GetData()
        CbBarang.Items.Clear()
        For Each dataa In datas
            CbBarang.Items.Add(dataa)
        Next
        datas.Clear()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        FungsiBarangMasuk.GSNamaBarang = CbBarang.Text
        FungsiBarangMasuk.GSjumlah = TxtJumlah.Text

        FungsiBarangMasuk.AddDataBarang(FungsiBarangMasuk.GSNamaBarang, FungsiBarangMasuk.GSjumlah)
        TxtJumlah.Text = ""
    End Sub
End Class