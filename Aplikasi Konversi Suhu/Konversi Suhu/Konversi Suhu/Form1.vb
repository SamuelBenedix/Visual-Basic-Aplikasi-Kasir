Public Class Form1
    Dim penambahan As Double
    Dim hasil As Double


    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""

    End Sub


    Sub Tampilkan()
        Call Koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from Konversi", Conn)
        Ds = New DataSet
        DA.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KonversiSuhuDataSet.Konversi' table. You can move, or remove it, as needed.
        Me.KonversiTableAdapter.Fill(Me.KonversiSuhuDataSet.Konversi)

        Call Koneksi()
        Call Tampilkan()

        TextBox4.Enabled = False
        With Me.ComboBox1.Items
            .Add("R")
            .Add("C")
            .Add("F")
        End With

        With Me.ComboBox2.Items
            .Add("R")
            .Add("C")
            .Add("F")


        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim temp As Double
        Dim temp2 As Double
        Dim temp3 As Double
        penambahan = 32

        If ComboBox1.SelectedItem = "R" And ComboBox2.SelectedItem = "C" Then
            temp = (5 / 4) * Val(TextBox1.Text)
            TextBox4.Text = temp
        ElseIf ComboBox1.SelectedItem = "R" And ComboBox2.SelectedItem = "F" Then
            temp = ((9 / 4) * Val(TextBox1.Text)) + penambahan
            TextBox4.Text = temp
        ElseIf ComboBox1.SelectedItem = "C" And ComboBox2.SelectedItem = "F" Then
            temp2 = ((9 / 5) * Val(TextBox1.Text)) - penambahan
            TextBox4.Text = temp2
        ElseIf ComboBox1.SelectedItem = "C" And ComboBox2.SelectedItem = "R" Then
            temp2 = (4 / 5) * Val(TextBox1.Text)
        ElseIf ComboBox1.SelectedItem = "F" And ComboBox2.SelectedItem = "R" Then
            temp3 = (Val(TextBox1.Text) - penambahan) * (4 / 9)
            TextBox4.Text = temp3
        ElseIf ComboBox1.SelectedItem = "F" And ComboBox2.SelectedItem = "C" Then
            temp3 = (Val(TextBox1.Text) - penambahan) * (5 / 9)
            TextBox4.Text = temp3
        Else
            MsgBox("Konversi yang anda masukkan salah")
            TextBox1.Text = ""
            TextBox4.Text = ""
            ComboBox1.Text = ""
            ComboBox2.Text = ""
        End If


    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            Call Koneksi()
        cmd = New OleDb.OleDbCommand("select * from Konversi where NilaiKonversi = '" & TextBox1.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Call Koneksi()
                Dim simpan As String
            simpan = " insert into Konversi values ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "')"
                cmd = New OleDb.OleDbCommand(simpan, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Input Data Sukses")
            Else
                MsgBox("Kode Sudah Terdaftar")

            End If
            Call Kosongkan()
            Call Tampilkan()

    End Sub
End Class
