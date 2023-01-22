Public Class Barang

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
End Class
