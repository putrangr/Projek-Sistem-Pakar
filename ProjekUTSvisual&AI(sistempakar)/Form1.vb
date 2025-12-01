Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = TextBox1.Text.Trim()
        Dim password = TextBox2.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Isi username dan password terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim hashed = EnkripsiPassword(password)

            OpenConnection()
            Dim sql = "SELECT * FROM tb_akun WHERE username = @user AND password = @pass LIMIT 1"
            cmd = New MySqlCommand(sql, connStr)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)

            rd = cmd.ExecuteReader()

            If rd IsNot Nothing AndAlso rd.HasRows Then
                rd.Read()
                MessageBox.Show("Login berhasil. Selamat datang " & rd("username").ToString(), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rd.Close()
                CloseConnection()
            Else
                If rd IsNot Nothing AndAlso Not rd.IsClosed Then rd.Close()
                CloseConnection()
                MessageBox.Show("Username atau password salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If rd IsNot Nothing AndAlso Not rd.IsClosed Then rd.Close()
            CloseConnection()
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frm As New Form2()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
