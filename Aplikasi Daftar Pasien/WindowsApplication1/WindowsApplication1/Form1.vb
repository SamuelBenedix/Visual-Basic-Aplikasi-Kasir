Public Class Form1

    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub


    Sub Tampilkan()

        Call Koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from  DaftarPasien", Conn)
        Ds = New DataSet
        DA.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_DaftarPasienDataSet.DaftarPasien' table. You can move, or remove it, as needed.
        Me.DaftarPasienTableAdapter.Fill(Me.DB_DaftarPasienDataSet.DaftarPasien)

        Call Koneksi()
        Call Tampilkan()

        With Me.ComboBox1.Items
            .Add("Laki Laki")
            .Add("Perempuan")
        End With


    End Sub

    Private Sub Btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Save.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Data Yang dimasukkan Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            cmd = New OleDb.OleDbCommand("select * from DaftarPasien where NoRuangan = '" & TextBox1.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Call Koneksi()
                Dim simpan As String
                simpan = " insert into DaftarPasien values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "')"
                cmd = New OleDb.OleDbCommand(simpan, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("No Ruangan Sudah Terdaftar")

            End If
            Call Kosongkan()
            Call Tampilkan()

        End If
    End Sub
End Class
