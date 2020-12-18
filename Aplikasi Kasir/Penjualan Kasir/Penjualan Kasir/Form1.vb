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
        DA = New OleDb.OleDbDataAdapter("select * from  Kasir", Conn)
        Ds = New DataSet
        DA.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_KasirDataSet.Kasir' table. You can move, or remove it, as needed.
        Me.KasirTableAdapter.Fill(Me.DB_KasirDataSet.Kasir)

        Call Koneksi()
        Call Tampilkan()
        TextBox5.Enabled = False

    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
      
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Dim tempta As Integer
        tempta = Val(TextBox4.Text) * Val(TextBox3.Text)
        TextBox5.Text = tempta
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim tempta As Integer
        tempta = Val(TextBox4.Text) * Val(TextBox3.Text)
        TextBox5.Text = tempta
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label10.Text = TimeOfDay
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Dim temp As Double
        temp = Val(TextBox7.Text)
        temp = (temp / 100) * Val(TextBox5.Text)

        temp = Val(TextBox5.Text) - temp
        TextBox8.Text = temp
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim temp As Double
        temp = Val(TextBox6.Text) - Val(TextBox8.Text)
            TextBox9.Text = temp
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim temp As Double
        temp = Val(TextBox6.Text) - Val(TextBox8.Text)
        If temp < 0 Then
            MsgBox("Jumlah Uang di masukkan kurang")
        End If

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Data Yang dimasukkan Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            cmd = New OleDb.OleDbCommand("select * from Kasir where KodeBarang = '" & TextBox1.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Call Koneksi()
                Dim simpan As String
                simpan = " insert into Kasir values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox6.Text & "','" & TextBox9.Text & "')"
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
