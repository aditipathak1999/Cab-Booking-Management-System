Public Class loading

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        PictureBox1.Location = New Point(PictureBox1.Location.X + 5.8, PictureBox1.Location.Y)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            MDIParent1.Show()
            Me.Hide()
            login.Hide()
            ProgressBar1.Value = 0
        End If
        Label1.Text = ProgressBar1.Value & (" %")
    End Sub

    Private Sub loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class