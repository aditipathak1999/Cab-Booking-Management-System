Imports System.Data.OleDb
Public Class feedback_info
    Dim con As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim num, result As Integer
    Dim maxid As Object
    Dim str, rate, sql, mSql As String
    Dim a, b As String
    Dim bs As BindingSource
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim dr As OleDbDataReader
    Private Sub cmdnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdnew.Click
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblFeedback", con)
        cmd.CommandText = "select max(FeedbackID) as maxid from tblFeedback"
        maxid = cmd.ExecuteScalar
        If maxid Is DBNull.Value Then
            num = 1
        Else
            str = CType(maxid, String)
            num = CType(str, String)
            num = num + 1
        End If
        txtfeedbackid.Text = num
        con.Close()
    End Sub

    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        If RadioButton1.Checked = True Then
            rate = 1
        ElseIf RadioButton2.Checked = True Then
            rate = 2
        ElseIf RadioButton4.Checked = True Then
            rate = 3
        ElseIf RadioButton3.Checked = True Then
            rate = 4
        Else : rate = 5
        End If
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("insert into tblFeedback values(" & txtfeedbackid.Text & " , " & TextBox1.Text & ", '" & txtsuggestion.Text & "'," & rate & ",'" & ComboBox3.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("SAVED")
        cmd.Clone()
        con.Close()
    End Sub

    Private Sub cmdclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclear.Click
        txtfeedbackid.Text = ""
        txtsuggestion.Text = ""
        TextBox1.Text = ""
        ComboBox3.Text = ""
    End Sub

    Private Sub feedback_info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Cab_BookingDataSet12.tblFeedback' table. You can move, or remove it, as needed.
        Me.TblFeedbackTableAdapter1.Fill(Me.Cab_BookingDataSet12.tblFeedback)

        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblFeedback", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox2.Items.Add(ds.Tables(0).Rows(i).Item(4))
        Next
        con.Close()
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBooking", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            ComboBox3.Items.Add(ds.Tables(0).Rows(i).Item(12))
        Next
        con.Close()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblFeedback where Customer_Name='" & ComboBox2.Text & "'", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        txtfeedbackid.Text = ds.Tables(0).Rows(0).Item(0)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(1)
        txtsuggestion.Text = ds.Tables(0).Rows(0).Item(2)
        ComboBox3.Text = ds.Tables(0).Rows(0).Item(4)
        con.Close()
       

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        con.Open()
        cmd = New OleDbCommand("select * from tblBooking where CustomerName='" & ComboBox3.Text & "'", con)
        da = New OleDbDataAdapter(cmd)
        ds = New DataSet("mytable")
        da.Fill(ds)
        TextBox1.Text = ds.Tables(0).Rows(0).Item(0)
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdclose.Click
        Me.Close()
        MDIParent1.Show()

    End Sub

    Private Sub cmdreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdreport.Click
        feedbackrep.Show()
    End Sub
End Class