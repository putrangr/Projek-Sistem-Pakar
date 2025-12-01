Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form2

    'ini untuk menampilkan karakter password jadi duit
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbPassword.PasswordChar = "$"c
    End Sub

    'ini untuk prosses register
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Register button
        Dim username = TextBox1.Text.Trim()
        Dim password = txbPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Isi username dan password terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim form1 As New Form1()

        Dim hashedPass = Form1.HashPassword(password)

        Using conn As MySqlConnection = getConnection()
            If conn Is Nothing Then
                Return
            End If
            Try
                Dim sql As String = "INSERT INTO tb_akun (username, password) VALUES (@user, @pass)"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", hashedPass)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registrasi berhasil! Silakan login.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        Dim loginForm As New Form1()
                        loginForm.Show()
                    Else
                        MessageBox.Show("Registrasi gagal. Silakan coba lagi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    'ini untuk close form register, kembali ke form login
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' When the register form is closed, show the login form again
        Try
            ' If a Form1 instance is already open, show it; otherwise create a new one
            For Each f As Form In Application.OpenForms
                If TypeOf f Is Form1 Then
                    f.Show()
                    Return
                End If
            Next

            Dim loginForm As New Form1()
            loginForm.Show()
        Catch ex As Exception
            MessageBox.Show("Gagal membuka form login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class