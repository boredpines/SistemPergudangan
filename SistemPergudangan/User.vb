Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class User
    Private username As String
    Private password As String
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private koleksiUser As New ArrayList()

    Private koleksiDataTable As New ArrayList()
    Public Shared dbconn As New MySqlConnection
    Public Shared sqlcommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader
    Private sqlquery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "pergudangan"

    Public Sub New()
        dbconn.ConnectionString = "server = " + server + ";" + "user id = " +
        username_db + ";" + "password = " + password_db + ";" + "database = " + database

    End Sub

    Public Property GSusername() As String
        Get
            Return username

        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property GSpassword() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Function EncryptData(ByVal plainText As String) As String

        Dim plainTextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plainText)

        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(),
                System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(username As String, ByVal plainPassword As String) As String

        For Each akun In koleksiUser
            If String.Compare(username, akun(0)) = 0 And String.Compare(EncryptData(plainPassword), EncryptData(akun(1))) = 0 Then
                Return "Login Berhasil"
            ElseIf String.Compare(username, akun(0)) = 0 And String.Compare(EncryptData(plainPassword), EncryptData(akun(1))) <> 0 Then
                Return "Wrong password"
            End If
        Next

    End Function

    Public Function setUserPassKoleksi(userName As String, pass As String) As Boolean
        koleksiUser.Add({userName, pass})

    End Function

    Public Function EncryptDataMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)

        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next

        Return s.ToString()
    End Function

    Public Function CheckAvailableUsername(username_regist As String)
        Dim result As Boolean

        dbconn.Open()

        sqlcommand.Connection = dbconn
        sqlcommand.CommandText = "SELECT username
                                  FROM USERS
                                  WHERE username='" & username_regist & "'"
        sqlread = sqlcommand.ExecuteReader

        If sqlread.HasRows Then
            result = True
        Else
            result = False
        End If

        sqlread.Close()
        dbconn.Close()

        Return result
    End Function

    Public Function AddUsersDatabase(username_regist As String, password_regist As String)

        Try

            If CheckAvailableUsername(username_regist) Then
                MsgBox("Username already exists.", MsgBoxStyle.Exclamation, "Warning")
            Else
                Dim today = Date.Now()

                dbconn.Open()

                sqlcommand.Connection = dbconn

                sqlquery = "INSERT INTO USERS 
                        VALUES('','" &
                            username_regist & "','" &
                            EncryptDataMD5(password_regist) & "','" &
                            today.ToString("yyyy/MM/dd") & "')"
                Debug.WriteLine(sqlquery)

                sqlcommand = New MySqlCommand(sqlquery, dbconn)
                sqlread = sqlcommand.ExecuteReader

                MsgBox("Register Berhasil", MsgBoxStyle.Information, "Sukses")
                sqlread.Close()
                dbconn.Close()
            End If
        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try
    End Function

    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)

        Try
            Dim result As New List(Of String)

            dbconn.Open()
            sqlcommand.Connection = dbconn
            Dim queryAuth = "SELECT id_user, username FROM users WHERE username = '" & username_login & "' AND password = '" & EncryptDataMD5(password_login) & "'"


            sqlcommand.CommandText = queryAuth
            sqlread = sqlcommand.ExecuteReader

            If sqlread.HasRows Then
                While sqlread.Read()
                    result.Add(sqlread.GetString(0).ToString())
                    result.Add(sqlread.GetString(1).ToString())
                End While
            End If

            sqlread.Close()
            dbconn.Close()

            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbconn.Dispose()
        End Try
    End Function

End Class
