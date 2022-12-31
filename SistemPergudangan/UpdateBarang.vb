Public Class UpdateBarang
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TxtIDBUpdate.Text = MainMenu.datagudang.GSIDBarang
        TxtJenisUpdate.Text = MainMenu.datagudang.GSIDJenis
        TxtBarangUpdate.Text = MainMenu.datagudang.GSNama
        TxtStockUpdate.Text = MainMenu.datagudang.GSStock
    End Sub

    Private Sub BtnUpdateBarang_Click(sender As Object, e As EventArgs) Handles BtnUpdateBarang.Click
        MainMenu.datagudang.GSIDBarang = Integer.Parse(TxtIDBUpdate.Text)
        MainMenu.datagudang.GSIDJenis = Integer.Parse(TxtJenisUpdate.Text)
        MainMenu.datagudang.GSNama = TxtBarangUpdate.Text.ToString()
        MainMenu.datagudang.GSStock = Integer.Parse(TxtStockUpdate.Text)

        'Dim convertedBarang = MainMenu.datagudang.ConvertBarangToString(MainMenu.datagudang.getBarangDataTable)
        MainMenu.datagudang.UpdateDataBarangByIDDatabase(MainMenu.selectedTableBarang,
                                                         MainMenu.datagudang.GSIDBarang,
                                                         MainMenu.datagudang.GSIDJenis,
                                                         MainMenu.datagudang.GSNama,
                                                         MainMenu.datagudang.GSStock)


        Dim infoBarang = New InfoBarang()
        infoBarang.Show()
        Me.Close()
    End Sub
End Class