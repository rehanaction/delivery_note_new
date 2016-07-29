Public Class Buku
    Private Sub Buku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        itemCombox("Jenjang", "Jenjang", cmbJenjang)
        itemCombox("Kategori", "kategori", cmbCategeory)
        itemCombox("kurikulum", "kurikulum", cmbKurikulum)
    End Sub
    Private Sub txtKodeBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKodeBuku.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)
    End Sub
    Private Sub txtISBN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtISBN.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back) Then
            KeyAscii = 0
        End If

        e.Handled = CBool(KeyAscii)
    End Sub
    Private Sub txtBerat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBerat.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)
    End Sub
    Private Sub txtJkoli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJkoli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" _
            OrElse KeyAscii = Keys.Back) Then
            KeyAscii = 0
        End If
        e.Handled = CBool(KeyAscii)
    End Sub
    Private Sub cmbJenjang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJenjang.SelectedIndexChanged

    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeBuku.Text <> "" And txtJudul.Text <> "" And cmbJenjang.Text <> "" And cmbCategeory.Text <> "" And cmbKurikulum.Text <> "" Then
            If btnSimpan.Text = "Simpan" Then
                insertBook(txtKodeBuku.Text, txtISBN.Text, txtJudul.Text, txtJilid.Text, getidByparam("Jenjang", cmbJenjang.Text, "Jenjang"), getidByparam("Kurikulum", cmbKurikulum.Text, "kurikulum"), getidByparam("Kategori", cmbCategeory.Text, "kategori"), txtBerat.Text, txtJkoli.Text)
                Me.Close()
            ElseIf btnSimpan.Text = "Perbaharui" Then
                UpdateBook(txtKodeBuku.Text, txtISBN.Text, txtJudul.Text, txtJilid.Text, getidByparam("Jenjang", cmbJenjang.Text, "Jenjang"), getidByparam("Kurikulum", cmbKurikulum.Text, "kurikulum"), getidByparam("Kategori", cmbCategeory.Text, "kategori"), txtBerat.Text, txtJkoli.Text)
                Me.Close()
            End If
        Else
                MsgBox("Data Kode buku,judul,jilid,jenjang, dan kurikulum wajib diisi", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub
End Class