Imports MySqlConnector

Public Class artistForm
    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        Dim strArtistName As String = txtArtistName.Text
        Dim strCitizenship As String = txtCitizenship.Text
        Dim strGenre As String = txtGenre.Text
        Dim strEmail As String = txtEmail.Text
        Dim strPassword As String = txtPassword.Text
        Dim strTelephone As String = txtTelephone.Text

        Dim connectionString As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"
        Using connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("INSERT INTO artist (artistName, Citizenship, Genre, email, password, PhoneNumber) VALUES (@artistName, @Citizenship, @Genre, @Email, @Password, @PhoneNumber)", connection)

            command.Parameters.AddWithValue("@artistName", strArtistName)
            command.Parameters.AddWithValue("@Citizenship", strCitizenship)
            command.Parameters.AddWithValue("@Genre", strGenre)
            command.Parameters.AddWithValue("@email", strEmail)
            command.Parameters.AddWithValue("@password", strPassword)
            command.Parameters.AddWithValue("@PhoneNumber", strTelephone)

            connection.Open()
            command.ExecuteNonQuery()
        End Using

        MsgBox("Succesfully Registered " & strArtistName)
        Me.Close()
    End Sub

    'Private Sub artistForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    mainDashboard.Hide()
    'End Sub

    'Private Sub artistForm_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
    '    mainDashboard.Show()
    'End Sub
End Class