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
        If CbBarang.Text = "Pilih Barang" Then
            MessageBox.Show("Pilih Barang Masuk!")
        ElseIf TxtJumlah.Text.Length < 1 Then
            TxtJumlah.Select()
            MessageBox.Show("Please add at least 1 number")
        Else
            FungsiBarangMasuk.GSNamaBarang = CbBarang.Text
            FungsiBarangMasuk.GSjumlah = Integer.Parse(TxtJumlah.Text)
            FungsiBarangMasuk.GStglmasuk = DateTimePicker1.Value.ToShortDateString

            FungsiBarangMasuk.AddDataBarang(FungsiBarangMasuk.GSNamaBarang, FungsiBarangMasuk.GSjumlah, FungsiBarangMasuk.GStglmasuk)
            FungsiBarangMasuk.InsertStockBarang(FungsiBarangMasuk.GSNamaBarang, FungsiBarangMasuk.GSjumlah)

            Barang.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TxtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJumlah.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If

    End Sub

    'Private Sub TxtJumlah_Leave(sender As Object, e As EventArgs) Handles TxtJumlah.Leave
    '    If TxtJumlah.Text.Length < 1 Then
    '        TxtJumlah.Select()
    '        MessageBox.Show("Please add at least 1 number")
    '    End If
    'End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        Barang.Show()
        Me.Close()

    End Sub
End Class