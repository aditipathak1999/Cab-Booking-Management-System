Imports System.Data.OleDb

Public Class booking_info
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim num, result As Integer
    Dim maxid As Object
    Dim str, type, sql, mSql As String
    Dim a, b As String
    Dim bs As BindingSource
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click

        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBooking", con)
        cmd.CommandText = "select max(BookingID) as maxid from tblBooking"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            num = 1
        Else
            str = CType(maxid, String)
            num = CType(str, String)
            num = num + 1
        End If
        txtbookingid.Text = num
        con.Close()
        txtbookingid.Select()
    End Sub

    Private Sub booking_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cab_BookingDataSet11.tblBooking' table. You can move, or remove it, as needed.
        Me.TblBookingTableAdapter2.Fill(Me.Cab_BookingDataSet11.tblBooking)

        txtjourneydate.Text = DateTimePicker1.Value
        txtbookingdate.Text = DateTimePicker2.Value
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBooking", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox4.Items.Add(ds.Tables(0).Rows(i).Item(12))
        Next
        con.Close()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCustomer", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item(1))
        Next
        con.Close()
        con.Close()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCarType", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox3.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If RadioButton4.Checked = True Then
            type = "AC"
        Else
            type = "NonAC"
        End If
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into tblBooking values(" & txtbookingid.Text & " , '" & txtbookingdate.Text & "', '" & txtpickuppoint.Text & "','" & txtdroppoint.Text & "','" & txtjourneydate.Text & "','" & txtpickuptime.Text & "'," & txtrateperkm.Text & ",'" & type & "','" & txtcartype.Text & "'," & txtkmexpected.Text & "," & ComboBox3.Text & "," & txtdriverid.Text & ",'" & ComboBox1.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("SAVED")
        cmd.Clone()
        con.Close()

    End Sub
    Private Sub clear()
        txtbookingid.Text = ""
        txtpickuppoint.Text = ""
        txtdroppoint.Text = ""
        txtpickuptime.Text = ""
        txtrateperkm.Text = ""
        txtcartype.Text = ""
        txtkmexpected.Text = ""
        ComboBox3.Text = ""
        txtdriverid.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBooking where CustomerName='" & ComboBox4.Text & "'", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtbookingid.Text = ds.Tables(0).Rows(0).Item(0)
        txtbookingdate.Text = ds.Tables(0).Rows(0).Item(1)
        txtpickuppoint.Text = ds.Tables(0).Rows(0).Item(2)
        txtdroppoint.Text = ds.Tables(0).Rows(0).Item(3)
        txtjourneydate.Text = ds.Tables(0).Rows(0).Item(4)
        txtpickuptime.Text = ds.Tables(0).Rows(0).Item(5)
        txtrateperkm.Text = ds.Tables(0).Rows(0).Item(6)
        txtcartype.Text = ds.Tables(0).Rows(0).Item(8)
        txtkmexpected.Text = ds.Tables(0).Rows(0).Item(9)
        ComboBox3.Text = ds.Tables(0).Rows(0).Item(10)
        '  txtdriverid.Text = ds.Tables(0).Rows(0).Item(11)
        ComboBox1.Text = ComboBox4.Text
        con.Close()
        txtjourneydate.Visible = True
        txtbookingdate.Visible = True
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtjourneydate.Text = DateTimePicker2.Value
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        txtbookingdate.Text = DateTimePicker2.Value
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub cmdremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        If RadioButton4.Checked = True Then
            type = "AC"
        Else
            type = "NonAC"
        End If
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBooking", con)
        cmd.CommandText = "update tblBooking set BookingDate='" & txtbookingdate.Text & "',PickupPoint='" & txtpickuppoint.Text & "',DropPoint='" & txtdroppoint.Text & "',JourneyDate='" & txtjourneydate.Text & "',PickupTime=" & txtpickuptime.Text & ",Rate=" & txtrateperkm.Text & ",AC/NON-AC='" & type & "',CarType='" & txtcartype.Text & "',KmExpeceted=" & txtkmexpected.Text & ",CarID=" & ComboBox3.Text & ",DriverID=" & txtdriverid.Text & ",CustomerName='" & ComboBox1.Text & "' where BookingID=" & txtbookingid.Text & ""
        MsgBox("Values are Updated")
        con.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsearch.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCarType where CarTypeID=" & ComboBox3.Text & "", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtcartype.Text = ds.Tables(0).Rows(0).Item(1)
        con.Close()
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
        MDIParent1.Show()

    End Sub
End Class