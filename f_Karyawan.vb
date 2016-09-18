Public Class f_Karyawan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tampilDapartement()
        GBdapartement.Visible = True
    End Sub
    Sub bersih()
        txtalamat.Clear()
        txtcarinamakarywan.Clear()
        txtdapartement.Clear()
        txtiddapartement.Clear()
        txtiddapartement.Clear()
        txtnamaKaryawan.Clear()
        txtNikKaryawan.Clear()
        txtnohp.Clear()
        cbxstatus.Text = "..:: Status ::.."
        cmbxjeniskelamin.Text = "..:: Jenis Kelamain ::.."
        cbxjabatan.Text = "..:: Jabatan ::.."
        txtNikKaryawan.Focus()

    End Sub
    Sub simpankaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("INSERT INTO tbKaryawan VALUES(@1,@2,@3,@4,@5,@6,@7,@8)", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtNikKaryawan.Text
        cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtnamaKaryawan.Text
        cmd.Parameters.Add("@3", SqlDbType.Char).Value = txtiddapartement.Text
        cmd.Parameters.Add("@4", SqlDbType.Char).Value = cmbxjeniskelamin.Text
        cmd.Parameters.Add("@5", SqlDbType.Char).Value = cbxstatus.Text
        cmd.Parameters.Add("@6", SqlDbType.Text).Value = txtalamat.Text
        cmd.Parameters.Add("@7", SqlDbType.Char).Value = txtnohp.Text
        cmd.Parameters.Add("@8", SqlDbType.VarChar).Value = cbxjabatan.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampilkaryawan()
        bersih()
    End Sub
    Sub editkaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("UPDATE tbKaryawan SET jabatan =@8,namaKaryawan =@2, kodeDapartement = @3, jenisKelamin = @4, status = @5, alamat = @6, nohandphone = @7 WHERE nikKaryawan =@1", con)
        cmd.Parameters.Add("@1", SqlDbType.Char).Value = txtNikKaryawan.Text
        cmd.Parameters.Add("@8", SqlDbType.VarChar).Value = cbxjabatan.Text
        cmd.Parameters.Add("@2", SqlDbType.VarChar).Value = txtnamaKaryawan.Text
        cmd.Parameters.Add("@3", SqlDbType.Char).Value = txtiddapartement.Text
        cmd.Parameters.Add("@4", SqlDbType.Char).Value = cmbxjeniskelamin.Text
        cmd.Parameters.Add("@5", SqlDbType.Char).Value = cbxstatus.Text
        cmd.Parameters.Add("@6", SqlDbType.Text).Value = txtalamat.Text
        cmd.Parameters.Add("@7", SqlDbType.Char).Value = txtnohp.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampilkaryawan()
        bersih()
    End Sub
    Sub hapuskaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("DELETE FROM tbKaryawan WHERE nikKaryawan ='" & txtNikKaryawan.Text & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampilkaryawan()
        bersih()
    End Sub
    Sub tampilDapartement()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT kodeDapartement AS Kode_Dapartement, namaDapartement AS Nama_Dapartement FROM tbDapartement", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbDapartement")
        dtvDapartement.DataSource = ds
        dtvDapartement.DataMember = "tbDapartement"
        dtvDapartement.Columns(0).Width = 140
        dtvDapartement.Columns(1).Width = 260
    End Sub
    Sub CariDapartement()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT kodeDapartement AS Kode_Dapartement, namaDapartement AS Nama_Dapartement FROM tbDapartement WHERE namaDapartement Like '%" & carinamadapartement.Text & "%'", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbDapartement")
        dtvDapartement.DataSource = ds
        dtvDapartement.DataMember = "tbDapartement"
        dtvDapartement.Columns(0).Width = 140
        dtvDapartement.Columns(1).Width = 260
    End Sub
    Sub tampilkaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT  nikKaryawan AS NIK_Karyawan, namaKaryawan AS Nama_Karyawan, " +
                                       "kodeDapartement AS Kode_Dapartement, jabatan AS Jabatan, jenisKelamin AS Kelamin, status, alamat, " +
                                       "nohandphone AS No_HP FROM  tbKaryawan", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbKaryawan")
        dtvKaryawan.DataSource = ds
        dtvKaryawan.DataMember = "tbKaryawan"
        dtvKaryawan.Columns(0).Width = 80
        dtvKaryawan.Columns(1).Width = 160
        dtvKaryawan.Columns(2).Width = 60
        dtvKaryawan.Columns(3).Width = 60
        dtvKaryawan.Columns(4).Width = 80
        dtvKaryawan.Columns(5).Width = 100
        dtvKaryawan.Columns(6).Width = 200
        dtvKaryawan.Columns(7).Width = 100
    End Sub
    Sub caritampilkaryawan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT  nikKaryawan AS NIK_Karyawan, namaKaryawan AS Nama_Karyawan, " +
                                       "kodeDapartement AS Kode_Dapartement, jabatan AS Jabatan, jenisKelamin AS Kelamin, status, alamat, " +
                                       "nohandphone AS No_HP FROM  tbKaryawan WHERE namaKaryawan LIKE '%" & txtcarinamakarywan.Text & "%'", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbKaryawan")
        dtvKaryawan.DataSource = ds
        dtvKaryawan.DataMember = "tbKaryawan"
        dtvKaryawan.Columns(0).Width = 80
        dtvKaryawan.Columns(1).Width = 160
        dtvKaryawan.Columns(2).Width = 60
        dtvKaryawan.Columns(3).Width = 60
        dtvKaryawan.Columns(4).Width = 80
        dtvKaryawan.Columns(5).Width = 100
        dtvKaryawan.Columns(6).Width = 200
        dtvKaryawan.Columns(7).Width = 100
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub f_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        tampilkaryawan()
        tampilDapartement()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles carinamadapartement.TextChanged

    End Sub

    Private Sub dtvDapartement_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvDapartement.CellClick
        Dim i As Integer
        i = Me.dtvDapartement.CurrentRow.Index
        With dtvDapartement.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtiddapartement.Text = .Cells(0).Value
                txtdapartement.Text = .Cells(1).Value
                GBdapartement.Visible = False
            End If
        End With
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtcarinamakarywan.TextChanged
        caritampilkaryawan()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNikKaryawan.Text = "" Or txtnamaKaryawan.Text = "" Or txtiddapartement.Text = "" Or cbxstatus.Text = "..:: Status ::.." Or
        cmbxjeniskelamin.Text = "..:: Jenis Kelamain ::.." Or txtalamat.Text = "" Or txtnohp.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbKaryawan WHERE nikKaryawan ='" & txtNikKaryawan.Text & "'", con)
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                MessageBox.Show("Nik Sudah Ada", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNikKaryawan.Focus()
            Else
                simpankaryawan()
            End If
        End If
    End Sub

    Private Sub dtvKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvKaryawan.CellClick
        Dim i As Integer
        i = Me.dtvKaryawan.CurrentRow.Index
        With dtvKaryawan.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtNikKaryawan.Text = .Cells(0).Value
                txtnamaKaryawan.Text = .Cells(1).Value
                txtiddapartement.Text = .Cells(2).Value
                cbxjabatan.Text = .Cells(3).Value
                cmbxjeniskelamin.Text = .Cells(4).Value
                cbxstatus.Text = .Cells(5).Value
                txtalamat.Text = .Cells(6).Value
                txtnohp.Text = .Cells(7).Value

                con.Close()
                bukaKoneksi()
                cmd = New SqlClient.SqlCommand("SELECT * FROM tbDapartement WHERE kodeDapartement ='" & txtiddapartement.Text & "'", con)
                cmd.ExecuteNonQuery()
                baca = cmd.ExecuteReader()
                baca.Read()
                txtdapartement.Text = baca.Item("namaDapartement").ToString
            End If
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If txtNikKaryawan.Text = "" Or txtnamaKaryawan.Text = "" Or txtiddapartement.Text = "" Or cbxstatus.Text = "..:: Status ::.." Or
        cmbxjeniskelamin.Text = "..:: Jenis Kelamain ::.." Or txtalamat.Text = "" Or txtnohp.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            editkaryawan()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtNikKaryawan.Text = "" Or txtnamaKaryawan.Text = "" Or txtiddapartement.Text = "" Or cbxstatus.Text = "..:: Status ::.." Or
        cmbxjeniskelamin.Text = "..:: Jenis Kelamain ::.." Or txtalamat.Text = "" Or txtnohp.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                hapuskaryawan()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtalamat.Enabled = True
        txtcarinamakarywan.Enabled = True
        txtdapartement.Enabled = True
        txtiddapartement.Enabled = True
        txtiddapartement.Enabled = True
        txtnamaKaryawan.Enabled = True
        txtNikKaryawan.Enabled = True
        txtnohp.Enabled = True
        cbxstatus.Enabled = True
        cmbxjeniskelamin.Enabled = True
        cbxjabatan.Enabled = True
        dtvKaryawan.Enabled = True
        Button1.Enabled = True
        btnSimpan.Enabled = True
        btnHapus.Enabled = True
        btnubah.Enabled = True
        bersih()
    End Sub
End Class