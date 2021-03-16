Imports System.Data.OleDb
Public Class enquiry_info
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
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblEnquiry", con)
        cmd.CommandText = "select max(EnquiryID) as maxid from tblEnquiry"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            num = 1
        Else
            str = CType(maxid, String)
            num = CType(str, String)
            num = num + 1
        End If
        txtenquiryid.Text = num
        con.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into tblEnquiry values(" & txtenquiryid.Text & " , '" & TextBox1.Text & "', '" & txtrequirements.Text & "','" & txtjourneysource.Text & "','" & txtdestination.Text & "','" & TextBox2.Text & "','" & txtcustomername.Text & "'," & txtcontactno.Text & ")", con)
        cmd.ExecuteNonQuery()
        MsgBox("SAVED")
        cmd.Clone()
        con.Close()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        TextBox2.Text = DateTimePicker2.Text
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox1.Text = DateTimePicker1.Text
    End Sub

    Private Sub enquiry_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblEnquiryTableAdapter.Fill(Me.Cab_BookingDataSet7.tblEnquiry)
        TextBox1.Text = DateTimePicker1.Text
        TextBox2.Text = DateTimePicker2.Text
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblEnquiry", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox1.Items.Add(ds.Tables(0).Rows(i).Item(6))
        Next
        con.Close()
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtenquiryid.Text = ""
        txtrequirements.Text = ""
        txtjourneysource.Text = ""
        txtcustomername.Text = ""
        txtcontactno.Text = ""
        txtdestination.Text = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblEnquiry where CustomerName='" & ComboBox1.Text & "'", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtenquiryid.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(1)
        txtrequirements.Text = ds.Tables(0).Rows(0).Item(2)
        txtjourneysource.Text = ds.Tables(0).Rows(0).Item(3)
        txtdestination.Text = ds.Tables(0).Rows(0).Item(4)
        TextBox2.Text = ds.Tables(0).Rows(0).Item(5)
        txtcustomername.Text = ds.Tables(0).Rows(0).Item(6)
        txtcontactno.Text = ds.Tables(0).Rows(0).Item(7)
        con.Close()
        TextBox1.Visible = True
        TextBox2.Visible = True
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False

    End Sub

    Private Sub cmdupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdupdate.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblEnquiry", con)
        cmd.CommandText = "update tblEnquiry set EnquiryDate='" & TextBox1.Text & "',Requirement='" & txtrequirements.Text & "',JourneySource='" & TextBox2.Text & "',JourneyDestination='" & txtdestination.Text & "',JourneyDate='" & TextBox2.Text & "',CustomerName='" & txtcustomername.Text & "',ContactNo=" & txtcontactno.Text & " where EnquiryID=" & txtenquiryid.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox("Values are Updated")
        con.Close()
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
        MDIParent1.Show()

    End Sub

    Private Sub cmdreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreport.Click
        frmenquiry.Show()
    End Sub
End Class