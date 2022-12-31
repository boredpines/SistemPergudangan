Public Class Login
    Public Shared Barang As Barang
    Public Shared user As User

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user = New User()
        Barang = New Barang()

    End Sub
    Private Sub butlogin_Click(sender As Object, e As EventArgs) Handles butlogin.Click
        user.GSusername = txtuname.Text
        user.GSpassword = txtpass.Text

        If user.GSusername.Length = 0 Or user.GSpassword.Length = 0 Then
            MsgBox("Please enter your login info", MsgBoxStyle.Critical, "Failed to sign-in")
        Else
            Dim data_user As List(Of String) = user.CheckAuthDatabase(user.GSusername, user.GSpassword)

            If data_user.Count > 0 Then
                Barang.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect username or password", MsgBoxStyle.Critical, "Failure")
            End If

        End If

    End Sub

    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        txtpass.PasswordChar = "*"c
    End Sub

    Private Sub butreg_Click(sender As Object, e As EventArgs) Handles butreg.Click
        Register.Show()
    End Sub

    Private Sub login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtuname.Select()
        txtuname.Text = ""
        txtpass.Text = ""
    End Sub

End Class