Public Class Form1
    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

    End Sub


    Sub Tampilkan()
        Call Koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from  BeratIdeal", Conn)
        Ds = New DataSet
        DA.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_BeratidealDataSet.BeratIdeal' table. You can move, or remove it, as needed.
        Me.BeratIdealTableAdapter.Fill(Me.DB_BeratidealDataSet.BeratIdeal)

        Call Koneksi()
        Call Tampilkan()

        With Me.ComboBox1.Items
            .Add("Laki Laki")
            .Add("Perempuan")
        End With

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tempt As Double
        Dim tinggi As Double

        tinggi = TextBox5.Text / 100

        tempt = TextBox4.Text / (tinggi * tinggi)
        If tempt < 17 Then
            TextBox6.Text = "Berat Badan Tidak Ideal"
        ElseIf tempt > 25 Then
            TextBox6.Text = "Kelebihan Berat Badan"
        Else
            TextBox6.Text = "Berat Badan Ideal"
        End If

    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Data Yang dimasukkan Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            cmd = New OleDb.OleDbCommand("select * from BeratIdeal where Nama = '" & TextBox1.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Call Koneksi()
                Dim simpan As String
                simpan = " insert into BeratIdeal values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "')"
                cmd = New OleDb.OleDbCommand(simpan, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Nama Sudah Terdaftar")

            End If
            Call Kosongkan()
            Call Tampilkan()

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
