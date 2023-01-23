Public Class HapusOrder
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LabelHapusOrder.Text = Order.selectedTableOrderNama.ToString()

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Order.DataOrder.DeleteDataOrderByIDDatabase(Order.selectedTableOrder)
        Me.Close()
    End Sub
End Class