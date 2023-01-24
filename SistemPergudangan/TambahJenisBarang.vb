Imports System.IO
Public Class TambahJenisBarang


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        JenisBarang.Jenis_Barang = New jenis_barang

    End Sub

    Private Sub BtnCloseJenis_Click(sender As Object, e As EventArgs) Handles BtnCloseJenis.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If CbSatuanJenis.Text = "" Then
            MsgBox("Harap Pilih satuan!", MsgBoxStyle.Critical, "Error")
        Else
            JenisBarang.Jenis_Barang.GSNamaJenis = TxtNamaJenis.Text
            JenisBarang.Jenis_Barang.GSjumlah = Integer.Parse(txtjumlah.Text)
            JenisBarang.Jenis_Barang.GSSatuanJenis = CbSatuanJenis.SelectedItem
            JenisBarang.Jenis_Barang.AddDataJenisDatabase(JenisBarang.Jenis_Barang.GSNamaJenis,
                                                          JenisBarang.Jenis_Barang.GSjumlah,
                                                          JenisBarang.Jenis_Barang.GSSatuanJenis)

            Dim back = New JenisBarang()
            Me.Close()
            back.Show()
        End If

    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("Harap Masukan Angka")
        End If

    End Sub

    Private Sub txtjumlah_Leave(sender As Object, e As EventArgs) Handles txtjumlah.Leave
        If txtjumlah.Text.Length < 1 Then
            txtjumlah.Select()
            MessageBox.Show("Please add At least 1 Number")
        End If

    End Sub

    Private Sub TxtNamaJenis_Leave(sender As Object, e As EventArgs) Handles TxtNamaJenis.Leave
        If TxtNamaJenis.Text.Length < 1 Then
            TxtNamaJenis.Select()
            MessageBox.Show("Do Not leave this filed empty!")
        End If

    End Sub

    'Public Function validationItemData()
    '    Dim errMessage As String

    '    If JenisBarang.Jenis_Barang.GSNamaJenis.Length = 0 Then
    '        errMessage = "Harap tulis nama jenisnya!"
    '    ElseIf JenisBarang.Jenis_Barang.GSjumlah = 0 Then
    '        errMessage = "Harap masukkan jumlahnya!"
    '    ElseIf JenisBarang.Jenis_Barang.GSSatuanJenis.Length = 0 Then
    '        errMessage = "Harap pilih satuannya!"
    '    End If
    '    Return errMessage
    'End Function

End Class