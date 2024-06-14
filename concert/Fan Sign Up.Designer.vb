<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fanSignUpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fanSignUpForm))
        labelDetails = New Label()
        txtFirstName = New TextBox()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        txtTelephoneNumber = New TextBox()
        submitbtn = New Button()
        firstNameLabel = New Label()
        passwordLabel = New Label()
        emailLabel = New Label()
        telephoneLabel = New Label()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' labelDetails
        ' 
        labelDetails.AutoSize = True
        labelDetails.Enabled = False
        labelDetails.Font = New Font("Arial", 12F, FontStyle.Bold)
        labelDetails.ForeColor = Color.Black
        labelDetails.Location = New Point(50, 84)
        labelDetails.Name = "labelDetails"
        labelDetails.Size = New Size(193, 19)
        labelDetails.TabIndex = 0
        labelDetails.Text = "Enter your details below"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(69, 138)
        txtFirstName.Margin = New Padding(3, 2, 3, 2)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(195, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(72, 200)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(195, 23)
        txtEmail.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(72, 261)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.MaxLength = 999
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(195, 23)
        txtPassword.TabIndex = 3
        ' 
        ' txtTelephoneNumber
        ' 
        txtTelephoneNumber.Location = New Point(72, 331)
        txtTelephoneNumber.Margin = New Padding(3, 2, 3, 2)
        txtTelephoneNumber.Name = "txtTelephoneNumber"
        txtTelephoneNumber.Size = New Size(195, 23)
        txtTelephoneNumber.TabIndex = 4
        ' 
        ' submitbtn
        ' 
        submitbtn.BackColor = Color.DeepSkyBlue
        submitbtn.FlatAppearance.BorderSize = 0
        submitbtn.FlatStyle = FlatStyle.Flat
        submitbtn.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        submitbtn.ForeColor = Color.Black
        submitbtn.Location = New Point(101, 369)
        submitbtn.Margin = New Padding(3, 2, 3, 2)
        submitbtn.Name = "submitbtn"
        submitbtn.Size = New Size(107, 47)
        submitbtn.TabIndex = 5
        submitbtn.Text = "&Submit"
        submitbtn.UseVisualStyleBackColor = False
        ' 
        ' firstNameLabel
        ' 
        firstNameLabel.AutoSize = True
        firstNameLabel.Enabled = False
        firstNameLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        firstNameLabel.ForeColor = Color.Black
        firstNameLabel.Location = New Point(69, 110)
        firstNameLabel.Name = "firstNameLabel"
        firstNameLabel.Size = New Size(83, 19)
        firstNameLabel.TabIndex = 7
        firstNameLabel.Text = "Full name"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Enabled = False
        passwordLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        passwordLabel.ForeColor = Color.Black
        passwordLabel.Location = New Point(72, 233)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(86, 19)
        passwordLabel.TabIndex = 8
        passwordLabel.Text = "Password"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.Enabled = False
        emailLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        emailLabel.ForeColor = Color.Black
        emailLabel.Location = New Point(71, 172)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(51, 19)
        emailLabel.TabIndex = 9
        emailLabel.Text = "Email"
        ' 
        ' telephoneLabel
        ' 
        telephoneLabel.AutoSize = True
        telephoneLabel.Enabled = False
        telephoneLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        telephoneLabel.ForeColor = Color.Black
        telephoneLabel.Location = New Point(73, 298)
        telephoneLabel.Name = "telephoneLabel"
        telephoneLabel.Size = New Size(89, 19)
        telephoneLabel.TabIndex = 10
        telephoneLabel.Text = "Telephone"
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
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(370, 81)
        FlowLayoutPanel1.TabIndex = 12
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Label1)
        FlowLayoutPanel2.Controls.Add(Label2)
        FlowLayoutPanel2.Controls.Add(Label4)
        FlowLayoutPanel2.Location = New Point(110, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(248, 78)
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
        Label4.Size = New Size(134, 18)
        Label4.TabIndex = 14
        Label4.Text = "Fan Sign Up Form"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Enabled = False
        Label3.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 16)
        Label3.TabIndex = 13
        Label3.Text = "Fan Sign Up Form"
        ' 
        ' fanSignUpForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        ClientSize = New Size(370, 413)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(telephoneLabel)
        Controls.Add(Label3)
        Controls.Add(emailLabel)
        Controls.Add(labelDetails)
        Controls.Add(passwordLabel)
        Controls.Add(txtFirstName)
        Controls.Add(firstNameLabel)
        Controls.Add(txtEmail)
        Controls.Add(submitbtn)
        Controls.Add(txtPassword)
        Controls.Add(txtTelephoneNumber)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "fanSignUpForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fan Sign Up Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents labelDetails As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtTelephoneNumber As TextBox
    Friend WithEvents submitbtn As Button
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents telephoneLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
