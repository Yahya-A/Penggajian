<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.lblnamauser = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblinforole = New System.Windows.Forms.Label()
        Me.lblinfouname = New System.Windows.Forms.Label()
        Me.lblinfonama = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelClock = New System.Windows.Forms.Label()
        Me.LabelHari = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.shortpegawai = New System.Windows.Forms.Button()
        Me.shortpenggajian = New System.Windows.Forms.Button()
        Me.shortjabatan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblnamauser
        '
        Me.lblnamauser.AutoSize = True
        Me.lblnamauser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnamauser.Location = New System.Drawing.Point(154, 78)
        Me.lblnamauser.Name = "lblnamauser"
        Me.lblnamauser.Size = New System.Drawing.Size(52, 20)
        Me.lblnamauser.TabIndex = 1
        Me.lblnamauser.Text = "admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dashboard Aplikasi Penggajian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selamat Datang,"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lblinforole)
        Me.GroupBox1.Controls.Add(Me.lblinfouname)
        Me.GroupBox1.Controls.Add(Me.lblinfonama)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 282)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(125, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "="
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(125, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 20)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "="
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(125, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "="
        '
        'lblinforole
        '
        Me.lblinforole.AutoSize = True
        Me.lblinforole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinforole.Location = New System.Drawing.Point(149, 145)
        Me.lblinforole.Name = "lblinforole"
        Me.lblinforole.Size = New System.Drawing.Size(100, 20)
        Me.lblinforole.TabIndex = 5
        Me.lblinforole.Text = "Nama Admin"
        '
        'lblinfouname
        '
        Me.lblinfouname.AutoSize = True
        Me.lblinfouname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfouname.Location = New System.Drawing.Point(149, 104)
        Me.lblinfouname.Name = "lblinfouname"
        Me.lblinfouname.Size = New System.Drawing.Size(100, 20)
        Me.lblinfouname.TabIndex = 4
        Me.lblinfouname.Text = "Nama Admin"
        '
        'lblinfonama
        '
        Me.lblinfonama.AutoSize = True
        Me.lblinfonama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfonama.Location = New System.Drawing.Point(149, 63)
        Me.lblinfonama.Name = "lblinfonama"
        Me.lblinfonama.Size = New System.Drawing.Size(100, 20)
        Me.lblinfonama.TabIndex = 3
        Me.lblinfonama.Text = "Nama Admin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Role "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nama Admin"
        '
        'LabelClock
        '
        Me.LabelClock.AutoSize = True
        Me.LabelClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClock.Location = New System.Drawing.Point(678, 78)
        Me.LabelClock.Name = "LabelClock"
        Me.LabelClock.Size = New System.Drawing.Size(120, 31)
        Me.LabelClock.TabIndex = 10
        Me.LabelClock.Text = "00:00:00"
        '
        'LabelHari
        '
        Me.LabelHari.AutoSize = True
        Me.LabelHari.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHari.Location = New System.Drawing.Point(457, 80)
        Me.LabelHari.Name = "LabelHari"
        Me.LabelHari.Size = New System.Drawing.Size(186, 29)
        Me.LabelHari.TabIndex = 9
        Me.LabelHari.Text = "Day, 00-00-0000"
        '
        'Timer1
        '
        '
        'shortpegawai
        '
        Me.shortpegawai.BackColor = System.Drawing.Color.PaleGreen
        Me.shortpegawai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.shortpegawai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortpegawai.Image = CType(resources.GetObject("shortpegawai.Image"), System.Drawing.Image)
        Me.shortpegawai.Location = New System.Drawing.Point(462, 125)
        Me.shortpegawai.Name = "shortpegawai"
        Me.shortpegawai.Size = New System.Drawing.Size(165, 136)
        Me.shortpegawai.TabIndex = 4
        Me.shortpegawai.Text = "Master Pegawai"
        Me.shortpegawai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.shortpegawai.UseVisualStyleBackColor = False
        '
        'shortpenggajian
        '
        Me.shortpenggajian.BackColor = System.Drawing.Color.DarkOrange
        Me.shortpenggajian.Cursor = System.Windows.Forms.Cursors.Hand
        Me.shortpenggajian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortpenggajian.Image = CType(resources.GetObject("shortpenggajian.Image"), System.Drawing.Image)
        Me.shortpenggajian.Location = New System.Drawing.Point(462, 277)
        Me.shortpenggajian.Name = "shortpenggajian"
        Me.shortpenggajian.Size = New System.Drawing.Size(336, 125)
        Me.shortpenggajian.TabIndex = 6
        Me.shortpenggajian.Text = "Penggajian"
        Me.shortpenggajian.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.shortpenggajian.UseVisualStyleBackColor = False
        '
        'shortjabatan
        '
        Me.shortjabatan.BackColor = System.Drawing.Color.CornflowerBlue
        Me.shortjabatan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.shortjabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shortjabatan.Image = CType(resources.GetObject("shortjabatan.Image"), System.Drawing.Image)
        Me.shortjabatan.Location = New System.Drawing.Point(633, 125)
        Me.shortjabatan.Name = "shortjabatan"
        Me.shortjabatan.Size = New System.Drawing.Size(165, 136)
        Me.shortjabatan.TabIndex = 7
        Me.shortjabatan.Text = "Master Jabatan"
        Me.shortjabatan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.shortjabatan.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(860, 444)
        Me.Controls.Add(Me.LabelClock)
        Me.Controls.Add(Me.shortjabatan)
        Me.Controls.Add(Me.LabelHari)
        Me.Controls.Add(Me.shortpenggajian)
        Me.Controls.Add(Me.shortpegawai)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblnamauser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnamauser As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblinforole As System.Windows.Forms.Label
    Friend WithEvents lblinfouname As System.Windows.Forms.Label
    Friend WithEvents lblinfonama As System.Windows.Forms.Label
    Friend WithEvents LabelClock As System.Windows.Forms.Label
    Friend WithEvents LabelHari As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents shortpegawai As System.Windows.Forms.Button
    Friend WithEvents shortpenggajian As System.Windows.Forms.Button
    Friend WithEvents shortjabatan As System.Windows.Forms.Button
End Class
