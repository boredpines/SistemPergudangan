Public Class Register
    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click

        Login.user.GSusername = tbuname.Text
        Login.user.GSpassword = tbpass.Text

        If tbuname.Text.Length > 0 And tbpass.Text.Length > 0 Then
            Login.user.AddUsersDatabase(Login.user.GSusername, Login.user.GSpassword)
            Me.Close()
        Else
            MsgBox("Please enter the correct info.", MsgBoxStyle.Critical, "Failure")
        End If

    End Sub

    Private Sub btnlog_Click(sender As Object, e As EventArgs) Handles btnlog.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub register_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        tbuname.Select()
        tbuname.Text = ""
        tbpass.Text = ""

    End Sub

    Private Sub tbpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbpass.KeyPress
        tbpass.PasswordChar = "*"c

    End Sub
End Class