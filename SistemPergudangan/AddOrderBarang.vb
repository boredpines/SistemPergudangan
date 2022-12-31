Public Class AddOrderBarang
    Dim status
    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        Order.DataOrder.GSTanggalOrder = DateTimePickerOrder.Value.ToString
        Order.DataOrder.GSJumlahOrder = TextBoxJmlhOrder.Text
        Order.DataOrder.GSStatus = status
        Order.DataOrder.GSIdBarang = TextBoxIDBarang.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        status = "Aktif"
    End Sub

    Private Sub RadioButton0_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton0.CheckedChanged
        status = "terpenuhi"
    End Sub
End Class