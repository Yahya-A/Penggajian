Imports System.Data.Odbc

Public Class Penggajian

    Dim total_potongan, bpjs, pp, gapok, gator, gaber, tunj_fungsional As Integer

    Sub kondisiAwal()
        dtpenggajian.Enabled = False
        btntambah.Visible = False
        btnbatal.Visible = False
        btncetak.Visible = False

    End Sub

    Sub ActionBtn(dtgaji, batal, tambah, cetak, cetakenable)
        dtpenggajian.Enabled = dtgaji
        btnbatal.Visible = batal
        btntambah.Visible = tambah
        btncetak.Visible = cetak
        btncetak.Enabled = cetakenable
        If cetakenable = False Then
            btncetak.BackColor = Color.DarkGray
            btncetak.Cursor = Cursors.No
        Else
            btncetak.BackColor = Color.CornflowerBlue
            btncetak.Cursor = Cursors.Hand
        End If
    End Sub

    Sub ResetAll()
        Dim nominal As String
        nominal = "Rp. 0"

        txtkd.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txtidjabatan.Text = ""
        txtjabatan.Text = ""
        txtnip.Text = ""
        txtstatus.Text = ""
        txtidpeg.Text = ""
        lblbpjs.Text = nominal
        lblgajibersih.Text = nominal
        lblgapok.Text = nominal
        lblgator.Text = nominal
        lblpjkpenghasilan.Text = nominal
        lblpotongan.Text = nominal
        lbltotalgator.Text = nominal
        lbltotalpotongan.Text = nominal
        lbltunjangan.Text = nominal

    End Sub

    Function total_bpjs(gapok) As Integer
        Dim nominal As Integer
        nominal = gapok * 0.02
        Return nominal
    End Function

    Function pajak_penghasilan(gapok) As Integer
        Dim nominal As Integer
        nominal = gapok * 0.06
        Return nominal
    End Function

    Private Sub Penggajian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
        txtkd.Focus()
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        Dim nip As String

        nip = txtkd.Text
        Call Konek()
        CMD = New OdbcCommand("Select * From pegawai Join jabatan ON pegawai.id_jabatan = jabatan.id_jabatan where nip ='" & txtkd.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()

        If Not RD.HasRows Then
            MsgBox("Pegawai tidak ditemukan!")
            txtkd.Focus()
        Else
            gapok = RD.Item("gaji_pokok")
            tunj_fungsional = RD.Item("tunjangan_fungsional")

            bpjs = total_bpjs(gapok)
            pp = pajak_penghasilan(gapok)
            total_potongan = bpjs + pp
            gator = gapok + tunj_fungsional
            gaber = gator - total_potongan

            txtnip.Text = RD.Item("nip")
            txtnama.Text = RD.Item("nama_pegawai")
            txtjabatan.Text = RD.Item("nama_jabatan")
            txtstatus.Text = RD.Item("status")
            txtalamat.Text = RD.Item("alamat_pegawai")
            txtidpeg.Text = RD.Item("id_pegawai")
            txtidjabatan.Text = RD.Item("id_jabatan")

            lblgapok.Text = "Rp. " + Format(Val(gapok), "#,#")
            lblbpjs.Text = "Rp. " + Format(Val(bpjs), "#,#")
            lblpjkpenghasilan.Text = "Rp. " + Format(Val(pp), "#,#")
            lbltotalpotongan.Text = "Rp. " + Format(Val(total_potongan), "#,#")
            lbltunjangan.Text = "Rp. " + Format(Val(tunj_fungsional), "#,#")
            lblgator.Text = "Rp. " + Format(Val(gator), "#,#")
            lblpotongan.Text = "Rp. " + Format(Val(total_potongan), "#,#")
            lbltotalgator.Text = "Rp. " + Format(Val(gator), "#,#")
            lblgajibersih.Text = "Rp. " + Format(Val(gaber), "#,#")

            ActionBtn(True, True, True, True, False)
            dtpenggajian.Focus()
        End If

    End Sub

    Private Sub checkbox1_ItemCheck(sender As Object, e As ItemCheckEventArgs)
        lbltunjangan.Text = "click"
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Dim tgl_gaji, id_pegawai, id_jabatan, t_gapok, total_tunj, t_bpjs, t_pp, T_gaber As String
        tgl_gaji = dtpenggajian.Value.ToString("yyyy-MM-dd")
        id_pegawai = txtidpeg.Text
        id_jabatan = txtidjabatan.Text
        t_gapok = gapok
        total_tunj = tunj_fungsional
        t_bpjs = bpjs
        t_pp = pp
        T_gaber = gaber

        SimpanGaji(tgl_gaji, id_pegawai, id_jabatan, t_gapok, total_tunj, t_bpjs, t_pp, T_gaber)

    End Sub

    Private Sub SimpanGaji(tgl_gaji As String, id_pegawai As String, id_jabatan As String, t_gapok As String, total_tunj As String, t_bpjs As String, t_pp As String, t_gaber As String)
        Dim simpan As String = "insert into penggajian values ('','" & tgl_gaji & "','" & id_pegawai & "','" & id_jabatan & "','" & gapok & "','" & total_tunj & "','" & t_bpjs & "','" & t_pp & "','" & t_gaber & "')"
        CMD = New OdbcCommand(simpan, Conn)
        CMD.ExecuteNonQuery()

        MsgBox("Penggajian berhasil disimpan")
        ActionBtn(True, True, False, True, True)
        txtkd.Focus()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        ActionBtn(False, False, False, False, False)
        ResetAll()
        txtkd.Focus()
    End Sub

    Sub cetak(idpegawai)
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        CetakSlip.tglGaji = dtpenggajian.Value.ToString("yyyy-MM-dd")
        CetakSlip.Show()
    End Sub
End Class