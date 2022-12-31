Public Class EditJenisBarang
    Private Sub BtnCloseJenisUpdate_Click(sender As Object, e As EventArgs) Handles BtnCloseJenisUpdate.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        JenisBarang.JenisBarang.GSIdJenis = Integer.Parse(TxtIdJenis.Text)
        JenisBarang.JenisBarang.GSNamaJenis = TxtNamaJenis.Text.ToString()
        JenisBarang.JenisBarang.GSSatuanJenis = CbSatuanJenis.SelectedItem().ToString()
    End Sub
End Class