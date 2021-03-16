Imports System.Data.OleDb
Public Class customer_info
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim num, result As Integer
    Dim maxid As Object
    Dim str, gender, sql, mSql As String
    Dim a, b As String
    Dim bs As BindingSource
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        DataGridView1.Refresh()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCustomer", con)
        cmd.CommandText = "select max(CustomerID) as maxid from tblCustomer"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            num = 1
        Else
            str = CType(maxid, String)
            num = CType(str, String)
            num = num + 1
        End If
        txtcustomerid.Text = num
        con.Close()
        txtcustomerid.Select()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If RadioButton1.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into tblCustomer values(" & txtcustomerid.Text & " , '" & txtname.Text & "', '" & txtaddress.Text & "','" & gender & "'," & txtcontactno.Text & ")", con)
        cmd.ExecuteNonQuery()
        MsgBox("SAVED")
        clear()
        cmd.Clone()
        con.Close()
    End Sub
    Private Sub clear()
        txtcustomerid.Text = ""
        txtenquiryid.Text = ""
        txtname.Text = ""
        Panel1.Text = ""
        txtcontactno.Text = ""
        txtaddress.Text = ""
    End Sub

    Private Sub customer_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cab_BookingDataSet1.tblCustomer' table. You can move, or remove it, as needed.
        Me.TblCustomerTableAdapter.Fill(Me.Cab_BookingDataSet1.tblCustomer)
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCustomer", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox2.Items.Add(ds.Tables(0).Rows(i).Item(1))
        Next
        con.Close()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCustomer where CustomerName='" & ComboBox2.Text & "'", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtcustomerid.Text = ds.Tables(0).Rows(0).Item(0)
        txtname.Text = ds.Tables(0).Rows(0).Item(1)
        txtaddress.Text = ds.Tables(0).Rows(0).Item(2)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(3)
        txtcontactno.Text = ds.Tables(0).Rows(0).Item(4)
        con.Close()
        If TextBox1.Text = "Male" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        If RadioButton1.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCustomer", con)
        cmd.CommandText = "update tblCustomer set CustomerName='" & txtname.Text & "',CustomerAddress='" & txtaddress.Text & "',CustomerPhoneNo=" & txtcontactno.Text & " where CustomerID=" & txtcustomerid.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox("Values are Updated")
        con.Close()
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtcustomerid.Text = ""
        txtname.Text = ""
        txtaddress.Text = ""
        txtcontactno.Text = ""
        txtenquiryid.Text = ""
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
        MDIParent1.Show()

    End Sub

    Private Sub cmdreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreport.Click
        customerrpt.Show()
    End Sub
End Class