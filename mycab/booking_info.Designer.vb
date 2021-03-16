<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booking_info
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
        Me.TblBookingBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet3 = New mycab.Cab_BookingDataSet3
        Me.TblBookingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet2 = New mycab.Cab_BookingDataSet2
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.lblcustomername = New System.Windows.Forms.Label
        Me.txtdroppoint = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.lblbookingdate = New System.Windows.Forms.Label
        Me.lbljourneydate = New System.Windows.Forms.Label
        Me.txtdriverid = New System.Windows.Forms.TextBox
        Me.txtcartype = New System.Windows.Forms.TextBox
        Me.lbldriverid = New System.Windows.Forms.Label
        Me.lblcartype = New System.Windows.Forms.Label
        Me.lblcarid = New System.Windows.Forms.Label
        Me.txtpickuppoint = New System.Windows.Forms.TextBox
        Me.txtrateperkm = New System.Windows.Forms.TextBox
        Me.txtkmexpected = New System.Windows.Forms.TextBox
        Me.txtpickuptime = New System.Windows.Forms.TextBox
        Me.txtbookingid = New System.Windows.Forms.TextBox
        Me.lblrateperkm = New System.Windows.Forms.Label
        Me.lblkmexpected = New System.Windows.Forms.Label
        Me.lblacnonac = New System.Windows.Forms.Label
        Me.lblpickuptime = New System.Windows.Forms.Label
        Me.lbldroppoint = New System.Windows.Forms.Label
        Me.lblpickuppoint = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtjourneydate = New System.Windows.Forms.TextBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.txtbookingdate = New System.Windows.Forms.TextBox
        Me.lblbookingid = New System.Windows.Forms.Label
        Me.cmdclose = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblsearch = New System.Windows.Forms.Label
        Me.TblbookinginfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblBookingTableAdapter = New mycab.Cab_BookingDataSet2TableAdapters.tblBookingTableAdapter
        Me.TblBookingTableAdapter1 = New mycab.Cab_BookingDataSet3TableAdapters.tblBookingTableAdapter
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BookingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PickupPointDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DropPointDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JourneyDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PickupTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ACNONACDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KmExpectedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DriverIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblBookingBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet11 = New mycab.Cab_BookingDataSet11
        Me.TblBookingTableAdapter2 = New mycab.Cab_BookingDataSet11TableAdapters.tblBookingTableAdapter
        CType(Me.TblBookingBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBookingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblbookinginfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBookingBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblBookingBindingSource1
        '
        Me.TblBookingBindingSource1.DataMember = "tblBooking"
        Me.TblBookingBindingSource1.DataSource = Me.Cab_BookingDataSet3
        '
        'Cab_BookingDataSet3
        '
        Me.Cab_BookingDataSet3.DataSetName = "Cab_BookingDataSet3"
        Me.Cab_BookingDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBookingBindingSource
        '
        Me.TblBookingBindingSource.DataMember = "tblBooking"
        Me.TblBookingBindingSource.DataSource = Me.Cab_BookingDataSet2
        '
        'Cab_BookingDataSet2
        '
        Me.Cab_BookingDataSet2.DataSetName = "Cab_BookingDataSet2"
        Me.Cab_BookingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(396, 132)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(124, 26)
        Me.ComboBox3.TabIndex = 77
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(396, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 26)
        Me.ComboBox1.TabIndex = 75
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.ForeColor = System.Drawing.Color.Red
        Me.lblcustomername.Location = New System.Drawing.Point(272, 88)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(124, 19)
        Me.lblcustomername.TabIndex = 71
        Me.lblcustomername.Text = "Customer Name:"
        '
        'txtdroppoint
        '
        Me.txtdroppoint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdroppoint.Location = New System.Drawing.Point(110, 109)
        Me.txtdroppoint.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdroppoint.Name = "txtdroppoint"
        Me.txtdroppoint.Size = New System.Drawing.Size(124, 23)
        Me.txtdroppoint.TabIndex = 72
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButton3)
        Me.Panel2.Controls.Add(Me.RadioButton4)
        Me.Panel2.Location = New System.Drawing.Point(110, 175)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(151, 43)
        Me.Panel2.TabIndex = 74
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.Red
        Me.RadioButton3.Location = New System.Drawing.Point(64, 8)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(83, 23)
        Me.RadioButton3.TabIndex = 14
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "NON-AC"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.Red
        Me.RadioButton4.Location = New System.Drawing.Point(4, 8)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(46, 23)
        Me.RadioButton4.TabIndex = 13
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "AC"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'lblbookingdate
        '
        Me.lblbookingdate.AutoSize = True
        Me.lblbookingdate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookingdate.ForeColor = System.Drawing.Color.Red
        Me.lblbookingdate.Location = New System.Drawing.Point(271, 37)
        Me.lblbookingdate.Name = "lblbookingdate"
        Me.lblbookingdate.Size = New System.Drawing.Size(106, 19)
        Me.lblbookingdate.TabIndex = 70
        Me.lblbookingdate.Text = "Booking Date:"
        '
        'lbljourneydate
        '
        Me.lbljourneydate.AutoSize = True
        Me.lbljourneydate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljourneydate.ForeColor = System.Drawing.Color.Red
        Me.lbljourneydate.Location = New System.Drawing.Point(273, 273)
        Me.lbljourneydate.Name = "lbljourneydate"
        Me.lbljourneydate.Size = New System.Drawing.Size(104, 19)
        Me.lbljourneydate.TabIndex = 68
        Me.lbljourneydate.Text = "Journey Date:"
        '
        'txtdriverid
        '
        Me.txtdriverid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdriverid.Location = New System.Drawing.Point(397, 231)
        Me.txtdriverid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdriverid.Name = "txtdriverid"
        Me.txtdriverid.Size = New System.Drawing.Size(124, 23)
        Me.txtdriverid.TabIndex = 67
        '
        'txtcartype
        '
        Me.txtcartype.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcartype.Location = New System.Drawing.Point(397, 184)
        Me.txtcartype.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcartype.Name = "txtcartype"
        Me.txtcartype.Size = New System.Drawing.Size(124, 23)
        Me.txtcartype.TabIndex = 64
        '
        'lbldriverid
        '
        Me.lbldriverid.AutoSize = True
        Me.lbldriverid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldriverid.ForeColor = System.Drawing.Color.Red
        Me.lbldriverid.Location = New System.Drawing.Point(278, 235)
        Me.lbldriverid.Name = "lbldriverid"
        Me.lbldriverid.Size = New System.Drawing.Size(78, 19)
        Me.lbldriverid.TabIndex = 59
        Me.lbldriverid.Text = "Driver ID:"
        '
        'lblcartype
        '
        Me.lblcartype.AutoSize = True
        Me.lblcartype.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartype.ForeColor = System.Drawing.Color.Red
        Me.lblcartype.Location = New System.Drawing.Point(278, 184)
        Me.lblcartype.Name = "lblcartype"
        Me.lblcartype.Size = New System.Drawing.Size(75, 19)
        Me.lblcartype.TabIndex = 57
        Me.lblcartype.Text = "Car Type:"
        '
        'lblcarid
        '
        Me.lblcarid.AutoSize = True
        Me.lblcarid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarid.ForeColor = System.Drawing.Color.Red
        Me.lblcarid.Location = New System.Drawing.Point(279, 139)
        Me.lblcarid.Name = "lblcarid"
        Me.lblcarid.Size = New System.Drawing.Size(57, 19)
        Me.lblcarid.TabIndex = 55
        Me.lblcarid.Text = "Car ID:"
        '
        'txtpickuppoint
        '
        Me.txtpickuppoint.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpickuppoint.Location = New System.Drawing.Point(114, 74)
        Me.txtpickuppoint.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpickuppoint.Name = "txtpickuppoint"
        Me.txtpickuppoint.Size = New System.Drawing.Size(124, 23)
        Me.txtpickuppoint.TabIndex = 51
        '
        'txtrateperkm
        '
        Me.txtrateperkm.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrateperkm.Location = New System.Drawing.Point(110, 272)
        Me.txtrateperkm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrateperkm.Name = "txtrateperkm"
        Me.txtrateperkm.Size = New System.Drawing.Size(124, 23)
        Me.txtrateperkm.TabIndex = 50
        '
        'txtkmexpected
        '
        Me.txtkmexpected.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkmexpected.Location = New System.Drawing.Point(110, 231)
        Me.txtkmexpected.Margin = New System.Windows.Forms.Padding(4)
        Me.txtkmexpected.Name = "txtkmexpected"
        Me.txtkmexpected.Size = New System.Drawing.Size(124, 23)
        Me.txtkmexpected.TabIndex = 49
        '
        'txtpickuptime
        '
        Me.txtpickuptime.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpickuptime.Location = New System.Drawing.Point(110, 143)
        Me.txtpickuptime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpickuptime.Name = "txtpickuptime"
        Me.txtpickuptime.Size = New System.Drawing.Size(124, 23)
        Me.txtpickuptime.TabIndex = 47
        '
        'txtbookingid
        '
        Me.txtbookingid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookingid.Location = New System.Drawing.Point(114, 34)
        Me.txtbookingid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbookingid.Name = "txtbookingid"
        Me.txtbookingid.Size = New System.Drawing.Size(124, 23)
        Me.txtbookingid.TabIndex = 45
        '
        'lblrateperkm
        '
        Me.lblrateperkm.AutoSize = True
        Me.lblrateperkm.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrateperkm.ForeColor = System.Drawing.Color.Red
        Me.lblrateperkm.Location = New System.Drawing.Point(3, 276)
        Me.lblrateperkm.Name = "lblrateperkm"
        Me.lblrateperkm.Size = New System.Drawing.Size(107, 19)
        Me.lblrateperkm.TabIndex = 44
        Me.lblrateperkm.Text = "Rate(Per KM):"
        '
        'lblkmexpected
        '
        Me.lblkmexpected.AutoSize = True
        Me.lblkmexpected.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblkmexpected.ForeColor = System.Drawing.Color.Red
        Me.lblkmexpected.Location = New System.Drawing.Point(3, 231)
        Me.lblkmexpected.Name = "lblkmexpected"
        Me.lblkmexpected.Size = New System.Drawing.Size(103, 19)
        Me.lblkmexpected.TabIndex = 43
        Me.lblkmexpected.Text = "KM Expected:"
        '
        'lblacnonac
        '
        Me.lblacnonac.AutoSize = True
        Me.lblacnonac.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblacnonac.ForeColor = System.Drawing.Color.Red
        Me.lblacnonac.Location = New System.Drawing.Point(7, 183)
        Me.lblacnonac.Name = "lblacnonac"
        Me.lblacnonac.Size = New System.Drawing.Size(88, 19)
        Me.lblacnonac.TabIndex = 42
        Me.lblacnonac.Text = "AC/NonAC:"
        '
        'lblpickuptime
        '
        Me.lblpickuptime.AutoSize = True
        Me.lblpickuptime.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpickuptime.ForeColor = System.Drawing.Color.Red
        Me.lblpickuptime.Location = New System.Drawing.Point(7, 147)
        Me.lblpickuptime.Name = "lblpickuptime"
        Me.lblpickuptime.Size = New System.Drawing.Size(93, 19)
        Me.lblpickuptime.TabIndex = 41
        Me.lblpickuptime.Text = "Pickup time:"
        '
        'lbldroppoint
        '
        Me.lbldroppoint.AutoSize = True
        Me.lbldroppoint.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldroppoint.ForeColor = System.Drawing.Color.Red
        Me.lbldroppoint.Location = New System.Drawing.Point(7, 113)
        Me.lbldroppoint.Name = "lbldroppoint"
        Me.lbldroppoint.Size = New System.Drawing.Size(89, 19)
        Me.lbldroppoint.TabIndex = 40
        Me.lbldroppoint.Text = "Drop Point:"
        '
        'lblpickuppoint
        '
        Me.lblpickuppoint.AutoSize = True
        Me.lblpickuppoint.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpickuppoint.ForeColor = System.Drawing.Color.Red
        Me.lblpickuppoint.Location = New System.Drawing.Point(7, 74)
        Me.lblpickuppoint.Name = "lblpickuppoint"
        Me.lblpickuppoint.Size = New System.Drawing.Size(99, 19)
        Me.lblpickuppoint.TabIndex = 39
        Me.lblpickuppoint.Text = "Pickup Point:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 44)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Booking Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.txtjourneydate)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.txtbookingdate)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.txtdroppoint)
        Me.GroupBox2.Controls.Add(Me.lblcustomername)
        Me.GroupBox2.Controls.Add(Me.lblbookingdate)
        Me.GroupBox2.Controls.Add(Me.lbljourneydate)
        Me.GroupBox2.Controls.Add(Me.txtdriverid)
        Me.GroupBox2.Controls.Add(Me.txtcartype)
        Me.GroupBox2.Controls.Add(Me.lbldriverid)
        Me.GroupBox2.Controls.Add(Me.lblcartype)
        Me.GroupBox2.Controls.Add(Me.lblcarid)
        Me.GroupBox2.Controls.Add(Me.txtpickuppoint)
        Me.GroupBox2.Controls.Add(Me.txtrateperkm)
        Me.GroupBox2.Controls.Add(Me.txtkmexpected)
        Me.GroupBox2.Controls.Add(Me.txtpickuptime)
        Me.GroupBox2.Controls.Add(Me.txtbookingid)
        Me.GroupBox2.Controls.Add(Me.lblrateperkm)
        Me.GroupBox2.Controls.Add(Me.lblkmexpected)
        Me.GroupBox2.Controls.Add(Me.lblacnonac)
        Me.GroupBox2.Controls.Add(Me.lblpickuptime)
        Me.GroupBox2.Controls.Add(Me.lbldroppoint)
        Me.GroupBox2.Controls.Add(Me.lblpickuppoint)
        Me.GroupBox2.Controls.Add(Me.lblbookingid)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.btnclear)
        Me.GroupBox2.Controls.Add(Me.cmdupdate)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdnew)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 158)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(569, 456)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(397, 273)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(164, 23)
        Me.DateTimePicker1.TabIndex = 31
        '
        'txtjourneydate
        '
        Me.txtjourneydate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjourneydate.Location = New System.Drawing.Point(397, 273)
        Me.txtjourneydate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtjourneydate.Name = "txtjourneydate"
        Me.txtjourneydate.Size = New System.Drawing.Size(124, 23)
        Me.txtjourneydate.TabIndex = 79
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(398, 33)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(164, 23)
        Me.DateTimePicker2.TabIndex = 79
        '
        'txtbookingdate
        '
        Me.txtbookingdate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookingdate.Location = New System.Drawing.Point(397, 33)
        Me.txtbookingdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbookingdate.Name = "txtbookingdate"
        Me.txtbookingdate.Size = New System.Drawing.Size(124, 23)
        Me.txtbookingdate.TabIndex = 78
        '
        'lblbookingid
        '
        Me.lblbookingid.AutoSize = True
        Me.lblbookingid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookingid.ForeColor = System.Drawing.Color.Red
        Me.lblbookingid.Location = New System.Drawing.Point(7, 34)
        Me.lblbookingid.Name = "lblbookingid"
        Me.lblbookingid.Size = New System.Drawing.Size(90, 19)
        Me.lblbookingid.TabIndex = 38
        Me.lblbookingid.Text = "Booking ID:"
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdclose.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.DarkBlue
        Me.cmdclose.Location = New System.Drawing.Point(424, 367)
        Me.cmdclose.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 38)
        Me.cmdclose.TabIndex = 30
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = False
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnclear.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnclear.Location = New System.Drawing.Point(321, 367)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(72, 36)
        Me.btnclear.TabIndex = 29
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdupdate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.ForeColor = System.Drawing.Color.DarkBlue
        Me.cmdupdate.Location = New System.Drawing.Point(203, 367)
        Me.cmdupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(88, 38)
        Me.cmdupdate.TabIndex = 26
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdsave.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.DarkBlue
        Me.cmdsave.Location = New System.Drawing.Point(114, 366)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(59, 38)
        Me.cmdsave.TabIndex = 25
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdnew
        '
        Me.cmdnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdnew.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.ForeColor = System.Drawing.Color.DarkBlue
        Me.cmdnew.Location = New System.Drawing.Point(23, 365)
        Me.cmdnew.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(62, 38)
        Me.cmdnew.TabIndex = 24
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblsearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 64)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(426, 89)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(202, 43)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(124, 26)
        Me.ComboBox4.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(69, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 19)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Customer Name :"
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.ForeColor = System.Drawing.Color.Red
        Me.lblsearch.Location = New System.Drawing.Point(349, 45)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(56, 19)
        Me.lblsearch.TabIndex = 79
        Me.lblsearch.Text = "Search"
        '
        'TblbookinginfoBindingSource
        '
        Me.TblbookinginfoBindingSource.DataMember = "tblbookinginfo"
        '
        'TblBookingTableAdapter
        '
        Me.TblBookingTableAdapter.ClearBeforeFill = True
        '
        'TblBookingTableAdapter1
        '
        Me.TblBookingTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookingIDDataGridViewTextBoxColumn, Me.BookingDateDataGridViewTextBoxColumn, Me.PickupPointDataGridViewTextBoxColumn, Me.DropPointDataGridViewTextBoxColumn, Me.JourneyDateDataGridViewTextBoxColumn, Me.PickupTimeDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.ACNONACDataGridViewTextBoxColumn, Me.CarTypeDataGridViewTextBoxColumn, Me.KmExpectedDataGridViewTextBoxColumn, Me.CarIDDataGridViewTextBoxColumn, Me.DriverIDDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblBookingBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(622, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(745, 356)
        Me.DataGridView1.TabIndex = 30
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        '
        'BookingDateDataGridViewTextBoxColumn
        '
        Me.BookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate"
        Me.BookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate"
        Me.BookingDateDataGridViewTextBoxColumn.Name = "BookingDateDataGridViewTextBoxColumn"
        '
        'PickupPointDataGridViewTextBoxColumn
        '
        Me.PickupPointDataGridViewTextBoxColumn.DataPropertyName = "PickupPoint"
        Me.PickupPointDataGridViewTextBoxColumn.HeaderText = "PickupPoint"
        Me.PickupPointDataGridViewTextBoxColumn.Name = "PickupPointDataGridViewTextBoxColumn"
        '
        'DropPointDataGridViewTextBoxColumn
        '
        Me.DropPointDataGridViewTextBoxColumn.DataPropertyName = "DropPoint"
        Me.DropPointDataGridViewTextBoxColumn.HeaderText = "DropPoint"
        Me.DropPointDataGridViewTextBoxColumn.Name = "DropPointDataGridViewTextBoxColumn"
        '
        'JourneyDateDataGridViewTextBoxColumn
        '
        Me.JourneyDateDataGridViewTextBoxColumn.DataPropertyName = "JourneyDate"
        Me.JourneyDateDataGridViewTextBoxColumn.HeaderText = "JourneyDate"
        Me.JourneyDateDataGridViewTextBoxColumn.Name = "JourneyDateDataGridViewTextBoxColumn"
        '
        'PickupTimeDataGridViewTextBoxColumn
        '
        Me.PickupTimeDataGridViewTextBoxColumn.DataPropertyName = "PickupTime"
        Me.PickupTimeDataGridViewTextBoxColumn.HeaderText = "PickupTime"
        Me.PickupTimeDataGridViewTextBoxColumn.Name = "PickupTimeDataGridViewTextBoxColumn"
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        '
        'ACNONACDataGridViewTextBoxColumn
        '
        Me.ACNONACDataGridViewTextBoxColumn.DataPropertyName = "AC/NON-AC"
        Me.ACNONACDataGridViewTextBoxColumn.HeaderText = "AC/NON-AC"
        Me.ACNONACDataGridViewTextBoxColumn.Name = "ACNONACDataGridViewTextBoxColumn"
        '
        'CarTypeDataGridViewTextBoxColumn
        '
        Me.CarTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType"
        Me.CarTypeDataGridViewTextBoxColumn.HeaderText = "CarType"
        Me.CarTypeDataGridViewTextBoxColumn.Name = "CarTypeDataGridViewTextBoxColumn"
        '
        'KmExpectedDataGridViewTextBoxColumn
        '
        Me.KmExpectedDataGridViewTextBoxColumn.DataPropertyName = "KmExpected"
        Me.KmExpectedDataGridViewTextBoxColumn.HeaderText = "KmExpected"
        Me.KmExpectedDataGridViewTextBoxColumn.Name = "KmExpectedDataGridViewTextBoxColumn"
        '
        'CarIDDataGridViewTextBoxColumn
        '
        Me.CarIDDataGridViewTextBoxColumn.DataPropertyName = "CarID"
        Me.CarIDDataGridViewTextBoxColumn.HeaderText = "CarID"
        Me.CarIDDataGridViewTextBoxColumn.Name = "CarIDDataGridViewTextBoxColumn"
        '
        'DriverIDDataGridViewTextBoxColumn
        '
        Me.DriverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID"
        Me.DriverIDDataGridViewTextBoxColumn.HeaderText = "DriverID"
        Me.DriverIDDataGridViewTextBoxColumn.Name = "DriverIDDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'TblBookingBindingSource2
        '
        Me.TblBookingBindingSource2.DataMember = "tblBooking"
        Me.TblBookingBindingSource2.DataSource = Me.Cab_BookingDataSet11
        '
        'Cab_BookingDataSet11
        '
        Me.Cab_BookingDataSet11.DataSetName = "Cab_BookingDataSet11"
        Me.Cab_BookingDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblBookingTableAdapter2
        '
        Me.TblBookingTableAdapter2.ClearBeforeFill = True
        '
        'booking_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1425, 577)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "booking_info"
        Me.Text = "booking_info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TblBookingBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBookingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TblbookinginfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBookingBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TblbookinginfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblcustomername As System.Windows.Forms.Label
    Friend WithEvents txtdroppoint As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents lblbookingdate As System.Windows.Forms.Label
    Friend WithEvents lbljourneydate As System.Windows.Forms.Label
    Friend WithEvents txtdriverid As System.Windows.Forms.TextBox
    Friend WithEvents txtcartype As System.Windows.Forms.TextBox
    Friend WithEvents lbldriverid As System.Windows.Forms.Label
    Friend WithEvents lblcartype As System.Windows.Forms.Label
    Friend WithEvents lblcarid As System.Windows.Forms.Label
    Friend WithEvents txtpickuppoint As System.Windows.Forms.TextBox
    Friend WithEvents txtrateperkm As System.Windows.Forms.TextBox
    Friend WithEvents txtkmexpected As System.Windows.Forms.TextBox
    Friend WithEvents txtpickuptime As System.Windows.Forms.TextBox
    Friend WithEvents txtbookingid As System.Windows.Forms.TextBox
    Friend WithEvents lblrateperkm As System.Windows.Forms.Label
    Friend WithEvents lblkmexpected As System.Windows.Forms.Label
    Friend WithEvents lblacnonac As System.Windows.Forms.Label
    Friend WithEvents lblpickuptime As System.Windows.Forms.Label
    Friend WithEvents lbldroppoint As System.Windows.Forms.Label
    Friend WithEvents lblpickuppoint As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblbookingid As System.Windows.Forms.Label
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cab_BookingDataSet2 As mycab.Cab_BookingDataSet2
    Friend WithEvents TblBookingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblBookingTableAdapter As mycab.Cab_BookingDataSet2TableAdapters.tblBookingTableAdapter
    Friend WithEvents txtjourneydate As System.Windows.Forms.TextBox
    Friend WithEvents txtbookingdate As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cab_BookingDataSet3 As mycab.Cab_BookingDataSet3
    Friend WithEvents TblBookingBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblBookingTableAdapter1 As mycab.Cab_BookingDataSet3TableAdapters.tblBookingTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cab_BookingDataSet11 As mycab.Cab_BookingDataSet11
    Friend WithEvents TblBookingBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblBookingTableAdapter2 As mycab.Cab_BookingDataSet11TableAdapters.tblBookingTableAdapter
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PickupPointDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DropPointDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JourneyDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PickupTimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACNONACDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KmExpectedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
