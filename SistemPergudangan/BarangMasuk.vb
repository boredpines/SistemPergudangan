Public Class Barang
    Public Shared incoming As FungsiBarangMasuk
    Public Shared selectedTableMasuk As Integer
    Public Shared selectedTableMasukNama As String
    Dim selectedRow As DataGridViewRow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        incoming = New FungsiBarangMasuk()
        reloadtablemasuk()

    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        Dim main = New MainMenu()
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim add = New TambahBarangMasuk()
        add.Show()
        Me.Hide()
    End Sub

    Private Sub reloadtablemasuk()
        DataGridView1.DataSource = incoming.GetDataMasukDatabase
    End Sub

    Private Sub btnhapusinc_Click(sender As Object, e As EventArgs) Handles btnhapusinc.Click
        Try
            If selectedRow IsNot Nothing Then
                HapusBarangMasuk.LblHapus.Text = selectedTableMasukNama
                Dim delform = New HapusBarangMasuk()
                delform.Show()
            Else
                MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
            End If

        Catch ex As Exception
            MessageBox.Show("..")
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer = e.RowIndex

        selectedRow = DataGridView1.Rows(index)
        selectedTableMasuk = selectedRow.Cells(0).Value

        If Not IsDBNull(selectedRow.Cells(1).Value) Then
            selectedTableMasukNama = selectedRow.Cells(1).Value
        Else
            selectedTableMasukNama = ""
        End If
    End Sub

    Private Sub Barang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        reloadtablemasuk()
    End Sub
End Class
