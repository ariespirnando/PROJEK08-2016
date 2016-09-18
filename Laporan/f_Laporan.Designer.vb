<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_Laporan
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
        Me.LaporanSeluruhBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Laporan = New TAFitri2016.Laporan()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttanggal = New System.Windows.Forms.DateTimePicker()
        Me.txttanggalakhir = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LaporanSeluruhTableAdapter = New TAFitri2016.LaporanTableAdapters.LaporanSeluruhTableAdapter()
        CType(Me.LaporanSeluruhBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Laporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LaporanSeluruhBindingSource
        '
        Me.LaporanSeluruhBindingSource.DataMember = "LaporanSeluruh"
        Me.LaporanSeluruhBindingSource.DataSource = Me.Laporan
        '
        'Laporan
        '
        Me.Laporan.DataSetName = "Laporan"
        Me.Laporan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "laporanSeluruh"
        ReportDataSource1.Value = Me.LaporanSeluruhBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TAFitri2016.LaporanSeluruh.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 86)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual
        Me.ReportViewer1.ShowBackButton = False
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowParameterPrompts = False
        Me.ReportViewer1.ShowProgress = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.ShowZoomControl = False
        Me.ReportViewer1.Size = New System.Drawing.Size(1023, 428)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.WaitControlDisplayAfter = 100
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tanggal Awal Proses"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tanggal Akhir Proses"
        '
        'txttanggal
        '
        Me.txttanggal.CustomFormat = "dd-MM-yyyy"
        Me.txttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttanggal.Location = New System.Drawing.Point(164, 25)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(131, 23)
        Me.txttanggal.TabIndex = 19
        Me.txttanggal.Value = New Date(2016, 6, 1, 0, 0, 0, 0)
        '
        'txttanggalakhir
        '
        Me.txttanggalakhir.CustomFormat = "dd-MM-yyyy"
        Me.txttanggalakhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggalakhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttanggalakhir.Location = New System.Drawing.Point(477, 25)
        Me.txttanggalakhir.Name = "txttanggalakhir"
        Me.txttanggalakhir.Size = New System.Drawing.Size(131, 23)
        Me.txttanggalakhir.TabIndex = 20
        Me.txttanggalakhir.Value = New Date(2016, 6, 1, 0, 0, 0, 0)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(816, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 29)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "..:: Proses ::.."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txttanggal)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txttanggalakhir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1023, 68)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "..:: Input ::.."
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(934, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 29)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "..:: Keluar ::.."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LaporanSeluruhTableAdapter
        '
        Me.LaporanSeluruhTableAdapter.ClearBeforeFill = True
        '
        'f_Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1049, 526)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "f_Laporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Laporan Gaji Keseluruhan ::.."
        CType(Me.LaporanSeluruhBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Laporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttanggalakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LaporanSeluruhBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Laporan As TAFitri2016.Laporan
    Friend WithEvents LaporanSeluruhTableAdapter As TAFitri2016.LaporanTableAdapters.LaporanSeluruhTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
