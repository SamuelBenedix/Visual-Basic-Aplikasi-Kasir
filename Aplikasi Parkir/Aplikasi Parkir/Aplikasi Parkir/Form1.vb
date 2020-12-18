Public Class Form1

    Sub Kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""

    End Sub


    Sub Tampilkan()
        Call Koneksi()
        DA = New OleDb.OleDbDataAdapter("select * from Parkir", Conn)
        Ds = New DataSet
        DA.Fill(Ds)
        DataGridView1.DataSource = Ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenghitungParkirDataSet.Parkir' table. You can move, or remove it, as needed.
        Me.ParkirTableAdapter.Fill(Me.PenghitungParkirDataSet.Parkir)

        Call Koneksi()
        Call Tampilkan()

        With Me.ComboBox1.Items
            .Add("Motor")
            .Add("Mobil")

        End With

        TextBox3.Text = Format(Now, "HH:mm")
        TextBox4.Text = Format(Now, "HH:mm")


    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
       
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Dim dem As Integer
        Dim hargamobil As Integer
        hargamobil = 5000
        Dim hargamotor As Integer
        hargamotor = 3000
        dem = Val(TextBox4.Text) - Val(TextBox3.Text)
        If ComboBox1.SelectedItem = "Mobil" Then
            dem = dem * hargamobil
            TextBox2.Text = dem
        Else
            dem = dem * hargamotor
            TextBox2.Text = dem
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Dim dem As Integer
        Dim hargamobil As Integer
        hargamobil = 5000
        Dim hargamotor As Integer
        hargamotor = 3000
        dem = Val(TextBox4.Text) - Val(TextBox3.Text)
        If ComboBox1.SelectedItem = "Mobil" Then
            dem = dem * hargamobil
            TextBox2.Text = dem
        Else
            dem = dem * hargamotor
            TextBox2.Text = dem
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim dem As Integer
        Dim hargamobil As Integer
        hargamobil = 5000
        Dim hargamotor As Integer
        hargamotor = 3000
        dem = Val(TextBox4.Text) - Val(TextBox3.Text)
        If ComboBox1.SelectedItem = "Mobil" Then
            dem = dem * hargamobil
            TextBox2.Text = dem
        Else
            dem = dem * hargamotor
            TextBox2.Text = dem
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Data Yang dimasukkan Belum Lengkap")
            Exit Sub
        Else
            Call Koneksi()
            cmd = New OleDb.OleDbCommand("select * from Parkir where PlatNomor = '" & TextBox1.Text & "'", Conn)
            Dr = cmd.ExecuteReader
            Dr.Read()
            If Not Dr.HasRows Then
                Call Koneksi()
                Dim simpan As String
                simpan = " insert into Parkir values ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "')"
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
