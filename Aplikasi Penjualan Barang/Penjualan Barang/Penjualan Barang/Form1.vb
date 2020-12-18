Public Class Form1


    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""

    End Sub


    Sub Tampilkan()
        Call Koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from Penjualan", Conn)
        Ds = New DataSet
        DA.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanBarangDataSet.Penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.PenjualanBarangDataSet.Penjualan)
        Call Koneksi()
        Call Tampilkan()
        TextBox5.Enabled = False
        TextBox5.Text = "0"
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox5.Text = "" Then
            MsgBox("Tolong Cek Harga Dahulu Sebelum diInput")
        End If
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Data Yang dimasukkan Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            cmd = New OleDb.OleDbCommand("select * from Penjualan where kode = '" & TextBox1.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Call Koneksi()
                Dim simpan As String
                simpan = " insert into penjualan values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
                cmd = New OleDb.OleDbCommand(simpan, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Kode Sudah Terdaftar")

            End If
            Call Kosongkan()
            Call Tampilkan()

        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Call Kosongkan()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick


    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub


    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Dim tempt As Integer
        tempt = Val(TextBox4.Text) * Val(TextBox3.Text)
        TextBox5.Text = tempt


    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim tempt As Integer
        tempt = Val(TextBox3.Text) * Val(TextBox4.Text)
        TextBox5.Text = tempt
    End Sub
End Class
