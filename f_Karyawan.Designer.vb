<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class f_Karyawan
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxjabatan = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdapartement = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbxstatus = New System.Windows.Forms.ComboBox()
        Me.cmbxjeniskelamin = New System.Windows.Forms.ComboBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtnohp = New System.Windows.Forms.TextBox()
        Me.txtiddapartement = New System.Windows.Forms.TextBox()
        Me.txtnamaKaryawan = New System.Windows.Forms.TextBox()
        Me.txtNikKaryawan = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.dtvKaryawan = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcarinamakarywan = New System.Windows.Forms.TextBox()
        Me.GBdapartement = New System.Windows.Forms.GroupBox()
        Me.dtvDapartement = New System.Windows.Forms.DataGridView()
        Me.carinamadapartement = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dtvKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBdapartement.SuspendLayout()
        CType(Me.dtvDapartement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbxjabatan)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtdapartement)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbxstatus)
        Me.GroupBox1.Controls.Add(Me.cmbxjeniskelamin)
        Me.GroupBox1.Controls.Add(Me.txtalamat)
        Me.GroupBox1.Controls.Add(Me.txtnohp)
        Me.GroupBox1.Controls.Add(Me.txtiddapartement)
        Me.GroupBox1.Controls.Add(Me.txtnamaKaryawan)
        Me.GroupBox1.Controls.Add(Me.txtNikKaryawan)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 413)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "..:: Input ::.."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Jabatan"
        '
        'cbxjabatan
        '
        Me.cbxjabatan.Enabled = False
        Me.cbxjabatan.FormattingEnabled = True
        Me.cbxjabatan.Items.AddRange(New Object() {"Manager", "Supervison", "Umum", "Marketing", "Staff", "Outsourching"})
        Me.cbxjabatan.Location = New System.Drawing.Point(165, 153)
        Me.cbxjabatan.Name = "cbxjabatan"
        Me.cbxjabatan.Size = New System.Drawing.Size(181, 21)
        Me.cbxjabatan.TabIndex = 17
        Me.cbxjabatan.Text = "..:: Jabatan ::.."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Id Dapartement"
        '
        'txtdapartement
        '
        Me.txtdapartement.Enabled = False
        Me.txtdapartement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdapartement.Location = New System.Drawing.Point(166, 121)
        Me.txtdapartement.Name = "txtdapartement"
        Me.txtdapartement.Size = New System.Drawing.Size(181, 23)
        Me.txtdapartement.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(354, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "......"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbxstatus
        '
        Me.cbxstatus.Enabled = False
        Me.cbxstatus.FormattingEnabled = True
        Me.cbxstatus.Items.AddRange(New Object() {"Menikah", "Belum Menikah"})
        Me.cbxstatus.Location = New System.Drawing.Point(166, 211)
        Me.cbxstatus.Name = "cbxstatus"
        Me.cbxstatus.Size = New System.Drawing.Size(181, 21)
        Me.cbxstatus.TabIndex = 13
        Me.cbxstatus.Text = "..:: Status ::.."
        '
        'cmbxjeniskelamin
        '
        Me.cmbxjeniskelamin.Enabled = False
        Me.cmbxjeniskelamin.FormattingEnabled = True
        Me.cmbxjeniskelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cmbxjeniskelamin.Location = New System.Drawing.Point(165, 184)
        Me.cmbxjeniskelamin.Name = "cmbxjeniskelamin"
        Me.cmbxjeniskelamin.Size = New System.Drawing.Size(181, 21)
        Me.cmbxjeniskelamin.TabIndex = 12
        Me.cmbxjeniskelamin.Text = "..:: Jenis Kelamin ::.."
        '
        'txtalamat
        '
        Me.txtalamat.Enabled = False
        Me.txtalamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(165, 239)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(235, 108)
        Me.txtalamat.TabIndex = 11
        '
        'txtnohp
        '
        Me.txtnohp.Enabled = False
        Me.txtnohp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnohp.Location = New System.Drawing.Point(165, 353)
        Me.txtnohp.Name = "txtnohp"
        Me.txtnohp.Size = New System.Drawing.Size(235, 23)
        Me.txtnohp.TabIndex = 10
        '
        'txtiddapartement
        '
        Me.txtiddapartement.Enabled = False
        Me.txtiddapartement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiddapartement.Location = New System.Drawing.Point(166, 91)
        Me.txtiddapartement.Name = "txtiddapartement"
        Me.txtiddapartement.Size = New System.Drawing.Size(181, 23)
        Me.txtiddapartement.TabIndex = 9
        '
        'txtnamaKaryawan
        '
        Me.txtnamaKaryawan.Enabled = False
        Me.txtnamaKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnamaKaryawan.Location = New System.Drawing.Point(166, 63)
        Me.txtnamaKaryawan.Name = "txtnamaKaryawan"
        Me.txtnamaKaryawan.Size = New System.Drawing.Size(235, 23)
        Me.txtnamaKaryawan.TabIndex = 8
        '
        'txtNikKaryawan
        '
        Me.txtNikKaryawan.Enabled = False
        Me.txtNikKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNikKaryawan.Location = New System.Drawing.Point(166, 35)
        Me.txtNikKaryawan.Name = "txtNikKaryawan"
        Me.txtNikKaryawan.Size = New System.Drawing.Size(235, 23)
        Me.txtNikKaryawan.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 356)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No Handphone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dapartement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK Karyawan"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.btnHapus)
        Me.Panel2.Controls.Add(Me.btnubah)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Location = New System.Drawing.Point(178, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(257, 99)
        Me.Panel2.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = Global.TAFitri2016.My.Resources.Resources.logout_icon
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(143, 57)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 27)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Keluar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Enabled = False
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Image = Global.TAFitri2016.My.Resources.Resources.Actions_edit_delete_icon
        Me.btnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHapus.Location = New System.Drawing.Point(22, 57)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(92, 27)
        Me.btnHapus.TabIndex = 3
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnubah
        '
        Me.btnubah.Enabled = False
        Me.btnubah.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.Image = Global.TAFitri2016.My.Resources.Resources.Actions_document_edit_icon
        Me.btnubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnubah.Location = New System.Drawing.Point(143, 15)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(91, 27)
        Me.btnubah.TabIndex = 2
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.TAFitri2016.My.Resources.Resources.Button_Add_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(22, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 27)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Baru"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Location = New System.Drawing.Point(12, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(148, 99)
        Me.Panel1.TabIndex = 3
        '
        'btnSimpan
        '
        Me.btnSimpan.Enabled = False
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Image = Global.TAFitri2016.My.Resources.Resources.Floppy_Small_icon
        Me.btnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpan.Location = New System.Drawing.Point(19, 15)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(106, 69)
        Me.btnSimpan.TabIndex = 0
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'dtvKaryawan
        '
        Me.dtvKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvKaryawan.Enabled = False
        Me.dtvKaryawan.Location = New System.Drawing.Point(442, 19)
        Me.dtvKaryawan.Name = "dtvKaryawan"
        Me.dtvKaryawan.Size = New System.Drawing.Size(484, 425)
        Me.dtvKaryawan.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(441, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cari Nama Karyawan"
        '
        'txtcarinamakarywan
        '
        Me.txtcarinamakarywan.Enabled = False
        Me.txtcarinamakarywan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarinamakarywan.Location = New System.Drawing.Point(593, 464)
        Me.txtcarinamakarywan.Name = "txtcarinamakarywan"
        Me.txtcarinamakarywan.Size = New System.Drawing.Size(333, 23)
        Me.txtcarinamakarywan.TabIndex = 15
        '
        'GBdapartement
        '
        Me.GBdapartement.Controls.Add(Me.dtvDapartement)
        Me.GBdapartement.Controls.Add(Me.carinamadapartement)
        Me.GBdapartement.Controls.Add(Me.Label9)
        Me.GBdapartement.Location = New System.Drawing.Point(418, 96)
        Me.GBdapartement.Name = "GBdapartement"
        Me.GBdapartement.Size = New System.Drawing.Size(366, 227)
        Me.GBdapartement.TabIndex = 16
        Me.GBdapartement.TabStop = False
        Me.GBdapartement.Text = "..:: Dapartement ::.."
        Me.GBdapartement.Visible = False
        '
        'dtvDapartement
        '
        Me.dtvDapartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvDapartement.Location = New System.Drawing.Point(9, 63)
        Me.dtvDapartement.Name = "dtvDapartement"
        Me.dtvDapartement.Size = New System.Drawing.Size(351, 150)
        Me.dtvDapartement.TabIndex = 18
        '
        'carinamadapartement
        '
        Me.carinamadapartement.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carinamadapartement.Location = New System.Drawing.Point(102, 25)
        Me.carinamadapartement.Name = "carinamadapartement"
        Me.carinamadapartement.Size = New System.Drawing.Size(258, 23)
        Me.carinamadapartement.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Dapartement"
        '
        'f_Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(934, 542)
        Me.Controls.Add(Me.GBdapartement)
        Me.Controls.Add(Me.txtcarinamakarywan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtvKaryawan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "f_Karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "..:: Karyawan ::.."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtvKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBdapartement.ResumeLayout(False)
        Me.GBdapartement.PerformLayout()
        CType(Me.dtvDapartement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtnohp As System.Windows.Forms.TextBox
    Friend WithEvents txtiddapartement As System.Windows.Forms.TextBox
    Friend WithEvents txtnamaKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents txtNikKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents cbxstatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxjeniskelamin As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents dtvKaryawan As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcarinamakarywan As System.Windows.Forms.TextBox
    Friend WithEvents GBdapartement As System.Windows.Forms.GroupBox
    Friend WithEvents carinamadapartement As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtvDapartement As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtdapartement As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxjabatan As System.Windows.Forms.ComboBox
End Class
