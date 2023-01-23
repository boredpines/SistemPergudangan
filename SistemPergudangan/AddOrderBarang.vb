Imports MySql

Public Class AddOrderBarang
    Dim datas As New List(Of String)
    Public Shared order As DataOrder
    Dim stok As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        order = New DataOrder()

    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        If cbnamabarang.Text = "Pilih Barang" Then
            MessageBox.Show("Silahkan Pilih Barang!")
        Else
            order.GSnamabarang = cbnamabarang.SelectedItem.ToString
            order.GSTanggalOrder = dateorder.Value.ToShortDateString
            order.GSJumlahOrder = txtjumlahorder.Text
            stok = order.GetPrevSum(cbnamabarang.Text)

            If order.CheckStatus(stok, txtjumlahorder.Text) Then
                order.AddMasukFilled(order.GSnamabarang, order.GSJumlahOrder, order.GSTanggalOrder)
            Else
                order.AddMasukAktif(order.GSnamabarang, order.GSJumlahOrder, order.GSTanggalOrder)
            End If

            Dim bac = New Order()
            bac.Show()
            Me.Close()
        End If
    End Sub

    Private Sub AddOrderBarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cbnamabarang.Text = "Pilih Barang"
        datas = order.GetData()
        cbnamabarang.Items.Clear()
        For Each dataa In datas
            cbnamabarang.Items.Add(dataa)
        Next
        datas.Clear()

    End Sub

    Private Sub txtjumlahorder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlahorder.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Please Insert Number Only")
        End If
    End Sub

    Private Sub txtjumlahorder_Leave(sender As Object, e As EventArgs) Handles txtjumlahorder.Leave
        If txtjumlahorder.Text.Length < 1 Then
            txtjumlahorder.Select()
            MessageBox.Show("Please add at least 1 number")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bac = New Order()
        bac.Show()
        Me.Close()
    End Sub
End Class