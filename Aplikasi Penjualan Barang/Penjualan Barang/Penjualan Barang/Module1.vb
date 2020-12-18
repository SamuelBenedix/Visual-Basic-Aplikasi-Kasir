Imports System.Data.OleDb

Module Module1
    Public Conn As OleDbConnection
    Public DA As OleDbDataAdapter
    Public Ds As DataSet
    Public cmd As OleDbCommand
    Public Dr As OleDbDataReader

    Sub Koneksi()
        Try
            Conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\PenjualanBarang.mdb")
            Conn.Open()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

End Module
