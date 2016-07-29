<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buku
    Inherits System.Windows.Forms.Form

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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txtJkoli = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBerat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbKurikulum = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtISBN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbCategeory = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbJenjang = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJilid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKodeBuku = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnClose)
        Me.GroupControl1.Controls.Add(Me.btnSimpan)
        Me.GroupControl1.Controls.Add(Me.txtJkoli)
        Me.GroupControl1.Controls.Add(Me.Label10)
        Me.GroupControl1.Controls.Add(Me.Label9)
        Me.GroupControl1.Controls.Add(Me.txtBerat)
        Me.GroupControl1.Controls.Add(Me.Label8)
        Me.GroupControl1.Controls.Add(Me.cmbKurikulum)
        Me.GroupControl1.Controls.Add(Me.Label7)
        Me.GroupControl1.Controls.Add(Me.txtISBN)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.cmbCategeory)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.cmbJenjang)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.txtJilid)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.txtJudul)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.txtKodeBuku)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(410, 301)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Data Buku"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(96, 273)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "Batal"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(15, 273)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 20
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'txtJkoli
        '
        Me.txtJkoli.Location = New System.Drawing.Point(102, 240)
        Me.txtJkoli.MaxLength = 3
        Me.txtJkoli.Name = "txtJkoli"
        Me.txtJkoli.Size = New System.Drawing.Size(54, 21)
        Me.txtJkoli.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Jumlah/Koli"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(162, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "/Kg"
        '
        'txtBerat
        '
        Me.txtBerat.Location = New System.Drawing.Point(102, 213)
        Me.txtBerat.MaxLength = 2
        Me.txtBerat.Name = "txtBerat"
        Me.txtBerat.Size = New System.Drawing.Size(54, 21)
        Me.txtBerat.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Berat/Koli"
        '
        'cmbKurikulum
        '
        Me.cmbKurikulum.FormattingEnabled = True
        Me.cmbKurikulum.Location = New System.Drawing.Point(102, 155)
        Me.cmbKurikulum.Name = "cmbKurikulum"
        Me.cmbKurikulum.Size = New System.Drawing.Size(166, 21)
        Me.cmbKurikulum.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Kurikulum"
        '
        'txtISBN
        '
        Me.txtISBN.Location = New System.Drawing.Point(102, 183)
        Me.txtISBN.MaxLength = 20
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(166, 21)
        Me.txtISBN.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ISBN"
        '
        'cmbCategeory
        '
        Me.cmbCategeory.FormattingEnabled = True
        Me.cmbCategeory.Location = New System.Drawing.Point(283, 125)
        Me.cmbCategeory.Name = "cmbCategeory"
        Me.cmbCategeory.Size = New System.Drawing.Size(83, 21)
        Me.cmbCategeory.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Category"
        '
        'cmbJenjang
        '
        Me.cmbJenjang.FormattingEnabled = True
        Me.cmbJenjang.Location = New System.Drawing.Point(102, 125)
        Me.cmbJenjang.Name = "cmbJenjang"
        Me.cmbJenjang.Size = New System.Drawing.Size(102, 21)
        Me.cmbJenjang.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jenjang"
        '
        'txtJilid
        '
        Me.txtJilid.Location = New System.Drawing.Point(102, 95)
        Me.txtJilid.MaxLength = 5
        Me.txtJilid.Name = "txtJilid"
        Me.txtJilid.Size = New System.Drawing.Size(54, 21)
        Me.txtJilid.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jilid"
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(102, 64)
        Me.txtJudul.MaxLength = 60
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(250, 21)
        Me.txtJudul.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Judul"
        '
        'txtKodeBuku
        '
        Me.txtKodeBuku.Location = New System.Drawing.Point(102, 28)
        Me.txtKodeBuku.MaxLength = 11
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.Size = New System.Drawing.Size(154, 21)
        Me.txtKodeBuku.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kode Buku"
        '
        'Buku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 301)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "Buku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buku"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtJilid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtJkoli As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtBerat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbKurikulum As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtISBN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbCategeory As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbJenjang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSimpan As Button
End Class
