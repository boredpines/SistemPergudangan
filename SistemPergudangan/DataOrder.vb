Imports System.Text
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class DataOrder
    Private idorder As Integer
    Private TanggalOrder As Date
    Private JumlahOrder As Integer
    Private status As Boolean
    Private namabarang As String

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

    Public Property GSStatus() As Boolean
        Get
            Return status
        End Get
        Set(value As Boolean)
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


    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlread As MySqlDataReader
    Private db As New database
    Private sqlQuery As String


    Public Function GetDataOrderDatabase() As DataTable

        sqlQuery = "SELECT id_order AS 'ID',
                            nama_barang as 'Barang Order',
                            tanggal_order AS 'Tanggal Order',
                            jumlah_order AS 'Jumlah Order',
                            status AS 'Status'
                            From barang_keluar"

        Return db.ExecuteQuery(sqlQuery)
    End Function

    'Public Function AddDataKoleksiDatabase(tanggal_order As Date,
    '                                   jumlah_order As String,
    '                                   status As String)

    '    Try

    '        MessageBox.Show("test")
    '        dbConn.ConnectionString = "server = " + server + ";" + "user id=" + username + ";" _
    '            + "password=" + password + ";" + "database =" + database

    '        dbConn.Open()
    '        sqlCommand.Connection = dbConn
    '        sqlQuery = "INSERT INTO order( 
    '                        tanggal_order,
    '                        jumlah_order, 
    '                        status
    '                    ) VALUE('" _
    '            & tanggal_order.ToString("yyyy/MM/dd") & "', '" _
    '            & jumlah_order & "', '" _
    '            & status & "')"


    '        MessageBox.Show(sqlQuery)
    '        Debug.Print(sqlQuery)

    '        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
    '        sqlread = sqlCommand.ExecuteReader


    '        sqlread.Close()
    '        dbConn.Close()
    '    Catch ex As Exception
    '        Return ex.Message
    '    Finally
    '        dbConn.Dispose()
    '    End Try
    'End Function

    'Public Function GetDataKoleksiIDDatabase(id_barang As Integer) As List(Of String)
    '    Dim result As New List(Of String)

    '    dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
    '     + "password=" + password + ";" + "database =" + database
    '    dbConn.Open()
    '    sqlCommand.Connection = dbConn
    '    sqlCommand.CommandText = "SELECT id_barang,
    '                                tanggal_order,
    '                                jumlah_order,
    '                                status
    '                                FROM order
    '                                WHERE id_order= '" & id_barang & "'"

    '    sqlread = sqlCommand.ExecuteReader

    '    While sqlread.Read
    '        result.Add(sqlread.GetString(0).ToString())
    '        result.Add(sqlread.GetString(1).ToString())
    '        result.Add(sqlread.GetString(2).ToString())
    '        result.Add(sqlread.GetString(3).ToString())
    '    End While

    '    sqlread.Close()
    '    dbConn.Close()
    '    Return result
    'End Function

    'Public Function DeleteDataKoleksiByIDDatabase(id_barang As Integer)

    '    dbConn.ConnectionString = "server -" + server + ";" + "user id-" + username + ";" _
    '        + "password-" + password + ";" + "database -" + database

    '    Try
    '        dbConn.Open()
    '        sqlCommand.Connection = dbConn
    '        sqlQuery = "DELETE FROM order " &
    '                "WHERE id_barang-'" & id_barang & "'"


    '        Debug.WriteLine(sqlQuery)

    '        sqlCommand = New MySqlCommand(sqlQuery, dbConn)
    '        sqlread = sqlCommand.ExecuteReader
    '        dbConn.Close()

    '        sqlread.Close()
    '        dbConn.Close()
    '    Catch ex As Exception
    '        Return ex.Message
    '    Finally
    '        dbConn.Dispose()
    '    End Try
    'End Function
End Class
