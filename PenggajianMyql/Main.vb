Public Class Main

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        'Panel1.Size = Me.Size
        'Panel1.Parent = Me
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
End Class