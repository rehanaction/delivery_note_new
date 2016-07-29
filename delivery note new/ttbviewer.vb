
Public Class ttbviewer
    Dim con As MySql.Data.MySqlClient.MySqlConnection
    Dim report_penjualan As XtraReport1
    Sub DJIE_generate_report()
        Try
            Dim dset_source As New DataSet
            dset_source.Tables.Add("header")
            dset_source.Tables.Add("detail")

            Dim tbl_source As New DataTable
            con = New MySql.Data.MySqlClient.MySqlConnection("Server=192.168.1.212;user id=duta;password=dutaduta;database=delivery;")
            con.Open()
            Using adp As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM v_ttb where no_pengiriman='" & noSurat.Text & "'", con)
                'dapatkan data source sesuai kriteria kita
                adp.Fill(dset_source.Tables(0))
            End Using

            con = New MySql.Data.MySqlClient.MySqlConnection("Server=192.168.1.212;;user id=duta;password=dutaduta;database=delivery;")
            con.Open()
            Using adp As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM v_ttb where no_pengiriman='" & noSurat.Text & "'", con)
                'dapatkan data source sesuai kriteria kita
                adp.Fill(dset_source.Tables(1))
            End Using

            'dset_source.Relations.Add(New DataRelation("header_detail", dset_source.Tables(0).Columns("OrderID"), dset_source.Tables(1).Columns("OrderID")))

            'ambil report yg sudah kita buat
            report_penjualan = New XtraReport1
            With report_penjualan
                'set data source
                .DataSource = dset_source
                .DataMember = .DataMember
                .RequestParameters = False
                'set koneksi agar tidak minta login database
                .V_ttbTableAdapter1.Connection = con
                'buat report agar bisa di preview atau di print
                .CreateDocument()
            End With

        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ttbviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DJIE_generate_report()
        'tampilkan report
        DocumentViewer1.DocumentSource = report_penjualan
    End Sub
End Class