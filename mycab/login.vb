Imports System.Data.OleDb
Public Class login
    Dim a, b, c As String
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim cn As OleDbConnection
    
    Private Sub cmdlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdlogin.Click
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\mycab\Cab_Booking.mdb")
        cmd = New OleDbCommand("Select * from tbllogin where User= '" & txtusername.Text & "' and Pass='" & txtpassword.Text & "' ", cn)
        cn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            a = dr("User")
            c = dr("Pass")
            If (txtusername.Text = a And txtpassword.Text = c) Then b = a
            MessageBox.Show("Welcome")
            loading.Show()
        Else
            MsgBox("Incorrect Username/Password")
            clear()
            txtusername.Select()
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub clear()
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.Close()
    End Sub


    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged

    End Sub
End Class
