<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penggajian
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.txtidpeg = New System.Windows.Forms.TextBox()
        Me.txtidjabatan = New System.Windows.Forms.TextBox()
        Me.txtkd = New System.Windows.Forms.MaskedTextBox()
        Me.btncari = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.dtpenggajian = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.txtjabatan = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.txtnip = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblgajibersih = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblpotongan = New System.Windows.Forms.Label()
        Me.lbltotalgator = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lbltotalpotongan = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblpjkpenghasilan = New System.Windows.Forms.Label()
        Me.lblbpjs = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblgator = New System.Windows.Forms.Label()
        Me.lbltunjangan = New System.Windows.Forms.Label()
        Me.lblgapok = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btncetak)
        Me.Panel1.Controls.Add(Me.txtidpeg)
        Me.Panel1.Controls.Add(Me.txtidjabatan)
        Me.Panel1.Controls.Add(Me.txtkd)
        Me.Panel1.Controls.Add(Me.btncari)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnbatal)
        Me.Panel1.Controls.Add(Me.btntambah)
        Me.Panel1.Controls.Add(Me.dtpenggajian)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 511)
        Me.Panel1.TabIndex = 0
        '
        'btncetak
        '
        Me.btncetak.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btncetak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncetak.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btncetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncetak.Location = New System.Drawing.Point(228, 457)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(90, 30)
        Me.btncetak.TabIndex = 32
        Me.btncetak.Text = "Cetak Slip"
        Me.btncetak.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncetak.UseVisualStyleBackColor = False
        '
        'txtidpeg
        '
        Me.txtidpeg.Location = New System.Drawing.Point(16, 324)
        Me.txtidpeg.Name = "txtidpeg"
        Me.txtidpeg.Size = New System.Drawing.Size(42, 20)
        Me.txtidpeg.TabIndex = 30
        Me.txtidpeg.Visible = False
        '
        'txtidjabatan
        '
        Me.txtidjabatan.Location = New System.Drawing.Point(74, 324)
        Me.txtidjabatan.Name = "txtidjabatan"
        Me.txtidjabatan.Size = New System.Drawing.Size(42, 20)
        Me.txtidjabatan.TabIndex = 31
        Me.txtidjabatan.Visible = False
        '
        'txtkd
        '
        Me.txtkd.Location = New System.Drawing.Point(17, 36)
        Me.txtkd.Mask = "P.0000.0000"
        Me.txtkd.Name = "txtkd"
        Me.txtkd.Size = New System.Drawing.Size(223, 20)
        Me.txtkd.TabIndex = 29
        '
        'btncari
        '
        Me.btncari.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btncari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncari.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btncari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncari.Location = New System.Drawing.Point(246, 32)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(90, 27)
        Me.btncari.TabIndex = 27
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Tanggal Penggajian"
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Crimson
        Me.btnbatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnbatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbatal.Location = New System.Drawing.Point(123, 457)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(90, 30)
        Me.btnbatal.TabIndex = 25
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btntambah
        '
        Me.btntambah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btntambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntambah.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btntambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btntambah.Location = New System.Drawing.Point(17, 457)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(90, 30)
        Me.btntambah.TabIndex = 20
        Me.btntambah.Text = "Simpan"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'dtpenggajian
        '
        Me.dtpenggajian.Enabled = False
        Me.dtpenggajian.Location = New System.Drawing.Point(17, 366)
        Me.dtpenggajian.Name = "dtpenggajian"
        Me.dtpenggajian.Size = New System.Drawing.Size(196, 20)
        Me.dtpenggajian.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtalamat)
        Me.GroupBox2.Controls.Add(Me.txtstatus)
        Me.GroupBox2.Controls.Add(Me.txtjabatan)
        Me.GroupBox2.Controls.Add(Me.txtnama)
        Me.GroupBox2.Controls.Add(Me.txtnip)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 242)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Pegawai"
        '
        'txtalamat
        '
        Me.txtalamat.Enabled = False
        Me.txtalamat.Location = New System.Drawing.Point(75, 181)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(287, 41)
        Me.txtalamat.TabIndex = 9
        '
        'txtstatus
        '
        Me.txtstatus.Enabled = False
        Me.txtstatus.Location = New System.Drawing.Point(75, 144)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(287, 20)
        Me.txtstatus.TabIndex = 8
        '
        'txtjabatan
        '
        Me.txtjabatan.Enabled = False
        Me.txtjabatan.Location = New System.Drawing.Point(75, 107)
        Me.txtjabatan.Name = "txtjabatan"
        Me.txtjabatan.Size = New System.Drawing.Size(287, 20)
        Me.txtjabatan.TabIndex = 7
        '
        'txtnama
        '
        Me.txtnama.Enabled = False
        Me.txtnama.Location = New System.Drawing.Point(75, 69)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(287, 20)
        Me.txtnama.TabIndex = 6
        '
        'txtnip
        '
        Me.txtnip.Enabled = False
        Me.txtnip.Location = New System.Drawing.Point(75, 32)
        Me.txtnip.Name = "txtnip"
        Me.txtnip.Size = New System.Drawing.Size(287, 20)
        Me.txtnip.TabIndex = 5
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(16, 184)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(39, 13)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "Alamat"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 147)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(37, 13)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "Status"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 110)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(45, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Jabatan"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(16, 35)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(25, 13)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "NIP"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(16, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(35, 13)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Induk Pegawai"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblgajibersih)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.lblpotongan)
        Me.GroupBox1.Controls.Add(Me.lbltotalgator)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.lbltotalpotongan)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.lblpjkpenghasilan)
        Me.GroupBox1.Controls.Add(Me.lblbpjs)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblgator)
        Me.GroupBox1.Controls.Add(Me.lbltunjangan)
        Me.GroupBox1.Controls.Add(Me.lblgapok)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(435, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 511)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rincian Gaji"
        '
        'lblgajibersih
        '
        Me.lblgajibersih.AutoSize = True
        Me.lblgajibersih.Location = New System.Drawing.Point(282, 472)
        Me.lblgajibersih.Name = "lblgajibersih"
        Me.lblgajibersih.Size = New System.Drawing.Size(33, 13)
        Me.lblgajibersih.TabIndex = 23
        Me.lblgajibersih.Text = "Rp. 0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(23, 472)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(36, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Total"
        '
        'lblpotongan
        '
        Me.lblpotongan.AutoSize = True
        Me.lblpotongan.Location = New System.Drawing.Point(282, 425)
        Me.lblpotongan.Name = "lblpotongan"
        Me.lblpotongan.Size = New System.Drawing.Size(33, 13)
        Me.lblpotongan.TabIndex = 21
        Me.lblpotongan.Text = "Rp. 0"
        '
        'lbltotalgator
        '
        Me.lbltotalgator.AutoSize = True
        Me.lbltotalgator.Location = New System.Drawing.Point(282, 392)
        Me.lbltotalgator.Name = "lbltotalgator"
        Me.lbltotalgator.Size = New System.Drawing.Size(33, 13)
        Me.lbltotalgator.TabIndex = 20
        Me.lbltotalgator.Text = "Rp. 0"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(13, 448)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(367, 13)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "---------------------------------------------------------------------------------" & _
    "---------------------------------------"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(23, 425)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 13)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "Total Potongan"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(23, 392)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 13)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Gaji Kotor"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(23, 356)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 16)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Gaji Bersih"
        '
        'lbltotalpotongan
        '
        Me.lbltotalpotongan.AutoSize = True
        Me.lbltotalpotongan.Location = New System.Drawing.Point(282, 305)
        Me.lbltotalpotongan.Name = "lbltotalpotongan"
        Me.lbltotalpotongan.Size = New System.Drawing.Size(33, 13)
        Me.lbltotalpotongan.TabIndex = 15
        Me.lbltotalpotongan.Text = "Rp. 0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(23, 305)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Total Potongan"
        '
        'lblpjkpenghasilan
        '
        Me.lblpjkpenghasilan.AutoSize = True
        Me.lblpjkpenghasilan.Location = New System.Drawing.Point(282, 258)
        Me.lblpjkpenghasilan.Name = "lblpjkpenghasilan"
        Me.lblpjkpenghasilan.Size = New System.Drawing.Size(33, 13)
        Me.lblpjkpenghasilan.TabIndex = 13
        Me.lblpjkpenghasilan.Text = "Rp. 0"
        '
        'lblbpjs
        '
        Me.lblbpjs.AutoSize = True
        Me.lblbpjs.Location = New System.Drawing.Point(282, 225)
        Me.lblbpjs.Name = "lblbpjs"
        Me.lblbpjs.Size = New System.Drawing.Size(33, 13)
        Me.lblbpjs.TabIndex = 12
        Me.lblbpjs.Text = "Rp. 0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 281)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(367, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "---------------------------------------------------------------------------------" & _
    "---------------------------------------"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 258)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Pajak Penghasilan (6% gapok)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "BPJS (2% gapok)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(23, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Potongan"
        '
        'lblgator
        '
        Me.lblgator.AutoSize = True
        Me.lblgator.Location = New System.Drawing.Point(282, 143)
        Me.lblgator.Name = "lblgator"
        Me.lblgator.Size = New System.Drawing.Size(33, 13)
        Me.lblgator.TabIndex = 7
        Me.lblgator.Text = "Rp. 0"
        '
        'lbltunjangan
        '
        Me.lbltunjangan.AutoSize = True
        Me.lbltunjangan.Location = New System.Drawing.Point(282, 98)
        Me.lbltunjangan.Name = "lbltunjangan"
        Me.lbltunjangan.Size = New System.Drawing.Size(33, 13)
        Me.lbltunjangan.TabIndex = 6
        Me.lbltunjangan.Text = "Rp. 0"
        '
        'lblgapok
        '
        Me.lblgapok.AutoSize = True
        Me.lblgapok.Location = New System.Drawing.Point(282, 65)
        Me.lblgapok.Name = "lblgapok"
        Me.lblgapok.Size = New System.Drawing.Size(33, 13)
        Me.lblgapok.TabIndex = 5
        Me.lblgapok.Text = "Rp. 0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(367, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "---------------------------------------------------------------------------------" & _
    "---------------------------------------"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Gaji Kotor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tunjangan Fungsional"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Gaji Pokok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Penghasilan"
        '
        'Penggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Penggajian"
        Me.Text = "Penggajian"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpenggajian As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents lblgajibersih As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblpotongan As System.Windows.Forms.Label
    Friend WithEvents lbltotalgator As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lbltotalpotongan As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblpjkpenghasilan As System.Windows.Forms.Label
    Friend WithEvents lblbpjs As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblgator As System.Windows.Forms.Label
    Friend WithEvents lbltunjangan As System.Windows.Forms.Label
    Friend WithEvents lblgapok As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents txtjabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button
    Friend WithEvents txtkd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtnip As System.Windows.Forms.TextBox
    Friend WithEvents txtidpeg As System.Windows.Forms.TextBox
    Friend WithEvents txtidjabatan As System.Windows.Forms.TextBox
    Friend WithEvents btncetak As System.Windows.Forms.Button
End Class
