Public Class HapusBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LblBarang.Text = MainMenu.selectedTableBarangNama.ToString()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        MainMenu.datagudang.DeleteDataKoleksiByIDDatabase(MainMenu.selectedTableBarang)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class