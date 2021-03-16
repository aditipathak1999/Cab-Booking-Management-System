<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booking_receipt
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
        Me.Lblsearch = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.txttotalwaiting = New System.Windows.Forms.TextBox
        Me.txtcustomer_id = New System.Windows.Forms.TextBox
        Me.txtbilldate = New System.Windows.Forms.TextBox
        Me.txtcarid = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.txtpaymentdetails = New System.Windows.Forms.TextBox
        Me.txttotalamt = New System.Windows.Forms.TextBox
        Me.lblpaymentdetails = New System.Windows.Forms.Label
        Me.lbltotalamt = New System.Windows.Forms.Label
        Me.lblpaymentmode = New System.Windows.Forms.Label
        Me.cmdcalculate = New System.Windows.Forms.Button
        Me.txtdriverid = New System.Windows.Forms.TextBox
        Me.lblcarid = New System.Windows.Forms.Label
        Me.lblbilldate = New System.Windows.Forms.Label
        Me.txtnarration = New System.Windows.Forms.TextBox
        Me.txtrateperkm = New System.Windows.Forms.TextBox
        Me.lblnarration = New System.Windows.Forms.Label
        Me.lblrateperkm = New System.Windows.Forms.Label
        Me.lblcustomername = New System.Windows.Forms.Label
        Me.lblcustomerid = New System.Windows.Forms.Label
        Me.txttaxamt = New System.Windows.Forms.TextBox
        Me.txtextracharges = New System.Windows.Forms.TextBox
        Me.txttotalkms = New System.Windows.Forms.TextBox
        Me.txtbillid = New System.Windows.Forms.TextBox
        Me.lbltaxamt = New System.Windows.Forms.Label
        Me.lblextracharges = New System.Windows.Forms.Label
        Me.lbltotalwaiting = New System.Windows.Forms.Label
        Me.lbltotalkms = New System.Windows.Forms.Label
        Me.lbldrivername = New System.Windows.Forms.Label
        Me.lblbookingid = New System.Windows.Forms.Label
        Me.lblbillid = New System.Windows.Forms.Label
        Me.cmdclose = New System.Windows.Forms.Button
        Me.btnclear = New System.Windows.Forms.Button
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BillIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BillDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalKmsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalWaitingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TotalAmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PaymentDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CarIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DriverIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExtraChargesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NarrationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblBillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet4 = New mycab.Cab_BookingDataSet4
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TblBillTableAdapter = New mycab.Cab_BookingDataSet4TableAdapters.tblBillTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Controls.Add(Me.Lblsearch)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(360, 89)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(69, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Bill ID :"
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(152, 43)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(124, 26)
        Me.ComboBox4.TabIndex = 79
        '
        'Lblsearch
        '
        Me.Lblsearch.AutoSize = True
        Me.Lblsearch.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblsearch.ForeColor = System.Drawing.Color.Red
        Me.Lblsearch.Location = New System.Drawing.Point(297, 45)
        Me.Lblsearch.Name = "Lblsearch"
        Me.Lblsearch.Size = New System.Drawing.Size(56, 19)
        Me.Lblsearch.TabIndex = 79
        Me.Lblsearch.Text = "Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 44)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Booking Receipt"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.txttotalwaiting)
        Me.GroupBox2.Controls.Add(Me.txtcustomer_id)
        Me.GroupBox2.Controls.Add(Me.txtbilldate)
        Me.GroupBox2.Controls.Add(Me.txtcarid)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.txtpaymentdetails)
        Me.GroupBox2.Controls.Add(Me.txttotalamt)
        Me.GroupBox2.Controls.Add(Me.lblpaymentdetails)
        Me.GroupBox2.Controls.Add(Me.lbltotalamt)
        Me.GroupBox2.Controls.Add(Me.lblpaymentmode)
        Me.GroupBox2.Controls.Add(Me.cmdcalculate)
        Me.GroupBox2.Controls.Add(Me.txtdriverid)
        Me.GroupBox2.Controls.Add(Me.lblcarid)
        Me.GroupBox2.Controls.Add(Me.lblbilldate)
        Me.GroupBox2.Controls.Add(Me.txtnarration)
        Me.GroupBox2.Controls.Add(Me.txtrateperkm)
        Me.GroupBox2.Controls.Add(Me.lblnarration)
        Me.GroupBox2.Controls.Add(Me.lblrateperkm)
        Me.GroupBox2.Controls.Add(Me.lblcustomername)
        Me.GroupBox2.Controls.Add(Me.lblcustomerid)
        Me.GroupBox2.Controls.Add(Me.txttaxamt)
        Me.GroupBox2.Controls.Add(Me.txtextracharges)
        Me.GroupBox2.Controls.Add(Me.txttotalkms)
        Me.GroupBox2.Controls.Add(Me.txtbillid)
        Me.GroupBox2.Controls.Add(Me.lbltaxamt)
        Me.GroupBox2.Controls.Add(Me.lblextracharges)
        Me.GroupBox2.Controls.Add(Me.lbltotalwaiting)
        Me.GroupBox2.Controls.Add(Me.lbltotalkms)
        Me.GroupBox2.Controls.Add(Me.lbldrivername)
        Me.GroupBox2.Controls.Add(Me.lblbookingid)
        Me.GroupBox2.Controls.Add(Me.lblbillid)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.btnclear)
        Me.GroupBox2.Controls.Add(Me.cmdupdate)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdnew)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 154)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(566, 456)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"Dinesh", "Ramesh", "Ganesh", "Milind"})
        Me.ComboBox5.Location = New System.Drawing.Point(110, 109)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(124, 26)
        Me.ComboBox5.TabIndex = 92
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"CASH", "CARD", "PAYTM"})
        Me.ComboBox3.Location = New System.Drawing.Point(117, 349)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(118, 27)
        Me.ComboBox3.TabIndex = 91
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(397, 141)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 26)
        Me.ComboBox1.TabIndex = 81
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(397, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(164, 22)
        Me.DateTimePicker2.TabIndex = 83
        '
        'txttotalwaiting
        '
        Me.txttotalwaiting.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalwaiting.Location = New System.Drawing.Point(112, 182)
        Me.txttotalwaiting.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalwaiting.Name = "txttotalwaiting"
        Me.txttotalwaiting.Size = New System.Drawing.Size(124, 23)
        Me.txttotalwaiting.TabIndex = 90
        '
        'txtcustomer_id
        '
        Me.txtcustomer_id.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustomer_id.Location = New System.Drawing.Point(397, 109)
        Me.txtcustomer_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcustomer_id.Name = "txtcustomer_id"
        Me.txtcustomer_id.Size = New System.Drawing.Size(124, 23)
        Me.txtcustomer_id.TabIndex = 89
        '
        'txtbilldate
        '
        Me.txtbilldate.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbilldate.Location = New System.Drawing.Point(397, 31)
        Me.txtbilldate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbilldate.Name = "txtbilldate"
        Me.txtbilldate.Size = New System.Drawing.Size(124, 23)
        Me.txtbilldate.TabIndex = 78
        Me.txtbilldate.Visible = False
        '
        'txtcarid
        '
        Me.txtcarid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarid.Location = New System.Drawing.Point(397, 69)
        Me.txtcarid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcarid.Name = "txtcarid"
        Me.txtcarid.Size = New System.Drawing.Size(124, 23)
        Me.txtcarid.TabIndex = 88
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(112, 72)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(124, 26)
        Me.ComboBox2.TabIndex = 87
        '
        'txtpaymentdetails
        '
        Me.txtpaymentdetails.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaymentdetails.Location = New System.Drawing.Point(397, 351)
        Me.txtpaymentdetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtpaymentdetails.Name = "txtpaymentdetails"
        Me.txtpaymentdetails.Size = New System.Drawing.Size(124, 23)
        Me.txtpaymentdetails.TabIndex = 86
        '
        'txttotalamt
        '
        Me.txttotalamt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalamt.Location = New System.Drawing.Point(397, 313)
        Me.txttotalamt.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalamt.Name = "txttotalamt"
        Me.txttotalamt.Size = New System.Drawing.Size(124, 23)
        Me.txttotalamt.TabIndex = 85
        '
        'lblpaymentdetails
        '
        Me.lblpaymentdetails.AutoSize = True
        Me.lblpaymentdetails.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaymentdetails.ForeColor = System.Drawing.Color.Red
        Me.lblpaymentdetails.Location = New System.Drawing.Point(263, 352)
        Me.lblpaymentdetails.Name = "lblpaymentdetails"
        Me.lblpaymentdetails.Size = New System.Drawing.Size(124, 19)
        Me.lblpaymentdetails.TabIndex = 84
        Me.lblpaymentdetails.Text = "Payment Details:"
        '
        'lbltotalamt
        '
        Me.lbltotalamt.AutoSize = True
        Me.lbltotalamt.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalamt.ForeColor = System.Drawing.Color.Red
        Me.lbltotalamt.Location = New System.Drawing.Point(269, 312)
        Me.lbltotalamt.Name = "lbltotalamt"
        Me.lbltotalamt.Size = New System.Drawing.Size(79, 19)
        Me.lbltotalamt.TabIndex = 83
        Me.lbltotalamt.Text = "Total Amt:"
        '
        'lblpaymentmode
        '
        Me.lblpaymentmode.AutoSize = True
        Me.lblpaymentmode.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaymentmode.ForeColor = System.Drawing.Color.Red
        Me.lblpaymentmode.Location = New System.Drawing.Point(-6, 357)
        Me.lblpaymentmode.Name = "lblpaymentmode"
        Me.lblpaymentmode.Size = New System.Drawing.Size(116, 19)
        Me.lblpaymentmode.TabIndex = 81
        Me.lblpaymentmode.Text = "Payment Mode:"
        '
        'cmdcalculate
        '
        Me.cmdcalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdcalculate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcalculate.ForeColor = System.Drawing.Color.DarkBlue
        Me.cmdcalculate.Location = New System.Drawing.Point(207, 263)
        Me.cmdcalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdcalculate.Name = "cmdcalculate"
        Me.cmdcalculate.Size = New System.Drawing.Size(106, 38)
        Me.cmdcalculate.TabIndex = 80
        Me.cmdcalculate.Text = "Calculate"
        Me.cmdcalculate.UseVisualStyleBackColor = False
        '
        'txtdriverid
        '
        Me.txtdriverid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdriverid.Location = New System.Drawing.Point(110, 109)
        Me.txtdriverid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdriverid.Name = "txtdriverid"
        Me.txtdriverid.Size = New System.Drawing.Size(124, 23)
        Me.txtdriverid.TabIndex = 72
        '
        'lblcarid
        '
        Me.lblcarid.AutoSize = True
        Me.lblcarid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarid.ForeColor = System.Drawing.Color.Red
        Me.lblcarid.Location = New System.Drawing.Point(273, 74)
        Me.lblcarid.Name = "lblcarid"
        Me.lblcarid.Size = New System.Drawing.Size(57, 19)
        Me.lblcarid.TabIndex = 71
        Me.lblcarid.Text = "Car ID:"
        '
        'lblbilldate
        '
        Me.lblbilldate.AutoSize = True
        Me.lblbilldate.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbilldate.ForeColor = System.Drawing.Color.Red
        Me.lblbilldate.Location = New System.Drawing.Point(271, 34)
        Me.lblbilldate.Name = "lblbilldate"
        Me.lblbilldate.Size = New System.Drawing.Size(71, 19)
        Me.lblbilldate.TabIndex = 70
        Me.lblbilldate.Text = "Bill Date:"
        '
        'txtnarration
        '
        Me.txtnarration.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnarration.Location = New System.Drawing.Point(397, 226)
        Me.txtnarration.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnarration.Name = "txtnarration"
        Me.txtnarration.Size = New System.Drawing.Size(124, 23)
        Me.txtnarration.TabIndex = 67
        '
        'txtrateperkm
        '
        Me.txtrateperkm.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrateperkm.Location = New System.Drawing.Point(397, 189)
        Me.txtrateperkm.Margin = New System.Windows.Forms.Padding(4)
        Me.txtrateperkm.Name = "txtrateperkm"
        Me.txtrateperkm.Size = New System.Drawing.Size(124, 23)
        Me.txtrateperkm.TabIndex = 64
        '
        'lblnarration
        '
        Me.lblnarration.AutoSize = True
        Me.lblnarration.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnarration.ForeColor = System.Drawing.Color.Red
        Me.lblnarration.Location = New System.Drawing.Point(278, 224)
        Me.lblnarration.Name = "lblnarration"
        Me.lblnarration.Size = New System.Drawing.Size(81, 19)
        Me.lblnarration.TabIndex = 59
        Me.lblnarration.Text = "Narration:"
        '
        'lblrateperkm
        '
        Me.lblrateperkm.AutoSize = True
        Me.lblrateperkm.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrateperkm.ForeColor = System.Drawing.Color.Red
        Me.lblrateperkm.Location = New System.Drawing.Point(276, 189)
        Me.lblrateperkm.Name = "lblrateperkm"
        Me.lblrateperkm.Size = New System.Drawing.Size(107, 19)
        Me.lblrateperkm.TabIndex = 57
        Me.lblrateperkm.Text = "Rate(Per KM):"
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.ForeColor = System.Drawing.Color.Red
        Me.lblcustomername.Location = New System.Drawing.Point(273, 152)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(124, 19)
        Me.lblcustomername.TabIndex = 55
        Me.lblcustomername.Text = "Customer Name:"
        '
        'lblcustomerid
        '
        Me.lblcustomerid.AutoSize = True
        Me.lblcustomerid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomerid.ForeColor = System.Drawing.Color.Red
        Me.lblcustomerid.Location = New System.Drawing.Point(273, 113)
        Me.lblcustomerid.Name = "lblcustomerid"
        Me.lblcustomerid.Size = New System.Drawing.Size(100, 19)
        Me.lblcustomerid.TabIndex = 54
        Me.lblcustomerid.Text = "Customer ID:"
        '
        'txttaxamt
        '
        Me.txttaxamt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttaxamt.Location = New System.Drawing.Point(110, 310)
        Me.txttaxamt.Margin = New System.Windows.Forms.Padding(4)
        Me.txttaxamt.Name = "txttaxamt"
        Me.txttaxamt.Size = New System.Drawing.Size(124, 23)
        Me.txttaxamt.TabIndex = 50
        '
        'txtextracharges
        '
        Me.txtextracharges.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtextracharges.Location = New System.Drawing.Point(112, 220)
        Me.txtextracharges.Margin = New System.Windows.Forms.Padding(4)
        Me.txtextracharges.Name = "txtextracharges"
        Me.txtextracharges.Size = New System.Drawing.Size(124, 23)
        Me.txtextracharges.TabIndex = 49
        '
        'txttotalkms
        '
        Me.txttotalkms.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalkms.Location = New System.Drawing.Point(110, 143)
        Me.txttotalkms.Margin = New System.Windows.Forms.Padding(4)
        Me.txttotalkms.Name = "txttotalkms"
        Me.txttotalkms.Size = New System.Drawing.Size(124, 23)
        Me.txttotalkms.TabIndex = 47
        '
        'txtbillid
        '
        Me.txtbillid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillid.Location = New System.Drawing.Point(112, 34)
        Me.txtbillid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbillid.Name = "txtbillid"
        Me.txtbillid.Size = New System.Drawing.Size(124, 23)
        Me.txtbillid.TabIndex = 45
        '
        'lbltaxamt
        '
        Me.lbltaxamt.AutoSize = True
        Me.lbltaxamt.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltaxamt.ForeColor = System.Drawing.Color.Red
        Me.lbltaxamt.Location = New System.Drawing.Point(3, 313)
        Me.lbltaxamt.Name = "lbltaxamt"
        Me.lbltaxamt.Size = New System.Drawing.Size(69, 19)
        Me.lbltaxamt.TabIndex = 44
        Me.lbltaxamt.Text = "Tax Amt:"
        '
        'lblextracharges
        '
        Me.lblextracharges.AutoSize = True
        Me.lblextracharges.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblextracharges.ForeColor = System.Drawing.Color.Red
        Me.lblextracharges.Location = New System.Drawing.Point(3, 220)
        Me.lblextracharges.Name = "lblextracharges"
        Me.lblextracharges.Size = New System.Drawing.Size(110, 19)
        Me.lblextracharges.TabIndex = 43
        Me.lblextracharges.Text = "Extra Charges:"
        '
        'lbltotalwaiting
        '
        Me.lbltotalwaiting.AutoSize = True
        Me.lbltotalwaiting.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalwaiting.ForeColor = System.Drawing.Color.Red
        Me.lbltotalwaiting.Location = New System.Drawing.Point(7, 183)
        Me.lbltotalwaiting.Name = "lbltotalwaiting"
        Me.lbltotalwaiting.Size = New System.Drawing.Size(103, 19)
        Me.lbltotalwaiting.TabIndex = 42
        Me.lbltotalwaiting.Text = "Total Waiting:"
        '
        'lbltotalkms
        '
        Me.lbltotalkms.AutoSize = True
        Me.lbltotalkms.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalkms.ForeColor = System.Drawing.Color.Red
        Me.lbltotalkms.Location = New System.Drawing.Point(7, 147)
        Me.lbltotalkms.Name = "lbltotalkms"
        Me.lbltotalkms.Size = New System.Drawing.Size(82, 19)
        Me.lbltotalkms.TabIndex = 41
        Me.lbltotalkms.Text = "Total KMS:"
        '
        'lbldrivername
        '
        Me.lbldrivername.AutoSize = True
        Me.lbldrivername.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrivername.ForeColor = System.Drawing.Color.Red
        Me.lbldrivername.Location = New System.Drawing.Point(7, 113)
        Me.lbldrivername.Name = "lbldrivername"
        Me.lbldrivername.Size = New System.Drawing.Size(102, 19)
        Me.lbldrivername.TabIndex = 40
        Me.lbldrivername.Text = "Driver Name:"
        '
        'lblbookingid
        '
        Me.lblbookingid.AutoSize = True
        Me.lblbookingid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookingid.ForeColor = System.Drawing.Color.Red
        Me.lblbookingid.Location = New System.Drawing.Point(7, 74)
        Me.lblbookingid.Name = "lblbookingid"
        Me.lblbookingid.Size = New System.Drawing.Size(90, 19)
        Me.lblbookingid.TabIndex = 39
        Me.lblbookingid.Text = "Booking ID:"
        '
        'lblbillid
        '
        Me.lblbillid.AutoSize = True
        Me.lblbillid.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbillid.ForeColor = System.Drawing.Color.Red
        Me.lblbillid.Location = New System.Drawing.Point(7, 34)
        Me.lblbillid.Name = "lblbillid"
        Me.lblbillid.Size = New System.Drawing.Size(55, 19)
        Me.lblbillid.TabIndex = 38
        Me.lblbillid.Text = "Bill ID:"
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdclose.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.DarkBlue
        Me.cmdclose.Location = New System.Drawing.Point(432, 402)
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
        Me.btnclear.Location = New System.Drawing.Point(325, 403)
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
        Me.cmdupdate.Location = New System.Drawing.Point(207, 401)
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
        Me.cmdsave.Location = New System.Drawing.Point(117, 400)
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
        Me.cmdnew.Location = New System.Drawing.Point(27, 399)
        Me.cmdnew.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(62, 38)
        Me.cmdnew.TabIndex = 24
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillIDDataGridViewTextBoxColumn, Me.BillDateDataGridViewTextBoxColumn, Me.TotalKmsDataGridViewTextBoxColumn, Me.TotalWaitingDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.TaxDataGridViewTextBoxColumn, Me.TotalAmtDataGridViewTextBoxColumn, Me.PaymentModeDataGridViewTextBoxColumn, Me.PaymentDetailsDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.CarIDDataGridViewTextBoxColumn, Me.DriverIDDataGridViewTextBoxColumn, Me.BookingIDDataGridViewTextBoxColumn, Me.ExtraChargesDataGridViewTextBoxColumn, Me.NarrationDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblBillBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(617, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(645, 397)
        Me.DataGridView1.TabIndex = 84
        '
        'BillIDDataGridViewTextBoxColumn
        '
        Me.BillIDDataGridViewTextBoxColumn.DataPropertyName = "BillID"
        Me.BillIDDataGridViewTextBoxColumn.HeaderText = "BillID"
        Me.BillIDDataGridViewTextBoxColumn.Name = "BillIDDataGridViewTextBoxColumn"
        '
        'BillDateDataGridViewTextBoxColumn
        '
        Me.BillDateDataGridViewTextBoxColumn.DataPropertyName = "BillDate"
        Me.BillDateDataGridViewTextBoxColumn.HeaderText = "BillDate"
        Me.BillDateDataGridViewTextBoxColumn.Name = "BillDateDataGridViewTextBoxColumn"
        '
        'TotalKmsDataGridViewTextBoxColumn
        '
        Me.TotalKmsDataGridViewTextBoxColumn.DataPropertyName = "TotalKms"
        Me.TotalKmsDataGridViewTextBoxColumn.HeaderText = "TotalKms"
        Me.TotalKmsDataGridViewTextBoxColumn.Name = "TotalKmsDataGridViewTextBoxColumn"
        '
        'TotalWaitingDataGridViewTextBoxColumn
        '
        Me.TotalWaitingDataGridViewTextBoxColumn.DataPropertyName = "TotalWaiting"
        Me.TotalWaitingDataGridViewTextBoxColumn.HeaderText = "TotalWaiting"
        Me.TotalWaitingDataGridViewTextBoxColumn.Name = "TotalWaitingDataGridViewTextBoxColumn"
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        '
        'TaxDataGridViewTextBoxColumn
        '
        Me.TaxDataGridViewTextBoxColumn.DataPropertyName = "Tax"
        Me.TaxDataGridViewTextBoxColumn.HeaderText = "Tax"
        Me.TaxDataGridViewTextBoxColumn.Name = "TaxDataGridViewTextBoxColumn"
        '
        'TotalAmtDataGridViewTextBoxColumn
        '
        Me.TotalAmtDataGridViewTextBoxColumn.DataPropertyName = "TotalAmt"
        Me.TotalAmtDataGridViewTextBoxColumn.HeaderText = "TotalAmt"
        Me.TotalAmtDataGridViewTextBoxColumn.Name = "TotalAmtDataGridViewTextBoxColumn"
        '
        'PaymentModeDataGridViewTextBoxColumn
        '
        Me.PaymentModeDataGridViewTextBoxColumn.DataPropertyName = "PaymentMode"
        Me.PaymentModeDataGridViewTextBoxColumn.HeaderText = "PaymentMode"
        Me.PaymentModeDataGridViewTextBoxColumn.Name = "PaymentModeDataGridViewTextBoxColumn"
        '
        'PaymentDetailsDataGridViewTextBoxColumn
        '
        Me.PaymentDetailsDataGridViewTextBoxColumn.DataPropertyName = "PaymentDetails"
        Me.PaymentDetailsDataGridViewTextBoxColumn.HeaderText = "PaymentDetails"
        Me.PaymentDetailsDataGridViewTextBoxColumn.Name = "PaymentDetailsDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
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
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        '
        'ExtraChargesDataGridViewTextBoxColumn
        '
        Me.ExtraChargesDataGridViewTextBoxColumn.DataPropertyName = "ExtraCharges"
        Me.ExtraChargesDataGridViewTextBoxColumn.HeaderText = "ExtraCharges"
        Me.ExtraChargesDataGridViewTextBoxColumn.Name = "ExtraChargesDataGridViewTextBoxColumn"
        '
        'NarrationDataGridViewTextBoxColumn
        '
        Me.NarrationDataGridViewTextBoxColumn.DataPropertyName = "Narration"
        Me.NarrationDataGridViewTextBoxColumn.HeaderText = "Narration"
        Me.NarrationDataGridViewTextBoxColumn.Name = "NarrationDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'TblBillBindingSource
        '
        Me.TblBillBindingSource.DataMember = "tblBill"
        Me.TblBillBindingSource.DataSource = Me.Cab_BookingDataSet4
        '
        'Cab_BookingDataSet4
        '
        Me.Cab_BookingDataSet4.DataSetName = "Cab_BookingDataSet4"
        Me.Cab_BookingDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.mycab.My.Resources.Resources.thDS2F0KHQ
        Me.PictureBox1.Location = New System.Drawing.Point(389, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'TblBillTableAdapter
        '
        Me.TblBillTableAdapter.ClearBeforeFill = True
        '
        'booking_receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1081, 614)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "booking_receipt"
        Me.Text = "booking_receipt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Lblsearch As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbilldate As System.Windows.Forms.TextBox
    Friend WithEvents txtdriverid As System.Windows.Forms.TextBox
    Friend WithEvents lblcarid As System.Windows.Forms.Label
    Friend WithEvents lblbilldate As System.Windows.Forms.Label
    Friend WithEvents txtnarration As System.Windows.Forms.TextBox
    Friend WithEvents txtrateperkm As System.Windows.Forms.TextBox
    Friend WithEvents lblnarration As System.Windows.Forms.Label
    Friend WithEvents lblrateperkm As System.Windows.Forms.Label
    Friend WithEvents lblcustomername As System.Windows.Forms.Label
    Friend WithEvents lblcustomerid As System.Windows.Forms.Label
    Friend WithEvents txttaxamt As System.Windows.Forms.TextBox
    Friend WithEvents txtextracharges As System.Windows.Forms.TextBox
    Friend WithEvents txttotalkms As System.Windows.Forms.TextBox
    Friend WithEvents txtbillid As System.Windows.Forms.TextBox
    Friend WithEvents lbltaxamt As System.Windows.Forms.Label
    Friend WithEvents lblextracharges As System.Windows.Forms.Label
    Friend WithEvents lbltotalwaiting As System.Windows.Forms.Label
    Friend WithEvents lbltotalkms As System.Windows.Forms.Label
    Friend WithEvents lbldrivername As System.Windows.Forms.Label
    Friend WithEvents lblbookingid As System.Windows.Forms.Label
    Friend WithEvents lblbillid As System.Windows.Forms.Label
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents cmdcalculate As System.Windows.Forms.Button
    Friend WithEvents lblpaymentdetails As System.Windows.Forms.Label
    Friend WithEvents lbltotalamt As System.Windows.Forms.Label
    Friend WithEvents lblpaymentmode As System.Windows.Forms.Label
    Friend WithEvents txtpaymentdetails As System.Windows.Forms.TextBox
    Friend WithEvents txttotalamt As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtcustomer_id As System.Windows.Forms.TextBox
    Friend WithEvents txtcarid As System.Windows.Forms.TextBox
    Friend WithEvents txttotalwaiting As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cab_BookingDataSet4 As mycab.Cab_BookingDataSet4
    Friend WithEvents TblBillBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblBillTableAdapter As mycab.Cab_BookingDataSet4TableAdapters.tblBillTableAdapter
    Friend WithEvents BillIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BillDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalKmsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalWaitingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentDetailsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExtraChargesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NarrationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
