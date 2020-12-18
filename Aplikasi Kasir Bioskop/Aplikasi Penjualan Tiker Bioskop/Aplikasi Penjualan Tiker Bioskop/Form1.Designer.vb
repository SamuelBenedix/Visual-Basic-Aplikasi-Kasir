<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.PenjualanTiketBioskopDataSet = New Aplikasi_Penjualan_Tiker_Bioskop.PenjualanTiketBioskopDataSet()
        Me.BioskopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BioskopTableAdapter = New Aplikasi_Penjualan_Tiker_Bioskop.PenjualanTiketBioskopDataSetTableAdapters.BioskopTableAdapter()
        Me.TableAdapterManager = New Aplikasi_Penjualan_Tiker_Bioskop.PenjualanTiketBioskopDataSetTableAdapters.TableAdapterManager()
        Me.KursiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaSatuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PembayaranDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KembalianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanTiketBioskopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BioskopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(412, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Ticket"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Total"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(499, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(118, 286)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(113, 20)
        Me.TextBox3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Kasir Bioskop"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(199, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(604, 406)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(118, 256)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KursiDataGridViewTextBoxColumn, Me.HargaSatuanDataGridViewTextBoxColumn, Me.JumlahBeliDataGridViewTextBoxColumn, Me.HargaTotalDataGridViewTextBoxColumn, Me.PembayaranDataGridViewTextBoxColumn, Me.KembalianDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BioskopBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(294, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(365, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(439, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Data List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Kursi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(249, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Muhammad Farhan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(250, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "03021281823035"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(118, 67)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(113, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Jenis Tiket"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(118, 101)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 30
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Reguler"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(118, 124)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton2.TabIndex = 31
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Premium"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 166)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Harga Satuan"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(118, 163)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(113, 20)
        Me.TextBox4.TabIndex = 33
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Bonus Langsung"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(118, 193)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(113, 20)
        Me.TextBox5.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Jumlah Beli"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(118, 222)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(113, 20)
        Me.TextBox6.TabIndex = 37
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(21, 313)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(172, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "*Diskon 10% jika beli diatas 3 Tiket"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(118, 329)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(113, 20)
        Me.TextBox7.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 374)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Pembayaran"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(118, 371)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(113, 20)
        Me.TextBox8.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Kembalian"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(118, 404)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(113, 20)
        Me.TextBox9.TabIndex = 43
        '
        'PenjualanTiketBioskopDataSet
        '
        Me.PenjualanTiketBioskopDataSet.DataSetName = "PenjualanTiketBioskopDataSet"
        Me.PenjualanTiketBioskopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BioskopBindingSource
        '
        Me.BioskopBindingSource.DataMember = "Bioskop"
        Me.BioskopBindingSource.DataSource = Me.PenjualanTiketBioskopDataSet
        '
        'BioskopTableAdapter
        '
        Me.BioskopTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BioskopTableAdapter = Me.BioskopTableAdapter
        Me.TableAdapterManager.UpdateOrder = Aplikasi_Penjualan_Tiker_Bioskop.PenjualanTiketBioskopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KursiDataGridViewTextBoxColumn
        '
        Me.KursiDataGridViewTextBoxColumn.DataPropertyName = "Kursi"
        Me.KursiDataGridViewTextBoxColumn.HeaderText = "Kursi"
        Me.KursiDataGridViewTextBoxColumn.Name = "KursiDataGridViewTextBoxColumn"
        '
        'HargaSatuanDataGridViewTextBoxColumn
        '
        Me.HargaSatuanDataGridViewTextBoxColumn.DataPropertyName = "HargaSatuan"
        Me.HargaSatuanDataGridViewTextBoxColumn.HeaderText = "HargaSatuan"
        Me.HargaSatuanDataGridViewTextBoxColumn.Name = "HargaSatuanDataGridViewTextBoxColumn"
        '
        'JumlahBeliDataGridViewTextBoxColumn
        '
        Me.JumlahBeliDataGridViewTextBoxColumn.DataPropertyName = "JumlahBeli"
        Me.JumlahBeliDataGridViewTextBoxColumn.HeaderText = "JumlahBeli"
        Me.JumlahBeliDataGridViewTextBoxColumn.Name = "JumlahBeliDataGridViewTextBoxColumn"
        '
        'HargaTotalDataGridViewTextBoxColumn
        '
        Me.HargaTotalDataGridViewTextBoxColumn.DataPropertyName = "HargaTotal"
        Me.HargaTotalDataGridViewTextBoxColumn.HeaderText = "HargaTotal"
        Me.HargaTotalDataGridViewTextBoxColumn.Name = "HargaTotalDataGridViewTextBoxColumn"
        '
        'PembayaranDataGridViewTextBoxColumn
        '
        Me.PembayaranDataGridViewTextBoxColumn.DataPropertyName = "Pembayaran"
        Me.PembayaranDataGridViewTextBoxColumn.HeaderText = "Pembayaran"
        Me.PembayaranDataGridViewTextBoxColumn.Name = "PembayaranDataGridViewTextBoxColumn"
        '
        'KembalianDataGridViewTextBoxColumn
        '
        Me.KembalianDataGridViewTextBoxColumn.DataPropertyName = "Kembalian"
        Me.KembalianDataGridViewTextBoxColumn.HeaderText = "Kembalian"
        Me.KembalianDataGridViewTextBoxColumn.Name = "KembalianDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(691, 441)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kasir"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanTiketBioskopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BioskopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents PenjualanTiketBioskopDataSet As Aplikasi_Penjualan_Tiker_Bioskop.PenjualanTiketBioskopDataSet
    Friend WithEvents BioskopBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BioskopTableAdapter As Aplikasi_Penjualan_Tiker_Bioskop.PenjualanTiketBioskopDataSetTableAdapters.BioskopTableAdapter
    Friend WithEvents TableAdapterManager As Aplikasi_Penjualan_Tiker_Bioskop.PenjualanTiketBioskopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KursiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaSatuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahBeliDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PembayaranDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KembalianDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
