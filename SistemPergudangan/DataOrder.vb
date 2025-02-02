﻿Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports Org.BouncyCastle.Crypto.Tls

Public Class DataOrder
    Private idorder As Integer
    Private TanggalOrder As Date
    Private JumlahOrder As Integer
    Private status As String
    Private namabarang As String
    Private stock As Integer

    Public Property GSIdorder() As Integer
        Get
            Return idorder
        End Get
        Set(value As Integer)
            idorder = value
        End Set
    End Property

    Public Property GSTanggalOrder() As Date
        Get
            Return TanggalOrder
        End Get
        Set(value As Date)
            TanggalOrder = value
        End Set
    End Property

    Public Property GSJumlahOrder() As Integer
        Get
            Return JumlahOrder
        End Get
        Set(value As Integer)
            JumlahOrder = value
        End Set
    End Property

    Public Property GSStatus() As String
        Get
            Return status
        End Get
        Set(value As String)
            status = value
        End Set
    End Property

    Public Property GSnamabarang() As String
        Get
            Return namabarang
        End Get
        Set(value As String)
            namabarang = value
        End Set
    End Property

    'Public Property GSstockBarang() As Integer
    '    Get
    '        Return stock
    '    End Get
    '    Set(value As Integer)
    '        stock = value
    '    End Set
    'End Property


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader
    Private db As New database
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"


    Public Function CheckStatus(stock As Integer,
                                 jumlahorder As Integer) As Boolean

        If stock >= jumlahorder Then
            Return True
        ElseIf stock < jumlahorder Then
            Return False
        End If
    End Function

    Public Function GetPrevSum(nama As String)
        Try
            Dim result As Integer
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT stock FROM barang WHERE nama_barang ='" & nama & "'"
            sqlread = sqlCommand.ExecuteReader

            While sqlread.Read
                result = sqlread.GetString(0)
            End While

            sqlread.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetOrderSum() As DataTable

        Try
            Dim result As New DataTable
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT barang.stock as stock, barang_keluar.jumlah_order as jumlah_order, barang_keluar.id_order FROM barang_keluar JOIN barang on barang_keluar.id_barang = barang.id_barang"
            sqlread = sqlCommand.ExecuteReader

            result.Load(sqlread)

            sqlread.Close()
            dbConn.Close()
            Return result

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetJumlahOrder()

        Try
            Dim result As Integer
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT jumlah_order FROM barang_keluar"
            sqlread = sqlCommand.ExecuteReader

            While sqlread.Read
                result = sqlread.GetString(0)
            End While

            sqlread.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetIDbarang(nama As String)
        Try
            Dim result As Integer
            dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_barang FROM barang WHERE nama_barang ='" & nama & "'"
            sqlread = sqlCommand.ExecuteReader

            While sqlread.Read
                result = sqlread.GetString(0)
            End While

            sqlread.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataOrderDatabase() As DataTable
        Try
            Dim result As New DataTable

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlCommand.CommandText = "SELECT id_order AS 'ID',
                                      nama_barang As 'Barang Pesanan',
                                      tanggal_order As 'Tanggal Order',
                                      jumlah_order As 'Jumlah Order',
                                      status as 'Status'
                                      FROM barang_keluar"
            sqlread = sqlCommand.ExecuteReader

            result.Load(sqlread)
            sqlread.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        Finally
            dbConn.Dispose()
        End Try
    End Function


    Public Function GetData()
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "SELECT nama_barang FROM barang"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlread = sqlCommand.ExecuteReader

            While sqlread.Read
                result.Add(sqlread.GetString(0).ToString)
            End While

            sqlread.Close()
            dbConn.Close()

            Return result

        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function AddMasukAktif(nama As String,
                                  jumlah As Integer,
                                  tgl As Date)

        Dim idtemp = GetIDbarang(nama)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn


            sqlQuery = "INSERT INTO barang_keluar(id_order, nama_barang,
                            jumlah_order, status, id_barang, tanggal_order) VALUE ('','" _
                            & nama & "', '" _
                            & jumlah & "', '" _
                            & "Aktif" & "', '" _
                            & idtemp & "', '" _
                            & tgl.ToString("yyyy/MM/dd") & "')"

            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlread = sqlCommand.ExecuteReader
                dbConn.Close()
                sqlread.Close()
                MsgBox("Data berhasil masuk.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
            sqlread.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

    End Function

    Public Function AddMasukFilled(nama As String,
                                  jumlah As Integer,
                                  tgl As Date)

        Dim idtemp = GetIDbarang(nama)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "INSERT INTO barang_keluar(id_order, nama_barang,
                            jumlah_order, status, id_barang, tanggal_order) VALUE ('','" _
                            & nama & "', '" _
                            & jumlah & "', '" _
                            & "Terpenuhi" & "', '" _
                            & idtemp & "', '" _
                            & tgl.ToString("yyyy/MM/dd") & "')"

            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlread = sqlCommand.ExecuteReader
                dbConn.Close()
                sqlread.Close()
                MsgBox("Data berhasil masuk.")
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
            sqlread.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

    End Function

    Public Function UpdateStatusAktif(idorder As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE barang_keluar SET " &
                       "status = 'Terpenuhi' WHERE id_order ='" & idorder & "'"


            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlread = sqlCommand.ExecuteReader
                dbConn.Close()
                sqlread.Close()
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
            sqlread.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

    End Function

    Public Function UpdateStatusFilled(idorder As Integer)

        dbConn.ConnectionString = "server = " + server + ";" + "user id = " +
            username + ";" + "password = " + password + ";" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE barang_keluar SET " &
                       "status = 'Aktif' WHERE id_order ='" & idorder & "'"


            Try
                sqlCommand = New MySqlCommand(sqlQuery, dbConn)
                sqlread = sqlCommand.ExecuteReader
                dbConn.Close()
                sqlread.Close()
            Catch ex As Exception
                MsgBox("Failed to update data: " & ex.Message.ToString())
            Finally
                dbConn.Dispose()
            End Try
            sqlread.Close()
        Catch ex As Exception
            MsgBox("Connection Error: " & ex.Message.ToString)
        End Try

    End Function

    Public Function DeleteDataOrderByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
       + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = " DELETE FROM barang_keluar " &
                       " WHERE id_order ='" & ID & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlread = sqlCommand.ExecuteReader

            dbConn.Close()

            sqlread.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try

    End Function


End Class
