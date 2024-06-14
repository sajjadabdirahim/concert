

Public Class mainDashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles eventBtn.Click
        Dim eventForm As New eventsForm()

        eventForm.Show()


    End Sub

    Private Sub signUpBtn_Click(sender As Object, e As EventArgs) Handles signUpBtn.Click
        Dim strChoice As String
        Dim artistSignUp As New artistForm()
        Dim fanSignUp As New fanSignUpForm()

        strChoice = ""

        Do While Not (strChoice.ToLower = "artist" Or strChoice.ToLower = "fan")
            strChoice = InputBox("Choose Artist/Fan", "Fan/Artist Choice")
            If Not (strChoice.ToLower = "artist" Or strChoice.ToLower = "fan") Then
                MessageBox.Show("Wrong Choice! Enter Fan or Artist", "Input Error!")
            End If
        Loop

        If strChoice.ToLower = "artist" Then
            artistSignUp.Show()
        ElseIf strChoice.ToLower = "fan" Then
            fanSignUp.Show()

        End If
    End Sub

    Private Sub mainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateLabel.Text = Now()
    End Sub

    Private Sub logInBtn_Click(sender As Object, e As EventArgs) Handles logInBtn.Click
        Dim logIn As New logInForm()

        logIn.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

