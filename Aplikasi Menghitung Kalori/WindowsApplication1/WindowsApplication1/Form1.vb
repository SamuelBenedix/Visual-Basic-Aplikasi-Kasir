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
        DA = New OleDb.OleDbDataAdapter("select * from  Kalori", Conn)
        Ds = New DataSet
        DA.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tempt As Double

        If ComboBox1.Text = "Laki Laki" Then
            tempt = 88.362 + (13.397 * TextBox3.Text) + (4.799 * TextBox4.Text) - (5.677 * TextBox2.Text)
        Else
            tempt = 447.593 + (9.247 * TextBox3.Text) + (3.098 * TextBox4.Text) - (4.33 * TextBox2.Text)
        End If
        TextBox5.Text = tempt
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_kaloriDataSet.Kalori' table. You can move, or remove it, as needed.
        Me.KaloriTableAdapter.Fill(Me.DB_kaloriDataSet.Kalori)
        Call Koneksi()
        Call Tampilkan()

        With Me.ComboBox1.Items
            .Add("Laki Laki")
            .Add("Perempuan")
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then

            MsgBox("Data Yang dimasukkan Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            cmd = New OleDb.OleDbCommand("select * from Kalori where Nama = '" & TextBox1.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Call Koneksi()
                Dim simpan As String
                simpan = " insert into Kalori values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
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
End Class
