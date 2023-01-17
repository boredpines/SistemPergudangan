Imports MySql

Public Class TambahBarang
    Dim datas As New List(Of String)
    Public Shared fungsiBarang As FungsiBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fungsiBarang = New FungsiBarang()
    End Sub

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
        fungsiBarang.GSNama = TxtBarang.Text
        fungsiBarang.GSStock = TxtStock.Text
        fungsiBarang.GSnamajenis = cbjenisbarang.SelectedItem

        fungsiBarang.AddDataBarangDatabase(fungsiBarang.GSNama, fungsiBarang.GSStock, fungsiBarang.GSnamajenis)

        Dim main = New MainMenu()
        main.Show()
        Me.Hide()
    End Sub

    Private Sub TambahBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cbjenisbarang.Text = "Pilih Barang"
        datas = fungsiBarang.GetData()
        cbjenisbarang.Items.Clear()
        For Each dataa In datas
            cbjenisbarang.Items.Add(dataa)
        Next
        datas.Clear()
    End Sub

    Private Sub TxtStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub
End Class