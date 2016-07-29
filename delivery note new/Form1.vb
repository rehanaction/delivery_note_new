Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid

Partial Public Class Form1

    Inherits DevExpress.XtraEditors.XtraForm
    Dim kb As String
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub SuratJalanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuratJalanToolStripMenuItem.Click
        DeliveryPage.PageVisible = True
        MenuTab.SelectedTabPage = DeliveryPage
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        koneksi()
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        Insert_SJvb.Show()
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        Dim i As Integer
        Dim row As System.Data.DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim CellValue As String = row(0)
        If CellValue <> "" Then
            noberkas.Text = CellValue
            Edit.Enabled = True
            Revisi.Enabled = True
            Print.Enabled = True
        Else
            Edit.Enabled = False
            noberkas.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If noberkas.Text <> "" Then
            Insert_SJvb.Show()
            findDeliveryByNo(noberkas.Text, Insert_SJvb.txtNoBerkas, Insert_SJvb.CmbCabang, Insert_SJvb.cmbChecker, Insert_SJvb.BtnSimpan, Insert_SJvb.noberkas, "Perbaharui")
            viewLookUpdBukudetial(noberkas.Text, Insert_SJvb.dgvKirim)
        Else
            MsgBox("Pilih Data Yang akan Di Perbaiki Terlebih Dahulu", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        DeliveryPage.PageVisible = False
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.V_suratjalanTableAdapter.Fill(Me.DeliveryDataSet.v_suratjalan)
        Me.V_suratjalan_detailTableAdapter1.Fill(Me.DeliveryDataSet.v_suratjalan_detail)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Import_Distribusi.Show()
    End Sub

    Private Sub Revisi_Click(sender As Object, e As EventArgs) Handles Revisi.Click
        If noberkas.Text <> "" Then
            Insert_SJvb.Show()
            findDeliveryByNo(noberkas.Text, Insert_SJvb.txtNoBerkas, Insert_SJvb.CmbCabang, Insert_SJvb.cmbChecker, Insert_SJvb.BtnSimpan, Insert_SJvb.noberkas, "Revisi")
            viewLookUpdBukudetial(noberkas.Text, Insert_SJvb.dgvKirim)
        Else
            MsgBox("Pilih Data Yang akan Di Perbaiki Terlebih Dahulu", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Print_Click(sender As Object, e As EventArgs) Handles Print.Click
        ttbviewer.noSurat.Text = noberkas.Text
        ttbviewer.Show()
    End Sub
    Private Sub DeliveryPage_VisibleChanged(sender As Object, e As EventArgs) Handles DeliveryPage.VisibleChanged
        'TODO: This line of code loads data into the 'DeliveryDataSet.v_suratjalan' table. You can move, or remove it, as needed.
        If DeliveryPage.Visible = True Then
            Me.V_suratjalanTableAdapter.Fill(Me.DeliveryDataSet.v_suratjalan)
            Me.V_suratjalan_detailTableAdapter1.Fill(Me.DeliveryDataSet.v_suratjalan_detail)
        End If
    End Sub

    Private Sub Distribusi_Paint(sender As Object, e As PaintEventArgs) Handles Distribusi.Paint

    End Sub

    Private Sub Distribusi_VisibleChanged(sender As Object, e As EventArgs) Handles Distribusi.VisibleChanged
        If Distribusi.Visible = True Then
            viewBuku(GridControl2)
        End If
    End Sub
    Private Sub BukuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukuToolStripMenuItem.Click
        Distribusi.PageVisible = False
        Distribusi.PageVisible = True
        MenuTab.SelectedTabPage = Distribusi
    End Sub



    Private Sub GridView2_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView2.RowClick
        Dim row As System.Data.DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        Dim CellValue As String = row(0)
        If CellValue <> "" Then
            buku_code.Text = CellValue
            Update.Enabled = True
        Else
            Update.Enabled = False
            noberkas.Text = ""
        End If
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Buku.Show()
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If buku_code.Text <> "" And buku_code.Text <> "Label1" Then
            Buku.Show()
            findBookbyKode(buku_code.Text, Buku.txtKodeBuku, Buku.txtJudul, Buku.txtJilid, Buku.cmbJenjang, Buku.cmbCategeory, Buku.cmbKurikulum, Buku.txtISBN, Buku.txtBerat, Buku.txtJkoli, Buku.btnSimpan)
        Else
            MsgBox("Pilih Data Yang akan Di Update Terlebih Dahulu", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        viewBuku(GridControl2)
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Distribusi.PageVisible = False
    End Sub
End Class
