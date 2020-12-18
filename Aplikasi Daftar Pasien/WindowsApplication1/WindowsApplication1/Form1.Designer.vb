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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.DB_DaftarPasienDataSet = New WindowsApplication1.DB_DaftarPasienDataSet()
        Me.DaftarPasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaftarPasienTableAdapter = New WindowsApplication1.DB_DaftarPasienDataSetTableAdapters.DaftarPasienTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DB_DaftarPasienDataSetTableAdapters.TableAdapterManager()
        Me.NoRuanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_DaftarPasienDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DaftarPasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Daftar Pasien"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ahmad Fauzan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "03021281823068"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoRuanganDataGridViewTextBoxColumn, Me.NamaDataGridViewTextBoxColumn, Me.UsiaDataGridViewTextBoxColumn, Me.JenisKelaminDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DaftarPasienBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(291, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(482, 145)
        Me.DataGridView1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(711, 282)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nama "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(127, 80)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Alamat"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(127, 106)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Usia"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(127, 136)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(123, 20)
        Me.TextBox3.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Jenis Kelamin"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(127, 169)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "No Ruangan"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(127, 197)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(123, 20)
        Me.TextBox4.TabIndex = 14
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(175, 242)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Save.TabIndex = 15
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'DB_DaftarPasienDataSet
        '
        Me.DB_DaftarPasienDataSet.DataSetName = "DB_DaftarPasienDataSet"
        Me.DB_DaftarPasienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DaftarPasienBindingSource
        '
        Me.DaftarPasienBindingSource.DataMember = "DaftarPasien"
        Me.DaftarPasienBindingSource.DataSource = Me.DB_DaftarPasienDataSet
        '
        'DaftarPasienTableAdapter
        '
        Me.DaftarPasienTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DaftarPasienTableAdapter = Me.DaftarPasienTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DB_DaftarPasienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NoRuanganDataGridViewTextBoxColumn
        '
        Me.NoRuanganDataGridViewTextBoxColumn.DataPropertyName = "NoRuangan"
        Me.NoRuanganDataGridViewTextBoxColumn.HeaderText = "NoRuangan"
        Me.NoRuanganDataGridViewTextBoxColumn.Name = "NoRuanganDataGridViewTextBoxColumn"
        '
        'NamaDataGridViewTextBoxColumn
        '
        Me.NamaDataGridViewTextBoxColumn.DataPropertyName = "Nama"
        Me.NamaDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamaDataGridViewTextBoxColumn.Name = "NamaDataGridViewTextBoxColumn"
        '
        'UsiaDataGridViewTextBoxColumn
        '
        Me.UsiaDataGridViewTextBoxColumn.DataPropertyName = "Usia"
        Me.UsiaDataGridViewTextBoxColumn.HeaderText = "Usia"
        Me.UsiaDataGridViewTextBoxColumn.Name = "UsiaDataGridViewTextBoxColumn"
        '
        'JenisKelaminDataGridViewTextBoxColumn
        '
        Me.JenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "JenisKelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.HeaderText = "JenisKelamin"
        Me.JenisKelaminDataGridViewTextBoxColumn.Name = "JenisKelaminDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(798, 317)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Daftar Pasien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_DaftarPasienDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DaftarPasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Save As System.Windows.Forms.Button
    Friend WithEvents DB_DaftarPasienDataSet As WindowsApplication1.DB_DaftarPasienDataSet
    Friend WithEvents DaftarPasienBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DaftarPasienTableAdapter As WindowsApplication1.DB_DaftarPasienDataSetTableAdapters.DaftarPasienTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DB_DaftarPasienDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NoRuanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisKelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
