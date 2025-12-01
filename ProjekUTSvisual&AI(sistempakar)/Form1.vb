Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form1

    'ini Function untuk hassh password
    Public Shared Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(password)
            Dim hashBytes As Byte() = sha256.ComputeHash(bytes)
            Dim sb As New StringBuilder()
            For Each b As Byte In hashBytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

    'ini untuk menampilkan karakter password jadi duit
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbPassword.PasswordChar = "$"c

    End Sub

    'ini untuk prosses login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = TextBox1.Text.Trim()
        Dim password = txbPassword.Text.Trim()

        ' Validate inputs using ErrorProvider1
        ErrorProvider1.Clear()
        Dim valid As Boolean = True
        If username = "" Then
            ErrorProvider1.SetError(TextBox1, "Isi username terlebih dahulu")
            valid = False
        End If
        If password = "" Then
            ErrorProvider1.SetError(txbPassword, "Isi password terlebih dahulu")
            If valid Then txbPassword.Focus()
            valid = False
        End If
        If Not valid Then
            Return
        End If

        Dim hashedPass = HashPassword(password)

        Using conn As MySqlConnection = getConnection()
            If conn Is Nothing Then
                Return
            End If

            Try
                Dim sql As String = "SELECT * FROM tb_akun WHERE username = @user AND password = @pass"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@user", username)
                    cmd.Parameters.AddWithValue("@pass", hashedPass)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Dim mainForm As New Form3()
                            mainForm.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using


    End Sub

    'ini untuk buka form register
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim registerForm As New Form2()
        registerForm.Show()

        Me.Hide()
    End Sub
End Class
