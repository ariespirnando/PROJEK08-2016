Imports Microsoft.Reporting.WinForms
Public Class f_Laporan

    Private Sub f_Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Laporan.LaporanSeluruh' table. You can move, or remove it, as needed.
        bukaKoneksi()
        txttanggal.Value = Now
        txttanggalakhir.Value = Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT tbPenggajian.kodTransaksi, tbPenggajian.tanggalTransaksi, tbPenggajian.nikKaryawan, tbKaryawan.namaKaryawan, " +
                                       "tbDapartement.namaDapartement, tbKaryawan.jabatan, tbPengaturanGaji.GajiHari, tbPengaturanGaji.Lembur, tbPenggajian.hadir, " +
                                       "tbPenggajian.lembur AS Expr1, tbPenggajian.totalgaji FROM tbDapartement INNER JOIN tbKaryawan ON " +
                                       "tbDapartement.kodeDapartement = tbKaryawan.kodeDapartement INNER JOIN tbPenggajian ON tbKaryawan.nikKaryawan = " +
                                       "tbPenggajian.nikKaryawan INNER JOIN tbPengaturanGaji ON tbPenggajian.idpGaji = tbPengaturanGaji.idpGaji " +
                                       "WHERE tbPenggajian.tanggalTransaksi BETWEEN '" + txttanggal.Value.ToString("yyyy-MM-dd") + "' and '" + txttanggalakhir.Value.ToString("yyyy-MM-dd") + "'", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        If baca.Read() Then
            Dim Awal As New ReportParameter("Tanggal11", txttanggal.Value.ToString)
            Dim Akhir As New ReportParameter("Tanggal22", txttanggalakhir.Value.ToString)
            Me.LaporanSeluruhTableAdapter.Fill(Me.Laporan.LaporanSeluruh, txttanggal.Value.ToString(), txttanggalakhir.Value.ToString())
            Me.ReportViewer1.LocalReport.SetParameters(Awal)
            Me.ReportViewer1.LocalReport.SetParameters(Akhir)
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("Data Tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

End Class