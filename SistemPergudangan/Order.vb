Public Class Order
    Public Shared DataOrder As DataOrder
    Public Shared selectedTableOrder
    Public Shared selectedTableOrderStatus
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim pindah = New AddOrderBarang()
        pindah.Show()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddOrderBarangToolStripMenuItem.Click
        Dim pindah = New AddOrderBarang()
        pindah.Show()
    End Sub

    Private Sub BtnRmv_Click(sender As Object, e As EventArgs) Handles BtnRmv.Click
        If ListBoxOrder.SelectedIndex >= 0 Then
            DataOrder.GSdelete = ListBoxOrder.SelectedItem()
            Dim pindah = New HapusOrder()
            pindah.Show()
        Else
            MessageBox.Show("Pilih data terlebih dahulu")
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        Dim FormHapus = New HapusOrder()
        FormHapus.Show()
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim selectedorder As List(Of String) = DataOrder.GetDataKoleksiIDDatabase(selectedTableOrder)

        DataOrder.GSTanggalOrder = selectedorder(1)
        DataOrder.GSJumlahOrder = selectedorder(2)
        DataOrder.GSStatus = selectedorder(3)

        Dim InfoTambah = New AddOrderBarang()
        InfoTambah.Show()
    End Sub
End Class