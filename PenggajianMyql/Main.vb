Public Class Main

    Public keyfor As String

    Public Sub LapPreview(keyLap As String)
        keyfor = keyLap
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(Dashboard)
    End Sub

    Private Sub PegawaiToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PegawaiToolStripMenuItem1.Click
        switchPanel(Pegawai)
    End Sub

    Private Sub JabatanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JabatanToolStripMenuItem.Click
        switchPanel(Jabatan)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.Username = ""
        My.Settings.Name = ""
        My.Settings.isLogin = False
        My.Settings.Save()
        My.Settings.Reload()
        Me.Close()
        Login.Show()

    End Sub

    Private Sub PenggajianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggajianToolStripMenuItem.Click
        switchPanel(Penggajian)
    End Sub

    Private Sub PegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lappegawai.Click
        Laporan.keyfor = "pegawai"
        Laporan.Show()
    End Sub

    Private Sub lapjabatan_Click(sender As Object, e As EventArgs) Handles lapjabatan.Click
        Laporan.keyfor = "jabatan"
        Laporan.Show()
    End Sub

    Private Sub lapgaji_Click(sender As Object, e As EventArgs) Handles lapgaji.Click
        Laporan.keyfor = "gaji"
        Laporan.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MenuUtamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuUtamaToolStripMenuItem.Click
        switchPanel(Dashboard)
    End Sub
End Class