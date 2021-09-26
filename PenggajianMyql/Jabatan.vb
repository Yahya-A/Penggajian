Imports System.Data.Odbc

Public Class Jabatan

    Dim onUpdate, onDelete As Boolean

    Function validasiInput() As Boolean
        Dim valid As Boolean
        If txtnamajabatan.Text = "" Then
            txtnamajabatan.Focus()
            valid = False
        ElseIf txtgapok.Text = "" Then
            txtgapok.Focus()
            valid = False
        ElseIf txtkdjabatan.Text = "" Then
            txtkdjabatan.Focus()
            valid = False
        ElseIf txttunjangan.Text = "" Then
            txttunjangan.Focus()
            valid = False
        Else
            valid = True
        End If

        Return valid
    End Function

    Function checkKode(kdjabatan, idjabatan) As Boolean
        Dim unique As Boolean
        Call Konek()
        CMD = New OdbcCommand("Select * From jabatan where kode_jabatan ='" & kdjabatan & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()

        If Not RD.HasRows Then
            unique = True
        Else
            If RD.Item("id_jabatan") = idjabatan Then
                unique = True
            Else
                unique = False
            End If
        End If


        Return unique
    End Function

    Sub TampilJabatan()
        Dim query As String
        Call Konek()
        query = "SELECT kode_jabatan AS 'Kode Jabatan', nama_jabatan AS 'Jabatan', gaji_pokok AS 'Gaji', tunjangan_fungsional AS 'Tunjangan Fungsional' FROM `jabatan`"
        DA = New OdbcDataAdapter(query, Conn)
        DS = New DataSet
        DA.Fill(DS, "jabatan")
        DataGridJabatan.DataSource = DS.Tables("jabatan")
        DataGridJabatan.ReadOnly = True
    End Sub

    Sub kondisiAwal()
        txtkdjabatan.Enabled = False
        txtgapok.Enabled = False
        txtnamajabatan.Enabled = False
        txttunjangan.Enabled = False
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

    Sub InputText(ByVal kdjabatan, ByVal nmjabatan, ByVal gapok, ByVal tunjangan)
        txtkdjabatan.Enabled = kdjabatan
        txtnamajabatan.Enabled = nmjabatan
        txtgapok.Enabled = gapok
        txttunjangan.Enabled = tunjangan
    End Sub

    Sub ResetInput()
        txtkdjabatan.Text = ""
        txtgapok.Text = ""
        txtnamajabatan.Text = ""
        txttunjangan.Text = ""
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim kdjabatan, namajabatan, gapok, tunjangan As String

        If btntambah.Text = "Tambah" Then
            ActionButton(True, False, False, True)
            InputText(True, True, True, True)
            txtkdjabatan.Focus()
            btntambah.Text = "Simpan"
        ElseIf btntambah.Text = "Simpan" Then
            kdjabatan = txtkdjabatan.Text
            namajabatan = txtnamajabatan.Text
            gapok = txtgapok.Text
            tunjangan = txttunjangan.Text

            If validasiInput() = False Then
                MsgBox("Inputan tidak boleh kosong")
            Else
                SimpanBaru(kdjabatan, namajabatan, gapok, tunjangan)
            End If

        End If
    End Sub

    Sub SimpanBaru(ByVal kdjabatan, ByVal nama, ByVal gaji, ByVal tunjangan)
        Dim check As Boolean
        check = checkKode(kdjabatan, -1)

        If check Then
            Dim simpan As String = "insert into jabatan values ('','" & kdjabatan & "','" & nama & "','" & gaji & "','" & tunjangan & "')"
            CMD = New OdbcCommand(simpan, Conn)
            CMD.ExecuteNonQuery()

            MsgBox("Jabatan berhasil diinput")
            Call TampilJabatan()
            Call ResetInput()
        Else
            MsgBox("Kode jabatan sudah digunakan")
            txtkdjabatan.Focus()
        End If

    End Sub

    Private Sub Jabatan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        InputText(False, False, False, False)
        TampilJabatan()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        ActionButton(True, True, True, False)
        InputText(False, False, False, False)
        ResetInput()
        btntambah.Text = "Tambah"
        btnubah.Text = "Ubah"
        onUpdate = False
        onDelete = False
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        Dim kdjabatan, namajabatan, gapok, tunjangan, id_jabatan As String
        If btnubah.Text = "Ubah" Then
            onUpdate = True
            InputText(True, False, False, False)
            ActionButton(False, True, False, True)
            txtkdjabatan.Focus()
            btnubah.Text = "Simpan"
        ElseIf btnubah.Text = "Simpan" Then
            kdjabatan = txtkdjabatan.Text
            namajabatan = txtnamajabatan.Text
            gapok = txtgapok.Text
            tunjangan = txttunjangan.Text
            id_jabatan = txtidjabatan.Text

            If validasiInput() = False Then
                MsgBox("Inputan tidak boleh kosong")
            Else
                SimpanUpdate(id_jabatan, kdjabatan, namajabatan, gapok, tunjangan)
            End If
        End If
    End Sub

    Sub SimpanUpdate(ByVal id_jabatan, ByVal kdjabatan, ByVal nama, ByVal gapok, ByVal tunjangan)
        Dim check As Boolean
        check = checkKode(kdjabatan, id_jabatan)
        If check Then
            Dim edit As String = "update jabatan set kode_jabatan='" & kdjabatan & "', nama_jabatan='" & nama & "', gaji_pokok='" & gapok & "', tunjangan_fungsional='" & tunjangan & "' where id_jabatan='" & id_jabatan & "'"
            CMD = New OdbcCommand(edit, Conn)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil diupdate")
            Call TampilJabatan()
            Call ResetInput()
            txtkdjabatan.Enabled = True
            txtkdjabatan.Focus()
            InputText(True, False, False, False)
        Else
            MsgBox("Kode jabatan sudah digunakan")
            txtkdjabatan.Focus()
        End If

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If onDelete = True Then
            If MessageBox.Show("Data jabatan yang dihapus tidak dapat dikembalikan. Yakin ingin menghapus data ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Call Konek()
                Dim hapus As String = "delete From jabatan where kode_jabatan='" & txtkdjabatan.Text & "'"
                CMD = New OdbcCommand(hapus, Conn)
                CMD.ExecuteNonQuery()
                TampilJabatan()
                ResetInput()
                MsgBox("Data berhasil dihapus")
                txtkdjabatan.Enabled = True
                txtkdjabatan.Focus()
            End If
        Else
            onDelete = True
            InputText(True, False, False, False)
            ActionButton(False, False, True, True)
            txtkdjabatan.Enabled = True
            txtkdjabatan.Focus()
        End If
    End Sub

    Private Sub txtkdjabatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtkdjabatan.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            If onUpdate = True Then
                Call Konek()
                CMD = New OdbcCommand("Select * From jabatan where kode_jabatan ='" & txtkdjabatan.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If Not RD.HasRows Then
                    MsgBox("Kode jabatan tidak ditemukan!")
                    txtkdjabatan.Focus()
                Else
                    InputText(True, True, True, True)
                    txtidjabatan.Text = RD.Item("id_jabatan")
                    txtkdjabatan.Text = RD.Item("kode_jabatan")
                    txtnamajabatan.Text = RD.Item("nama_jabatan")
                    txtgapok.Text = RD.Item("gaji_pokok")
                    txttunjangan.Text = RD.Item("tunjangan_fungsional")
                    txtkdjabatan.Focus()
                End If
            End If
        End If
    End Sub
End Class