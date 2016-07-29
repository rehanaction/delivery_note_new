Imports MySql.Data.MySqlClient
Imports System.Math
Module dbconfig
    Public conn As MySqlConnection
    Public CMD As MySqlCommand
    Public DS As New DataSet
    Public DA As MySqlDataAdapter
    Public RD As MySqlDataReader
    Public dt As DataTable
    Public lokasiData As String
    Private bindingSource1 As New BindingSource()
    Public con_server As String
    Public con_userid As String
    Public con_password As String
    Public con_database As String
    Public con_string As String
    Public Sub koneksi()
        lokasiData = "Server=192.168.1.212;user id=duta;password=dutaduta;database=delivery;"
        Try
            conn = New MySqlConnection(lokasiData)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Tidak Terhubung Ke database Silahkan Hubungi SysAdmin")
        End Try
    End Sub
    Public Sub noBerkasCode(txt As TextBox)
        Dim code As String = ""
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("SELECT no_pengiriman FROM  delivery ORDER BY no_pengiriman DESC LIMIT 1", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim ss As String
            ss = Strings.Right(RD!no_pengiriman, 4)
            Select Case Convert.ToDouble(ss)
                Case Is < 9
                    code = "Duta-000" & Convert.ToDouble(ss) + 1
                Case Is < 99
                    code = "Duta-00" & Convert.ToDouble(ss) + 1
                Case Is < 999
                    code = "Duta-0" & Convert.ToDouble(ss) + 1
                Case Is < 999
                    code = "Duta-" & Convert.ToDouble(ss) + 1
            End Select
        Else
            code = "Duta-0791"
        End If
        txt.Text = code
        conn.Close()
    End Sub
    Public Function getNoberkas()
        Dim code As String = ""
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("SELECT no_pengiriman FROM  delivery ORDER BY no_pengiriman DESC LIMIT 1", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Dim ss As String
            ss = Strings.Right(RD!no_pengiriman, 4)
            Select Case Convert.ToDouble(ss)
                Case Is < 9
                    code = "Duta-000" & Convert.ToDouble(ss) + 1
                Case Is < 99
                    code = "Duta-00" & Convert.ToDouble(ss) + 1
                Case Is < 999
                    code = "Duta-0" & Convert.ToDouble(ss) + 1
                Case Is < 999
                    code = "Duta-" & Convert.ToDouble(ss) + 1
            End Select
        Else
            code = "Duta-0791"
        End If
        Return code
        conn.Close()
    End Function
    Public Sub itemCombo(ByVal field As String, ByVal cmb As ComboBox, ByVal db As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Try
            Dim query As String
            'Dim a As Integer
            query = "select " & field & ",id from " & db & " ORDER BY id asc"
            CMD = New MySqlCommand(query, conn)
            RD = CMD.ExecuteReader
            While RD.Read
                cmb.Items.Add(RD.Item(1) & "-" & RD.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        conn.Close()
    End Sub
    Public Sub getDate(ByVal txt As TextBox)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("SELECT CURDATE() as tgl", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            txt.Text = RD!tgl
        End If
        conn.Close()
    End Sub
    Public Function getIdbyCodeCab(ByVal kc As String)
        Dim rp As String
        rp = kc.Replace(" ", "")
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("SELECT id from cabang where kodecabang Like'%" & rp & "%'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Return RD!id
        Else
            Return 0
        End If
        conn.Close()
    End Function
    Sub findBukuByCode(ByVal param As String, ByVal baris As Integer, ByVal dgv As DataGridView, ByVal op As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from buku Where ISBN='" & param & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            dgv.Rows(baris).Cells(1).Value = RD("KodeBuku")
            dgv.Rows(baris).Cells(1).ReadOnly = True
            dgv.Rows(baris).Cells(2).Value = RD("Judul")
            dgv.Rows(baris).Cells(2).ReadOnly = True
            If Not IsDBNull(RD("konversiBerat")) Then
                dgv.Rows(baris).Cells(5).Value = RD("konversiBerat")
                dgv.Rows(baris).Cells(5).ReadOnly = True
            Else
                dgv.Rows(baris).Cells(5).Value = 0
                dgv.Rows(baris).Cells(5).ReadOnly = True
            End If
            If Not IsDBNull(RD("jumlah_koli")) Then
                dgv.Rows(baris).Cells(8).Value = RD("jumlah_koli")
                dgv.Rows(baris).Cells(8).ReadOnly = True
            Else
                dgv.Rows(baris).Cells(8).Value = 0
                dgv.Rows(baris).Cells(8).ReadOnly = True
            End If
        Else
            RD.Close()
            CMD = New MySqlCommand("select * from buku Where KodeBuku='" & param & "'", conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                dgv.Rows(baris).Cells(1).Value = RD("KodeBuku")
                dgv.Rows(baris).Cells(1).ReadOnly = True
                dgv.Rows(baris).Cells(2).Value = RD("Judul")
                dgv.Rows(baris).Cells(2).ReadOnly = True
                If Not IsDBNull(RD("konversiBerat")) Then
                    dgv.Rows(baris).Cells(5).Value = RD("konversiBerat")
                    dgv.Rows(baris).Cells(5).ReadOnly = True
                Else
                    dgv.Rows(baris).Cells(5).Value = 0
                    dgv.Rows(baris).Cells(5).ReadOnly = True
                End If
                If Not IsDBNull(RD("jumlah_koli")) Then
                    dgv.Rows(baris).Cells(8).Value = RD("jumlah_koli")
                    dgv.Rows(baris).Cells(8).ReadOnly = True
                Else
                    dgv.Rows(baris).Cells(8).Value = 0
                    dgv.Rows(baris).Cells(8).ReadOnly = True
                End If
            Else
                MsgBox("Kode Buku Tidak Terdaftar Hubungi SysAdmin", MsgBoxStyle.Information, "Perhatian")
            End If
        End If
    End Sub
    Public Sub viewLookUpdBuku(ByVal dgv As DataGridView)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        DA = New MySqlDataAdapter("select * from buku where KodeBuku=''", conn)
        DS.Reset()
        DS.Clear()
        DS.Tables.Clear()
        DA.Fill(DS)
        dgv.DataSource = DS.Tables(0)
        conn.Close()
    End Sub
    Public Sub TransferBook(ByVal np As String, ByVal tgl As String, ByVal idcab As String, ByVal idcek As String, ByVal ket As String, ByVal uid As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from delivery where no_pengiriman=@kode", conn)
        CMD.Parameters.Add("@kode", MySqlDbType.VarChar, 50).Value = np
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "Insert Into delivery (no_pengiriman,tgl,kirimke,checker,keterangan,datecreated,status,userinput) Values('" & np & "','" & tgl & "','" & idcab & "','" & idcek & "','" & ket & "',NOW(),'1','" & uid & "')"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                ' MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            'MsgBox("No. Berkas Sudah Ada ", MsgBoxStyle.Exclamation)
        End If
        conn.Close()
    End Sub
    Public Sub TransferBookDetail(ByVal np As String, ByVal isbn As String, ByVal kb As String, ByVal exp As String, ByVal koli As String, ByVal berat As String, ByVal cc As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from delivery_detail where no_pengiriman=@kode and kodebuku=@kb", conn)
        CMD.Parameters.Add("@kode", MySqlDbType.VarChar, 50).Value = np
        CMD.Parameters.Add("@kb", MySqlDbType.VarChar, 50).Value = kb
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            RD.Close()
            CMD = New MySqlCommand("select Coalesce(jumlah_koli,0) as koli,Coalesce(isbn,kodebuku) as isbn from buku where kodebuku=@kb", conn)
            CMD.Parameters.Add("@kb", MySqlDbType.VarChar, 50).Value = kb
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                If cc <> "44" Then
                    koli = Convert.ToDouble(Convert.ToDouble(exp) / Convert.ToDouble(RD!koli))
                    isbn = RD!isbn
                Else
                    koli = 'NULL
                    berat = 'NULL'
                    isbn = RD!isbn
                End If
                Try
                        conn.Close()
                        conn.Open()
                        Dim query As String
                        query = "Insert Into delivery_detail (no_pengiriman,isbn,kodebuku,eksemplar,koli,berat) Values('" & np & "','" & isbn & "','" & kb & "','" & exp & "','" & koli & "','" & berat & "')"
                        CMD = New MySqlCommand(query, conn)
                        CMD.ExecuteNonQuery()
                        CMD.Dispose()
                        'MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                End If
            Else
            MsgBox("No. Berkas Sudah Ada ", MsgBoxStyle.Exclamation)
        End If
        conn.Close()
    End Sub
    Public Sub UpdateTransferBookDetail(ByVal np As String, ByVal isbn As String, ByVal kb As String, ByVal exp As String, ByVal koli As String, ByVal berat As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from delivery_detail where no_pengiriman=@kode and kodebuku=@kb", conn)
        CMD.Parameters.Add("@kode", MySqlDbType.VarChar, 50).Value = np
        CMD.Parameters.Add("@kb", MySqlDbType.VarChar, 50).Value = kb
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Try
                conn.Close()
                conn.Open()
                Dim query As String
                query = "update delivery_detail set eksemplar='" & exp & "',koli='" & koli & "',berat='" & berat & "' where no_pengiriman='" & np & "' and kodebuku='" & kb & "'"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                'MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MsgBox("No. Berkas Tidak Ada ", MsgBoxStyle.Exclamation)
        End If
        conn.Close()
    End Sub
    Public Sub findDeliveryByNo(ByVal pk As String, ByVal tnB As TextBox, ByVal ccb As ComboBox, ByVal cck As ComboBox, ByVal btn As Button, ByVal nb As Label, ByVal stat As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("SELECT delivery.no_pengiriman, delivery.no_pengiriman_edit,delivery.tgl,delivery.kirimke,delivery.checker,delivery.keterangan,cabang.cabang,checker.nama_checker FROM delivery Inner Join cabang ON delivery.kirimke = cabang.id Inner Join checker ON delivery.checker = checker.id
 where delivery.no_pengiriman=@kode", conn)
        CMD.Parameters.Add("@kode", MySqlDbType.VarChar, 50).Value = pk
        RD = CMD.ExecuteReader
        RD.Read()
        If stat = "Revisi" Then
            If RD.HasRows Then
                tnB.Text = ""
                tnB.Text = RD.Item(0) + "-R"
                nb.Text = RD.Item(0)
                ccb.Enabled = False
                ccb.Text = RD.Item(3) & "-" & RD.Item(6)
                cck.Enabled = False
                cck.Text = RD.Item(4) & "-" & RD.Item(7)
                btn.Text = "Revisi"
            Else
                MsgBox("Data No Berkas Tidak Ditemukan", MsgBoxStyle.Information)
            End If
        ElseIf stat = "Perbaharui" Then
            If RD.HasRows Then
                tnB.Text = ""
                tnB.Text = RD.Item(0)
                nb.Text = RD.Item(0)
                ccb.Enabled = False
                ccb.Text = RD.Item(3) & "-" & RD.Item(6)
                cck.Enabled = False
                cck.Text = RD.Item(4) & "-" & RD.Item(7)
                btn.Text = "Perbaharui"
            Else
                MsgBox("Data No Berkas Tidak Ditemukan", MsgBoxStyle.Information)
            End If
        End If
        conn.Close()
    End Sub
    Public Sub findBookbyKode(ByVal kb As String, ByVal tkb As TextBox, ByVal tjd As TextBox, ByVal tjl As TextBox, ByVal cj As ComboBox, ByVal cc As ComboBox, ByVal ck As ComboBox, ByVal ti As TextBox, ByVal tb As TextBox, ByVal tk As TextBox, ByVal btn As Button)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select kodeBuku,COALESCE(isbn,'') As ISBN,judul,COALESCE(jilid,'') as Jilid,jenjang,kategori,kurikulum,COALESCE(konversiBerat,0) as Berat,COALESCE(jumlah_koli,0) AS koli from buku Inner Join jenjang ON buku.id_jenjang = jenjang.id Inner Join kategori ON buku.id_kategori = kategori.id Inner Join kurikulum ON buku.id_kurikulum = kurikulum.id Where KodeBuku='" & kb & "'", conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            tkb.Enabled = False
            tkb.Text = RD.Item(0)
            tjd.Text = RD.Item(2)
            tjl.Text = RD.Item(3)
            ti.Text = RD.Item(1)
            cj.Text = RD("jenjang")
            cc.Text = RD("kategori")
            ck.Text = RD("kurikulum")
            ti.Text = RD("ISBN")
            tb.Text = RD("Berat")
            tk.Text = RD("koli")
            btn.Text = "Perbaharui"
        Else
            MsgBox("Kode Buku Tidak Di temukan", MsgBoxStyle.Exclamation, "Peringatan")
        End If
    End Sub

    Public Sub viewLookUpdBukudetial(ByVal np As String, ByVal dgv As DataGridView)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        dgv.Rows.Clear()
        dgv.Columns.Clear()
        DA = New MySqlDataAdapter("SELECT delivery_detail.isbn AS ISBN,delivery_detail.kodebuku AS Kode_Buku,buku.Judul,delivery_detail.eksemplar,delivery_detail.koli,Buku.konversiBerat,COALESCE(delivery_detail.berat,0) AS 'Berat/Kg Tambahan',COALESCE((Buku.konversiBerat*delivery_detail.koli),0) AS 'Sub Total Berat',coalesce(buku.jumlah_koli,0) as 'Jumlah koli' FROM delivery_detail Inner Join buku ON buku.KodeBuku = delivery_detail.kodebuku where no_pengiriman='" & np & "'", conn)
        DS.Reset()
        DS.Clear()
        DS.Tables.Clear()
        DA.Fill(DS)
        dgv.DataSource = DS.Tables(0)
        dgv.Columns(5).Visible = False
        dgv.Columns(8).Visible = False
        conn.Close()
    End Sub
    Public Sub UpdateTransferBook(ByVal np As String, ByVal npp As String, ByVal tgl As String, ByVal idcab As String, ByVal idcek As String, ByVal ket As String, ByVal stat As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from delivery where no_pengiriman=@kode", conn)
        CMD.Parameters.Add("@kode", MySqlDbType.VarChar, 50).Value = np
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            If stat = "Revisi" Then
                Try
                    conn.Close()
                    conn.Open()
                    Dim query, query2 As String
                    query = "Update delivery set no_pengiriman_edit='" & npp & "',keterangan='" & ket & "' where no_pengiriman='" & np & "'"
                    CMD = New MySqlCommand(query, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                    query2 = "Insert Into delivery (no_pengiriman,tgl,kirimke,checker,datecreated,status,userinput) Values('" & npp & "','" & tgl & "','" & idcab & "','" & idcek & "',NOW(),1,'" & Form1.userid.Text & "')"
                    CMD = New MySqlCommand(query2, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                    MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            ElseIf stat = "Perbaharui" Then
                Try
                    conn.Close()
                    conn.Open()
                    Dim query As String
                    query = "Update delivery set keterangan='" & ket & "',tgl='" & tgl & "' where no_pengiriman='" & np & "'"
                    CMD = New MySqlCommand(query, conn)
                    CMD.ExecuteNonQuery()
                    CMD.Dispose()
                    MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            End If
        Else
                MsgBox("No. Berkas Sudah Ada ", MsgBoxStyle.Exclamation)
            End If
        conn.Close()
    End Sub
    Public Sub reportview()
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        DA = New MySqlDataAdapter("SELECT * FROM v_ttb", conn)
        DS.Reset()
        DS.Clear()
        DS.Tables.Clear()
        DA.Fill(DS, "ttb")
        dt = Nothing
        dt = DS.Tables("ttb")
        conn.Close()
    End Sub
    Public Sub cekLogin(ByVal uname As String, ByVal pwd As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from user where userid=@uname and password=@pwd", conn)
        CMD.Parameters.Add("@uname", MySqlDbType.VarChar, 25).Value = uname
        CMD.Parameters.Add("@pwd", MySqlDbType.VarChar, 25).Value = pwd
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            Form1.userid.Text = RD!userid
            Form1.Show()
            Login.Hide()
        Else
            MsgBox("Username dan Password Tidak Terdaftar Harap Hubungi Adminstrator", MsgBoxStyle.Information)
        End If
    End Sub
    Public Sub viewBuku(ByVal dgv As DevExpress.XtraGrid.GridControl)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        Try
            DA = New MySqlDataAdapter("SELECT buku.KodeBuku,buku.ISBN,buku.Judul,buku.Jilid,jenjang.Jenjang,kategori.Kategori,kurikulum.Kurikulum FROM buku Inner Join jenjang ON buku.id_jenjang = jenjang.id Inner Join kategori ON buku.id_kategori = kategori.id Inner Join kurikulum ON buku.id_kurikulum = kurikulum.id
", conn)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Try
            DS.Reset()
            DS.Clear()
            DS.Tables.Clear()
            DA.Fill(DS)
            dgv.DataSource = DS.Tables(0)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        conn.Close()
    End Sub
    Public Sub itemCombox(ByVal field As String, ByVal table As String, ByVal attr As ComboBox)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select " & field & " from " & table & "", conn)
        RD = CMD.ExecuteReader()
        While RD.Read
            attr.Items.Add(RD.Item(0))
        End While
        conn.Close()
    End Sub
    Public Function getidByparam(ByVal field As String, ByVal param As String, ByVal table As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select id from " & table & " where " & field & " like '%" & param & "%'", conn)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            Return RD.Item(0)
        End If
        conn.Close()
    End Function
    Public Function getparambyid(ByVal field As String, ByVal param As String, ByVal table As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select " & field & " from " & table & " where id='" & param & "'", conn)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            Return RD.Item(0)
        End If
    End Function
    Public Function getparambyidkr(ByVal field As String, ByVal param As String, ByVal table As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from " & table & " where id='" & param & "'", conn)
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            Return RD.Item(1)
        End If
        conn.Close()
    End Function
    Public Sub insertBook(ByVal kb As String, ByVal isbn As String, ByVal jd As String, ByVal jl As String, ByVal ij As String, ByVal ik As String, ByVal ic As String, ByVal br As String, ByVal jk As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from buku where KodeBuku=@kb   ", conn)
        CMD.Parameters.Add("@kb", MySqlDbType.VarChar, 20).Value = kb
        RD = CMD.ExecuteReader()
        RD.Read()
        If Not RD.HasRows Then
            RD.Close()
            Try
                Dim query As String
                query = "insert into buku (KodeBuku,ISBN,Judul,Jilid,id_jenjang,id_kategori,id_kurikulum,konversiBerat,status,userid,inputTime,jumlah_koli) values('" & kb & "','" & isbn & "','" & jd & "','" & jl & "','" & ij & "','" & ic & "','" & ik & "','" & br & "','1','" & Form1.userid.Text & "',NOW(),'" & jk & "')"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        Else
            MsgBox("Data Buku Sudah Ada Di dalam Database", MsgBoxStyle.Information, "Informasi")
        End If
        conn.Close()
    End Sub
    Public Sub UpdateBook(ByVal kb As String, ByVal isbn As String, ByVal jd As String, ByVal jl As String, ByVal ij As String, ByVal ik As String, ByVal ic As String, ByVal br As String, ByVal jk As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
            conn.Open()
        Else
            conn.Open()
        End If
        CMD = New MySqlCommand("select * from buku where KodeBuku=@kb   ", conn)
        CMD.Parameters.Add("@kb", MySqlDbType.VarChar, 20).Value = kb
        RD = CMD.ExecuteReader()
        RD.Read()
        If RD.HasRows Then
            RD.Close()
            Try
                Dim query As String
                query = "update buku set ISBN='" & isbn & "',Judul='" & jd & "',Jilid='" & jl & "',id_jenjang='" & ij & "',id_kategori='" & ic & "',id_kurikulum='" & ik & "',konversiBerat='" & br & "',jumlah_koli='" & jk & "' where KodeBuku='" & kb & "'"
                CMD = New MySqlCommand(query, conn)
                CMD.ExecuteNonQuery()
                CMD.Dispose()
                MsgBox("Data Diperbaharui Disimpan", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        conn.Close()
    End Sub
End Module
