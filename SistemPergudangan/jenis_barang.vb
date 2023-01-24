Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Common

Public Class jenis_barang
    Private id_jenis As Integer
    Private nama_jenis As String
    Private satuan As String
    Private jumlah As Integer

    Public Shared Functions
    Public Shared Selected As String

    Public Shared DbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    'Fungsi GS
    Public Property GSIdJenis() As Integer
        Get
            Return id_jenis
        End Get
        Set(ByVal value As Integer)
            id_jenis = value
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
    Public Property GSNamaJenis() As String
        Get
            Return nama_jenis
        End Get
        Set(ByVal value As String)
            nama_jenis = value
        End Set
    End Property

    Public Property GSSatuanJenis() As String
        Get
            Return satuan
        End Get
        Set(ByVal value As String)
            satuan = value
        End Set
    End Property

    'Fungsi Database

    Public Function GetDataJenisDatabase() As DataTable
        Try
            Dim result As New DataTable

            DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

            DbConn.Open()
            sqlCommand.Connection = DbConn
            sqlCommand.CommandText = "SELECT id_jenis AS 'ID',
                                      nama_jenis As 'Nama Jenis Barang',
                                      jumlah As 'Jumlah',
                                      satuan As 'Satuan'
                                      FROM jenis_barang"
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

    Public Function AddDataJenisDatabase(nama_jenis As String,
                                         jumlah As Integer,
                                         satuan As String)
        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

        DbConn.Open()
        sqlQuery = "INSERT INTO jenis_barang VALUES('','" _
                & nama_jenis & "', '" _
                & jumlah & "', '" _
                & satuan & "')"
        Try
            sqlCommand = New MySqlCommand(sqlQuery, DbConn)
            sqlRead = sqlCommand.ExecuteReader()
            sqlRead.Close()
            DbConn.Close()
            MsgBox("Data inserted.")
        Catch ex As Exception
            MsgBox("Failed to insert data: " & ex.Message.ToString())
        Finally
            DbConn.Dispose()
        End Try
    End Function

    Public Function GetJenisDatabase() As DataTable
        Dim result As New DataTable

        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

        Try
            DbConn.Open()
            sqlQuery = "SELECT nama_jenis AS 'Nama Jenis',
                               jumlah AS 'Jumlah',
                               satuan As 'Satuan'
                               FROM jenis_barang"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                result.Load(sqlRead)
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

    Public Function GetDataNama()
        Dim result As New List(Of String)

        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            DbConn.Open()
            sqlQuery = "SELECT nama_jenis FROM jenis_barang"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0))
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

    Public Function GetDataJenisById(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            DbConn.Open()
            sqlQuery = "SELECT id_jenis,
                                nama_jenis,
                                jumlah,
                                satuan
                                FROM jenis_barang
                                WHERE id_jenis='" & ID & "'"
            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader

                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                    result.Add(sqlRead.GetString(2).ToString())
                    result.Add(sqlRead.GetString(3).ToString())

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

    Public Function UpdateDataJenisByID(ID As Integer,
                                        nama_jenis As String,
                                        jumlah As Integer,
                                        satuan As String)

        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            DbConn.Open()
            sqlCommand.Connection = DbConn

            sqlQuery = "UPDATE jenis_barang SET " &
                       "nama_jenis='" & nama_jenis & "', " &
                       "jumlah='" & jumlah & "', " &
                       "satuan='" & satuan & "' WHERE id_jenis ='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            Try
                sqlCommand = New MySqlCommand(sqlQuery, DbConn)
                sqlRead = sqlCommand.ExecuteReader
                DbConn.Close()
                sqlRead.Close()
                MsgBox("Data updated.")
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

    Public Function DeleteDataJenisByIDDatabase(ID As Integer)

        DbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

        DbConn.Open()
        Try
            sqlCommand.Connection = DbConn
            sqlQuery = "DELETE FROM jenis_barang WHERE id_jenis = '" & ID & "'"

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

