<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainDashboard))
        eventBtn = New Button()
        signUpBtn = New Button()
        logInBtn = New Button()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        dateLabel = New Label()
        Label2 = New Label()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' eventBtn
        ' 
        eventBtn.BackColor = SystemColors.Control
        eventBtn.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        eventBtn.ForeColor = SystemColors.ActiveCaptionText
        eventBtn.Location = New Point(73, 495)
        eventBtn.Margin = New Padding(5, 4, 5, 4)
        eventBtn.Name = "eventBtn"
        eventBtn.Padding = New Padding(3, 2, 3, 2)
        eventBtn.Size = New Size(126, 30)
        eventBtn.TabIndex = 2
        eventBtn.Text = "Events"
        eventBtn.UseVisualStyleBackColor = False
        ' 
        ' signUpBtn
        ' 
        signUpBtn.BackColor = Color.Black
        signUpBtn.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        signUpBtn.ForeColor = SystemColors.ButtonHighlight
        signUpBtn.Location = New Point(1056, 21)
        signUpBtn.Margin = New Padding(3, 2, 3, 2)
        signUpBtn.Name = "signUpBtn"
        signUpBtn.Padding = New Padding(3, 2, 3, 2)
        signUpBtn.Size = New Size(87, 35)
        signUpBtn.TabIndex = 3
        signUpBtn.Text = "Sign up"
        signUpBtn.UseVisualStyleBackColor = False
        ' 
        ' logInBtn
        ' 
        logInBtn.BackColor = SystemColors.ActiveCaptionText
        logInBtn.Font = New Font("Sans Serif Collection", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logInBtn.ForeColor = SystemColors.ButtonHighlight
        logInBtn.Location = New Point(1183, 21)
        logInBtn.Margin = New Padding(3, 2, 3, 2)
        logInBtn.Name = "logInBtn"
        logInBtn.Padding = New Padding(3, 2, 3, 2)
        logInBtn.Size = New Size(87, 35)
        logInBtn.TabIndex = 4
        logInBtn.Text = "Log in"
        logInBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.WindowText
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Enabled = False
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1056, 158)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(3, 2, 3, 2)
        PictureBox1.Size = New Size(214, 210)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.LightSlateGray
        Label1.Location = New Point(73, 397)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 26)
        Label1.TabIndex = 9
        Label1.Text = "For Fans, By Fans"
        ' 
        ' dateLabel
        ' 
        dateLabel.AutoSize = True
        dateLabel.BackColor = Color.Transparent
        dateLabel.Font = New Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dateLabel.ForeColor = Color.White
        dateLabel.Location = New Point(88, 340)
        dateLabel.Name = "dateLabel"
        dateLabel.Size = New Size(0, 17)
        dateLabel.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(73, 443)
        Label2.Name = "Label2"
        Label2.Size = New Size(544, 44)
        Label2.TabIndex = 13
        Label2.Text = "Experience the best songs from your favourite artists and many " & vbCrLf & "more live performances."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Arial Narrow", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Crimson
        Label4.Location = New Point(73, 357)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 42)
        Label4.TabIndex = 15
        Label4.Text = "ENCORE"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.AccessibleRole = AccessibleRole.None
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(73, 237)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(101, 78)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' mainDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(1296, 598)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(dateLabel)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(logInBtn)
        Controls.Add(signUpBtn)
        Controls.Add(eventBtn)
        Margin = New Padding(3, 2, 3, 2)
        Name = "mainDashboard"
        Padding = New Padding(7, 6, 7, 6)
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Dashboard"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents eventBtn As Button
    Friend WithEvents signInBtn As Button
    Friend WithEvents logInBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents signUpBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dateLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox

End Class
