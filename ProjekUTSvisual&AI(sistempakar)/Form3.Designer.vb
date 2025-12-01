<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        NumericUpDown2 = New NumericUpDown()
        Label7 = New Label()
        TextBox3 = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label8 = New Label()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        Button1 = New Button()
        Panel1.SuspendLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 80)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(185, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(423, 38)
        Label1.TabIndex = 1
        Label1.Text = "Informasi Akademik dan Dasar"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(40, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(208, 20)
        Label2.TabIndex = 1
        Label2.Text = "1. Siapa nama lengkap Anda?"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(380, 108)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(311, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(40, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(260, 20)
        Label3.TabIndex = 1
        Label3.Text = "2. Berapa NIM / ID mahasiswa Anda?"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(380, 152)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(311, 27)
        TextBox2.TabIndex = 2
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(40, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(237, 20)
        Label4.TabIndex = 1
        Label4.Text = "3. Berapa nilai IPK terakhir Anda?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(40, 249)
        Label5.Name = "Label5"
        Label5.Size = New Size(322, 20)
        Label5.TabIndex = 1
        Label5.Text = "4. Apa Program Studi / Jurusan Anda saat ini?"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(380, 246)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(311, 27)
        TextBox4.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(40, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(307, 20)
        Label6.TabIndex = 1
        Label6.Text = "5. Anda saat ini berada di Semester berapa?"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(380, 297)
        NumericUpDown2.Maximum = New Decimal(New Integer() {14, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(311, 27)
        NumericUpDown2.TabIndex = 3
        NumericUpDown2.Value = New Decimal(New Integer() {7, 0, 0, 0})
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(40, 347)
        Label7.Name = "Label7"
        Label7.Size = New Size(318, 20)
        Label7.TabIndex = 1
        Label7.Text = "6. Apa tujuan karir utama Anda setelah lulus?"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(380, 198)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(311, 27)
        TextBox3.TabIndex = 2
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(380, 345)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(79, 24)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Industri"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(465, 347)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(62, 24)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "Riset"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(533, 347)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(99, 24)
        RadioButton3.TabIndex = 4
        RadioButton3.TabStop = True
        RadioButton3.Text = "Wirausaha"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(40, 397)
        Label8.Name = "Label8"
        Label8.Size = New Size(251, 20)
        Label8.TabIndex = 1
        Label8.Text = "7. Apa preferensi fokus kerja Anda?"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(380, 395)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(70, 24)
        RadioButton4.TabIndex = 4
        RadioButton4.TabStop = True
        RadioButton4.Text = "Teknis"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(465, 397)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(100, 24)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "Manajerial"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(693, 416)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton5)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton1)
        Controls.Add(NumericUpDown2)
        Controls.Add(TextBox4)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Form3"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents Button1 As Button
End Class
