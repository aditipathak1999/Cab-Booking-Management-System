<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class driver_info
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
        Me.lblsearch = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.txtdrivinglicenseno = New System.Windows.Forms.TextBox
        Me.lblgender = New System.Windows.Forms.Label
        Me.lbljoiningdate = New System.Windows.Forms.Label
        Me.lbldrivinglicenseno = New System.Windows.Forms.Label
        Me.cmdreport = New System.Windows.Forms.Button
        Me.txtaddress = New System.Windows.Forms.TextBox
        Me.txtcontactno = New System.Windows.Forms.TextBox
        Me.txtage = New System.Windows.Forms.TextBox
        Me.txtname = New System.Windows.Forms.TextBox
        Me.txtdriverid = New System.Windows.Forms.TextBox
        Me.cmdclose = New System.Windows.Forms.Button
        Me.lbladdress = New System.Windows.Forms.Label
        Me.cmdclear = New System.Windows.Forms.Button
        Me.lbldriverid = New System.Windows.Forms.Label
        Me.lblcontactno = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.cmdupdate = New System.Windows.Forms.Button
        Me.lblage = New System.Windows.Forms.Label
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DriverIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DriverNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DriverPhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DriverAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DriverAgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DriverGenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DriverLicenseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JoiningDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblDriverBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet10 = New mycab.Cab_BookingDataSet10
        Me.TblDriverTableAdapter = New mycab.Cab_BookingDataSet10TableAdapters.tblDriverTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDriverBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(387, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 44)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Driver Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblsearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(517, 87)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblsearch.Location = New System.Drawing.Point(369, 41)
        Me.lblsearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(63, 22)
        Me.lblsearch.TabIndex = 45
        Me.lblsearch.Text = "Search"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(137, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 22)
        Me.ComboBox1.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(17, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 22)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Driver Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.txtdrivinglicenseno)
        Me.GroupBox2.Controls.Add(Me.lblgender)
        Me.GroupBox2.Controls.Add(Me.lbljoiningdate)
        Me.GroupBox2.Controls.Add(Me.lbldrivinglicenseno)
        Me.GroupBox2.Controls.Add(Me.cmdreport)
        Me.GroupBox2.Controls.Add(Me.txtaddress)
        Me.GroupBox2.Controls.Add(Me.txtcontactno)
        Me.GroupBox2.Controls.Add(Me.txtage)
        Me.GroupBox2.Controls.Add(Me.txtname)
        Me.GroupBox2.Controls.Add(Me.txtdriverid)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.lbladdress)
        Me.GroupBox2.Controls.Add(Me.cmdclear)
        Me.GroupBox2.Controls.Add(Me.lbldriverid)
        Me.GroupBox2.Controls.Add(Me.lblcontactno)
        Me.GroupBox2.Controls.Add(Me.lblname)
        Me.GroupBox2.Controls.Add(Me.cmdupdate)
        Me.GroupBox2.Controls.Add(Me.lblage)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdnew)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 152)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(596, 469)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(503, 305)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(58, 23)
        Me.CheckBox1.TabIndex = 46
        Me.CheckBox1.Text = "EDIT"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(220, 300)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 44
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(220, 348)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(209, 43)
        Me.Panel1.TabIndex = 43
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.RadioButton2.Location = New System.Drawing.Point(100, 10)
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
        Me.RadioButton1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.RadioButton1.Location = New System.Drawing.Point(18, 10)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(60, 23)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Male"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'txtdrivinglicenseno
        '
        Me.txtdrivinglicenseno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrivinglicenseno.Location = New System.Drawing.Point(220, 257)
        Me.txtdrivinglicenseno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdrivinglicenseno.Name = "txtdrivinglicenseno"
        Me.txtdrivinglicenseno.Size = New System.Drawing.Size(276, 23)
        Me.txtdrivinglicenseno.TabIndex = 41
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblgender.Location = New System.Drawing.Point(40, 358)
        Me.lblgender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(75, 22)
        Me.lblgender.TabIndex = 40
        Me.lblgender.Text = "Gender:"
        '
        'lbljoiningdate
        '
        Me.lbljoiningdate.AutoSize = True
        Me.lbljoiningdate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljoiningdate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbljoiningdate.Location = New System.Drawing.Point(24, 308)
        Me.lbljoiningdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbljoiningdate.Name = "lbljoiningdate"
        Me.lbljoiningdate.Size = New System.Drawing.Size(113, 22)
        Me.lbljoiningdate.TabIndex = 39
        Me.lbljoiningdate.Text = "Joining Date:"
        '
        'lbldrivinglicenseno
        '
        Me.lbldrivinglicenseno.AutoSize = True
        Me.lbldrivinglicenseno.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrivinglicenseno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbldrivinglicenseno.Location = New System.Drawing.Point(24, 261)
        Me.lbldrivinglicenseno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldrivinglicenseno.Name = "lbldrivinglicenseno"
        Me.lbldrivinglicenseno.Size = New System.Drawing.Size(167, 22)
        Me.lbldrivinglicenseno.TabIndex = 38
        Me.lbldrivinglicenseno.Text = "Driving License No:"
        '
        'cmdreport
        '
        Me.cmdreport.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdreport.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreport.ForeColor = System.Drawing.Color.Navy
        Me.cmdreport.Location = New System.Drawing.Point(381, 422)
        Me.cmdreport.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdreport.Name = "cmdreport"
        Me.cmdreport.Size = New System.Drawing.Size(82, 38)
        Me.cmdreport.TabIndex = 37
        Me.cmdreport.Text = "Report"
        Me.cmdreport.UseVisualStyleBackColor = False
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(220, 213)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(276, 23)
        Me.txtaddress.TabIndex = 35
        '
        'txtcontactno
        '
        Me.txtcontactno.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontactno.Location = New System.Drawing.Point(220, 172)
        Me.txtcontactno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontactno.Name = "txtcontactno"
        Me.txtcontactno.Size = New System.Drawing.Size(276, 23)
        Me.txtcontactno.TabIndex = 34
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(220, 130)
        Me.txtage.Margin = New System.Windows.Forms.Padding(4)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(276, 23)
        Me.txtage.TabIndex = 33
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(220, 91)
        Me.txtname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(276, 23)
        Me.txtname.TabIndex = 32
        '
        'txtdriverid
        '
        Me.txtdriverid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdriverid.Location = New System.Drawing.Point(220, 44)
        Me.txtdriverid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdriverid.Name = "txtdriverid"
        Me.txtdriverid.Size = New System.Drawing.Size(276, 23)
        Me.txtdriverid.TabIndex = 31
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdclose.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.Navy
        Me.cmdclose.Location = New System.Drawing.Point(486, 422)
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
        Me.lbladdress.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbladdress.Location = New System.Drawing.Point(24, 217)
        Me.lbladdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(82, 22)
        Me.lbladdress.TabIndex = 23
        Me.lbladdress.Text = "Address:"
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdclear.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.Navy
        Me.cmdclear.Location = New System.Drawing.Point(287, 422)
        Me.cmdclear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(72, 36)
        Me.cmdclear.TabIndex = 29
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.UseVisualStyleBackColor = False
        '
        'lbldriverid
        '
        Me.lbldriverid.AutoSize = True
        Me.lbldriverid.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldriverid.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbldriverid.Location = New System.Drawing.Point(24, 45)
        Me.lbldriverid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldriverid.Name = "lbldriverid"
        Me.lbldriverid.Size = New System.Drawing.Size(91, 22)
        Me.lbldriverid.TabIndex = 19
        Me.lbldriverid.Text = "Driver ID:"
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontactno.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblcontactno.Location = New System.Drawing.Point(24, 176)
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
        Me.lblname.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblname.Location = New System.Drawing.Point(24, 95)
        Me.lblname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(62, 22)
        Me.lblname.TabIndex = 21
        Me.lblname.Text = "Name:"
        '
        'cmdupdate
        '
        Me.cmdupdate.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdupdate.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdupdate.ForeColor = System.Drawing.Color.Navy
        Me.cmdupdate.Location = New System.Drawing.Point(176, 421)
        Me.cmdupdate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdupdate.Name = "cmdupdate"
        Me.cmdupdate.Size = New System.Drawing.Size(88, 38)
        Me.cmdupdate.TabIndex = 26
        Me.cmdupdate.Text = "Update"
        Me.cmdupdate.UseVisualStyleBackColor = False
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblage.Location = New System.Drawing.Point(24, 134)
        Me.lblage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(45, 22)
        Me.lblage.TabIndex = 22
        Me.lblage.Text = "Age:"
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdsave.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.Navy
        Me.cmdsave.Location = New System.Drawing.Point(95, 420)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(59, 38)
        Me.cmdsave.TabIndex = 25
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdnew
        '
        Me.cmdnew.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdnew.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.ForeColor = System.Drawing.Color.Navy
        Me.cmdnew.Location = New System.Drawing.Point(11, 420)
        Me.cmdnew.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(62, 38)
        Me.cmdnew.TabIndex = 24
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(220, 299)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 23)
        Me.TextBox1.TabIndex = 45
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(450, 509)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(151, 23)
        Me.TextBox2.TabIndex = 47
        Me.TextBox2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DriverIDDataGridViewTextBoxColumn, Me.DriverNameDataGridViewTextBoxColumn, Me.DriverPhDataGridViewTextBoxColumn, Me.DriverAddressDataGridViewTextBoxColumn, Me.DriverAgeDataGridViewTextBoxColumn, Me.DriverGenderDataGridViewTextBoxColumn, Me.DriverLicenseNoDataGridViewTextBoxColumn, Me.JoiningDateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblDriverBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(627, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 349)
        Me.DataGridView1.TabIndex = 14
        '
        'DriverIDDataGridViewTextBoxColumn
        '
        Me.DriverIDDataGridViewTextBoxColumn.DataPropertyName = "DriverID"
        Me.DriverIDDataGridViewTextBoxColumn.HeaderText = "DriverID"
        Me.DriverIDDataGridViewTextBoxColumn.Name = "DriverIDDataGridViewTextBoxColumn"
        '
        'DriverNameDataGridViewTextBoxColumn
        '
        Me.DriverNameDataGridViewTextBoxColumn.DataPropertyName = "DriverName"
        Me.DriverNameDataGridViewTextBoxColumn.HeaderText = "DriverName"
        Me.DriverNameDataGridViewTextBoxColumn.Name = "DriverNameDataGridViewTextBoxColumn"
        '
        'DriverPhDataGridViewTextBoxColumn
        '
        Me.DriverPhDataGridViewTextBoxColumn.DataPropertyName = "DriverPh"
        Me.DriverPhDataGridViewTextBoxColumn.HeaderText = "DriverPh"
        Me.DriverPhDataGridViewTextBoxColumn.Name = "DriverPhDataGridViewTextBoxColumn"
        '
        'DriverAddressDataGridViewTextBoxColumn
        '
        Me.DriverAddressDataGridViewTextBoxColumn.DataPropertyName = "DriverAddress"
        Me.DriverAddressDataGridViewTextBoxColumn.HeaderText = "DriverAddress"
        Me.DriverAddressDataGridViewTextBoxColumn.Name = "DriverAddressDataGridViewTextBoxColumn"
        '
        'DriverAgeDataGridViewTextBoxColumn
        '
        Me.DriverAgeDataGridViewTextBoxColumn.DataPropertyName = "DriverAge"
        Me.DriverAgeDataGridViewTextBoxColumn.HeaderText = "DriverAge"
        Me.DriverAgeDataGridViewTextBoxColumn.Name = "DriverAgeDataGridViewTextBoxColumn"
        '
        'DriverGenderDataGridViewTextBoxColumn
        '
        Me.DriverGenderDataGridViewTextBoxColumn.DataPropertyName = "DriverGender"
        Me.DriverGenderDataGridViewTextBoxColumn.HeaderText = "DriverGender"
        Me.DriverGenderDataGridViewTextBoxColumn.Name = "DriverGenderDataGridViewTextBoxColumn"
        '
        'DriverLicenseNoDataGridViewTextBoxColumn
        '
        Me.DriverLicenseNoDataGridViewTextBoxColumn.DataPropertyName = "DriverLicenseNo"
        Me.DriverLicenseNoDataGridViewTextBoxColumn.HeaderText = "DriverLicenseNo"
        Me.DriverLicenseNoDataGridViewTextBoxColumn.Name = "DriverLicenseNoDataGridViewTextBoxColumn"
        '
        'JoiningDateDataGridViewTextBoxColumn
        '
        Me.JoiningDateDataGridViewTextBoxColumn.DataPropertyName = "JoiningDate"
        Me.JoiningDateDataGridViewTextBoxColumn.HeaderText = "JoiningDate"
        Me.JoiningDateDataGridViewTextBoxColumn.Name = "JoiningDateDataGridViewTextBoxColumn"
        '
        'TblDriverBindingSource
        '
        Me.TblDriverBindingSource.DataMember = "tblDriver"
        Me.TblDriverBindingSource.DataSource = Me.Cab_BookingDataSet10
        '
        'Cab_BookingDataSet10
        '
        Me.Cab_BookingDataSet10.DataSetName = "Cab_BookingDataSet10"
        Me.Cab_BookingDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDriverTableAdapter
        '
        Me.TblDriverTableAdapter.ClearBeforeFill = True
        '
        'driver_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(1275, 616)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "driver_info"
        Me.Text = "driver_info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDriverBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents txtdrivinglicenseno As System.Windows.Forms.TextBox
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lbljoiningdate As System.Windows.Forms.Label
    Friend WithEvents lbldrivinglicenseno As System.Windows.Forms.Label
    Friend WithEvents cmdreport As System.Windows.Forms.Button
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents txtcontactno As System.Windows.Forms.TextBox
    Friend WithEvents txtage As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtdriverid As System.Windows.Forms.TextBox
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents lbladdress As System.Windows.Forms.Label
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents lbldriverid As System.Windows.Forms.Label
    Friend WithEvents lblcontactno As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents cmdupdate As System.Windows.Forms.Button
    Friend WithEvents lblage As System.Windows.Forms.Label
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cab_BookingDataSet10 As mycab.Cab_BookingDataSet10
    Friend WithEvents TblDriverBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblDriverTableAdapter As mycab.Cab_BookingDataSet10TableAdapters.tblDriverTableAdapter
    Friend WithEvents DriverIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverPhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverAgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverGenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DriverLicenseNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JoiningDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
