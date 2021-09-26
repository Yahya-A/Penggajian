<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuUtamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PegawaiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggajianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lappegawai = New System.Windows.Forms.ToolStripMenuItem()
        Me.lapjabatan = New System.Windows.Forms.ToolStripMenuItem()
        Me.lapgaji = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.MasterToolStripMenuItem, Me.PenggajianToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(876, 32)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUtamaToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.DashboardToolStripMenuItem.Image = CType(resources.GetObject("DashboardToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DashboardToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(92, 28)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'MenuUtamaToolStripMenuItem
        '
        Me.MenuUtamaToolStripMenuItem.Image = CType(resources.GetObject("MenuUtamaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MenuUtamaToolStripMenuItem.Name = "MenuUtamaToolStripMenuItem"
        Me.MenuUtamaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MenuUtamaToolStripMenuItem.Text = "Menu Utama"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PegawaiToolStripMenuItem1, Me.JabatanToolStripMenuItem})
        Me.MasterToolStripMenuItem.Image = CType(resources.GetObject("MasterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MasterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MasterToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(79, 28)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'PegawaiToolStripMenuItem1
        '
        Me.PegawaiToolStripMenuItem1.Image = CType(resources.GetObject("PegawaiToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PegawaiToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PegawaiToolStripMenuItem1.Name = "PegawaiToolStripMenuItem1"
        Me.PegawaiToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PegawaiToolStripMenuItem1.Text = "Pegawai"
        '
        'JabatanToolStripMenuItem
        '
        Me.JabatanToolStripMenuItem.Image = CType(resources.GetObject("JabatanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JabatanToolStripMenuItem.Name = "JabatanToolStripMenuItem"
        Me.JabatanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JabatanToolStripMenuItem.Text = "Jabatan"
        '
        'PenggajianToolStripMenuItem
        '
        Me.PenggajianToolStripMenuItem.Image = CType(resources.GetObject("PenggajianToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenggajianToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PenggajianToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.PenggajianToolStripMenuItem.Name = "PenggajianToolStripMenuItem"
        Me.PenggajianToolStripMenuItem.Size = New System.Drawing.Size(102, 28)
        Me.PenggajianToolStripMenuItem.Text = "Penggajian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lappegawai, Me.lapjabatan, Me.lapgaji})
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(86, 28)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'lappegawai
        '
        Me.lappegawai.Image = CType(resources.GetObject("lappegawai.Image"), System.Drawing.Image)
        Me.lappegawai.Name = "lappegawai"
        Me.lappegawai.Size = New System.Drawing.Size(152, 22)
        Me.lappegawai.Text = "Pegawai"
        '
        'lapjabatan
        '
        Me.lapjabatan.Image = CType(resources.GetObject("lapjabatan.Image"), System.Drawing.Image)
        Me.lapjabatan.Name = "lapjabatan"
        Me.lapjabatan.Size = New System.Drawing.Size(152, 22)
        Me.lapjabatan.Text = "Jabatan"
        '
        'lapgaji
        '
        Me.lapgaji.Image = CType(resources.GetObject("lapgaji.Image"), System.Drawing.Image)
        Me.lapgaji.Name = "lapgaji"
        Me.lapgaji.Size = New System.Drawing.Size(152, 22)
        Me.lapgaji.Text = "Penggajian"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 561)
        Me.Panel1.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(876, 598)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Aplikasi Penggajian"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuUtamaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegawaiToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggajianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lappegawai As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lapjabatan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lapgaji As System.Windows.Forms.ToolStripMenuItem
End Class
