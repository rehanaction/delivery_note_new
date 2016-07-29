Partial Public Class Form1
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JilidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JenjangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTujuanKirimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TujuanKirimToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuratJalanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.colno_pengiriman1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colno_pengiriman_edit1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coltgl1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colkirimke1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colchecker1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coldatecreated1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Distribusi = New DevExpress.XtraTab.XtraTabPage()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Insert = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Update = New System.Windows.Forms.ToolStripButton()
        Me.Refresh = New System.Windows.Forms.ToolStripButton()
        Me.Close = New System.Windows.Forms.ToolStripButton()
        Me.DeliveryPage = New DevExpress.XtraTab.XtraTabPage()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.Tambah = New System.Windows.Forms.ToolStripButton()
        Me.Edit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.Revisi = New System.Windows.Forms.ToolStripButton()
        Me.Print = New System.Windows.Forms.ToolStripButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VsuratjalanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryDataSet = New delivery_note_new.deliveryDataSet()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colno_pengiriman = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colno_pengiriman_edit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTujuan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MenuTab = New DevExpress.XtraTab.XtraTabControl()
        Me.V_suratjalanTableAdapter = New delivery_note_new.deliveryDataSetTableAdapters.v_suratjalanTableAdapter()
        Me.V_suratjalan_detailTableAdapter1 = New delivery_note_new.deliveryDataSetTableAdapters.v_suratjalan_detailTableAdapter()
        Me.noberkas = New System.Windows.Forms.Label()
        Me.userid = New System.Windows.Forms.Label()
        Me.DeliveryDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BukuTableAdapter = New delivery_note_new.deliveryDataSetTableAdapters.bukuTableAdapter()
        Me.XpCollection1 = New DevExpress.Xpo.XPCollection(Me.components)
        Me.buku_code = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Distribusi.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Insert.SuspendLayout()
        Me.DeliveryPage.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VsuratjalanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuTab.SuspendLayout()
        CType(Me.DeliveryDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.SuratJalanToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PengaturanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBukuToolStripMenuItem, Me.DataTujuanKirimToolStripMenuItem, Me.CheckerToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukuToolStripMenuItem, Me.JilidToolStripMenuItem, Me.JenjangToolStripMenuItem, Me.CategoryToolStripMenuItem})
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'BukuToolStripMenuItem
        '
        Me.BukuToolStripMenuItem.Name = "BukuToolStripMenuItem"
        Me.BukuToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.BukuToolStripMenuItem.Text = "Buku"
        '
        'JilidToolStripMenuItem
        '
        Me.JilidToolStripMenuItem.Name = "JilidToolStripMenuItem"
        Me.JilidToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.JilidToolStripMenuItem.Text = "Jilid"
        '
        'JenjangToolStripMenuItem
        '
        Me.JenjangToolStripMenuItem.Name = "JenjangToolStripMenuItem"
        Me.JenjangToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.JenjangToolStripMenuItem.Text = "Jenjang"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'DataTujuanKirimToolStripMenuItem
        '
        Me.DataTujuanKirimToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TujuanKirimToolStripMenuItem})
        Me.DataTujuanKirimToolStripMenuItem.Name = "DataTujuanKirimToolStripMenuItem"
        Me.DataTujuanKirimToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.DataTujuanKirimToolStripMenuItem.Text = "Data Tujuan Kirim"
        '
        'TujuanKirimToolStripMenuItem
        '
        Me.TujuanKirimToolStripMenuItem.Name = "TujuanKirimToolStripMenuItem"
        Me.TujuanKirimToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.TujuanKirimToolStripMenuItem.Text = "Tujuan Kirim"
        '
        'CheckerToolStripMenuItem
        '
        Me.CheckerToolStripMenuItem.Name = "CheckerToolStripMenuItem"
        Me.CheckerToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CheckerToolStripMenuItem.Text = "Checker"
        '
        'SuratJalanToolStripMenuItem
        '
        Me.SuratJalanToolStripMenuItem.Name = "SuratJalanToolStripMenuItem"
        Me.SuratJalanToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.SuratJalanToolStripMenuItem.Text = "Surat Jalan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 23)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(626, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'colno_pengiriman1
        '
        Me.colno_pengiriman1.FieldName = "no_pengiriman"
        Me.colno_pengiriman1.Name = "colno_pengiriman1"
        '
        'colno_pengiriman_edit1
        '
        Me.colno_pengiriman_edit1.FieldName = "no_pengiriman_edit"
        Me.colno_pengiriman_edit1.Name = "colno_pengiriman_edit1"
        '
        'coltgl1
        '
        Me.coltgl1.FieldName = "tgl"
        Me.coltgl1.Name = "coltgl1"
        '
        'colkirimke1
        '
        Me.colkirimke1.FieldName = "kirimke"
        Me.colkirimke1.Name = "colkirimke1"
        '
        'colchecker1
        '
        Me.colchecker1.FieldName = "checker"
        Me.colchecker1.Name = "colchecker1"
        '
        'colketerangan1
        '
        Me.colketerangan1.FieldName = "keterangan"
        Me.colketerangan1.Name = "colketerangan1"
        '
        'coldatecreated1
        '
        Me.coldatecreated1.FieldName = "datecreated"
        Me.coldatecreated1.Name = "coldatecreated1"
        '
        'Distribusi
        '
        Me.Distribusi.Controls.Add(Me.GridControl2)
        Me.Distribusi.Controls.Add(Me.Insert)
        Me.Distribusi.Name = "Distribusi"
        Me.Distribusi.PageVisible = False
        Me.Distribusi.Size = New System.Drawing.Size(626, 389)
        Me.Distribusi.Text = "Buku"
        '
        'GridControl2
        '
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(0, 0)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(626, 364)
        Me.GridControl2.TabIndex = 3
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'Insert
        '
        Me.Insert.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Insert.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.Update, Me.Refresh, Me.Close})
        Me.Insert.Location = New System.Drawing.Point(0, 364)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(626, 25)
        Me.Insert.TabIndex = 2
        Me.Insert.Text = "ToolStrip3"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Input Surat Jalan"
        '
        'Update
        '
        Me.Update.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Update.Enabled = False
        Me.Update.Image = CType(resources.GetObject("Update.Image"), System.Drawing.Image)
        Me.Update.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Update.Name = "Update"
        Me.Update.Size = New System.Drawing.Size(23, 22)
        Me.Update.Text = "Edit Surat Jalan"
        Me.Update.ToolTipText = "Update Data Buku"
        '
        'Refresh
        '
        Me.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Refresh.Image = CType(resources.GetObject("Refresh.Image"), System.Drawing.Image)
        Me.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(23, 22)
        Me.Refresh.Text = "Refresh"
        '
        'Close
        '
        Me.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Close.Image = CType(resources.GetObject("Close.Image"), System.Drawing.Image)
        Me.Close.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(23, 22)
        Me.Close.Text = "Close"
        '
        'DeliveryPage
        '
        Me.DeliveryPage.Controls.Add(Me.ToolStrip2)
        Me.DeliveryPage.Controls.Add(Me.GridControl1)
        Me.DeliveryPage.Name = "DeliveryPage"
        Me.DeliveryPage.PageVisible = False
        Me.DeliveryPage.Size = New System.Drawing.Size(626, 389)
        Me.DeliveryPage.Text = "DataPengiriman"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tambah, Me.Edit, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.Revisi, Me.Print})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 364)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(626, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'Tambah
        '
        Me.Tambah.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Tambah.Image = CType(resources.GetObject("Tambah.Image"), System.Drawing.Image)
        Me.Tambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(23, 22)
        Me.Tambah.Text = "Input Surat Jalan"
        '
        'Edit
        '
        Me.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Edit.Enabled = False
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(23, 22)
        Me.Edit.Text = "Edit Surat Jalan"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Refresh"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Close"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Import Excel"
        '
        'Revisi
        '
        Me.Revisi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Revisi.Enabled = False
        Me.Revisi.Image = CType(resources.GetObject("Revisi.Image"), System.Drawing.Image)
        Me.Revisi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Revisi.Name = "Revisi"
        Me.Revisi.Size = New System.Drawing.Size(23, 22)
        Me.Revisi.Text = "Revisi"
        '
        'Print
        '
        Me.Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Print.Enabled = False
        Me.Print.Image = CType(resources.GetObject("Print.Image"), System.Drawing.Image)
        Me.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(23, 22)
        Me.Print.Text = "ToolStripButton2"
        Me.Print.ToolTipText = "Print Tanda Terima Buku"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VsuratjalanBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(626, 389)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VsuratjalanBindingSource
        '
        Me.VsuratjalanBindingSource.DataMember = "v_suratjalan"
        Me.VsuratjalanBindingSource.DataSource = Me.DeliveryDataSet
        '
        'DeliveryDataSet
        '
        Me.DeliveryDataSet.DataSetName = "deliveryDataSet"
        Me.DeliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colno_pengiriman, Me.colno_pengiriman_edit, Me.colketerangan, Me.colTanggal, Me.colTujuan, Me.colnama, Me.colStatus})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colno_pengiriman
        '
        Me.colno_pengiriman.FieldName = "no_pengiriman"
        Me.colno_pengiriman.Name = "colno_pengiriman"
        Me.colno_pengiriman.Visible = True
        Me.colno_pengiriman.VisibleIndex = 0
        '
        'colno_pengiriman_edit
        '
        Me.colno_pengiriman_edit.FieldName = "no_pengiriman_edit"
        Me.colno_pengiriman_edit.Name = "colno_pengiriman_edit"
        Me.colno_pengiriman_edit.Visible = True
        Me.colno_pengiriman_edit.VisibleIndex = 1
        '
        'colketerangan
        '
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 2
        '
        'colTanggal
        '
        Me.colTanggal.FieldName = "Tanggal"
        Me.colTanggal.Name = "colTanggal"
        Me.colTanggal.Visible = True
        Me.colTanggal.VisibleIndex = 3
        '
        'colTujuan
        '
        Me.colTujuan.FieldName = "Tujuan"
        Me.colTujuan.Name = "colTujuan"
        Me.colTujuan.Visible = True
        Me.colTujuan.VisibleIndex = 4
        '
        'colnama
        '
        Me.colnama.FieldName = "nama"
        Me.colnama.Name = "colnama"
        Me.colnama.Visible = True
        Me.colnama.VisibleIndex = 5
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 6
        '
        'MenuTab
        '
        Me.MenuTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuTab.Location = New System.Drawing.Point(0, 24)
        Me.MenuTab.Name = "MenuTab"
        Me.MenuTab.SelectedTabPage = Me.DeliveryPage
        Me.MenuTab.Size = New System.Drawing.Size(632, 417)
        Me.MenuTab.TabIndex = 2
        Me.MenuTab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.DeliveryPage, Me.Distribusi})
        '
        'V_suratjalanTableAdapter
        '
        Me.V_suratjalanTableAdapter.ClearBeforeFill = True
        '
        'V_suratjalan_detailTableAdapter1
        '
        Me.V_suratjalan_detailTableAdapter1.ClearBeforeFill = True
        '
        'noberkas
        '
        Me.noberkas.AutoSize = True
        Me.noberkas.Location = New System.Drawing.Point(402, 0)
        Me.noberkas.Name = "noberkas"
        Me.noberkas.Size = New System.Drawing.Size(0, 13)
        Me.noberkas.TabIndex = 4
        Me.noberkas.Visible = False
        '
        'userid
        '
        Me.userid.AutoSize = True
        Me.userid.Location = New System.Drawing.Point(372, 4)
        Me.userid.Name = "userid"
        Me.userid.Size = New System.Drawing.Size(38, 13)
        Me.userid.TabIndex = 2
        Me.userid.Text = "Label1"
        Me.userid.Visible = False
        '
        'DeliveryDataSetBindingSource
        '
        Me.DeliveryDataSetBindingSource.DataSource = Me.DeliveryDataSet
        Me.DeliveryDataSetBindingSource.Position = 0
        '
        'BukuBindingSource
        '
        Me.BukuBindingSource.DataMember = "buku"
        Me.BukuBindingSource.DataSource = Me.DeliveryDataSet
        '
        'BukuTableAdapter
        '
        Me.BukuTableAdapter.ClearBeforeFill = True
        '
        'buku_code
        '
        Me.buku_code.AutoSize = True
        Me.buku_code.Location = New System.Drawing.Point(405, 4)
        Me.buku_code.Name = "buku_code"
        Me.buku_code.Size = New System.Drawing.Size(38, 13)
        Me.buku_code.TabIndex = 2
        Me.buku_code.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 441)
        Me.Controls.Add(Me.noberkas)
        Me.Controls.Add(Me.MenuTab)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Index"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Distribusi.ResumeLayout(False)
        Me.Distribusi.PerformLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Insert.ResumeLayout(False)
        Me.Insert.PerformLayout()
        Me.DeliveryPage.ResumeLayout(False)
        Me.DeliveryPage.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VsuratjalanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuTab.ResumeLayout(False)
        CType(Me.DeliveryDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JilidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JenjangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTujuanKirimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TujuanKirimToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuratJalanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents colno_pengiriman1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colno_pengiriman_edit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coltgl1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colkirimke1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colchecker1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldatecreated1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Distribusi As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents DeliveryPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents MenuTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DeliveryDataSet As deliveryDataSet
    Friend WithEvents VsuratjalanBindingSource As BindingSource
    Friend WithEvents V_suratjalanTableAdapter As deliveryDataSetTableAdapters.v_suratjalanTableAdapter
    Friend WithEvents V_suratjalan_detailTableAdapter1 As deliveryDataSetTableAdapters.v_suratjalan_detailTableAdapter
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents Tambah As ToolStripButton
    Friend WithEvents Edit As ToolStripButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colno_pengiriman As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colno_pengiriman_edit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTujuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents noberkas As Label
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents userid As Label
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents Revisi As ToolStripButton
    Friend WithEvents Print As ToolStripButton
    Friend WithEvents DeliveryDataSetBindingSource As BindingSource
    Friend WithEvents BukuBindingSource As BindingSource
    Friend WithEvents BukuTableAdapter As deliveryDataSetTableAdapters.bukuTableAdapter
    Friend WithEvents XpCollection1 As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Insert As ToolStrip
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents Update As ToolStripButton
    Friend WithEvents Refresh As ToolStripButton
    Friend WithEvents Close As ToolStripButton
    Friend WithEvents buku_code As Label







#End Region

End Class
