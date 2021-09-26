Imports System.Data.Odbc

Module Koneksi
    Public Conn As OdbcConnection
    Public CMD As OdbcCommand
    Public DS As New DataSet
    Public DA As OdbcDataAdapter
    Public RD As OdbcDataReader
    Dim LokasiData As String

    Public Sub Konek()
        LokasiData = "Driver={MySQL ODBC 8.0 Unicode Driver};Database=penggajian;server=localhost;uid=root"
        Conn = New OdbcConnection(LokasiData)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
