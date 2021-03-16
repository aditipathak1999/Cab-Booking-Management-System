Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BILLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BILLToolStripMenuItem.Click
        booking_receipt.Show()
    End Sub

    Private Sub BookingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingToolStripMenuItem.Click
        booking_info.Show()
    End Sub

    Private Sub CarInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarInfoToolStripMenuItem.Click
        car_info.Show()
    End Sub

    Private Sub CarTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarTypeToolStripMenuItem.Click
        car_type_info.Show()
    End Sub

    Private Sub DriverInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriverInfoToolStripMenuItem.Click
        driver_info.Show()
    End Sub

    Private Sub EnquiryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnquiryToolStripMenuItem.Click
        enquiry_info.Show()
    End Sub

    Private Sub CustomerInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerInfoToolStripMenuItem.Click
        customer_info.Show()
    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeedbackToolStripMenuItem.Click
        feedback_info.Show()
    End Sub

    Private Sub SingOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingOutToolStripMenuItem.Click
        Me.Close()
        login.Show()

    End Sub

    Private Sub BookingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingReportToolStripMenuItem.Click
        bookinginforpt.Show()
    End Sub

    Private Sub BillReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillReportToolStripMenuItem.Click
        bookingreceiptrpt.Show()
    End Sub

    Private Sub EnquiryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnquiryReportToolStripMenuItem.Click
        frmenquiry.Show()

    End Sub

    Private Sub CarReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CarReportToolStripMenuItem.Click
        customerrpt.Show()

    End Sub

    Private Sub DriverReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriverReportToolStripMenuItem.Click
        driverrpt.Show()

    End Sub

    Private Sub FeedbackReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeedbackReportToolStripMenuItem.Click
        feedbackrep.Show()
    End Sub
End Class
