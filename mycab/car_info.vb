Imports System.Data.OleDb
Public Class car_info
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
        cmd = New OleDbCommand("select * from tblCar", con)
        cmd.CommandText = "select max(CarID) as maxid from tblCar"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            num = 1
        Else
            str = CType(maxid, String)
            num = CType(str, String)
            num = num + 1
        End If
        txtcarid.Text = num
        con.Close()
        txtregistrationno.Select()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into tblCar values(" & txtcarid.Text & " , " & txtregistrationno.Text & ", '" & txtcarmodel.Text & "'," & txtchasisno.Text & "," & ComboBox2.Text & ")", con)
        cmd.ExecuteNonQuery()
        MsgBox("SAVED")
        cmd.Clone()
        con.Close()
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtcarid.Text = ""
        txtcarmodel.Text = ""
        txtchasisno.Text = ""
        txtregistrationno.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub car_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cab_BookingDataSet5.tblCar' table. You can move, or remove it, as needed.
        Me.TblCarTableAdapter.Fill(Me.Cab_BookingDataSet5.tblCar)
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCar", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox4.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        con.Close()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCarType", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox2.Items.Add(ds.Tables(0).Rows(i).Item(0))
        Next
        con.Close()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCar where CarID=" & ComboBox4.Text & "", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtcarid.Text = ds.Tables(0).Rows(0).Item(0)
        txtregistrationno.Text = ds.Tables(0).Rows(0).Item(1)
        txtcarmodel.Text = ds.Tables(0).Rows(0).Item(2)
        txtchasisno.Text = ds.Tables(0).Rows(0).Item(3)
        ComboBox2.Text = ds.Tables(0).Rows(0).Item(4)
        con.Close()
    End Sub

    Private Sub cmdremove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdremove.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCar", con)
        cmd.CommandText = "update tblCar set RegistrationNo=" & txtregistrationno.Text & ",CarModel='" & txtcarmodel.Text & "',ChassisNo=" & txtchasisno.Text & ",CarTypeId=" & ComboBox2.Text & " where CarID=" & txtcarid.Text & ""
        cmd.ExecuteNonQuery()
        MsgBox("Values are Updated")
        con.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblCarType where CarTypeId=" & ComboBox2.Text & "", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        con.Close()
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
        MDIParent1.Show()

    End Sub
End Class