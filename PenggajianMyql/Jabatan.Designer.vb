<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jabatan
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
        Me.DataGridJabatan = New System.Windows.Forms.DataGridView()
        Me.txtidjabatan = New System.Windows.Forms.TextBox()
        Me.txtkdjabatan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtgapok = New System.Windows.Forms.TextBox()
        Me.txtnamajabatan = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbmasterpegawai = New System.Windows.Forms.GroupBox()
        Me.txttunjangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridJabatan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbmasterpegawai.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridJabatan
        '
        Me.DataGridJabatan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridJabatan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridJabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridJabatan.Location = New System.Drawing.Point(12, 279)
        Me.DataGridJabatan.Name = "DataGridJabatan"
        Me.DataGridJabatan.Size = New System.Drawing.Size(851, 283)
        Me.DataGridJabatan.TabIndex = 4
        '
        'txtidjabatan
        '
        Me.txtidjabatan.Location = New System.Drawing.Point(27, 170)
        Me.txtidjabatan.Name = "txtidjabatan"
        Me.txtidjabatan.Size = New System.Drawing.Size(40, 20)
        Me.txtidjabatan.TabIndex = 27
        Me.txtidjabatan.Visible = False
        '
        'txtkdjabatan
        '
        Me.txtkdjabatan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtkdjabatan.Location = New System.Drawing.Point(27, 50)
        Me.txtkdjabatan.Name = "txtkdjabatan"
        Me.txtkdjabatan.Size = New System.Drawing.Size(378, 20)
        Me.txtkdjabatan.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Kode Jabatan"
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.Crimson
        Me.btnbatal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnbatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbatal.Location = New System.Drawing.Point(315, 210)
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
        Me.btnhapus.Location = New System.Drawing.Point(219, 210)
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
        Me.btnubah.Location = New System.Drawing.Point(123, 210)
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
        Me.btntambah.Location = New System.Drawing.Point(27, 210)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(90, 30)
        Me.btntambah.TabIndex = 19
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = False
        '
        'txtgapok
        '
        Me.txtgapok.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtgapok.Location = New System.Drawing.Point(27, 144)
        Me.txtgapok.Name = "txtgapok"
        Me.txtgapok.Size = New System.Drawing.Size(378, 20)
        Me.txtgapok.TabIndex = 9
        '
        'txtnamajabatan
        '
        Me.txtnamajabatan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnamajabatan.Location = New System.Drawing.Point(27, 97)
        Me.txtnamajabatan.Name = "txtnamajabatan"
        Me.txtnamajabatan.Size = New System.Drawing.Size(378, 20)
        Me.txtnamajabatan.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Gaji Pokok"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nama Jabatan"
        '
        'gbmasterpegawai
        '
        Me.gbmasterpegawai.BackColor = System.Drawing.SystemColors.Control
        Me.gbmasterpegawai.Controls.Add(Me.txttunjangan)
        Me.gbmasterpegawai.Controls.Add(Me.Label2)
        Me.gbmasterpegawai.Controls.Add(Me.txtidjabatan)
        Me.gbmasterpegawai.Controls.Add(Me.txtkdjabatan)
        Me.gbmasterpegawai.Controls.Add(Me.Label1)
        Me.gbmasterpegawai.Controls.Add(Me.btnbatal)
        Me.gbmasterpegawai.Controls.Add(Me.btnhapus)
        Me.gbmasterpegawai.Controls.Add(Me.btnubah)
        Me.gbmasterpegawai.Controls.Add(Me.btntambah)
        Me.gbmasterpegawai.Controls.Add(Me.txtgapok)
        Me.gbmasterpegawai.Controls.Add(Me.txtnamajabatan)
        Me.gbmasterpegawai.Controls.Add(Me.Label5)
        Me.gbmasterpegawai.Controls.Add(Me.Label4)
        Me.gbmasterpegawai.Location = New System.Drawing.Point(12, 12)
        Me.gbmasterpegawai.Name = "gbmasterpegawai"
        Me.gbmasterpegawai.Size = New System.Drawing.Size(849, 261)
        Me.gbmasterpegawai.TabIndex = 3
        Me.gbmasterpegawai.TabStop = False
        Me.gbmasterpegawai.Text = "Form Data Jabatan"
        '
        'txttunjangan
        '
        Me.txttunjangan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttunjangan.Location = New System.Drawing.Point(439, 50)
        Me.txttunjangan.Name = "txttunjangan"
        Me.txttunjangan.Size = New System.Drawing.Size(378, 20)
        Me.txttunjangan.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(436, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Tunjangan Fungsional"
        '
        'Jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(875, 574)
        Me.Controls.Add(Me.DataGridJabatan)
        Me.Controls.Add(Me.gbmasterpegawai)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Jabatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Jabatan"
        CType(Me.DataGridJabatan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbmasterpegawai.ResumeLayout(False)
        Me.gbmasterpegawai.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridJabatan As System.Windows.Forms.DataGridView
    Friend WithEvents txtidjabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtkdjabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents txtgapok As System.Windows.Forms.TextBox
    Friend WithEvents txtnamajabatan As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents gbmasterpegawai As System.Windows.Forms.GroupBox
    Friend WithEvents txttunjangan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
