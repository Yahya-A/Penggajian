<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pegawai
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
        Me.gbmasterpegawai = New System.Windows.Forms.GroupBox()
        Me.txtkdpegawai = New System.Windows.Forms.MaskedTextBox()
        Me.txtidpeg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.cbjabatan = New System.Windows.Forms.ComboBox()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.dttgllahir = New System.Windows.Forms.DateTimePicker()
        Me.txttmplahir = New System.Windows.Forms.TextBox()
        Me.txtnamapegawai = New System.Windows.Forms.TextBox()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridPegawai = New System.Windows.Forms.DataGridView()
        Me.gbmasterpegawai.SuspendLayout()
        CType(Me.DataGridPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbmasterpegawai
        '
        Me.gbmasterpegawai.BackColor = System.Drawing.SystemColors.Control
        Me.gbmasterpegawai.Controls.Add(Me.txtkdpegawai)
        Me.gbmasterpegawai.Controls.Add(Me.txtidpeg)
        Me.gbmasterpegawai.Controls.Add(Me.Label1)
        Me.gbmasterpegawai.Controls.Add(Me.btnbatal)
        Me.gbmasterpegawai.Controls.Add(Me.btnhapus)
        Me.gbmasterpegawai.Controls.Add(Me.btnubah)
        Me.gbmasterpegawai.Controls.Add(Me.btntambah)
        Me.gbmasterpegawai.Controls.Add(Me.cbstatus)
        Me.gbmasterpegawai.Controls.Add(Me.txtalamat)
        Me.gbmasterpegawai.Controls.Add(Me.cbjabatan)
        Me.gbmasterpegawai.Controls.Add(Me.cbagama)
        Me.gbmasterpegawai.Controls.Add(Me.dttgllahir)
        Me.gbmasterpegawai.Controls.Add(Me.txttmplahir)
        Me.gbmasterpegawai.Controls.Add(Me.txtnamapegawai)
        Me.gbmasterpegawai.Controls.Add(Me.txtnik)
        Me.gbmasterpegawai.Controls.Add(Me.Label11)
        Me.gbmasterpegawai.Controls.Add(Me.Label10)
        Me.gbmasterpegawai.Controls.Add(Me.Label9)
        Me.gbmasterpegawai.Controls.Add(Me.Label8)
        Me.gbmasterpegawai.Controls.Add(Me.Label7)
        Me.gbmasterpegawai.Controls.Add(Me.Label6)
        Me.gbmasterpegawai.Controls.Add(Me.Label5)
        Me.gbmasterpegawai.Controls.Add(Me.Label4)
        Me.gbmasterpegawai.Location = New System.Drawing.Point(12, 12)
        Me.gbmasterpegawai.Name = "gbmasterpegawai"
        Me.gbmasterpegawai.Size = New System.Drawing.Size(849, 305)
        Me.gbmasterpegawai.TabIndex = 1
        Me.gbmasterpegawai.TabStop = False
        Me.gbmasterpegawai.Text = "Form Data Pegawai"
        '
        'txtkdpegawai
        '
        Me.txtkdpegawai.Location = New System.Drawing.Point(27, 50)
        Me.txtkdpegawai.Mask = "P.0000.0000"
        Me.txtkdpegawai.Name = "txtkdpegawai"
        Me.txtkdpegawai.Size = New System.Drawing.Size(378, 20)
        Me.txtkdpegawai.TabIndex = 28
        '
        'txtidpeg
        '
        Me.txtidpeg.Location = New System.Drawing.Point(27, 219)
        Me.txtidpeg.Name = "txtidpeg"
        Me.txtidpeg.Size = New System.Drawing.Size(40, 20)
        Me.txtidpeg.TabIndex = 27
        Me.txtidpeg.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Pegawai"
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Crimson
        Me.btnbatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnbatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbatal.Location = New System.Drawing.Point(315, 256)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(90, 30)
        Me.btnbatal.TabIndex = 24
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.Crimson
        Me.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnhapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnhapus.Location = New System.Drawing.Point(219, 256)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(90, 30)
        Me.btnhapus.TabIndex = 23
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnubah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnubah.Location = New System.Drawing.Point(123, 256)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(90, 30)
        Me.btnubah.TabIndex = 22
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btntambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(27, 256)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(90, 30)
        Me.btntambah.TabIndex = 19
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'cbstatus
        '
        Me.cbstatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Location = New System.Drawing.Point(466, 146)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(357, 21)
        Me.cbstatus.TabIndex = 15
        '
        'txtalamat
        '
        Me.txtalamat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtalamat.Location = New System.Drawing.Point(466, 198)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(357, 88)
        Me.txtalamat.TabIndex = 14
        '
        'cbjabatan
        '
        Me.cbjabatan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbjabatan.FormattingEnabled = True
        Me.cbjabatan.Location = New System.Drawing.Point(466, 97)
        Me.cbjabatan.Name = "cbjabatan"
        Me.cbjabatan.Size = New System.Drawing.Size(357, 21)
        Me.cbjabatan.TabIndex = 13
        '
        'cbagama
        '
        Me.cbagama.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Location = New System.Drawing.Point(466, 50)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(357, 21)
        Me.cbagama.TabIndex = 12
        '
        'dttgllahir
        '
        Me.dttgllahir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dttgllahir.Location = New System.Drawing.Point(185, 193)
        Me.dttgllahir.Name = "dttgllahir"
        Me.dttgllahir.Size = New System.Drawing.Size(220, 20)
        Me.dttgllahir.TabIndex = 11
        '
        'txttmplahir
        '
        Me.txttmplahir.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttmplahir.Location = New System.Drawing.Point(27, 193)
        Me.txttmplahir.Name = "txttmplahir"
        Me.txttmplahir.Size = New System.Drawing.Size(140, 20)
        Me.txttmplahir.TabIndex = 10
        '
        'txtnamapegawai
        '
        Me.txtnamapegawai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnamapegawai.Location = New System.Drawing.Point(27, 144)
        Me.txtnamapegawai.Name = "txtnamapegawai"
        Me.txtnamapegawai.Size = New System.Drawing.Size(378, 20)
        Me.txtnamapegawai.TabIndex = 9
        '
        'txtnik
        '
        Me.txtnik.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnik.Location = New System.Drawing.Point(27, 97)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(378, 20)
        Me.txtnik.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(463, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Jabatan"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(463, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Status"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(182, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Tanggal Lahir"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Tempat Lahir"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(463, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(463, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Agama"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nama Pegawai"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "NIK"
        '
        'DataGridPegawai
        '
        Me.DataGridPegawai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridPegawai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPegawai.Location = New System.Drawing.Point(12, 322)
        Me.DataGridPegawai.Name = "DataGridPegawai"
        Me.DataGridPegawai.Size = New System.Drawing.Size(851, 240)
        Me.DataGridPegawai.TabIndex = 2
        '
        'Pegawai
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(875, 574)
        Me.Controls.Add(Me.DataGridPegawai)
        Me.Controls.Add(Me.gbmasterpegawai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pegawai"
        Me.gbmasterpegawai.ResumeLayout(False)
        Me.gbmasterpegawai.PerformLayout()
        CType(Me.DataGridPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbmasterpegawai As System.Windows.Forms.GroupBox
    Friend WithEvents cbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents cbjabatan As System.Windows.Forms.ComboBox
    Friend WithEvents cbagama As System.Windows.Forms.ComboBox
    Friend WithEvents dttgllahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttmplahir As System.Windows.Forms.TextBox
    Friend WithEvents txtnamapegawai As System.Windows.Forms.TextBox
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents DataGridPegawai As System.Windows.Forms.DataGridView
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidpeg As System.Windows.Forms.TextBox
    Friend WithEvents txtkdpegawai As System.Windows.Forms.MaskedTextBox
End Class
