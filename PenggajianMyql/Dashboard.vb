Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblnamauser.Text = My.Settings.Name
        lblinfonama.Text = My.Settings.Name
        lblinfouname.Text = My.Settings.Username
        lblinforole.Text = My.Settings.Role

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelClock.Text = Format(TimeOfDay, "HH:mm:ss")
        LabelHari.Text = Format(Now, "dddd") + ", " + Format(Now, "dd-mm-yyyy")
    End Sub

    Private Sub shortpegawai_Click(sender As Object, e As EventArgs) Handles shortpegawai.Click
        Main.switchPanel(Pegawai)
    End Sub

    Private Sub shortjabatan_Click(sender As Object, e As EventArgs) Handles shortjabatan.Click
        Main.switchPanel(Jabatan)
    End Sub

    Private Sub shortpenggajian_Click(sender As Object, e As EventArgs) Handles shortpenggajian.Click
        Main.switchPanel(Penggajian)
    End Sub
End Class