Imports System.Data.OleDb
Public Class driver_info
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim num, result As Integer
    Dim maxid As Object
    Dim str, gender, sql, mSql As String
    Dim a, b As String
    Dim bs As BindingSource
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = DateTimePicker1.Text
    End Sub

    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblDriver", con)
        cmd.CommandText = "select max(DriverID) as maxid from tblDriver"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            num = 1
        Else
            str = CType(maxid, String)
            num = CType(str, String)
            num = num + 1
        End If
        txtdriverid.Text = num
        con.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If RadioButton1.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into tblDriver values(" & txtdriverid.Text & " , '" & txtname.Text & "', " & txtcontactno.Text & ",'" & txtaddress.Text & "'," & txtage.Text & ",'" & gender & "'," & txtdrivinglicenseno.Text & ",'" & TextBox1.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("SAVED")
        cmd.Clone()
        con.Close()
    End Sub

    Private Sub driver_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cab_BookingDataSet10.tblDriver' table. You can move, or remove it, as needed.
        Me.TblDriverTableAdapter.Fill(Me.Cab_BookingDataSet10.tblDriver)
        TextBox1.Text = DateTimePicker1.Text
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblDriver", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item(1))
        Next
        con.Close()
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtdriverid.Text = ""
        txtname.Text = ""
        txtcontactno.Text = ""
        txtaddress.Text = ""
        txtage.Text = ""
        txtdrivinglicenseno.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox2.Visible = True
        TextBox1.Visible = True
        DateTimePicker1.Visible = False
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblDriver where DriverName='" & ComboBox1.Text & "'", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtdriverid.Text = ds.Tables(0).Rows(0).Item(0)
        txtname.Text = ds.Tables(0).Rows(0).Item(1)
        txtcontactno.Text = ds.Tables(0).Rows(0).Item(2)
        txtaddress.Text = ds.Tables(0).Rows(0).Item(3)
        txtage.Text = ds.Tables(0).Rows(0).Item(4)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(5)
        txtdrivinglicenseno.Text = ds.Tables(0).Rows(0).Item(6)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(7)
        con.Close()
        If TextBox1.Text = "Male" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.Visible = True
            DateTimePicker1.Visible = False
        Else
            TextBox1.Visible = False
            DateTimePicker1.Visible = True
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
        cmd = New OleDbCommand("select * from tblDriver", con)
        cmd.CommandText = "update tblDriver set DriverName='" & txtname.Text & "',DriverPh=" & txtcontactno.Text & ",DriverAddress='" & txtaddress.Text & "',DriverAge=" & txtage.Text & ",DriverGender='" & gender & "',DriverLicenseNo=" & txtdrivinglicenseno.Text & ",JoiningDate='" & TextBox1.Text & "' where  DriverID=" & txtdriverid.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox("Values are Updated")
        con.Close()
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        MDIParent1.Show()
        Me.Close()
    End Sub

    Private Sub cmdreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreport.Click
        driverrpt.Show()
    End Sub
End Class