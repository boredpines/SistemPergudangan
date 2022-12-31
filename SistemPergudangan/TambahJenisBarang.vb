Imports System.IO
Public Class TambahJenisBarang


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click



        'Penyimpanan variable
        JenisBarang.JenisBarang.GSIdJenis = TxtIdJenis.Text
        JenisBarang.JenisBarang.GSNamaJenis = TxtNamaJenis.Text
        JenisBarang.JenisBarang.GSSatuanJenis = CbSatuanJenis.Text

        'panggil database 
        JenisBarang.JenisBarang.AddJenisTable(
                        JenisBarang.JenisBarang.GSIdJenis,
                        JenisBarang.JenisBarang.GSNamaJenis,
                        JenisBarang.JenisBarang.GSSatuanJenis)

    End Sub

    Private Sub BtnCloseJenis_Click(sender As Object, e As EventArgs) Handles BtnCloseJenis.Click
        Me.Close()
    End Sub
End Class