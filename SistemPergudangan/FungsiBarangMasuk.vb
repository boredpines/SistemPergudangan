Imports MySql.Data.MySqlClient

Public Class FungsiBarangMasuk
    Private nama_barang As String
    Private jumlah As Integer

    Public Shared DbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    Public Property GSNamaBarang() As String
        Get
            Return nama_barang
        End Get
        Set(ByVal value As String)
            nama_barang = value
        End Set
    End Property

    Public Property GSjumlah() As Integer
        Get
            Return jumlah
        End Get
        Set(ByVal value As Integer)
            jumlah = value
        End Set
    End Property

    Public Function GetData()
        Dim result As New List(Of String)

        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            DbConn.Open()
            sqlQuery = "SELECT nama FROM barang"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString)
                End While

                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlRead.Close()
            DbConn.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        Finally
            DbConn.Dispose()
        End Try
    End Function

    Public Function GetPrevSum(nama As String)
        Try
            Dim result As Integer
            DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

            DbConn.Open()
            sqlCommand.Connection = DbConn
            sqlCommand.CommandText = "SELECT stock FROM barang WHERE nama ='" & nama & "'"
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result = sqlRead.GetString(0)
            End While

            sqlRead.Close()
            DbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            DbConn.Dispose()
        End Try
    End Function

    Public Function AddDataBarang(nama As String,
                                  jumlah As Integer)
        Dim stockLama As Integer = GetPrevSum(nama)
        Dim stockBaru As Integer = stockLama + jumlah
        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn

            sqlQuery = "UPDATE barang SET " &
                       "stock='" & stockBaru & "' WHERE nama ='" & nama & "'"

            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                DbConn.Close()
                sqlRead.Close()
                MsgBox("Stock Ditambahkan.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                DbConn.Dispose()
            End Try
            sqlRead.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

    End Function

End Class
