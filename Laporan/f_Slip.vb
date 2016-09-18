
Imports Microsoft.Reporting.WinForms
Public Class f_Slip

    Private Sub f_Slip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Laporan.LaporanKaryawan' table. You can move, or remove it, as needed.

        bukaKoneksi()
        txttanggal.Value = Now
        txtTanggalakhir.Value = Now
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GBKaryawan.Visible = True
        tampilkaryawan()
    End Sub
    Sub tampilkaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT tk.nikKaryawan AS NIK_Karyawan, tk.namaKaryawan AS Nama_Karyawan, " +
                                       "td.namaDapartement AS Dapartement, tk.jabatan AS Jabatan FROM " +
                                       "tbKaryawan AS tk, tbDapartement AS td WHERE " +
                                       "tk.kodeDapartement = td.kodeDapartement", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbKaryawan")
        dtvKaryawan.DataSource = ds
        dtvKaryawan.DataMember = "tbKaryawan"
        dtvKaryawan.Columns(0).Width = 80
        dtvKaryawan.Columns(1).Width = 110
        dtvKaryawan.Columns(2).Width = 80
        dtvKaryawan.Columns(3).Width = 60
    End Sub
    Sub caritampilkaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT tk.nikKaryawan AS NIK_Karyawan, tk.namaKaryawan AS Nama_Karyawan, " +
                                       "td.namaDapartement AS Dapartement, tk.jabatan AS Jabatan FROM " +
                                       "tbKaryawan AS tk, tbDapartement AS td WHERE " +
                                       "tk.kodeDapartement = td.kodeDapartement AND tk.nikKaryawan LIKE '%" + txtcarinikkaryawan.Text + "%'", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbKaryawan")
        dtvKaryawan.DataSource = ds
        dtvKaryawan.DataMember = "tbKaryawan"
        dtvKaryawan.Columns(0).Width = 80
        dtvKaryawan.Columns(1).Width = 110
        dtvKaryawan.Columns(2).Width = 80
        dtvKaryawan.Columns(3).Width = 60
    End Sub

    Private Sub txtcarinikkaryawan_TextChanged(sender As Object, e As EventArgs) Handles txtcarinikkaryawan.TextChanged
        caritampilkaryawan()
    End Sub

    Private Sub dtvKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvKaryawan.CellClick
        Dim i As Integer
        i = Me.dtvKaryawan.CurrentRow.Index
        With dtvKaryawan.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtNikKaryawan.Text = .Cells(0).Value
                txtNamaKaryawan.Text = .Cells(1).Value
                GBKaryawan.Visible = False
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtNikKaryawan.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM View_1 WHERE nikKaryawan = '" + txtNikKaryawan.Text + "' and tanggalTransaksi " +
                                           "BETWEEN '" + txttanggal.Value.ToString("yyyy-MM-dd") + "' AND '" + txtTanggalakhir.Value.ToString("yyyy-MM-dd") + "'", con)
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                Dim Awal As New ReportParameter("Tanggal1", txttanggal.Value.ToString)
                Dim Akhir As New ReportParameter("Tanggal2", txtTanggalakhir.Value.ToString)
                Me.LaporanKaryawanTableAdapter.Fill(Me.Laporan.LaporanKaryawan, txtNikKaryawan.Text, txttanggal.Value.ToString(), txtTanggalakhir.Value.ToString())
                Me.ReportViewer1.LocalReport.SetParameters(Awal)
                Me.ReportViewer1.LocalReport.SetParameters(Akhir)
                Me.ReportViewer1.RefreshReport()
            Else
                MessageBox.Show("Data Tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class