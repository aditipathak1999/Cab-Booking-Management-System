<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enquiry_info
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblsearch = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.cmdclose = New System.Windows.Forms.Button
        Me.cmdreport = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.txtdestination = New System.Windows.Forms.TextBox
        Me.txtjourneysource = New System.Windows.Forms.TextBox
        Me.txtrequirements = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.txtcustomername = New System.Windows.Forms.TextBox
        Me.txtenquiryid = New System.Windows.Forms.TextBox
        Me.lbldate = New System.Windows.Forms.Label
        Me.lbljourneydate = New System.Windows.Forms.Label
        Me.lbljourneydestination = New System.Windows.Forms.Label
        Me.lbljourneysource = New System.Windows.Forms.Label
        Me.lblrequirements = New System.Windows.Forms.Label
        Me.lblcontactno = New System.Windows.Forms.Label
        Me.lblcustomername = New System.Windows.Forms.Label
        Me.lblenquiryid = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.EnquiryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EnquiryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RequirementDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JourneySourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JourneyDestinationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JourneyDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblEnquiryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet7 = New mycab.Cab_BookingDataSet7
        Me.TblEnquiryTableAdapter = New mycab.Cab_BookingDataSet7TableAdapters.tblEnquiryTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblEnquiryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(423, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enquiry Form"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblsearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 85)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Customer Name:"
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(348, 52)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(56, 19)
        Me.lblsearch.TabIndex = 30
        Me.lblsearch.Text = "Search"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(174, 49)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 22)
        Me.ComboBox1.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.cmdreport)
        Me.GroupBox2.Controls.Add(Me.cmdclear)
        Me.GroupBox2.Controls.Add(Me.cmdupdate)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdnew)
        Me.GroupBox2.Controls.Add(Me.txtdestination)
        Me.GroupBox2.Controls.Add(Me.txtjourneysource)
        Me.GroupBox2.Controls.Add(Me.txtrequirements)
        Me.GroupBox2.Controls.Add(Me.txtcontactno)
        Me.GroupBox2.Controls.Add(Me.txtcustomername)
        Me.GroupBox2.Controls.Add(Me.txtenquiryid)
        Me.GroupBox2.Controls.Add(Me.lbldate)
        Me.GroupBox2.Controls.Add(Me.lbljourneydate)
        Me.GroupBox2.Controls.Add(Me.lbljourneydestination)
        Me.GroupBox2.Controls.Add(Me.lbljourneysource)
        Me.GroupBox2.Controls.Add(Me.lblrequirements)
        Me.GroupBox2.Controls.Add(Me.lblcontactno)
        Me.GroupBox2.Controls.Add(Me.lblcustomername)
        Me.GroupBox2.Controls.Add(Me.lblenquiryid)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(580, 410)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(352, 42)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(168, 22)
        Me.DateTimePicker1.TabIndex = 28
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(163, 277)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(165, 22)
        Me.DateTimePicker2.TabIndex = 29
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(163, 277)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 23)
        Me.TextBox2.TabIndex = 31
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(352, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 30
        Me.TextBox1.Visible = False
        '
        'cmdclose
        '
        Me.cmdclose.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.Location = New System.Drawing.Point(471, 350)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(69, 32)
        Me.cmdclose.TabIndex = 26
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = True
        '
        'cmdreport
        '
        Me.cmdreport.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreport.Location = New System.Drawing.Point(361, 349)
        Me.cmdreport.Name = "cmdreport"
        Me.cmdreport.Size = New System.Drawing.Size(82, 32)
        Me.cmdreport.TabIndex = 25
        Me.cmdreport.Text = "Report"
        Me.cmdreport.UseVisualStyleBackColor = True
        '
        'cmdclear
        '
        Me.cmdclear.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.Location = New System.Drawing.Point(274, 350)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(68, 32)
        Me.cmdclear.TabIndex = 24
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.UseVisualStyleBackColor = True
        '
        'cmdupdate
        '
        Me.cmdupdate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.Location = New System.Drawing.Point(163, 349)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(89, 33)
        Me.cmdupdate.TabIndex = 21
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(85, 349)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(57, 33)
        Me.cmdsave.TabIndex = 20
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdnew
        '
        Me.cmdnew.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.Location = New System.Drawing.Point(10, 349)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(57, 33)
        Me.cmdnew.TabIndex = 2
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = True
        '
        'txtdestination
        '
        Me.txtdestination.BackColor = System.Drawing.Color.White
        Me.txtdestination.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdestination.Location = New System.Drawing.Point(163, 232)
        Me.txtdestination.Name = "txtdestination"
        Me.txtdestination.Size = New System.Drawing.Size(100, 23)
        Me.txtdestination.TabIndex = 17
        '
        'txtjourneysource
        '
        Me.txtjourneysource.BackColor = System.Drawing.Color.White
        Me.txtjourneysource.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjourneysource.Location = New System.Drawing.Point(163, 198)
        Me.txtjourneysource.Name = "txtjourneysource"
        Me.txtjourneysource.Size = New System.Drawing.Size(100, 23)
        Me.txtjourneysource.TabIndex = 16
        '
        'txtrequirements
        '
        Me.txtrequirements.BackColor = System.Drawing.Color.White
        Me.txtrequirements.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrequirements.Location = New System.Drawing.Point(163, 158)
        Me.txtrequirements.Name = "txtrequirements"
        Me.txtrequirements.Size = New System.Drawing.Size(100, 23)
        Me.txtrequirements.TabIndex = 15
        '
        'txtcontactno
        '
        Me.txtcontactno.BackColor = System.Drawing.Color.White
        Me.txtcontactno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.Location = New System.Drawing.Point(163, 120)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(100, 23)
        Me.txtcontactno.TabIndex = 14
        '
        'txtcustomername
        '
        Me.txtcustomername.BackColor = System.Drawing.Color.White
        Me.txtcustomername.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomername.Location = New System.Drawing.Point(163, 79)
        Me.txtcustomername.Name = "txtcustomername"
        Me.txtcustomername.Size = New System.Drawing.Size(100, 23)
        Me.txtcustomername.TabIndex = 13
        '
        'txtenquiryid
        '
        Me.txtenquiryid.BackColor = System.Drawing.Color.White
        Me.txtenquiryid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtenquiryid.Location = New System.Drawing.Point(163, 44)
        Me.txtenquiryid.Name = "txtenquiryid"
        Me.txtenquiryid.Size = New System.Drawing.Size(100, 23)
        Me.txtenquiryid.TabIndex = 12
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(301, 44)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(45, 19)
        Me.lbldate.TabIndex = 11
        Me.lbldate.Text = "Date:"
        '
        'lbljourneydate
        '
        Me.lbljourneydate.AutoSize = True
        Me.lbljourneydate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljourneydate.Location = New System.Drawing.Point(6, 285)
        Me.lbljourneydate.Name = "lbljourneydate"
        Me.lbljourneydate.Size = New System.Drawing.Size(104, 19)
        Me.lbljourneydate.TabIndex = 10
        Me.lbljourneydate.Text = "Journey Date:"
        '
        'lbljourneydestination
        '
        Me.lbljourneydestination.AutoSize = True
        Me.lbljourneydestination.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljourneydestination.Location = New System.Drawing.Point(6, 232)
        Me.lbljourneydestination.Name = "lbljourneydestination"
        Me.lbljourneydestination.Size = New System.Drawing.Size(151, 19)
        Me.lbljourneydestination.TabIndex = 9
        Me.lbljourneydestination.Text = "Journey Destination:"
        '
        'lbljourneysource
        '
        Me.lbljourneysource.AutoSize = True
        Me.lbljourneysource.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljourneysource.Location = New System.Drawing.Point(6, 198)
        Me.lbljourneysource.Name = "lbljourneysource"
        Me.lbljourneysource.Size = New System.Drawing.Size(120, 19)
        Me.lbljourneysource.TabIndex = 8
        Me.lbljourneysource.Text = "Journey Source:"
        '
        'lblrequirements
        '
        Me.lblrequirements.AutoSize = True
        Me.lblrequirements.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrequirements.Location = New System.Drawing.Point(6, 160)
        Me.lblrequirements.Name = "lblrequirements"
        Me.lblrequirements.Size = New System.Drawing.Size(110, 19)
        Me.lblrequirements.TabIndex = 7
        Me.lblrequirements.Text = "Requirements:"
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontactno.Location = New System.Drawing.Point(6, 122)
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(89, 19)
        Me.lblcontactno.TabIndex = 6
        Me.lblcontactno.Text = "Contact No:"
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.Location = New System.Drawing.Point(6, 81)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(124, 19)
        Me.lblcustomername.TabIndex = 5
        Me.lblcustomername.Text = "Customer Name:"
        '
        'lblenquiryid
        '
        Me.lblenquiryid.AutoSize = True
        Me.lblenquiryid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenquiryid.Location = New System.Drawing.Point(6, 44)
        Me.lblenquiryid.Name = "lblenquiryid"
        Me.lblenquiryid.Size = New System.Drawing.Size(88, 19)
        Me.lblenquiryid.TabIndex = 4
        Me.lblenquiryid.Text = "Enquiry ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EnquiryIDDataGridViewTextBoxColumn, Me.EnquiryDateDataGridViewTextBoxColumn, Me.RequirementDataGridViewTextBoxColumn, Me.JourneySourceDataGridViewTextBoxColumn, Me.JourneyDestinationDataGridViewTextBoxColumn, Me.JourneyDateDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblEnquiryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(620, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 347)
        Me.DataGridView1.TabIndex = 4
        '
        'EnquiryIDDataGridViewTextBoxColumn
        '
        Me.EnquiryIDDataGridViewTextBoxColumn.DataPropertyName = "EnquiryID"
        Me.EnquiryIDDataGridViewTextBoxColumn.HeaderText = "EnquiryID"
        Me.EnquiryIDDataGridViewTextBoxColumn.Name = "EnquiryIDDataGridViewTextBoxColumn"
        '
        'EnquiryDateDataGridViewTextBoxColumn
        '
        Me.EnquiryDateDataGridViewTextBoxColumn.DataPropertyName = "EnquiryDate"
        Me.EnquiryDateDataGridViewTextBoxColumn.HeaderText = "EnquiryDate"
        Me.EnquiryDateDataGridViewTextBoxColumn.Name = "EnquiryDateDataGridViewTextBoxColumn"
        '
        'RequirementDataGridViewTextBoxColumn
        '
        Me.RequirementDataGridViewTextBoxColumn.DataPropertyName = "Requirement"
        Me.RequirementDataGridViewTextBoxColumn.HeaderText = "Requirement"
        Me.RequirementDataGridViewTextBoxColumn.Name = "RequirementDataGridViewTextBoxColumn"
        '
        'JourneySourceDataGridViewTextBoxColumn
        '
        Me.JourneySourceDataGridViewTextBoxColumn.DataPropertyName = "JourneySource"
        Me.JourneySourceDataGridViewTextBoxColumn.HeaderText = "JourneySource"
        Me.JourneySourceDataGridViewTextBoxColumn.Name = "JourneySourceDataGridViewTextBoxColumn"
        '
        'JourneyDestinationDataGridViewTextBoxColumn
        '
        Me.JourneyDestinationDataGridViewTextBoxColumn.DataPropertyName = "JourneyDestination"
        Me.JourneyDestinationDataGridViewTextBoxColumn.HeaderText = "JourneyDestination"
        Me.JourneyDestinationDataGridViewTextBoxColumn.Name = "JourneyDestinationDataGridViewTextBoxColumn"
        '
        'JourneyDateDataGridViewTextBoxColumn
        '
        Me.JourneyDateDataGridViewTextBoxColumn.DataPropertyName = "JourneyDate"
        Me.JourneyDateDataGridViewTextBoxColumn.HeaderText = "JourneyDate"
        Me.JourneyDateDataGridViewTextBoxColumn.Name = "JourneyDateDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        '
        'TblEnquiryBindingSource
        '
        Me.TblEnquiryBindingSource.DataMember = "tblEnquiry"
        Me.TblEnquiryBindingSource.DataSource = Me.Cab_BookingDataSet7
        '
        'Cab_BookingDataSet7
        '
        Me.Cab_BookingDataSet7.DataSetName = "Cab_BookingDataSet7"
        Me.Cab_BookingDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblEnquiryTableAdapter
        '
        Me.TblEnquiryTableAdapter.ClearBeforeFill = True
        '
        'enquiry_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1282, 605)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "enquiry_info"
        Me.Text = "enquiry_info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblEnquiryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdreport As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents txtdestination As System.Windows.Forms.TextBox
    Friend WithEvents txtjourneysource As System.Windows.Forms.TextBox
    Friend WithEvents txtrequirements As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtcustomername As System.Windows.Forms.TextBox
    Friend WithEvents txtenquiryid As System.Windows.Forms.TextBox
    Friend WithEvents lbldate As System.Windows.Forms.Label
    Friend WithEvents lbljourneydate As System.Windows.Forms.Label
    Friend WithEvents lbljourneydestination As System.Windows.Forms.Label
    Friend WithEvents lbljourneysource As System.Windows.Forms.Label
    Friend WithEvents lblrequirements As System.Windows.Forms.Label
    Friend WithEvents lblcontactno As System.Windows.Forms.Label
    Friend WithEvents lblcustomername As System.Windows.Forms.Label
    Friend WithEvents lblenquiryid As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cab_BookingDataSet7 As mycab.Cab_BookingDataSet7
    Friend WithEvents TblEnquiryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblEnquiryTableAdapter As mycab.Cab_BookingDataSet7TableAdapters.tblEnquiryTableAdapter
    Friend WithEvents EnquiryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnquiryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RequirementDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JourneySourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JourneyDestinationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JourneyDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
