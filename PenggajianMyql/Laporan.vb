Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class Laporan
    Public keyfor As String

    Public Sub LapPreview(keyLap As String)
        keyfor = keyLap
    End Sub
    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim curpath As String = AppDomain.CurrentDomain.BaseDirectory.ToString
        Dim rptpath As String = Path.GetFullPath(Path.Combine(curpath, "..\..\"))

        Dim oDocument As New ReportDocument()
        If keyfor = "pegawai" Then
            oDocument.Load(rptpath + "LapPegawai.rpt")
            oDocument.SetDataSource(New DataSet())
        ElseIf keyfor = "jabatan" Then
            oDocument.Load(rptpath + "LapJabatan.rpt")
            oDocument.SetDataSource(New DataSet())
        ElseIf keyfor = "gaji" Then
            oDocument.Load(rptpath + "LapPenggajian.rpt")
            oDocument.SetDataSource(New DataSet())
        End If
        CrystalReportViewer1.ReportSource = oDocument
    End Sub
End Class