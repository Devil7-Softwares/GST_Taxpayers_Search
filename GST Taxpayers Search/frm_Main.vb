Public Class frm_Main
    Sub LoadSettings()
        Me.Size = My.Settings.Size
        Me.Location = My.Settings.Location
        Me.WindowState = My.Settings.FormState
        Me.DefaultLookAndFeel1.EnableBonusSkins = True
        Me.DefaultLookAndFeel1.LookAndFeel.SetSkinStyle(My.Settings.Skin)
    End Sub
    Sub SaveSettings()
        My.Settings.FormState = Me.WindowState
        My.Settings.Size = Me.Size
        My.Settings.Location = Me.Location
        My.Settings.Skin = Me.LookAndFeel.ActiveSkinName
        My.Settings.Save()
    End Sub

    Private Sub frm_Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveSettings()
    End Sub
    Private Sub frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSettings()
        Control.CheckForIllegalCrossThreadCalls = False
        Me.gc_Items2Search.DataSource = New List(Of Item2Search)
        Me.gc_TaxPayers.DataSource = New List(Of TaxPayer)
        Me.gv_TaxPayers.BestFitColumns()
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        Dim d As New frm_AddGSTIN
        If d.ShowDialog = Windows.Forms.DialogResult.OK Then
            If d.Items2Search.Count > 0 Then
                CType(Me.gc_Items2Search.DataSource, List(Of Item2Search)).AddRange(d.Items2Search.ToArray)
                gc_Items2Search.RefreshDataSource()
            End If
        End If
    End Sub

    Private Sub btn_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove.Click
        If gv_Items2Search.SelectedRowsCount > 0 Then
            For Each i As Integer In gv_Items2Search.GetSelectedRows
                Dim row = gv_Items2Search.GetRow(i)
                CType(Me.gc_Items2Search.DataSource, List(Of Item2Search)).Remove(CType(row, Item2Search))
            Next
            gc_Items2Search.RefreshDataSource()
        End If
    End Sub

    Private Sub btn_Export2Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export2Excel.Click
        If SaveFile_XLSX.ShowDialog = Windows.Forms.DialogResult.OK Then
            gc_TaxPayers.ExportToXlsx(SaveFile_XLSX.FileName)
            Process.Start(SaveFile_XLSX.FileName)
        End If
    End Sub

    Private Sub btn_Export2Excel2003_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export2Excel2003.Click
        If SaveFile_XLS.ShowDialog = Windows.Forms.DialogResult.OK Then
            gc_TaxPayers.ExportToXls(SaveFile_XLS.FileName)
            Process.Start(SaveFile_XLS.FileName)
        End If
    End Sub

    Private Sub btn_Export2CSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export2CSV.Click
        If SaveFile_CSV.ShowDialog = Windows.Forms.DialogResult.OK Then
            gc_TaxPayers.ExportToCsv(SaveFile_CSV.FileName)
            Process.Start(SaveFile_CSV.FileName)
        End If
    End Sub

    Private Sub btn_Export2PDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export2PDF.Click
        If SaveFile_PDF.ShowDialog = Windows.Forms.DialogResult.OK Then
            gc_TaxPayers.ExportToPdf(SaveFile_PDF.FileName)
            Process.Start(SaveFile_PDF.FileName)
        End If
    End Sub

    Private Sub btn_Export2HTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export2HTML.Click
        If SaveFile_HTML.ShowDialog = Windows.Forms.DialogResult.OK Then
            gc_TaxPayers.ExportToHtml(SaveFile_HTML.FileName)
            Process.Start(SaveFile_HTML.FileName)
        End If
    End Sub

    Private Sub btn_Export2MHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export2MHT.Click
        If SaveFile_MHT.ShowDialog = Windows.Forms.DialogResult.OK Then
            gc_TaxPayers.ExportToMht(SaveFile_MHT.FileName)
            Process.Start(SaveFile_MHT.FileName)
        End If
    End Sub

    Private Sub btn_Export2RTF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export2RTF.Click
        If SaveFile_RTF.ShowDialog = Windows.Forms.DialogResult.OK Then
            gc_TaxPayers.ExportToRtf(SaveFile_RTF.FileName)
            Process.Start(SaveFile_RTF.FileName)
        End If
    End Sub

    Private Sub btn_Export2Text_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Export2Text.Click
        If SaveFile_TXT.ShowDialog = Windows.Forms.DialogResult.OK Then
            gc_TaxPayers.ExportToText(SaveFile_TXT.FileName)
            Process.Start(SaveFile_TXT.FileName)
        End If
    End Sub

    Private Sub btn_InstantSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_InstantSearch.Click
        Worker_InstantSearch.RunWorkerAsync()
    End Sub

    Private Sub Worker_InstantSearch_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker_InstantSearch.DoWork
        Dim GSTIN As String = InputBox("Enter GSTIN to Search :", "Instant Search")
        WaitFormManager.ShowWaitForm()
        If GSTIN.Trim <> "" Then
            Dim result As SearchResult = SearchTaxpayer(GSTIN)
            WaitFormManager.CloseWaitForm()
            If result.Result = D7Automation.Result.Found Then
                MsgBox(String.Format("GSTIN{1}{1}: {2}{0}Name{1}{1}: {3}{0}State Jurisdiction{1}: {4}{0}Centre Jurisdiction{1}: {5}{0}DOR{1}{1}: {6}{0}Constitution{1}: {7}{0}Type{1}{1}: {8}{0}Status{1}{1}: {9}{0}", vbNewLine, vbTab, result.TaxPayer.GSTIN, result.TaxPayer.TaxPayerName, result.TaxPayer.StateJurisdiction, result.TaxPayer.CentreJurisdiction, result.TaxPayer.DateOfRegistration, result.TaxPayer.ConstitutionOfBusiness, result.TaxPayer.TaxpayerType, result.TaxPayer.Status), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Found")
            Else
                MsgBox("Taxpayer not found. Check GSTIN", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Not Found")
            End If
        End If
    End Sub

    Private Sub Worker_SearchAll_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Worker_SearchAll.DoWork
        Dim Found As Integer = 0
        Dim NotFound As Integer = 0
        Dim Total As Integer = 0
        For Each i As Item2Search In CType(gv_Items2Search.DataSource, List(Of Item2Search))
            If i.Status = Status.Waiting Then
                Total += 1
                Try
                    Dim result As SearchResult = SearchTaxpayer(i.GSTIN)
                    If result.Result = D7Automation.Result.NotFound Then
                        i.Status = Status.NotFound
                        NotFound += 1
                        gc_Items2Search.RefreshDataSource()
                    Else
                        i.Status = Status.Found
                        Found += 1
                        gc_Items2Search.RefreshDataSource()
                        CType(gc_TaxPayers.DataSource, List(Of TaxPayer)).Add(result.TaxPayer)
                        gc_TaxPayers.RefreshDataSource()
                    End If
                Catch ex As Exception
                    i.Status = Status.UnknownError
                End Try
            End If
        Next
        Me.gv_TaxPayers.BestFitColumns()
        WaitFormManager.CloseWaitForm()
        MsgBox(String.Format("Search completed.{1}{1}No of entries searched{0}: {2}{1}No of entries found{0}{0}: {3}{1}No of entries not found{0}: {4}", vbTab, vbNewLine, Total, Found, NotFound), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Done!")
    End Sub

    Private Sub btn_Search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Search.Click
        WaitFormManager.ShowWaitForm()
        Worker_SearchAll.RunWorkerAsync()
    End Sub
End Class
Public Class Item2Search
    Property GSTIN As String
    Sub New(ByVal GSTIN As String)
        Me.GSTIN = GSTIN
    End Sub
    Property Status As Status = Status.Waiting
End Class
Public Enum Status
    Waiting
    Found
    NotFound
    UnknownError
End Enum