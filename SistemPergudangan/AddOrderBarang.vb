Public Class AddOrderBarang
    Dim status
    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        Order.DataOrder.GSTanggalOrder = DateTimePickerOrder.Value.ToString("yyyy/MM/dd")
        Order.DataOrder.GSJumlahOrder = TextBoxJmlhOrder.Text
        Order.DataOrder.GSStatus = status
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        status = "Aktif"
    End Sub

    Private Sub RadioButton0_CheckedChanged(sender As Object, e As EventArgs)
        status = "terpenuhi"
    End Sub

End Class