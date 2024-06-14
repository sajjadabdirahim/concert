Imports System.CodeDom
Imports MySqlConnector

Public Class venueSeats
    Dim availableIcon As New System.Drawing.Bitmap(My.Resources.Resource1.available)
    Dim provisionalIcon As New System.Drawing.Bitmap(My.Resources.Resource1.provisional)
    Dim bookedIcon As New System.Drawing.Bitmap(My.Resources.Resource1.booked)

    ' In venueSeats add a public property to accept ConcertID 
    Public Property ConcertID As Integer
    Private Sub venueSeats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Control

        For Each c In Controls
            If TypeOf (c) Is PictureBox Then
                CType(c, PictureBox).Image = availableIcon

                AddHandler c.Click, AddressOf PictureBox1_Click
            End If
        Next

        Call UpdateBooking()
    End Sub

    Sub UpdateBooking()
        Dim stSQL As String
        stSQL = "SELECT concertID, fanID, seatID FROM ticket WHERE concertID = @concertID"

        Dim stConString As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"

        Using conBooking As New MySqlConnection(stConString)
            conBooking.Open()

            Using command As New MySqlCommand(stSQL, conBooking)
                command.Parameters.AddWithValue("@concertID", Me.ConcertID)
                Dim dsBookings As New DataSet

                Dim daBookings As New MySqlDataAdapter(command)

                daBookings.Fill(dsBookings, "ticket")

                conBooking.Close()

                Dim t1 As DataTable = dsBookings.Tables("ticket")
                Dim row As DataRow

                For Each row In t1.Rows
                    CType(Controls("PictureBox" & row(2)), PictureBox).Image = bookedIcon
                Next
            End Using
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        If CType(sender, PictureBox).Image Is availableIcon Then
            CType(sender, PictureBox).Image = provisionalIcon
        ElseIf CType(sender, PictureBox).Image Is provisionalIcon Then
            CType(sender, PictureBox).Image = availableIcon
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim c As Control
        Dim bSelected As Boolean

        For Each c In Controls
            If TypeOf (c) Is PictureBox Then
                If CType(c, PictureBox).Image Is provisionalIcon Then
                    bSelected = True
                    Exit For

                End If
            End If
        Next

        If bSelected = False Then
            MsgBox("Please Select atleast one seat to book")
            Exit Sub
        End If

        Dim stSQLInsert As String
        'stSQLInsert = "INSERT INTO ticket (concertID, fanID, seatID) VALUES(3, 2, 85)"

        Dim stConString As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"

        Using conBooking As New MySqlConnection(stConString)
            conBooking.Open()

            Using comMakeBooking As New MySqlCommand(stSQLInsert, conBooking)
                Dim iSeatNum As Integer

                For Each c In Controls
                    If TypeOf (c) Is PictureBox Then
                        If CType(c, PictureBox).Image Is provisionalIcon Then

                            iSeatNum = Mid(CType(c, PictureBox).Name, 11)

                            stSQLInsert = "INSERT INTO ticket (concertID, fanID, seatID) VALUES('" & Me.ConcertID & "', '" & logInForm.LoggedInUserID & "', '" & iSeatNum & "')"

                            comMakeBooking.CommandText = stSQLInsert
                            comMakeBooking.ExecuteNonQuery()
                            'MsgBox(iSeatNum)

                        End If
                        AddHandler c.Click, AddressOf PictureBox1_Click
                    End If
                Next

                conBooking.Close()
            End Using
        End Using

        Call UpdateBooking()

        Dim fanOutput As New ticketForm()
        fanOutput.ConcertID = Me.ConcertID ' Set ConcertID
        fanOutput.LoggedInUserID = logInForm.LoggedInUserID ' Set LoggedInUserID
        fanOutput.Show()
    End Sub
End Class