Public Class f_loginUser
    Sub bersih()
        txtPassword.Clear()
        txtUser.Clear()
        txtUser.Focus()
    End Sub
    Private Sub f_loginUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtUser.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Lengkapi Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            bersih()
        Else
            con.Close()
            bukaKoneksi()
            cmd = New SqlClient.SqlCommand("SELECT * FROM tbLogin WHERE username ='" & txtUser.Text & "'  AND password = '" & txtPassword.Text & "'", con)
            cmd.ExecuteNonQuery()
            baca = cmd.ExecuteReader()
            If baca.Read() Then
                MessageBox.Show("Selamat, Anda Berhasil Login", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                f_Utama.ToolStripButton1.Enabled = True
                f_Utama.ToolStripButton2.Enabled = True
                f_Utama.LogOutToolStripMenuItem.Enabled = True
                f_Utama.LoginToolStripMenuItem.Enabled = False
                f_Utama.MasterToolStripMenuItem.Enabled = True
                f_Utama.PenggajianToolStripMenuItem.Enabled = True
                f_Utama.LaporanToolStripMenuItem.Enabled = True
                f_Utama.PengaturanToolStripMenuItem.Enabled = True
                bersih()
                Me.Close()
            Else
                MessageBox.Show("Username dan Password Tidak Cocok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                bersih()
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class