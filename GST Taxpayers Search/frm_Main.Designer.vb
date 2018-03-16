<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits XtraFormTemp

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.grp_Search = New DevExpress.XtraEditors.GroupControl()
        Me.gc_Items2Search = New DevExpress.XtraGrid.GridControl()
        Me.gv_Items2Search = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_InstantSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Search = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Remove = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.gc_TaxPayers = New DevExpress.XtraGrid.GridControl()
        Me.gv_TaxPayers = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_Export2Text = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Export2RTF = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Export2MHT = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Export2HTML = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Export2PDF = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Export2CSV = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Export2Excel2003 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Export2Excel = New DevExpress.XtraEditors.SimpleButton()
        Me.SaveFile_CSV = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFile_XLS = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFile_XLSX = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFile_HTML = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFile_RTF = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFile_PDF = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFile_TXT = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFile_MHT = New System.Windows.Forms.SaveFileDialog()
        Me.Worker_InstantSearch = New System.ComponentModel.BackgroundWorker()
        Me.WaitFormManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.D7Automation.frm_Wait), True, True)
        Me.Worker_SearchAll = New System.ComponentModel.BackgroundWorker()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.btn_Skin = New DevExpress.XtraBars.SkinBarSubItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.grp_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Search.SuspendLayout()
        CType(Me.gc_Items2Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_Items2Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gc_TaxPayers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv_TaxPayers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp_Search
        '
        Me.grp_Search.Controls.Add(Me.gc_Items2Search)
        Me.grp_Search.Controls.Add(Me.PanelControl1)
        Me.grp_Search.Dock = System.Windows.Forms.DockStyle.Top
        Me.grp_Search.Location = New System.Drawing.Point(0, 0)
        Me.grp_Search.MinimumSize = New System.Drawing.Size(672, 225)
        Me.grp_Search.Name = "grp_Search"
        Me.grp_Search.Size = New System.Drawing.Size(672, 225)
        Me.grp_Search.TabIndex = 0
        Me.grp_Search.Text = "GSTINs to Search"
        '
        'gc_Items2Search
        '
        Me.gc_Items2Search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_Items2Search.Location = New System.Drawing.Point(2, 20)
        Me.gc_Items2Search.MainView = Me.gv_Items2Search
        Me.gc_Items2Search.Name = "gc_Items2Search"
        Me.gc_Items2Search.Size = New System.Drawing.Size(668, 148)
        Me.gc_Items2Search.TabIndex = 4
        Me.gc_Items2Search.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_Items2Search})
        '
        'gv_Items2Search
        '
        Me.gv_Items2Search.GridControl = Me.gc_Items2Search
        Me.gv_Items2Search.Name = "gv_Items2Search"
        Me.gv_Items2Search.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_Items2Search.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_Items2Search.OptionsBehavior.Editable = False
        Me.gv_Items2Search.OptionsSelection.MultiSelect = True
        Me.gv_Items2Search.OptionsView.ShowGroupPanel = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_InstantSearch)
        Me.PanelControl1.Controls.Add(Me.btn_Search)
        Me.PanelControl1.Controls.Add(Me.btn_Remove)
        Me.PanelControl1.Controls.Add(Me.btn_Add)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 168)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(668, 55)
        Me.PanelControl1.TabIndex = 0
        '
        'btn_InstantSearch
        '
        Me.btn_InstantSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_InstantSearch.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.Search
        Me.btn_InstantSearch.Location = New System.Drawing.Point(441, 2)
        Me.btn_InstantSearch.Name = "btn_InstantSearch"
        Me.btn_InstantSearch.Size = New System.Drawing.Size(123, 51)
        Me.btn_InstantSearch.TabIndex = 3
        Me.btn_InstantSearch.Text = "Instant Search"
        Me.btn_InstantSearch.ToolTip = "Search only one GSTIN"
        '
        'btn_Search
        '
        Me.btn_Search.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Search.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.SearchAll
        Me.btn_Search.Location = New System.Drawing.Point(564, 2)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(102, 51)
        Me.btn_Search.TabIndex = 2
        Me.btn_Search.Text = "Search All"
        '
        'btn_Remove
        '
        Me.btn_Remove.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Remove.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.Remove
        Me.btn_Remove.Location = New System.Drawing.Point(77, 2)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(86, 51)
        Me.btn_Remove.TabIndex = 0
        Me.btn_Remove.Text = "Remove"
        '
        'btn_Add
        '
        Me.btn_Add.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Add.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.Add
        Me.btn_Add.Location = New System.Drawing.Point(2, 2)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(75, 51)
        Me.btn_Add.TabIndex = 1
        Me.btn_Add.Text = "Add"
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 225)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(672, 5)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'gc_TaxPayers
        '
        Me.gc_TaxPayers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc_TaxPayers.Location = New System.Drawing.Point(0, 230)
        Me.gc_TaxPayers.MainView = Me.gv_TaxPayers
        Me.gc_TaxPayers.Name = "gc_TaxPayers"
        Me.gc_TaxPayers.Size = New System.Drawing.Size(672, 86)
        Me.gc_TaxPayers.TabIndex = 3
        Me.gc_TaxPayers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv_TaxPayers})
        '
        'gv_TaxPayers
        '
        Me.gv_TaxPayers.GridControl = Me.gc_TaxPayers
        Me.gv_TaxPayers.Name = "gv_TaxPayers"
        Me.gv_TaxPayers.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_TaxPayers.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gv_TaxPayers.OptionsBehavior.Editable = False
        Me.gv_TaxPayers.OptionsSelection.MultiSelect = True
        Me.gv_TaxPayers.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        Me.gv_TaxPayers.OptionsView.ColumnAutoWidth = False
        Me.gv_TaxPayers.OptionsView.ShowGroupPanel = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btn_Export2Text)
        Me.GroupControl2.Controls.Add(Me.btn_Export2RTF)
        Me.GroupControl2.Controls.Add(Me.btn_Export2MHT)
        Me.GroupControl2.Controls.Add(Me.btn_Export2HTML)
        Me.GroupControl2.Controls.Add(Me.btn_Export2PDF)
        Me.GroupControl2.Controls.Add(Me.btn_Export2CSV)
        Me.GroupControl2.Controls.Add(Me.btn_Export2Excel2003)
        Me.GroupControl2.Controls.Add(Me.btn_Export2Excel)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(0, 316)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(672, 75)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Export"
        '
        'btn_Export2Text
        '
        Me.btn_Export2Text.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Export2Text.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.TEXT
        Me.btn_Export2Text.Location = New System.Drawing.Point(592, 20)
        Me.btn_Export2Text.Name = "btn_Export2Text"
        Me.btn_Export2Text.Size = New System.Drawing.Size(78, 53)
        Me.btn_Export2Text.TabIndex = 7
        Me.btn_Export2Text.Text = "Text"
        Me.btn_Export2Text.ToolTip = "Export to Plain Text File"
        '
        'btn_Export2RTF
        '
        Me.btn_Export2RTF.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Export2RTF.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.RTF
        Me.btn_Export2RTF.Location = New System.Drawing.Point(519, 20)
        Me.btn_Export2RTF.Name = "btn_Export2RTF"
        Me.btn_Export2RTF.Size = New System.Drawing.Size(73, 53)
        Me.btn_Export2RTF.TabIndex = 6
        Me.btn_Export2RTF.Text = "RTF"
        Me.btn_Export2RTF.ToolTip = "Export to Rich Text Format File"
        '
        'btn_Export2MHT
        '
        Me.btn_Export2MHT.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Export2MHT.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.MHT
        Me.btn_Export2MHT.Location = New System.Drawing.Point(443, 20)
        Me.btn_Export2MHT.Name = "btn_Export2MHT"
        Me.btn_Export2MHT.Size = New System.Drawing.Size(76, 53)
        Me.btn_Export2MHT.TabIndex = 5
        Me.btn_Export2MHT.Text = "MHT"
        Me.btn_Export2MHT.ToolTip = "Export to Multipart HTML Web Page File"
        '
        'btn_Export2HTML
        '
        Me.btn_Export2HTML.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Export2HTML.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.HTML
        Me.btn_Export2HTML.Location = New System.Drawing.Point(363, 20)
        Me.btn_Export2HTML.Name = "btn_Export2HTML"
        Me.btn_Export2HTML.Size = New System.Drawing.Size(80, 53)
        Me.btn_Export2HTML.TabIndex = 4
        Me.btn_Export2HTML.Text = "HTML"
        Me.btn_Export2HTML.ToolTip = "Export to HTML Web Page File"
        '
        'btn_Export2PDF
        '
        Me.btn_Export2PDF.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Export2PDF.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.PDF
        Me.btn_Export2PDF.Location = New System.Drawing.Point(284, 20)
        Me.btn_Export2PDF.Name = "btn_Export2PDF"
        Me.btn_Export2PDF.Size = New System.Drawing.Size(79, 53)
        Me.btn_Export2PDF.TabIndex = 3
        Me.btn_Export2PDF.Text = "PDF"
        Me.btn_Export2PDF.ToolTip = "Export to PDF"
        '
        'btn_Export2CSV
        '
        Me.btn_Export2CSV.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Export2CSV.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.CSV
        Me.btn_Export2CSV.Location = New System.Drawing.Point(210, 20)
        Me.btn_Export2CSV.Name = "btn_Export2CSV"
        Me.btn_Export2CSV.Size = New System.Drawing.Size(74, 53)
        Me.btn_Export2CSV.TabIndex = 2
        Me.btn_Export2CSV.Text = "CSV"
        Me.btn_Export2CSV.ToolTip = "Export to CSV File"
        '
        'btn_Export2Excel2003
        '
        Me.btn_Export2Excel2003.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Export2Excel2003.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.XLS
        Me.btn_Export2Excel2003.Location = New System.Drawing.Point(106, 20)
        Me.btn_Export2Excel2003.Name = "btn_Export2Excel2003"
        Me.btn_Export2Excel2003.Size = New System.Drawing.Size(104, 53)
        Me.btn_Export2Excel2003.TabIndex = 1
        Me.btn_Export2Excel2003.Text = "Excel 2003"
        Me.btn_Export2Excel2003.ToolTip = "Export to Excel 2003 File Format"
        '
        'btn_Export2Excel
        '
        Me.btn_Export2Excel.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_Export2Excel.ImageOptions.Image = Global.D7Automation.My.Resources.Resources.XLSX
        Me.btn_Export2Excel.Location = New System.Drawing.Point(2, 20)
        Me.btn_Export2Excel.Name = "btn_Export2Excel"
        Me.btn_Export2Excel.Size = New System.Drawing.Size(104, 53)
        Me.btn_Export2Excel.TabIndex = 0
        Me.btn_Export2Excel.Text = "Excel 2007"
        Me.btn_Export2Excel.ToolTip = "Export to Excel 2007 File Format"
        '
        'SaveFile_CSV
        '
        Me.SaveFile_CSV.FileName = "*.csv"
        Me.SaveFile_CSV.Filter = "Comma Delemited Text Files (*.csv)|*.csv"
        '
        'SaveFile_XLS
        '
        Me.SaveFile_XLS.FileName = "*.xls"
        Me.SaveFile_XLS.Filter = "Microsoft Office Excel 2003 (*.xls)|*.xls"
        '
        'SaveFile_XLSX
        '
        Me.SaveFile_XLSX.FileName = "*.xlsx"
        Me.SaveFile_XLSX.Filter = "Microsoft Office Excel 2007 (*.xlsx)|*.xlsx"
        '
        'SaveFile_HTML
        '
        Me.SaveFile_HTML.FileName = "*.html"
        Me.SaveFile_HTML.Filter = "Web Page (*.html)|*.html"
        '
        'SaveFile_RTF
        '
        Me.SaveFile_RTF.FileName = "*.rtf"
        Me.SaveFile_RTF.Filter = "Rich Text Format (*.rtf)|*.rtf"
        '
        'SaveFile_PDF
        '
        Me.SaveFile_PDF.FileName = "*.pdf"
        Me.SaveFile_PDF.Filter = "Portable Document Format (*.pdf)|*.pdf"
        '
        'SaveFile_TXT
        '
        Me.SaveFile_TXT.FileName = "*.txt"
        Me.SaveFile_TXT.Filter = "Text Files (*.txt)|*.txt"
        '
        'SaveFile_MHT
        '
        Me.SaveFile_MHT.FileName = "*.mht"
        Me.SaveFile_MHT.Filter = "Multipart HTML Files (*.mht)|*.mht"
        '
        'Worker_InstantSearch
        '
        Me.Worker_InstantSearch.WorkerSupportsCancellation = True
        '
        'WaitFormManager
        '
        Me.WaitFormManager.ClosingDelay = 500
        '
        'Worker_SearchAll
        '
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Skin})
        Me.BarManager1.MaxItemId = 1
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Skin)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'btn_Skin
        '
        Me.btn_Skin.Caption = "Skin"
        Me.btn_Skin.Id = 0
        Me.btn_Skin.Name = "btn_Skin"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(672, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 391)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(672, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 391)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(672, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 391)
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 416)
        Me.Controls.Add(Me.gc_TaxPayers)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.grp_Search)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(682, 448)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "GST Taxpayers Search"
        CType(Me.grp_Search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Search.ResumeLayout(False)
        CType(Me.gc_Items2Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_Items2Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gc_TaxPayers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv_TaxPayers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp_Search As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents gc_TaxPayers As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_TaxPayers As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gc_Items2Search As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv_Items2Search As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_Add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Remove As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Export2Excel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SaveFile_CSV As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFile_XLS As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFile_XLSX As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFile_HTML As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFile_RTF As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFile_PDF As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFile_TXT As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveFile_MHT As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_Export2Text As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Export2RTF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Export2MHT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Export2HTML As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Export2PDF As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Export2CSV As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Export2Excel2003 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_Search As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_InstantSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Worker_InstantSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents WaitFormManager As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents Worker_SearchAll As System.ComponentModel.BackgroundWorker
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Skin As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl

End Class
