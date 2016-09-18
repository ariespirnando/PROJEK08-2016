Public Class f_User
    Sub tampiluser()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("SELECT * from tbLogin", con)
        adaptor = New SqlClient.SqlDataAdapter()
        adaptor.SelectCommand = cmd
        ds = New Data.DataSet()
        adaptor.Fill(ds, "tbLogin")
        dtvuser.DataSource = ds
        dtvuser.DataMember = "tbLogin"
    End Sub
    Sub simpanuser()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("INSERT INTO tbLogin VALUES('" & txtuserbaru.Text & "','" & txtpasswordbaru.Text & "')", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampiluser()
        bersih()
    End Sub
    Sub updateuser()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("UPDATE tbLogin SET username = '" & txtuserbaru.Text & "', password = '" & txtpasswordbaru.Text & "' WHERE iduser = '" & TextBox1.Text & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diUbah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampiluser()
        bersih()
    End Sub
    Sub hapususer()
        con.Close()
        bukaKoneksi()
        cmd = New SqlClient.SqlCommand("DELETE FROM tbLogin WHERE iduser = '" & TextBox1.Text & "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diHapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tampiluser()
        bersih()
    End Sub
    Sub bersih()
        txtPassword.Clear()
        txtUser.Clear()
        txtUser.Focus()
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
                Panel3.Visible = False
                tampiluser()
            Else
                MessageBox.Show("Username dan Password Tidak Cocok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                bersih()
            End If
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Panel3.Visible = True
    End Sub

    Private Sub f_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaKoneksi()
        tampiluser()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        If txtuserbaru.Text = "" Or txtpasswordbaru.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            simpanuser()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtuserbaru.Text = "" Or txtpasswordbaru.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            hapususer()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtuserbaru.Text = "" Or txtpasswordbaru.Text = "" Then
            MessageBox.Show("Lengkapi data dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            updateuser()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        txtuserbaru.Enabled = True
        txtpasswordbaru.Enabled = True
        btntambah.Enabled = True
        btnEdit.Enabled = True
        btnHapus.Enabled = True
        dtvuser.Enabled = True
    End Sub

    Private Sub dtvuser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtvuser.CellClick
        Dim i As Integer
        i = Me.dtvuser.CurrentRow.Index
        With dtvuser.Rows.Item(i)
            If IsDBNull(.Cells(0).Value) Then
            Else
                txtuserbaru.Text = .Cells(0).Value
                txtpasswordbaru.Text = .Cells(1).Value
                TextBox1.Text = .Cells(2).Value
            End If
        End With
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class