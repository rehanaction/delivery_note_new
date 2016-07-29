Imports System.Math
Public Class Insert_SJvb
    Private Sub Insert_SJvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        noBerkasCode(txtNoBerkas)
        itemCombo("cabang", CmbCabang, "cabang")
        itemCombo("nama_checker", cmbChecker, "checker")

        dgvKirim.ColumnCount = 9
        dgvKirim.Columns(0).Name = "ISBN/Kode Buku"
        dgvKirim.Columns(1).Name = "Kode Buku"
        dgvKirim.Columns(2).Name = "Judul"
        dgvKirim.Columns(3).Name = "Eksemplar"
        dgvKirim.Columns(4).Name = "Koli"
        dgvKirim.Columns(5).Name = "konversiberat"
        dgvKirim.Columns(5).Visible = False
        dgvKirim.Columns(6).Name = "Berat Tambahan"
        dgvKirim.Columns(7).Name = "Berat/Kg"
        dgvKirim.Columns(7).ReadOnly = True
        dgvKirim.Columns(8).Name = "jumlah_koli"
        dgvKirim.Columns(8).Visible = False

    End Sub
    Private Sub dgvKirim_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKirim.CellValueChanged
        If (e.ColumnIndex = 0) Then
            For baris = 0 To dgvKirim.RowCount - 2
                If dgvKirim.Rows(baris).Cells(0).Value.ToString <> "" Then
                    findBukuByCode(dgvKirim.Rows(baris).Cells(0).Value, baris, dgvKirim, "OK")
                End If
            Next
        End If
    End Sub
    Private Sub dgvKirim_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKirim.CellEndEdit
        If (e.ColumnIndex = 3) Then   ' Checking numeric value for Column1 only
            Dim value As String = dgvKirim.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For baris = 0 To dgvKirim.RowCount - 2
                dgvKirim.Rows(baris).Cells(8).Value = dgvKirim.Rows(baris).Cells(8).Value
                'MsgBox((dgvKirim.Rows(baris).Cells(5).Value * dgvKirim.Rows(baris).Cells(4).Value) + dgvKirim.Rows(baris).Cells(6).Value)
                dgvKirim.Rows(baris).Cells(4).Value = Convert.ToDouble((dgvKirim.Rows(baris).Cells(3).Value / dgvKirim.Rows(baris).Cells(8).Value))
            Next
        End If
        If (e.ColumnIndex = 6) Then   ' Checking numeric value for Column1 only
            Dim value As String = dgvKirim.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            For baris = 0 To dgvKirim.RowCount - 2
                dgvKirim.Rows(baris).Cells(6).Value = dgvKirim.Rows(baris).Cells(6).Value
                'MsgBox((dgvKirim.Rows(baris).Cells(5).Value * dgvKirim.Rows(baris).Cells(4).Value) + dgvKirim.Rows(baris).Cells(6).Value)
                dgvKirim.Rows(baris).Cells(7).Value = (dgvKirim.Rows(baris).Cells(5).Value * dgvKirim.Rows(baris).Cells(4).Value) + dgvKirim.Rows(baris).Cells(6).Value
            Next

        End If
    End Sub
    Private Sub CmbCabang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCabang.SelectedIndexChanged
        Label3.Text = CmbCabang.Text.Substring(0, 2)
    End Sub

    Private Sub cmbChecker_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChecker.SelectedIndexChanged
        Label4.Text = cmbChecker.Text.Substring(0, 1)
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If txtNoBerkas.Text <> "" And dtpTanggalKirim.Text <> "" And CmbCabang.Text <> "" And cmbChecker.Text <> "" Then
            If BtnSimpan.Text = "Simpan" Then
                TransferBook(txtNoBerkas.Text, Format(CDate(dtpTanggalKirim.Text), "yyyy-MM-dd"), Label3.Text, Label4.Text, txtKeterangan.Text, Form1.userid.Text)
                For baris As Integer = 0 To dgvKirim.RowCount - 2
                    TransferBookDetail(txtNoBerkas.Text, dgvKirim.Rows(baris).Cells(0).Value, dgvKirim.Rows(baris).Cells(1).Value, dgvKirim.Rows(baris).Cells(3).Value, dgvKirim.Rows(baris).Cells(4).Value, dgvKirim.Rows(baris).Cells(6).Value, Label3.Text)
                Next
                ttbviewer.noSurat.Text = txtNoBerkas.Text
                Me.Close()
                ttbviewer.Show()
            ElseIf BtnSimpan.Text = "Revisi" Then
                UpdateTransferBook(noberkas.Text, txtNoBerkas.Text, Format(CDate(dtpTanggalKirim.Text), "yyyy-MM-dd"), CmbCabang.Text.Substring(0, 2), cmbChecker.Text.Substring(0, 1), txtKeterangan.Text, "Revisi")
                For baris As Integer = 0 To dgvKirim.RowCount - 2
                    TransferBookDetail(txtNoBerkas.Text, dgvKirim.Rows(baris).Cells(0).Value, dgvKirim.Rows(baris).Cells(1).Value, dgvKirim.Rows(baris).Cells(3).Value, dgvKirim.Rows(baris).Cells(4).Value, dgvKirim.Rows(baris).Cells(6).Value, Label3.Text)
                Next
                ttbviewer.noSurat.Text = txtNoBerkas.Text
                Me.Close()
                ttbviewer.Show()
            ElseIf BtnSimpan.Text = "Perbaharui" Then
                UpdateTransferBook(noberkas.Text, txtNoBerkas.Text, Format(CDate(dtpTanggalKirim.Text), "yyyy-MM-dd"), CmbCabang.Text.Substring(0, 2), cmbChecker.Text.Substring(0, 1), txtKeterangan.Text, "Perbaharui")
                For baris As Integer = 0 To dgvKirim.RowCount - 2
                    UpdateTransferBookDetail(txtNoBerkas.Text, dgvKirim.Rows(baris).Cells(0).Value, dgvKirim.Rows(baris).Cells(1).Value, dgvKirim.Rows(baris).Cells(3).Value, dgvKirim.Rows(baris).Cells(4).Value, dgvKirim.Rows(baris).Cells(6).Value)
                Next
                ttbviewer.noSurat.Text = txtNoBerkas.Text
                Me.Close()
                ttbviewer.Show()
            End If
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub
End Class