Public Class f_pGaji
    Dim UMR As Double
    Dim LEMBUR As Double
    Dim HARIAN As Double
    Dim MAKAN As Double
    Sub simpan()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("UPDATE tbPengaturanGaji SET UMR=@1, GajiHari=@2, Umakan=@3, Lembur=@4 WHERE idpGaji=1 ", con)
        cmd.Parameters.Add("@1", SqlDbType.Float).Value = txtUmr.Text
        cmd.Parameters.Add("@2", SqlDbType.Float).Value = txtGaji.Text
        cmd.Parameters.Add("@3", SqlDbType.Float).Value = txtUangmkn.Text
        cmd.Parameters.Add("@4", SqlDbType.Float).Value = txtlembur.Text
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil Simpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampilgaji()
        bersih()
    End Sub
    Sub tampilgaji()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * FROM tbPengaturanGaji", con)
        cmd.ExecuteNonQuery()
        baca = cmd.ExecuteReader()
        baca.Read()
        Dim a As Double = Val(baca.Item("UMR").ToString)
        Dim b As Double = Val(baca.Item("Lembur").ToString)
        Dim c As Double = Val(baca.Item("GajiHari").ToString)
        Dim d As Double = Val(baca.Item("Umakan").ToString)
        txtfUmr.Text = Format(a, "#,###")
        txtflembur.Text = Format(b, "#,###")
        txtfgaji.Text = Format(c, "#,###")
        tktfmakan.Text = Format(d, "#,###")
    End Sub
    Private Sub f_pUMR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        tampilgaji()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        panelUbah.Visible = True
        bersih()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        panelUbah.Visible = False
    End Sub
    Sub bersih()
        txtUmr.Text = "0"
        txtUangmkn.Text = "0"
        txtlembur.Text = "0"
        txtGaji.Text = "0"
    End Sub
    Private Sub txtUmr_TextChanged(sender As Object, e As EventArgs) Handles txtUmr.TextChanged
        If txtfUmr.Text = "" Or txtUangmkn.Text = "" Then
            txtGaji.Text = "0"
            txtlembur.Text = "0"
        Else
            UMR = Val(txtUmr.Text)
            MAKAN = Val(txtUangmkn.Text)
            HARIAN = (UMR - MAKAN) / 25
            LEMBUR = UMR / 173
            txtGaji.Text = Convert.ToString(Math.Round(HARIAN, 2))
            txtlembur.Text = Convert.ToString(Math.Round(LEMBUR, 2))
        End If
    End Sub

    Private Sub txtUangmkn_TextChanged(sender As Object, e As EventArgs) Handles txtUangmkn.TextChanged
        If txtfUmr.Text = "0" Or txtUangmkn.Text = "0" Then
            txtGaji.Text = "0"
            txtlembur.Text = "0"
        Else
            UMR = Val(txtUmr.Text)
            MAKAN = Val(txtUangmkn.Text)
            HARIAN = (UMR - MAKAN) / 25
            LEMBUR = UMR / 173
            txtGaji.Text = Convert.ToString(Math.Round(HARIAN, 2))
            txtlembur.Text = Convert.ToString(Math.Round(LEMBUR, 2))
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        simpan()
        panelUbah.Visible = False
    End Sub
End Class