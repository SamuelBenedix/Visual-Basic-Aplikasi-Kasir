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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaPerBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahBarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalHargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SetelahDiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDibayarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KembalianDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KasirBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_KasirDataSet = New Penjualan_Kasir.DB_KasirDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.KasirTableAdapter = New Penjualan_Kasir.DB_KasirDataSetTableAdapters.KasirTableAdapter()
        Me.TableAdapterManager = New Penjualan_Kasir.DB_KasirDataSetTableAdapters.TableAdapterManager()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_KasirDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jumlah Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Harga Per/Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Myriad Pro Cond", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 41)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Kasir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(311, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Harga"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(149, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(149, 132)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(149, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 8
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(149, 191)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 9
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(471, 203)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(211, 20)
        Me.TextBox5.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 241)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 27)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(38, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 27)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(602, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(80, 29)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeBarangDataGridViewTextBoxColumn, Me.NamaBarangDataGridViewTextBoxColumn, Me.HargaPerBarangDataGridViewTextBoxColumn, Me.JumlahBarangDataGridViewTextBoxColumn, Me.TotalHargaDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.SetelahDiskonDataGridViewTextBoxColumn, Me.JumlahDibayarDataGridViewTextBoxColumn, Me.KembalianDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KasirBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(297, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(385, 150)
        Me.DataGridView1.TabIndex = 16
        '
        'KodeBarangDataGridViewTextBoxColumn
        '
        Me.KodeBarangDataGridViewTextBoxColumn.DataPropertyName = "KodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.HeaderText = "KodeBarang"
        Me.KodeBarangDataGridViewTextBoxColumn.Name = "KodeBarangDataGridViewTextBoxColumn"
        '
        'NamaBarangDataGridViewTextBoxColumn
        '
        Me.NamaBarangDataGridViewTextBoxColumn.DataPropertyName = "NamaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn.HeaderText = "NamaBarang"
        Me.NamaBarangDataGridViewTextBoxColumn.Name = "NamaBarangDataGridViewTextBoxColumn"
        '
        'HargaPerBarangDataGridViewTextBoxColumn
        '
        Me.HargaPerBarangDataGridViewTextBoxColumn.DataPropertyName = "HargaPerBarang"
        Me.HargaPerBarangDataGridViewTextBoxColumn.HeaderText = "HargaPerBarang"
        Me.HargaPerBarangDataGridViewTextBoxColumn.Name = "HargaPerBarangDataGridViewTextBoxColumn"
        '
        'JumlahBarangDataGridViewTextBoxColumn
        '
        Me.JumlahBarangDataGridViewTextBoxColumn.DataPropertyName = "JumlahBarang"
        Me.JumlahBarangDataGridViewTextBoxColumn.HeaderText = "JumlahBarang"
        Me.JumlahBarangDataGridViewTextBoxColumn.Name = "JumlahBarangDataGridViewTextBoxColumn"
        '
        'TotalHargaDataGridViewTextBoxColumn
        '
        Me.TotalHargaDataGridViewTextBoxColumn.DataPropertyName = "TotalHarga"
        Me.TotalHargaDataGridViewTextBoxColumn.HeaderText = "TotalHarga"
        Me.TotalHargaDataGridViewTextBoxColumn.Name = "TotalHargaDataGridViewTextBoxColumn"
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        '
        'SetelahDiskonDataGridViewTextBoxColumn
        '
        Me.SetelahDiskonDataGridViewTextBoxColumn.DataPropertyName = "SetelahDiskon"
        Me.SetelahDiskonDataGridViewTextBoxColumn.HeaderText = "SetelahDiskon"
        Me.SetelahDiskonDataGridViewTextBoxColumn.Name = "SetelahDiskonDataGridViewTextBoxColumn"
        '
        'JumlahDibayarDataGridViewTextBoxColumn
        '
        Me.JumlahDibayarDataGridViewTextBoxColumn.DataPropertyName = "JumlahDibayar"
        Me.JumlahDibayarDataGridViewTextBoxColumn.HeaderText = "JumlahDibayar"
        Me.JumlahDibayarDataGridViewTextBoxColumn.Name = "JumlahDibayarDataGridViewTextBoxColumn"
        '
        'KembalianDataGridViewTextBoxColumn
        '
        Me.KembalianDataGridViewTextBoxColumn.DataPropertyName = "Kembalian"
        Me.KembalianDataGridViewTextBoxColumn.HeaderText = "Kembalian"
        Me.KembalianDataGridViewTextBoxColumn.Name = "KembalianDataGridViewTextBoxColumn"
        '
        'KasirBindingSource
        '
        Me.KasirBindingSource.DataMember = "Kasir"
        Me.KasirBindingSource.DataSource = Me.DB_KasirDataSet
        '
        'DB_KasirDataSet
        '
        Me.DB_KasirDataSet.DataSetName = "DB_KasirDataSet"
        Me.DB_KasirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(439, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Data List"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(625, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 13)
        Me.Label10.TabIndex = 18
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(311, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 25)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Diskon %"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(311, 255)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(145, 25)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Jumlah dibayar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(311, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 25)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Kembalian"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(471, 259)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(211, 20)
        Me.TextBox6.TabIndex = 22
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(471, 230)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(50, 20)
        Me.TextBox7.TabIndex = 23
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(553, 230)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(126, 20)
        Me.TextBox8.TabIndex = 24
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(471, 286)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(211, 20)
        Me.TextBox9.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(524, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "%"
        '
        'KasirTableAdapter
        '
        Me.KasirTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KasirTableAdapter = Me.KasirTableAdapter
        Me.TableAdapterManager.UpdateOrder = Penjualan_Kasir.DB_KasirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Samuel Benedict Putra Teguh"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 375)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kasir"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KasirBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_KasirDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DB_KasirDataSet As Penjualan_Kasir.DB_KasirDataSet
    Friend WithEvents KasirBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KasirTableAdapter As Penjualan_Kasir.DB_KasirDataSetTableAdapters.KasirTableAdapter
    Friend WithEvents TableAdapterManager As Penjualan_Kasir.DB_KasirDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KodeBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HargaPerBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahBarangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalHargaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SetelahDiskonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahDibayarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KembalianDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
