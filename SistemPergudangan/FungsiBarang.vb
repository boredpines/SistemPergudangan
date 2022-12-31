Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FungsiBarang
    Private IDBarang As String
    Private IDJenis As String
    Private Nama As String
    Private Stock As String
    Private deleteItem As String
    Private BarangDataTable As New ArrayList()

    Public Shared dbconn As New MySqlConnection
    Public Shared sqlcommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader
    Private sqlquery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "gudang"

    Public Property GSIDBarang() As String
        Get
            Return IDBarang
        End Get
        Set(ByVal value As String)
            IDBarang = value
        End Set
    End Property

    Public Property GSIDJenis() As String
        Get
            Return IDJenis
        End Get
        Set(ByVal value As String)
            IDJenis = value
        End Set
    End Property

    Public Property GSNama() As String
        Get
            Return Nama
        End Get
        Set(ByVal value As String)
            Nama = value
        End Set
    End Property

    Public Property GSStock() As String
        Get
            Return Stock
        End Get
        Set(ByVal value As String)
            Stock = value
        End Set
    End Property

    Public Property GSdelete() As String
        Get
            Return deleteItem
        End Get
        Set(value As String)
            deleteItem = value
        End Set
    End Property

    Public Sub AddBarangDataTable(IDBarang As String,
                                   IDJenis As String,
                                   Nama As String,
                                   Stock As String)

        BarangDataTable.Add({IDBarang,
                             IDJenis,
                             Nama,
                             Stock})
    End Sub

    Public Function RemoveBarangDataTable(index As Integer)
        BarangDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getBarangDataTable() As ArrayList
        Get
            Return BarangDataTable
        End Get
    End Property

    Public Function ConvertBarangToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'convert to string
        Dim res = builder.ToString()
        Return res
    End Function

    Public Function ConvertStringToBarang(value As String)
        Dim arr() As String = value.Split("|")

        'convert to list
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function GetDataBarangDatabase() As DataTable
        Try
            Dim result As New DataTable

            dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlcommand.CommandText = "SELECT ID AS 'ID',
                                      IDBarang As 'ID Barang',
                                      IDJenis As 'ID Jenis barang',
                                      Nama As 'Nama Barang',
                                      Stock As 'Stock'
                                      FROM barang"
            sqlread = sqlcommand.ExecuteReader

            result.Load(sqlread)
            sqlread.Close()
            dbconn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbconn.Dispose()
        End Try
    End Function
    Public Function AddDataBarangDatabase(IDBarang As String,
                                          IDJenis As String,
                                          Nama As String,
                                          Stock As String)
        dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = "INSERT INTO barang(IDBarang, IDJenis,
                        Nama, Stock) VALUE ('" _
                & IDBarang & "', '" _
                & IDJenis & "', '" _
                & Nama & "', '" _
                & Stock & "')"
            Debug.Print(sqlquery)

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader
            MessageBox.Show("Tambah Database")
            dbconn.Close()
            sqlread.Close()
            dbconn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
      + "password=" + password + ";" + "database=" + database
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlcommand.CommandText = " SELECT ID, 
                                       IDBarang, 
                                       IDJenis, 
                                       Nama, 
                                       Stock
                                   FROM barang
                                   WHERE ID= '" & ID & " ' "
            sqlread = sqlcommand.ExecuteReader

            While sqlread.Read
                result.Add(sqlread.GetString(0).ToString())
                result.Add(sqlread.GetString(1).ToString())
                result.Add(sqlread.GetString(2).ToString())
                result.Add(sqlread.GetString(3).ToString())
                result.Add(sqlread.GetString(4).ToString())
            End While

            sqlread.Close()
            dbconn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbconn.Dispose()
        End Try
    End Function

    Public Function UpdateDataBarangByIDDatabase(ID As Integer,
                                                 IDBarang As Integer,
                                                 IDJenis As Integer,
                                                 Nama As String,
                                                 Stock As Integer)
        dbconn.ConnectionString = "server =" + server + ";" _
                                + "user id=" + username + ";" _
                                + "password=" + password + ";" _
                                + "database=" + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = " UPDATE barang SET IDBarang='" & IDBarang & "', " &
                        "IDJenis='" & IDJenis & "', " &
                        "Nama='" & Nama & "', " &
                        "Stock='" & Stock & "' " &
                        "WHERE ID='" & ID & "'"

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader
            MessageBox.Show("Data sudah diperbarui")
            dbconn.Close()
            sqlread.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
       + "password=" + password + ";" + "database=" + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = " DELETE FROM barang " &
                       " WHERE ID ='" & ID & "'"

            Debug.WriteLine(sqlquery)

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader

            dbconn.Close()

            ' Form_Perpustakaan.sqlDR.Load(sqlRead)
            sqlread.Close()
            dbconn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try

    End Function


End Class
