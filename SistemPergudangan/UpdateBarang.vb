Imports MySql

Public Class UpdateBarang
    Dim datas As New List(Of String)
    Public Shared fungsiBarang As FungsiBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'TxtIDBUpdate.Text = MainMenu.datagudang.GSIDBarang
        'TxtJenisUpdate.Text = MainMenu.datagudang.GSIDJenis

        fungsiBarang = New FungsiBarang()
        TxtBarangUpdate.Text = MainMenu.datagudang.GSNama
        TxtStockUpdate.Text = MainMenu.datagudang.GSStock
        cbjenisup.Text = MainMenu.datagudang.GSnamajenis
    End Sub

    Private Sub BtnUpdateBarang_Click(sender As Object, e As EventArgs) Handles BtnUpdateBarang.Click

        'MainMenu.datagudang.GSIDBarang = Integer.Parse(TxtIDBUpdate.Text)
        'MainMenu.datagudang.GSIDJenis = Integer.Parse(TxtJenisUpdate.Text)

        MainMenu.datagudang.GSNama = TxtBarangUpdate.Text.ToString()
        MainMenu.datagudang.GSStock = Integer.Parse(TxtStockUpdate.Text)
        MainMenu.datagudang.GSnamajenis = cbjenisup.SelectedItem.ToString()

        MainMenu.datagudang.UpdateDataBarangByIDDatabase(MainMenu.selectedTableBarang,
                                                         MainMenu.datagudang.GSNama, MainMenu.datagudang.GSStock, MainMenu.datagudang.GSnamajenis)


        Dim infoBarang = New MainMenu()
        infoBarang.Show()
        Me.Close()
    End Sub

    Private Sub UpdateBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cbjenisup.Text = "Pilih Barang"
        datas = fungsiBarang.GetData()
        cbjenisup.Items.Clear()
        For Each dataa In datas
            cbjenisup.Items.Add(dataa)
        Next
        datas.Clear()

    End Sub

    Private Sub TxtStockUpdate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStockUpdate.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If

    End Sub

    Private Sub TxtBarangUpdate_Leave(sender As Object, e As EventArgs) Handles TxtBarangUpdate.Leave
        If TxtBarangUpdate.Text.Length < 1 Then
            TxtBarangUpdate.Select()
            MessageBox.Show("Do Not Leave This Field Empty!")
        End If

    End Sub
End Class