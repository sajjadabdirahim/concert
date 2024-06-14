Imports MySqlConnector

Public Class fanSignUpForm
    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        Dim strFullName As String = txtFirstName.Text
        Dim strEmail As String = txtEmail.Text
        Dim strPassword As String = txtPassword.Text
        Dim strTelephoneNumber As String = txtTelephoneNumber.Text

        ' Check if any of the fields are empty
        If strFullName = "" Or strEmail = "" Or strPassword = "" Or strTelephoneNumber = "" Then
            MsgBox("All fields must be filled out")
            Return
        End If

        ' Create a connection string 
        Dim connStr As String = "server=localhost;userid=root;password=Saju4002;database=concertdb"

        Using connection As New MySqlConnection(connStr)
            ' Open the connection 
            connection.Open()

            ' Create an SQL INSERT INTO statement 
            Dim query As String = "INSERT INTO fan (fanName, email, password, phoneNumber) VALUES (@fanName, @email, @password, @phoneNumber)"

            Using command As New MySqlCommand(query, connection)
                ' Add parameters and their values 
                command.Parameters.AddWithValue("@fanName", strFullName)
                command.Parameters.AddWithValue("@email", strEmail)
                command.Parameters.AddWithValue("@password", strPassword)
                command.Parameters.AddWithValue("@phoneNumber", strTelephoneNumber)

                ' Execute the query 
                command.ExecuteNonQuery()
            End Using

            MsgBox(strFullName & " has been added successfully!")
            Me.Close()
        End Using
    End Sub


    'Private Sub fanSignUpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    mainDashboard.Hide()
    'End Sub

    'Private Sub fanSignUpForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    '    mainDashboard.Show()
    'End Sub

    ' Define the normal, hover, and clicked colors.
    Dim normalColor As Color = Color.DeepSkyBlue
    Dim hoverColor As Color = Color.RoyalBlue
    Dim clickedColor As Color = Color.Navy

    ' Handle the MouseEnter event to change the color when the mouse hovers over the button.
    Private Sub submitbtn_MouseEnter(sender As Object, e As EventArgs) Handles submitbtn.MouseEnter
        submitbtn.BackColor = hoverColor
    End Sub

    ' Handle the MouseLeave event to change the color back to normal when the mouse leaves the button.
    Private Sub submitbtn_MouseLeave(sender As Object, e As EventArgs) Handles submitbtn.MouseLeave
        submitbtn.BackColor = normalColor
    End Sub

    ' Handle the MouseDown event to change the color when the button is clicked.
    Private Sub submitbtn_MouseDown(sender As Object, e As MouseEventArgs) Handles submitbtn.MouseDown
        submitbtn.BackColor = clickedColor
    End Sub

    ' Handle the MouseUp event to change the color back to hover or normal when the button is released.
    Private Sub submitbtn_MouseUp(sender As Object, e As MouseEventArgs) Handles submitbtn.MouseUp
        ' Check if the button is disposed.
        If submitbtn.IsDisposed Then
            Return
        End If

        ' Check if the mouse is still over the button.
        If submitbtn.ClientRectangle.Contains(submitbtn.PointToClient(Control.MousePosition)) Then
            submitbtn.BackColor = hoverColor
        Else
            submitbtn.BackColor = normalColor
        End If
    End Sub



End Class