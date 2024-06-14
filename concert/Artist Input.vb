Imports MySqlConnector


Public Class venueBookingForm
    Private Sub venueBookingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connection string to connect to MySQL database.
        Dim connectionString As String = "server=localhost;user id=root;password='Saju4002';database=concertdb;"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' SQL command to select all venues from the venue table.
            Using command As New MySqlCommand("SELECT * FROM venue", connection)
                ' Execute the SQL command.
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Add each venue to the ComboBox.
                        cmboxVenue.Items.Add(New VenueItem With {.Text = reader.GetString("VenueName"), .Value = reader.GetInt32("VenueID")})
                    End While
                End Using
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim strConcertName As String = txtConcertName.Text
        Dim strArtistID As String = logInForm.LoggedInUserID.ToString() ' Set the artistID to the logged in user's ID.
        Dim strVenueID As String = CType(cmboxVenue.SelectedItem, VenueItem).Value
        Dim strTicketPrice As String = txtTicketPrice.Text
        Dim datePicked As Date = DateTimePicker1.Value

        ' Connection string to connect to MySQL database.
        Dim connectionString As String = "server=localhost;user id=root;password='Saju4002';database=concertdb;"

        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' SQL command to insert data into concert table.
            Using command As New MySqlCommand("INSERT INTO concert (concertName, artistID, venueID, ticketPrice, concertDate) VALUES (@concertName, @artistID, @venueID, @ticketPrice, @concertDate)", connection)
                command.Parameters.AddWithValue("@concertName", strConcertName)
                command.Parameters.AddWithValue("@artistID", Int32.Parse(strArtistID))
                command.Parameters.AddWithValue("@venueID", Int32.Parse(strVenueID))
                command.Parameters.AddWithValue("@ticketPrice", Decimal.Parse(strTicketPrice))
                command.Parameters.AddWithValue("@concertDate", datePicked)

                ' Execute the SQL command.
                command.ExecuteNonQuery()
            End Using

            connection.Close()
        End Using
    End Sub
End Class
