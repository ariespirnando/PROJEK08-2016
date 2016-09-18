<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_Slip
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.LaporanKaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Laporan = New TAFitri2016.Laporan()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.txtNikKaryawan = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtTanggalakhir = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBKaryawan = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtvKaryawan = New System.Windows.Forms.DataGridView()
        Me.txtcarinikkaryawan = New System.Windows.Forms.TextBox()
        Me.LaporanKaryawanTableAdapter = New TAFitri2016.LaporanTableAdapters.LaporanKaryawanTableAdapter()
        CType(Me.LaporanKaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GBKaryawan.SuspendLayout()
        CType(Me.dtvKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LaporanKaryawanBindingSource
        '
        Me.LaporanKaryawanBindingSource.DataMember = "LaporanKaryawan"
        Me.LaporanKaryawanBindingSource.DataSource = Me.Laporan
        '
        'Laporan
        '
        Me.Laporan.DataSetName = "Laporan"
        Me.Laporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "laporanKaryawan"
        ReportDataSource1.Value = Me.LaporanKaryawanBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TAFitri2016.Slip.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 124)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(886, 368)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.txtNamaKaryawan)
        Me.GroupBox1.Controls.Add(Me.txtNikKaryawan)
        Me.GroupBox1.Controls.Add(Me.txttanggal)
        Me.GroupBox1.Controls.Add(Me.txtTanggalakhir)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(886, 106)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "..:: Input Parameter ::.."
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(328, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "......"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.Enabled = False
        Me.txtNamaKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(149, 66)
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(235, 23)
        Me.txtNamaKaryawan.TabIndex = 28
        '
        'txtNikKaryawan
        '
        Me.txtNikKaryawan.Enabled = False
        Me.txtNikKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNikKaryawan.Location = New System.Drawing.Point(149, 35)
        Me.txtNikKaryawan.Name = "txtNikKaryawan"
        Me.txtNikKaryawan.Size = New System.Drawing.Size(173, 23)
        Me.txtNikKaryawan.TabIndex = 27
        '
        'txttanggal
        '
        Me.txttanggal.CustomFormat = "dd-MM-yyyy"
        Me.txttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttanggal.Location = New System.Drawing.Point(586, 33)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(150, 23)
        Me.txttanggal.TabIndex = 25
        Me.txttanggal.Value = New Date(2016, 6, 1, 0, 0, 0, 0)
        '
        'txtTanggalakhir
        '
        Me.txtTanggalakhir.CustomFormat = "dd-MM-yyyy"
        Me.txtTanggalakhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTanggalakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtTanggalakhir.Location = New System.Drawing.Point(586, 64)
        Me.txtTanggalakhir.Name = "txtTanggalakhir"
        Me.txtTanggalakhir.Size = New System.Drawing.Size(150, 23)
        Me.txtTanggalakhir.TabIndex = 26
        Me.txtTanggalakhir.Value = New Date(2016, 6, 1, 0, 0, 0, 0)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(792, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "..:: Keluar ::.."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(792, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "..:: Proses ::.."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(464, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tanggal Akhir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(464, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal Awal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NIK Karyawan"
        '
        'GBKaryawan
        '
        Me.GBKaryawan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GBKaryawan.Controls.Add(Me.Label12)
        Me.GBKaryawan.Controls.Add(Me.dtvKaryawan)
        Me.GBKaryawan.Controls.Add(Me.txtcarinikkaryawan)
        Me.GBKaryawan.Location = New System.Drawing.Point(310, 42)
        Me.GBKaryawan.Name = "GBKaryawan"
        Me.GBKaryawan.Size = New System.Drawing.Size(393, 276)
        Me.GBKaryawan.TabIndex = 30
        Me.GBKaryawan.TabStop = False
        Me.GBKaryawan.Text = "..:: Karyawan ::.."
        Me.GBKaryawan.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 17)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "NIK Karyawan"
        '
        'dtvKaryawan
        '
        Me.dtvKaryawan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.dtvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvKaryawan.Location = New System.Drawing.Point(14, 82)
        Me.dtvKaryawan.Name = "dtvKaryawan"
        Me.dtvKaryawan.Size = New System.Drawing.Size(373, 214)
        Me.dtvKaryawan.TabIndex = 15
        '
        'txtcarinikkaryawan
        '
        Me.txtcarinikkaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarinikkaryawan.Location = New System.Drawing.Point(130, 27)
        Me.txtcarinikkaryawan.Name = "txtcarinikkaryawan"
        Me.txtcarinikkaryawan.Size = New System.Drawing.Size(252, 23)
        Me.txtcarinikkaryawan.TabIndex = 14
        '
        'LaporanKaryawanTableAdapter
        '
        Me.LaporanKaryawanTableAdapter.ClearBeforeFill = True
        '
        'f_Slip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(912, 504)
        Me.Controls.Add(Me.GBKaryawan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "f_Slip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Laporan Slip Gaji Karyawan ::.."
        CType(Me.LaporanKaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Laporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBKaryawan.ResumeLayout(False)
        Me.GBKaryawan.PerformLayout()
        CType(Me.dtvKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LaporanKaryawanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Laporan As TAFitri2016.Laporan
    Friend WithEvents LaporanKaryawanTableAdapter As TAFitri2016.LaporanTableAdapters.LaporanKaryawanTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTanggalakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNamaKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents txtNikKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GBKaryawan As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtvKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents txtcarinikkaryawan As System.Windows.Forms.TextBox
End Class
