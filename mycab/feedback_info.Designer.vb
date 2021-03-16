<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class feedback_info
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.cmdreport = New System.Windows.Forms.Button
        Me.cmdclose = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdnew = New System.Windows.Forms.Button
        Me.txtfeedbackid = New System.Windows.Forms.TextBox
        Me.txtsuggestion = New System.Windows.Forms.TextBox
        Me.lblcustomername = New System.Windows.Forms.Label
        Me.lblsuggestion = New System.Windows.Forms.Label
        Me.lblrating = New System.Windows.Forms.Label
        Me.lblfeedbackid = New System.Windows.Forms.Label
        Me.lblbookingid = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.FeedbackIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BookingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SuggestionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RatingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TblFeedbackBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet12 = New mycab.Cab_BookingDataSet12
        Me.TblFeedbackBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cab_BookingDataSet8 = New mycab.Cab_BookingDataSet8
        Me.TblFeedbackTableAdapter = New mycab.Cab_BookingDataSet8TableAdapters.tblFeedbackTableAdapter
        Me.TblFeedbackTableAdapter1 = New mycab.Cab_BookingDataSet12TableAdapters.tblFeedbackTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFeedbackBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFeedbackBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cab_BookingDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 44)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Feedback Information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblsearch)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 57)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(434, 73)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(323, 34)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(63, 22)
        Me.lblsearch.TabIndex = 83
        Me.lblsearch.Text = "Search"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(147, 30)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(151, 26)
        Me.ComboBox2.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 22)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Customer Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.cmdreport)
        Me.GroupBox2.Controls.Add(Me.cmdclose)
        Me.GroupBox2.Controls.Add(Me.cmdclear)
        Me.GroupBox2.Controls.Add(Me.cmdsave)
        Me.GroupBox2.Controls.Add(Me.cmdnew)
        Me.GroupBox2.Controls.Add(Me.txtfeedbackid)
        Me.GroupBox2.Controls.Add(Me.txtsuggestion)
        Me.GroupBox2.Controls.Add(Me.lblcustomername)
        Me.GroupBox2.Controls.Add(Me.lblsuggestion)
        Me.GroupBox2.Controls.Add(Me.lblrating)
        Me.GroupBox2.Controls.Add(Me.lblfeedbackid)
        Me.GroupBox2.Controls.Add(Me.lblbookingid)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(583, 411)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Details"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(152, 148)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(151, 23)
        Me.TextBox1.TabIndex = 89
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ComboBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(152, 101)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(151, 26)
        Me.ComboBox3.TabIndex = 88
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(422, 195)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(91, 33)
        Me.RadioButton5.TabIndex = 87
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "*****"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(264, 195)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(67, 33)
        Me.RadioButton4.TabIndex = 86
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "***"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(337, 195)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(79, 33)
        Me.RadioButton3.TabIndex = 85
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "****"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(203, 195)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(55, 33)
        Me.RadioButton2.TabIndex = 84
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "**"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(147, 195)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(43, 33)
        Me.RadioButton1.TabIndex = 83
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "*"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'cmdreport
        '
        Me.cmdreport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdreport.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreport.ForeColor = System.Drawing.Color.Black
        Me.cmdreport.Location = New System.Drawing.Point(286, 373)
        Me.cmdreport.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdreport.Name = "cmdreport"
        Me.cmdreport.Size = New System.Drawing.Size(82, 38)
        Me.cmdreport.TabIndex = 81
        Me.cmdreport.Text = "Report"
        Me.cmdreport.UseVisualStyleBackColor = False
        '
        'cmdclose
        '
        Me.cmdclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdclose.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclose.ForeColor = System.Drawing.Color.Black
        Me.cmdclose.Location = New System.Drawing.Point(398, 374)
        Me.cmdclose.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclose.Name = "cmdclose"
        Me.cmdclose.Size = New System.Drawing.Size(75, 38)
        Me.cmdclose.TabIndex = 80
        Me.cmdclose.Text = "Close"
        Me.cmdclose.UseVisualStyleBackColor = False
        '
        'cmdclear
        '
        Me.cmdclear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdclear.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdclear.ForeColor = System.Drawing.Color.Black
        Me.cmdclear.Location = New System.Drawing.Point(186, 375)
        Me.cmdclear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(72, 36)
        Me.cmdclear.TabIndex = 79
        Me.cmdclear.Text = "Clear"
        Me.cmdclear.UseVisualStyleBackColor = False
        '
        'cmdsave
        '
        Me.cmdsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdsave.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.Black
        Me.cmdsave.Location = New System.Drawing.Point(97, 373)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(59, 38)
        Me.cmdsave.TabIndex = 75
        Me.cmdsave.Text = "Save"
        Me.cmdsave.UseVisualStyleBackColor = False
        '
        'cmdnew
        '
        Me.cmdnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdnew.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdnew.ForeColor = System.Drawing.Color.Black
        Me.cmdnew.Location = New System.Drawing.Point(7, 372)
        Me.cmdnew.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdnew.Name = "cmdnew"
        Me.cmdnew.Size = New System.Drawing.Size(62, 38)
        Me.cmdnew.TabIndex = 74
        Me.cmdnew.Text = "New"
        Me.cmdnew.UseVisualStyleBackColor = False
        '
        'txtfeedbackid
        '
        Me.txtfeedbackid.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtfeedbackid.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfeedbackid.Location = New System.Drawing.Point(152, 55)
        Me.txtfeedbackid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtfeedbackid.Name = "txtfeedbackid"
        Me.txtfeedbackid.Size = New System.Drawing.Size(151, 23)
        Me.txtfeedbackid.TabIndex = 69
        '
        'txtsuggestion
        '
        Me.txtsuggestion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsuggestion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsuggestion.Location = New System.Drawing.Point(140, 271)
        Me.txtsuggestion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtsuggestion.Name = "txtsuggestion"
        Me.txtsuggestion.Size = New System.Drawing.Size(343, 23)
        Me.txtsuggestion.TabIndex = 72
        '
        'lblcustomername
        '
        Me.lblcustomername.AutoSize = True
        Me.lblcustomername.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.Location = New System.Drawing.Point(1, 105)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(145, 22)
        Me.lblcustomername.TabIndex = 73
        Me.lblcustomername.Text = "Customer Name:"
        '
        'lblsuggestion
        '
        Me.lblsuggestion.AutoSize = True
        Me.lblsuggestion.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuggestion.Location = New System.Drawing.Point(5, 268)
        Me.lblsuggestion.Name = "lblsuggestion"
        Me.lblsuggestion.Size = New System.Drawing.Size(102, 22)
        Me.lblsuggestion.TabIndex = 72
        Me.lblsuggestion.Text = "Suggestion:"
        '
        'lblrating
        '
        Me.lblrating.AutoSize = True
        Me.lblrating.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrating.Location = New System.Drawing.Point(5, 206)
        Me.lblrating.Name = "lblrating"
        Me.lblrating.Size = New System.Drawing.Size(67, 22)
        Me.lblrating.TabIndex = 71
        Me.lblrating.Text = "Rating:"
        '
        'lblfeedbackid
        '
        Me.lblfeedbackid.AutoSize = True
        Me.lblfeedbackid.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfeedbackid.Location = New System.Drawing.Point(5, 52)
        Me.lblfeedbackid.Name = "lblfeedbackid"
        Me.lblfeedbackid.Size = New System.Drawing.Size(113, 22)
        Me.lblfeedbackid.TabIndex = 69
        Me.lblfeedbackid.Text = "Feedback ID:"
        '
        'lblbookingid
        '
        Me.lblbookingid.AutoSize = True
        Me.lblbookingid.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookingid.Location = New System.Drawing.Point(5, 149)
        Me.lblbookingid.Name = "lblbookingid"
        Me.lblbookingid.Size = New System.Drawing.Size(105, 22)
        Me.lblbookingid.TabIndex = 70
        Me.lblbookingid.Text = "Booking ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FeedbackIDDataGridViewTextBoxColumn, Me.BookingIDDataGridViewTextBoxColumn, Me.SuggestionDataGridViewTextBoxColumn, Me.RatingDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblFeedbackBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(634, 169)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(443, 366)
        Me.DataGridView1.TabIndex = 22
        '
        'FeedbackIDDataGridViewTextBoxColumn
        '
        Me.FeedbackIDDataGridViewTextBoxColumn.DataPropertyName = "FeedbackID"
        Me.FeedbackIDDataGridViewTextBoxColumn.HeaderText = "FeedbackID"
        Me.FeedbackIDDataGridViewTextBoxColumn.Name = "FeedbackIDDataGridViewTextBoxColumn"
        '
        'BookingIDDataGridViewTextBoxColumn
        '
        Me.BookingIDDataGridViewTextBoxColumn.DataPropertyName = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.HeaderText = "BookingID"
        Me.BookingIDDataGridViewTextBoxColumn.Name = "BookingIDDataGridViewTextBoxColumn"
        '
        'SuggestionDataGridViewTextBoxColumn
        '
        Me.SuggestionDataGridViewTextBoxColumn.DataPropertyName = "Suggestion"
        Me.SuggestionDataGridViewTextBoxColumn.HeaderText = "Suggestion"
        Me.SuggestionDataGridViewTextBoxColumn.Name = "SuggestionDataGridViewTextBoxColumn"
        '
        'RatingDataGridViewTextBoxColumn
        '
        Me.RatingDataGridViewTextBoxColumn.DataPropertyName = "Rating"
        Me.RatingDataGridViewTextBoxColumn.HeaderText = "Rating"
        Me.RatingDataGridViewTextBoxColumn.Name = "RatingDataGridViewTextBoxColumn"
        '
        'TblFeedbackBindingSource1
        '
        Me.TblFeedbackBindingSource1.DataMember = "tblFeedback"
        Me.TblFeedbackBindingSource1.DataSource = Me.Cab_BookingDataSet12
        '
        'Cab_BookingDataSet12
        '
        Me.Cab_BookingDataSet12.DataSetName = "Cab_BookingDataSet12"
        Me.Cab_BookingDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFeedbackBindingSource
        '
        Me.TblFeedbackBindingSource.DataMember = "tblFeedback"
        Me.TblFeedbackBindingSource.DataSource = Me.Cab_BookingDataSet8
        '
        'Cab_BookingDataSet8
        '
        Me.Cab_BookingDataSet8.DataSetName = "Cab_BookingDataSet8"
        Me.Cab_BookingDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFeedbackTableAdapter
        '
        Me.TblFeedbackTableAdapter.ClearBeforeFill = True
        '
        'TblFeedbackTableAdapter1
        '
        Me.TblFeedbackTableAdapter1.ClearBeforeFill = True
        '
        'feedback_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1109, 563)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "feedback_info"
        Me.Text = "feedback_info"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFeedbackBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFeedbackBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cab_BookingDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdreport As System.Windows.Forms.Button
    Friend WithEvents cmdclose As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdnew As System.Windows.Forms.Button
    Friend WithEvents txtfeedbackid As System.Windows.Forms.TextBox
    Friend WithEvents txtsuggestion As System.Windows.Forms.TextBox
    Friend WithEvents lblcustomername As System.Windows.Forms.Label
    Friend WithEvents lblsuggestion As System.Windows.Forms.Label
    Friend WithEvents lblrating As System.Windows.Forms.Label
    Friend WithEvents lblfeedbackid As System.Windows.Forms.Label
    Friend WithEvents lblbookingid As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Cab_BookingDataSet8 As mycab.Cab_BookingDataSet8
    Friend WithEvents TblFeedbackBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFeedbackTableAdapter As mycab.Cab_BookingDataSet8TableAdapters.tblFeedbackTableAdapter
    Friend WithEvents FeedbackIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BookingIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuggestionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RatingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cab_BookingDataSet12 As mycab.Cab_BookingDataSet12
    Friend WithEvents TblFeedbackBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblFeedbackTableAdapter1 As mycab.Cab_BookingDataSet12TableAdapters.tblFeedbackTableAdapter
End Class
