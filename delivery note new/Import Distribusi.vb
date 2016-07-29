Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Import_Distribusi
    Dim tblImport As DataTable
    Dim con As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim source1 As New BindingSource
    Dim tgl, nb As String
    Private Sub Import_Distribusi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nb = getNoberkas()
        tgl = Format(CDate(Date.Now.Date), "yyyy-MM-dd")
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim fBrowse As New OpenFileDialog
        Dim sheetname As String
        With fBrowse
            .Filter = "excel files 2003-2007 (*.xls)|*.xls|all files (*.*)|*.*"
            .FilterIndex = 1
            .Title = "Import data From Excel File"
        End With
        If fBrowse.ShowDialog() = Windows.Forms.DialogResult.OK Then
            txtFile.Text = fBrowse.FileName
            'Dim excel As String = fBrowse.FileName
            'Dim xl As New Excel.Application
            'Dim xlsheet As Excel.Worksheet
            'Dim xlwbook As Excel.Workbook
            ''xlwbook = xl.Workbooks.Open(excel)
            ''xlsheet = xlwbook.Sheets.Item(1)
            'For Each sht In xlwbook.Worksheets
            '    sheetname = sht.Name
            'Next
            ''xl.ActiveWorkbook.Close(False, excel)
            'xl.Quit()
            'xlwbook = Nothing
            'xl = Nothing
            Try
                con = New OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" &
                    "data source='" & fBrowse.FileName & "';Extended Properties=Excel 8.0;")
                da = New OleDbDataAdapter("select * from [Sheet1$]", con)
                con.Open()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            Try
                ds.Reset()
                ds.Clear()
                ds.Tables.Clear()
                da.Fill(ds)
                dgvImport.DataSource = ds.Tables(0)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kb, ckb, kc, idx As String
        Dim baris As Double
        Dim s As Integer = 0
        For c As Integer = 4 To GridView1.Columns.Count - 2
            nb = getNoberkas()
            For baris = 0 To GridView1.RowCount - 1
                If Not IsDBNull(GridView1.GetRowCellValue(baris, GridView1.Columns(c).GetCaption().ToString())) And getIdbyCodeCab(GridView1.Columns(c).GetCaption().ToString()) <> 0 Then
                    If Convert.ToDouble(GridView1.GetRowCellValue(baris, GridView1.Columns(c).GetCaption().ToString())) <> 0 Then
                        TransferBook(nb, Format(CDate(DateTimePicker1.Text), "yyyy-MM-dd"), getIdbyCodeCab(GridView1.Columns(c).GetCaption().ToString()), "1", "", Form1.userid.Text)
                        kb = GridView1.GetRowCellValue(baris, "Kode Buku")
                        ckb = kb.Replace("-", "")
                        TransferBookDetail(nb, ckb, ckb, GridView1.GetRowCellValue(baris, GridView1.Columns(c).GetCaption().ToString()), "", "", getIdbyCodeCab(GridView1.Columns(c).GetCaption().ToString()))
                        'MsgBox(ckb & "-" & GridView1.GetRowCellValue(baris, GridView1.Columns(c).GetCaption().ToString()) & "-" & GridView1.Columns(c).GetCaption().ToString())
                    End If
                End If
            Next
        Next
        MsgBox("Data Tersimpan", MsgBoxStyle.Information, "Informasi")
        Me.Close()
    End Sub
End Class