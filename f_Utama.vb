Public Class f_Utama

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        f_Penggajian.MdiParent = Me
        f_Penggajian.Show()
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
    End Sub

    Private Sub f_Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = False
        LogOutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        PenggajianToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        PengaturanToolStripMenuItem.Enabled = False

        f_loginUser.MdiParent = Me
        f_loginUser.Show()
    End Sub

    Private Sub DataDapartemenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDapartemenToolStripMenuItem.Click
        f_Dapartemen.MdiParent = Me
        f_Dapartemen.Show()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
    End Sub

    Private Sub PengaturanGajiToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        f_loginUser.MdiParent = Me
        f_loginUser.Show()
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = False
        LogOutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        PenggajianToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        PengaturanToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True

        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()

        MessageBox.Show("Logout Sukses !!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = False
        LogOutToolStripMenuItem.Enabled = False
        LoginToolStripMenuItem.Enabled = True
        MasterToolStripMenuItem.Enabled = False
        PenggajianToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        PengaturanToolStripMenuItem.Enabled = False

        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
        MessageBox.Show("Logout Sukses !!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click

        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()

        MessageBox.Show("Terimakasi telah menggunakan sistem ini", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        f_Karyawan.MdiParent = Me
        f_Karyawan.Show()
        f_Dapartemen.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
    End Sub

    Private Sub DataPengaturanGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPengaturanGajiToolStripMenuItem.Click
        f_pGaji.MdiParent = Me
        f_pGaji.Show()
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
    End Sub

    Private Sub PenggajianKarywanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggajianKarywanToolStripMenuItem.Click
        f_Penggajian.MdiParent = Me
        f_Penggajian.Show()
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
    End Sub

    Private Sub LaporanGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanGajiToolStripMenuItem.Click
        
    End Sub

    Private Sub SlipGajiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlipGajiToolStripMenuItem.Click
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.MdiParent = Me
        f_Slip.Show()
        f_About.Close()
        f_User.Close()
    End Sub

    Private Sub PengaturanUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PengaturanUserToolStripMenuItem.Click
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.MdiParent = Me
        f_User.Show()
    End Sub

    Private Sub AboutProgramerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutProgramerToolStripMenuItem.Click
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()
        f_Laporan2.Close()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.MdiParent = Me
        f_About.Show()
        f_User.Close()
    End Sub

    Private Sub PerTanggalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerTanggalToolStripMenuItem.Click
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()

        f_Laporan.MdiParent = Me
        f_Laporan.Show()
        f_Laporan2.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
    End Sub

    Private Sub PerBulanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerBulanToolStripMenuItem.Click
        f_Dapartemen.Close()
        f_Karyawan.Close()
        f_Penggajian.Close()
        f_pGaji.Close()

        f_Laporan2.MdiParent = Me
        f_Laporan2.Show()
        f_Laporan.Close()
        f_Slip.Close()
        f_About.Close()
        f_User.Close()
    End Sub
End Class
