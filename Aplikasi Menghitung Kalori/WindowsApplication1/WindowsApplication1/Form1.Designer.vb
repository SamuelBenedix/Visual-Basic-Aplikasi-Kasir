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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DB_kaloriDataSet = New WindowsApplication1.DB_kaloriDataSet()
        Me.KaloriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KaloriTableAdapter = New WindowsApplication1.DB_kaloriDataSetTableAdapters.KaloriTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.DB_kaloriDataSetTableAdapters.TableAdapterManager()
        Me.NamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisKelaminDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BeratBadanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TinggiBadanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahKaloriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_kaloriDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaloriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(128, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Umur"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(128, 93)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(128, 152)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Berat Badan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tinggi Badan"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(128, 180)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(128, 121)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(230, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(354, 31)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Aplikasi Penghitung Kalori"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Jumlah Kalori"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(128, 215)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Input"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NamaDataGridViewTextBoxColumn, Me.UmurDataGridViewTextBoxColumn, Me.JenisKelaminDataGridViewTextBoxColumn, Me.BeratBadanDataGridViewTextBoxColumn, Me.TinggiBadanDataGridViewTextBoxColumn, Me.JumlahKaloriDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KaloriBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(294, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(478, 173)
        Me.DataGridView1.TabIndex = 15
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(697, 270)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DB_kaloriDataSet
        '
        Me.DB_kaloriDataSet.DataSetName = "DB_kaloriDataSet"
        Me.DB_kaloriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KaloriBindingSource
        '
        Me.KaloriBindingSource.DataMember = "Kalori"
        Me.KaloriBindingSource.DataSource = Me.DB_kaloriDataSet
        '
        'KaloriTableAdapter
        '
        Me.KaloriTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KaloriTableAdapter = Me.KaloriTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.DB_kaloriDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'JumlahKaloriDataGridViewTextBoxColumn
        '
        Me.JumlahKaloriDataGridViewTextBoxColumn.DataPropertyName = "Jumlah Kalori"
        Me.JumlahKaloriDataGridViewTextBoxColumn.HeaderText = "Jumlah Kalori"
        Me.JumlahKaloriDataGridViewTextBoxColumn.Name = "JumlahKaloriDataGridViewTextBoxColumn"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Wayan Adji F.R"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "03021181823025"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(798, 305)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Penghitung Kalori"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_kaloriDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaloriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DB_kaloriDataSet As WindowsApplication1.DB_kaloriDataSet
    Friend WithEvents KaloriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KaloriTableAdapter As WindowsApplication1.DB_kaloriDataSetTableAdapters.KaloriTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.DB_kaloriDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UmurDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisKelaminDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeratBadanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TinggiBadanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JumlahKaloriDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
