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
        DA = New OleDb.OleDbDataAdapter("select * from Bioskop", Conn)
        Ds = New DataSet
        DA.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenjualanTiketBioskopDataSet.Bioskop' table. You can move, or remove it, as needed.
        Me.BioskopTableAdapter.Fill(Me.PenjualanTiketBioskopDataSet.Bioskop)




    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Data Yang dimasukkan Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            cmd = New OleDb.OleDbCommand("select * from Bioskop where kursi = '" & TextBox1.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Call Koneksi()
                Dim simpan As String
                simpan = " insert into Bioskop values ('" & TextBox2.Text & "','" & TextBox4.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
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

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.RegionChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
     

        
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Dim temp As Integer

        temp = Val(TextBox6.Text) * Val(TextBox4.Text)
        TextBox3.Text = temp

        If Val(TextBox6.Text) > 3 Then
            Dim tempt As Double
            tempt = Val(TextBox3.Text) * (10 / 100)
            Dim counter As Double
            counter = Val(TextBox3.Text) - tempt
            TextBox7.Text = counter
        Else
            TextBox7.Text = temp

        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Dim temp As Double

        temp = Val(TextBox8.Text) - Val(TextBox3.Text)
        TextBox9.Text = temp
    End Sub
End Class
