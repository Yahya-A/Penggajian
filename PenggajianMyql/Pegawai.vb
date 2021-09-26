Imports System.Data.Odbc

Public Class Pegawai

    Dim onUpdate, onDelete As Boolean

    Function generateKode() As String
        Dim kodeBuku, yr As String
        Dim lastKode As Integer
        Call Konek()
        CMD = New OdbcCommand("Select id_pegawai from pegawai order by id_pegawai desc", Conn)
        RD = CMD.ExecuteReader
        If RD.HasRows Then
            lastKode = RD.Item("id_pegawai") + 1
        Else
            lastKode = 1
        End If
        yr = DateTime.Now.ToString("yyyy")
        kodeBuku = "P" + "." + yr + "." + String.Format("{0:000#}", lastKode)
        txtkdpegawai.Text = kodeBuku

        Return kodeBuku
    End Function

    Function validasiInput() As Boolean
        Dim valid As Boolean
        If txtnik.Text = "" Then
            txtnik.Focus()
            valid = False
        ElseIf txtnamapegawai.Text = "" Then
            txtnamapegawai.Focus()
            valid = False
        ElseIf txttmplahir.Text = "" Then
            txttmplahir.Focus()
            valid = False
        ElseIf txtalamat.Text = "" Then
            txtalamat.Focus()
            valid = False
        ElseIf cbagama.SelectedIndex = 0 Then
            cbagama.Focus()
            valid = False
        ElseIf cbjabatan.SelectedIndex = 0 Then
            cbjabatan.Focus()
            valid = False
        ElseIf cbstatus.SelectedIndex = 0 Then
            cbstatus.Focus()
            valid = False
        Else
            valid = True
        End If

        Return valid
    End Function

    Sub TampilPegawai()
        Dim query As String
        Call Konek()
        query = "SELECT nip AS 'NIP', nama_pegawai AS 'Nama Pegawai', nama_jabatan AS 'Jabatan', alamat_pegawai AS 'Alamat', agama AS 'Agama', tempat_lahir AS 'Tempat Lahir', tanggal_lahir AS 'Tanggal Lahir', status AS 'Status' FROM `pegawai` JOIN `jabatan` ON pegawai.id_jabatan = jabatan.id_jabatan"
        DA = New OdbcDataAdapter(query, Conn)
        DS = New DataSet
        DA.Fill(DS, "pegawai")
        DataGridPegawai.DataSource = DS.Tables("pegawai")
        DataGridPegawai.ReadOnly = True
    End Sub

    Sub kondisiAwal()
        txtalamat.Enabled = False
        txtkdpegawai.Enabled = False
        txtnamapegawai.Enabled = False
        txtnik.Enabled = False
        txttmplahir.Enabled = False
        dttgllahir.Enabled = False
        cbagama.Enabled = False
        cbjabatan.Enabled = False
        cbstatus.Enabled = False
        btnbatal.Visible = False
    End Sub

    Sub ActionButton(ByVal tambah, ByVal ubah, ByVal hapus, ByVal batal)
        btntambah.Enabled = tambah
        btnubah.Enabled = ubah
        btnhapus.Enabled = hapus
        btnbatal.Visible = batal
        If hapus = False Then
            btnhapus.BackColor = Color.DarkGray
            btnhapus.Cursor = Cursors.No
        Else
            btnhapus.BackColor = Color.CornflowerBlue
            btnhapus.Cursor = Cursors.Hand
        End If

        If tambah = False Then
            btntambah.BackColor = Color.DarkGray
            btntambah.Cursor = Cursors.No
        Else
            btntambah.BackColor = Color.CornflowerBlue
            btntambah.Cursor = Cursors.Hand
        End If

        If ubah = False Then
            btnubah.BackColor = Color.DarkGray
            btnubah.Cursor = Cursors.No
        Else
            btnubah.BackColor = Color.CornflowerBlue
            btnubah.Cursor = Cursors.Hand
        End If
    End Sub

    Sub InputText(ByVal kdpegawai, ByVal nik, ByVal nama, ByVal tmplahir, ByVal tgllahir, ByVal agama, ByVal jabatan, ByVal status, ByVal alamat)
        txtkdpegawai.Enabled = kdpegawai
        txtnik.Enabled = nik
        txtnamapegawai.Enabled = nama
        txttmplahir.Enabled = tmplahir
        dttgllahir.Enabled = tgllahir
        cbagama.Enabled = agama
        cbjabatan.Enabled = jabatan
        cbstatus.Enabled = status
        txtalamat.Enabled = alamat
    End Sub

    Sub ResetInput()
        txtkdpegawai.Text = ""
        txtnamapegawai.Text = ""
        txtalamat.Text = ""
        txtnik.Text = ""
        txttmplahir.Text = ""

        cbagama.SelectedIndex = 0
        cbjabatan.SelectedIndex = 0
        cbstatus.SelectedIndex = 0
        txtkdpegawai.Enabled = False
    End Sub

    Sub Agama()
        cbagama.Items.Add("Pilih Agama")
        cbagama.Items.Add("Islam")
        cbagama.Items.Add("Kristen")
        cbagama.Items.Add("Hindu")
        cbagama.Items.Add("Budha")
        cbagama.Items.Add("Katholik")
        cbagama.SelectedIndex = cbagama.FindStringExact("Pilih Agama")
    End Sub

    Sub Status()
        cbstatus.Items.Add("Pilih Status")
        cbstatus.Items.Add("Aktif")
        cbstatus.Items.Add("Cuti")
        cbstatus.Items.Add("Tidak Aktif")
        cbstatus.SelectedIndex = cbstatus.FindStringExact("Pilih Status")
    End Sub

    Sub Jabatan()
        Call Konek()
        CMD = New OdbcCommand("Select * from jabatan", Conn)
        RD = CMD.ExecuteReader
        If Not RD.HasRows Then
            Dim comboJbt As New Dictionary(Of String, String)()
            comboJbt.Add(0, "Kosong")
            cbjabatan.SelectedIndex = cbjabatan.FindStringExact("Kosong")
            cbjabatan.DataSource = New BindingSource(comboJbt, Nothing)
            cbjabatan.DisplayMember = "Value"
            cbjabatan.ValueMember = "Key"
        Else
            Dim comboJbt As New Dictionary(Of String, String)()
            cbjabatan.SelectedIndex = cbjabatan.FindStringExact("Pilih Jabatan")
            comboJbt.Add(0, "Pilih Jabatan")
            Do While RD.Read
                comboJbt.Add(RD("id_jabatan"), RD("nama_jabatan"))
            Loop
            cbjabatan.DataSource = New BindingSource(comboJbt, Nothing)
            cbjabatan.DisplayMember = "Value"
            cbjabatan.ValueMember = "Key"
        End If
    End Sub

    Private Sub Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        Agama()
        Jabatan()
        Status()
        TampilPegawai()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim kdpegawai, nik, nama, tmplahir, tgllahir, agama, jabatan, alamat, status, kode As String
        kode = generateKode()
        If btntambah.Text = "Tambah" Then
            ActionButton(True, False, False, True)
            InputText(False, True, True, True, True, True, True, True, True)
            generateKode()
            txtnik.Focus()
            btntambah.Text = "Simpan"
        ElseIf btntambah.Text = "Simpan" Then
            kdpegawai = kode
            nik = txtnik.Text
            nama = txtnamapegawai.Text
            tmplahir = txttmplahir.Text
            alamat = txtalamat.Text
            tgllahir = dttgllahir.Value.ToString("yyyy-MM-dd")
            agama = cbagama.Items(cbagama.SelectedIndex).ToString
            jabatan = DirectCast(cbjabatan.SelectedItem, KeyValuePair(Of String, String)).Key
            status = cbstatus.Items(cbstatus.SelectedIndex).ToString

            If validasiInput() = False Then
                MsgBox("Inputan tidak boleh kosong")
            Else
                SimpanBaru(kdpegawai, nik, nama, tmplahir, tgllahir, agama, jabatan, status, alamat)
                generateKode()
            End If

        End If
    End Sub

    Sub SimpanBaru(ByVal kdpegawai, ByVal nik, ByVal nama, ByVal tmplahir, ByVal tgllahir, ByVal agama, ByVal jabatan, ByVal status, ByVal alamat)

        Dim simpan As String = "insert into pegawai values ('','" & kdpegawai & "','" & nik & "','" & nama & "','" & alamat & "','" & agama & "','" & tmplahir & "','" & tgllahir & "','" & status & "','" & jabatan & "')"
        CMD = New OdbcCommand(simpan, Conn)
        CMD.ExecuteNonQuery()

        MsgBox("Pegawai berhasil diinput")
        Call TampilPegawai()
        Call ResetInput()

    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        ActionButton(True, True, True, False)
        InputText(False, False, False, False, False, False, False, False, False)
        ResetInput()
        btntambah.Text = "Tambah"
        btnubah.Text = "Ubah"
        onUpdate = False
        onDelete = False
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        Dim nik, nama, tmplahir, tgllahir, agama, jabatan, alamat, status, id_pegawai As String

        If btnubah.Text = "Ubah" Then
            onUpdate = True
            InputText(True, False, False, False, False, False, False, False, False)
            ActionButton(False, True, False, True)
            txtkdpegawai.Focus()
            btnubah.Text = "Simpan"
        ElseIf btnubah.Text = "Simpan" Then
            nik = txtnik.Text
            nama = txtnamapegawai.Text
            tmplahir = txttmplahir.Text
            alamat = txtalamat.Text
            tgllahir = dttgllahir.Value.ToString("yyyy-MM-dd")
            agama = cbagama.Items(cbagama.SelectedIndex).ToString
            jabatan = DirectCast(cbjabatan.SelectedItem, KeyValuePair(Of String, String)).Key
            status = cbstatus.Items(cbstatus.SelectedIndex).ToString
            id_pegawai = txtidpeg.Text

            If validasiInput() = False Then
                MsgBox("Inputan tidak boleh kosong")
            Else
                SimpanUpdate(id_pegawai, nik, nama, tmplahir, tgllahir, agama, jabatan, status, alamat)
            End If
        End If
    End Sub

    Sub SimpanUpdate(ByVal id_pegawai, ByVal nik, ByVal nama, ByVal tmplahir, ByVal tgllahir, ByVal agama, ByVal jabatan, ByVal status, ByVal alamat)

        Dim edit As String = "update pegawai set nama_pegawai='" & nama & "', alamat_pegawai='" & alamat & "', agama='" & agama & "', tempat_lahir='" & tmplahir & "', tanggal_lahir='" & tgllahir & "', status='" & status & "', id_jabatan='" & jabatan & "' where id_pegawai='" & id_pegawai & "'"
        CMD = New OdbcCommand(edit, Conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil diupdate")
        Call TampilPegawai()
        Call ResetInput()
        txtkdpegawai.Enabled = True
        txtkdpegawai.Focus()
        InputText(True, False, False, False, False, False, False, False, False)

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If onDelete = True Then
            If MessageBox.Show("Data pegawai yang dihapus tidak dapat dikembalikan. Yakin ingin menghapus data ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Konek()
                Dim hapus As String = "delete From pegawai where nip='" & txtkdpegawai.Text & "'"
                CMD = New OdbcCommand(hapus, Conn)
                CMD.ExecuteNonQuery()
                TampilPegawai()
                ResetInput()
                MsgBox("Data berhasil dihapus")
                txtkdpegawai.Enabled = True
                txtkdpegawai.Focus()
            End If
        Else
            onDelete = True
            InputText(True, False, False, False, False, False, False, False, False)
            ActionButton(False, False, True, True)
            txtkdpegawai.Enabled = True
            txtkdpegawai.Focus()
        End If
    End Sub

    Private Sub txtkdpegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkdpegawai.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If onUpdate = True Then
                Call Konek()
                CMD = New OdbcCommand("Select pegawai.*, jabatan.nama_jabatan From pegawai Join jabatan ON pegawai.id_jabatan = jabatan.id_jabatan where nip ='" & txtkdpegawai.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If Not RD.HasRows Then
                    MsgBox("Pegawai tidak ditemukan!")
                    txtkdpegawai.Focus()
                Else
                    InputText(True, True, True, True, True, True, True, True, True)
                    txtidpeg.Text = RD.Item("id_pegawai")
                    txtkdpegawai.Text = RD.Item("nip")
                    txtnik.Text = RD.Item("nik")
                    txtnamapegawai.Text = RD.Item("nama_pegawai")
                    txtalamat.Text = RD.Item("alamat_pegawai")
                    txttmplahir.Text = RD.Item("tempat_lahir")
                    dttgllahir.Value = RD.Item("tanggal_lahir")
                    cbstatus.SelectedIndex = cbstatus.FindStringExact(RD.Item("status"))
                    cbagama.SelectedIndex = cbagama.FindStringExact(RD.Item("agama"))
                    cbjabatan.SelectedIndex = cbjabatan.FindStringExact(RD.Item("nama_jabatan"))
                    txtnamapegawai.Focus()
                End If
            End If
        End If
    End Sub
End Class