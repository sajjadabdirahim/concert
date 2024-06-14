<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logInForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(logInForm))
        Label1 = New Label()
        cmboxUserTypeChoice = New ComboBox()
        passwordLabelLogIn = New Label()
        txtPassword = New TextBox()
        userName = New Label()
        submitbtn = New Button()
        txtEmail = New TextBox()
        loginLabel = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        PictureBox1 = New PictureBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Label2 = New Label()
        Label3 = New Label()
        FlowLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold)
        Label1.Location = New Point(83, 239)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 19)
        Label1.TabIndex = 10
        Label1.Text = "Choose between Fan or Artist"
        ' 
        ' cmboxUserTypeChoice
        ' 
        cmboxUserTypeChoice.FormattingEnabled = True
        cmboxUserTypeChoice.Items.AddRange(New Object() {"Artist", "Fan"})
        cmboxUserTypeChoice.Location = New Point(83, 260)
        cmboxUserTypeChoice.Margin = New Padding(3, 2, 3, 2)
        cmboxUserTypeChoice.Name = "cmboxUserTypeChoice"
        cmboxUserTypeChoice.Size = New Size(184, 23)
        cmboxUserTypeChoice.TabIndex = 3
        ' 
        ' passwordLabelLogIn
        ' 
        passwordLabelLogIn.AutoSize = True
        passwordLabelLogIn.Enabled = False
        passwordLabelLogIn.Font = New Font("Arial", 12F, FontStyle.Bold)
        passwordLabelLogIn.Location = New Point(83, 176)
        passwordLabelLogIn.Name = "passwordLabelLogIn"
        passwordLabelLogIn.Size = New Size(86, 19)
        passwordLabelLogIn.TabIndex = 9
        passwordLabelLogIn.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(83, 197)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(184, 23)
        txtPassword.TabIndex = 2
        ' 
        ' userName
        ' 
        userName.AutoSize = True
        userName.Cursor = Cursors.SizeNESW
        userName.Enabled = False
        userName.Font = New Font("Arial", 12F, FontStyle.Bold)
        userName.Location = New Point(83, 123)
        userName.Name = "userName"
        userName.Size = New Size(57, 19)
        userName.TabIndex = 7
        userName.Text = "Email:"
        ' 
        ' submitbtn
        ' 
        submitbtn.BackColor = Color.DeepSkyBlue
        submitbtn.FlatAppearance.BorderSize = 0
        submitbtn.FlatStyle = FlatStyle.Flat
        submitbtn.Font = New Font("Arial Narrow", 12F, FontStyle.Bold)
        submitbtn.ForeColor = Color.Black
        submitbtn.Location = New Point(110, 296)
        submitbtn.Margin = New Padding(3, 2, 3, 2)
        submitbtn.Name = "submitbtn"
        submitbtn.Size = New Size(107, 47)
        submitbtn.TabIndex = 4
        submitbtn.Text = "&Submit"
        submitbtn.UseVisualStyleBackColor = False
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(83, 146)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(184, 23)
        txtEmail.TabIndex = 1
        ' 
        ' loginLabel
        ' 
        loginLabel.AutoSize = True
        loginLabel.Enabled = False
        loginLabel.Font = New Font("Arial", 12F, FontStyle.Bold)
        loginLabel.Location = New Point(138, 84)
        loginLabel.Name = "loginLabel"
        loginLabel.Size = New Size(57, 19)
        loginLabel.TabIndex = 0
        loginLabel.Text = "Log In"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(PictureBox1)
        FlowLayoutPanel1.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(366, 81)
        FlowLayoutPanel1.TabIndex = 15
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
        FlowLayoutPanel2.Controls.Add(Label2)
        FlowLayoutPanel2.Controls.Add(Label3)
        FlowLayoutPanel2.Location = New Point(110, 3)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(248, 78)
        FlowLayoutPanel2.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Enabled = False
        Label2.Font = New Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(3, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(220, 20)
        Label2.TabIndex = 13
        Label2.Text = "CONCERT MANAGEMENT SYSTEM"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Enabled = False
        Label3.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(3, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 17)
        Label3.TabIndex = 13
        Label3.Text = "By Fans, For Fans"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' logInForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PowderBlue
        ClientSize = New Size(366, 360)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Controls.Add(cmboxUserTypeChoice)
        Controls.Add(passwordLabelLogIn)
        Controls.Add(loginLabel)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(userName)
        Controls.Add(submitbtn)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "logInForm"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log In"
        FlowLayoutPanel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents userName As Label
    Friend WithEvents submitbtn As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents loginLabel As Label
    Friend WithEvents passwordLabelLogIn As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmboxUserTypeChoice As ComboBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
