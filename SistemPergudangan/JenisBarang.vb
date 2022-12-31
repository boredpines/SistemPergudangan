Imports Google.Protobuf.WellKnownTypes

Public Class JenisBarang
    Public Shared JenisBarang As jenis_barang
    Public Shared selectedTableJenisBarang
    Dim selectedTableJenis

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        JenisBarang = New jenis_barang()
        ' Add any initialization after the InitializeComponent() call.
        ReloadDataTableDatabase()
    End Sub



    Private Sub DgvJenisBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvJenisBarang.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DgvJenisBarang.Rows(index)

        selectedTableJenis = selectedRow.Cells(0).Value
        selectedTableJenisBarang = selectedRow.Cells(1).Value
    End Sub

    Private Sub ReloadDataTableDataBase()
        DgvJenisBarang.DataSource = JenisBarang.GetDataJenisDatabase()


    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim Edit = New EditJenisBarang()
        Edit.Show()
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim Hapus = New HapusJenisBarang()
        Hapus.Show()
    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Tambah = New TambahJenisBarang()
        Tambah.Show()
    End Sub
End Class