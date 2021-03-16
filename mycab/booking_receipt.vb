Imports System.Data.OleDb
Public Class booking_receipt
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim num, result As Integer
    Dim maxid As Object
    Dim str, gender, sql, mSql As String
    Dim a, b As String
    Dim bs As BindingSource
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim sum As Integer
    Dim tax As Double
    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBill", con)
        cmd.CommandText = "select max(BillID) as maxid from tblBill"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            num = 1
        Else
            str = CType(maxid, String)
            num = CType(str, String)
            num = num + 1
        End If
        txtbillid.Text = num
        con.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcarid.TextChanged

    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into tblBill values(" & txtbillid.Text & " , '" & txtbilldate.Text & "', " & txttotalkms.Text & "," & txttotalwaiting.Text & "," & txtrateperkm.Text & "," & txttaxamt.Text & "," & txttotalamt.Text & ",'" & ComboBox3.Text & "','" & txtpaymentdetails.Text & "'," & txtcustomer_id.Text & "," & txtcarid.Text & "," & txtdriverid.Text & "," & ComboBox2.Text & "," & txtextracharges.Text & ",'" & txtnarration.Text & "','" & ComboBox1.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("SAVED")
        cmd.Clone()
        con.Close()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        txtbilldate.Text = DateTimePicker2.Value
    End Sub

    Private Sub booking_receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cab_BookingDataSet4.tblBill' table. You can move, or remove it, as needed.
        Me.TblBillTableAdapter.Fill(Me.Cab_BookingDataSet4.tblBill)
        txtbilldate.Text = DateTimePicker2.Value
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBill", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox4.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        con.Close()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblDriver", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox5.Items.Add(ds.Tables(0).Rows(i).Item(1))
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
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBooking", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox2.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub cmdcalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcalculate.Click
        sum = (Val(txtrateperkm.Text) * Val(txttotalkms.Text)) + Val(txttotalwaiting.Text) + Val(txtextracharges.Text)
        tax = sum * 0.8
        txttaxamt.Text = tax
        txttotalamt.Text = tax + sum
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "PAYTM" Then
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtbillid.Text = ""
        txttotalkms.Text = ""
        txttotalwaiting.Text = ""
        txttaxamt.Text = ""
        txtrateperkm.Text = ""
        txttotalamt.Text = ""
        ComboBox3.Text = ""
        txtpaymentdetails.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        txtextracharges.Text = ""
        txtnarration.Text = ""
        txtcarid.Text = ""
        txtcustomer_id.Text = ""
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBill where BillID=" & ComboBox4.Text & "", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtbillid.Text = ds.Tables(0).Rows(0).Item(0)
        txtbilldate.Text = ds.Tables(0).Rows(0).Item(1)
        txttotalkms.Text = ds.Tables(0).Rows(0).Item(2)
        txttotalwaiting.Text = ds.Tables(0).Rows(0).Item(3)
        txtrateperkm.Text = ds.Tables(0).Rows(0).Item(4)
        txttaxamt.Text = ds.Tables(0).Rows(0).Item(5)
        txttotalamt.Text = ds.Tables(0).Rows(0).Item(6)
        ComboBox3.Text = ds.Tables(0).Rows(0).Item(7)
        txtpaymentdetails.Text = ds.Tables(0).Rows(0).Item(8)
        ComboBox1.Text = ds.Tables(0).Rows(0).Item(9)
        txtcarid.Text = ds.Tables(0).Rows(0).Item(10)
        txtdriverid.Text = ds.Tables(0).Rows(0).Item(11)
        ComboBox2.Text = ds.Tables(0).Rows(0).Item(12)
        txtextracharges.Text = ds.Tables(0).Rows(0).Item(13)
        txtnarration.Text = ds.Tables(0).Rows(0).Item(14)
        txtcustomer_id.Text = ds.Tables(0).Rows(0).Item(15)

        con.Close()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblDriver where DriverName='" & ComboBox5.Text & "'", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        'txtdriverid.Text = ds.Tables(0).Rows(0).Item(0)
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCustomer where CustomerName='" & ComboBox1.Text & "'", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtcustomer_id.Text = ds.Tables(0).Rows(0).Item(0)
        con.Close()
    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtcustomerid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcustomer_id.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBill where BookingID=" & ComboBox2.Text & "", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        con.Close()
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBill", con)
        cmd.CommandText = "update tblBill set BillDate='" & txtbilldate.Text & "',TotalKms=" & txttotalkms.Text & ",TotalWaiting=" & txttotalwaiting.Text & ",Rate=" & txtrateperkm.Text & ",Tax=" & txttaxamt.Text & ",TotalAmt=" & txttotalamt.Text & ",PaymentMode='" & ComboBox3.Text & "',PaymentDetails='" & txtpaymentdetails.Text & "',CustomerID=" & txtcustomer_id.Text & ",CarID=" & txtcarid.Text & ",DriverID=" & txtdriverid.Text & ",BookingID=" & ComboBox2.Text & ",ExtraCharges=" & txtextracharges.Text & ",Narration='" & txtnarration.Text & "',CustomerName='" & ComboBox1.Text & "' where BillID=" & txtbillid.Text & ""
        'cmd.ExecuteNonQuery()
        MsgBox("Values are Updated")
        con.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
        MDIParent1.Show()

    End Sub
End Class