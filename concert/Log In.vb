Imports MySqlConnector

Public Class logInForm
    Public Shared Property LoggedInUserID As Integer

    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        Dim strEmail As String = txtEmail.Text
        Dim strPassword As String = txtPassword.Text
        Dim strUserTypeChoice As String = cmboxUserTypeChoice.Text.ToLower()

        ' Validate user type choice 
        If Not (strUserTypeChoice = "fan" OrElse strUserTypeChoice = "artist") Then
            MsgBox("Please enter either 'fan' or 'artist'")
            Return
        End If

        ' Create a connection string 
        Dim connStr As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"

        Using connection As New MySqlConnection(connStr)
            ' Open the connection 
            connection.Open()

            ' Create an SQL SELECT statement 
            Dim query As String = $"SELECT * FROM {strUserTypeChoice} WHERE email = @email AND password = @password"

            Using command As New MySqlCommand(query, connection)
                ' Add parameters and their values 
                command.Parameters.AddWithValue("@email", strEmail)
                command.Parameters.AddWithValue("@password", strPassword)

                ' Execute the query and get the result
                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        ' User exists in the database
                        MsgBox("Login successful!")

                        ' Read the first row
                        reader.Read()

                        If strUserTypeChoice = "fan" Then
                            ' Store the ID of the logged in user
                            LoggedInUserID = reader.GetInt32("fanID")

                            Dim eventsSelection As New eventSelectionForm()
                            eventsSelection.Show()
                        ElseIf strUserTypeChoice = "artist" Then
                            ' Store the ID of the logged in user
                            LoggedInUserID = reader.GetInt32("artistID")

                            Dim artistDashboard As New artistDashboard()
                            artistDashboard.Show()
                        End If

                        Me.Close()
                    Else
                        ' User does not exist in the database
                        MsgBox("Enter Correct Email or Password")
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class
