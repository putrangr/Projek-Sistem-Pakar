<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        NumericUpDown2 = New NumericUpDown()
        Label2 = New Label()
        Label3 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Label4 = New Label()
        NumericUpDown3 = New NumericUpDown()
        RadioButton21 = New RadioButton()
        RadioButton22 = New RadioButton()
        Label6 = New Label()
        Panel1.SuspendLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(-4, -2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(811, 89)
        Panel1.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(319, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 38)
        Label1.TabIndex = 1
        Label1.Text = " Sertifikasi"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(466, 120)
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(311, 27)
        NumericUpDown2.TabIndex = 20
        NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(51, 122)
        Label2.MaximumSize = New Size(400, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(382, 40)
        Label2.TabIndex = 19
        Label2.Text = "1. Berapa jumlah sertifikasi cloud (AWS / Azure / GCP / dsb) yang Anda miliki?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(51, 192)
        Label3.MaximumSize = New Size(400, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(397, 40)
        Label3.TabIndex = 19
        Label3.Text = "2. Berapa jumlah sertifikasi data (Google Data / Tableau / dsb) yang Anda miliki?"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(466, 190)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(311, 27)
        NumericUpDown1.TabIndex = 20
        NumericUpDown1.Value = New Decimal(New Integer() {3, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(51, 263)
        Label4.MaximumSize = New Size(400, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(367, 40)
        Label4.TabIndex = 19
        Label4.Text = "3. Berapa jumlah sertifikasi vendor IT lainnya (Cisco, CompTIA, dsb) yang Anda miliki?"
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(466, 261)
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(311, 27)
        NumericUpDown3.TabIndex = 20
        NumericUpDown3.Value = New Decimal(New Integer() {2, 0, 0, 0})
        ' 
        ' RadioButton21
        ' 
        RadioButton21.AutoSize = True
        RadioButton21.Location = New Point(532, 335)
        RadioButton21.Name = "RadioButton21"
        RadioButton21.Size = New Size(66, 24)
        RadioButton21.TabIndex = 37
        RadioButton21.TabStop = True
        RadioButton21.Text = "Tidak"
        RadioButton21.UseVisualStyleBackColor = True
        ' 
        ' RadioButton22
        ' 
        RadioButton22.AutoSize = True
        RadioButton22.Location = New Point(468, 335)
        RadioButton22.Name = "RadioButton22"
        RadioButton22.Size = New Size(49, 24)
        RadioButton22.TabIndex = 38
        RadioButton22.TabStop = True
        RadioButton22.Text = "Iya"
        RadioButton22.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(51, 337)
        Label6.MaximumSize = New Size(400, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(392, 40)
        Label6.TabIndex = 36
        Label6.Text = "4. Pernah mengikuti bootcamp atau kursus bersertifikat (diluar sertifikasi vendor)?"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(RadioButton21)
        Controls.Add(RadioButton22)
        Controls.Add(Label6)
        Controls.Add(NumericUpDown3)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label4)
        Controls.Add(NumericUpDown2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Name = "Form8"
        Text = "Form8"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents RadioButton21 As RadioButton
    Friend WithEvents RadioButton22 As RadioButton
    Friend WithEvents Label6 As Label
End Class
