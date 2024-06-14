Imports MySqlConnector

Public Class artistOutputForm
    Private Sub ArtistOutputForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assuming artistID is obtained from the login
        Dim artistID As Integer = logInForm.LoggedInUserID

        Dim connStr As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"

        Using connection As New MySqlConnection(connStr)
            connection.Open()

            ' SQL query to get all concerts based on artistID
            Dim query As String = $"SELECT c.concertName FROM concert c WHERE c.artistID = @artistId"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@artistId", artistID)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Populate the ComboBox with concert names
                            cmbConcertNames.Items.Add(reader.GetString("concertName"))
                        End While
                    Else
                        ' No concerts found for this artist
                        MsgBox("No concerts found.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub cmbConcertNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbConcertNames.SelectedIndexChanged
        ' Get selected concert name
        Dim selectedConcert As String = cmbConcertNames.SelectedItem.ToString()

        Dim artistID As Integer = logInForm.LoggedInUserID

        Dim connStr As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"

        Using connection As New MySqlConnection(connStr)
            connection.Open()

            ' SQL query to get all needed information based on artistID and selected concert
            Dim query As String = $"SELECT c.concertName, a.artistName, v.VenueName, c.concertDate,
                                    COUNT(t.ticketID) as bookedSeats, c.ticketPrice,
                                    v.VenuePricing FROM concert c 
                                    INNER JOIN artist a ON c.artistID = a.artistID 
                                    INNER JOIN venue v ON c.venueID = v.VenueID 
                                    LEFT JOIN ticket t ON c.concertID = t.concertID 
                                    WHERE a.artistID = @artistId AND c.concertName = @concertName GROUP BY c.concertId"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@artistId", artistID)
                command.Parameters.AddWithValue("@concertName", selectedConcert)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            ' Populate the fields on the form with data from database
                            lblConcertName.Text = reader.GetString("concertName")
                            lblArtist.Text = reader.GetString("artistName")
                            lblVenue.Text = reader.GetString("VenueName")
                            lblConcertDate.Text = reader.GetDateTime("concertDate").ToString()

                            Dim bookedSeats As Integer = reader.GetInt32("bookedSeats")
                            lblBookedSeats.Text = bookedSeats.ToString()

                            Dim ticketPrice As Decimal = reader.GetDecimal("ticketPrice")
                            lblTicketPrice.Text = ticketPrice.ToString()

                            Dim totalIncome As Decimal = bookedSeats * ticketPrice
                            lblTotalIncome.Text = totalIncome.ToString()

                            Dim venueCost As Decimal = reader.GetDecimal("VenuePricing")
                            lblVenueCost.Text = venueCost.ToString()

                            lblCost.Text = "(" & lblVenueCost.Text & ")"

                            Dim profit As Decimal = totalIncome - venueCost
                            lblProfit.Text = profit.ToString()
                        End While
                    Else
                        ' No concerts found for this artist
                        MsgBox("No concerts found.")
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class