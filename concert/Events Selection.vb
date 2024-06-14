Imports MySqlConnector
Public Class eventSelectionForm

    'Declare concertID as a class-level variable()
    Private concertID As Integer
    Private Sub eventSelectionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Populate the ListBox with concertName from the concert table
        Dim stConString As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"
        Using con As New MySqlConnection(stConString)
            con.Open()
            Dim stSQL As String = "SELECT concertName FROM concert WHERE concertDate >= CURDATE()"
            Using cmd As New MySqlCommand(stSQL, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        ' Assuming your ListBox is named lstConcertName
                        lstConcertName.Items.Add(reader("concertName").ToString())
                    End While
                End Using
            End Using
            con.Close()
        End Using
    End Sub

    Private Sub lstConcertName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConcertName.SelectedIndexChanged
        Dim concertName As String = lstConcertName.SelectedItem.ToString()

        ' Get concertID based on selected concertName
        Dim stConString As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"
        Using con As New MySqlConnection(stConString)
            con.Open()
            Dim stSQL As String = "SELECT concertID FROM concert WHERE concertName = @concertName"
            Using cmd As New MySqlCommand(stSQL, con)
                cmd.Parameters.AddWithValue("@concertName", concertName)
                ' Store concertID in the class-level variable
                concertID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            con.Close()
        End Using
    End Sub

    Private Sub eventSelectionForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        mainDashboard.Show()
    End Sub

    Private Sub ticketBtn_Click(sender As Object, e As EventArgs) Handles ticketBtn.Click
        ' Check if a concert has been selected
        If concertID <> 0 Then
            ' Pass this ID to venueSeats form
            Dim seatBooking As New venueSeats()
            seatBooking.ConcertID = concertID
            seatBooking.Show()

            Me.Close()
        Else
            ' Show a message if no concert has been selected
            MessageBox.Show("Please select a concert first.")
        End If
    End Sub

End Class
