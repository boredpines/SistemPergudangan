Imports System.Text
Imports MySql.Data.MySqlClient

Public Class FungsiBarang
    Private namajenis As String
    Private Nama As String
    Private Stock As Integer
    'Private deleteItem As String
    'Private BarangDataTable As New ArrayList()

    Public Shared dbconn As New MySqlConnection
    Public Shared sqlcommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader
    Private sqlquery As String
    Private db As New database

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"



    Public Property GSnamajenis() As String
        Get
            Return namajenis
        End Get
        Set(ByVal value As String)
            namajenis = value
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

    Public Property GSStock() As Integer
        Get
            Return Stock
        End Get
        Set(ByVal value As Integer)
            Stock = value
        End Set
    End Property

    'Public Property GSdelete() As String
    '    Get
    '        Return deleteItem
    '    End Get
    '    Set(value As String)
    '        deleteItem = value
    '    End Set
    'End Property

    'Public Sub AddBarangDataTable(IDBarang As String,
    '                               IDJenis As String,
    '                               Nama As String,
    '                               Stock As String)

    '    BarangDataTable.Add({IDBarang,
    '                         IDJenis,
    '                         Nama,
    '                         Stock})
    'End Sub

    'Public Function RemoveBarangDataTable(index As Integer)
    '    BarangDataTable.RemoveAt(index)
    'End Function

    'Public ReadOnly Property getBarangDataTable() As ArrayList
    '    Get
    '        Return BarangDataTable
    '    End Get
    'End Property

    'Public Function ConvertBarangToString(vals As List(Of String))
    '    Dim builder As StringBuilder = New StringBuilder()
    '    For Each val As String In vals
    '        builder.Append(val).Append("|")
    '    Next

    '    'convert to string
    '    Dim res = builder.ToString()
    '    Return res
    'End Function

    'Public Function ConvertStringToBarang(value As String)
    '    Dim arr() As String = value.Split("|")

    '    'convert to list
    '    Dim vals As List(Of String) = arr.ToList()
    '    Return vals
    'End Function

    Public Function GetDatajenis()
        Dim result As New List(Of String)

        dbconn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbconn.Open()
            sqlquery = "SELECT nama_jenis FROM jenis_barang"
            Try
                sqlcommand = New MySqlCommand(sqlquery, dbconn)
                sqlread = sqlcommand.ExecuteReader

                While sqlread.Read
                    result.Add(sqlread.GetString(0).ToString)
                End While

                Return result
            Catch ex As Exception
                MsgBox("Problem loading data: " & ex.Message.ToString)
            End Try
            sqlread.Close()
            dbconn.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        Finally
            dbconn.Dispose()
        End Try
    End Function

    Public Function GetDataBarangDatabase() As DataTable
        Try
            Dim result As New DataTable

            dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlcommand.CommandText = "SELECT id_barang AS 'ID',
                                      nama_barang As 'Nama Barang',
                                      nama_jenis As 'Jenis barang',
                                      stock As 'Stock'
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

    Public Function AddDataBarangDatabase(nama_barang As String,
                                          stock As Integer,
                                          nama_jenis As String)

        dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = "INSERT INTO barang(id_barang, nama_barang,
                        stock, nama_jenis) VALUE ('','" _
                & nama_barang & "', '" _
                & stock & "', '" _
                & nama_jenis & "')"

            Try
                sqlcommand = New MySqlCommand(sqlquery, dbconn)
                sqlread = sqlcommand.ExecuteReader
                dbconn.Close()
                sqlread.Close()
                MsgBox("Data berhasil masuk.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                dbconn.Dispose()
            End Try
            sqlread.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try
    End Function



    Public Function GetData()
        Dim result As New List(Of String)

        dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = "SELECT nama_jenis FROM jenis_barang"

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader

            While sqlread.Read
                result.Add(sqlread.GetString(0).ToString)
            End While

            sqlread.Close()
            dbconn.Close()

            Return result

        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        Finally
            dbconn.Dispose()
        End Try
    End Function

    Public Function GetDataBarangByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        Try
            dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
      + "password=" + password + ";" + "database=" + database
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlcommand.CommandText = " SELECT id_barang,
                                nama_barang,
                                stock,
                                nama_jenis
                                FROM barang
                                WHERE id_barang='" & ID & "'"
            sqlread = sqlcommand.ExecuteReader

            While sqlread.Read
                result.Add(sqlread.GetString(0).ToString())
                result.Add(sqlread.GetString(1).ToString())
                result.Add(sqlread.GetString(2).ToString())
                result.Add(sqlread.GetString(3).ToString())
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
                                        nama_barang As String,
                                        stock As Integer,
                                        nama_jenis As String)

        dbconn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn

            sqlquery = "UPDATE barang SET " &
                       "nama_barang='" & nama_barang & "', " &
                       "stock='" & stock & "', " &
                       "nama_jenis='" & nama_jenis & "' WHERE id_barang ='" & ID & "'"

            Try
                sqlcommand = New MySqlCommand(sqlquery, dbconn)
                sqlread = sqlcommand.ExecuteReader
                dbconn.Close()
                sqlread.Close()
                MsgBox("Data updated.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                dbconn.Dispose()
            End Try
            sqlread.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

    End Function

    Public Function DeleteDataKoleksiByIDDatabase(ID As Integer)
        dbconn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
       + "password=" + password + ";" + "database=" + database

        Try
            dbconn.Open()
            sqlcommand.Connection = dbconn
            sqlquery = " DELETE FROM barang " &
                       " WHERE id_barang ='" & ID & "'"

            Debug.WriteLine(sqlquery)

            sqlcommand = New MySqlCommand(sqlquery, dbconn)
            sqlread = sqlcommand.ExecuteReader

            dbconn.Close()

            sqlread.Close()
            dbconn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbconn.Dispose()
        End Try

    End Function

    Public Function CheckNama(nama As String) As Boolean
        sqlquery = "SELECT nama_barang FROM barang WHERE nama_barang='" & nama & "'"
        Return db.CheckAvailability(sqlquery)
    End Function

End Class
