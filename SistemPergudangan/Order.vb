Public Class Order
    Public Shared DataOrder As DataOrder
    Public Shared selectedTableOrder
    Public Shared selectedTableOrderStatus
    Dim stok As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DataOrder = New DataOrder()
        reloadtableorder()

    End Sub


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim pindah = New AddOrderBarang()
        pindah.Show()
        Me.Hide()

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

    Private Sub reloadtableorder()

        DataGridOrder.DataSource = DataOrder.GetDataOrderDatabase

    End Sub

    Private Sub Order_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For Each iota In DataOrder.GetOrderSum().Rows
            If iota(0) >= iota(1) Then
                DataOrder.UpdateStatusAktif(iota(2))
            ElseIf iota(0) < iota(1) Then
                DataOrder.UpdateStatusFilled(iota(2))
            End If
        Next

        reloadtableorder()
    End Sub

    Private Sub btntest_Click(sender As Object, e As EventArgs) Handles btntest.Click
        For Each iota In DataOrder.GetOrderSum().Rows
            If iota(0) >= iota(1) Then
                DataOrder.UpdateStatusAktif(iota(2))
            ElseIf iota(0) < iota(1) Then
                DataOrder.UpdateStatusFilled(iota(2))
            End If
        Next
    End Sub
End Class