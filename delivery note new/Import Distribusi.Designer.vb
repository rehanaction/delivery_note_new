<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Import_Distribusi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dgvImport = New DevExpress.XtraGrid.GridControl()
        Me.txtNoberkas = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&File Path"
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(76, 6)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(208, 20)
        Me.txtFile.TabIndex = 1
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(251, 6)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(33, 20)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Import File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.dgvImport
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, Nothing, Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsMenu.ShowAutoFilterRowItem = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'dgvImport
        '
        Me.dgvImport.Location = New System.Drawing.Point(2, 32)
        Me.dgvImport.MainView = Me.GridView1
        Me.dgvImport.Name = "dgvImport"
        Me.dgvImport.Size = New System.Drawing.Size(1002, 618)
        Me.dgvImport.TabIndex = 3
        Me.dgvImport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'txtNoberkas
        '
        Me.txtNoberkas.Location = New System.Drawing.Point(515, 9)
        Me.txtNoberkas.Name = "txtNoberkas"
        Me.txtNoberkas.ReadOnly = True
        Me.txtNoberkas.Size = New System.Drawing.Size(100, 20)
        Me.txtNoberkas.TabIndex = 5
        Me.txtNoberkas.Visible = False
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(666, 12)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(39, 13)
        Me.id.TabIndex = 6
        Me.id.Text = "Label2"
        Me.id.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(394, 6)
        Me.DateTimePicker1.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(142, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tanggal Distribusi"
        '
        'Import_Distribusi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 662)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.txtNoberkas)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvImport)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Import_Distribusi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import_Distribusi"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFile As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgvImport As DevExpress.XtraGrid.GridControl
    Friend WithEvents txtNoberkas As TextBox
    Friend WithEvents id As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
End Class
