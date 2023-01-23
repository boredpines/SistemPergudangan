Imports Google.Protobuf.WellKnownTypes

Public Class JenisBarang

    Public Shared Jenis_Barang As jenis_barang
    Public Shared selected As String
    Public selectedTableKoleksi As Integer
    Public selectedTableKoleksiDB As Integer
    Public selectedTableKoleksiNama As String
    Dim selectedRow As DataGridViewRow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Jenis_Barang = New jenis_barang()
        ' Add any initialization after the InitializeComponent() call.
        reloaddatatable()
    End Sub

    Private Sub DgvJenisBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvJenisBarang.CellClick
        Dim index As Integer = e.RowIndex

        selectedRow = DgvJenisBarang.Rows(index)
        selectedTableKoleksiDB = selectedRow.Cells(0).Value

        If Not IsDBNull(selectedRow.Cells(1).Value) Then
            selectedTableKoleksiNama = selectedRow.Cells(1).Value
        Else
            selectedTableKoleksiNama = ""
        End If

    End Sub
    Public Sub showselectedDB()
        Dim selectedKoleksi As List(Of String) = Jenis_Barang.GetDataJenisById(selectedTableKoleksiDB)
        Jenis_Barang.GSNamaJenis = selectedKoleksi(1)
        Jenis_Barang.GSjumlah = selectedKoleksi(2)
        Jenis_Barang.GSSatuanJenis = selectedKoleksi(3)

    End Sub
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim add = New TambahJenisBarang
        add.Show()
    End Sub

    Private Sub JenisBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloaddatatable()
    End Sub
    Private Sub reloaddatatable()
        DgvJenisBarang.DataSource = Jenis_Barang.GetDataJenisDatabase()
    End Sub
    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If selectedRow IsNot Nothing Then
            HapusJenisBarang.LblHapusJenis.Text = selectedTableKoleksiNama
            Dim delform = New HapusJenisBarang()
            delform.Show()
        Else
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End If

    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            showselectedDB()
            EditJenisBarang.Show()

        Catch ex As Exception
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End Try

    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        Dim main = New MainMenu()
        main.Show()
        Me.Hide()

    End Sub
End Class