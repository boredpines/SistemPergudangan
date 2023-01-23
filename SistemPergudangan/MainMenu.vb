Imports System.Data.Common
Imports System.IO
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class MainMenu
    Public Shared datagudang As FungsiBarang
    Public Shared selectedTableBarang As Integer
    Public Shared selectedTableBarangNama As String
    Dim selectedRow As DataGridViewRow
    Dim selecteddatatable


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        datagudang = New FungsiBarang()

        ReloadDataTableDatabase()
    End Sub

    Private Sub MainMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    'Public Sub updateDataTableArrayList()
    '    DataGridBarang.Rows.Clear()
    '    For Each rowKoleksi In datagudang.getBarangDataTable()
    '        Dim dataTable As String() = {rowKoleksi(1),
    '                                     rowKoleksi(2),
    '                                     rowKoleksi(3),
    '                                     rowKoleksi(4)
    '        }
    '        DataGridBarang.Rows.Add(dataTable)
    '    Next
    'End Sub

    Private Sub DataGridBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBarang.CellClick
        Dim index As Integer = e.RowIndex

        selectedRow = DataGridBarang.Rows(index)
        selectedTableBarang = selectedRow.Cells(0).Value

        If Not IsDBNull(selectedRow.Cells(1).Value) Then
            selectedTableBarangNama = selectedRow.Cells(1).Value
        Else
            selectedTableBarangNama = ""
        End If

    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridBarang.DataSource = datagudang.GetDataBarangDatabase()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim formTambahBarang = New TambahBarang
        formTambahBarang.Show()
        Me.Hide()

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        Try
            Dim selectedBarang As List(Of String) = datagudang.GetDataBarangByIDDatabase(selectedTableBarang)

            datagudang.GSNama = selectedBarang(1)
            datagudang.GSStock = selectedBarang(2)
            datagudang.GSnamajenis = selectedBarang(3)
            UpdateBarang.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
        End Try

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click

        Try
            If selectedRow IsNot Nothing Then
                HapusBarang.LblBarang.Text = selectedTableBarangNama
                Dim delform = New HapusBarang()
                delform.Show()
            Else
                MsgBox("You Must Min. 1 Collection", MsgBoxStyle.Critical, "Failure")
            End If

        Catch ex As Exception
            MessageBox.Show("..")

        End Try
    End Sub

    Private Sub IncomingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomingToolStripMenuItem.Click
        Dim inc = New Barang()
        inc.Show()
        Me.Hide()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Dim ord = New Order()
        ord.Show()
        Me.Hide()

    End Sub

    Private Sub JenisBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JenisBarangToolStripMenuItem.Click
        Dim kin = New JenisBarang()
        kin.Show()
        Me.Hide()

    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Login.Show()
        Me.Hide()

    End Sub


End Class
