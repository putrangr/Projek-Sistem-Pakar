Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: initialize or test connection here
        ' Module_koneksi.OpenConnection()
        ' Module_koneksi.CloseConnection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = TextBox1.Text.Trim()
        Dim password = TextBox2.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Isi username dan password terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'tes gothub login

        Try
            OpenConnection()
            Dim sql = "SELECT * FROM users WHERE username = @user AND password = @pass LIMIT 1"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)
            rd = cmd.ExecuteReader()

            If rd.HasRows Then
                rd.Read()
                MessageBox.Show("Login berhasil. Selamat datang " & rd("username").ToString(), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rd.Close()
                CloseConnection()
                ' TODO: buka form utama jika ada, mis: Form3.Show()
            Else
                rd.Close()
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
        ' Open register form
        Dim frm As New Form2()
        frm.Show()
        Me.Hide()
    End Sub

End Class
