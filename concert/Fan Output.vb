Imports MySqlConnector

Public Class ticketForm
    ' Declare ConcertID and LoggedInUserID as class-level variables
    Public Property ConcertID As Integer
    Public Property LoggedInUserID As Integer

    Private Sub ticketForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stConString As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"

        Using con As New MySqlConnection(stConString)
            con.Open()

            ' Get fan name
            Dim stSQLFanName As String = "SELECT fanName FROM fan WHERE fanID = @fanID"
            Using cmdFanName As New MySqlCommand(stSQLFanName, con)
                cmdFanName.Parameters.AddWithValue("@fanID", LoggedInUserID) ' Use the class-level variable
                lblName.Text = cmdFanName.ExecuteScalar().ToString()
            End Using

            ' Get concert name and price
            Dim stSQLConcertInfo As String = "SELECT concertName, ticketPrice FROM concert WHERE concertID = @concertID"
            Using cmdConcertInfo As New MySqlCommand(stSQLConcertInfo, con)
                cmdConcertInfo.Parameters.AddWithValue("@concertID", ConcertID) ' Use the class-level variable
                Using reader As MySqlDataReader = cmdConcertInfo.ExecuteReader()
                    If reader.Read() Then
                        lblConcertName.Text = reader("concertName").ToString()
                        lblPrice.Text = reader("ticketPrice").ToString()
                    End If
                End Using
            End Using

            ' Get venue name
            Dim stSQLVenueName As String = "SELECT v.VenueName FROM venue v INNER JOIN concert c ON v.VenueID = c.venueID WHERE c.concertID = @concertID"
            Using cmdVenueName As New MySqlCommand(stSQLVenueName, con)
                cmdVenueName.Parameters.AddWithValue("@concertID", ConcertID) ' Use the class-level variable
                lblVenue.Text = cmdVenueName.ExecuteScalar().ToString()
            End Using

            ' Get seats booked
            Dim stSQLSeats As String = "SELECT s.row, s.seatNo FROM seats s INNER JOIN ticket t ON s.seatID = t.seatID WHERE t.concertID = @concertID AND t.fanID = @fanID"
            Using cmdSeats As New MySqlCommand(stSQLSeats, con)
                cmdSeats.Parameters.AddWithValue("@concertID", ConcertID) ' Use the class-level variable
                cmdSeats.Parameters.AddWithValue("@fanID", LoggedInUserID) ' Use the class-level variable
                Using reader As MySqlDataReader = cmdSeats.ExecuteReader()
                    While reader.Read()
                        lblSeats.Text += reader("row").ToString() & reader("seatNo").ToString() & ", "
                    End While
                    ' Remove the last comma and space
                    If lblSeats.Text.Length > 0 Then
                        lblSeats.Text = lblSeats.Text.Substring(0, lblSeats.Text.Length - 2)
                    End If
                End Using
            End Using

            ' Get ticketID
            Dim stSQLTicketID As String = "SELECT ticketID FROM ticket WHERE concertID = @concertID AND fanID = @fanID LIMIT 1"
            Using cmdTicketID As New MySqlCommand(stSQLTicketID, con)
                cmdTicketID.Parameters.AddWithValue("@concertID", ConcertID) ' Use the class-level variable
                cmdTicketID.Parameters.AddWithValue("@fanID", LoggedInUserID) ' Use the class-level variable
                lblTicketID.Text = "TK00" & cmdTicketID.ExecuteScalar().ToString()
            End Using


            ' Get concert date
            Dim stSQLConcertDate As String = "SELECT concertDate FROM concert WHERE concertID = @concertID"
            Using cmdConcertDate As New MySqlCommand(stSQLConcertDate, con)
                cmdConcertDate.Parameters.AddWithValue("@concertID", ConcertID) ' Use the class-level variable
                lblConcertDate.Text = cmdConcertDate.ExecuteScalar().ToString()
            End Using

            ' Get total price
            Dim stSQLTotalPrice As String = "SELECT COUNT(*) * c.ticketPrice FROM ticket t INNER JOIN concert c ON t.concertID = c.concertID WHERE t.concertID = @concertID AND t.fanID = @fanID"
            Using cmdTotalPrice As New MySqlCommand(stSQLTotalPrice, con)
                cmdTotalPrice.Parameters.AddWithValue("@concertID", ConcertID) ' Use the class-level variable
                cmdTotalPrice.Parameters.AddWithValue("@fanID", LoggedInUserID) ' Use the class-level variable
                lblTotalPrice.Text = cmdTotalPrice.ExecuteScalar().ToString()
            End Using

            con.Close()
        End Using
    End Sub
End Class
