Public Class f_Dapartemen

    Private Sub f_Dapartemen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        tampilDapartement()
        nomorOtomatis()
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
    Sub bersih()
        txtiddapartement.Clear()
        txtnamadapartement.Clear()
        txtiddapartement.Focus()
    End Sub
    Sub nomorOtomatis()
        Dim StrSementara As String = ""
        Dim Strisi As String = ""
        Dim n As Integer = vbNull
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbDapartement order by kodeDapartement desc", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        If baca.Read() Then
            StrSementara = Mid(baca.Item("kodeDapartement"), 4, 2)
            Strisi = Val(StrSementara) + 1
            n = Val(Strisi)
            If n < 10 Then
                txtiddapartement.Text = "DEP0" + Strisi
            Else
                txtiddapartement.Text = "DEP" + Strisi
            End If
        Else
            txtiddapartement.Text = "DEP01"
        End If
    End Sub
    Sub simpandapartement()
        Try
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("INSERT INTO tbDapartement VALUES('" & txtiddapartement.Text & "','" & txtnamadapartement.Text & "')", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilDapartement()
            bersih()
            nomorOtomatis()
        Catch
            MessageBox.Show("Proses Gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub editdapartement()
        Try
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("UPDATE tbDapartement SET namaDapartement = '" & txtnamadapartement.Text & "' WHERE kodeDapartement ='" & txtiddapartement.Text & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilDapartement()
            bersih()
            nomorOtomatis()
        Catch
            MessageBox.Show("Proses Gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Sub Hapusdapartement()
        Try
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("DELETE FROM tbDapartement WHERE kodeDapartement ='" & txtiddapartement.Text & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tampilDapartement()
            bersih()
            nomorOtomatis()
        Catch
            MessageBox.Show("Proses Gagal", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles carinamadapartement.TextChanged
        CariDapartement()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtiddapartement.Text = "" Or txtnamadapartement.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            simpandapartement()
        End If
    End Sub

    Private Sub dtvDapartement_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvDapartement.CellClick
        Dim i As Integer
        i = Me.dtvDapartement.CurrentRow.Index
        With dtvDapartement.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtiddapartement.Text = .Cells(0).Value
                txtnamadapartement.Text = .Cells(1).Value
            End If
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtiddapartement.Text = "" Or txtnamadapartement.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            editdapartement()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtiddapartement.Text = "" Or txtnamadapartement.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If MessageBox.Show("Yakin akan dihapus..?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Hapusdapartement()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtnamadapartement.Enabled = True
        dtvDapartement.Enabled = True
        btnsimpan.Enabled = True
        btnHapus.Enabled = True
        btnUbah.Enabled = True
        carinamadapartement.Enabled = True
    End Sub
End Class