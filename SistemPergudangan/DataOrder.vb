Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class DataOrder
    Private idBarang As String
    Private TanggalOrder As String
    Private JumlahOrder As String
    Private status As String
    Private delete

    Public Property GSIdBarang() As String
        Get
            Return idBarang
        End Get
        Set(value As String)
            idBarang = value
        End Set
    End Property

    Public Property GSTanggalOrder() As String
        Get
            Return TanggalOrder
        End Get
        Set(value As String)
            TanggalOrder = value
        End Set
    End Property

    Public Property GSJumlahOrder()
        Get
            Return JumlahOrder
        End Get
        Set(value)
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
    Public Property GSdelete() As String
        Get
            Return delete
        End Get
        Set(value As String)
            delete = value
        End Set
    End Property



    'database global variable
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader

    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "order"

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_barang AS 'idBarang', 
                                  tanggal_order AS 'TanggalOrder',
                                  jumlah_order AS 'JumlahOrder',
                                  status AS 'status'
                                  From order"

        sqlread = sqlCommand.ExecuteReader

        result.Load(sqlread)
        sqlread.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase(tanggal_order As Date,
                                       jumlah_order As String,
                                       status As String)

        Try

            MessageBox.Show("test")
            dbConn.ConnectionString = "server = " + server + ";" + "user id=" + username + ";" _
                + "password=" + password + ";" + "database =" + database

            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO order( 
                            tanggal_order,
                            jumlah_order, 
                            status
                        ) VALUE('" _
                & tanggal_order.ToString("yyyy/MM/dd") & "', '" _
                & jumlah_order & "', '" _
                & status & "')"


            MessageBox.Show(sqlQuery)
            Debug.Print(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlread = sqlCommand.ExecuteReader


            sqlread.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiIDDatabase(id_barang As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
         + "password=" + password + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_barang,
                                    tanggal_order,
                                    jumlah_order,
                                    status
                                    FROM order
                                    WHERE id_order= '" & id_barang & "'"

        sqlread = sqlCommand.ExecuteReader

        While sqlread.Read
            result.Add(sqlread.GetString(0).ToString())
            result.Add(sqlread.GetString(1).ToString())
            result.Add(sqlread.GetString(2).ToString())
            result.Add(sqlread.GetString(3).ToString())
        End While

        sqlread.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function DeleteDataKoleksiByIDDatabase(id_barang As Integer)

        dbConn.ConnectionString = "server -" + server + ";" + "user id-" + username + ";" _
            + "password-" + password + ";" + "database -" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM order " &
                    "WHERE id_barang-'" & id_barang & "'"


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
