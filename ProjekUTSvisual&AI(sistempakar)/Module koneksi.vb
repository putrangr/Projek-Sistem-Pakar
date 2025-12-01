Imports MySql.Data.MySqlClient

Module modul_koneksi
    Dim connStr As String = "server=localhost;user id=root;password=;database=db_sistempakar"

    Public Function getConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connStr)
        Try
            conn.Open()
            Return conn
        Catch ex As MySqlException
            MessageBox.Show("Koneksi Gagal: " & ex.Message)
            Return Nothing
        End Try
    End Function
End Module