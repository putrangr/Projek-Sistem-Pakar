Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Register button
        Dim username = TextBox1.Text.Trim()
        Dim password = TextBox2.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Isi username dan password terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            OpenConnection()
            ' Check if username already exists
            Dim checkSql = "SELECT COUNT(*) FROM users WHERE username = @user"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(checkSql, conn)
            cmd.Parameters.AddWithValue("@user", username)
            Dim exists = Convert.ToInt32(cmd.ExecuteScalar())

            If exists > 0 Then
                MessageBox.Show("Username sudah terdaftar, pilih username lain.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CloseConnection()
                Return
            End If

            Dim insertSql = "INSERT INTO users (username, password) VALUES (@user, @pass)"
            cmd = New MySql.Data.MySqlClient.MySqlCommand(insertSql, conn)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)
            Dim rows = cmd.ExecuteNonQuery()

            If rows > 0 Then
                MessageBox.Show("Registrasi berhasil. Silakan login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CloseConnection()
                Dim loginForm As New Form1()
                loginForm.Show()
                Me.Close()
            Else
                MessageBox.Show("Gagal registrasi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat registrasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Kembali button
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub

End Class