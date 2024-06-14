Public Class artistDashboard
    Private Sub venueBookingBtn_Click(sender As Object, e As EventArgs) Handles venueBookingBtn.Click
        Dim venueBooking As New venueBookingForm()
        venueBooking.Show()
    End Sub

    Private Sub analysisBtn_Click(sender As Object, e As EventArgs) Handles analysisBtn.Click
        Dim artistOutPut As New artistOutputForm()
        artistOutPut.Show()

    End Sub
End Class