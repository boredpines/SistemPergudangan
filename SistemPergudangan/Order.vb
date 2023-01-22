Public Class Order
    Public Shared DataOrder As DataOrder
    Public Shared selectedTableOrder
    Public Shared selectedTableOrderStatus


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim pindah = New AddOrderBarang()
        pindah.Show()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim pindah = New AddOrderBarang()
        pindah.Show()
    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        Dim main = New MainMenu()
        main.Show()
        Me.Hide()

    End Sub

End Class