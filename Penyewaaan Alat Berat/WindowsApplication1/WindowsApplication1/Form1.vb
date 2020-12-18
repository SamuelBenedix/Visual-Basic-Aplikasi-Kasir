Public Class Form1
    Dim total As Double
    Dim awal As Double

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Me.ComboBox1.Items
            .Add("Pagi")
            .Add("Siang")
            .Add("Sore")
            .Add("Malam")
        End With

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = TimeOfDay

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox6.Text = ""
        TextBox7.Text = ""
        DateTimePicker1.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        Label15.Text = "0"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(Keys.Back))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MessageBox.Show("Data Masih Ada yang Kurang", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Data Tersimpan", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox9.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If Val(TextBox8.Text) = "0" Then
            MessageBox.Show("Jumlah yang dimasukkan Salah", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        total = 0
        total = Val(TextBox9.Text) * Val(TextBox8.Text) * Val(TextBox7.Text) + total
        Label15.Text = total

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub
End Class
