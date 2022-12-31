Public Class TambahBarang
    Private Sub TxtBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBarang.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert String Only")
        End If
    End Sub

    Private Sub TxtBarang_Leave(sender As Object, e As EventArgs) Handles TxtBarang.Leave
        If TxtBarang.Text.Length < 1 Then
            TxtBarang.Select()
            MessageBox.Show("Please add At least 1 String")
        End If
    End Sub

    Private Sub BtnAddBarang_Click(sender As Object, e As EventArgs) Handles BtnAddBarang.Click
        MainMenu.datagudang.GSIDBarang = TxtIDB.Text
        MainMenu.datagudang.GSIDJenis = TxtJenis.Text
        MainMenu.datagudang.GSNama = TxtBarang.Text
        MainMenu.datagudang.GSStock = TxtStock.Text

        MainMenu.datagudang.AddDataBarangDatabase(MainMenu.datagudang.GSIDBarang, MainMenu.datagudang.GSIDJenis, MainMenu.datagudang.GSNama, MainMenu.datagudang.GSStock)


        Dim tambahbarang = New InfoBarang()
        tambahbarang.Show()

        Dim add_item = MainMenu.datagudang.GSNama
        MainMenu.listKoleksi.Add(add_item)

        Me.Close()
    End Sub
End Class