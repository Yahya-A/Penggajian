Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO
Imports CrystalDecisions.Shared

Public Class CetakSlip
    Public tglGaji As String

    Public Sub CetakSlip(tgl As String)
        tglGaji = tgl
    End Sub

    Private Sub CetakSlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        Dim curpath As String = AppDomain.CurrentDomain.BaseDirectory.ToString
        Dim rptpath As String = Path.GetFullPath(Path.Combine(curpath, "..\..\"))
        cryRpt.Load(rptpath + "SlipGaji.rpt")

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = tglGaji
        crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields()
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("tglGaji")
        crParameterValues = crParameterFieldDefinition.CurrentValues

        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        CrystalReportViewer2.ReportSource = cryRpt
        CrystalReportViewer2.Refresh()
    End Sub
End Class