<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class car_info
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
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.lblsearch = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.txtregistrationno = New System.Windows.Forms.TextBox
        Me.txtchasisno = New System.Windows.Forms.TextBox
        Me.txtcarmodel = New System.Windows.Forms.TextBox
        Me.txtcarid = New System.Windows.Forms.TextBox
        Me.cmdclose = New System.Windows.Forms.Button
        Me.lblcartypeid = New System.Windows.Forms.Label
        Me.cmdclear = New System.Windows.Forms.Button
        Me.lblcarid = New System.Windows.Forms.Label
        Me.lblregistrationno = New System.Windows.Forms.Label
        Me.lblcarmodel = New System.Windows.Forms.Label
        Me.cmdremove = New System.Windows.Forms.Button
        Me.lblchasisno = New System.Windows.Forms.Label
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RegistrationNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChassisNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarTypeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblCarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet5 = New mycab.Cab_BookingDataSet5
        Me.TblCarTableAdapter = New mycab.Cab_BookingDataSet5TableAdapters.tblCarTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.lblsearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(360, 89)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(42, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Car ID"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(106, 40)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(124, 26)
        Me.ComboBox4.TabIndex = 79
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.ForeColor = System.Drawing.Color.Red
        Me.lblsearch.Location = New System.Drawing.Point(255, 45)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(56, 19)
        Me.lblsearch.TabIndex = 79
        Me.lblsearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 44)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Car Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.txtregistrationno)
        Me.GroupBox2.Controls.Add(Me.txtchasisno)
        Me.GroupBox2.Controls.Add(Me.txtcarmodel)
        Me.GroupBox2.Controls.Add(Me.txtcarid)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.lblcartypeid)
        Me.GroupBox2.Controls.Add(Me.cmdclear)
        Me.GroupBox2.Controls.Add(Me.lblcarid)
        Me.GroupBox2.Controls.Add(Me.lblregistrationno)
        Me.GroupBox2.Controls.Add(Me.lblcarmodel)
        Me.GroupBox2.Controls.Add(Me.cmdremove)
        Me.GroupBox2.Controls.Add(Me.lblchasisno)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdnew)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(537, 461)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.White
        Me.ComboBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(172, 274)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(208, 26)
        Me.ComboBox2.TabIndex = 32
        '
        'txtregistrationno
        '
        Me.txtregistrationno.BackColor = System.Drawing.Color.White
        Me.txtregistrationno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtregistrationno.Location = New System.Drawing.Point(172, 122)
        Me.txtregistrationno.Name = "txtregistrationno"
        Me.txtregistrationno.Size = New System.Drawing.Size(208, 27)
        Me.txtregistrationno.TabIndex = 18
        '
        'txtchasisno
        '
        Me.txtchasisno.BackColor = System.Drawing.Color.White
        Me.txtchasisno.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtchasisno.Location = New System.Drawing.Point(172, 228)
        Me.txtchasisno.Name = "txtchasisno"
        Me.txtchasisno.Size = New System.Drawing.Size(208, 27)
        Me.txtchasisno.TabIndex = 17
        '
        'txtcarmodel
        '
        Me.txtcarmodel.BackColor = System.Drawing.Color.White
        Me.txtcarmodel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarmodel.Location = New System.Drawing.Point(172, 168)
        Me.txtcarmodel.Name = "txtcarmodel"
        Me.txtcarmodel.Size = New System.Drawing.Size(208, 27)
        Me.txtcarmodel.TabIndex = 16
        '
        'txtcarid
        '
        Me.txtcarid.BackColor = System.Drawing.Color.White
        Me.txtcarid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarid.Location = New System.Drawing.Point(172, 70)
        Me.txtcarid.Name = "txtcarid"
        Me.txtcarid.Size = New System.Drawing.Size(208, 27)
        Me.txtcarid.TabIndex = 14
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdclose.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdclose.Location = New System.Drawing.Point(410, 387)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 31)
        Me.cmdclose.TabIndex = 13
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = False
        '
        'lblcartypeid
        '
        Me.lblcartypeid.AutoSize = True
        Me.lblcartypeid.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartypeid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcartypeid.Location = New System.Drawing.Point(19, 278)
        Me.lblcartypeid.Name = "lblcartypeid"
        Me.lblcartypeid.Size = New System.Drawing.Size(109, 22)
        Me.lblcartypeid.TabIndex = 5
        Me.lblcartypeid.Text = "Car Type Id:"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdclear.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdclear.Location = New System.Drawing.Point(314, 387)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(75, 29)
        Me.cmdclear.TabIndex = 12
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.UseVisualStyleBackColor = False
        '
        'lblcarid
        '
        Me.lblcarid.AutoSize = True
        Me.lblcarid.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcarid.Location = New System.Drawing.Point(19, 70)
        Me.lblcarid.Name = "lblcarid"
        Me.lblcarid.Size = New System.Drawing.Size(66, 22)
        Me.lblcarid.TabIndex = 1
        Me.lblcarid.Text = "Car ID:"
        '
        'lblregistrationno
        '
        Me.lblregistrationno.AutoSize = True
        Me.lblregistrationno.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblregistrationno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblregistrationno.Location = New System.Drawing.Point(19, 122)
        Me.lblregistrationno.Name = "lblregistrationno"
        Me.lblregistrationno.Size = New System.Drawing.Size(140, 22)
        Me.lblregistrationno.TabIndex = 2
        Me.lblregistrationno.Text = "Registration No:"
        '
        'lblcarmodel
        '
        Me.lblcarmodel.AutoSize = True
        Me.lblcarmodel.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarmodel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcarmodel.Location = New System.Drawing.Point(19, 173)
        Me.lblcarmodel.Name = "lblcarmodel"
        Me.lblcarmodel.Size = New System.Drawing.Size(98, 22)
        Me.lblcarmodel.TabIndex = 3
        Me.lblcarmodel.Text = "Car Model:"
        '
        'cmdremove
        '
        Me.cmdremove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdremove.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdremove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdremove.Location = New System.Drawing.Point(194, 387)
        Me.cmdremove.Name = "cmdremove"
        Me.cmdremove.Size = New System.Drawing.Size(94, 31)
        Me.cmdremove.TabIndex = 9
        Me.cmdremove.Text = "Update"
        Me.cmdremove.UseVisualStyleBackColor = False
        '
        'lblchasisno
        '
        Me.lblchasisno.AutoSize = True
        Me.lblchasisno.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchasisno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblchasisno.Location = New System.Drawing.Point(19, 228)
        Me.lblchasisno.Name = "lblchasisno"
        Me.lblchasisno.Size = New System.Drawing.Size(93, 22)
        Me.lblchasisno.TabIndex = 4
        Me.lblchasisno.Text = "Chasis No:"
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdsave.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdsave.Location = New System.Drawing.Point(106, 387)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(68, 31)
        Me.cmdsave.TabIndex = 8
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdnew
        '
        Me.cmdnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdnew.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdnew.Location = New System.Drawing.Point(21, 387)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(64, 31)
        Me.cmdnew.TabIndex = 7
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarIDDataGridViewTextBoxColumn, Me.RegistrationNoDataGridViewTextBoxColumn, Me.CarModelDataGridViewTextBoxColumn, Me.ChassisNoDataGridViewTextBoxColumn, Me.CarTypeIdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblCarBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(577, 178)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 393)
        Me.DataGridView1.TabIndex = 32
        '
        'CarIDDataGridViewTextBoxColumn
        '
        Me.CarIDDataGridViewTextBoxColumn.DataPropertyName = "CarID"
        Me.CarIDDataGridViewTextBoxColumn.HeaderText = "CarID"
        Me.CarIDDataGridViewTextBoxColumn.Name = "CarIDDataGridViewTextBoxColumn"
        '
        'RegistrationNoDataGridViewTextBoxColumn
        '
        Me.RegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNo"
        Me.RegistrationNoDataGridViewTextBoxColumn.HeaderText = "RegistrationNo"
        Me.RegistrationNoDataGridViewTextBoxColumn.Name = "RegistrationNoDataGridViewTextBoxColumn"
        '
        'CarModelDataGridViewTextBoxColumn
        '
        Me.CarModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel"
        Me.CarModelDataGridViewTextBoxColumn.HeaderText = "CarModel"
        Me.CarModelDataGridViewTextBoxColumn.Name = "CarModelDataGridViewTextBoxColumn"
        '
        'ChassisNoDataGridViewTextBoxColumn
        '
        Me.ChassisNoDataGridViewTextBoxColumn.DataPropertyName = "ChassisNo"
        Me.ChassisNoDataGridViewTextBoxColumn.HeaderText = "ChassisNo"
        Me.ChassisNoDataGridViewTextBoxColumn.Name = "ChassisNoDataGridViewTextBoxColumn"
        '
        'CarTypeIdDataGridViewTextBoxColumn
        '
        Me.CarTypeIdDataGridViewTextBoxColumn.DataPropertyName = "CarTypeId"
        Me.CarTypeIdDataGridViewTextBoxColumn.HeaderText = "CarTypeId"
        Me.CarTypeIdDataGridViewTextBoxColumn.Name = "CarTypeIdDataGridViewTextBoxColumn"
        '
        'TblCarBindingSource
        '
        Me.TblCarBindingSource.DataMember = "tblCar"
        Me.TblCarBindingSource.DataSource = Me.Cab_BookingDataSet5
        '
        'Cab_BookingDataSet5
        '
        Me.Cab_BookingDataSet5.DataSetName = "Cab_BookingDataSet5"
        Me.Cab_BookingDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCarTableAdapter
        '
        Me.TblCarTableAdapter.ClearBeforeFill = True
        '
        'car_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(1075, 593)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "car_info"
        Me.Text = "car_info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtregistrationno As System.Windows.Forms.TextBox
    Friend WithEvents txtchasisno As System.Windows.Forms.TextBox
    Friend WithEvents txtcarmodel As System.Windows.Forms.TextBox
    Friend WithEvents txtcarid As System.Windows.Forms.TextBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents lblcartypeid As System.Windows.Forms.Label
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents lblcarid As System.Windows.Forms.Label
    Friend WithEvents lblregistrationno As System.Windows.Forms.Label
    Friend WithEvents lblcarmodel As System.Windows.Forms.Label
    Friend WithEvents cmdremove As System.Windows.Forms.Button
    Friend WithEvents lblchasisno As System.Windows.Forms.Label
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cab_BookingDataSet5 As mycab.Cab_BookingDataSet5
    Friend WithEvents TblCarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCarTableAdapter As mycab.Cab_BookingDataSet5TableAdapters.tblCarTableAdapter
    Friend WithEvents CarIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChassisNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarTypeIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
