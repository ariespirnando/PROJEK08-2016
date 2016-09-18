Public Class f_Penggajian
    '1. Membuat variable untuk melakukan perhitungan gaji
    Dim harian As Double
    Dim jumlahlembur As Double
    Dim hadir As Double
    Dim lembur As Double
    Dim Total As Double
    Dim TotalGaji As Double

    '2. Membersihkan semua textbox pada sistem
    Sub bersih()
        txtcarinikkaryawan.Clear()
        txtdapartement.Clear()
        txtgaji.Text = "0"
        txthadir.Text = "0"
        txtjabatan.Clear()
        txtjumlembur.Text = "0"
        txtlembur.Text = "0"
        txtnamakaryawan.Clear()
        txtcarigaji.Clear()
        txttotalgaji.Text = "0"
        txttanggal.Value = Now
        txtnikkaryawan.Clear()
    End Sub
    '3. Menampilkan daftar karyawan
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

    '4. Menampilkan daftar pencarian karyawan berdasarkan NIK Karyawan
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

    '5. Menampilkan nilai gaji yang digunakan untuk melakukan perhitungan gaji
    Sub tampilgaji()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbPengaturanGaji", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        baca.Read()
        harian = Val(baca.Item("GajiHari").ToString)
        lembur = Val(baca.Item("Lembur").ToString)
        txtlembur.Text = Format(lembur, "#,###")
        txtgaji.Text = Format(harian, "#,###")
    End Sub
    Sub nomorOtomatis()
        Dim StrSementara As String = ""
        Dim Strisi As String = ""
        Dim tanggal1 As String = txttanggal.Value.ToString("MM")
        Dim tanggal2 As String = txttanggal.Value.ToString("yy")
        Dim n As Integer = vbNull
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbPenggajian order by kodTransaksi desc", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        If baca.Read() Then
            StrSementara = Mid(baca.Item("kodTransaksi"), 13, 5)
            Strisi = Val(StrSementara) + 1
            n = Val(Strisi)
            If n < 10 Then
                txtKodeTransaksi.Text = "TRG/B" + tanggal1 + "/T" + tanggal2 + "/0000" + Strisi
            ElseIf n < 100 Then
                txtKodeTransaksi.Text = "TRG/B" + tanggal1 + "/T" + tanggal2 + "/000" + Strisi
            ElseIf n < 1000 Then
                txtKodeTransaksi.Text = "TRG/B" + tanggal1 + "/T" + tanggal2 + "/00" + Strisi
            ElseIf n < 10000 Then
                txtKodeTransaksi.Text = "TRG/B" + tanggal1 + "/T" + tanggal2 + "/0" + Strisi
            Else
                txtKodeTransaksi.Text = "TRG/B" + tanggal1 + "/T" + tanggal2 + "/" + Strisi
            End If
        Else
            txtKodeTransaksi.Text = "TRG/B" + tanggal1 + "/T" + tanggal2 + "/00001"
        End If
    End Sub
    Sub tampilgajiKaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT tbPenggajian.kodTransaksi AS Kode_Transaksi, tbPenggajian.nikKaryawan AS NIK_Karyawan, " +
                                       "tbPenggajian.tanggalTransaksi AS Tanggal, tbPenggajian.totalgaji AS Total, tbPenggajian.hadir AS Total_Hadir, tbPenggajian.lembur AS Total_Lembur, " +
                                       "tbPengaturanGaji.GajiHari AS [Gaji/Hari], tbPengaturanGaji.Lembur AS [Lembur/Jam] " +
                                       "FROM tbDapartement INNER JOIN tbKaryawan ON dbo.tbDapartement.kodeDapartement = dbo.tbKaryawan.kodeDapartement " +
                                       "INNER JOIN tbPenggajian ON tbKaryawan.nikKaryawan = tbPenggajian.nikKaryawan INNER JOIN tbPengaturanGaji ON " +
                                       "tbPenggajian.idpGaji = tbPengaturanGaji.idpGaji ORDER BY Kode_Transaksi DESC", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbKaryawan")
        dtvPengajian.DataSource = ds
        dtvPengajian.DataMember = "tbKaryawan"
        dtvPengajian.Columns(0).Width = 130
    End Sub
    Sub caritampilgajiKaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT tbPenggajian.kodTransaksi AS Kode_Transaksi, tbPenggajian.nikKaryawan AS NIK_Karyawan, " +
                                       "tbPenggajian.tanggalTransaksi AS Tanggal, tbPenggajian.totalgaji AS Total, tbPenggajian.hadir AS Total_Hadir, tbPenggajian.lembur AS Total_Lembur, " +
                                       "tbPengaturanGaji.GajiHari AS [Gaji/Hari], tbPengaturanGaji.Lembur AS [Lembur/Jam] " +
                                       "FROM tbDapartement INNER JOIN tbKaryawan ON dbo.tbDapartement.kodeDapartement = dbo.tbKaryawan.kodeDapartement " +
                                       "INNER JOIN tbPenggajian ON tbKaryawan.nikKaryawan = tbPenggajian.nikKaryawan INNER JOIN tbPengaturanGaji ON " +
                                       "tbPenggajian.idpGaji = tbPengaturanGaji.idpGaji WHERE tbPenggajian.nikKaryawan LIKE '%" & txtcarigaji.Text & "%' ORDER BY Kode_Transaksi DESC", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbKaryawan")
        dtvPengajian.DataSource = ds
        dtvPengajian.DataMember = "tbKaryawan"
        dtvPengajian.Columns(0).Width = 130
    End Sub

    Sub simpangajikaryawan()
        Dim tanggal As String = txttanggal.Value.ToString("yyyy-MM-dd")
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("INSERT INTO tbPenggajian VALUES(@1,@2,@3,1,@4,@5,@6)", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtKodeTransaksi.Text
        cmd.Parameters.Add("@2", SqlDbType.Date).Value = tanggal
        cmd.Parameters.Add("@3", SqlDbType.Char).Value = Convert.ToString(TotalGaji)
        cmd.Parameters.Add("@4", SqlDbType.Char).Value = txtnikkaryawan.Text
        cmd.Parameters.Add("@5", SqlDbType.Char).Value = txthadir.Text
        cmd.Parameters.Add("@6", SqlDbType.Char).Value = txtjumlembur.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampilgajiKaryawan()
        bersih()
        nomorOtomatis()
    End Sub
    Sub ubahgajikaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("UPDATE tbPenggajian SET totalgaji = @3, nikKaryawan = @4, hadir =@5, lembur = @6 WHERE kodTransaksi =@1", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtKodeTransaksi.Text
        cmd.Parameters.Add("@3", SqlDbType.Char).Value = Convert.ToString(TotalGaji)
        cmd.Parameters.Add("@4", SqlDbType.Char).Value = txtnikkaryawan.Text
        cmd.Parameters.Add("@5", SqlDbType.Char).Value = txthadir.Text
        cmd.Parameters.Add("@6", SqlDbType.Char).Value = txtjumlembur.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampilgajiKaryawan()
        bersih()
        nomorOtomatis()
    End Sub
    Sub hapusgajikaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("DELETE FROM tbPenggajian WHERE kodTransaksi =@1", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtKodeTransaksi.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampilgajiKaryawan()
        bersih()
        nomorOtomatis()
    End Sub

    
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles Btnsimpan.Click
        Dim date1 As Date = Convert.ToDateTime(txttanggal.Value)
        Dim date2 As Date = Now
        Dim tgl As Integer = vbNull
        If txtnikkaryawan.Text = "" Or txtjumlembur.Text = "" Or txtgaji.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbPenggajian WHERE kodTransaksi ='" & txtKodeTransaksi.Text & "'", con)
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            If (baca.Read()) Then
                MessageBox.Show("Karyawan sudah mendapatkan gaji pada Minggu ini", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                nomorOtomatis()
            Else
                con.Close()
                bukaKoneksi()
                cmd = New SqlClient.SqlCommand("SELECT * FROM tbPenggajian WHERE nikKaryawan ='" & txtnikkaryawan.Text & "' order by kodTransaksi desc", con)
                cmd.ExecuteNonQuery()
                baca = cmd.ExecuteReader()
                If (baca.Read()) Then
                    date2 = Convert.ToDateTime(baca.Item("tanggalTransaksi"))
                    tgl = Val(DateDiff("w", date2, date1))
                    If tgl > 0 Then
                        simpangajikaryawan()
                    Else
                        MessageBox.Show("Karyawan sudah mendapatkan gaji pada Minggu ini", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    simpangajikaryawan()
                End If
            End If
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles txtcarigaji.TextChanged
        caritampilgajiKaryawan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnKaryawan.Click
        GBKaryawan.Visible = True
        tampilkaryawan()
    End Sub

    Private Sub f_Penggajian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        tampilkaryawan()
        bersih()
        nomorOtomatis()
        tampilgajiKaryawan()
    End Sub

    Private Sub dtvKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvKaryawan.CellClick
        Dim i As Integer
        i = Me.dtvKaryawan.CurrentRow.Index
        With dtvKaryawan.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtnikkaryawan.Text = .Cells(0).Value
                txtnamakaryawan.Text = .Cells(1).Value
                txtdapartement.Text = .Cells(2).Value
                txtjabatan.Text = .Cells(3).Value
                GBKaryawan.Visible = False
                tampilgaji()
            End If
        End With
    End Sub

    Private Sub txthadir_TextChanged(sender As Object, e As EventArgs) Handles txthadir.TextChanged
        If Not IsNumeric(txthadir.Text) Then
            MessageBox.Show("Inputan bukan Numerik", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txthadir.Focus()
            txthadir.Text = "0"
            Exit Sub
        End If
        If txthadir.Text = "0" Or txtjumlembur.Text = "" Then
            txttotalgaji.Text = "0"
        Else
            jumlahlembur = Val(txtjumlembur.Text)
            hadir = Val(txthadir.Text)
            Total = (lembur * jumlahlembur) + (hadir * harian)
            TotalGaji = Math.Round(Total, 2)
            txttotalgaji.Text = Format(TotalGaji, "#,###")
        End If
    End Sub

    Private Sub txtjumlembur_TextChanged(sender As Object, e As EventArgs) Handles txtjumlembur.TextChanged
        If Not IsNumeric(txtjumlembur.Text) Then
            MessageBox.Show("Inputan bukan Numerik", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtjumlembur.Focus()
            txtjumlembur.Text = "0"
            Exit Sub
        End If
        If txthadir.Text = "0" Or txtjumlembur.Text = "" Then
            txttotalgaji.Text = "0"
        Else
            jumlahlembur = Val(txtjumlembur.Text)
            hadir = Val(txthadir.Text)
            Total = (lembur * jumlahlembur) + (hadir * harian)
            TotalGaji = Math.Round(Total, 2)
            txttotalgaji.Text = Format(TotalGaji, "#,###")
        End If
    End Sub

    Private Sub txtcarinikkaryawan_TextChanged(sender As Object, e As EventArgs) Handles txtcarinikkaryawan.TextChanged
        caritampilkaryawan()
    End Sub

    Private Sub dtvPengajian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvPengajian.CellClick
        Dim tot As Double
        Dim gj As Double
        Dim lm As Double
        Dim i As Integer
        i = Me.dtvPengajian.CurrentRow.Index
        With dtvPengajian.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtKodeTransaksi.Text = .Cells(0).Value
                txtnikkaryawan.Text = .Cells(1).Value
                txttanggal.Value = Convert.ToDateTime(.Cells(2).Value)
                tot = Val(.Cells(3).Value)
                txthadir.Text = .Cells(4).Value
                txtjumlembur.Text = .Cells(5).Value
                gj = Val(.Cells(6).Value)
                lm = Val(.Cells(7).Value)

                txttotalgaji.Text = Format(tot, "#,###")
                txtlembur.Text = Format(lm, "#,###")
                txtgaji.Text = Format(gj, "#,###")

                harian = gj
                lembur = lm

                con.Close()
                bukaKoneksi()
                cmd = New SqlClient.SqlCommand("SELECT tk.namaKaryawan, td.namaDapartement, tk.jabatan " +
                                               "FROM tbKaryawan AS tk, tbDapartement AS td WHERE " +
                                               "td.kodeDapartement = td.kodeDapartement AND tk.nikKaryawan = '" + txtnikkaryawan.Text + "'", con)
                cmd.ExecuteNonQuery()
                baca = cmd.ExecuteReader()
                baca.Read()
                txtnamakaryawan.Text = baca.Item("namaKaryawan").ToString
                txtdapartement.Text = baca.Item("namaDapartement").ToString
                txtjabatan.Text = baca.Item("jabatan").ToString
            End If
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtnikkaryawan.Text = "" Or txtjumlembur.Text = "" Or txtgaji.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ubahgajikaryawan()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtnikkaryawan.Text = "" Or txtjumlembur.Text = "" Or txtgaji.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            hapusgajikaryawan()
        End If
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        BtnKaryawan.Enabled = True
        txthadir.Enabled = True
        txtjumlembur.Enabled = True
        dtvPengajian.Enabled = True
        txtcarigaji.Enabled = True
        Btnsimpan.Enabled = True
        btnHapus.Enabled = True
        btnUbah.Enabled = True
        txttanggal.Enabled = True
        bersih()
        nomorOtomatis()
    End Sub
End Class