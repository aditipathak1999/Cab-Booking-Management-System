<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_info
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtenquiryid = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdreport = New System.Windows.Forms.Button
        Me.lblenquiryid = New System.Windows.Forms.Label
        Me.lblgender = New System.Windows.Forms.Label
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtcustomerid = New System.Windows.Forms.TextBox
        Me.cmdclose = New System.Windows.Forms.Button
        Me.lbladdress = New System.Windows.Forms.Label
        Me.cmdclear = New System.Windows.Forms.Button
        Me.lblcustomerid = New System.Windows.Forms.Label
        Me.lblcontactno = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerPhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet1 = New mycab.Cab_BookingDataSet1
        Me.TblCustomerTableAdapter = New mycab.Cab_BookingDataSet1TableAdapters.tblCustomerTableAdapter
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.txtenquiryid)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmdreport)
        Me.GroupBox2.Controls.Add(Me.lblenquiryid)
        Me.GroupBox2.Controls.Add(Me.lblgender)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.txtcontactno)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.txtcustomerid)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.lbladdress)
        Me.GroupBox2.Controls.Add(Me.cmdclear)
        Me.GroupBox2.Controls.Add(Me.lblcustomerid)
        Me.GroupBox2.Controls.Add(Me.lblcontactno)
        Me.GroupBox2.Controls.Add(Me.lblname)
        Me.GroupBox2.Controls.Add(Me.cmdupdate)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdnew)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 144)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(573, 405)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(392, 250)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 39)
        Me.TextBox1.TabIndex = 47
        Me.TextBox1.Visible = False
        '
        'txtenquiryid
        '
        Me.txtenquiryid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtenquiryid.Location = New System.Drawing.Point(161, 55)
        Me.txtenquiryid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtenquiryid.Name = "txtenquiryid"
        Me.txtenquiryid.Size = New System.Drawing.Size(276, 23)
        Me.txtenquiryid.TabIndex = 48
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Panel1.Location = New System.Drawing.Point(175, 253)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 43)
        Me.Panel1.TabIndex = 43
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton2.Location = New System.Drawing.Point(114, 13)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(76, 23)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RadioButton1.Location = New System.Drawing.Point(4, 13)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 23)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(444, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "(If enquiry done)"
        '
        'cmdreport
        '
        Me.cmdreport.BackColor = System.Drawing.Color.Plum
        Me.cmdreport.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreport.ForeColor = System.Drawing.Color.Black
        Me.cmdreport.Location = New System.Drawing.Point(381, 349)
        Me.cmdreport.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdreport.Name = "cmdreport"
        Me.cmdreport.Size = New System.Drawing.Size(82, 38)
        Me.cmdreport.TabIndex = 37
        Me.cmdreport.Text = "Report"
        Me.cmdreport.UseVisualStyleBackColor = False
        '
        'lblenquiryid
        '
        Me.lblenquiryid.AutoSize = True
        Me.lblenquiryid.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenquiryid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblenquiryid.Location = New System.Drawing.Point(12, 52)
        Me.lblenquiryid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblenquiryid.Name = "lblenquiryid"
        Me.lblenquiryid.Size = New System.Drawing.Size(104, 22)
        Me.lblenquiryid.TabIndex = 44
        Me.lblenquiryid.Text = "Enquiry ID:"
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblgender.Location = New System.Drawing.Point(12, 260)
        Me.lblgender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(75, 22)
        Me.lblgender.TabIndex = 22
        Me.lblgender.Text = "Gender:"
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(162, 181)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Multiline = True
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(276, 57)
        Me.txtaddress.TabIndex = 35
        '
        'txtcontactno
        '
        Me.txtcontactno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.Location = New System.Drawing.Point(162, 304)
        Me.txtcontactno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(276, 23)
        Me.txtcontactno.TabIndex = 34
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(162, 137)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(276, 23)
        Me.txtname.TabIndex = 32
        '
        'txtcustomerid
        '
        Me.txtcustomerid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomerid.Location = New System.Drawing.Point(162, 97)
        Me.txtcustomerid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcustomerid.Name = "txtcustomerid"
        Me.txtcustomerid.Size = New System.Drawing.Size(276, 23)
        Me.txtcustomerid.TabIndex = 31
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.Plum
        Me.cmdclose.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.Black
        Me.cmdclose.Location = New System.Drawing.Point(490, 349)
        Me.cmdclose.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 38)
        Me.cmdclose.TabIndex = 30
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = False
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbladdress.Location = New System.Drawing.Point(12, 198)
        Me.lbladdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(82, 22)
        Me.lbladdress.TabIndex = 23
        Me.lbladdress.Text = "Address:"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.Color.Plum
        Me.cmdclear.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.Black
        Me.cmdclear.Location = New System.Drawing.Point(289, 350)
        Me.cmdclear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(72, 36)
        Me.cmdclear.TabIndex = 29
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.UseVisualStyleBackColor = False
        '
        'lblcustomerid
        '
        Me.lblcustomerid.AutoSize = True
        Me.lblcustomerid.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomerid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcustomerid.Location = New System.Drawing.Point(12, 98)
        Me.lblcustomerid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcustomerid.Name = "lblcustomerid"
        Me.lblcustomerid.Size = New System.Drawing.Size(117, 22)
        Me.lblcustomerid.TabIndex = 19
        Me.lblcustomerid.Text = "Customer ID:"
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontactno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcontactno.Location = New System.Drawing.Point(12, 307)
        Me.lblcontactno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(103, 22)
        Me.lblcontactno.TabIndex = 20
        Me.lblcontactno.Text = "Contact No:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblname.Location = New System.Drawing.Point(12, 139)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(62, 22)
        Me.lblname.TabIndex = 21
        Me.lblname.Text = "Name:"
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.Color.Plum
        Me.cmdupdate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.ForeColor = System.Drawing.Color.Black
        Me.cmdupdate.Location = New System.Drawing.Point(175, 349)
        Me.cmdupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(88, 38)
        Me.cmdupdate.TabIndex = 26
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Plum
        Me.cmdsave.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.Black
        Me.cmdsave.Location = New System.Drawing.Point(92, 349)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(59, 38)
        Me.cmdsave.TabIndex = 25
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdnew
        '
        Me.cmdnew.BackColor = System.Drawing.Color.Plum
        Me.cmdnew.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.ForeColor = System.Drawing.Color.Black
        Me.cmdnew.Location = New System.Drawing.Point(12, 349)
        Me.cmdnew.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(62, 38)
        Me.cmdnew.TabIndex = 24
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(7, 48)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(481, 88)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(227, 53)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(214, 26)
        Me.ComboBox2.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(79, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Customer Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(302, 3)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(425, 44)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Customer Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.CustomerAddressDataGridViewTextBoxColumn, Me.CustomerGenderDataGridViewTextBoxColumn, Me.CustomerPhoneNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblCustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(600, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 368)
        Me.DataGridView1.TabIndex = 23
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'CustomerAddressDataGridViewTextBoxColumn
        '
        Me.CustomerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress"
        Me.CustomerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress"
        Me.CustomerAddressDataGridViewTextBoxColumn.Name = "CustomerAddressDataGridViewTextBoxColumn"
        '
        'CustomerGenderDataGridViewTextBoxColumn
        '
        Me.CustomerGenderDataGridViewTextBoxColumn.DataPropertyName = "CustomerGender"
        Me.CustomerGenderDataGridViewTextBoxColumn.HeaderText = "CustomerGender"
        Me.CustomerGenderDataGridViewTextBoxColumn.Name = "CustomerGenderDataGridViewTextBoxColumn"
        '
        'CustomerPhoneNoDataGridViewTextBoxColumn
        '
        Me.CustomerPhoneNoDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNo"
        Me.CustomerPhoneNoDataGridViewTextBoxColumn.HeaderText = "CustomerPhoneNo"
        Me.CustomerPhoneNoDataGridViewTextBoxColumn.Name = "CustomerPhoneNoDataGridViewTextBoxColumn"
        '
        'TblCustomerBindingSource
        '
        Me.TblCustomerBindingSource.DataMember = "tblCustomer"
        Me.TblCustomerBindingSource.DataSource = Me.Cab_BookingDataSet1
        '
        'Cab_BookingDataSet1
        '
        Me.Cab_BookingDataSet1.DataSetName = "Cab_BookingDataSet1"
        Me.Cab_BookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCustomerTableAdapter
        '
        Me.TblCustomerTableAdapter.ClearBeforeFill = True
        '
        'customer_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1170, 561)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "customer_info"
        Me.Text = "customer_info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblenquiryid As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents cmdreport As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomerid As System.Windows.Forms.TextBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents lblcustomerid As System.Windows.Forms.Label
    Friend WithEvents lblcontactno As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cab_BookingDataSet1 As mycab.Cab_BookingDataSet1
    Friend WithEvents TblCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCustomerTableAdapter As mycab.Cab_BookingDataSet1TableAdapters.tblCustomerTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerGenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerPhoneNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtenquiryid As System.Windows.Forms.TextBox
End Class
