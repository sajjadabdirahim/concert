<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class artistForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(artistForm))
        artistTelephoneLabel = New Label()
        txtTelephone = New TextBox()
        citizenShipLabel = New Label()
        passwordLabel = New Label()
        genreLabel = New Label()
        emailLabel = New Label()
        fullNameLabel = New Label()
        submitbtn = New Button()
        txtCitizenship = New TextBox()
        txtPassword = New TextBox()
        txtEmail = New TextBox()
        txtGenre = New TextBox()
        txtArtistName = New TextBox()
        labelDetails = New Label()
        PrintDialog1 = New PrintDialog()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' artistTelephoneLabel
        ' 
        artistTelephoneLabel.AutoSize = True
        artistTelephoneLabel.Enabled = False
        artistTelephoneLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        artistTelephoneLabel.Location = New Point(79, 451)
        artistTelephoneLabel.Name = "artistTelephoneLabel"
        artistTelephoneLabel.Size = New Size(89, 19)
        artistTelephoneLabel.TabIndex = 13
        artistTelephoneLabel.Text = "Telephone"
        ' 
        ' txtTelephone
        ' 
        txtTelephone.Location = New Point(79, 472)
        txtTelephone.Margin = New Padding(3, 2, 3, 2)
        txtTelephone.Name = "txtTelephone"
        txtTelephone.Size = New Size(195, 23)
        txtTelephone.TabIndex = 6
        ' 
        ' citizenShipLabel
        ' 
        citizenShipLabel.AutoSize = True
        citizenShipLabel.Enabled = False
        citizenShipLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        citizenShipLabel.ForeColor = Color.Black
        citizenShipLabel.Location = New Point(79, 199)
        citizenShipLabel.Name = "citizenShipLabel"
        citizenShipLabel.Size = New Size(95, 19)
        citizenShipLabel.TabIndex = 11
        citizenShipLabel.Text = "Citizenship"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Enabled = False
        passwordLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        passwordLabel.Location = New Point(79, 387)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(86, 19)
        passwordLabel.TabIndex = 10
        passwordLabel.Text = "Password"
        ' 
        ' genreLabel
        ' 
        genreLabel.AutoSize = True
        genreLabel.Enabled = False
        genreLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        genreLabel.Location = New Point(79, 260)
        genreLabel.Name = "genreLabel"
        genreLabel.Size = New Size(55, 19)
        genreLabel.TabIndex = 9
        genreLabel.Text = "Genre"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Enabled = False
        emailLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        emailLabel.Location = New Point(79, 324)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(51, 19)
        emailLabel.TabIndex = 8
        emailLabel.Text = "Email"
        ' 
        ' fullNameLabel
        ' 
        fullNameLabel.AutoSize = True
        fullNameLabel.Enabled = False
        fullNameLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        fullNameLabel.ForeColor = Color.Black
        fullNameLabel.Location = New Point(79, 142)
        fullNameLabel.Name = "fullNameLabel"
        fullNameLabel.Size = New Size(97, 19)
        fullNameLabel.TabIndex = 7
        fullNameLabel.Text = "Artist Name"
        ' 
        ' submitbtn
        ' 
        submitbtn.BackColor = Color.DeepSkyBlue
        submitbtn.FlatStyle = FlatStyle.Flat
        submitbtn.ForeColor = Color.Black
        submitbtn.Location = New Point(113, 500)
        submitbtn.Margin = New Padding(3, 2, 3, 2)
        submitbtn.Name = "submitbtn"
        submitbtn.Size = New Size(107, 47)
        submitbtn.TabIndex = 6
        submitbtn.Text = "&Submit"
        submitbtn.UseVisualStyleBackColor = False
        ' 
        ' txtCitizenship
        ' 
        txtCitizenship.Location = New Point(79, 220)
        txtCitizenship.Margin = New Padding(3, 2, 3, 2)
        txtCitizenship.Name = "txtCitizenship"
        txtCitizenship.Size = New Size(195, 23)
        txtCitizenship.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(79, 408)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(195, 23)
        txtPassword.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(79, 345)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.MaxLength = 999
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(195, 23)
        txtEmail.TabIndex = 4
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(79, 281)
        txtGenre.Margin = New Padding(3, 2, 3, 2)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(195, 23)
        txtGenre.TabIndex = 3
        ' 
        ' txtArtistName
        ' 
        txtArtistName.Location = New Point(79, 163)
        txtArtistName.Margin = New Padding(3, 2, 3, 2)
        txtArtistName.Name = "txtArtistName"
        txtArtistName.Size = New Size(195, 23)
        txtArtistName.TabIndex = 1
        ' 
        ' labelDetails
        ' 
        labelDetails.AutoSize = True
        labelDetails.Enabled = False
        labelDetails.Font = New Font("Arial", 12F, FontStyle.Bold)
        labelDetails.ForeColor = Color.Black
        labelDetails.Location = New Point(97, 107)
        labelDetails.Name = "labelDetails"
        labelDetails.Size = New Size(193, 19)
        labelDetails.TabIndex = 0
        labelDetails.Text = "Enter your details below"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(396, 81)
        FlowLayoutPanel1.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.AccessibleRole = AccessibleRole.None
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 78)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(Label2)
        FlowLayoutPanel2.Controls.Add(Label4)
        FlowLayoutPanel2.Location = New Point(110, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(274, 78)
        FlowLayoutPanel2.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 20)
        Label1.TabIndex = 13
        Label1.Text = "CONCERT MANAGEMENT SYSTEM"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Enabled = False
        Label2.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(3, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 17)
        Label2.TabIndex = 13
        Label2.Text = "By Fans, For Fans"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Enabled = False
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(3, 37)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 18)
        Label4.TabIndex = 14
        Label4.Text = "Artist Sign Up Form"
        ' 
        ' artistForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(396, 558)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(artistTelephoneLabel)
        Controls.Add(txtTelephone)
        Controls.Add(txtArtistName)
        Controls.Add(citizenShipLabel)
        Controls.Add(labelDetails)
        Controls.Add(passwordLabel)
        Controls.Add(txtGenre)
        Controls.Add(genreLabel)
        Controls.Add(txtEmail)
        Controls.Add(emailLabel)
        Controls.Add(txtPassword)
        Controls.Add(fullNameLabel)
        Controls.Add(txtCitizenship)
        Controls.Add(submitbtn)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "artistForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Artist sign up form"
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents citizenShipLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents genreLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents fullNameLabel As Label
    Friend WithEvents submitbtn As Button
    Friend WithEvents txtCitizenship As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtArtistName As TextBox
    Friend WithEvents labelDetails As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents artistTelephoneLabel As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
