<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class car_type_info
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtwaitingrate = New System.Windows.Forms.TextBox
        Me.txtnonacrate = New System.Windows.Forms.TextBox
        Me.txtacrate = New System.Windows.Forms.TextBox
        Me.txtcartypeid = New System.Windows.Forms.TextBox
        Me.cmdclose = New System.Windows.Forms.Button
        Me.lblwaitingrate = New System.Windows.Forms.Label
        Me.cmdclear = New System.Windows.Forms.Button
        Me.lblcartypeid = New System.Windows.Forms.Label
        Me.lblcartype = New System.Windows.Forms.Label
        Me.lblacrate = New System.Windows.Forms.Label
        Me.lblnonacrate = New System.Windows.Forms.Label
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CarTypeIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ACRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NonACRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WaitingChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblCarTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet6 = New mycab.Cab_BookingDataSet6
        Me.TblCarTypeTableAdapter = New mycab.Cab_BookingDataSet6TableAdapters.tblCarTypeTableAdapter
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCarTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(416, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Car Type Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.txtwaitingrate)
        Me.GroupBox1.Controls.Add(Me.txtnonacrate)
        Me.GroupBox1.Controls.Add(Me.txtacrate)
        Me.GroupBox1.Controls.Add(Me.txtcartypeid)
        Me.GroupBox1.Controls.Add(Me.cmdclose)
        Me.GroupBox1.Controls.Add(Me.lblwaitingrate)
        Me.GroupBox1.Controls.Add(Me.cmdclear)
        Me.GroupBox1.Controls.Add(Me.lblcartypeid)
        Me.GroupBox1.Controls.Add(Me.lblcartype)
        Me.GroupBox1.Controls.Add(Me.lblacrate)
        Me.GroupBox1.Controls.Add(Me.lblnonacrate)
        Me.GroupBox1.Controls.Add(Me.cmdsave)
        Me.GroupBox1.Controls.Add(Me.cmdnew)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(537, 461)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"luxary", "mini", "micro", "auto"})
        Me.ComboBox1.Location = New System.Drawing.Point(172, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 26)
        Me.ComboBox1.TabIndex = 19
        '
        'txtwaitingrate
        '
        Me.txtwaitingrate.BackColor = System.Drawing.Color.White
        Me.txtwaitingrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwaitingrate.Location = New System.Drawing.Point(172, 278)
        Me.txtwaitingrate.Name = "txtwaitingrate"
        Me.txtwaitingrate.Size = New System.Drawing.Size(208, 27)
        Me.txtwaitingrate.TabIndex = 18
        '
        'txtnonacrate
        '
        Me.txtnonacrate.BackColor = System.Drawing.Color.White
        Me.txtnonacrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnonacrate.Location = New System.Drawing.Point(172, 228)
        Me.txtnonacrate.Name = "txtnonacrate"
        Me.txtnonacrate.Size = New System.Drawing.Size(208, 27)
        Me.txtnonacrate.TabIndex = 17
        '
        'txtacrate
        '
        Me.txtacrate.BackColor = System.Drawing.Color.White
        Me.txtacrate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtacrate.Location = New System.Drawing.Point(172, 170)
        Me.txtacrate.Name = "txtacrate"
        Me.txtacrate.Size = New System.Drawing.Size(208, 27)
        Me.txtacrate.TabIndex = 16
        '
        'txtcartypeid
        '
        Me.txtcartypeid.BackColor = System.Drawing.Color.White
        Me.txtcartypeid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcartypeid.Location = New System.Drawing.Point(172, 70)
        Me.txtcartypeid.Name = "txtcartypeid"
        Me.txtcartypeid.Size = New System.Drawing.Size(208, 27)
        Me.txtcartypeid.TabIndex = 14
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdclose.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdclose.Location = New System.Drawing.Point(350, 385)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 31)
        Me.cmdclose.TabIndex = 13
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = False
        '
        'lblwaitingrate
        '
        Me.lblwaitingrate.AutoSize = True
        Me.lblwaitingrate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaitingrate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblwaitingrate.Location = New System.Drawing.Point(19, 278)
        Me.lblwaitingrate.Name = "lblwaitingrate"
        Me.lblwaitingrate.Size = New System.Drawing.Size(117, 22)
        Me.lblwaitingrate.TabIndex = 5
        Me.lblwaitingrate.Text = "Waiting Rate:"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdclear.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdclear.Location = New System.Drawing.Point(241, 385)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(75, 31)
        Me.cmdclear.TabIndex = 12
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.UseVisualStyleBackColor = False
        '
        'lblcartypeid
        '
        Me.lblcartypeid.AutoSize = True
        Me.lblcartypeid.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartypeid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcartypeid.Location = New System.Drawing.Point(19, 70)
        Me.lblcartypeid.Name = "lblcartypeid"
        Me.lblcartypeid.Size = New System.Drawing.Size(111, 22)
        Me.lblcartypeid.TabIndex = 1
        Me.lblcartypeid.Text = "Car Type ID:"
        '
        'lblcartype
        '
        Me.lblcartype.AutoSize = True
        Me.lblcartype.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartype.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcartype.Location = New System.Drawing.Point(19, 122)
        Me.lblcartype.Name = "lblcartype"
        Me.lblcartype.Size = New System.Drawing.Size(88, 22)
        Me.lblcartype.TabIndex = 2
        Me.lblcartype.Text = "Car Type:"
        '
        'lblacrate
        '
        Me.lblacrate.AutoSize = True
        Me.lblacrate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacrate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblacrate.Location = New System.Drawing.Point(19, 173)
        Me.lblacrate.Name = "lblacrate"
        Me.lblacrate.Size = New System.Drawing.Size(78, 22)
        Me.lblacrate.TabIndex = 3
        Me.lblacrate.Text = "AC Rate:"
        '
        'lblnonacrate
        '
        Me.lblnonacrate.AutoSize = True
        Me.lblnonacrate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnonacrate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblnonacrate.Location = New System.Drawing.Point(19, 228)
        Me.lblnonacrate.Name = "lblnonacrate"
        Me.lblnonacrate.Size = New System.Drawing.Size(116, 22)
        Me.lblnonacrate.TabIndex = 4
        Me.lblnonacrate.Text = "Non AC Rate:"
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdsave.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdsave.Location = New System.Drawing.Point(135, 385)
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
        Me.cmdnew.Location = New System.Drawing.Point(38, 385)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CarTypeIdDataGridViewTextBoxColumn, Me.CarTypeDataGridViewTextBoxColumn, Me.ACRateDataGridViewTextBoxColumn, Me.NonACRateDataGridViewTextBoxColumn, Me.WaitingChargesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblCarTypeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(574, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(543, 404)
        Me.DataGridView1.TabIndex = 8
        '
        'CarTypeIdDataGridViewTextBoxColumn
        '
        Me.CarTypeIdDataGridViewTextBoxColumn.DataPropertyName = "CarTypeId"
        Me.CarTypeIdDataGridViewTextBoxColumn.HeaderText = "CarTypeId"
        Me.CarTypeIdDataGridViewTextBoxColumn.Name = "CarTypeIdDataGridViewTextBoxColumn"
        '
        'CarTypeDataGridViewTextBoxColumn
        '
        Me.CarTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType"
        Me.CarTypeDataGridViewTextBoxColumn.HeaderText = "CarType"
        Me.CarTypeDataGridViewTextBoxColumn.Name = "CarTypeDataGridViewTextBoxColumn"
        '
        'ACRateDataGridViewTextBoxColumn
        '
        Me.ACRateDataGridViewTextBoxColumn.DataPropertyName = "ACRate"
        Me.ACRateDataGridViewTextBoxColumn.HeaderText = "ACRate"
        Me.ACRateDataGridViewTextBoxColumn.Name = "ACRateDataGridViewTextBoxColumn"
        '
        'NonACRateDataGridViewTextBoxColumn
        '
        Me.NonACRateDataGridViewTextBoxColumn.DataPropertyName = "NonACRate"
        Me.NonACRateDataGridViewTextBoxColumn.HeaderText = "NonACRate"
        Me.NonACRateDataGridViewTextBoxColumn.Name = "NonACRateDataGridViewTextBoxColumn"
        '
        'WaitingChargesDataGridViewTextBoxColumn
        '
        Me.WaitingChargesDataGridViewTextBoxColumn.DataPropertyName = "WaitingCharges"
        Me.WaitingChargesDataGridViewTextBoxColumn.HeaderText = "WaitingCharges"
        Me.WaitingChargesDataGridViewTextBoxColumn.Name = "WaitingChargesDataGridViewTextBoxColumn"
        '
        'TblCarTypeBindingSource
        '
        Me.TblCarTypeBindingSource.DataMember = "tblCarType"
        Me.TblCarTypeBindingSource.DataSource = Me.Cab_BookingDataSet6
        '
        'Cab_BookingDataSet6
        '
        Me.Cab_BookingDataSet6.DataSetName = "Cab_BookingDataSet6"
        Me.Cab_BookingDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCarTypeTableAdapter
        '
        Me.TblCarTypeTableAdapter.ClearBeforeFill = True
        '
        'car_type_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(1156, 532)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "car_type_info"
        Me.Text = "car_type_info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCarTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtwaitingrate As System.Windows.Forms.TextBox
    Friend WithEvents txtnonacrate As System.Windows.Forms.TextBox
    Friend WithEvents txtacrate As System.Windows.Forms.TextBox
    Friend WithEvents txtcartypeid As System.Windows.Forms.TextBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents lblwaitingrate As System.Windows.Forms.Label
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents lblcartypeid As System.Windows.Forms.Label
    Friend WithEvents lblcartype As System.Windows.Forms.Label
    Friend WithEvents lblacrate As System.Windows.Forms.Label
    Friend WithEvents lblnonacrate As System.Windows.Forms.Label
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cab_BookingDataSet6 As mycab.Cab_BookingDataSet6
    Friend WithEvents TblCarTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCarTypeTableAdapter As mycab.Cab_BookingDataSet6TableAdapters.tblCarTypeTableAdapter
    Friend WithEvents CarTypeIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NonACRateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WaitingChargesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
