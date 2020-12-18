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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DB_BeratidealDataSet = New Aplikasi_Tipe_Badan.DB_BeratidealDataSet()
        Me.BeratIdealBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeratIdealTableAdapter = New Aplikasi_Tipe_Badan.DB_BeratidealDataSetTableAdapters.BeratIdealTableAdapter()
        Me.TableAdapterManager = New Aplikasi_Tipe_Badan.DB_BeratidealDataSetTableAdapters.TableAdapterManager()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeratBadanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinggiBadanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HasilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_BeratidealDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BeratIdealBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(812, 351)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 42
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "030212818237"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Muhammad Iqbal"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(311, 243)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "/Cm"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "/Kg"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaDataGridViewTextBoxColumn, Me.UmurDataGridViewTextBoxColumn, Me.JenisKelaminDataGridViewTextBoxColumn, Me.BeratBadanDataGridViewTextBoxColumn, Me.TinggiBadanDataGridViewTextBoxColumn, Me.HasilDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BeratIdealBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(357, 111)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(533, 150)
        Me.DataGridView1.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(230, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 339)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(129, 174)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(176, 21)
        Me.ComboBox1.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 300)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Hasil"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(129, 297)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(176, 20)
        Me.TextBox6.TabIndex = 32
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(129, 236)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(176, 20)
        Me.TextBox5.TabIndex = 31
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(129, 206)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(176, 20)
        Me.TextBox4.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Tinggi Badan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Berat Badan"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(129, 144)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(176, 20)
        Me.TextBox2.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Umur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 31)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Aplikasi Tipe Tubuh"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 111)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 22
        '
        'DB_BeratidealDataSet
        '
        Me.DB_BeratidealDataSet.DataSetName = "DB_BeratidealDataSet"
        Me.DB_BeratidealDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BeratIdealBindingSource
        '
        Me.BeratIdealBindingSource.DataMember = "BeratIdeal"
        Me.BeratIdealBindingSource.DataSource = Me.DB_BeratidealDataSet
        '
        'BeratIdealTableAdapter
        '
        Me.BeratIdealTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BeratIdealTableAdapter = Me.BeratIdealTableAdapter
        Me.TableAdapterManager.UpdateOrder = Aplikasi_Tipe_Badan.DB_BeratidealDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'UmurDataGridViewTextBoxColumn
        '
        Me.UmurDataGridViewTextBoxColumn.DataPropertyName = "Umur"
        Me.UmurDataGridViewTextBoxColumn.HeaderText = "Umur"
        Me.UmurDataGridViewTextBoxColumn.Name = "UmurDataGridViewTextBoxColumn"
        '
        'JenisKelaminDataGridViewTextBoxColumn
        '
        Me.JenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis Kelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.Name = "JenisKelaminDataGridViewTextBoxColumn"
        '
        'BeratBadanDataGridViewTextBoxColumn
        '
        Me.BeratBadanDataGridViewTextBoxColumn.DataPropertyName = "Berat Badan"
        Me.BeratBadanDataGridViewTextBoxColumn.HeaderText = "Berat Badan"
        Me.BeratBadanDataGridViewTextBoxColumn.Name = "BeratBadanDataGridViewTextBoxColumn"
        '
        'TinggiBadanDataGridViewTextBoxColumn
        '
        Me.TinggiBadanDataGridViewTextBoxColumn.DataPropertyName = "Tinggi Badan"
        Me.TinggiBadanDataGridViewTextBoxColumn.HeaderText = "Tinggi Badan"
        Me.TinggiBadanDataGridViewTextBoxColumn.Name = "TinggiBadanDataGridViewTextBoxColumn"
        '
        'HasilDataGridViewTextBoxColumn
        '
        Me.HasilDataGridViewTextBoxColumn.DataPropertyName = "Hasil"
        Me.HasilDataGridViewTextBoxColumn.HeaderText = "Hasil"
        Me.HasilDataGridViewTextBoxColumn.Name = "HasilDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(899, 386)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Ideal Tubuh"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_BeratidealDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BeratIdealBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DB_BeratidealDataSet As Aplikasi_Tipe_Badan.DB_BeratidealDataSet
    Friend WithEvents BeratIdealBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BeratIdealTableAdapter As Aplikasi_Tipe_Badan.DB_BeratidealDataSetTableAdapters.BeratIdealTableAdapter
    Friend WithEvents TableAdapterManager As Aplikasi_Tipe_Badan.DB_BeratidealDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisKelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeratBadanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinggiBadanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HasilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
