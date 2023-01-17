Public Class InfoBarang

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'LblIDBrgValue.Text = MainMenu.datagudang.GSIDBarang
        'LblIDJenisValue.Text = MainMenu.datagudang.GSIDJenis
        LblBarangValue.Text = MainMenu.datagudang.GSNama
        LblStock.Text = MainMenu.datagudang.GSStock
    End Sub

    Private Sub BtnCLose_Click(sender As Object, e As EventArgs) Handles BtnCLose.Click
        Me.Close()
    End Sub
End Class