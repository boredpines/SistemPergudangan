Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities.Collections

Public Class FungsiBarangMasuk
    Private nama_barang As String
    Private jumlah As Integer
    Private tglmasuk As Date
    Private db As New database

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

    Public Property GStglmasuk() As Date
        Get
            Return tglmasuk
        End Get
        Set(ByVal value As Date)
            tglmasuk = value
        End Set
    End Property

    Public Function GetDataMasukDatabase() As DataTable
        Try
            Dim result As New DataTable

            DbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

            DbConn.Open()
            sqlCommand.Connection = DbConn
            sqlCommand.CommandText = "SELECT id_masuk AS 'ID',
                                      nama_barang As 'Barang Masuk',
                                      tanggal_masuk As 'Tanggal Masuk',
                                      jumlah_masuk As 'Jumlah Masuk'
                                      FROM barang_masuk"
            sqlRead = sqlCommand.ExecuteReader

            result.Load(sqlRead)
            sqlRead.Close()
            DbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            DbConn.Dispose()
        End Try
    End Function


    Public Function GetData()
        Dim result As New List(Of String)

        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn
            sqlQuery = "SELECT nama_barang FROM barang"

            sqlCommand = New MySqlCommand(sqlQuery, DbConn)
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString)
            End While

            sqlRead.Close()
            DbConn.Close()

            Return result

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
            sqlCommand.CommandText = "SELECT stock FROM barang WHERE nama_barang ='" & nama & "'"
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

    Public Function InsertStockBarang(nama As String,
                                  jumlah As Integer)
        Dim stockLama As Integer = GetPrevSum(nama)
        Dim stockBaru As Integer = stockLama + jumlah
        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn

            sqlQuery = "UPDATE barang SET " &
                       "stock='" & stockBaru & "' WHERE nama_barang ='" & nama & "'"


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
    Public Function AddDataBarang(nama As String,
                                  jumlah As Integer,
                                  tgl As Date)
        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn

            sqlQuery = "INSERT INTO barang_masuk(id_masuk, nama_barang,
                            jumlah_masuk, tanggal_masuk) VALUE ('','" _
                            & nama & "', '" _
                            & jumlah & "', '" _
                            & tgl.ToString("yyyy/MM/dd") & "')"

            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                DbConn.Close()
                sqlRead.Close()
                MsgBox("Data berhasil masuk.")
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

    Public Function GetDataMasukByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            DbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
      + "password=" + password + ";" + "database=" + database
            DbConn.Open()
            sqlCommand.Connection = DbConn
            sqlCommand.CommandText = " SELECT id_masuk,
                                tanggal_masuk,
                                jumlah_masuk,
                                nama_barang
                                FROM barang_masuk
                                WHERE id_masuk='" & ID & "'"
            sqlRead = sqlCommand.ExecuteReader

            While sqlRead.Read
                result.Add(sqlRead.GetString(0).ToString())
                result.Add(sqlRead.GetString(1).ToString())
                result.Add(sqlRead.GetString(2).ToString())
                result.Add(sqlRead.GetString(3).ToString())
            End While

            sqlRead.Close()
            DbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DbConn.Dispose()
        End Try
    End Function


    Public Function DeleteDataMasukByIDDatabase(ID As Integer)
        DbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
       + "password=" + password + ";" + "database=" + database

        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn
            sqlQuery = " DELETE FROM barang_masuk " &
                       " WHERE id_masuk ='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, DbConn)
            sqlRead = sqlCommand.ExecuteReader

            DbConn.Close()

            sqlRead.Close()
            DbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            DbConn.Dispose()
        End Try

    End Function


End Class
